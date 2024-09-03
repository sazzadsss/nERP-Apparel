Public Class frmKnittingType
    Private _KniitingTypeId As Integer
    Public Property KnittingTypeId() As Integer
        Get
            Return _KniitingTypeId
        End Get
        Set(ByVal value As Integer)
            _KniitingTypeId = value
        End Set
    End Property

    Private Sub KnittingTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnittingTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KnittingTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KnittingTypeDataSet)

    End Sub

    Private Sub frmKnittingType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)

        'Start -------- Check and Set user rights

        If CheckUserRights("Knitting Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            KnittingTypeBindingNavigatorSaveItem.Enabled = False

        End If

        'End ------- Check and Set user rights


    End Sub

    Private Sub KnittingTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KnittingTypeDataGridView.CellContentClick

    End Sub

    Private Sub KnittingTypeDataGridView_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles KnittingTypeDataGridView.RowHeaderMouseDoubleClick

        Dim row As KnittingTypeDataSet.KnittingTypeRow
        row = CType(CType(Me.KnittingTypeBindingSource.Current, DataRowView).Row, KnittingTypeDataSet.KnittingTypeRow)

        Me.KnittingTypeId = row.KnittingTypeId
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If ToolStripButton1.Text = "Show All" Then
            Me.KnittingTypeTableAdapter.Fill(Me.KnittingTypeDataSet.KnittingType)
            ToolStripButton1.Text = "Hide Dicontinue"
        Else
            Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
            ToolStripButton1.Text = "Show All"
        End If


    End Sub

    Private Sub SearchToolStripTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripTextBox.TextChanged
        Me.KnittingTypeBindingSource.Filter = "KnittingType Like '%" & SearchToolStripTextBox.Text & "%'"
    End Sub
End Class