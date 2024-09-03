Public Class frmPrintColor

   


    Private Sub frmPrintColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
        Me.PrintColorDataGridView.ReadOnly = True

        If CheckUserRights("Print Color").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Print Color").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If
    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            PrintColorBindingSource.AddNew()
            PrintColorDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.PrintColorBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PrintColorDataSet)
                PrintColorDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.PrintColorTableAdapter.FillByPrintColor(Me.PrintColorDataSet.PrintColor, SearchTextBox.Text.ToString)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If PrintColorBindingSource.Position > -1 Then
            PrintColorBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            PrintColorDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.PrintColorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintColorDataSet)
            PrintColorDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            PrintColorDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub


    Private Sub PrintColorDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PrintColorDataGridView.RowHeaderMouseDoubleClick

        If Me.PrintColorBindingSource.Position > -1 Then
            Dim row As PrintColorDataSet.PrintColorRow
            row = CType(CType(Me.PrintColorBindingSource.Current, DataRowView).Row, PrintColorDataSet.PrintColorRow)

            frmRecipe.PC_ID = row.PrintColorId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub PrintColorDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PrintColorDataGridView.CellContentClick

    End Sub
End Class