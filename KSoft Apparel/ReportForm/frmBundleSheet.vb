Public Class frmBundleSheet
    Private _CPNId As Integer
    Public Property CPNId() As Integer
        Get
            Return _CPNId
        End Get
        Set(ByVal value As Integer)
            _CPNId = value
        End Set
    End Property

    Private Sub frmBundleSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CuttingNoTextBox.Text = ReadStringData("Select CuttingNo From CuttingProductionNew Where CuttingProductionNewId=" & Me.CPNId, cnn)
    End Sub

    Private Sub BundleSheetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BundleSheetButton.Click

        Me.CPNId = ReadIntegerData("Select Min(CuttingProductionNewId) From CuttingProductionNew Where CuttingNo='" & Trim(Me.CuttingNoTextBox.Text) & "'", cnn)

        If Me.CPNId > 0 Then

            Dim filterstring As String = "{CuttingProductionNew.CuttingProductionNewId} = " & Me.CPNId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BundleSheet
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            MessageBox.Show("Cutting No is not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
      
    End Sub

    Private Sub BundleStickerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BundleStickerButton.Click

        Me.CPNId = ReadIntegerData("Select Min(CuttingProductionNewId) From CuttingProductionNew Where CuttingNo='" & Trim(Me.CuttingNoTextBox.Text) & "'", cnn)

        If Me.CPNId > 0 Then
            Dim filterstring As String = "{CuttingProductionNew.CuttingProductionNewId} = " & Me.CPNId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BundleStickerPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else

            MessageBox.Show("Cutting No is not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim filterstring As String = "{CuttingProductionNew.CuttingProductionNewId} = " & Me.CPNId
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BundleSheet
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class