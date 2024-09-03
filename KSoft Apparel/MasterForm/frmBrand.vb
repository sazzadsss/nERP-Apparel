Public Class frmBrand

    Private Sub frmBrand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.BrandDataGridView.ReadOnly = True

        ' Me.CategoryDataSet.Category.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.BrandDataSet.Brand.DepartmentIdColumn.DefaultValue = DepartmentId

        If CheckUserRights("Brand").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Brand").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If

    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            BrandBindingSource.AddNew()
            BrandDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.BrandBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BrandDataSet)
                BrandDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.BrandTableAdapter.FillByBrand(Me.BrandDataSet.Brand, SearchTextBox.Text, DepartmentId)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If BrandBindingSource.Position > -1 Then
            BrandBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            BrandDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.BrandBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BrandDataSet)
            BrandDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            BrandDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub

    
End Class