Imports System.Data.SqlClient

Public Class SewingInput
    Private Sub SewingInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.SewingInputDataSet.SewingInput.SewingInputDateColumn.DefaultValue = Me.DateTimePicker1.Text
        Me.SewingInputDataSet.SewingInput.BranchIdColumn.DefaultValue = Me.BranchComboBox.SelectedValue


        'If CheckUserRights("Finishing Input").CanEdit = False Then

        '    SewingInputBindingNavigatorSaveItem.Enabled = False

        'End If
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If SewingInputBindingSource.Position > -1 Then
            Exit Sub
        End If


        Dim row As OrderColorPOLookupDataSet.OrderColorPOLookupRow
        row = CType(CType(Me.OrderColorPOLookupBindingSource.Current, DataRowView).Row, OrderColorPOLookupDataSet.OrderColorPOLookupRow)


        Using connection As New SqlConnection(cnn)

            Dim command As New SqlCommand("Select SizeId,OrderQuantity From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId, connection)

            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As FinishingInputDataSet.FinishingInputRow = Me.SewingInputDataSet.SewingInput.NewRow()
                newRow.OrderDetailsId = row.OrderDetailsId
                newRow.SizeId = reader("SizeId")
                newRow.InputQuantity = 0
                newRow.OrderQuantity = reader("OrderQuantity")
                Dim TTLInputQuantity = ReadData("Select Sum(InputQuantity) As TTLQuantity From SewingInput Where OrderDetailsId=" & row.OrderDetailsId & "And SizeId=" & reader("SizeId"), cnn)
                newRow.BalanceQuantity = reader("OrderQuantity") - TTLInputQuantity
                newRow.Remarks = "-"
                newRow.TTLInputQuantity = TTLInputQuantity
                Me.SewingInputDataSet.SewingInput.Rows.Add(newRow)

            End While

            reader.Close()

        End Using
    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged
        On Error Resume Next

        Me.SewingInputTableAdapter.Fill(Me.SewingInputDataSet.SewingInput, BranchComboBox.SelectedValue, 0, DateTimePicker1.Text)

        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.EditValue)
        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, ProgramNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        Me.OrderColorPOLookupTableAdapter.FillBy(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, FabricColorComboBox.SelectedValue, ProgramNoGridLookUpEdit.EditValue)

        CalculatePOQuantity()
    End Sub
    Private Sub CalculatePOQuantity()

        If OrderColorPOLookupBindingSource.Position > -1 Then


            For Each drv As DataRowView In OrderColorPOLookupBindingSource.List

                Dim OrderQuantity As Integer = ReadIntegerData("Select OrderQuantity From vOrder Where OrderDetailsId=" & drv!OrderDetailsId, cnn)
                Dim InputQuantity As Integer = ReadData("Select Sum(InputQuantity) as TTLInput From SewingInput Where OrderDetailsId=" & drv!OrderDetailsId, cnn)

                drv!OrderQuantity = OrderQuantity
                drv!InputQuantity = InputQuantity
                drv!Balance = OrderQuantity - InputQuantity


            Next

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.SewingInputDataSet.SewingInput.SewingInputDateColumn.DefaultValue = Me.DateTimePicker1.Text
        Me.SewingInputDataSet.SewingInput.BranchIdColumn.DefaultValue = Me.BranchComboBox.SelectedValue

        Me.SewingInputDataSet.SewingInput.SewingInputDateColumn.DefaultValue = Me.DateTimePicker1.Text
    End Sub

    Private Sub OrderColorPOLookupBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderColorPOLookupBindingSource.PositionChanged

        If OrderColorPOLookupBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As OrderColorPOLookupDataSet.OrderColorPOLookupRow
        row = CType(CType(Me.OrderColorPOLookupBindingSource.Current, DataRowView).Row, OrderColorPOLookupDataSet.OrderColorPOLookupRow)

        Me.SewingInputTableAdapter.Fill(Me.SewingInputDataSet.SewingInput, BranchComboBox.SelectedValue, row.OrderDetailsId, DateTimePicker1.Text)

        If SewingInputBindingSource.Position > -1 Then

            For Each drv As DataRowView In Me.SewingInputBindingSource.List

                Dim OrderQuantity As Integer = ReadIntegerData("Select OrderQuantity From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId & "And SizeId=" & drv!SizeId, cnn)
                Dim InputQuantity As Integer = ReadData("Select Sum(InputQuantity)As TTLInputQuantity From SewingInput Where OrderDetailsId=" & row.OrderDetailsId & " And SizeId=" & drv!SizeId, cnn)

                drv!OrderQuantity = OrderQuantity
                drv!TTLInputQuantity = InputQuantity
                drv!BalanceQuantity = OrderQuantity - InputQuantity

            Next

        End If

    End Sub

    Private Sub FinishingInputBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SewingInputBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SewingInputBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingInputDataSet)

        CalculatePOQuantity()
        CalculateSizeQuantity()
    End Sub
    Private Sub CalculateSizeQuantity()


        If Me.SewingInputBindingSource.Position > -1 Then

            Dim row As FinishingInputDataSet.FinishingInputRow
            row = CType(CType(Me.SewingInputBindingSource.Current, DataRowView).Row, FinishingInputDataSet.FinishingInputRow)

            SIZELABEL.Text = ReadStringData("Select SizeCode From Size Where SizeId=" & row.SizeId, cnn)
            TTLINPUTQUANTITYLABEL.Text = ReadData("Select Sum(InputQuantity) From FinishingInput Where SizeId=" & row.SizeId & "And FinishingDate='" & Me.DateTimePicker1.Text & "' And BranchId=" & Me.BranchComboBox.SelectedValue & "And OrderDetailsId=" & row.OrderDetailsId, cnn)


        End If

    End Sub
    'Private Sub SewingInputDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles FinishingInputDataGridView.CellBeginEdit

    '    'TTLInput = SewingInputDataGridView.CurrentRow.Cells("TTLInputQuantity").Value - SewingInputDataGridView.CurrentRow.Cells("InputQuantityColumn").Value

    'End Sub
End Class