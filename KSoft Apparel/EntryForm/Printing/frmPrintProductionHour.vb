Public Class frmPrintProductionHour

    Private Sub PrintProductionHourBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintProductionHourBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.PrintProductionHourBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintProductionHourDataSet)

    End Sub

    Private Sub frmPrintProductionHour_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)

        Me.PrintProductionHourDataSet.PrintProductionHour.ProductionMonthIdColumn.DefaultValue = Me.ProductionMonthComboBox.SelectedValue
        Me.PrintProductionHourDataSet.PrintProductionHour.MakeInColumn.DefaultValue = Me.AreaComboBox.Text

        If CheckUserRights("Print Production Hourly").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            PrintProductionHourBindingNavigatorSaveItem.Enabled = False
        End If


    End Sub

   
   
    Private Sub ProductionMonthComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionMonthComboBox.SelectedIndexChanged

        Me.PrintProductionHourTableAdapter.FillByMonthAndArea(Me.PrintProductionHourDataSet.PrintProductionHour, ProductionMonthComboBox.SelectedValue, AreaComboBox.Text)

        Me.PrintProductionHourDataSet.PrintProductionHour.ProductionMonthIdColumn.DefaultValue = Me.ProductionMonthComboBox.SelectedValue
        Me.PrintProductionHourDataSet.PrintProductionHour.MakeInColumn.DefaultValue = Me.AreaComboBox.Text

    End Sub

    Private Sub AreaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaComboBox.SelectedIndexChanged

        Me.PrintProductionHourTableAdapter.FillByMonthAndArea(Me.PrintProductionHourDataSet.PrintProductionHour, ProductionMonthComboBox.SelectedValue, AreaComboBox.Text)

        Me.PrintProductionHourDataSet.PrintProductionHour.ProductionMonthIdColumn.DefaultValue = Me.ProductionMonthComboBox.SelectedValue
        Me.PrintProductionHourDataSet.PrintProductionHour.MakeInColumn.DefaultValue = Me.AreaComboBox.Text

    End Sub
End Class