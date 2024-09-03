Imports System.Data.SqlClient
Imports System.Data


Public Class frmFabricConsumption
    Dim AddFlag As Boolean = False

    'Private Sub FabricBOMBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMBindingNavigatorSaveItem.Click


    '    If GridLookUpEdit1.Text = String.Empty Then
    '        MessageBox.Show("Please,select a Program No", "Program No Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If

    '    Try
    '        Me.Validate()
    '        Me.FabricBOMBindingSource.EndEdit()
    '        Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

    '        OrderIdGridLookUpEdit.Enabled = False

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    '    If UserLevel = 1 Then
    '        Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
    '    Else
    '        Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
    '    End If

    '    Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


    'End Sub

    Private Sub frmFabricConsumption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.UserTableAdapter.Fill(Me.UserDataSet.User)

        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)

        'Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)


        If UserLevel = 1 Then
            Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
        Else
            Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
        End If

        'Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)

        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.SupplierTableAdapter.FillBySupplierType(Me.SupplierDataSet.Supplier, "Fabrics")


        If UserLevel = 1 Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Else
            Me.OrderLookupTableAdapter.FillByUserId(Me.OrderLookupDataSet.OrderLookup, UserId)
        End If


        Me.FabricBOMDataSet.FabricBOM.SupplierIdColumn.DefaultValue = 39


        'If UserLevel = 1 Then
        '    Me.FabricBOMTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOM)
        'Else
        '    Me.FabricBOMTableAdapter.FillByUserId(Me.FabricBOMDataSet.FabricBOM, UserId)
        'End If

        DisableControl(Me.SplitContainer1)

    End Sub

    Private Sub FabricBOMBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles FabricBOMBindingSource.AddingNew

        Me.FabricBOMDataSet.FabricBOM.UserIdColumn.DefaultValue = UserId
        Me.FabricBOMDataSet.FabricBOM.ModifiedOnColumn.DefaultValue = Today()
        Me.FabricBOMDataSet.Fabric.AmndNoColumn.DefaultValue = AmendmentNoSpinEdit.Value

    End Sub

    Private Sub FabricBOMDetailsBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles FabricBOMDetailsBindingSource.AddingNew

        Me.FabricBOMDataSet.FabricBOMDetails.UserIdColumn.DefaultValue = UserId
        Me.FabricBOMDataSet.FabricBOMDetails.ModifiedOnColumn.DefaultValue = Today()

    End Sub

    Private Sub OrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged, OrderIdGridLookUpEdit.Closed

        'If FabricBOMBindingSource.Position > -1 Then

        'Dim row As OrderLookupDataSet.OrderLookupRow
        'row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)
        On Error Resume Next

        If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = False Then

            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = OrderIdGridLookUpEdit.EditValue
            Me.FabricTableAdapter.FillByAmndNo(Me.FabricBOMDataSet.Fabric, OrderIdGridLookUpEdit.EditValue, AmendmentNoSpinEdit.Value)
            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OrderIdGridLookUpEdit.EditValue)
            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " Group By POGroup", cnn)

            ErrorProvider1.Clear()

        End If

        'End If

    End Sub

    Private Sub FabricDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FabricDataGridView.RowHeaderMouseDoubleClick

        If Val(FabricBOMIdLabel1.Text) < 1 Then
            Exit Sub
            MessageBox.Show("Please,save first to work in details", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If FabricBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)


            Dim rowGSM As GSMDataSet.GSMRow
            rowGSM = CType(CType(Me.GSMBindingSource.Current, DataRowView).Row, GSMDataSet.GSMRow)

            Dim consumption As Decimal = 0

            If row.GMQuantity = 0 Then

                MessageBox.Show("Require Garments Quantity", "Missing Data!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Dim Length As Decimal = CDec(row.MarkerLengthYrds) * 36 + CDec(row.MarkerLengthInch) + row.LengthAllowance
                Dim Width As Decimal = CDec(row.MarkerWidth) + CDec(row.WidthAllowance)
                Dim GSM As Decimal = ReadData("Select GSM From GSM Where GSMId=" & row.GSMId, cnn)
                Dim MarkerQuantity As Decimal = row.GMQuantity
                Dim WP As Decimal = (1 + row.WastagePercentage / 100)

                consumption = Length * Width * GSM / MarkerQuantity * 12 / 1550 / 1000 * WP

            End If

            Me.FabricBOMDataSet.FabricBOMDetails.FabricIdColumn.DefaultValue = row.FabricId
            Me.FabricBOMDataSet.FabricBOMDetails.UserIdColumn.DefaultValue = UserId
            Me.FabricBOMDataSet.FabricBOMDetails.ConsumptionColumn.DefaultValue = FormatNumber(consumption, 2)
            Me.FabricBOMDataSet.FabricBOMDetails.WastagePercentageColumn.DefaultValue = row.WastagePercentage
            Me.FabricBOMDataSet.FabricBOMDetails.ModifiedOnColumn.DefaultValue = Today()
            Me.FabricBOMDataSet.FabricBOMDetails.DyeingPricePerUnitColumn.DefaultValue = 0
            Me.FabricBOMDataSet.FabricBOMDetails.KnittingPricePerUnitColumn.DefaultValue = 0

            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OrderIdGridLookUpEdit.EditValue)
            FabricViewBindingSource.ResetBindings(True)

            FabricBOMDetailsBindingSource.AddNew()






        End If


    End Sub

    Private Sub FabricBOMDetailsDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FabricBOMDetailsDataGridView.CellEndEdit


        If FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Part" Then

            Try
                Me.Validate()
                Me.FabricBOMBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Order Quantity" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.FinishFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity), 0)
            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)


        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Con" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.FinishFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity), 0)
            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "GP(%)" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Additional Quantity" Then


            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + (row.AdditionalQuantity * (1 + row.GreyPercentage / 100)), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        End If

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        Me.Validate()
        Me.FabricBOMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

        Dim row As FabricBOMDataSet.FabricBOMRow
        row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)


        frmFabricBOMInstruction.FabricBOMId = row.FabricBOMId
        ShowMaster(frmFabricBOMInstruction)

    End Sub

    Private Sub FabricBOMDetailsDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FabricBOMDetailsDataGridView.KeyDown



        If e.KeyData = Keys.F10 Or e.KeyData = Keys.Control + Keys.F10 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

            If FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Fabric Color" Then

                frmOrderFabricColor.prOrderId = row.OrderId
                ShowMaster(frmOrderFabricColor)

                If frmOrderFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Dim OrderQuantity As Integer = ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderId=" & row.OrderId & " AND FabricColorId=" & FabricColorIdvar, cnn)
                    Dim ColorCode As String = ReadStringData("Select Distinct Code From OrderDetails Where OrderId=" & row.OrderId & " AND FabricColorId=" & FabricColorIdvar, cnn)
                    FabricBOMDetailsDataGridView.CurrentRow.Cells("FabricColorId").Value = FabricColorIdvar
                    FabricBOMDetailsDataGridView.CurrentRow.Cells("GarmentsColorId").Value = FabricColorIdvar
                    FabricBOMDetailsDataGridView.CurrentRow.Cells("ColorCode").Value = ColorCode
                    FabricBOMDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value = OrderQuantity

                    Dim FFQuantity As Integer = (OrderQuantity / 12) * FabricBOMDetailsDataGridView.CurrentRow.Cells("Consumption").Value

                    FabricBOMDetailsDataGridView.CurrentRow.Cells("FinishFabricQuantity").Value = FFQuantity

                    Me.Validate()
                    Me.FabricBOMBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

                    Dim row1 As FabricBOMDataSet.FabricBOMDetailsRow
                    row1 = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

                    FabricBOMDetailsDataGridView.CurrentRow.Cells("GreyFabricQuantity").Value = FFQuantity * (1 + row1.GreyPercentage / 100) + (row1.AdditionalQuantity * (1 + row1.GreyPercentage / 100))


                End If

            ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Garments Color" Then

                frmOrderFabricColor.prOrderId = row.OrderId
                ShowMaster(frmOrderFabricColor)

                If frmOrderFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    'Dim OrderQuantity As Integer = ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderId=" & row.OrderId & " AND FabricColorId=" & FabricColorIdvar, cnn)
                    'Dim ColorCode As String = ReadStringData("Select Distinct Code From OrderDetails Where OrderId=" & row.OrderId & " AND FabricColorId=" & FabricColorIdvar, cnn)
                    'FabricBOMDetailsDataGridView.CurrentRow.Cells("FabricColorId").Value = FabricColorIdvar
                    FabricBOMDetailsDataGridView.CurrentRow.Cells("GarmentsColorId").Value = FabricColorIdvar
                    'FabricBOMDetailsDataGridView.CurrentRow.Cells("ColorCode").Value = ColorCode
                    'FabricBOMDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value = OrderQuantity
                    'Dim FFQuantity As Integer = (OrderQuantity / 12) * FabricBOMDetailsDataGridView.CurrentRow.Cells("Consumption").Value

                    'FabricBOMDetailsDataGridView.CurrentRow.Cells("FinishFabricQuantity").Value = FFQuantity

                    'Me.Validate()
                    'Me.FabricBOMBindingSource.EndEdit()
                    'Me.FabricBOMDetailsBindingSource.EndEdit()
                    'Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

                    'Dim row1 As FabricBOMDataSet.FabricBOMDetailsRow
                    'row1 = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

                    'FabricBOMDetailsDataGridView.CurrentRow.Cells("GreyFabricQuantity").Value = FFQuantity * (1 + row1.GreyPercentage / 100) + (row1.AdditionalQuantity * (1 + row1.GreyPercentage / 100))


                End If

            ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Order Quantity" Then

                Dim row1 As FabricBOMDataSet.FabricBOMDetailsRow
                row1 = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)


                frmOrderQuantity.FabricColorId = row1.FabricColorId
                frmOrderQuantity.OrderId = row.OrderId
                ShowMaster(frmOrderQuantity)

                If frmOrderQuantity.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.FabricBOMDetailsDataGridView.CurrentRow.Cells("OrderQuantity").Value = frmOrderQuantity.OrderQuantity
                End If

            End If

        ElseIf e.KeyData = Keys.F11 Or e.KeyData = Keys.Control + Keys.F11 Then

            ShowMaster(frmFabricColor)

            If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then
                '***
                Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
                FabricBOMDetailsDataGridView.CurrentRow.Cells("FabricColorId").Value = FabricColorIdvar

            End If


        End If
    End Sub

    Private Sub AmendmentSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmendmentSimpleButton.Click

        If FabricBOMBindingSource.Position > -1 Then


            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

            Dim MaxAmndNO As Integer = ReadIntData("Select Max(AmendmentNo) From FabricBOM Where OrderId=" & row.OrderId, cnn)
            Dim CurrentFabricBOMId As Integer = row.FabricBOMId

            If MaxAmndNO > AmendmentNoSpinEdit.Value Then

                MessageBox.Show("Select Max Amendmnet No and try again", "Amendment No", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

            If Me.FabricBindingSource.Position = -1 Then
                MessageBox.Show("Fabric is not Available", "Missing...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.FabricBOMDetailsBindingSource.Position = -1 Then
                MessageBox.Show("Fabric Booking Details is not available", "Missing...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            If MessageBox.Show("Are you sure u want to amendment this booking ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then


                Dim FBRow As FabricBOMDataSet.FabricBOMRow
                FBRow = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

                Dim AmndNo As Integer = ReadIntData("Select Max(AmendmentNo) From FabricBOM Where OrderId=" & FBRow.OrderId, cnn)


                ExecuteQuery("Insert Into FabricBOM(OrderId,FabricBookingDate,FabricReqDate,SupplierId,ExplationForAdditionalFabricQty,CheckWith,ProceedForKnitting,ProceedForDyeing,MarkerDia,MarkerLength,AmendmentNo,AmendmentDetails,AmendmentDate,Discontinue,CauseofDiscontinue,WashReference,SampleReference,IsPrint,PrintDetails,IsAOP,AOPDetails,WashDetails,SampleDetails,UserId,ModifiedOn,ProgramComments)" &
                             " Select OrderId,FabricBookingDate,FabricReqDate,SupplierId,ExplationForAdditionalFabricQty,CheckWith,ProceedForKnitting,ProceedForDyeing,MarkerDia,MarkerLength ," & AmndNo + 1 & "As AmendmentNo, AmendmentDetails,AmendmentDate,Discontinue,CauseofDiscontinue,WashReference,SampleReference,IsPrint,PrintDetails,IsAOP,AOPDetails,WashDetails,SampleDetails,UserId,ModifiedOn,ProgramComments From FabricBOM Where OrderId=" & FBRow.OrderId & " And AmendmentNo=" & AmndNo, cnn)

                ExecuteQuery("Insert Into FabricBOMDetails(FabricBOMId,FabricColorId,ELDNo,OrderQuantity,FabricId,Consumption,WastagePercentage,AdditionalQuantity,FinishFabricQuantity,GreyPercentage,GreyFabricQuantity,Remarks,UserId,ModifiedOn,GarmentsPartId,ColorCode,Discontinue,CCSize,DyeingPricePerUnit,KnittingPricePerUnit)" &
                             " Select (Select Max(FabricBOMId)As FabricBOMId From FabricBOM Where OrderId=" & FBRow.OrderId & ")as FabricBOMId,FabricColorId,ELDNo,OrderQuantity,FabricId,Consumption,WastagePercentage,AdditionalQuantity,FinishFabricQuantity,GreyPercentage,GreyFabricQuantity,Remarks,UserId,ModifiedOn,GarmentsPartId,ColorCode,Discontinue,CCSize,DyeingPricePerUnit,KnittingPricePerUnit From FabricBOMDetails Where FabricBOMId=" & FBRow.FabricBOMId, cnn)


                'ExecuteQuery("Update Fabric Set PreviousFabricId=FabricId Where OrderId=" & FBRow.OrderId & "And AmndNo=" & AmndNo, cnn)
                'ExecuteQuery("Insert Into Fabric(OrderId,FabricColorId,KnittingTypeId,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo)" & _
                '                  "Select OrderId,FabricColorId,KnittingTypeId,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,(Select Max(AmndNo) as AmndNo From Fabric Where OrderId=" & FBRow.OrderId & ") From Fabric Where OrderId=" & FBRow.OrderId & "And AmndNo=" & AmndNo, cnn)


                'ExecuteQuery("Update FabricBOM Set FabricBOMId=" & AmndNo + 1 & " Where FabricBOMId=(Select Max(FabricBOMId) From FabricBOM Where OrderId=" & FBRow.OrderId & ")", cnn)




                For Each drv As DataRowView In FabricBindingSource.List

                    ExecuteQuery("Insert Into Fabric(PreFabricId,OrderId,FabricColorId,KnittingTypeId,CompositionId,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo,SPNote)" &
                                   "Select " & drv!FabricId & "As PreFabricId,OrderId,FabricColorId,KnittingTypeId,CompositionId,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,(Select Distinct " & AmndNo + 1 & "as AmndNo From Fabric Where OrderId=" & FBRow.OrderId & "),SPNote From Fabric Where FabricId=" & drv!FabricId, cnn)

                    Dim MaxFabricId As Integer = ReadIntegerData("Select Max(FabricId) From Fabric Where OrderId=" & FBRow.OrderId, cnn)
                    Dim MaxFabricBOMId As Integer = ReadIntegerData("Select Max(FabricBOMId)As FabricBOMId From FabricBOM Where OrderId=" & FBRow.OrderId, cnn)

                    ExecuteQuery("Update FabricBOMDetails Set FabricId=" & MaxFabricId & " Where FabricId=" & drv!FabricId & " and FabricBOMId=" & MaxFabricBOMId, cnn)


                    'MessageBox.Show(FBRow.OrderId.ToString & "/" & AmndNo.ToString)

                Next


                Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)
                Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails)

                Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, FBRow.FabricBOMId)



                Dim row1 As FabricBOMDataSet.FabricBOMRow
                row1 = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)


                Me.FabricTableAdapter.FillByAmndNo(Me.FabricBOMDataSet.Fabric, row1.OrderId, row1.AmendmentNo)

                ExecuteQuery("Insert Into FabricBOMInstruction(FabricBOMId,SLNo,Remarks)Select " & row1.FabricBOMId & " As FabricBOMId,SLNo,Remarks From FabricBOMInstruction Where FabricBOMId=" & CurrentFabricBOMId, cnn)

            Else

                Exit Sub

            End If

        End If
    End Sub


    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged, GridLookUpEdit1.Closed


        


    End Sub


    Private Sub PrintSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSimpleButton.Click

        If Me.FabricBOMBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)



            With frmFabricConsumptionPrint

                .MdiParent = frmMain
                .FabricBOMId = row.FabricBOMId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If


    End Sub

    Private Sub FabricBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles FabricBindingSource.AddingNew

        If FabricBOMBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = row.OrderId

        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        OrderIdGridLookUpEdit.Enabled = True
        OrderIdGridLookUpEdit.Focus()


    End Sub

    Private Sub FabricDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FabricDataGridView.KeyDown




        If e.KeyData = Keys.F3 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

            Dim row1 As FabricBOMDataSet.FabricRow
            row1 = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)



            ExecuteQuery("Insert Into Fabric(OrderId,FabricColorId,KnittingTypeId,SPNote,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo)" & _
                             "Select OrderId,FabricColorId,KnittingTypeId,SPNote,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo From Fabric Where FabricId=" & row1.FabricId, cnn)

            Me.FabricTableAdapter.FillByAmndNo(Me.FabricBOMDataSet.Fabric, row1.OrderId, AmendmentNoSpinEdit.Value)
            Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


        End If

    End Sub

    Private Sub FabricDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FabricDataGridView.CellClick

        ' FabricDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If UserLevel = 1 Then

            Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
        Else
            Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)

        End If

    End Sub



    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click


        If SaveButton.Text = "&Save" Then
            MessageBox.Show("Please,save first.", "Save Require", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaveButton.Focus()
            Exit Sub
        End If


        If NewButton.Text = "&Add" Then

            Me.FabricBOMBindingSource.AddNew()
            'Me.BookingDateDateEdit.Focus()
            AddFlag = True
            NewButton.Text = "&Save"
            NewButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            SaveButton.Enabled = False
            OrderIdGridLookUpEdit.Enabled = True
            OrderIdGridLookUpEdit.Focus()
            GridLookUpEdit1.Enabled = False
            EnableControl(Me.SplitContainer1)


        Else

           


            If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = True Then

                'MessageBox.Show("Select a Program No", "Program No Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(OrderIdGridLookUpEdit, "Program No is Require")
                OrderIdGridLookUpEdit.Focus()
                Exit Sub
            Else
                ErrorProvider1.Clear()
            End If


            

            If AddFlag = True Then

                Dim OrdId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & OrderIdGridLookUpEdit.Text & "'", cnn)
                Dim PrgCount As Integer = ReadIntData("Select Count(*) From FabricBOM Where OrderId=" & OrdId, cnn)

                If PrgCount > 0 Then

                    NewButton.Text = "&Add"
                    SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
                    SaveButton.Enabled = True
                    DisableControl(Me.SplitContainer1)
                    OrderIdGridLookUpEdit.Enabled = False
                    MessageBox.Show("The mentioned Booking is already exists", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM,)
                    'Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OrderIdGridLookUpEdit.EditValue)

                    Exit Sub

                End If

            End If


            'If Me.FabricBOMDetailsBindingSource.Position > -1 Then

            '    For Each drv As DataRowView In FabricBOMDetailsBindingSource.List

            '        If drv!DyeingPricePerUnit <= 0 Then
            '            MessageBox.Show("Dyeing Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '            Exit Sub
            '        End If

            '        If drv!KnittingPricePerUnit <= 0 Then
            '            MessageBox.Show("Knitting Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '            Exit Sub
            '        End If

            '    Next

            'End If


            Try

                Me.Validate()
                Me.FabricBOMBindingSource.EndEdit()
                Me.FabricBOMDetailsBindingSource.EndEdit()
                Me.FabricBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

                AddFlag = False


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            If UserLevel = 1 Then
                Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
            Else
                Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
            End If

            Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


            NewButton.Text = "&Add"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
            SaveButton.Enabled = True
            DisableControl(Me.SplitContainer1)
            OrderIdGridLookUpEdit.Enabled = False
            GridLookUpEdit1.Enabled = True
        End If


    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If Me.FabricBOMBindingSource.Position = -1 Then
            Exit Sub
        End If

        If Me.FabricBOMDetailsBindingSource.Position > -1 Then

            For Each drv As DataRowView In FabricBOMDetailsBindingSource.List

                If drv!DyeingPricePerUnit < 0.001 Then
                    MessageBox.Show("Dyeing Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If drv!KnittingPricePerUnit < 0.001 Then
                    MessageBox.Show("Knitting Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            Next
        End If

        If SaveButton.Text = "&Edit" Then

            SaveButton.Text = "&Save"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            NewButton.Enabled = False
            EnableControl(Me.SplitContainer1)
            GridLookUpEdit1.Enabled = False

        Else

            If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = True Then

                'MessageBox.Show("Select a Program No", "Program No Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(OrderIdGridLookUpEdit, "Program No is Require")
                OrderIdGridLookUpEdit.Focus()
                Exit Sub
            Else
                ErrorProvider1.Clear()
            End If


            Try

                Me.Validate()
                Me.FabricBOMBindingSource.EndEdit()
                Me.FabricBOMDetailsBindingSource.EndEdit()
                Me.FabricBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

                OrderIdGridLookUpEdit.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            If UserLevel = 1 Then
                Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
            Else
                Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
            End If

            Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


            SaveButton.Text = "&Edit"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Edit
            NewButton.Enabled = True
            DisableControl(Me.SplitContainer1)
            GridLookUpEdit1.Enabled = True


        End If



    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        If FabricBOMBindingSource.Position = -1 Then
            Exit Sub
        End If


        If FabricBOMDetailsBindingSource.Position > -1 Then
            MessageBox.Show("You should delete Fabric Booking Details of the booking.", "Fabric Booking Details Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf FabricBindingSource.Position > -1 Then
            MessageBox.Show("You should delete Fabric of the booking.", "Fabric is Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        MessageBox.Show("Are you sure you want to delete the booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgBoxResult.Yes Then

            FabricBOMBindingSource.RemoveCurrent()

            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Exit Sub

        End If

    End Sub

    Private Sub FabricBOMDetailsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles FabricBOMDetailsDataGridView.DataError
        On Error Resume Next

    End Sub


    Private Sub FabricDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricDataGridView.Enter

        Me.FabricBOMBindingSource.EndEdit()
        Me.FabricBOMDataSet.Fabric.AmndNoColumn.DefaultValue = AmendmentNoSpinEdit.Value

    End Sub


    Private Sub SplitContainer2_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer2.SplitterMoved

    End Sub


    Private Sub GridLookUpEdit1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.Enter

    End Sub


    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCCancelButton.Click
        Reset()
    End Sub

    Private Sub Reset()

        NewButton.Text = "&Add"
        NewButton.Enabled = True
        SaveButton.Text = "&Edit"
        SaveButton.Enabled = True
        GridLookUpEdit1.Enabled = True
        ErrorProvider1.Clear()

        If FabricBOMIdSearchBindingSource.Position > -1 Then
            'On Error Resume Next

            'Dim row As FabricBOMIdSearchDataSet.FabricBOMIdSearchRow
            'row = CType(CType(Me.FabricBOMIdSearchBindingSource.Current, DataRowView).Row, FabricBOMIdSearchDataSet.FabricBOMIdSearchRow)

            'Dim OrderId As Integer = 0

            'If DBNull.Value.Equals(Me.OrderIdGridLookUpEdit.EditValue) <> True Then
            '    OrderId = OrderIdGridLookUpEdit.EditValue
            '    Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = OrderId
            'Else

            'End If

            Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, 0)
            Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails)
            Me.FabricTableAdapter.FillByAmndNo(Me.FabricBOMDataSet.Fabric, 0, 0)
            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & 0, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & 0 & " Group By POGroup", cnn)

            OrderIdGridLookUpEdit.Enabled = False



        End If


    End Sub

    Private Sub FabricBOMDetailsDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMDetailsDataGridView.Enter
        Me.FabricBOMBindingSource.EndEdit()
    End Sub

    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click
        '===============
        'Copying...
        '================

        If Me.FabricBindingSource.Position = -1 Then

            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim OrId As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim AmndNo As Integer = ReadIntData("Select AmendmentNo From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim sqlstring As String = "Select FabricId,OrderId,KnittingTypeId,GSMId,FinishFabricDia,DiaType,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo,CompositionId,SPNote From Fabric Where OrderId=" & OrId & "And AmndNo=" & AmndNo
            Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            'Dim list As New AutoCompleteStringCollection

            While reader.Read

                If reader.IsDBNull(0) = False Then

                    'list.Add(reader.GetString(0))

                    Dim newRow As FabricBOMDataSet.FabricRow = Me.FabricBOMDataSet.Fabric.NewRow()

                    On Error Resume Next

                    newRow.OrderId = OrderIdGridLookUpEdit.EditValue
                    newRow.KnittingTypeId = reader("KnittingTypeId").ToString
                    newRow.GSMId = reader("GSMId").ToString
                    newRow.FinishFabricDia = reader("FinishFabricDia").ToString
                    newRow.DiaType = reader("DiaType").ToString
                    newRow.MarkerLengthYrds = reader("MarkerLengthYrds").ToString
                    newRow.MarkerLengthInch = reader("MarkerLengthInch").ToString
                    newRow.MarkerWidth = reader("MarkerWidth").ToString
                    newRow.LengthAllowance = reader("LengthAllowance")
                    newRow.WidthAllowance = reader("WidthAllowance")
                    'newRow.WashReference = reader("WashReference")
                    newRow.GMQuantity = reader("GMQuantity")
                    newRow.DiaUnit = reader("DiaUnit")
                    newRow.FinishUnit = reader("FinishUnit")
                    newRow.AmndNo = Me.AmendmentNoSpinEdit.Value
                    newRow.CompositionId = reader("CompositionId")
                    newRow.SPNote = reader("SPNote")
                    newRow.CopyFrom = reader("FabricId").ToString

                    Me.FabricBOMDataSet.Fabric.Rows.Add(newRow)

                End If

            End While

            reader.Close()
            connection.Close()

        End If
        '===========================
        'Saving to get Fabric Id ...
        '===========================

        Me.Validate()
        Me.FabricBOMBindingSource.EndEdit()
        Me.FabricBOMDetailsBindingSource.EndEdit()
        Me.FabricBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

        '===================
        'Getting Details ...
        '===================

        If FabricBOMDetailsBindingSource.Position = -1 Then


            Dim connection2 As New SqlConnection(cnn)
            connection2.Open()

            'Dim OrId As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
            'Dim AmndNo As Integer = ReadIntData("Select AmendmentNo From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)

            Dim sqlstring As String = "Select FabricBOMId,GarmentsPartId,FabricColorId,ELDNo,FabricId,Consumption,WastagePercentage,GreyPercentage,Remarks,CCSize,KgPerUnit From FabricBOMDetails Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue
            Dim cmd2 As SqlCommand = New SqlCommand(sqlstring, connection2)
            Dim reader2 As SqlDataReader = cmd2.ExecuteReader()


            While reader2.Read

                If reader2.IsDBNull(0) = False Then

                    'list.Add(reader.GetString(0))

                    Dim newRow As FabricBOMDataSet.FabricBOMDetailsRow = Me.FabricBOMDataSet.FabricBOMDetails.NewRow()

                    On Error Resume Next

                    newRow.FabricBOMId = Me.FabricBOMIdLabel1.Text
                    newRow.GarmentsPartId = reader2("GarmentsPartId").ToString
                    newRow.FabricColorId = reader2("FabricColorId").ToString
                    newRow.ELDNo = reader2("ELDNo").ToString

                    Dim FId As Integer = ReadIntegerData("Select FabricId From Fabric Where CopyFrom=" & reader2("FabricId").ToString, cnn)
                    newRow.FabricId = FId
                    newRow.Consumption = reader2("consumption").ToString
                    newRow.WastagePercentage = reader2("WastagePercentage").ToString
                    newRow.GreyPercentage = reader2("GreyPercentage").ToString
                    newRow.Remarks = reader2("Remarks").ToString
                    newRow.CCSize = reader2("CCSize").ToString

                    Me.FabricBOMDataSet.FabricBOMDetails.Rows.Add(newRow)

                End If

            End While

            reader2.Close()
            connection2.Close()


        End If

    End Sub

   
    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If FabricBOMIdSearchBindingSource.Position > -1 Then

            Dim row As FabricBOMIdSearchDataSet.FabricBOMIdSearchRow
            row = CType(CType(Me.FabricBOMIdSearchBindingSource.Current, DataRowView).Row, FabricBOMIdSearchDataSet.FabricBOMIdSearchRow)

            Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails)
            Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, row.FabricBOMId)
            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = row.OrderId
            Me.FabricTableAdapter.FillByAmndNo(Me.FabricBOMDataSet.Fabric, row.OrderId, row.AmendmentNo)
            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, row.OrderId)

            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & row.OrderId, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & row.OrderId & " Group By POGroup", cnn)

            OrderIdGridLookUpEdit.Enabled = False

        End If

    End Sub
End Class