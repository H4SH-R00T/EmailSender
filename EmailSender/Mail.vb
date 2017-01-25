Imports System.Net.Mail

Module Mail

    'inputs: user, pass, from, to, subject, message, server, port

    Public Function sendEmail(ByVal user As String, ByVal pass As String, ByVal from As String, ByVal recipient As String, ByVal subject As String, ByVal message As String, ByVal server As String, ByVal port As Integer) As Boolean
        Dim UserName As String = user
        Dim mail As MailMessage = New MailMessage
        Dim t As Boolean
        t = True

        mail.From = New MailAddress(UserName)
        mail.To.Add(New MailAddress(recipient))
        mail.Subject = subject
        mail.Body = message

        mail.IsBodyHtml = True

        Dim client As SmtpClient = New SmtpClient(server, port)
        client.EnableSsl = True
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential(UserName, pass)
        Try
            client.Send(mail)
        Catch ex As Exception
            t = False
        End Try

        Return t

    End Function
    'inputs: user, pass, from, to, subject, message, "smptp.gmail.com", 587
    Public Function sendEmail(ByVal user As String, ByVal pass As String, ByVal from As String, ByVal recipient As String, ByVal subject As String, ByVal message As String) As Boolean
        Dim UserName As String = user
        Dim mail As MailMessage = New MailMessage
        Dim t As Boolean
        t = True

        mail.From = New MailAddress(UserName)
        mail.To.Add(New MailAddress(recipient))
        mail.Subject = subject
        mail.Body = message

        mail.IsBodyHtml = True

        Dim client As SmtpClient = New SmtpClient("smtp.gmail.com", 587)
        client.EnableSsl = True
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential(UserName, pass)
        Try
            client.Send(mail)
        Catch ex As Exception
            t = False
        End Try

        Return t

    End Function
End Module
