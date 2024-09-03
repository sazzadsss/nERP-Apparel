Public Class frmCuttingRunningProgram

    Private _vBranchId As Int64
    Public Property vBranchId() As Int64
        Get
            Return _vBranchId
        End Get
        Set(ByVal value As Int64)
            _vBranchId = value
        End Set
    End Property

    Private Sub CuttingRunningProgramBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingRunningProgramBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CuttingRunningProgramBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CuttingRunningProgramDataSet)

    End Sub

    Private Sub frmCuttingRunningProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Dim indx As Integer = Me.BranchBindingSource.Find("BranchId", Me.vBranchId)
        Me.BranchBindingSource.Position = indx


    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        On Error Resume Next

        Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)
        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.Text)
        Me.CuttingRunningProgramDataSet.CuttingRunningProgram.OrderIdColumn.DefaultValue = OrderId


    End Sub

    
    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged
        Me.CuttingRunningProgramTableAdapter.FillByBranchId(Me.CuttingRunningProgramDataSet.CuttingRunningProgram, BranchComboBox.SelectedValue)
        Me.CuttingRunningProgramDataSet.CuttingRunningProgram.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        Me.CuttingRunningProgramDataSet.CuttingRunningProgram.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Me.CuttingRunningProgramBindingSource.AddNew()

    End Sub
End Class