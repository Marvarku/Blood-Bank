Imports System.Net.Mail
Public Class request_blood

    'send button
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        'Try
        '    Dim Smtp_Server As New SmtpClient
        '    Dim e_mail As New MailMessage()
        '    Smtp_Server.UseDefaultCredentials = False

        '    'Senders Gmail Username and password

        '    Smtp_Server.Credentials = New Net.NetworkCredential("joshuaberkoh19@gmail.com", "12345Dembaba")

        '    Smtp_Server.Port = 587
        '    Smtp_Server.EnableSsl = True

        '    'gmail smtp settings

        '    Smtp_Server.Host = "smtp.gmail.com"

        '    e_mail = New MailMessage()
        '    e_mail.From = New MailAddress(txtfrom.Text)
        '    e_mail.To.Add(cmbto.Text)
        '    e_mail.Subject = txtsubject.Text
        '    e_mail.IsBodyHtml = False
        '    e_mail.Body = txtmessage.Text
        '    Smtp_Server.Send(e_mail)
        '    MsgBox("Your Email Have Been Sent Succesfully")

        'Catch error_t As Exception
        '    MsgBox("Error When Sending Your Email, Whether Your Email Address Does Not Exist Or There Is No Network Connection")
        'End Try




        'try two(2)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False

            'Senders Gmail Username and password

            Smtp_Server.Credentials = New Net.NetworkCredential("koferkoh@outlook.com", "12345Dembaba")

            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True

            'Hotmail smtp settings

            Smtp_Server.Host = "smtp.outlook.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtfrom.Text) '("koferkoh@outlook.com")

            If cmbto.Text = "Accra Regional Hospital" Then
                e_mail.To.Add("joshuaberkoh830@yahoo.com")

            ElseIf cmbto.Text = "Komfo Anokye Teaching hospital" Then
                e_mail.To.Add("joshuaberkoh19@gmail.com")

            ElseIf cmbto.Text = "Koforidua Regional Hospital" Then
                e_mail.To.Add("essaquayson@gmail.com")

            ElseIf cmbto.Text = "37 Millitary Hospital" Then
                e_mail.To.Add("joshuaberkoh19@gmail.com")

            ElseIf cmbto.Text = "Ho Regional Hospital" Then
                e_mail.To.Add("joshuaberkoh19@gmail.com")
            End If
            ' e_mail.To.Add("joshuaberkoh19@gmail.com")
            e_mail.Subject = txtsubject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = txtmessage.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Your Email Have Been Sent Succesfully")

            txtsubject.Clear()
            txtmessage.Clear()

        Catch error_t As Exception
            MsgBox("Error When Sending Your Email, Whether Your Email Address Does Not Exist Or There Is No Network Connection")
        End Try
    End Sub

    'clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MsgBox("Are You Sure You Want To Clear The Form Data?") Then
            ' FromTextBox.Clear()
            cmbto.Text = ""
            txtmessage.Clear()
            txtsubject.Clear()
            cmbto.Focus()
        End If
    End Sub
End Class