Public Class frmGarments

    Private _GarmentId As Integer
    Public Property GarmentId() As Integer
        Get
            Return _GarmentId
        End Get
        Set(ByVal value As Integer)
            _GarmentId = value
        End Set

    End Property
    Private Sub GarmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.GarmentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GarmentDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmGarments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GarmentTableAdapter.Fill(Me.GarmentDataSet.Garment)

        If CheckUserRights("Garments Name").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            GarmentBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub GarmentDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GarmentDataGridView.RowHeaderMouseDoubleClick

        If Me.GarmentBindingSource.Position > -1 Then
            Dim row As GarmentDataSet.GarmentRow
            row = CType(CType(Me.GarmentBindingSource.Current, DataRowView).Row, GarmentDataSet.GarmentRow)
            Me.GarmentId = row.GarmentId

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

   
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.GarmentTableAdapter.FillByGarmentDescription(Me.GarmentDataSet.Garment, SearchTextBox.Text)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.GarmentDataSet.Garment.Columns("GarmentDescription").DefaultValue = Me.SearchTextBox.Text
    End Sub

End Class