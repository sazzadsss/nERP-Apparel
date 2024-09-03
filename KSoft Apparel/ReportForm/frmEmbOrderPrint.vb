Public Class frmEmbOrderPrint
    Public EMBId As Integer
    Public Property _EmbId() As Integer
        Get
            Return EMBId
        End Get
        Set(ByVal value As Integer)
            EMBId = value
        End Set
    End Property

    Private Sub frmEmbOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim filterstring As String = String.Empty
        Me.EMBId = Me.EmbOrderNoGridLookUpEdit.EditValue

        filterstring = "{EmbOrder.EmbOrderId} = " & Me.EMBId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbroideryWorkOrder
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim filterstring As String = String.Empty

        filterstring = "{EmbOrder.EmbOrderId} = " & Me.EMBId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbroideryWorkOrder
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton2_Click(sender As Object, e As EventArgs) Handles ShowButton2.Click
        filterstring = "{EmbOrder.OrderId} = " & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbroideryWorkOrderProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class