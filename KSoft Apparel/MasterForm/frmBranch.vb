Public Class frmBranch

    Private Sub frmBranch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If


    End Sub

   

    Private Sub frmBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.BranchDataGridView.ReadOnly = True

        If CheckUserRights("Branch").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Branch").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If

    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            BranchBindingSource.AddNew()
            BranchDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.BranchBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BranchDataSet)
                BranchDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.BranchTableAdapter.FillByBranchName(Me.BranchDataSet.Branch, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If BranchBindingSource.Position > -1 Then
            BranchBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub BranchDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            BranchDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.BranchBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BranchDataSet)
            BranchDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            BranchDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub

    Private Sub BranchDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BranchDataGridView.CellEndEdit
        ' Clear the row error in case the user presses ESC.   
        BranchDataGridView.Rows(e.RowIndex).ErrorText = String.Empty

    End Sub



    Private Sub BranchDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles BranchDataGridView.CellValidating
        If BranchDataGridView.Columns(e.ColumnIndex).Name = "Branch Name" Then
            If e.FormattedValue IsNot Nothing AndAlso _
                String.IsNullOrEmpty(e.FormattedValue.ToString()) Then

                BranchDataGridView.Rows(e.RowIndex).ErrorText = _
                    "Branch Name must not be empty"
                e.Cancel = True

            End If
        End If

    End Sub

    Private Sub BranchDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BranchDataGridView.CellContentClick

    End Sub
End Class



