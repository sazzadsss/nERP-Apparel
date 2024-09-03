Public Class frmSeason
    '-----------------------------------------------
    ''Imrul Kaesh, Date on: 22/05/2013, Dis:

    Private _SeasonId As Integer
    Public Property SeasonId() As Integer
        Get
            Return _SeasonId
        End Get
        Set(ByVal value As Integer)
            _SeasonId = value
        End Set
        ''-------------------------------------------
    End Property
    Private Sub SeasonBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeasonBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SeasonBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SeasonDataSet)

    End Sub

    Private Sub frmSeason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        If CheckUserRights("Season").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            SeasonBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub SeasonDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SeasonDataGridView.RowHeaderMouseDoubleClick
        '-----------------------------------------------
        ''Imrul Kaesh, Date on: 22/05/2013, Dis:when Double click Row Header on this grid then specific valu or data transfer entry part (frmOrderReceived)

        If Me.SeasonBindingSource.Position > -1 Then
            Dim row As SeasonDataSet.SeasonRow
            row = CType(CType(Me.SeasonBindingSource.Current, DataRowView).Row, SeasonDataSet.SeasonRow)
            Me.SeasonId = row.SeasonId
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        '-----------------------------------------------
    End Sub
End Class