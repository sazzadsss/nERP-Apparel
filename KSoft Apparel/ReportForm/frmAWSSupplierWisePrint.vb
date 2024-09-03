

Public Class frmAWSSupplierWisePrint
    Dim filterstring As String = ""


    Private _AWSId As Integer
    Public Property AWSId() As Integer
        Get
            Return _AWSId
        End Get
        Set(ByVal value As Integer)
            _AWSId = value
        End Set
    End Property



    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
       
    End Sub

    Private Sub frmAWSSupplierWisePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AWSLookupTableAdapter.Fill(Me.AWSLookupDataSet.AWSLookup)

        If AWSId > 0 Then
            AWSNoLookUpEdit.EditValue = Me.AWSId

            filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

End Class