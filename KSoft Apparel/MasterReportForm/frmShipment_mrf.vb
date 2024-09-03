Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmShipment_mrf
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


    Private Sub FrmShipment_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{vOrder.OrderId} = " & Me.OID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation_ProgramWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class