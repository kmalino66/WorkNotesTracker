Public Class Form1
    Private Sub button_clear_Click(sender As Object, e As EventArgs) Handles button_clear.Click
        TextBox1.Text = "~"
        TextBox1.SelectionStart = TextBox1.Text.Length + 1
        TextBox1.Focus()
    End Sub

    Private Sub button_copy_Click(sender As Object, e As EventArgs) Handles button_copy.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = "~"
        TextBox1.SelectionStart = TextBox1.Text.Length + 1
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = 13 Then
            My.Computer.Keyboard.SendKeys("{~}")
        End If
    End Sub
End Class
