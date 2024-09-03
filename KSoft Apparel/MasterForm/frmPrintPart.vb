Public Class frmPrintPart

    Private Sub PrintPartBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPartBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PrintPartBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintPartDataSet)

    End Sub

    Private Sub frmPrintPart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)

        If CheckUserRights("Print Part").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            PrintPartBindingNavigatorSaveItem.Enabled = False

        End If

    End Sub
End Class