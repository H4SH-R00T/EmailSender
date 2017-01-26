Imports System.Net.Mail

Module Mail

    'inputs: user, pass, from, to, subject, message, server, port, ssl

    Public Function sendEmail(ByVal user As String, ByVal pass As String, ByVal from As String, ByVal recipient As String, ByVal subject As String, ByVal message As String, ByVal server As String, ByVal port As Integer, ByVal ssl As Boolean) As String
        Dim UserName As String = user
        Dim mail As MailMessage = New MailMessage
        Dim t As Boolean
        t = True

        Try
            mail.From = New MailAddress(from)
            mail.To.Add(New MailAddress(recipient))
            mail.Subject = subject
            mail.Body = message

            mail.IsBodyHtml = True

            Dim client As SmtpClient = New SmtpClient(server, port)
            client.EnableSsl = ssl
            client.UseDefaultCredentials = False
            client.Credentials = New System.Net.NetworkCredential(UserName, pass)

            client.Send(mail)
        Catch ex As Exception
            Return ex.ToString
            t = False
        End Try

        If t Then Return "True"


    End Function
    'inputs: user, pass, from, to, subject, message, Google server
    Public Function sendEmail(ByVal user As String, ByVal pass As String, ByVal from As String, ByVal recipient As String, ByVal subject As String, ByVal message As String) As Boolean
        Dim UserName As String = user
        Dim mail As MailMessage = New MailMessage
        Dim t As Boolean
        t = True

        mail.From = New MailAddress(from)
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
