Imports System.Data.SqlClient

Public Class frmFinishingInput
    Dim validatingflag As Boolean = False
    Dim TTLInput As Integer = 0
    Public PgNo As String

    Private Sub FinishingInputBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingInputBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.FinishingInputBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingInputDataSet)

        CalculatePOQuantity()
        CalculateSizeQuantity()

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.FinishingInputTableAdapter.Fill(Me.FinishingInputDataSet.FinishingInput, New System.Nullable(Of Long)(CType(BranchIdToolStripTextBox.Text, Long)), New System.Nullable(Of Date)(CType(FinishingDateToolStripTextBox.Text, Date)), New System.Nullable(Of Long)(CType(OrderDetailsIdToolStripTextBox.Text, Long)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub frmFinishingInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.FinishingInputDataSet.FinishingInput.FinishingDateColumn.DefaultValue = Me.DateTimePicker1.Text
        Me.FinishingInputDataSet.FinishingInput.BranchIdColumn.DefaultValue = Me.BranchComboBox.SelectedValue


        If CheckUserRights("Finishing Input").CanEdit = False Then

            FinishingInputBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged

        On Error Resume Next

        Me.FinishingInputTableAdapter.Fill(Me.FinishingInputDataSet.FinishingInput, BranchComboBox.SelectedValue, DateTimePicker1.Text, 0)

        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.EditValue)
        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, ProgramNoGridLookUpEdit.EditValue)



    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.FinishingInputDataSet.FinishingInput.FinishingDateColumn.DefaultValue = Me.DateTimePicker1.Text
        Me.FinishingInputDataSet.FinishingInput.BranchIdColumn.DefaultValue = Me.BranchComboBox.SelectedValue

        Me.FinishingInputDataSet.FinishingInput.FinishingDateColumn.DefaultValue = Me.DateTimePicker1.Text

    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged

        'On Error Resume Next


        Me.OrderColorPOLookupTableAdapter.FillBy(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, FabricColorComboBox.SelectedValue, ProgramNoGridLookUpEdit.EditValue)

        CalculatePOQuantity()


    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If FinishingInputBindingSource.Position > -1 Then
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

                Dim newRow As FinishingInputDataSet.FinishingInputRow = Me.FinishingInputDataSet.FinishingInput.NewRow()
                newRow.OrderDetailsId = row.OrderDetailsId
                newRow.SizeId = reader("SizeId")
                newRow.InputQuantity = 0
                newRow.OrderQuantity = reader("OrderQuantity")
                Dim TTLInputQuantity = ReadData("Select Sum(InputQuantity) As TTLQuantity From FinishingInput Where OrderDetailsId=" & row.OrderDetailsId & "And SizeId=" & reader("SizeId"), cnn)
                newRow.BalanceQuantity = reader("OrderQuantity") - TTLInputQuantity
                newRow.Remarks = "-"
                newRow.TTLInputQuantity = TTLInputQuantity
                Me.FinishingInputDataSet.FinishingInput.Rows.Add(newRow)

            End While

            reader.Close()

        End Using

    End Sub

    Private Sub OrderColorPOLookupBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderColorPOLookupBindingSource.PositionChanged

        If OrderColorPOLookupBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As OrderColorPOLookupDataSet.OrderColorPOLookupRow
        row = CType(CType(Me.OrderColorPOLookupBindingSource.Current, DataRowView).Row, OrderColorPOLookupDataSet.OrderColorPOLookupRow)

        Me.FinishingInputTableAdapter.Fill(Me.FinishingInputDataSet.FinishingInput, BranchComboBox.SelectedValue, DateTimePicker1.Text, row.OrderDetailsId)

        If FinishingInputBindingSource.Position > -1 Then

            For Each drv As DataRowView In Me.FinishingInputBindingSource.List

                Dim OrderQuantity As Integer = ReadIntegerData("Select OrderQuantity From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId & "And SizeId=" & drv!SizeId, cnn)
                Dim InputQuantity As Integer = ReadData("Select Sum(InputQuantity)As TTLInputQuantity From FinishingInput Where OrderDetailsId=" & row.OrderDetailsId & " And SizeId=" & drv!SizeId, cnn)

                drv!OrderQuantity = OrderQuantity
                drv!TTLInputQuantity = InputQuantity
                drv!BalanceQuantity = OrderQuantity - InputQuantity

            Next

        End If

    End Sub

    Private Sub FinishingInputDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles FinishingInputDataGridView.CellBeginEdit
        TTLInput = FinishingInputDataGridView.CurrentRow.Cells("TTLInputQuantity").Value - FinishingInputDataGridView.CurrentRow.Cells("InputQuantityColumn").Value

    End Sub

    Private Sub FinishingInputDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FinishingInputDataGridView.CellEndEdit

        'If FinishingInputBindingSource.Position > -1 Then


        '    If FinishingInputDataGridView.Columns(FinishingInputDataGridView.CurrentCell.ColumnIndex).HeaderText = "Input Quantity" Then
        '        'SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText
        '        Dim row As FinishingInputDataSet.FinishingInputRow
        '        row = CType(CType(Me.FinishingInputBindingSource.Current, DataRowView).Row, FinishingInputDataSet.FinishingInputRow)

        '        'Dim TTLInput As Integer = FinishingInputDataGridView.CurrentRow.Cells("BalanceQuantity").Value + Me.FinishingInputDataGridView.CurrentCell.Value

        '        'If TTLInput > Me.FinishingInputDataGridView.CurrentRow.Cells("OrderQuantityColumn").Value Then
        '        '    MessageBox.Show("Excess Quantity is not allowed", "Validating...", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        'End If

        '    End If
        'End If
        FinishingInputDataGridView.Rows(e.RowIndex).ErrorText = String.Empty

    End Sub

    Private Sub FinishingInputDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles FinishingInputDataGridView.CellValidating




        Dim headerText As String = FinishingInputDataGridView.Columns(e.ColumnIndex).HeaderText

        ' Abort validation if cell is not in the CompanyName column.
        If Not headerText.Equals("Input Quantity") Then Return

        ' Confirm that the cell is not empty.
        Dim row As FinishingInputDataSet.FinishingInputRow
        row = CType(CType(Me.FinishingInputBindingSource.Current, DataRowView).Row, FinishingInputDataSet.FinishingInputRow)


        Dim TTLBalance As Integer = FormatNumber((FinishingInputDataGridView.CurrentRow.Cells("OrderQuantityColumn").Value * 1.05), 0) - (TTLInput + CType(e.FormattedValue.ToString, Integer))


        If TTLBalance < 0 Then

            FinishingInputDataGridView.Rows(e.RowIndex).ErrorText = "Excess Quantity is not allowed."
            e.Cancel = True

        Else

            SIZELABEL.Text = ReadStringData("Select SizeCode From Size Where SizeId=" & row.SizeId, cnn)
            TTLINPUTQUANTITYLABEL.Text = ReadData("Select Sum(InputQuantity) From FinishingInput Where SizeId=" & row.SizeId & "And FinishingDate='" & Me.DateTimePicker1.Text & "' And BranchId=" & Me.BranchComboBox.SelectedValue, cnn)

            FinishingInputDataGridView.CurrentRow.Cells("TTLInputQuantity").Value = TTLInput + CType(e.FormattedValue.ToString, Integer)
            FinishingInputDataGridView.CurrentRow.Cells("BalanceQuantity").Value = FinishingInputDataGridView.CurrentRow.Cells("OrderQuantityColumn").Value - FinishingInputDataGridView.CurrentRow.Cells("TTLInputQuantity").Value

        End If



    End Sub

  
    
    Private Sub FinishingInputBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingInputBindingSource.PositionChanged

        CalculateSizeQuantity()

    End Sub

    Private Sub TTLINPUTQUANTITYLABEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTLINPUTQUANTITYLABEL.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub


    Private Sub CalculatePOQuantity()

        If OrderColorPOLookupBindingSource.Position > -1 Then


            For Each drv As DataRowView In OrderColorPOLookupBindingSource.List

                Dim OrderQuantity As Integer = ReadIntegerData("Select OrderQuantity From vOrder Where OrderDetailsId=" & drv!OrderDetailsId, cnn)
                Dim InputQuantity As Integer = ReadData("Select Sum(InputQuantity) as TTLInput From FinishingInput Where OrderDetailsId=" & drv!OrderDetailsId, cnn)

                drv!OrderQuantity = OrderQuantity
                drv!InputQuantity = InputQuantity
                drv!Balance = OrderQuantity - InputQuantity


            Next

        End If

    End Sub

    Private Sub CalculateSizeQuantity()


        If Me.FinishingInputBindingSource.Position > -1 Then

            Dim row As FinishingInputDataSet.FinishingInputRow
            row = CType(CType(Me.FinishingInputBindingSource.Current, DataRowView).Row, FinishingInputDataSet.FinishingInputRow)

            SIZELABEL.Text = ReadStringData("Select SizeCode From Size Where SizeId=" & row.SizeId, cnn)
            TTLINPUTQUANTITYLABEL.Text = ReadData("Select Sum(InputQuantity) From FinishingInput Where SizeId=" & row.SizeId & "And FinishingDate='" & Me.DateTimePicker1.Text & "' And BranchId=" & Me.BranchComboBox.SelectedValue & "And OrderDetailsId=" & row.OrderDetailsId, cnn)


        End If

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        frmFinishingReportProgramWise.PgNo = Me.ProgramNoGridLookUpEdit.EditValue
        ShowForm(frmFinishingReportProgramWise)
        Me.Close()
    End Sub


End Class