Public Class frmPrintOrderPrint
    Dim filterstring As String = ""
    Private _PWId As Integer
    Public Property PWId() As Integer
        Get
            Return _PWId
        End Get
        Set(ByVal value As Integer)
            _PWId = value
        End Set
    End Property



    Private Sub frmPrintOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)


        filterstring = "{PrintOrderNew.PrintOrderNewId} = " & Me.PWId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintWorkOrderNo
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Me.PrintOrderNoGridLookUpEdit.EditValue = Me.PWId



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.PWId = Me.PrintOrderNoGridLookUpEdit.EditValue

        filterstring = "{PrintOrderNew.PrintOrderNewId} = " & Me.PWId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintWorkOrderNo
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton2_Click(sender As Object, e As EventArgs) Handles ShowButton2.Click

        filterstring = "{PrintOrderNew.OrderId} = " & Me.ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintWorkOrderProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        filterstring = "{PrintOrderNew.OrderId} = " & Me.ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintWorkOrderProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class