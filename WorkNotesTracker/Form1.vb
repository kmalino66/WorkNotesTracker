Imports System.Data.SQLite

Public Class Form1

    Public dbConnection As New SQLiteConnection
    Public dbCmd As New SqliteCommand

    Private Sub button_clear_Click(sender As Object, e As EventArgs) Handles button_clear.Click
        TextBox1.Text = ""
        TextBox1.SelectionStart = TextBox1.Text.Length + 1
        TextBox1.Focus()
    End Sub

    Private Sub button_copy_Click(sender As Object, e As EventArgs) Handles button_copy.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        TextBox1.SelectionStart = TextBox1.Text.Length + 1

        populateComboBox()

    End Sub

    Public Function newTemplateHandler(ByVal name As String)
        Dim content As String = TextBox1.Text

        dbConnection.ConnectionString = My.Settings.TemplateConnection

        dbConnection.Open()
        dbCmd.Connection = dbConnection
        content = content.Replace("'", "''")
        dbCmd.CommandText = "insert into Templates(name, content) values ('" &
            name & "', '" &
            content & "');"

        dbCmd.ExecuteNonQuery()

        dbConnection.Close()

        'Add the new template to the list
        comboBox_templates.Items.Add(name)

        Return Nothing
    End Function

    Private Sub stripMenu_newTemplate_Click(sender As Object, e As EventArgs) Handles stripMenu_newTemplate.Click
        Dim diag As New NewTemplateDialogue
        diag.Show()

    End Sub

    Private Sub menuItem_loadTemplate_Click(sender As Object, e As EventArgs) Handles menuItem_loadTemplate.Click

        Dim selectedItem As String = comboBox_templates.Text

        If selectedItem IsNot "" AndAlso selectedItem IsNot Nothing Then

            dbConnection.ConnectionString = My.Settings.TemplateConnection

            dbConnection.Open()
            dbCmd.Connection = dbConnection
            dbCmd.CommandText = "select content from Templates where name like '" + selectedItem + "';"

            Dim reader As SQLiteDataReader = dbCmd.ExecuteReader
            reader.Read()

            TextBox1.Text = reader.GetString(0)

            reader.Close()

            dbConnection.Close()


        End If
    End Sub

    Public Function deleteSelectedTemplate()
        Dim selectedItem As String = comboBox_templates.Text

        dbConnection.ConnectionString = My.Settings.TemplateConnection
        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandText = "delete from Templates where name like '" + selectedItem + "';"
        dbCmd.ExecuteNonQuery()

        dbConnection.Close()

        comboBox_templates.Text = ""
        comboBox_templates.Items.Clear()
        populateComboBox()

        Return Nothing
    End Function

    Public Sub populateComboBox()
        Try
            'Get Template names, and add them to the combo box.
            dbConnection.ConnectionString = My.Settings.TemplateConnection

            dbConnection.Open()


            dbCmd.Connection = dbConnection
            dbCmd.CommandType = CommandType.Text

            'This code is magical, because it is in SQL
            dbCmd.CommandText = "select name from Templates;"

            Dim reader As SQLiteDataReader = dbCmd.ExecuteReader

            While reader.Read()
                Try

                    comboBox_templates.Items.Add(reader("name"))

                Catch ex As Exception

                End Try
            End While

            'Close the open stuffs 
            reader.Close()
            dbConnection.Close()
        Catch ex As Exception


        End Try

    End Sub

    Private Sub menuItem_delete_Click(sender As Object, e As EventArgs) Handles menuItem_delete.Click
        Dim diag As New DeleteConfirmDialogue
        diag.Show()
    End Sub
End Class