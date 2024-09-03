Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmOrderPrint
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


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Me.ProgramNoGridLookUpEdit.EditValue = Me.OrderId

    End Sub
   

    Private Sub frmOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        'If blnMIS = False Then

        '    'Dim Index As Integer
        '    'Index = OrderLookupBindingSource.Find("ProgramNo", frmOrder.ProgramNoTextBox.Text)
        '    'OrderLookupBindingSource.Position = Index

        '    filterstring = "{Order.OrderId} = " & Me.OrderId

        '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint
        '    ShowReport(MyReport, filterstring, CrystalReportViewer1)



        'End If
        If Me.OrderId > 0 Then
            filterstring = "{Order.OrderId} = " & Me.OrderId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If DBNull.Value.Equals(ProgramNoGridLookUpEdit.EditValue) = True Then
            Exit Sub
        End If

        Me.OrderId = ProgramNoGridLookUpEdit.EditValue

        filterstring = "{Order.OrderId} = " & Me.OrderId
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

   
    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click

        'Dim MyObj As New clsExportCRPT
        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint

        'MyObj.SetCrystalReportFilePath(MyReport)
        'MyObj.SetPdfDestinationFilePath("E:\XYZ.pdf")
        'MyObj.SetRecordSelectionFormula("{Order.OrderId} = " & Me.OrderId)
        'MyObj.Transfer()

        filterstring = "{Order.OrderId} = " & Me.OrderId
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderPrint

        ShowReportExport(MyReport, filterstring, "OrderSheet")

    End Sub
End Class