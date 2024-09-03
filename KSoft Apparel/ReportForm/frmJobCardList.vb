Public Class frmJobCardListDetails
    Dim filterstring As String

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub frmJobCardListDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    
    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged
        If OrderLookupBindingSource.Position > -1 Then


            'Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)


            Dim row As OrderLookupDataSet.OrderLookupRow
            row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)


            Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, row.ProgramNo)


            If row.IsIsMultiPartNull = False Then


                If row.IsMultiPart = True Then

                    MultipartComboBox.Visible = True
                    MultipartLabel.Visible = True
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

                Else

                    MultipartComboBox.Visible = False
                    MultipartLabel.Visible = False
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

                End If

            Else

                MultipartComboBox.Visible = False
                MultipartLabel.Visible = False
                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

            End If




           



        End If

    End Sub

    Private Sub OrderNoGridLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.TextChanged

        On Error Resume Next

        Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & OrderNoGridLookUpEdit.Text & "'", cnn)
        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.Text)
        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OrderId)

    End Sub

    Private Sub MultipartComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipartComboBox.SelectedIndexChanged

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click


        filterstring = "{FabricColor.FabricColorId} = " & FabricColorComboBox.SelectedValue & " and{Order.ProgramNo} = '" & OrderNoGridLookUpEdit.Text & "' and{Size.SizeCode} = '" & Me.SizeComboBox.SelectedValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Job_Card_list_Order_Color_Size
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class