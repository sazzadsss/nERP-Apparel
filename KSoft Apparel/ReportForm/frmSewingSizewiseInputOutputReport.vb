Public Class frmSewingSizewiseInputOutputReport
    Private Sub OrderNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.EditValue)
    End Sub
    Private Sub frmSewingSizewiseInputOutputReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub ShowByProgramButton_Click(sender As Object, e As EventArgs) Handles ShowByProgramButton.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " and {FabricColor.FabricColorId} = " & FabricColorComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowSummeryButton_Click(sender As Object, e As EventArgs) Handles ShowSummeryButton.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " and {FabricColor.FabricColorId} = " & FabricColorComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.MultipleProgramTextBox.Text = String.Empty Then
            Me.MultipleProgramTextBox.Text = Me.FabricColorComboBox.Text
        Else
            Me.MultipleProgramTextBox.Text = Me.MultipleProgramTextBox.Text & ", " & Me.FabricColorComboBox.Text
        End If
    End Sub

    Private Sub AllBranch_Click(sender As Object, e As EventArgs) Handles AllBranch.Click
        'Multiful branch in (ET3,ET4,ET5,SAMPLE,QAL,Sub Con) 

        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)

        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " And {FabricColor.FabricColorName} like ['" & s1 & "']"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filterstring As String = "{CuttingProductionNewDetails.InputQuantity} > 0.00 and {Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Final
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{CuttingProductionNewDetails.InputQuantity} > 0.00 and {Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " and {FabricColor.FabricColorId} = " & FabricColorComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Final
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{CuttingProductionNewDetails.InputQuantity} > 0.00 and {Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " and {FabricColor.FabricColorId} = " & FabricColorComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Summery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Multiful branch in (ET3,ET4,ET5,SAMPLE,QAL,Sub Con) 

        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)

        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " And {FabricColor.FabricColorName} like ['" & s1 & "']"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Final
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim filterstring As String = "{CuttingProductionNewDetails.InputQuantity} > 0.00 and {Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Summery1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtSummeryReport1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class