Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass, from, recipient, subject, message, server, port
        user = TextBox1.Text
        pass = TextBox2.Text
        from = TextBox3.Text
        recipient = TextBox4.Text
        subject = TextBox5.Text
        message = TextBox6.Text


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox7.Enabled = Not TextBox7.Enabled
        TextBox8.Enabled = Not TextBox8.Enabled


    End Sub
End Class
