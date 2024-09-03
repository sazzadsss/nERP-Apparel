Public Class frmCompany

    Private Sub CompanyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompanyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CompanyDataSet)

    End Sub

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CompanyAddressTableAdapter.Fill(Me.CompanyDataSet.CompanyAddress)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

        If CheckUserRights("Company").CanEdit = False Then
            CompanyBindingNavigatorSaveItem.Enabled = False

        End If

    End Sub


End Class