Imports System.IO.Ports
Imports System.Threading

Public Class frmSendSMS
    Private Sub frmSendSMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As String = TextBox1.Text
        Dim message As String = TextBox2.Text
        _serialPort = New SerialPort("COM8", 115200)
        Thread.Sleep(100)
        _serialPort.Open()
        Thread.Sleep(100)
        _serialPort.Write("AT+CMGF=1" & vbCr)
        Thread.Sleep(100)
        _serialPort.Write("AT+CMGS=""" & number & """" & vbCrLf)
        Thread.Sleep(100)
        _serialPort.Write(message & ChrW(26))
        Thread.Sleep(300)
        Label1.Text = "Message sent !!"
        _serialPort.Close()
    End Sub
End Class