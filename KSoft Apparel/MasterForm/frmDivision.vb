Public Class frmDivision
    '-----------------------------------------------
    ''Imrul Kaesh, Date on: 22/05/2013, Dis:

    Private _DivisionId As Integer
    Public Property DivisionId() As Integer
        Get
            Return _DivisionId
        End Get
        Set(ByVal value As Integer)
            _DivisionId = value
        End Set
        ''-------------------------------------------
    End Property
    Private Sub DivisionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivisionBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.DivisionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DivisionDataSet)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        

    End Sub

    Private Sub frmDivision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)

        If CheckUserRights("Division").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DivisionBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub DivisionDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DivisionDataGridView.RowHeaderMouseDoubleClick
        '-----------------------------------------------
        ''Imrul Kaesh, Date on: 22/05/2013, Dis:when Double click Row Header on this grid then specific valu or data transfer entry part (frmOrderReceived)

        If Me.DivisionBindingSource.Position > -1 Then

            Dim row As DivisionDataSet.DivisionRow
            row = CType(CType(Me.DivisionBindingSource.Current, DataRowView).Row, DivisionDataSet.DivisionRow)

            Me.DivisionId = row.DivisionId

        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

        '-----------------------------------------------
    End Sub

End Class