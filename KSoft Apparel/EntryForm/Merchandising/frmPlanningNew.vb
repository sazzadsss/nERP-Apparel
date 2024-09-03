Public Class frmPlanningNew

   
   
   
    
    Private Sub PlanningBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanningBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanningBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlanningNewDataSet)

        RefreshChart()

    End Sub

    Private Sub frmPlanningNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)

        Me.SewingTableAdapter.Fill(Me.PlanningNewDataSet.Sewing)

        Me.PlanningTableAdapter.Fill(Me.PlanningNewDataSet.Planning)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.SewingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlanningNewDataSet)
        RefreshChart()

    End Sub

    Private Sub CheckedComboBoxEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedComboBoxEdit1.EditValueChanged
        'If e.CloseMode = True Then

        If CheckedComboBoxEdit1.Properties.Items.Count <> 0 Then

            Dim s As String = ""
            Dim s1 As String = ""

            s = CheckedComboBoxEdit1.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            Me.PlanningBindingSource.Filter = "Line IN ('" & s1 & "')"
            Me.SewingBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)
            
            RefreshChart()


        End If
        'End If
    End Sub

    Private Sub RefreshChart()
        ChartControl1.RefreshData()
        ChartControl2.RefreshData()
    End Sub

End Class