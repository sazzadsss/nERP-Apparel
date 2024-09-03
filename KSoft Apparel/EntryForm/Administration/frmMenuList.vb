Public Class frmMenuList

    Private Sub MenuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MenuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MenuDataSet)

    End Sub

    Private Sub frmMenuList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MenuTableAdapter.Fill(Me.MenuDataSet.Menu)

    End Sub

    Private Sub MenuBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBindingSource.PositionChanged

        If MenuBindingSource.Position > -1 Then

            Dim row As MenuDataSet.MenuRow
            row = CType(CType(Me.MenuBindingSource.Current, DataRowView).Row, MenuDataSet.MenuRow)

            MenuDataSet.Menu.PARENT_IDColumn.DefaultValue = row.PARENT_ID
            MenuDataSet.Menu.PARENT_NAMEColumn.DefaultValue = row.PARENT_NAME


        End If
       


    End Sub

    Private Sub MENU_CODETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENU_CODETextBox.TextChanged

        MENU_NAMETextBox.Text = MENU_CODETextBox.Text.ToString

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        MENU_CODETextBox.Focus()

    End Sub
End Class