'Kyle Malinowski
'Created 3/26/2016
Public Class NewTemplateDialogue

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click

        'Validates if there is anything in the box when the button is clicked.
        If textBox_templateName.Text IsNot Nothing Then
            Dim name As String = textBox_templateName.Text
            Form1.newTemplateHandler(name)
            Me.Close()
        End If

    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub textBox_templateName_KeyUp(sender As Object, e As KeyEventArgs) Handles textBox_templateName.KeyUp
        If e.KeyCode = 13 Then
            button_ok_Click(sender, Nothing)
        End If
    End Sub
End Class