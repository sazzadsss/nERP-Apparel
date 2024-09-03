Imports System.Data.SqlClient
Imports System.Data


Public Class frmFabricBooking_Bulk
    Dim AddFlag As Boolean = False
    Dim FBDId As Integer
    Dim ProFlag As Boolean = False

    Private _PreFabricColorid As Integer
    Public Property PrefabricColorId() As Integer
        Get
            Return _PreFabricColorid
        End Get
        Set(ByVal value As Integer)
            _PreFabricColorid = value
        End Set
    End Property

    Private _PreGMTColorId As Integer
    Public Property PreGMTColorId() As Integer
        Get
            Return _PreGMTColorId
        End Get
        Set(ByVal value As Integer)
            _PreGMTColorId = value
        End Set
    End Property
    Private _PreFabColorCode As String
    Public Property PreFabColorCode() As String
        Get
            Return _PreFabColorCode
        End Get
        Set(ByVal value As String)
            _PreFabColorCode = value
        End Set
    End Property

    Private _PreFabColorReference As String
    Public Property PreFabColorReference() As String
        Get
            Return _PreFabColorReference
        End Get
        Set(ByVal value As String)
            _PreFabColorReference = value
        End Set
    End Property
    Private _NewFabricColorId As Integer
    Public Property NewFabricColorId() As Integer
        Get
            Return _NewFabricColorId
        End Get
        Set(ByVal value As Integer)
            _NewFabricColorId = value
        End Set
    End Property

    Private _NewGMTColorId As Integer
    Public Property NewGMTColorId() As Integer
        Get
            Return _NewGMTColorId
        End Get
        Set(ByVal value As Integer)
            _NewGMTColorId = value
        End Set
    End Property
    Private _NewFabColorCode As String '//
    Public Property NewFabColorCode() As String
        Get
            Return _NewFabColorCode
        End Get
        Set(ByVal value As String)
            _NewFabColorCode = value
        End Set
    End Property
    Private _NewFabColorReferece As String
    Public Property NewFabColorRerence() As String
        Get
            Return _NewFabColorReferece
        End Get
        Set(ByVal value As String)
            _NewFabColorReferece = value
        End Set
    End Property


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

        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        '
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, YarnStoreId)


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
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        With YarnDyeingTypeGridLookUpEdit

            .ForceInitialize() ' Force it to initialize
            .DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "YarnDyeingTypeId", True))
            .Properties.DataSource = GetYarnDyingType()
            .Properties.DisplayMember = "YarnDyeingType"
            .Properties.ValueMember = "YarnDyeingTypeId"
            .Properties.PopulateViewColumns() ' Force the lookupedit to populate
            .Properties.View.Columns("YarnDyeingTypeId").Visible = False

        End With

        'If UserLevel = 1 Then
        '    Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        'Else
        Me.OrderLookupTableAdapter.FillByUserId(Me.OrderLookupDataSet.OrderLookup, UserId)
        'Me.OrderLookupTableAdapter.FillByBuyerAsign(Me.OrderLookupDataSet.OrderLookup, UserId)
        'End If


        Me.FabricBOMDataSet.FabricBOM.SupplierIdColumn.DefaultValue = -1
        Me.FabricBOMDataSet.FabricBOM.FabricBookingDateColumn.DefaultValue = Today()
        Me.FabricBOMDataSet.FabricBOM.Signature1UserIdColumn.DefaultValue = ReadIntegerData("Select UserId From Signature Where Interface='FabricBOM' And SignatureSL=1", cnn)
        Me.FabricBOMDataSet.FabricBOM.Signature2UserIdColumn.DefaultValue = UserId
        Me.FabricBOMDataSet.FabricBOM.Signature3UserIdColumn.DefaultValue = ReadIntegerData("Select ReportTo From [User] Where User_Id=" & UserId, cnn)
        Me.FabricBOMDataSet.FabricBOM.Signature4UserIdColumn.DefaultValue = ReadIntegerData("Select UserId From Signature Where Interface='FabricBOM' And SignatureSL=4", cnn)



        'If UserLevel = 1 Then
        '    Me.FabricBOMTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOM)
        'Else
        '    Me.FabricBOMTableAdapter.FillByUserId(Me.FabricBOMDataSet.FabricBOM, UserId)
        'End If

        SplitContainer6.Panel1Collapsed = False
        SplitContainer6.Panel2Collapsed = True
        SplitContainer4.Panel2Collapsed = True

        DisableControl(Me.SplitContainer1)


        If CheckUserRights("Fabric Booking BULK").CanEdit = False Then

            NewButton.Enabled = False
            SaveButton.Enabled = False
            DeleteButton.Enabled = False
            CnclButton.Enabled = False

        ElseIf CheckUserRights("Fabric Booking BULK").CanDelete = False Then
            NewButton.Enabled = True
            SaveButton.Enabled = True
            DeleteButton.Enabled = False
            CnclButton.Enabled = False
        End If



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


        On Error Resume Next

        If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = False Then

            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = OrderIdGridLookUpEdit.EditValue
            Me.FabricTableAdapter.FillOrderId(Me.FabricBOMDataSet.Fabric, OrderIdGridLookUpEdit.EditValue)
            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OrderIdGridLookUpEdit.EditValue)
            Me.OrderSizeLookupTableAdapter.Fill(Me.OrderSizeDataSet.OrderSizeLookup, Me.OrderIdGridLookUpEdit.EditValue)
            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, Me.OrderIdGridLookUpEdit.EditValue)


            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " Group By POGroup", cnn)
            OrderQuantityTextEdit.Text = ReadIntegerData("Select OrderQuantity From OrderQuantitySummery Where OrderId = " & OrderIdGridLookUpEdit.EditValue, cnn)

            If IsFabricBOMCompleteCheckEdit.Checked = False Then
                UpdateMore()
            End If

            ErrorProvider1.Clear()

        End If



    End Sub

    Private Sub FabricDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

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

            Save()

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Order Quantity" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.FinishFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity), 2)
            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)


        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Con" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.FinishFabricQuantity = FormatNumber(CDec(row.Consumption) * CDec(row.OrderQuantity) / 12, 2)
            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) * CDec(row.OrderQuantity) / 12 * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "GP(%)" Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) * CDec(row.OrderQuantity) / 12 * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        ElseIf FabricBOMDetailsDataGridView.Columns(FabricBOMDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Additional Quantity" Then


            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) * CDec(row.OrderQuantity) / 12 * (1 + row.GreyPercentage / 100) + (row.AdditionalQuantity * (1 + row.GreyPercentage / 100)), 0)

            FabricBOMDetailsBindingSource.ResetBindings(True)

        End If

    End Sub

    Private Sub AdditionalCommentsSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionalCommentsSimpleButton.Click

        Save()

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

                    Dim FFQuantity As Double = (OrderQuantity / 12) * FabricBOMDetailsDataGridView.CurrentRow.Cells("Consumption").Value

                    FabricBOMDetailsDataGridView.CurrentRow.Cells("FinishFabricQuantity").Value = FFQuantity

                    Save()

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

            If Me.FabricBindingSource.Position = -1 Then
                MessageBox.Show("Fabric is not Available", "Missing...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.FabricBOMDetailsBindingSource.Position = -1 Then
                MessageBox.Show("Fabric Booking Details is not available", "Missing...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'If FDStatus() = False Then
            '    MessageBox.Show("No Need to Amendment, You can Edit.", "Missing...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If MessageBox.Show("Are you sure you want to AMENDMENT this booking ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Dim AmndDetails As String = InputBox("Enter Amendment Details.", "Amendment Details", "")

                If AmndDetails = String.Empty Then
                    MessageBox.Show("Not Allowed without Amendment Details", "Message")
                    Exit Sub
                End If

                AmendmentDetailsTextEdit.Text = AmndDetails

                ExecuteQuery("Insert Into FabricBOM_History(FabricBOMId,OrderId,FabricBookingDate,FabricReqDate,SupplierId,ExplationForAdditionalFabricQty,CheckWith,ProceedForKnitting,ProceedForDyeing,MarkerDia,MarkerLength,AmendmentNo,AmendmentDetails,AmendmentDate,Discontinue,CauseofDiscontinue,WashReference,SampleReference,IsPrint,PrintDetails,IsAOP,AOPDetails,WashDetails,SampleDetails,UserId,ModifiedOn,ProgramComments,DyeingComments,CuttingWP,Signature1,Signature2,Signature3,Signature4,Signature1Date,Signature2Date,Signature3Date,Signature4Date,Signature1UserId,Signature2UserId,Signature3UserId,Signature4UserId,IsPeachFinish,IsBrush,IsYDS,WashTypeId,IsWash,OrderQuantity,ProccedDate,IsEmbroidery,EmbroideryDetails,IsFabricBOMComplete,PO,YarnDyeingTypeId)" &
                             " Select FabricBOMId,OrderId,FabricBookingDate,FabricReqDate,SupplierId,ExplationForAdditionalFabricQty,CheckWith,ProceedForKnitting,ProceedForDyeing,MarkerDia,MarkerLength ,AmendmentNo, AmendmentDetails,AmendmentDate,Discontinue,CauseofDiscontinue,WashReference,SampleReference,IsPrint,PrintDetails,IsAOP,AOPDetails,WashDetails,SampleDetails,UserId,ModifiedOn,ProgramComments,DyeingComments,CuttingWP,Signature1,Signature2,Signature3,Signature4,Signature1Date,Signature2Date,Signature3Date,Signature4Date,Signature1UserId,Signature2UserId,Signature3UserId,Signature4UserId,IsPeachFinish,IsBrush,IsYDS,WashTypeId,IsWash,OrderQuantity,ProccedDate,IsEmbroidery,EmbroideryDetails,IsFabricBOMComplete,PO,YarnDyeingTypeId From FabricBOM Where FabricBOMId=" & row.FabricBOMId, cnn)

                ExecuteQuery("Insert Into FabricBOMDetails_History(FabricBOMDetailsId,FabricBOMId,AmndNo,FabricColorId,ELDNo,OrderQuantity,FabricId,Consumption,WastagePercentage,AdditionalQuantity,FinishFabricQuantity,GreyPercentage,GreyFabricQuantity,Remarks,UserId,ModifiedOn,GarmentsPartId,ColorCode,Discontinue,CCSize,GarmentsColorId,DyeingPricePerUnit,KnittingPricePerUnit,ForSize,CuttingPercentage,ColorSL,IsStripe,IsAOP,IsWash,YarnDyeingTypeId)" &
                             " Select FabricBOMDetailsId,FabricBOMId," & row.AmendmentNo & " As AmndNo,FabricColorId,ELDNo,OrderQuantity,FabricId,Consumption,WastagePercentage,AdditionalQuantity,FinishFabricQuantity,GreyPercentage,GreyFabricQuantity,Remarks,UserId,ModifiedOn,GarmentsPartId,ColorCode,Discontinue,CCSize,GarmentsColorId,DyeingPricePerUnit,KnittingPricePerUnit,ForSize,CuttingPercentage,ColorSL,IsStripe,IsAOP,IsWash,YarnDyeingTypeId From FabricBOMDetails Where FabricBOMId=" & row.FabricBOMId, cnn)

                ExecuteQuery("Insert Into Fabric_History(FabricId,OrderId,KnittingTypeId,CompositionId,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsAllOverPrint,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo,FabricBOMId,KgPerUnit,ForSize,KnittingPercentage,DyeingPercentage,CuttingPercentage,CCSize,Length,MCDia,MCGauge)" &
                                  " Select FabricId,OrderId,KnittingTypeId,CompositionId,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsAllOverPrint,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit," & row.AmendmentNo & " As AmndNo,FabricBOMId,KgPerUnit,ForSize,KnittingPercentage,DyeingPercentage,CuttingPercentage,CCSize,Length,MCDia,MCGauge From Fabric Where FabricBOMId=" & row.FabricBOMId, cnn)

                ExecuteQuery("Insert Into FabricBOMInstruction_History(ID,FabricBOMId,AmndNo,SLNo,Remarks)Select ID,FabricBOMId," & row.AmendmentNo & "As AmndNo,SLNo,Remarks From FabricBOMInstruction Where FabricBOMId=" & row.FabricBOMId, cnn)

                ExecuteQuery("Insert Into YarnAllocationGMT_History(YarnAllocationGMTId,ItemId,Remarks,YarnPercentage,WastagePercentage,Quantity,BrandId,SupplierId,YarnColor,IsYds,FabricBOMDetailsId,LotNo,FeederSize,FeederQty,PIId,AmndNo,StripeGroup,StripeSL,GroupSL)Select YarnAllocationGMTId,ItemId,Remarks,YarnPercentage,WastagePercentage,Quantity,BrandId,SupplierId,YarnColor,IsYds,FabricBOMDetailsId,LotNo,FeederSize,FeederQty,PIId," & row.AmendmentNo & ",StripeGroup,StripeSL,GroupSL From YarnAllocationGMT Where FabricBOMDetailsId in ( Select FabricBOMDetailsId From FabricBOMDetails Where FabricBOMId=" & row.FabricBOMId & ")", cnn)

                OrderQuantityTextEdit.Text = ReadIntegerData("Select OrderQuantity From OrderQuantitySummery Where OrderId = " & OrderIdGridLookUpEdit.EditValue, cnn)

                AmendmentNoSpinEdit.EditValue = AmendmentNoSpinEdit.EditValue + 1


                IsFabricBOMCompleteCheckEdit.Checked = False
                IsFabricBOMCompleteCheckEdit.ReadOnly = False

                FDCheckEdit.Checked = False

                Signature1CheckEdit.Checked = False
                    Signature2CheckEdit.Checked = False
                    Signature3CheckEdit.Checked = False
                    Signature4CheckEdit.Checked = False


                    AmendmentDateDateEdit.EditValue = ReadDateData("Select GETDATE()", cnn)


                'Saving

                Me.Validate()
                Me.FabricBOMBindingSource.EndEdit()
                Me.FabricBOMDetailsBindingSource.EndEdit()
                Me.YarnAllocationGMTBindingSource.EndEdit()
                Me.FabricBindingSource.EndEdit()
                Me.FabricForSizeBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)




            Else

                    Exit Sub

            End If

        End If
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
            Me.FabricBOMDataSet.Fabric.GreyWastagePercentageColumn.DefaultValue = 0



        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        OrderIdGridLookUpEdit.Enabled = True
        OrderIdGridLookUpEdit.Focus()


    End Sub

    Private Sub FabricDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)




        If e.KeyData = Keys.F3 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)

            Dim row1 As FabricBOMDataSet.FabricRow
            row1 = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)


            ExecuteQuery("Insert Into Fabric(OrderId,FabricColorId,KnittingTypeId,SPNote,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo)" & _
                             "Select OrderId,FabricColorId,KnittingTypeId,SPNote,Yarn1,Yarn2,Yarn3,Yarn4,Yarn1Count,Yarn2Count,Yarn3Count,Yarn4Count,GSMId,GreyFabricDia,FinishFabricDia,DiaType,DyeingTypeId,IsPrint,IsAllOverPrint,PrintDetails,WashReference,WashDetails,SampleDetails,SampleReference,MCDia_MCGauge,Remarks,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo From Fabric Where FabricId=" & row1.FabricId, cnn)

            Me.FabricTableAdapter.FillOrderId(Me.FabricBOMDataSet.Fabric, row1.OrderId)
            Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


        End If

    End Sub

    Private Sub FabricDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        ' FabricDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If UserLevel = 1 Then

            Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)

        Else

            Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)

        End If

        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)


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
            Dim SToday As Date = ReadDateData("Select GetDate()", cnn)
            BookingStartDateEdit.EditValue = SToday
            AddFlag = True
            NewButton.Text = "&Save"
            'NewButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            SaveButton.Enabled = False
            Me.OrderLookupTableAdapter.FillByUserId(Me.OrderLookupDataSet.OrderLookup, UserId)
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
                    'SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
                    SaveButton.Enabled = True
                    DisableControl(Me.SplitContainer1)
                    OrderIdGridLookUpEdit.Enabled = False
                    MessageBox.Show("The mentioned Booking is already exists", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, Val(FabricBOMIdLabel1.Text))
                    Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OrderIdGridLookUpEdit.EditValue)

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

                Save()
                GetFabric()
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
            'SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
            SaveButton.Enabled = True
            DisableControl(Me.SplitContainer1)
            OrderIdGridLookUpEdit.Enabled = False
            GridLookUpEdit1.Enabled = True
        End If


    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        'Condition Apply: If Production Start then not allow amendment======================================"

        'If FDStatus() = True Then
        '    MessageBox.Show("Sorry,Not Allowed to Edit, Already Received by Fabric Department." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.AmendmentSimpleButton.Enabled = False
        '    Exit Sub
        'ElseIf YRStatus() = True Then
        '    MessageBox.Show("Sorry,Not Allowed to Edit, Already Yarn Received by Knitting Department." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.AmendmentSimpleButton.Enabled = False
        '    Exit Sub
        'ElseIf KSStatus() = True Then
        '    MessageBox.Show("Sorry,Not Allowed to Edit, Already Knitting Start by Knitting Department." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.AmendmentSimpleButton.Enabled = False
        '    Exit Sub
        'ElseIf DSStatus() = True Then
        '    MessageBox.Show("Sorry,Not Allowed to Edit, Already Dyeing Start by Dyeing Department." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.AmendmentSimpleButton.Enabled = False
        '    Exit Sub
        'ElseIf CSStatus() = True Then
        '    MessageBox.Show("Sorry,Not Allowed to Edit, Already Cutting Start by Cutting Department." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.AmendmentSimpleButton.Enabled = False
        '    Exit Sub
        'Else
        '    Me.AmendmentSimpleButton.Enabled = True
        'End If
        '==============================================================================================================='


        'If Me.FabricBOMDetailsBindingSource.Position > -1 Then

        '    For Each drv As DataRowView In FabricBOMDetailsBindingSource.List

        '        If drv!DyeingPricePerUnit < 0.001 Then
        '            MessageBox.Show("Dyeing Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '        End If

        '        If drv!KnittingPricePerUnit < 0.001 Then
        '            MessageBox.Show("Knitting Price must be greater than 0", "Price Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '        End If

        '    Next
        'End If


        Dim pt As Integer = Me.FabricBindingSource.Position()

        If SaveButton.Text = "&Edit" Then

            If IsFabricBOMCompleteCheckEdit.Checked Then
                ProFlag = True
            Else
                ProFlag = False
            End If

            If Me.FabricBOMBindingSource.Position = -1 Then
                Exit Sub
            End If

            SaveButton.Text = "&Save"
            AmendmentSimpleButton.Enabled = True
            ' SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            NewButton.Enabled = False
            EnableControl(Me.SplitContainer1)
            GridLookUpEdit1.Enabled = False

            If IsFabricBOMCompleteCheckEdit.Checked = False Then
                IsFabricBOMCompleteCheckEdit.Properties.ReadOnly = False

            End If


        Else

            If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = True Then

                ErrorProvider1.SetError(OrderIdGridLookUpEdit, "Program No is Require")
                OrderIdGridLookUpEdit.Focus()
                Exit Sub

            Else

                ErrorProvider1.Clear()

            End If


            If AmendmentNoSpinEdit.Value > 0 And Me.AmendmentDetailsTextEdit.Text = String.Empty Then
                ErrorProvider1.SetError(AmendmentDetailsTextEdit, "Amendment Details is Require.")
                AmendmentDetailsTextEdit.Focus()
                Exit Sub
            End If

            If ProceedForDyeingCheckEdit.Checked = False And ProceedForKnittingCheckEdit.Checked = False Then
                MessageBox.Show("Please mention Proceed For Dyeing or Preceed For Knitting. ")
                Exit Sub
            End If

            If CDate(FabricReqDateDateEdit.Text) < CDate(FabricBookingDateDateEdit.Text) Then
                MessageBox.Show("Fabric Require Date should not less than Fabric Booking Date")

                Exit Sub

            End If

            'If IsFabricBOMCompleteCheckEdit.Checked = True Then
            '    ExecuteQuery("Update [Order] Set IsInputComplete=1 Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            'End If

            Try


                    Dim row As FabricBOMDataSet.FabricBOMRow
                    row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)


                    row.Signature1UserId = ReadIntegerData("Select UserId From Signature Where Interface='FabricBOM' And SignatureSL=1", cnn)
                    row.Signature2UserId = UserId
                    row.Signature3UserId = ReadIntegerData("Select ReportTo From [User] Where User_Id=" & UserId, cnn)
                    row.Signature4UserId = ReadIntegerData("Select UserId From Signature Where Interface='FabricBOM' And SignatureSL=4", cnn)


                    Save()

                    OrderIdGridLookUpEdit.Enabled = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


                'If UserLevel = 1 Then
                '    Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
                'Else
                Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
                'End If

                Me.FabricViewTableAdapter.Fill(Me.FabricBOMDataSet.FabricView)


                SaveButton.Text = "&Edit"
                AmendmentSimpleButton.Enabled = False
                ' SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Edit
                NewButton.Enabled = True
                DisableControl(Me.SplitContainer1)
                GridLookUpEdit1.Enabled = True
                IsFabricBOMCompleteCheckEdit.Properties.ReadOnly = True

                SetYarnAllocation()
            Me.FabricBindingSource.Position = pt
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
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)


            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Exit Sub

        End If

    End Sub

    Private Sub FabricBOMDetailsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next

    End Sub


    Private Sub FabricDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.FabricBOMBindingSource.EndEdit()
        Me.FabricBOMDataSet.Fabric.AmndNoColumn.DefaultValue = AmendmentNoSpinEdit.Value

    End Sub


   


    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CnclButton.Click
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
            Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails, 0)
            Me.FabricTableAdapter.FillOrderId(Me.FabricBOMDataSet.Fabric, OrderIdGridLookUpEdit.EditValue)
            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & 0, cnn)

            Me.IsPrintCheckEdit.Checked = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            Me.IsAOPCheckEdit.Checked = ReadBooleanData("Select IsAOP From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)

            Me.WashDetailsTextEdit.Text = ReadStringData("Select CASE WHEN IsWash=1 THEN 'Yes' ELSE '' END AS IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            Me.WashDetailsTextEdit.Text = ReadStringData("Select WashType From WashTypeMst Where WashTypeId=(Select WashTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)

            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & 0 & " Group By POGroup", cnn)
            Me.YarnDyeingTypeGridLookUpEdit.EditValue = ReadIntData("Select YarnDyeingTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)

            OrderIdGridLookUpEdit.Enabled = False



        End If


    End Sub

    Private Sub FabricBOMDetailsDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMDetailsDataGridView.Enter
        'Me.FabricBOMBindingSource.EndEdit()
    End Sub

    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '===============
        'Copying...
        '================

        If Me.FabricBindingSource.Position = -1 Then

            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim OrId As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim AmndNo As Integer = ReadIntData("Select AmendmentNo From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim sqlstring As String = "Select GarmentsPartId,FabricId,OrderId,KnittingTypeId,GSMId,FinishFabricDia,DiaType,Con,MarkerLengthYrds,MarkerLengthInch,MarkerWidth,LengthAllowance,WidthAllowance,WastagePercentage,GMQuantity,DiaUnit,FinishUnit,AmndNo,CompositionId,SPNote From Fabric Where OrderId=" & OrId & "And AmndNo=" & AmndNo
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
                    newRow.Con = Val(reader("Con").ToString)
                    newRow.GarmentsPartId = reader("GarmentsPartId")

                    Me.FabricBOMDataSet.Fabric.Rows.Add(newRow)

                End If

            End While

            reader.Close()
            connection.Close()

        End If

        '===========================
        'Saving to get Fabric Id ...
        '===========================

        Save()

        '===================
        'Getting Details ...
        '===================

        'If FabricBOMDetailsBindingSource.Position = -1 Then


        '    Dim connection2 As New SqlConnection(cnn)
        '    connection2.Open()

        '    'Dim OrId As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
        '    'Dim AmndNo As Integer = ReadIntData("Select AmendmentNo From FabricBOM Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue, cnn)

        '    Dim sqlstring As String = "Select FabricBOMId,GarmentsPartId,FabricColorId,ELDNo,FabricId,Consumption,WastagePercentage,GreyPercentage,Remarks,CCSize,KgPerUnit,ColorCode,DyeingPricePerUnit,KnittingPricePerUnit From FabricBOMDetails Where FabricBOMId=" & ProgramNoGridLookUpEdit.EditValue
        '    Dim cmd2 As SqlCommand = New SqlCommand(sqlstring, connection2)
        '    Dim reader2 As SqlDataReader = cmd2.ExecuteReader()


        '    While reader2.Read

        '        If reader2.IsDBNull(0) = False Then

        '            'list.Add(reader.GetString(0))

        '            Dim newRow As FabricBOMDataSet.FabricBOMDetailsRow = Me.FabricBOMDataSet.FabricBOMDetails.NewRow()

        '            On Error Resume Next

        '            newRow.FabricBOMId = Me.FabricBOMIdLabel1.Text
        '            newRow.GarmentsPartId = reader2("GarmentsPartId").ToString
        '            newRow.FabricColorId = reader2("FabricColorId").ToString
        '            newRow.ELDNo = reader2("ELDNo").ToString

        '            Dim FId As Integer = ReadIntegerData("Select FabricId From Fabric Where CopyFrom=" & reader2("FabricId").ToString, cnn)
        '            newRow.FabricId = FId
        '            newRow.Consumption = reader2("consumption").ToString
        '            newRow.WastagePercentage = reader2("WastagePercentage").ToString
        '            newRow.GreyPercentage = reader2("GreyPercentage").ToString
        '            newRow.Remarks = reader2("Remarks").ToString
        '            newRow.CCSize = reader2("CCSize").ToString
        '            newRow.ColorCode = reader2("ColorCode").ToString
        '            newRow.DyeingPricePerUnit = Val(reader2("DyeingPricePerUnit").ToString())
        '            newRow.KnittingPricePerUnit = Val(reader2("KnittingPricePerUnit").ToString())

        '            Me.FabricBOMDataSet.FabricBOMDetails.Rows.Add(newRow)

        '        End If

        '    End While

        '    reader2.Close()
        '    connection2.Close()


        'End If

    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If FabricBOMIdSearchBindingSource.Position > -1 Then
            'On Error Resume Next
            'Dim row As FabricBOMIdSearchDataSet.FabricBOMIdSearchRow
            'row = CType(CType(Me.FabricBOMIdSearchBindingSource.Current, DataRowView).Row, FabricBOMIdSearchDataSet.FabricBOMIdSearchRow)

            Dim OID As Integer = ReadIntegerData("Select OrderId From FabricBOM Where FabricBOMId=" & GridLookUpEdit1.EditValue, cnn)

            Me.OrderLookupTableAdapter.FillByFabricBOMId(Me.OrderLookupDataSet.OrderLookup, GridLookUpEdit1.EditValue)
            Me.YarnAllocationGMTTableAdapter.Fill(Me.FabricBOMDataSet.YarnAllocationGMT, GridLookUpEdit1.EditValue)
            Me.FabricBOMDetailsTableAdapter.Fill(Me.FabricBOMDataSet.FabricBOMDetails, GridLookUpEdit1.EditValue)
            Me.FabricBOMTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricBOM, GridLookUpEdit1.EditValue)
            Me.FabricBOMDataSet.Fabric.OrderIdColumn.DefaultValue = OID
            Me.FabricTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.Fabric, Val(FabricBOMIdLabel1.Text))
            Me.FabricViewTableAdapter.FillByOrderAndAmnd(Me.FabricBOMDataSet.FabricView, OID)
            Me.FabricForSizeTableAdapter.Fill(Me.FabricBOMDataSet.FabricForSize, GridLookUpEdit1.EditValue)

            Me.BuyerLabel.Text = ReadStringData("Select BuyerCode From vOrder Where OrderId=" & OID, cnn)
            Me.POGroupLabel.Text = ReadStringData("Select POGroup From vOrder  Where OrderId=" & OID & " Group By POGroup", cnn)

            OrderIdGridLookUpEdit.Enabled = False
            FDCheckEdit.Checked = FDStatus()

            YarnReceivedCheckEdit.Checked = YRStatus()
            KnittingStartCheckEdit.Checked = KSStatus()
            DyeingStartCheckEdit.Checked = DSStatus()
            CuttingStartCheckEdit.Checked = CSStatus()

            SplitContainer6.Panel1Collapsed = False
            SplitContainer6.Panel2Collapsed = True


            End If

    End Sub

    

   
    Private Sub Save()
        Try
            If IsFabricBOMCompleteCheckEdit.Checked = True AndAlso ProFlag = True Then
                MessageBox.Show("Sorry,Not Allowed to Edit, Already Proceeed." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AmendmentSimpleButton.Enabled = True
                Exit Sub
            End If

            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.YarnAllocationGMTBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)


            CalcCon()
            UpdateMore()

            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.YarnAllocationGMTBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

            GetFabric()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub GetFabric()

        ExecuteQuery("Update Fabric Set FabricBOMId=" & Val(FabricBOMIdLabel1.Text) & "Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        Me.FabricTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.Fabric, Val(FabricBOMIdLabel1.Text))

    End Sub

    Private Sub FabricBOMDetailsDataGridView_DataError_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles FabricBOMDetailsDataGridView.DataError
        On Error Resume Next
    End Sub


    Private Sub UpdateColorAndSize()

        If Me.FabricBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)


            For Each drv As DataRowView In Me.FabricForSizeBindingSource.List
                drv!CuttingPercentage = ReadData("Select Top 1 AvgCuttingPercentage From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderIdGridLookUpEdit.EditValue & "And FabricColorId=" & drv!FabricColorId, cnn)
                Dim OrQty As Integer = 0
                OrQty = ReadData("Select TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderIdGridLookUpEdit.EditValue & "And FabricColorId=" & drv!FabricColorId & "And SizeId=" & drv!SizeId, cnn)
                drv!FabricQuantity = Val(OrQty) * (row.Con / 12)
                drv!OrderQuantity = OrQty
            Next
        End If


    End Sub

    Private Sub SetColorAndSize()


        If FabricForSizeBindingSource.Position > -1 Then
            Exit Sub
        End If

        Dim Color As String = ""
        Dim Color1 As String = ""

        Color = ColorCheckedComboBoxEdit.Text

        Color1 = Color.Replace(", ", "','") 'You should use one space after first comma
        Color1 = Trim(Color1)


        Dim Size As String = ""
        Dim Size1 As String = ""

        Size = SizeCheckedComboBoxEdit.Text

        Size1 = Size.Replace(", ", "','") 'You should use one space after first comma
        Size1 = Trim(Size1)
        If Me.FabricBindingSource.Position = -1 Then
            Exit Sub
            MessageBox.Show("Fabric is not available")
        End If

        Dim row As FabricBOMDataSet.FabricRow
        row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)

        Dim CPFlag As Boolean = False

        Using connection1 As New SqlConnection(cnn)

            Dim command1 As New SqlCommand("Select ISNULL(CuttingPercentage,0) As CP From OrderCuttingPercentage Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " And FabricColorId in (Select FabricColorId From FabricColor Where FabricColorName in ('" & Color1 & "'))", connection1)
            command1.Connection.Open()
            command1.ExecuteNonQuery()

            Dim reader1 As SqlDataReader = command1.ExecuteReader()


            While reader1.Read()
                If reader1("CP") = 0 Then
                    MessageBox.Show("Not Done, Cutting Percentage Missing")
                    Exit Sub
                End If
            End While



        End Using




        Using connection As New SqlConnection(cnn)

            'Dim command As New SqlCommand("Select FabricColorId, Code, Reference, SizeId, TTLOrderQuantity From OrderQuantitySummery_ColorAndSize Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " And FabricColorId in(Select FabricColorId From FabricColor Where FabricColorName in ('" & Color1 & "'))And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", connection)
            Dim command As New SqlCommand("Select FabricColorId, Code, Reference, SizeId, TTLOrderQuantity,AvgCuttingPercentage From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " And ColorDetails in ('" & Color1 & "') And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()


            While reader.Read()

                Dim CP As Integer = ReadData("Select Sum(isnull(CuttingPercentage,0)) From OrderCuttingPercentage Where OrderId=" & OrderIdGridLookUpEdit.EditValue & " And FabricColorId=" & Val(reader("FabricColorId").ToString()), cnn)

                Dim newRow As FabricBOMDataSet.FabricForSizeRow = Me.FabricBOMDataSet.FabricForSize.NewRow()

                newRow.FabricId = row.FabricId
                newRow.FabricColorId = Val(reader("FabricColorId").ToString())
                newRow.SizeId = Val(reader("SizeId").ToString())
                newRow.OrderQuantity = Val(reader("TTLOrderQuantity").ToString()) '* (1 + Val(reader("AvgCuttingPercentage")) / 100)
                newRow.FabricQuantity = Val(reader("TTLOrderQuantity").ToString()) * (row.Con / 12) '* (1 + Val(reader("AvgCuttingPercentage")) / 100)
                newRow.Code = reader("Code").ToString()
                newRow.ContrastColorId = Val(reader("FabricColorId").ToString())
                newRow.CuttingPercentage = Val(reader("AvgCuttingPercentage").ToString())

                If row.IsLengthNull Then
                    row.Length = 0
                End If

                If row.Length > 0 Then
                    newRow.CCSize = row.Length & "X" & row.FinishFabricDia
                End If

                newRow.Reference = reader("Reference").ToString()

                Me.FabricBOMDataSet.FabricForSize.Rows.Add(newRow)

            End While

            reader.Close()

            row.ForColor = ColorCheckedComboBoxEdit.Text
            row.ForSize = SizeCheckedComboBoxEdit.Text

        End Using

Line1:
        Try

            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
       

    End Sub

    
    Private Sub CalcCon()

        On Error Resume Next


        For Each drv As DataRowView In Me.FabricBindingSource.List

            Dim Consumption As Decimal

            If drv!DiaType = "Open" Then
                '    drv!MarkerWidth = drv!FinishFabricDia - drv!WidthAllowance
                drv!FinishFabricDia = drv!MarkerWidth + drv!WidthAllowance
            Else
                '    drv!MarkerWidth = drv!FinishFabricDia * 2 - drv!WidthAllowance
                drv!FinishFabricDia = (drv!MarkerWidth + drv!WidthAllowance) / 2
            End If


            Dim Length As Decimal = CDec(drv!MarkerLengthYrds) * 36 + CDec(drv!MarkerLengthInch) + drv!LengthAllowance
            Dim Width As Decimal = CDec(drv!MarkerWidth) + CDec(drv!WidthAllowance)
            Dim GSM As Decimal = ReadData("Select GSM From GSM Where GSMId=" & drv!GSMId, cnn)
            Dim MarkerQuantity As Decimal = drv!GMQuantity
            Dim WP As Decimal = (1 + drv!WastagePercentage / 100)




            Consumption = Length * Width * GSM / MarkerQuantity * 12 / 1550 / 1000 * WP

            If Consumption > 0 Then
                drv!Con = Consumption
            End If

        Next


    End Sub

    
    
    Private Sub IsFabricBOMCompleteCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsFabricBOMCompleteCheckEdit.CheckedChanged

        'FabricBookingDateDateEdit.EditValue = Today()
        If DBNull.Value.Equals(OrderIdGridLookUpEdit.EditValue) = False Then
            Dim OrderInputFlag As Boolean = ReadBooleanData("Select IsInputComplete From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)

            If OrderInputFlag = False Then
                MessageBox.Show("Not Allowed for incomplete Buyer Order.")
                IsFabricBOMCompleteCheckEdit.Checked = False
                Exit Sub
            End If
        End If



        If SaveButton.Text = "&Save" Then

            If AmendmentNoSpinEdit.Value = 0 Then

                'Dim SToday As Date =
                FabricBookingDateDateEdit.EditValue = ReadDateData("Select GetDate()", cnn)

            Else

                'Dim SToday As Date = ReadDateData("Select GetDate()", cnn)
                AmendmentDateDateEdit.EditValue = ReadDateData("Select GetDate()", cnn)

            End If

            Signature2CheckEdit.Checked = True

        End If

        On Error Resume Next
        If IsFabricBOMCompleteCheckEdit.Checked = False Then
            ''ExecuteQuery("Update [Order] Set IsFabricBOMComplete=0 Where OrderId = " & OrderIdGridLookUpEdit.EditValue, cnn)
            Exit Sub
        Else
            ExecuteQuery("Update [Order] Set IsFabricBOMComplete=1 Where OrderId = " & OrderIdGridLookUpEdit.EditValue, cnn)
        End If

    End Sub
    'Fabric Department Status (Receive Pending or Amendment Pending)

    Function FDStatus() As Boolean 'Fabric Department Status

        Dim FD As Boolean = False

        Dim FFBCount As Integer = ReadIntData("Select Count(*) From FinishFabricBooking Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ") And AmendmentNo=" & Me.AmendmentNoSpinEdit.EditValue, cnn)

        If FFBCount = 1 Then
            FD = True
            FDCheckEdit.BackColor = Color.Red
        Else
            FD = False
            FDCheckEdit.BackColor = Color.Green
        End If

        Return FD

    End Function

    Function YRStatus() As Boolean 'Yarn Received Status

        Dim FD As Boolean = False

        Dim FFBCount As Decimal = ReadData("Select Sum(IssueQuantity) From Issue Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ") And DepartmentId=" & YarnStoreId, cnn)

        If FFBCount > 0 Then
            FD = True
            YarnReceivedCheckEdit.BackColor = Color.Red
        Else
            FD = False
            YarnReceivedCheckEdit.BackColor = Color.Green
        End If

        Return FD

    End Function

    Function KSStatus() As Boolean 'Knitting Start Status

        Dim FD As Boolean = False

        Dim FFBCount As Decimal = ReadData("Select KnittingProduction From KnittingProduction_FFId_kg Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)

        If FFBCount > 0 Then
            FD = True
            KnittingStartCheckEdit.BackColor = Color.Red
        Else
            FD = False
            KnittingStartCheckEdit.BackColor = Color.Green
        End If

        Return FD

    End Function

    Function DSStatus() As Boolean 'Dyeing Start Status

        Dim FD As Boolean = False

        Dim FFBCount As Decimal = ReadData("Select BatchQuantityKg From DyeingQuantity_FFID Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)

        If FFBCount > 0 Then
            FD = True
            DyeingStartCheckEdit.BackColor = Color.Red
        Else
            FD = False
            DyeingStartCheckEdit.BackColor = Color.Green
        End If

        Return FD

    End Function
    Function CSStatus() As Boolean 'Dyeing Start Status

        Dim FD As Boolean = False

        Dim FFBCount As Decimal = ReadData("Select CuttingQuantity From CuttingSummeryByOrder Where ProgramNo=(Select ProgramNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)

        If FFBCount > 0 Then
            FD = True
            CuttingStartCheckEdit.BackColor = Color.Red
        Else
            FD = False
            CuttingStartCheckEdit.BackColor = Color.Green
        End If

        Return FD

    End Function


    Private Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        If FabricForSizeBindingSource.Position > -1 Then
            For Each drv As DataRowView In FabricForSizeBindingSource.List
                If drv!SizeId = SizeLookupGridLookUpEdit.EditValue Then
                    drv!CCSize = CCSizeTextEdit.Text
                End If
            Next
        End If
    End Sub

    Private Sub YarnAllocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnAllocationButton.Click
        SplitContainer6.Panel1Collapsed = True
        SplitContainer6.Panel2Collapsed = False

    End Sub

    Private Sub YarnAllocationGMTBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnAllocationGMTBindingSource.PositionChanged
        'On Error Resume Next
        'Dim row As FabricBOMDataSet.YarnAllocationGMTRow
        'row = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

        'Me.LotAndItemwiseBalanceTableAdapter.Fill(Me.LotAndItemBalanceDataSet.LotAndItemwiseBalance, row.ItemId)


    End Sub

    Private Sub YarnLotNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnLotNoGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Dim row As FabricBOMDataSet.YarnAllocationGMTRow
        row = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

        Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, row.ItemId, YarnLotNoGridLookUpEdit.EditValue, 8)
    End Sub


    Private Sub SetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetButton.Click

        Try

            Dim FBDId As String = ""

            If Me.FabricBOMDetailsBindingSource.Position > -1 Then

                Dim row As FabricBOMDataSet.FabricBOMDetailsRow
                row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)


                For Each drv As DataRowView In FabricBOMDetailsBindingSource.List

                    If drv!SelectColumn = True Then

                        If FBDId = "" Then
                            FBDId = drv!FabricBOMDetailsId
                        Else
                            FBDId = FBDId & "," & drv!FabricBOMDetailsId
                        End If


                    End If

                Next

            End If


            Dim row1 As FabricBOMDataSet.YarnAllocationGMTRow
            row1 = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

            Dim SupplierId As Integer = ReadIntegerData("Select SupplierId From LCList Where LCId=" & LCGridLookUpEdit.EditValue, cnn)

            row1.SupplierId = SupplierId
            row1.LotNo = YarnLotNoGridLookUpEdit.EditValue

            'ExecuteQuery("Update YarnAllocationGMT Set SupplierId = " & SupplierId & ",LotNo=" & YarnLotNoGridLookUpEdit.EditValue & " Where ItemId=" & row1.ItemId & " And FabricBOMDetailsId in (" & FBDId & ")", cnn)
            'Me.YarnAllocationGMTTableAdapter.Fill(Me.FabricBOMDataSet.YarnAllocationGMT)


        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub SetYarnAllocation()

        Try
            Dim FBDId As String = ""

            If Me.FabricBOMDetailsBindingSource.Position > -1 Then


                Dim row As FabricBOMDataSet.FabricBOMDetailsRow
                row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

                For Each drv As DataRowView In FabricBOMDetailsBindingSource.List

                    If drv!SelectColumn = True Then

                        If FBDId = "" Then
                            FBDId = drv!FabricBOMDetailsId
                        Else
                            FBDId = FBDId & "," & drv!FabricBOMDetailsId
                        End If

                        Dim DataCount As Integer = ReadIntData("Select Count(*) From YarnAllocationGMT Where FabricBOMDetailsId=" & drv!FabricBOMDetailsId, cnn)

                        Dim FUnit As String = ReadStringData("Select FinishUnit From Fabric Where FabricId=" & drv!FabricId, cnn)
                        Dim KgPerUnit As Decimal = ReadData("Select KgPerUnit From Fabric Where FabricId=" & drv!FabricId, cnn)
                        Dim GreyQty As Decimal = ReadData("Select GreyFabricQuantity From FabricBOMDetails Where FabricBOMDetailsId=" & drv!FabricBOMDetailsId, cnn)
                        GreyQty = GreyQty * KgPerUnit

                        If DataCount = 0 Then
                            ExecuteQuery("Insert into YarnAllocationGMT(FabricBOMDetailsId,ItemId,YarnPercentage,WastagePercentage,YarnColor,IsYds,Quantity,BrandId,SupplierId,LotNo,FeederNo,StripeGroup,FeederSize,FeederQty,StripeSL)Select " & drv!FabricBOMDetailsId & " As FabricBOMDetailsId,ItemId,YarnPercentage,WastagePercentage,YarnColor,IsYds,(" & GreyQty & " * YarnPercentage/100)* (1+WastagePercentage/100) As Quantity,BrandId,SupplierId,LotNo,FeederNo,StripeGroup,FeederSize,FeederQty,StripeSL   From YarnAllocationGMT Where  FabricBOMDetailsId=" & row.FabricBOMDetailsId, cnn)
                        Else

                            ExecuteQuery("Update YarnAllocationGMT Set Quantity=(" & GreyQty & "* YarnPercentage/100)*(1+WastagePercentage/100) Where FabricBOMDetailsId =" & drv!FabricBOMDetailsId, cnn)
                        End If

                        Me.YarnAllocationGMTTableAdapter.Fill(Me.FabricBOMDataSet.YarnAllocationGMT, GridLookUpEdit1.EditValue)

                    End If

                Next

                If Me.YarnAllocationGMTBindingSource.Position > -1 Then

                    Dim row1 As FabricBOMDataSet.YarnAllocationGMTRow
                    row1 = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

                    If FBDId <> "" Then

                        YarnRequireLabel.Text = ReadData("Select Sum(Quantity) From YarnAllocationGMT Where ItemId=" & row1.ItemId & "And FabricBOMDetailsId in (" & FBDId & ")", cnn)

                    End If

                End If

                
                
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub SetYarnLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles InvertSelectLinkLabel.LinkClicked

        For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List


            If drv!SelectColumn = True Then

                drv!SelectColumn = False

            ElseIf drv!SelectColumn = False Then

                drv!SelectColumn = True
            End If

        Next

        Me.FabricBOMDetailsBindingSource.ResetBindings(True)

    End Sub

    Private Sub Highlight()


        If Me.FabricBOMDetailsBindingSource.Position > -1 Then
            For Each dr As DataGridViewRow In FabricBOMDetailsDataGridView.Rows

                If dr.Cells(0).Value = False Then
                    dr.DefaultCellStyle.BackColor = Color.White
                Else
                    dr.DefaultCellStyle.BackColor = Color.Gold
                End If


            Next
        End If



    End Sub


    Private Sub FabricBOMDetailsDataGridView_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FabricBOMDetailsDataGridView.CellValueChanged

        Highlight()

    End Sub

    Private Sub SetCColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCColorButton.Click

        If Me.FabricBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)


            Dim Color As String = ""
            Dim Color1 As String = ""

            Color = ColorCheckedComboBoxEdit.Text

            Color1 = Color.Replace(", ", "','") 'You should use one space after first comma
            Color1 = Trim(Color1)

            ' ExecuteQuery("Update FabricForSize Set ContrastColorId=" & CColorGridLookUpEdit.EditValue & " , Code='" & CodeTextBox.Text & "', Reference='" & RefTextBox.Text & "' Where FabricId=" & row.FabricId & " And FabricSizeId in (Select FabricSizeId From FabricForSizeView Where ColorDetails in ('" & Color1 & "'))", cnn)
            Dim queryString As String = "Update FabricForSize Set ContrastColorId=@ContrastColorId , Code=@Code, Reference=@Reference Where FabricId=@FabricId And FabricSizeId in (Select FabricSizeId From FabricForSizeView Where ColorDetails in ('" & Color1 & "'))"

            Using connection As New SqlConnection(cnn)
                Dim command As New SqlCommand(queryString, connection)
                command.Connection.Open()
                command.Parameters.Add(New SqlClient.SqlParameter("@ContrastColorId", SqlDbType.BigInt)).Value = CColorGridLookUpEdit.EditValue
                command.Parameters.Add(New SqlClient.SqlParameter("@Code", SqlDbType.VarChar)).Value = CodeTextBox.Text
                command.Parameters.Add(New SqlClient.SqlParameter("@Reference", SqlDbType.VarChar)).Value = RefTextBox.Text
                command.Parameters.Add(New SqlClient.SqlParameter("@FabricId", SqlDbType.BigInt)).Value = row.FabricId
                'command.Parameters.Add(New SqlClient.SqlParameter("@ColorDetails", SqlDbType.VarChar)).Value = Color1
                command.ExecuteNonQuery()
            End Using


            FabricForSizeTableAdapter.Fill(Me.FabricBOMDataSet.FabricForSize, GridLookUpEdit1.EditValue)


        End If

    End Sub

    Private Sub RefreshLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RefreshLinkLabel.LinkClicked

        If Me.YarnAllocationGMTBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.YarnAllocationGMTRow
            row = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

            Me.LotAndItemwiseBalanceTableAdapter.Fill(Me.LotAndItemBalanceDataSet.LotAndItemwiseBalance, row.ItemId)

        End If


        Try
            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.YarnAllocationGMTBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If Me.YarnAllocationGMTBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)


            Dim TTLFeederSize As Decimal = ReadData("Select Sum(FeederSize) From YarnAllocationGMT Where FabricBOMDetailsId=" & row.FabricBOMDetailsId, cnn)

            If TTLFeederSize > 0 Then
                For Each drv As DataRowView In Me.YarnAllocationGMTBindingSource.List
                    drv!YarnPercentage = drv!FeederSize / TTLFeederSize * 100
                Next
            End If


        End If

    End Sub

    Private Sub DeselectAllLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeselectAllLinkLabel.LinkClicked

        For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List

            If drv!SelectColumn = True Then

                drv!SelectColumn = False

            End If

        Next

    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        'Save()

        Try
            'Need to remember Copied FabricBOM Details Id

            If FabricBOMDetailsBindingSource.Position > -1 Then

                Dim row As FabricBOMDataSet.FabricBOMDetailsRow
                row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)


                FBDId = row.FabricBOMDetailsId

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click
        'If there is no data in po grid then the procedure will exit.

        If IsFabricBOMCompleteCheckEdit.Checked = True Then
            MessageBox.Show("Sorry,Not Allowed to Edit, Already Proceeed." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AmendmentSimpleButton.Enabled = True
            Exit Sub
        End If


        If YarnAllocationGMTBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyFBDId
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select ItemId,Remarks,YarnPercentage,WastagePercentage,Quantity,BrandId,SupplierId,YarnColor,IsYds,FabricBOMDetailsId,LotNo,FeederSize,FeederQty,PIId,FeederNo,StripeGroup,StripeSL,GroupSL,ISNULL(YarnPrice,0) AS YarnPrice From YarnAllocationGMT Where FabricBOMDetailsId =" & FBDId, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()
                'Insert Reading data From OrderSizeDetails  by CopyODI
                On Error Resume Next
                Dim newRow As FabricBOMDataSet.YarnAllocationGMTRow = Me.FabricBOMDataSet.YarnAllocationGMT.NewRow()

                'Start Reading Selected OrderDetailsId
                Dim PasteFBDI As Integer

                Dim row As FabricBOMDataSet.FabricBOMDetailsRow
                row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

                PasteFBDI = row.FabricBOMDetailsId

                'End Reading Selected OrderDetailsId

                newRow.FabricBOMDetailsId = PasteFBDI
                newRow.Remarks = reader("Remarks").ToString
                newRow.YarnPercentage = reader("YarnPercentage").ToString
                newRow.WastagePercentage = reader("WastagePercentage").ToString
                newRow.Quantity = reader("Quantity").ToString
                newRow.ItemId = reader("ItemId").ToString
                newRow.StripeSL = reader("StripeSL").ToString
                'newRow.BrandId = reader("BrandId").ToString
                newRow.SupplierId = reader("SupplierId").ToString
                newRow.YarnColor = reader("YarnColor").ToString
                newRow.IsYds = reader("IsYds").ToString
                newRow.LotNo = reader("LotNo").ToString
                newRow.FeederNo = reader("FeederNo").ToString
                newRow.FeederSize = reader("FeederSize").ToString
                newRow.FeederQty = reader("FeederQty").ToString
                newRow.StripeGroup = reader("StripeGroup").ToString
                newRow.GroupSL = reader("GroupSL").ToString
                newRow.YarnPrice = reader("YarnPrice").ToString



                Me.FabricBOMDataSet.YarnAllocationGMT.Rows.Add(newRow)


            End While

            reader.Close()
            connection.Close()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim i As Integer = 0


        If FabricBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As FabricBOMDataSet.FabricRow
        row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)


        Do Until i = Val(CopyTextBox.Value)

            Dim newRow As FabricBOMDataSet.FabricRow = Me.FabricBOMDataSet.Fabric.NewRow()

            With newRow

                On Error Resume Next

                .OrderId = row.OrderId
                .KnittingTypeId = row.KnittingTypeId
                .CompositionId = row.CompositionId
                .GSMId = row.GSMId
                .FinishFabricDia = row.FinishFabricDia
                .DiaType = row.DiaType
                .MarkerWidth = row.MarkerWidth
                .Remarks = row.Remarks
                .GMQuantity = row.GMQuantity
                .DiaUnit = row.DiaUnit
                .FinishUnit = row.FinishUnit
                .SPNote = row.SPNote
                .GarmentsPartId = row.GarmentsPartId
                .FabricBOMId = row.FabricBOMId
                .Con = row.Con
                .Length = 0
                .GreyWastagePercentage = row.GreyWastagePercentage

            End With

            Me.FabricBOMDataSet.Fabric.Rows.Add(newRow)
            i = i + 1
        Loop

    End Sub

    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click

        If Val(FabricBOMIdLabel1.Text) < 1 Then
            Exit Sub
            MessageBox.Show("Please,save first to work in details", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        SetColorAndSize()
        'AddToBOMLinkLabel.Enabled = False

        If FabricBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)




            'Dim rowGSM As GSMDataSet.GSMRow
            'rowGSM = CType(CType(Me.GSMBindingSource.Current, DataRowView).Row, GSMDataSet.GSMRow)

            ''Dim consumption As Decimal = 0

            'If row.GMQuantity = 0 Then

            '    MessageBox.Show("Require Garments Quantity", "Missing Data!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Else

            '    'On Error Resume Next
            '    Dim Length As Decimal = CDec(row.MarkerLengthYrds) * 36 + CDec(row.MarkerLengthInch) + row.LengthAllowance
            '    Dim Width As Decimal = CDec(row.MarkerWidth) + CDec(row.WidthAllowance)
            '    Dim GSM As Decimal = ReadData("Select GSM From GSM Where GSMId=" & row.GSMId, cnn)
            '    Dim MarkerQuantity As Decimal = row.GMQuantity
            '    Dim WP As Decimal = (1 + row.WastagePercentage / 100)

            '    consumption = Length * Width * GSM / MarkerQuantity * 12 / 1550 / 1000 * WP

            'End If

            'With Me.FabricBOMDataSet.FabricBOMDetails
            '    .GarmentsPartIdColumn.DefaultValue = row.GarmentsPartId
            '    .FabricIdColumn.DefaultValue = row.FabricId
            '    .UserIdColumn.DefaultValue = UserId
            '    .ConsumptionColumn.DefaultValue = row.Con
            '    .WastagePercentageColumn.DefaultValue = row.WastagePercentage
            '    .ModifiedOnColumn.DefaultValue = Today()
            '    .DyeingPricePerUnitColumn.DefaultValue = 0
            '    .KnittingPricePerUnitColumn.DefaultValue = 0
            'End With



            'Looping through all color form OrderDetails
            Using connection As New SqlConnection(cnn)

                'Dim sqlstring As String = "SELECT B.FabricId,B.FabricColorId,B.Code,B.Reference,B.ContrastColorId,B.CCSize,Sum(B.OrderQuantity)As OrderQuantity," & _
                '                            "STUFF((Select ',' , (Select C.SizeCode From Size C Where C.SizeId=A.SizeId ) As [text()] From FabricForSize A" & _
                '                            "Where A.FabricId=B.FabricId And ISNULL(A.CCSize,'-')=ISNULL(B.CCSize,'-') And A.FabricColorId=B.FabricColorId  And A.ContrastColorId=B.ContrastColorId And A.Code=B.Code And A.Reference=B.Reference" & _
                '                            "For XML Path('')),1,1,'') AS ForSize" & _
                '                            "From FabricForSize B" & _
                '                            "Where B.FabricId=" & row.FabricId & _
                '                            "Group By B.FabricId,B.FabricColorId,B.Code,B.Reference,B.ContrastColorId,B.CCSize"



                Dim command As New SqlCommand("Select (Select Max(ColorSL) From OrderDetails Where FabricColorId=FabricForSizeGroup.FabricColorId And OrderId=" & row.OrderId & ") AS ColorSL,FabricColorId,Code,Reference,OrderQuantity,CuttingPercentage,CCSize,ContrastColorId,ForSize From FabricForSizeGroup Where FabricId=" & row.FabricId, connection)
                'Dim command As New SqlCommand(sqlstring, connection)

                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    With Me.FabricBOMDataSet.FabricBOMDetails

                        .GarmentsPartIdColumn.DefaultValue = row.GarmentsPartId
                        .FabricIdColumn.DefaultValue = row.FabricId
                        .UserIdColumn.DefaultValue = UserId
                        .ConsumptionColumn.DefaultValue = row.Con
                        .WastagePercentageColumn.DefaultValue = row.WastagePercentage
                        .GreyPercentageColumn.DefaultValue = row.GreyWastagePercentage
                        .ModifiedOnColumn.DefaultValue = Today()
                        .DyeingPricePerUnitColumn.DefaultValue = 0
                        .KnittingPricePerUnitColumn.DefaultValue = 0
                        .CCSizeColumn.DefaultValue = reader("CCSize").ToString()
                        .FabricColorIdColumn.DefaultValue = Val(reader("ContrastColorId").ToString())
                        .GarmentsColorIdColumn.DefaultValue = Val(reader("FabricColorId").ToString())
                        .OrderQuantityColumn.DefaultValue = Val(reader("OrderQuantity").ToString())
                        .CuttingPercentageColumn.DefaultValue = Val(reader("CuttingPercentage").ToString())
                        .ColorCodeColumn.DefaultValue = reader("Code").ToString()
                        .ELDNoColumn.DefaultValue = reader("Reference").ToString()
                        'If DBNull.Value.Equals(reader("ColorSL")) = False Then
                        .ColorSLColumn.DefaultValue = reader("ColorSL").ToString()
                        'End If
                        Dim FFQuantity As Double = FormatNumber((Val(reader("OrderQuantity").ToString()) / 12) * row.Con, 2)
                        'Debug.Print(FFQuantity)
                        .FinishFabricQuantityColumn.DefaultValue = FFQuantity
                        'row.GreyFabricQuantity = FormatNumber(CDec(row.Consumption) / 12 * CDec(row.OrderQuantity) * (1 + row.GreyPercentage / 100) + row.AdditionalQuantity * (1 + row.GreyPercentage / 100), 0)
                        Dim GFQuantity As Double = FormatNumber(CDec(row.Con) / 12 * CDec(Val(reader("OrderQuantity").ToString())) * (1 + row.GreyWastagePercentage / 100) + (0 * (1 + row.GreyWastagePercentage / 100)), 2)
                        .GreyFabricQuantityColumn.DefaultValue = GFQuantity
                        .ForSizeColumn.DefaultValue = reader("ForSize").ToString()



                    End With

                    FabricBOMDetailsBindingSource.AddNew()
                    FabricBOMDetailsBindingSource.MoveFirst()
                    FabricBOMDetailsBindingSource.MoveLast()

                End While

                reader.Close()

            End Using

            Me.FabricViewTableAdapter.FillByFabricBOMId(Me.FabricBOMDataSet.FabricView, Val(FabricBOMIdLabel1.Text))
            FabricViewBindingSource.ResetBindings(True)


            MessageBox.Show("Generated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'AddToBOMLinkLabel.Enabled = True

        End If

    End Sub

    Private Sub AsignedColorAndSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignedColorAndSizeButton.Click

        If SplitContainer4.Panel2Collapsed = False Then
            SplitContainer4.Panel2Collapsed = True
        Else
            SplitContainer4.Panel2Collapsed = False
        End If


        If FabricBindingSource.Position > -1 Then
            SetColorAndSize()
        End If

    End Sub


    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click

        On Error Resume Next
        UpdateColorAndSize()

        For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)

            If drv!FabricId = row.FabricId Then

                drv!GarmentsPartId = row.GarmentsPartId
                drv!CCSize = row.Length & "X" & row.FinishFabricDia
                drv!OrderQuantity = ReadData("Select Sum(OrderQuantity) From FabricForSize Where FabricId=" & row.FabricId & "And FabricColorId=" & drv!GarmentsColorId, cnn)
                Dim FFQuantity As Double = FormatNumber((Val(drv!OrderQuantity) / 12) * row.Con, 2)
                drv!FinishFabricQuantity = FFQuantity
                Dim GFQuantity As Double = FormatNumber(CDec(row.Con) / 12 * CDec(Val(drv!OrderQuantity)) * (1 + row.GreyWastagePercentage / 100) + (drv!AdditionalQuantity * (1 + row.GreyWastagePercentage / 100)), 2)
                drv!GreyFabricQuantity = GFQuantity
                drv!Consumption = row.Con
                drv!CuttingPercentage = ReadData("Select Top 1 CuttingPercentage From OrderCuttingPercentage Where OrderId=" & OrderIdGridLookUpEdit.EditValue & "And FabricColorId=" & drv!GarmentsColorId, cnn)
                drv!GreyPercentage = row.GreyWastagePercentage
                drv!SelectColumn = True

            End If

        Next

        FabricBOMDetailsBindingSource.ResetBindings(True)


    End Sub


    Private Sub UpdateMore()

        On Error Resume Next

        Dim row As FabricBOMDataSet.FabricBOMRow
        row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)


        'Me.IsPrintCheckEdit.Checked = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.IsAOPCheckEdit.Checked = ReadBooleanData("Select IsAOP From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.WashReferenceTextEdit.Text = ReadStringData("Select CASE WHEN IsWash=1 THEN 'Yes' ELSE '' END AS IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.WashDetailsTextEdit.Text = ReadStringData("Select WashType From WashTypeMst Where WashTypeId=(Select WashTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)
        'Me.IsPeachFinishCheckEdit.Checked = ReadBooleanData("Select IsPeachFinish From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.IsYDSCheckEdit.Checked = ReadBooleanData("Select IsYds From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.IsBrushCheckEdit.Checked = ReadBooleanData("Select IsBrush From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.IsBrushCheckEdit.Checked = ReadBooleanData("Select IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select WashTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        'Me.IsWashCheckEdit.Checked = ReadBooleanData("Select IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)


        row.IsPrint = ReadBooleanData("Select IsPrint From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.IsAOP = ReadBooleanData("Select IsAOP From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.WashReference = ReadStringData("Select CASE WHEN IsWash=1 THEN 'Yes' ELSE '' END AS IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.WashDetails = ReadStringData("Select WashType From WashTypeMst Where WashTypeId=(Select WashTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue & ")", cnn)
        row.IsPeachFinish = ReadBooleanData("Select IsPeachFinish From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.IsYDS = ReadBooleanData("Select IsYds From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.IsBrush = ReadBooleanData("Select IsBrush From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.IsWash = ReadBooleanData("Select IsWash From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.WashTypeId = ReadIntData("Select WashTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.YarnDyeingTypeId = ReadIntData("Select YarnDyeingTypeId From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.IsEmbroidery = ReadBooleanData("Select ISNULL(IsEmbroidery,0) From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.EmbroideryDetails = ReadStringData("Select EmbroideryDetails From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.PrintDetails = ReadStringData("Select PrintDetails From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.AOPDetails = ReadStringData("Select AOPDetails From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.SampleReference = ReadStringData("Select ApprovedSampleNo From [Order] Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        row.PO = ReadStringData("Select PO From POList2 Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)


    End Sub


    Private Sub GetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateMore()
    End Sub

    Private Sub IsPeachFinishCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles IsPeachFinishCheckEdit.CheckedChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click

        If SelectButton.Text = "&Select All" Then

            For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List
                drv!SelectColumn = True
            Next

            Me.FabricBOMDetailsBindingSource.ResetBindings(True)
            SelectButton.Text = "&Deselect All"

        Else

            For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List
                drv!SelectColumn = False
            Next

            Me.FabricBOMDetailsBindingSource.ResetBindings(True)
            SelectButton.Text = "&Select All"

        End If

    End Sub

    Private Sub SelectByFabricButton_Click(sender As Object, e As EventArgs) Handles SelectByFabricButton.Click
        On Error Resume Next

        For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)

            If drv!FabricId = row.FabricId Then
                drv!SelectColumn = True
            Else
                drv!SelectColumn = False
            End If

        Next

    End Sub

    Private Sub DelSelButton_Click(sender As Object, e As EventArgs) Handles DelSelButton.Click

        If IsFabricBOMCompleteCheckEdit.Checked = True AndAlso ProFlag = True Then
            MessageBox.Show("Sorry,Not Allowed to Edit, Already Proceeed." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AmendmentSimpleButton.Enabled = True
            Exit Sub
        End If

        For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List

            Dim row As FabricBOMDataSet.FabricRow
            row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricRow)

            If drv!SelectColumn = True Then
                ExecuteQuery("Delete YarnAllocationGMT Where FabricBOMDetailsId =" & drv!FabricBOMDetailsId, cnn)
                Me.FabricBOMDetailsBindingSource.RemoveCurrent()
            End If

        Next

        Me.YarnAllocationGMTTableAdapter.Fill(Me.FabricBOMDataSet.YarnAllocationGMT, GridLookUpEdit1.EditValue)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If IsFabricBOMCompleteCheckEdit.Checked = True AndAlso ProFlag = True Then
            MessageBox.Show("Sorry,Not Allowed to Edit, Already Proceeed." & vbNewLine & "You have to Amendment first to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AmendmentSimpleButton.Enabled = True
            Exit Sub
        End If

        If Me.FabricBOMBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricBOMRow
            row = CType(CType(Me.FabricBOMBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMRow)


            frmFabricBOMColorupdate.FBID = row.FabricBOMId
            frmFabricBOMColorupdate.ShowDialog()

            If frmFabricBOMColorupdate.DialogResult = System.Windows.Forms.DialogResult.OK Then

                For Each drv As DataRowView In Me.FabricForSizeBindingSource.List

                    If drv!FabricColorId = Me.PreGMTColorId AndAlso drv!ContrastColorId = Me.PrefabricColorId AndAlso drv!Reference = Me.PreFabColorReference AndAlso drv!Code = Me.PreFabColorCode Then
                        drv!FabricColorId = Me.NewGMTColorId
                        drv!ContrastColorId = Me.NewFabricColorId
                        drv!Reference = Me.NewFabColorRerence
                        drv!Code = Me.NewFabColorCode
                    End If


                Next

                For Each drv As DataRowView In Me.FabricBOMDetailsBindingSource.List

                    If drv!FabricColorId = Me.PrefabricColorId AndAlso drv!GarmentsColorId = Me.PreGMTColorId AndAlso drv!ELDNo = Me.PreFabColorReference AndAlso drv!ColorCode = Me.PreFabColorCode Then
                        drv!FabricColorId = Me.NewFabricColorId
                        drv!GarmentsColorId = Me.NewGMTColorId
                        drv!ELDNo = Me.NewFabColorRerence
                        drv!ColorCode = Me.NewFabColorCode
                    End If

                Next

            End If



        Else
            MessageBox.Show("Fabric BOM is not selected")

        End If


    End Sub

    Private Sub GridView6_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView6.CellValueChanged

        Dim TTLPer As Decimal = 0

        If e.Column.Caption = "Yarn %" Then

            For Each drv As DataRowView In Me.YarnAllocationGMTBindingSource

                'If DBNull.Value.Equals(drv!YarnPercentage) = False AndAlso drv!YarnPercentage > 0 Then
                TTLPer = TTLPer + drv!YarnPercentage
                'End If

            Next

            Dim row As FabricBOMDataSet.YarnAllocationGMTRow
            row = CType(CType(Me.YarnAllocationGMTBindingSource.Current, DataRowView).Row, FabricBOMDataSet.YarnAllocationGMTRow)

            If TTLPer > 100 Then
                row.YarnPercentage = row.YarnPercentage - (TTLPer - 100)
            End If

        End If

    End Sub

    Private Sub GetPercentageButton_Click(sender As Object, e As EventArgs) Handles GetPercentageButton.Click

        Try

            Me.Validate()
            Me.FabricBOMBindingSource.EndEdit()
            Me.FabricBOMDetailsBindingSource.EndEdit()
            Me.YarnAllocationGMTBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.FabricForSizeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricBOMDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If Me.YarnAllocationGMTBindingSource.Position > -1 Then

            Dim row As FabricBOMDataSet.FabricBOMDetailsRow
            row = CType(CType(Me.FabricBOMDetailsBindingSource.Current, DataRowView).Row, FabricBOMDataSet.FabricBOMDetailsRow)

            Dim TTLFeederSize As Decimal = ReadData("Select Sum(FeederSize) From YarnAllocationGMT Where FabricBOMDetailsId=" & row.FabricBOMDetailsId, cnn)

            For Each drv As DataRowView In Me.YarnAllocationGMTBindingSource.List
                drv!YarnPercentage = drv!FeederSize / TTLFeederSize * 100
            Next

        End If

    End Sub
End Class