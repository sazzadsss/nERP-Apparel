Public Class frmPrintStatus

    Private Sub PrintStatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintStatusBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PrintStatusBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintStatusDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       

    End Sub

    Private Sub frmPrintStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.PrintStatusTableAdapter.Fill(Me.PrintStatusDataSet.PrintStatus)

        If CheckUserRights("Printing Status").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            PrintStatusBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Printing Status").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            PrintStatusBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Print Status For Sample"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                PrintStatusGridControl.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub
End Class