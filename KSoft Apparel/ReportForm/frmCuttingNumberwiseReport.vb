Public Class frmCuttingNumberwiseReport

    Dim filterstring As String = String.Empty

    Private Sub frmCuttingNumberwiseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue & " and {FabricColor.FabricColorId} = " & Me.FabricColorComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingNumberwiseReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged
        OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.EditValue)
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

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingNumberwiseReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub MultipleProgramTextBox_TextChanged(sender As Object, e As EventArgs) Handles MultipleProgramTextBox.TextChanged

    End Sub
End Class