﻿Public Class frmProgramFullAndFinal_mrf
    Private _OID As Integer

    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Dim filterstring As String = ""


    Private Sub FrmProgramFullAndFinal_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.OID > 0 Then

            filterstring = "{Order.OrderId} = " & Me.OID
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramFullandFinal

            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If
    End Sub
End Class