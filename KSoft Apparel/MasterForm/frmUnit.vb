Public Class frmUnit

    Private Sub frmUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.UnitDataGridView.ReadOnly = True

        If CheckUserRights("Unit").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Unit").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If

    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            UnitBindingSource.AddNew()
            UnitDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.UnitBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.UnitDataSet)
                UnitDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        'On Error Resume Next
        'Me.UnitTableAdapter.FillByUnitName(Me.UnitDataSet.Unit, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If UnitBindingSource.Position > -1 Then
            UnitBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub UnitDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            UnitDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.UnitBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UnitDataSet)
            UnitDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            UnitDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub
    
End Class