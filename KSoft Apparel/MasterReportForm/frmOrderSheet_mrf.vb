﻿Public Class frmOrderSheet_mrf
    Dim filterstring As String = ""
    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property


    Private Sub FrmOrderSheet_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.OrderId > 0 Then
            filterstring = "{Order.OrderId} = " & Me.OrderId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If
    End Sub
End Class