Imports System
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Collections
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Globalization

Public Class frmMailingAddress
    Private Sub frmMailingAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.MailAddressTableAdapter.Fill(Me.EmailAddressDataSet.MailAddress)

        EmailTextBox.Text = My.Settings.FromMail
        EmailHostTextBox.Text = My.Settings.Host
        PortTextBox.Text = My.Settings.Port

        If My.Settings.SSL = "True" Then
            SSLCheckBox.Checked = True
        Else
            SSLCheckBox.Checked = False
        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try
            Me.Validate()
            Me.MailAddressBindingSource.EndEdit()
            Me.MailAddressTableAdapter.Update(Me.EmailAddressDataSet.MailAddress)

            My.Settings.FromMail = EmailTextBox.Text
            My.Settings.Host = EmailHostTextBox.Text
            My.Settings.Port = PortTextBox.Text
            If SSLCheckBox.Checked Then
                My.Settings.SSL = "True"
            Else
                My.Settings.SSL = "False"
            End If

            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub SendProdMailButton_Click(sender As Object, e As EventArgs) Handles SendProdMailButton.Click
        SendProdMail(EmailHostTextBox.Text, PortTextBox.Text, True, EmailTextBox.Text, PassTextBox.Text, DateEdit1.DateTime.Date)
    End Sub
    Public Shared Sub SendProdMail(ByVal Host As String, ByVal Port As String, ByVal SSL As Boolean, ByVal FromEmail As String, ByVal Pass As String, ByVal PDate As Date)
        'Dim cnn As String = ConfigurationManager.ConnectionStrings("KSoft_ApparelConnectionString").ConnectionString
        Dim MailBody As String = String.Empty
        Dim SMSBody As String = String.Empty
        Dim culture As CultureInfo = New CultureInfo("en-IN")
        Dim list_emails As ArrayList = New ArrayList()
        Dim list_mobile As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim md As Integer = 1
        Dim email As String = String.Empty
        Dim mobile As String = String.Empty
        Using conn1 As SqlConnection = New SqlConnection()
            conn1.ConnectionString = cnn
            conn1.Open()
            Dim cmd_Email As SqlCommand = New SqlCommand("Select MailAddress,MobileNo from MailAddress Where IsActive=1 And MailAddressId in (Select MailAddressId From MailAddress Where MailType='Last Day Production')", conn1)
            Dim read_Email As SqlDataReader = cmd_Email.ExecuteReader()
            While read_Email.Read()
                email = read_Email.GetValue(0).ToString()
                mobile = read_Email.GetValue(1).ToString()
                list_emails.Add(email)
                list_mobile.Add(mobile)
                i = i + 1 - 1
            End While

            read_Email.Close()
        End Using

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = cnn
            conn.Open()
            Dim command As SqlCommand = New SqlCommand("Execute LastDayProductionStatus @0,'Mail',0", conn)
            Dim datetime As DateTime = DateTime.Now
            command.Parameters.Add(New SqlParameter("0", PDate))
            Using reader As SqlDataReader = command.ExecuteReader()
                Dim HeaderString As String = "<!DOCTYPE html>" & "<html>" & "<head>" & "<style>" & "table, th, td {" & "border: 1px solid black;" & "border-collapse:collapse;" & "}" & "th, td {" & "padding: 5px;" & "text-align: left;" & "}" & "</style>" & "</head>" & "<body>"
                MailBody = MailBody + HeaderString
                SMSBody = "NCL Production:" & vbLf
                MailBody = MailBody & "<table Style=" & "border: 1px solid blackborder - collapse: collapse;" & ">" & vbLf
                MailBody = MailBody & "<tr><td colspan="" 6 "" style=""background-color:Gray;color:White;"" > <b>NCL Production Date on  " + PDate.Date.AddDays(0).ToShortDateString() & "</b></td></tr>" & vbLf
                MailBody = MailBody & "<tr style=""background-color:Gray;color:White;text-align: center;"" ><td> <b>Production Type</b></td><td> <b>Count</b></td><td style=""text-align:center;""> <b>Actual</b></td><td style=""text-align:center;""><b>Value</b></td><td style=""text-align:center;""><b>Target</b></td><td style=""text-align:center;""><b>%</b></td></tr>" & vbLf

                While reader.Read()
                    Dim ap As Decimal = 0

                    If reader.GetDecimal(2) > 0 AndAlso reader.GetDecimal(3) > 0 AndAlso Not reader.GetDecimal(3).Equals(Nothing) Then
                        ap = reader.GetDecimal(3) / reader.GetDecimal(2) * 100
                    End If

                    If Convert.ToInt32(ap) = 0 Then
                        MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " & String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:center;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(5)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td style=""text-align:right;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(6)) & "</td><td style=""text-align:right;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</td><td style=""text-align:center;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(7)) & "</td></tr>" & vbLf
                    Else
                        MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " & String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:center;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(5)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td style=""text-align:right;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(6)) & "</td><td style=""text-align:right;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</td><td style=""text-align:center;"">" + String.Format(culture, "{0:##,##,##,###.####}", reader(7)) + Convert.ToInt32(ap).ToString() & "%</b></td></tr>" & vbLf
                    End If

                    SMSBody = SMSBody + reader(4).ToString() & " : " + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & vbLf
                End While

                MailBody = MailBody & "<tr><td colspan="" 6 "" style=""background-color:Gray;color:White;""><b>This is genereted by nERP Solutions. Powered by: Norban Group of Companies.</b></td></tr>" & vbLf
                MailBody = MailBody & "</table></body>" & vbLf
            End Using
        End Using


        Dim from As MailAddress = New MailAddress(FromEmail)
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = Host
        smtp.Port = Port
        smtp.Credentials = New NetworkCredential(FromEmail, Pass)
        smtp.EnableSsl = SSL
        For Each email_to As String In list_emails
            'Console.WriteLine("Mail To")
            Dim [to] As MailAddress = New MailAddress(email_to)
            'Console.WriteLine([to])
            Dim mail As MailMessage = New MailMessage(from, [to])
            mail.Subject = "NCL Production Status on " & PDate.ToShortDateString()
            mail.Body = MailBody
            'Console.WriteLine("Sending email...")
            ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
            mail.IsBodyHtml = True
            smtp.Send(mail)
            'Console.WriteLine("Send Succesfully")

        Next
        MessageBox.Show("The mail has been send successfully")
        'For Each mobile_no As String In list_mobile
        '    sendprodsms(SMSBody, mobile_no)
        'Next
    End Sub





    Public Shared Sub sendprodsms(ByVal message As String, ByVal no As String)
        Try
            Dim client As WebClient = New WebClient()
            Dim uid As String = "nerpsolutions"
            Dim password As String = "Password"
            Dim baseURL As String = "https://cmp.grameenphone.com/gpcmpbulk/messageplatform/controller.home?username=" & uid & "&password=" + password & "&apicode=5&msisdn=" & no & "&countrycode=880&cli=Nerp&messagetype=1&message=" & message & "&messageid=0"
            client.OpenRead(baseURL)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SendProdSMSButton.Click
        MessageBox.Show("Under Build")
    End Sub

    Private Sub PrintSimpleButton_Click(sender As Object, e As EventArgs) Handles PrintSimpleButton.Click
        ShowForm(frmEmailSMSUserList)
    End Sub

    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        If SelectAllButton.Text = "&Select All" Then

            For Each drv As DataRowView In Me.MailAddressBindingSource.List
                drv!IsActive = True
            Next

            Me.MailAddressBindingSource.ResetBindings(True)
            SelectAllButton.Text = "&Deselect All"
        Else
            For Each drv As DataRowView In Me.MailAddressBindingSource.List
                drv!IsActive = False
            Next

            Me.MailAddressBindingSource.ResetBindings(True)
            SelectAllButton.Text = "&Select All"
        End If
    End Sub
End Class