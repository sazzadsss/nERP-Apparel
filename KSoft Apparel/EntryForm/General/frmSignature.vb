Public Class frmSignature

    Private Sub SignatureBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignatureBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SignatureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SignatureDataSet)

    End Sub

    Private Sub frmSignature_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

        Me.SignatureTableAdapter.Fill(Me.SignatureDataSet.Signature)
        If CheckUserRights("Signature").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            SignatureBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Signature").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            SignatureBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub

End Class