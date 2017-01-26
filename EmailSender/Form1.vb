Imports Mail

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass, from, recipient, subject, message, server, port, ssl
        user = TextBox1.Text
        pass = TextBox2.Text
        from = TextBox3.Text
        recipient = TextBox4.Text
        subject = TextBox5.Text
        message = TextBox6.Text
        server = "smtp.gmail.com"
        port = 587
        ssl = True

        If CheckBox1.Checked Then
            server = TextBox7.Text
            port = (TextBox8.Text)
            ssl = CheckBox2.Checked
        End If

        Dim result = Mail.sendEmail(user, pass, from, recipient, subject, message, server, port, ssl)
        If result = "True" Then MsgBox("Successfully sent!") Else Label11.Text = result
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox7.Enabled = Not TextBox7.Enabled
        TextBox8.Enabled = Not TextBox8.Enabled
        CheckBox2.Enabled = Not CheckBox2.Enabled

    End Sub
End Class
