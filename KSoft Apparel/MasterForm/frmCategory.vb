Public Class frmCategory

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)
        Me.CategoryDataGridView.ReadOnly = True

        Me.CategoryDataSet.Category.DepartmentIdColumn.DefaultValue = DepartmentId


    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked

        If NewLinkLabel.Text = "Add" Then

            CategoryBindingSource.AddNew()
            CategoryDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try

                Me.Validate()
                Me.CategoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CategoryDataSet)
                CategoryDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"

            Catch ex As Exception

                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")

            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.CategoryTableAdapter.FillByCategoryName(Me.CategoryDataSet.Category, SearchTextBox.Text, DepartmentId)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If CategoryBindingSource.Position > -1 Then

            CategoryBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"

        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub
    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        If EditLinkLabel.Text = "Edit" Then

            CategoryDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"

        Else

            Me.Validate()
            Me.CategoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CategoryDataSet)
            CategoryDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            CategoryDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"

        End If

    End Sub

    Private Sub CategoryDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CategoryDataGridView.RowHeaderMouseDoubleClick

        Dim row As CategoryDataSet.CategoryRow
        row = CType(CType(Me.CategoryBindingSource.Current, DataRowView).Row, CategoryDataSet.CategoryRow)

        Me.CategoryId = row.CategoryId
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()




    End Sub

    Private _CategoryId As Integer
    Public Property CategoryId() As Integer
        Get
            Return _CategoryId
        End Get
        Set(ByVal value As Integer)
            _CategoryId = value
        End Set
    End Property


End Class