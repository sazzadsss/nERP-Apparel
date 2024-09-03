Public Class frmYarnAllocation

    Private Sub SplitContainer4_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub frmYarnAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.YarnAllocationGMTTableAdapter.Fill(Me.FabricBOMDataSet.YarnAllocationGMT)



        Me.UserTableAdapter.Fill(Me.UserDataSet.User)

        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)

        'Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)


        If UserLevel = 1 Then
            Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
        Else
            Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
        End If

        'Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)

        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.SupplierTableAdapter.FillBySupplierType(Me.SupplierDataSet.Supplier, "Fabrics")


        If UserLevel = 1 Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Else
            Me.OrderLookupTableAdapter.FillByUserId(Me.OrderLookupDataSet.OrderLookup, UserId)
        End If


        Me.FabricBOMDataSet.FabricBOM.SupplierIdColumn.DefaultValue = 39
        Me.FabricBOMDataSet.FabricBOM.FabricBookingDateColumn.DefaultValue = Today()



        'If UserLevel = 1 Then
        '    Me.FabricBOMTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOM)
        'Else
        '    Me.FabricBOMTableAdapter.FillByUserId(Me.FabricBOMDataSet.FabricBOM, UserId)
        'End If

        DisableControl(Me.SplitContainer1)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        If FabricBOMIdSearchBindingSource.Position > -1 Then

            Dim row As FabricBOMIdSearchDataSet.FabricBOMIdSearchRow
            row = CType(CType(Me.FabricBOMIdSearchBindingSource.Current, DataRowView).Row, FabricBOMIdSearchDataSet.FabricBOMIdSearchRow)

            Me.OrderLookupTableAdapter.FillByFabricBOMId(Me.OrderLookupDataSet.OrderLookup, GridLookUpEdit1.EditValue)
            Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails)
            Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, row.FabricBOMId)
            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = row.OrderId
            Me.FabricTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.Fabric, Val(FabricBOMIdLabel1.Text))
            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, row.OrderId)

            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & row.OrderId, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & row.OrderId & " Group By POGroup", cnn)

            OrderIdGridLookUpEdit.Enabled = False
            FDCheckEdit.Checked = FDStatus()

        End If
    End Sub
    Function FDStatus() As Boolean
        Dim FD As Boolean = False

        Dim FFBCount As Integer = ReadIntData("Select Count(*) From FinishFabricBooking Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ") And AmendmentNo=" & Me.AmendmentNoSpinEdit.EditValue, cnn)

        If FFBCount = 1 Then
            FD = True
        Else
            FD = False
        End If

        Return FD

    End Function
End Class