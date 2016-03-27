Public Class DeleteConfirmDialogue
    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Form1.deleteSelectedTemplate()
        Me.Close()
    End Sub
End Class