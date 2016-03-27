Public Class NewTemplateDialogue

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Dim name As String = textBox_templateName.Text

        Form1.newTemplateHandler(name)

        Me.Close()
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub
End Class