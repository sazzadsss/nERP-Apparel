﻿Public Class frmShipmentBalance_mrf
    Dim filterstring As String = ""
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property


    Private Sub FrmShipmentBalance_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{vOrder.OrderId} =" & Me.OID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactDetailsbyprogram

        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class