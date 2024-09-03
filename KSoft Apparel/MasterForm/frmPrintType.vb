Imports System.Windows.Forms

Public Class frmPrintType

    

    Private Sub frmPrintType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)

        If CheckUserRights("Print Type").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Print Type").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If
    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            PrintTypeBindingSource.AddNew()
            PrintTypeDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.PrintTypeBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PrintTypeDataSet)
                PrintTypeDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        'On Error Resume Next
        'Me.PrintTypeTableAdapter.FillByPrintType(Me.PrintTypeDataSet.PrintType, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If PrintTypeBindingSource.Position > -1 Then
            PrintTypeBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            PrintTypeDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.PrintTypeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintTypeDataSet)
            PrintTypeDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            PrintTypeDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub

    Private Sub PrintTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PrintTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintTypeDataSet)

    End Sub
End Class
