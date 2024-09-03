Imports System.Data
Imports System.Data.SqlClient

Public Class frmCuttingProductionNew
    Private _pBatchNo As String
    Public Property pBatchNo() As String
        Get
            Return _pBatchNo
        End Get
        Set(ByVal value As String)
            _pBatchNo = value
        End Set
    End Property

    Dim MailString As String = ""
    Dim FormLoaded As Boolean = False
    Dim IsCuttingEdited As Boolean = False
    Dim SplitPOFlag As Boolean = False
    Private Sub LoadCuttingProductionData(ByVal CPNID As Integer)
        Me.CuttingProductionNewDetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingProductionNewDetails, CPNID)
        Me.CuttingLayDetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingLayDetails, CPNID)
        Me.CuttingBundleDetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingBundleDetails, CPNID)
    End Sub

    Private Sub frmCuttingProductionNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        Me.TwinPackLookupTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackLookup)
        Me.CuttingAPOListTableAdapter.Fill(Me.CuttingAPOListDataSet.CuttingAPOList)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.CuttingDateTimePicker.Text = Today()
        Me.CuttingProductionNewDataSet.CuttingProductionNew.CuttingDateColumn.DefaultValue = CuttingDateTimePicker.Text
        Me.CuttingProductionNewDataSet.CuttingProductionNew.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        FormLoaded = True
        HideCheckBox.Checked = True
        Me.BranchComboBox.SelectedValue = Val(My.Settings.DefaultBranchIdForCutting)

        If CheckUserRights("Cutting Production From Job Card").CanEdit = False Then

            NewButton.Enabled = False
            SaveButton.Enabled = False

        End If

    End Sub





    Private Sub CuttingProductionNewDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CuttingProductionNewDataGridView.KeyDown

        If e.KeyData = Keys.F10 Then

            If CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Program No" Then

                'ShowMaster(frmOrderFabricColor)

                'If frmOrderFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '    Me.CuttingProductionNewDataGridView.CurrentCell.Value = frmOrderFabricColor.prOrderId
                '    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("FabricColorId").Value = frmOrderFabricColor.prFabricColorId
                '    Dim MaxCuttingNo As Integer = 0
                '    Dim APOId As Integer = 0
                '    MaxCuttingNo = ReadIntData("Select Max(CuttingNo) From CuttingProductionNew Where OrderId=" & frmOrderFabricColor.prOrderId & "AND FabricColorId=" & frmOrderFabricColor.prFabricColorId & "AND BranchId=" & BranchComboBox.SelectedValue, cnn)
                '    APOId = ReadIntegerData("Select Max(CuttingAPOId) From CuttingProductionNew Where OrderId=" & frmOrderFabricColor.prOrderId & "AND BranchId=" & BranchComboBox.SelectedValue, cnn)

                '    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value = MaxCuttingNo + 1

                '    If APOId >= 1 Then
                '        Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingAPOId").Value = APOId

                '    End If

                'End If
            ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Length" Then
                ShowMaster(frmInchCalculator)
                If frmInchCalculator.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("Length").Value = frmInchCalculator.TTLInch
                End If
            ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Width" Then
                ShowMaster(frmInchCalculator)
                If frmInchCalculator.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("Width").Value = frmInchCalculator.TTLInch
                End If
            ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Marker Length" Then
                ShowMaster(frmInchCalculator)
                If frmInchCalculator.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("Marker_Length").Value = frmInchCalculator.TTLInch
                End If
            ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Marker Width" Then
                ShowMaster(frmInchCalculator)
                If frmInchCalculator.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.CuttingProductionNewDataGridView.CurrentRow.Cells("Marker_Width").Value = frmInchCalculator.TTLInch
                End If
                'New-----------------------------
                'ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Batch No" Then

                '    If Me.CuttingProductionNewBindingSource.Position > -1 Then

                '        Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
                '        row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)
                '        frmBatchLookup.ProgramNo = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & row.OrderId, cnn)

                '    End If

                '    ShowMaster(frmBatchLookup)

                '    If frmBatchLookup.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '        Me.CuttingProductionNewDataGridView.CurrentRow.Cells("BatchNo").Value = Me.pBatchNo

                '    End If

            End If

        End If

    End Sub



    Private Sub CuttingDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingDateTimePicker.ValueChanged



    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged
        Me.CuttingProductionNewDataSet.CuttingProductionNew.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
    End Sub

    Private Sub GetSizeList()

        If Me.CuttingProductionNewBindingSource.Position = -1 Then
            Exit Sub

        End If
        If DBNull.Value.Equals(Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value) Then

            MessageBox.Show("Cutting No should not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If


        'If Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value >= 0 Then


        If Me.CuttingProductionNewDetailsBindingSource.Position = -1 Then

            Save()

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            If row.IsOrderIdNull Then
                MessageBox.Show("Order Is not Available")
                Exit Sub
            End If

            Me.SizeLookupTableAdapter.Fill(Me.SizeDataSet.SizeLookup, OrderNoGridLookUpEdit.EditValue)

            If SizeLookupBindingSource.Position > -1 Then


                For Each drv As DataRowView In SizeLookupBindingSource.List

                    Dim newRow As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow = Me.CuttingProductionNewDataSet.CuttingProductionNewDetails.NewRow()
                    newRow.CuttingProductionNewId = row.CuttingProductionNewId
                    newRow.SizeId = drv!SizeId
                    newRow.OrderQuantity = ReadIntegerData("Select Sum(OrderQuantity) from Color_Size_OrderQuantity Where OrderId=" & row.OrderId & "AND FabricColorId =" & row.FabricColorId & "AND SizeId=" & drv!SizeId, cnn)
                    newRow.TotalCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & drv!SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    Me.CuttingProductionNewDataSet.CuttingProductionNewDetails.Rows.Add(newRow)

                Next
            End If

        End If

        'End If

    End Sub

    Private Sub CuttingProductionNewDetailsDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionNewDetailsDataGridView.CellEndEdit
        On Error Resume Next
        If CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)



            'If changes in Ratio

            If CuttingProductionNewDetailsDataGridView.Columns(CuttingProductionNewDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Ratio" Then


                If CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("Ratio").Value.ToString <> String.Empty Then

                    Dim row1 As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
                    row1 = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

                    Dim TTLCutting As Integer = 0

                    If row.IsTwinPackIdNull Then
                        TTLCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & row1.SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    Else

                        TTLCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & row1.SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND TwinPackId=" & row.TwinPackId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    End If


                    Dim CQuantity As Integer = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("Ratio").Value * row.LayQuantity

                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingQuantity").Value = CQuantity
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value = TTLCutting + CQuantity
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("Balance").Value = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value - CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value


                    Dim OrQuantity As Integer = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingPercentage").Value = (CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value / CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value)

                    IsCuttingEdited = True

                End If

                '=== If changes in Cutting Quantity

            ElseIf CuttingProductionNewDetailsDataGridView.Columns(CuttingProductionNewDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Cutting Quantity" Then

                If CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingQuantity").Value >= 0 Then

                    Dim row1 As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
                    row1 = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

                    Dim TTLCutting As Integer = 0

                    If row.IsTwinPackIdNull Then
                        TTLCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & row1.SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    Else

                        TTLCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & row1.SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND TwinPackId=" & row.TwinPackId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    End If


                    Dim CQuantity As Integer = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingQuantity").Value

                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingQuantity").Value = CQuantity
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value = TTLCutting + CQuantity
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("Balance").Value = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value - CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value


                    Dim OrQuantity As Integer = CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value
                    CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("CuttingPercentage").Value = (CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value / CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value)

                    IsCuttingEdited = True


                End If


            End If




        End If




    End Sub

    Public Function GetInputQuantity(ByVal OID As Integer, ByVal CID As Integer, ByVal CuttingNo As String) As Integer
        Dim sql As String = "select ISNULL(Sum(ISNULL(InputQuantity,0)),0) from CuttingDeliveryByCuttingNo where OrderId = @OrderId and FabricColorId = @FabricColorId and CuttingNo = @CuttingNo"

        Using cn As New SqlConnection(cnn)
            cn.Open()
            Dim cmd As New SqlCommand(sql, cn)

            cmd.Parameters.Add("@OrderId", SqlDbType.BigInt).Value = OID
            cmd.Parameters.Add("@FabricColorId", SqlDbType.BigInt).Value = CID
            cmd.Parameters.Add("@CuttingNo", SqlDbType.VarChar, 50).Value = CuttingNo

            Return cmd.ExecuteScalar()
        End Using

    End Function


    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click




        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)


            If GetInputQuantity(row.OrderId, row.FabricColorId, row.CuttingNo) > 0 Then
                MessageBox.Show("Not Allowed to edit or delete for Input Data")
                Exit Sub
            End If


            If row.IsChallanNoNull = False AndAlso UserName <> "admin" Then
                MessageBox.Show("Not Allowed to edit or delete input data")
                Exit Sub
            End If

        End If


        If SaveButton.Text = "&Edit" Then
            SaveButton.Text = "&Save"


        Else
            SaveButton.Text = "&Edit"

            Try

                CalculateLayQuantity()
                GetSizeList()
                CalculateTotalCuttingAndPercentage()
                CalculateCuttingAndInput()

                SplitInPOQty()
                Save()
                GetData()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If




    End Sub



    Private Sub CuttingProductionNewDataGridView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CuttingProductionNewDataGridView.LostFocus

        FormLoaded = False

    End Sub

    Private Sub FabricColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.LostFocus

        If OrderLookupBindingSource.Position > -1 Then

            'Dim row As OrderLookupDataSet.OrderLookupRow
            'row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

            Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)

        End If

    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        On Error Resume Next
        Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)
        Me.CuttingNoLookupTableAdapter.Fill(Me.CuttingNoLookupDataSet.CuttingNoLookup, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)
        Me.CuttingProductionNewDataSet.CuttingProductionNew.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
        Me.CuttingProductionNewDataSet.CuttingProductionNew.ConsumptionColumn.DefaultValue = 0
        'Me.OrderColorPOLookupTableAdapter.FillBy(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, FabricColorComboBox.SelectedValue, OrderNoGridLookUpEdit.EditValue)
        'Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, FabricColorComboBox.SelectedValue, OrderNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub MultipartComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipartComboBox.SelectedIndexChanged

        'Dim row As OrderLookupDataSet.OrderLookupRow
        'row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)


        Me.CuttingProductionNewDataSet.CuttingProductionNew.TwinPackIdColumn.DefaultValue = MultipartComboBox.SelectedValue
        Me.CuttingNoLookupTableAdapter.FillByOrderAndColorAndPart(Me.CuttingNoLookupDataSet.CuttingNoLookup, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue, MultipartComboBox.SelectedValue)

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        Me.CuttingProductionNewDataSet.CuttingProductionNew.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
        Me.CuttingProductionNewDataSet.CuttingProductionNew.IsPrintColumn.DefaultValue = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & OrderNoGridLookUpEdit.EditValue, cnn)
        'Me.CuttingProductionNewBindingSource.AddNew()

        Dim DT As Date = ReadDateData("Select GetDate()", cnn)
        Dim ABC As String = DT.Year.ToString.Substring(2) & "C"
        Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(CuttingNo),0,CHARINDEX('C',REVERSE(CuttingNo))))AS Integer)) From CuttingProductionNew Where CuttingNo Like '" & ABC & "%'", cnn)

        'KPNo = DT.Year.ToString.Substring(2) & "C" & (Val(XYZ) + 1).ToString()

        Me.CuttingProductionNewDataSet.CuttingProductionNew.CuttingNoColumn.DefaultValue = DT.Year.ToString.Substring(2) & "C" & (Val(XYZ) + 1).ToString()
        Me.CuttingProductionNewDataSet.CuttingProductionNew.CuttingNoSLColumn.DefaultValue = Val(XYZ) + 1
        Me.CuttingProductionNewDataSet.CuttingProductionNew.ProcessColumn.DefaultValue = "Cutting"
        'Me.CuttingProductionNewDataSet.CuttingProductionNew.OrderDetailsIdColumn.DefaultValue = POGridLookUpEdit.EditValue
        Me.CuttingProductionNewBindingSource.AddNew()



    End Sub

    Private Sub frmCuttingProductionNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'If e.KeyData = Keys.F3 Then

        '    Me.CuttingProductionNewDataSet.CuttingProductionNew.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
        '    Me.CuttingProductionNewBindingSource.AddNew()

        If e.KeyData = Keys.F12 Then

            Save()

        End If

    End Sub



    Private Sub HideCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideCheckBox.CheckedChanged

        If HideCheckBox.Checked = True Then
            Me.CuttingProductionNewDataGridView.Columns("TwinPackId").Visible = True
        Else
            Me.CuttingProductionNewDataGridView.Columns("TwinPackId").Visible = False
        End If

    End Sub

    

    Private Sub CuttingProductionNewDetailsBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingProductionNewDetailsBindingSource.PositionChanged, CuttingProductionNewDetailsBindingSource.CurrentChanged

        CalculateCuttingAndInput()

        'If SplitPOFlag = False Then

        '    'If Me.CuttingProductionNewDetailsBindingSource.Position > -1 Then

        '    '    Dim row As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
        '    '    row = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

        '    '    Me.CuttingProductionNewPODetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails, row.CuttingProductionNewDetailsId)

        '    'End If

        'End If



    End Sub

    Private Sub CuttingProductionNewDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionNewDataGridView.CellClick

        On Error Resume Next

        'Me.CuttingProductionNewDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click

        CalculateTotalCuttingAndPercentage()
        CalculateCuttingAndInput()


    End Sub
    Private Sub SplitInPOQty()

        SplitPOFlag = True

        Dim i As Integer = 0
        Dim j As Integer = Me.CuttingProductionNewPODetailsBindingSource.Count - 1

        Me.CuttingProductionNewDetailsBindingSource.MoveFirst()


        Do While i <= Me.CuttingProductionNewDetailsBindingSource.Count - 1


            'On Error Resume Next



            Do While Me.CuttingProductionNewPODetailsBindingSource.Count > 0
                Me.CuttingProductionNewPODetailsBindingSource.RemoveCurrent()
                j = j + 1
            Loop

            Save()


            If Me.CuttingProductionNewPODetailsBindingSource.Position = -1 Then

                Dim TTLPOCuttingQuantity As Integer = 0
                Dim TTLPOCuttingBalance As Integer = 0
                Dim TTLClrCutting As Integer = 0
                Dim TTLClrCuttingBal As Integer = 0

                Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
                row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)


                Dim row1 As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
                row1 = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)


                Using connection As New SqlConnection(cnn)

                    Dim command As New SqlCommand("Select OrderDetailsId,ISNULL(OrderQuantity,0) AS OrderQuantity From OrderQuantity_OIDAndODIDAndCIDAndSIDWithCP Where  SizeId =" & row1.SizeId & "And OrderId=" & row.OrderId & " And FabricColorId=" & row.FabricColorId, connection)

                    command.Connection.Open()
                    command.ExecuteNonQuery()
                    Dim TTLColorCuttingQuantity As Integer = row1.CuttingQuantity

                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()

                        TTLPOCuttingQuantity = 0
                        TTLPOCuttingBalance = 0

                        If row1.CuttingQuantity > 0 And Me.CuttingProductionNewPODetailsBindingSource.Position = -1 Then

                            Dim newRow = CType(Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails.NewRow(), CuttingProductionNewDataSet.CuttingProductionNewPODetailsRow)

                            newRow.CuttingProductionNewDetailsId = row1.CuttingProductionNewDetailsId
                            newRow.OrderDetailsId = reader("OrderDetailsId")
                            If reader("OrderQuantity") > 0 Then
                                newRow.OrderQuantity = reader("OrderQuantity")
                            Else
                                newRow.OrderQuantity = 0
                            End If



                            TTLPOCuttingQuantity = ReadData("Select Sum(CuttingQuantity) As TTLCuttingQuantity From CuttingProductionSummeryPOAndSize Where SizeId=" & row1.SizeId & "And  OrderDetailsId=" & reader("OrderDetailsId"), cnn)
                            TTLPOCuttingBalance = CType(reader("OrderQuantity"), Int32) - CType(TTLPOCuttingQuantity, Int32)


                            If TTLColorCuttingQuantity >= TTLPOCuttingBalance AndAlso TTLColorCuttingQuantity > 0 AndAlso TTLPOCuttingBalance > 0 Then

                                newRow.CuttingQuantity = CType(TTLPOCuttingBalance, Integer)
                                TTLClrCutting = TTLClrCutting + CType(TTLPOCuttingBalance, Integer)
                                TTLColorCuttingQuantity = CType(TTLColorCuttingQuantity, Integer) - CType(TTLPOCuttingBalance, Integer)
                                newRow.CuttingBalance = 0



                            ElseIf TTLColorCuttingQuantity < TTLPOCuttingBalance AndAlso TTLColorCuttingQuantity > 0 Then

                                newRow.CuttingQuantity = TTLColorCuttingQuantity
                                TTLClrCutting = TTLClrCutting + TTLColorCuttingQuantity
                                TTLColorCuttingQuantity = TTLColorCuttingQuantity - TTLColorCuttingQuantity

                                newRow.CuttingBalance = TTLPOCuttingBalance - TTLColorCuttingQuantity



                            Else

                                newRow.CuttingQuantity = 0
                                newRow.CuttingBalance = 0

                            End If


                            'If newRow.InputQuantity > 0 Then

                            Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails.Rows.Add(newRow)

                            'End If



                        End If

                    End While

                    reader.Close()

                End Using


                'If Me.CuttingProductionNewPODetailsBindingSource.Position > -1 Then
                '    row1.InputQuantity = TTLClrInput
                'End If



            End If

            Me.CuttingProductionNewDetailsBindingSource.MoveNext()

            i = i + 1

        Loop

        Save()

        SplitPOFlag = False
    End Sub


    Private Sub CuttingProductionNewDetailsDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionNewDetailsDataGridView.CellClick
        Me.CuttingProductionNewDetailsDataGridView.CurrentRow.Selected = True
    End Sub




    Private Sub CuttingProductionNewDetailsDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingProductionNewDetailsDataGridView.Enter

        'IsCuttingEdited = False


        'If DBNull.Value.Equals(Me.CuttingProductionNewDataGridView.CurrentRow.Cells("QCPassed").Value) Then

        '    Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("FabricRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("PrintRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingReplaced").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("MatchingReplaced").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = True

        'Else


        '    If Me.CuttingProductionNewDataGridView.CurrentRow.Cells("QCPassed").Value = True Then

        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingRejection").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("FabricRejection").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintRejection").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingReplaced").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("MatchingReplaced").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = False

        '    Else

        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingRejection").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("FabricRejection").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintRejection").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingReplaced").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("MatchingReplaced").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = True

        '    End If

        'End If



        'If DBNull.Value.Equals(Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value) Then

        '    Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingQuantity").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("PrintSend").ReadOnly = False
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("PrintReceived").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("Ratio").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("FabricRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("PrintRejection").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingReplaced").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("MatchingReplaced").ReadOnly = True
        '    Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = True

        'Else

        '    If Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value >= 1 Then

        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingQuantity").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintSend").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("Ratio").ReadOnly = False


        '        Dim IsPrint As Boolean = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & CuttingProductionNewDataGridView.CurrentRow.Cells("OrderId").Value, cnn)

        '        If IsPrint = True Then
        '            Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = True
        '        Else
        '            Me.CuttingProductionNewDetailsDataGridView.Columns("InputQuantity").ReadOnly = False
        '        End If




        '    Else

        '        Me.CuttingProductionNewDetailsDataGridView.Columns("CuttingQuantity").ReadOnly = True
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintSend").ReadOnly = False
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("Ratio").ReadOnly = True


        '    End If


        '    If Me.CuttingProductionNewDataGridView.CurrentRow.Cells("CuttingNo").Value = 0 Then

        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintReceived").ReadOnly = False
        '        Dim IsPrint As Boolean = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & CuttingProductionNewDataGridView.CurrentRow.Cells("OrderId").Value, cnn)

        '    Else
        '        Me.CuttingProductionNewDetailsDataGridView.Columns("PrintReceived").ReadOnly = True
        '    End If

        'End If




    End Sub
   



    Private Sub CuttingNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingNoComboBox.SelectedIndexChanged



        If OrderLookupBindingSource.Position > -1 Then

            'Dim row As OrderLookupDataSet.OrderLookupRow
            'row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

            Me.CuttingProductionNewTableAdapter.FillByFilterCuttingNo(Me.CuttingProductionNewDataSet.CuttingProductionNew, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue, CuttingNoComboBox.SelectedValue)

            Me.CuttingProductionNewDataSet.CuttingProductionNew.CuttingNoColumn.DefaultValue = CuttingNoComboBox.SelectedValue

        End If



    End Sub

    Private Sub CuttingProductionNewDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionNewDataGridView.CellEndEdit

        If CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "Multiple Cutting No" Then

            CuttingProductionNewDataGridView.CurrentRow.Cells("MultipleCuttingNo").Value = RemoveWhitespace(CuttingProductionNewDataGridView.CurrentRow.Cells("MultipleCuttingNo").Value.ToString)

        ElseIf CuttingProductionNewDataGridView.Columns(CuttingProductionNewDataGridView.CurrentCell.ColumnIndex).HeaderText = "QC Passed" Then

            If Me.CuttingProductionNewDetailsBindingSource.Position > -1 Then
                If CuttingProductionNewDataGridView.CurrentRow.Cells("QCPassed").Value = 0 Then
                    For Each drv As DataRowView In Me.CuttingProductionNewDetailsBindingSource.List
                        drv!QCPassed = 0
                    Next
                End If
            End If
            
        End If

    End Sub


    Private Sub OrderNoGridLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.TextChanged
        On Error Resume Next

        Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where OrderId='" & OrderNoGridLookUpEdit.EditValue & "'", cnn)
        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, OrderId)
    End Sub



    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged, OrderNoGridLookUpEdit.Closed

        If OrderLookupBindingSource.Position > -1 Then

            On Error Resume Next

            Dim OrderId As Integer = OrderNoGridLookUpEdit.EditValue
            Dim IsPrint As Boolean = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & OrderNoGridLookUpEdit.EditValue, cnn)
            Dim IsIsMultiPartNull As Boolean = ReadBooleanData("Select IsMultiPart From [Order] Where OrderId=" & OrderNoGridLookUpEdit.EditValue, cnn)


            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderId)
            Me.CuttingNoLookupTableAdapter.Fill(Me.CuttingNoLookupDataSet.CuttingNoLookup, OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)


            If IsIsMultiPartNull = False Then

                If IsIsMultiPartNull = True Then

                    MultipartComboBox.Visible = True
                    MultipartLabel.Visible = True
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

                Else

                    MultipartComboBox.Visible = False
                    MultipartLabel.Visible = False
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

                End If

            Else

                MultipartComboBox.Visible = False
                MultipartLabel.Visible = False
                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

            End If



            Me.CuttingProductionNewDataSet.CuttingProductionNew.OrderIdColumn.DefaultValue = OrderId
            Me.CuttingProductionNewDataSet.CuttingProductionNew.IsPrintColumn.DefaultValue = IsPrint
            Me.CuttingProductionNewDataSet.CuttingProductionNew.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue



        End If

    End Sub

    
    Private Sub CalculateQCPassed()

        'On Error Resume Next
        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim QCPassedCount As Integer = 0

        If CuttingProductionNewBindingSource.Position > -1 Then


            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            'If row.IsTwinPackIdNull Then
            QCPassedCount = ReadIntData("Select Count(*)As QCPassedCount From CuttingProductionNew where OrderId=" & row.OrderId & "and FabricColorId=" & row.FabricColorId & "and CuttingNo='" & row.CuttingNo & "'and BranchId=" & row.BranchId & "And QCPassed=1 And CuttingProductionNewId not in (" & row.CuttingProductionNewId & ")", cnn)
            'Else
            'QCPassedCount = ReadIntData("Select Count(*)As QCPassedCount From CuttingProductionNew where OrderId=" & row.OrderId & "and TwinPackId=" & row.TwinPackId & "And FabricColorId=" & row.FabricColorId & "and CuttingNo=" & row.CuttingNo & "and BranchId=" & row.BranchId & "And QCPassed=1", cnn)
            'End If



            If QCPassedCount > 0 Then

                MessageBox.Show("The mentioned CuttingNo already has been QCPassed", "QC Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If


            For Each drv As DataRowView In CuttingProductionNewDetailsBindingSource.List

                Dim connection As New SqlConnection(cnn)
                connection.Open()
                Dim sqlString As String = ""

                'If row.IsTwinPackIdNull Then
                sqlString = "Select Sum(CuttingQuantity) As CuttingQuantity,Sum(CuttingRejection) As CuttingRejection,Sum(FabricRejection) As FabricRejection ,Sum(PrintRejection) As PrintRejection,Sum(CuttingReplaced) as CuttingReplaced ,Sum(MatchingReplaced) as MatchingReplaced From CuttingProductionNewView where OrderId=" & row.OrderId & "and FabricColorId=" & row.FabricColorId & "and SizeId=" & drv!SizeId & "and CuttingNo='" & row.CuttingNo & "' and BranchId=" & row.BranchId
                'Else
                '    sqlString = "Select Sum(CuttingQuantity) As CuttingQuantity,Sum(CuttingRejection) As CuttingRejection,Sum(FabricRejection) As FabricRejection ,Sum(PrintRejection) As PrintRejection,Sum(CuttingReplaced) as CuttingReplaced ,Sum(MatchingReplaced) as MatchingReplaced From CuttingProductionNewView where OrderId=" & row.OrderId & "and FabricColorId=" & row.FabricColorId & "and TwinPackId=" & row.TwinPackId & "and SizeId=" & drv!SizeId & "and CuttingNo=" & row.CuttingNo & "and BranchId=" & row.BranchId
                'End If


                Dim cmd As SqlCommand = New SqlCommand(sqlString, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                reader.Read()

                drv!QCPassed = reader("CuttingQuantity") - reader("CuttingRejection") - reader("FabricRejection") - reader("PrintRejection") + reader("CuttingReplaced") + reader("MatchingReplaced")

                reader.Close()
                connection.Close()

            Next

            'Me.CuttingProductionNewDetailsBindingSource.ResetBindings(True)

        End If



        'End If

    End Sub

    
    
    
    Private Sub CalculateQCPassedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateQCPassedButton.Click

        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            If row.IsChallanNoNull = False AndAlso UserName <> "admin" Then
                MessageBox.Show("Not Allowed to edit or delete input data")
                Exit Sub
            End If

        End If


        Try

            Save()

            If CuttingProductionNewBindingSource.Position > -1 Then

                Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
                row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

                If row.QCPassed = False Then

                    ExecuteQuery("Update CuttingProductionNewDetails Set QCPassed=0 Where CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "And FabricColorId=" & row.FabricColorId & "And CuttingNo='" & row.CuttingNo & "')", cnn)
                    Me.CuttingProductionNewTableAdapter.FillByFilterCuttingNo(Me.CuttingProductionNewDataSet.CuttingProductionNew, row.OrderId, FabricColorComboBox.SelectedValue, CuttingNoComboBox.SelectedValue)

                    If row.QCPassed = True Then

                        CalculateQCPassed()

                    End If

                End If

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub CalculatePrintSend()

        'On Error Resume Next
        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>



        Dim QCPassedCount As Integer = 0




        If CuttingProductionNewBindingSource.Position > -1 Then


            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            If row.IsMultipleCuttingNoNull Then
                MessageBox.Show("Multiple Cutting No is require")
            End If

            For Each drv As DataRowView In CuttingProductionNewDetailsBindingSource.List


                Dim connection As New SqlConnection(cnn)
                connection.Open()
                Dim sqlString As String = ""


                If row.IsTwinPackIdNull Then

                    sqlString = "Select Sum(CuttingQuantity) As CuttingQuantity From CuttingProductionNewView where OrderId=" & row.OrderId & " and FabricColorId=" & row.FabricColorId & " and SizeId=" & drv!SizeId & " and BranchId=" & row.BranchId & " and CuttingNo in (" & row.MultipleCuttingNo & ")"
                    Debug.Print(sqlString)

                Else

                    sqlString = "Select Sum(CuttingQuantity) As CuttingQuantity From CuttingProductionNewView where OrderId=" & row.OrderId & " and FabricColorId=" & row.FabricColorId & " and TwinPackId=" & row.TwinPackId & " and SizeId=" & drv!SizeId & " and BranchId=" & row.BranchId & " And CuttingNo in (" & row.MultipleCuttingNo & ")"
                    Debug.Print(sqlString)

                End If



                Dim cmd As SqlCommand = New SqlCommand(sqlString, connection)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                reader.Read()

                If DBNull.Value.Equals(reader.GetDecimal(0)) = True Then

                    drv!PrintSend = 0

                Else

                    drv!PrintSend = reader.GetDecimal(0)

                End If

                connection.Close()

            Next


        End If

        MessageBox.Show("Successfully Copied")

        'End If

    End Sub

   
    Private Sub CopyPrintSendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPrintSendButton.Click
        'CalculatePrintSend()
        SplitInPOQty()


    End Sub

    Private Sub CalculateTotalCuttingAndPercentage()

        'If FormLoaded = True Then


        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            If Me.CuttingProductionNewDetailsBindingSource.Position = -1 Then
                Exit Sub
            End If

            For Each drv As DataRowView In CuttingProductionNewDetailsBindingSource.List

                'Dim row1 As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
                'row1 = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

                drv!OrderQuantity = ReadIntegerData("Select Sum(OrderQuantity) from Color_Size_OrderQuantity Where OrderId=" & row.OrderId & "AND FabricColorId =" & row.FabricColorId & "AND SizeId=" & drv!SizeId, cnn)

                If row.IsTwinPackIdNull Then

                    drv!TotalCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & drv!SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    drv!TotalInput = ReadData("Select Sum(InputQuantity) From CuttingProductionNewDetails Where SizeId=" & drv!SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)

                Else

                    drv!TotalCutting = ReadData("Select Sum(CuttingQuantity) From CuttingProductionNewDetails Where SizeId=" & drv!SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND TwinPackId=" & row.TwinPackId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)
                    drv!TotalInput = ReadData("Select Sum(InputQuantity) From CuttingProductionNewDetails Where SizeId=" & drv!SizeId & "AND CuttingProductionNewId in (Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & "AND TwinPackId=" & row.TwinPackId & "AND FabricColorId=" & row.FabricColorId & ")", cnn)


                End If

                drv!Balance = drv!OrderQuantity - drv!TotalCutting

                If drv!OrderQuantity > 0 Then
                    drv!CuttingPercentage = drv!TotalCutting / drv!OrderQuantity
                End If

            Next

            CuttingProductionNewDetailsBindingSource.MoveLast()

        End If


        ' End If

    End Sub


    Private Sub Save()
        Try
            Me.Validate()
            Me.CuttingProductionNewBindingSource.EndEdit()
            Me.CuttingProductionNewDetailsBindingSource.EndEdit()
            Me.CuttingLayDetailsBindingSource.EndEdit()
            Me.CuttingBundleDetailsBindingSource.EndEdit()
            Me.CuttingProductionNewPODetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingProductionNewDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub GetData()



        'ExecuteQuery("Delete CuttingProduction Where BranchId=" & BranchComboBox.SelectedValue & "And CuttingDate='" & CuttingDateTimePicker.Text & "'", cnn)

        'ExecuteQuery("Insert into CuttingProduction(CuttingDate,OrderId,FabricColorId,CuttingQuantity,QCQuantity,PrintReceiveQuantity,PrintSendQuantity,InputQuantity,ReplaceQuantity,RejectQuantity,BranchId,TwinPackId,EmbSend,EmbReceived) " & _
        '            "(Select CuttingDate,OrderId,FabricColorId,CuttingQuantity,QCPassed,PrintReceived,PrintSend,InputQuantity,Replaced,Rejection,BranchId,TwinPackId,EmbSend,EmbReceived From CuttingSummery_ForDailyReport  where BranchId=" & BranchComboBox.SelectedValue & " and CuttingDate = '" & CuttingDateTimePicker.Text & "')", cnn)



        ExecuteQuery("Exec UpdateDailyCuttingProduction '" & CuttingDateTimePicker.Text & "'," & BranchComboBox.SelectedValue, cnn)

        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            Dim CP As Integer = ReadData("Select Max(ISNULL(CuttingPercentage,0)) From OrderCuttingPercentage Where OrderId= " & row.OrderId & "And FabricColorId=" & row.FabricColorId, cnn)
            ExecuteQuery("Exec CalculatePOCutting " & row.OrderId & "," & CP, cnn)

        End If


    End Sub

    Private Sub GenerateBundleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateBundleButton.Click

        If Me.CuttingBundleDetailsBindingSource.Position > -1 Then
            Exit Sub
        End If

        '1.Search Max Cutting No + 1 in the particular cutting

        '--For CuttingProductionNewId
        Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
        row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

        Dim row1 As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
        row1 = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

        Dim row2 As CuttingProductionNewDataSet.CuttingLayDetailsRow
        row2 = CType(CType(Me.CuttingLayDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingLayDetailsRow)


        Dim MaxBundleNo As Integer = ReadIntData("Select Max(BundleNoSL) From CuttingBundleDetails Where CuttingLayDetailsId in (Select CuttingLayDetailsId From CuttingLayDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId & ")", cnn)
        'Dim MaxFromStickerNo As Integer = ReadIntData("Select Max(BundleNo) From CuttingBundleDetails Where CuttingProductionNewDetailsId in (Select CuttingProductionNewDetailsId From CuttingProductionNewDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId & ")", cnn)
        Dim MaxToStickerNo As Integer = ReadIntData("Select Max(ToStickerNo) From CuttingBundleDetails Where CuttingLayDetailsId =" & row2.CuttingLayDetailsId, cnn)

        'MessageBox.Show(row.CuttingProductionNewId.ToString + "/" + MaxBundleNo.ToString)

        '2.Generate Bundle for Particular Size

        For Each drv As DataRowView In Me.CuttingProductionNewDetailsBindingSource.List

            MaxBundleNo = MaxBundleNo + 1

            Dim newRow As CuttingProductionNewDataSet.CuttingBundleDetailsRow = Me.CuttingProductionNewDataSet.CuttingBundleDetails.NewRow()
            newRow.CuttingProductionNewDetailsId = drv!CuttingProductionNewDetailsId
            newRow.BundleNoSL = MaxBundleNo
            newRow.BundleNo = row.CuttingNo & "B" & MaxBundleNo
            newRow.Quantity = row2.LayQuantity * drv!Ratio
            newRow.SL = row2.SL
            newRow.SizeId = drv!SizeId
            newRow.CuttingLayDetailsId = row2.CuttingLayDetailsId

            If MaxToStickerNo = 0 Then
                newRow.FromStickerNo = 1
            Else
                newRow.FromStickerNo = MaxToStickerNo + 1
            End If
            MaxToStickerNo = MaxToStickerNo + row2.LayQuantity
            newRow.ToStickerNo = newRow.FromStickerNo + row2.LayQuantity - 1
            Me.CuttingProductionNewDataSet.CuttingBundleDetails.Rows.Add(newRow)


        Next

        Save()

    End Sub
    Private Sub CalculateLayQuantity()

        Save()

        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            If Me.CuttingLayDetailsBindingSource.Position > -1 Then
                row.LayQuantity = ReadIntData("Select Sum(LayQuantity) From CuttingLayDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId, cnn)
                row.QuantityKg = ReadData("Select Sum(RollWeight) From CuttingLayDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId, cnn)
            End If

        End If

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If Me.CuttingProductionNewBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
            row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

            With frmBundleSheet
                .CPNId = row.CuttingProductionNewId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()
            End With

        End If
     

    End Sub

    Private Sub RecalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalculateButton.Click

        If Me.CuttingProductionNewDetailsBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
            row = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

            Dim MaxBundleNo As Integer = ReadIntData("Select Max(BundleNoSL) From CuttingBundleDetails Where CuttingProductionNewDetailsId in (Select CuttingProductionNewDetailsId From CuttingProductionNewDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId & ")", cnn)
            'Dim MaxFromStickerNo As Integer = ReadIntData("Select Max(BundleNo) From CuttingBundleDetails Where CuttingProductionNewDetailsId in (Select CuttingProductionNewDetailsId From CuttingProductionNewDetails Where CuttingProductionNewId=" & row.CuttingProductionNewId & ")", cnn)


            Dim TSN As Integer = 0
            Dim CQty As Integer = 0

            For Each drv As DataRowView In Me.CuttingBundleDetailsBindingSource.List

                Dim ToStickerNo As Integer = ReadIntData("Select Max(ToStickerNo) From CuttingBundleDetails Where CuttingProductionNewDetailsId =" & row.CuttingProductionNewDetailsId & " And BundleNoSL =" & drv!BundleNoSL - 1, cnn)

                If ToStickerNo = 0 Then

                    drv!FromStickerNo = 1
                    drv!ToStickerNo = drv!FromStickerNo + (drv!Quantity / row.Ratio) - 1
                    TSN = drv!FromStickerNo + (drv!Quantity / row.Ratio) - 1

                Else

                    drv!FromStickerNo = TSN + 1
                    drv!ToStickerNo = drv!FromStickerNo + (drv!Quantity / row.Ratio) - 1
                    TSN = drv!FromStickerNo + (drv!Quantity / row.Ratio) - 1
                End If

                CQty = CQty + drv!Quantity



            Next

            row.CuttingQuantity = CQty


        End If



    End Sub

   
    Private Sub CuttingLayDetailsDataGridView_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles CuttingLayDetailsDataGridView.RowsAdded
        'On Error Resume Next
        'Me.CuttingLayDetailsDataGridView.CurrentRow.Cells(0).Value = CuttingLayDetailsDataGridView.RowCount()
    End Sub


    Private Sub CuttingProductionNewBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingProductionNewBindingSource.PositionChanged

        On Error Resume Next

        Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
        row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

        Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, row.FabricColorId, row.OrderId)
        LoadCuttingProductionData(row.CuttingProductionNewId)
        CalculateCuttingAndInput()
        Me.CuttingProductionNewPODetailsTableAdapter.FillByCuttingProductionNewId(Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails, row.CuttingProductionNewId)
    End Sub
    Private Sub CalculateCuttingAndInput()
        On Error Resume Next
        Dim ttlRatio As Integer = 0
        Dim ttlCutting As Integer = 0
        Dim ttlRejection As Integer = 0
        Dim ttlReplaced As Integer = 0
        Dim ttlInput As Integer = 0
        Dim ttlQC As Integer = 0
        Dim ttlPrintSend As Integer = 0
        Dim ttlPrintReceive As Integer = 0

        For Each drv As DataRowView In CuttingProductionNewDetailsBindingSource.List

            If Not DBNull.Value.Equals(drv!Ratio) Then
                ttlRatio = ttlRatio + drv!Ratio
            Else
                ttlRatio = ttlRatio + 0
            End If

            If Not DBNull.Value.Equals(drv!CuttingQuantity) Then
                ttlCutting = ttlCutting + drv!CuttingQuantity
            Else
                ttlCutting = ttlCutting + 0
            End If

            If Not DBNull.Value.Equals(drv!TodayRejection) Then
                ttlRejection = ttlRejection + drv!TodayRejection
            Else
                ttlRejection = ttlRejection + 0

            End If

            If Not DBNull.Value.Equals(drv!TodayReplaced) Then
                ttlReplaced = ttlReplaced + drv!TodayReplaced
            Else
                ttlReplaced = ttlReplaced + 0

            End If

            If Not DBNull.Value.Equals(drv!InputQuantity) Then
                ttlInput = ttlInput + drv!InputQuantity
            Else
                ttlInput = ttlInput + 0

            End If

            If Not DBNull.Value.Equals(drv!TodayQC) Then
                ttlQC = ttlQC + drv!TodayQC
            Else
                ttlQC = ttlQC + 0

            End If

            If Not DBNull.Value.Equals(drv!PrintSend) Then
                ttlPrintSend = ttlPrintSend + drv!PrintSend
            Else
                ttlPrintSend = ttlPrintSend + 0
            End If

            If Not DBNull.Value.Equals(drv!PrintReceived) Then
                ttlPrintReceive = ttlPrintReceive + drv!PrintReceived
            Else
                ttlPrintReceive = ttlPrintReceive + 0
            End If


        Next

        RatioLabel.Text = ttlRatio
        CuttingLabel.Text = ttlCutting
        RejectionLabel.Text = ttlRejection
        ReplacedLabel.Text = ttlReplaced
        InputLabel.Text = ttlInput
        TotalQCLabel.Text = ttlQC
        TTLPrintSendLabel.Text = ttlPrintSend
        TTLPrintReceiveLabel.Text = ttlPrintReceive

    End Sub

    Private Sub ClearLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ClearLinkLabel.LinkClicked

        On Error Resume Next

        Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
        row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

        row.LineId = Nothing


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub



    Private Sub ShowByDateButton_Click(sender As Object, e As EventArgs) Handles ShowByDateButton.Click
        Me.CuttingProductionNewDataSet.CuttingProductionNew.CuttingDateColumn.DefaultValue = CuttingDateTimePicker.Text
        Me.CuttingProductionNewTableAdapter.FillByCuttingDate(Me.CuttingProductionNewDataSet.CuttingProductionNew, CuttingDateTimePicker.Text)
    End Sub

    Private Sub ShowbyBranchAndDateButton_Click(sender As Object, e As EventArgs) Handles ShowbyBranchAndDateButton.Click
        Me.CuttingProductionNewDataSet.CuttingProductionNew.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        If CuttingDateTimePicker.Text.ToString <> String.Empty Then
            Me.CuttingProductionNewTableAdapter.FillByCuttingDateAndBranch(Me.CuttingProductionNewDataSet.CuttingProductionNew, BranchComboBox.SelectedValue, CuttingDateTimePicker.Text)
        End If
    End Sub

    Private Sub SaveOLD()
        'Dim FirstMailRow As Integer = 0
        'Dim SecondMailRow As Integer = 0
        'Dim strTheBody As String = ""

        'Dim ExcessListString1 As String = "Excess Cutting Information (>1.05): "
        'Dim ExcessListString2 As String = "Excess Cutting Information (>1.07): "

        CalculateLayQuantity()
        GetSizeList()
        CalculateTotalCuttingAndPercentage()
        CalculateCuttingAndInput()

        'If CuttingProductionNewBindingSource.Position > -1 Then
        '    Dim row As CuttingProductionNewDataSet.CuttingProductionNewRow
        '    row = CType(CType(Me.CuttingProductionNewBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewRow)

        '    'Dim ProgramNo As String = ""
        '    'Dim ColorName As String = ""

        '    'Dim MaxCuttingNo As Integer = ReadIntData("Select Count(CuttingNo) As CuttingNo From CuttingProductionNew Where OrderId=" & row.OrderId & "AND FabricColorId=" & row.FabricColorId, cnn)

        '    'ProgramNo = ReadStringData("Select ProgramNo from [Order] Where OrderId=" & row.OrderId, cnn)
        '    'ColorName = ReadStringData("Select FabricColorName from FabricColor Where FabricColorId=" & row.FabricColorId, cnn)

        '    'MailString = "Excess Cutting : Order - " & ProgramNo & ", FabricColor - " & ColorName & ", TotalCutting - " & MaxCuttingNo & " Times"

        '    'ExcessListString1 = ExcessListString1 & vbCrLf & MailString
        '    'ExcessListString2 = ExcessListString2 & vbCrLf & MailString

        '    If CuttingProductionNewDetailsBindingSource.Position > -1 Then




        '        'For Each drv As DataRowView In CuttingProductionNewDetailsBindingSource.List

        '        '    Dim OrQty As Integer = 0

        '        '    If drv!OrderQuantity > 0 Then

        '        '        If drv!TotalCutting / drv!OrderQuantity > 1.05 Then

        '        '            Dim Size As String = ""

        '        '            Size = ReadStringData("Select SizeCode From Size Where SizeId=" & drv!SizeId, cnn)

        '        '            'SendSMTP("cutting@echotexbd.com", "Cutting", "noman@echotexbd.com", "Noman", "cutting@echotexbd.com", "Cutting", MailString, MailString, "", "")

        '        '            ExcessListString1 = ExcessListString1 & Environment.NewLine & "=> Size -  " & Size & " ,CuttingQuantity - " & drv!TotalCutting & " ,CuttingPercentage - " & FormatPercent(drv!TotalCutting / drv!OrderQuantity)
        '        '            FirstMailRow += 1


        '        '            ''==========
        '        '            'Dim myString As String = Me.TextBox1.Text
        '        '            '' string array to catch the separate lines of the multi line textbox
        '        '            'Dim strBody As String() = myString.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        '        '            'Dim linesToKeep As New List(Of String)
        '        '            '' Step 1 means that it includes all lines 
        '        '            'For index As Integer = 0 To strBody.GetUpperBound(0) Step 1
        '        '            '    linesToKeep.Add(strBody(index))
        '        '            'Next index
        '        '            ''display body of email n message box
        '        '            'MessageBox.Show(String.Join(Environment.NewLine, linesToKeep.ToArray()))



        '        '            'strTheBody = Environment.NewLine & "<p>Excess Cutting Information: </p>" & _
        '        '            '"<p>" & strBody(1) & "</p>"
        '        '            ''==========

        '        '        End If

        '        'If drv!TotalCutting / drv!OrderQuantity > 1.07 Then

        '        '    Dim Size2 As String = ""
        '        '    Size2 = ReadStringData("Select SizeCode From Size Where SizeId=" & drv!SizeId, cnn)

        '        '    'SendSMTP("amin@fareastknit.com", "IT", "mahmud.eis@gmail.com", "Mahmud", "amin@fareastknit.com", "IT", MailString, MailString, "", "")


        '        '    ExcessListString2 = ExcessListString2 & Environment.NewLine & " =>Size - " & Size2 & " ,CuttingQuantity - " & drv!TotalCutting & " ,CuttingPercentage - " & FormatPercent(drv!TotalCutting / drv!OrderQuantity)
        '        '    SecondMailRow += 1
        '        '    'Debug.Print(">1.07, SMR : " & SecondMailRow.ToString)

        '        'End If


        '        'End If

        '        'Next

        '    End If


        'If MessageBox.Show("Are you sure you want to save", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        Try

            Save()
            GetData()

            'If IsCuttingEdited = True Then

            '    If FirstMailRow > 0 Then

            '        SendSMTP("support@ksoftslns.com", "Cutting", "mahmud.eis@gmail.com", "mahmud", "support@ksoftslns.com", "Cutting", MailString, ExcessListString1, "", "")
            '        'MessageBox.Show(ExcessListString1)
            '        'Debug.Print(">1.05, FMR : " & FirstMailRow.ToString)

            '    End If

            '    If SecondMailRow > 0 Then

            '        SendSMTP("support@ksoftslns.com", "Cutting", "mahmud.eis@gmail.com", "mahmud", "support@ksoftslns.com", "Cutting", MailString, ExcessListString2, "", "")

            '        'MessageBox.Show(ExcessListString2)
            '        'Debug.Print(">1.07, SMR : " & SecondMailRow.ToString)

            '    End If

            '    IsCuttingEdited = False

            'End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        'ElseIf MessageBox.Show("Are you sure you want to save", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        'Exit Sub
        'End If



        'If (CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value / CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value) > 1.05 Then


        '    Dim Size As String = ""
        '    Dim Percentage As Decimal = (CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("TotalCutting").Value / CuttingProductionNewDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value)
        '    ProgramNo = ReadStringData("Select ProgramNo from [Order] Where OrderId=" & row.OrderId, cnn)
        '    ColorName = ReadStringData("Select FabricColorName from FabricColor Where FabricColorId=" & row.FabricColorId, cnn)
        '    Size = ReadStringData("Select SizeCode From Size Where SizeId=" & row1.SizeId, cnn)

        '    MailString = "Excess Cutting : Order - " & ProgramNo & ", FabricColor - " & ColorName & " , CuttingNo - " & row.CuttingNo & " ,Size -  " & Size & " , Percentage - " & FormatPercent(Percentage)
        '    SendSMTP("cutting@echotexbd.com", "Echo Information System", "cutting@echotexbd.com", "Mr. Shotadal", "cutting@echotexbd.com", "Echo Information System", MailString, "Testing Mail Firing System", "", "")

        '    If Percentage > 1.07 Then

        '        SendSMTP("cutting@echotexbd.com", "Cutting", "noman@echotexbd.com", "Noman", "cutting@echotexbd.com", "Cutting", MailString, MailString, "", "")
        '        SendSMTP("cutting@echotexbd.com", "Cutting", "redwan@echosourcing.com", "Redwan", "cutting@echotexbd.com", "Cutting", MailString, MailString, "", "")
        '        SendSMTP("cutting@echotexbd.com", "Cutting", "mahmud@echotexbd.com", "Mahmud", "cutting@echotexbd.com", "Cutting", MailString, MailString, "", "")

        '    End If

        'End If
        'Else

        'Exit Sub

        'End If
    End Sub

    Private Sub CuttingProductionNewDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles CuttingProductionNewDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub CuttingProductionNewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CuttingProductionNewDataGridView.CellContentClick

    End Sub

    Private Sub POGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CuttingProductionNewDetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CuttingProductionNewDetailsDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.CuttingProductionNewDetailsBindingSource.Position > -1 Then

            Dim row As CuttingProductionNewDataSet.CuttingProductionNewDetailsRow
            row = CType(CType(Me.CuttingProductionNewDetailsBindingSource.Current, DataRowView).Row, CuttingProductionNewDataSet.CuttingProductionNewDetailsRow)

            Me.CuttingProductionNewPODetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails, row.CuttingProductionNewDetailsId)

        End If

    End Sub

    Private Sub POLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles POLinkLabel.LinkClicked

        Try

            Me.CuttingProductionNewPODetailsBindingSource.RemoveCurrent()

            Save()


            'RefreshSummery()

        Catch ex As Exception

        End Try

    End Sub

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.CuttingProductionNewPODetailsTableAdapter.Fill(Me.CuttingProductionNewDataSet.CuttingProductionNewPODetails, CType(CuttingProductionNewdetailsIdToolStripTextBox.Text, Long))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class