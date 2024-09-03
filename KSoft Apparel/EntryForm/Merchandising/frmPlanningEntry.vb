Imports System.Windows.Forms

Public Class frmPlanningEntry

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmPlanningEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.PlanningTableAdapter.Fill(Me.PlanningNewDataSet.Planning)



    End Sub

    Private Sub PlanningBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanningBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanningBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlanningNewDataSet)

    End Sub

    
End Class
