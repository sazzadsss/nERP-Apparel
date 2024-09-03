Public Class frmDestination



    Private _DestinationId As Integer
    Public Property DestinationId() As Integer
        Get
            Return _DestinationId
        End Get
        Set(ByVal value As Integer)
            _DestinationId = value
        End Set
    End Property



    Private Sub DestinationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestinationBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DestinationBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DestinationDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmDestination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)

        If CheckUserRights("Destination").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DestinationBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub DestinationDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DestinationDataGridView.RowHeaderMouseDoubleClick

        If DestinationBindingSource.Position > -1 Then

            Dim row As DestinationDataSet.DestinationRow
            row = CType(CType(Me.DestinationBindingSource.Current, DataRowView).Row, DestinationDataSet.DestinationRow)

            Me.DestinationId = row.DestinationId
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If
       

    End Sub
End Class