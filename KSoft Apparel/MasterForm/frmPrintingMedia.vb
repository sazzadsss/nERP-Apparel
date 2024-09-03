Public Class frmPrintingMedia

    'Private Sub PrintingMediaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.PrintingMediaBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.MediaDataSet)

    'End Sub

    Private Sub frmPrintingMedia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.PrintingMediaDataGridView.ReadOnly = True

        'Me.IssueDataSet.Issue.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.MediaDataSet.PrintingMedia.DepartmentIdColumn.DefaultValue = DepartmentId

        If CheckUserRights("Printing Media").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Printing Media").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If

    End Sub

    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            PrintingMediaBindingSource.AddNew()
            PrintingMediaDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.PrintingMediaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MediaDataSet)
                PrintingMediaDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.PrintingMediaTableAdapter.FillByPrintingMediaName(Me.MediaDataSet.PrintingMedia, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If PrintingMediaBindingSource.Position > -1 Then
            PrintingMediaBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            PrintingMediaDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.PrintingMediaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MediaDataSet)
            PrintingMediaDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            PrintingMediaDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub
End Class