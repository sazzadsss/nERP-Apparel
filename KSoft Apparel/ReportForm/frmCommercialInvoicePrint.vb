Public Class frmCommercialInvoicePrint
    Private _CIID As Integer
    Public Property CIID() As Integer
        Get
            Return _CIID
        End Get
        Set(ByVal value As Integer)
            _CIID = value
        End Set
    End Property

    Private Sub frmCommercialInvoicePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CommercialInvoiceLookUpTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookUp)
        If Me.CIID > 0 Then
            Me.InvoiceNoGridLookUpEdit.EditValue = Me.CIID

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceCommonPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If FormatComboBox.Text = "Primark" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoicePrimarkPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf FormatComboBox.Text = "MGB" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceMGBPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf FormatComboBox.Text = "C&A" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceCAPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf FormatComboBox.Text = "Centerline" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceCenterlinePrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf FormatComboBox.Text = "GMS" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceGMSPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf FormatComboBox.Text = "Debenhams" Then

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceDebPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim filterstring As String = ""
            filterstring = "{CommercialInvoiceMain.CommercialInvoiceMainId}=" & Me.InvoiceNoGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CommercialInvoiceCommonPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub
End Class