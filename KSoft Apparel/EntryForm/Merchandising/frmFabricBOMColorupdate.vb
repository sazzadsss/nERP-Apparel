Public Class frmFabricBOMColorupdate
    Private _FBID As Integer
    Public Property FBID() As Integer
        Get
            Return _FBID
        End Get
        Set(ByVal value As Integer)
            _FBID = value
        End Set
    End Property
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub frmFabricBOMColorupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FabricBOMColorListTableAdapter.Fill(Me.FabricBOMColorListDataSet.FabricBOMColorList, Me.FBID)
        Dim OID As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & Me.FBID, cnn)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OID)

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click


        If Me.FabricBOMColorListBindingSource.Position > -1 Then

            Dim row As FabricBOMColorListDataSet.FabricBOMColorListRow
            row = CType(CType(Me.FabricBOMColorListBindingSource.Current, DataRowView).Row, FabricBOMColorListDataSet.FabricBOMColorListRow)

            frmFabricBooking_Bulk.PrefabricColorId = row.FabricColorId
            frmFabricBooking_Bulk.PreGMTColorId = row.GarmentsColorId
            frmFabricBooking_Bulk.PreFabColorReference = row.FabricColorReference
            frmFabricBooking_Bulk.PreFabColorCode = row.ColorCode
            frmFabricBooking_Bulk.NewFabricColorId = NewFabColorGridLookUpEdit.EditValue
            frmFabricBooking_Bulk.NewGMTColorId = NewGMTColorGridLookUpEdit.EditValue
            frmFabricBooking_Bulk.NewFabColorRerence = NewFabColorReferenceTextBox.Text
            frmFabricBooking_Bulk.NewFabColorCode = NewFabColorCodeTextBox.Text


            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            Me.Close()



        End If




    End Sub

    Private Sub FabricBOMColorListGridControl_Click(sender As Object, e As EventArgs) Handles FabricBOMColorListGridControl.Click

    End Sub

    Private Sub NewGMTColorGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles NewGMTColorGridLookUpEdit.EditValueChanged
        On Error Resume Next

        NewFabColorGridLookUpEdit.EditValue = NewGMTColorGridLookUpEdit.EditValue

    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class