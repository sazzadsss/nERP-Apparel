Public Class frmComposition

    Private Sub CompositionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompositionBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CompositionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CompositionDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

       

    End Sub

    Private Sub frmComposition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CompositionDetailsTableAdapter.Fill(Me.CompositionDataSet.CompositionDetails)
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, 16)

        If CheckUserRights("Composition").CanEdit = False Then

            AddNewToolStripButton.Enabled = False
            CompositionBindingNavigatorSaveItem.Enabled = False


        End If

    End Sub

    
    Private Sub AddNewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripButton.Click
        Me.CompositionBindingSource.AddNew()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If ToolStripButton1.Text = "Show All" Then
            Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
            ToolStripButton1.Text = "Hide Discontine"
        Else
            Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
            ToolStripButton1.Text = "Show All"
        End If

    End Sub

   
    Private Sub SearchToolStripTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripTextBox.TextChanged
        Me.CompositionBindingSource.Filter = "Composition Like '%" & SearchToolStripTextBox.Text & "%' "
    End Sub
End Class