Imports System.Windows.Forms

Public Class frmCPTemplate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Save()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CP_TemplateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP_TemplateBindingNavigatorSaveItem.Click
        Save()
        

    End Sub

    Private Sub frmCPTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CP_TemplateTableAdapter.Fill(Me.CPTemplateDataSet.CP_Template)

    End Sub
    Private Sub Save()
        Try
            Me.Validate()
            Me.CP_TemplateBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CPTemplateDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
