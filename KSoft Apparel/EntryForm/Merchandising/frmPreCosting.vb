Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPreCosting

    Dim Addflag As Boolean = False
    Dim Completedflag As Boolean = False
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Dim OrQtyWithCP As Integer
    Private Sub frmPreCosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PreCostingDataSet.PreCostingTarget' table. You can move, or remove it, as needed.


        If UserId = 1 Then
            Me.PreCostingProgramLookupTableAdapter.Fill(Me.PreCostingDataSet.PreCostingProgramLookup)
            DeleteButton.Visible = True
            Me.PrecostingGridLookUpEdit.EditValue = -1
        Else
            Me.PreCostingProgramLookupTableAdapter.FillByOnlyLatestAndUser(Me.PreCostingDataSet.PreCostingProgramLookup, UserId)
            DeleteButton.Visible = False
            Me.PrecostingGridLookUpEdit.EditValue = -1
        End If



        Me.DyeingTypeTableAdapter.Fill(Me.DyeingTypeDataSet.DyeingType)
        Me.FabricFinishingTypeTableAdapter.Fill(Me.FabricFinishingTypeDataSet.FabricFinishingType)

        'Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutLookupDataSet.SewingLayout)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.AccessoriesListTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesList)

        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.FillByUserId(Me.StyleLookupDataSet.Style, UserId)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, YarnStore)
        Me.TrimListLookupTableAdapter.Fill(TrimListLookupDataSet.TrimListLookup, My.Settings.AccDepartmentId)

        'With DyeingTypeLookUpEdit

        '    .DataSource = GetDeyingTypeTable()
        '    .DisplayMember = "DyeingType"
        '    .ValueMember = "DyeingTypeId"
        '    .ForceInitialize() ' Force it to initialize
        '    .PopulateColumns() ' Force the lookupedit to populate
        '    .Columns("DyeingTypeId").Visible = False

        'End With

        Me.PreCostingDataSet.PreCostingMain.UserIdColumn.DefaultValue = UserId




        If CheckUserRights("Pre Costing").CanEdit = False Then

            AddButton.Enabled = False
            EditButton.Enabled = False

        End If

    End Sub




#Region "Procedure-GetData"

    Private Sub GetData()



        Dim row As PreCostingDataSet.PreCostingMainRow
        row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)


        Dim connection As New SqlConnection(cnn)

        connection.Open()
        MessageBox.Show(row.StyleId.ToString)
        Dim cmd As SqlCommand = New SqlCommand("Select AccessoriesId,ConUnitId,WastagePercentage,GarmentsQuantity,Consumption From StyleCapture_Accessories Where StyleId=" & row.StyleId, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'reader.Read()

        While reader.Read()



            Dim AID As Integer = reader("AccessoriesId")
            Dim PreCostingId As Integer = row.PreCostingId
            'Dim UID As Integer = reader("TUnitId")
            Dim UPrice As Decimal = ReadData("Select MaxPrice From AccessoriesList Where AccessoriesId=" & AID, cnn)
            Dim WP As Integer = reader("WastagePercentage")
            Dim Remarks As String = "-"

            ' ===========================================


            Dim BookingUnitId As Integer = ReadIntegerData("Select Distinct UnitId From AccessoriesList Where AccessoriesId=" & AID, cnn)
            Dim ConsumptionUnitId As Integer = reader("ConUnitId")
            'Dim ConversionValue As Decimal = ReadData("Select ConversionValue From UnitConversion Where FromUnitId=" & ConsumptionUnitId & " And ToUnitId=" & BookingUnitId, cnn)
            'Dim CalculateSign As String = ReadStringData("Select CalculateSign From UnitConversion Where FromUnitId=" & ConsumptionUnitId & " And ToUnitId=" & BookingUnitId, cnn)
            Dim CalculateSign As String = GetCSV(ConsumptionUnitId, BookingUnitId).Sign.ToString()
            Dim ConversionValue As Double = GetCSV(ConsumptionUnitId, BookingUnitId).value

            Dim GarmentsQuantity As Integer = reader("GarmentsQuantity")
            Dim Consumption As Decimal = reader("Consumption")
            Dim Cost As Decimal = 0
            Dim BookingConsumption As Decimal = 0

            If BookingUnitId = ConsumptionUnitId Then

                If GarmentsQuantity > 0 Then

                    BookingConsumption = (Consumption / GarmentsQuantity * 12)

                End If

            Else

                Select Case CalculateSign

                    Case "/"
                        BookingConsumption = (Consumption / GarmentsQuantity * 12) / ConversionValue
                    Case "X"
                        BookingConsumption = (Consumption / GarmentsQuantity * 12) * ConversionValue
                    Case "+"
                        BookingConsumption = (Consumption / GarmentsQuantity * 12) + ConversionValue
                    Case "-"
                        BookingConsumption = (Consumption / GarmentsQuantity * 12) - ConversionValue

                End Select

            End If

            '=========================================================

            Cost = BookingConsumption * (1 + WP / 100) * ReadData("Select MaxPrice From AccessoriesList Where AccessoriesId=" & AID, cnn)

            PreCosting_TrimsTableAdapter.InsertQuery(PreCostingId, AID, BookingUnitId, UPrice, WP, Consumption, Cost, Remarks, ConsumptionUnitId, GarmentsQuantity)

        End While

        reader.Close()
        connection.Close()

        Me.PreCosting_TrimsTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Trims, PrecostingGridLookUpEdit.EditValue)

    End Sub

#End Region



    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        If AddButton.Text = "&New" Then

            Me.PreCostingMainBindingSource.AddNew()
            Me.EditButton.Enabled = False
            AddButton.Text = "&Save"
            Addflag = True

        Else

            If Addflag = True Then

                Dim NCN As String = ""
                Dim ABC As String = Now.Year.ToString.Substring(2) & "CN"
                'Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(PreCostingNo),0,CHARINDEX('N',REVERSE(PreCostingNo))))) From PreCostingMain Where PreCostingNo Like '" & ABC & "%'", cnn)
                Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(PreCostingNo),0,CHARINDEX('N',REVERSE(PreCostingNo))))AS Integer)) From PreCostingMain Where PreCostingNo Like '" & ABC & "%'", cnn)
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "CN" & (Val(XYZ) + 1).ToString()
                NCN = NewOrder
                PreCostingNoTextEdit.Text = NCN


                Save()

                Me.PreCostingProgramLookupTableAdapter.FillByOnlyLatestAndUser(Me.PreCostingDataSet.PreCostingProgramLookup, UserId)

                Dim row As PreCostingDataSet.PreCostingMainRow
                row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)

                PrecostingGridLookUpEdit.EditValue = row.PreCostingId

                DefaultMisc()

            End If


            Save()

            AddButton.Text = "&New"

            Me.EditButton.Enabled = True

        End If

    End Sub


    Private Sub PreCostingFabricBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PreCostingFabricBindingSource.AddingNew
        Me.PreCostingMainBindingSource.EndEdit()
    End Sub

    Private Sub PreCosting_YarnBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PreCosting_YarnBindingSource.AddingNew
        Me.PreCostingMainBindingSource.EndEdit()
    End Sub

    Private Sub PreCosting_TrimsBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PreCosting_TrimsBindingSource.AddingNew
        Me.PreCostingMainBindingSource.EndEdit()
    End Sub

    Private Sub PreCostingMainPreCostingTrimsBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PreCostingMainPreCostingTrimsBindingSource.AddingNew
        Me.PreCostingMainBindingSource.EndEdit()
    End Sub

    Private Sub GetAccessoriesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAccessoriesButton.Click

        'If PreCosting_TrimsBindingSource.Position = -1 Then
        '    GetData()
        'End If

        If ConSpinEdit.Value = 0 Then
            MessageBox.Show("Consumption Data Missing")
            Exit Sub
        ElseIf UnitIdGridLookUpEdit.EditValue = -1 Then
            MessageBox.Show("Consumption Unit Data Missing ")
            Exit Sub
        ElseIf ConPCSSpinEdit.Value = 0 Then
            MessageBox.Show("Consumption for Garments Data Missing ")
            Exit Sub
        End If


        Dim row As PreCostingDataSet.PreCostingMainRow
        row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)



        Dim newRow As PreCostingDataSet.PreCosting_TrimsRow = Me.PreCostingDataSet.PreCosting_Trims.NewRow()
        newRow.PreCostingId = row.PreCostingId
        newRow.ItemId = AccNameGridLookUpEdit.EditValue
        newRow.UnitId = ReadIntegerData("Select UnitId From ItemList Where ItemId=" & AccNameGridLookUpEdit.EditValue, cnn)
        newRow.UnitPrice = ReadData("Select ISNULL(CurrentPrice,0) From ItemList Where ItemId=" & AccNameGridLookUpEdit.EditValue, cnn)
        newRow.ConUnitId = UnitIdGridLookUpEdit.EditValue
        newRow.Consumption = ConSpinEdit.Value
        newRow.GarmentsQuantity = ConPCSSpinEdit.Value
        newRow.WastagePercentage = WPercSpinEdit.Value



        'Getting Order Quantity 

        Dim Color As String = ""
        Dim Color1 As String = ""

        Color = Color2CheckedComboBoxEdit.Text

        Color1 = Color.Replace(", ", "','") 'You should use one space after first comma
        Color1 = Trim(Color1)


        Dim Size As String = ""
        Dim Size1 As String = ""

        Size = Size2CheckedComboBoxEdit.Text

        Size1 = Size.Replace(", ", "','") 'You should use one space after first comma
        Size1 = Trim(Size1)

        Dim OrderQuantity As Decimal = 0

        If Color1 = String.Empty AndAlso Size1 = String.Empty Then
            OrderQuantity = OrderQuantitySpinEdit.Value / SubStyleSpinEdit.Value
        Else
            OrderQuantity = ReadIntegerData("Select SUM(TTLOrderQuantity) From OrderQuantitySummery_ColorAndSize Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And ColorDetails in ('" & Color1 & "') And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", cnn)
        End If

        PreCosting_TrimsBindingSource.MoveLast()

        Dim row1 As PreCostingDataSet.PreCosting_TrimsRow
        row1 = CType(CType(Me.PreCosting_TrimsBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_TrimsRow)

        newRow.OrderQuantity = OrderQuantity

        newRow.ForColor = Color2CheckedComboBoxEdit.Text
        newRow.ForSize = Size2CheckedComboBoxEdit.Text


        Me.PreCostingDataSet.PreCosting_Trims.Rows.Add(newRow)



    End Sub


    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged
        'Try
        'Me.CM_FirstLayoutTableAdapter.Fill(Me.CuttingMakingDataSet.CM_FirstLayout, New System.Nullable(Of Long)(CType(StyleIdGridLookUpEdit.EditValue, Long)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
        On Error Resume Next
        'Me.CM_FirstLayoutTableAdapter.Fill(Me.CuttingMakingDataSet.CM_FirstLayout, StyleIdGridLookUpEdit.EditValue)
        'Me.BuyerIdLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)
        Me.OrderLookupByStyleTableAdapter.FillByStyleId(Me.OrderLookupDataSet.OrderLookupByStyle, StyleIdGridLookUpEdit.EditValue)
        Me.ProgramLookupTableAdapter.FillByStyleId(Me.PreCostingDataSet.ProgramLookup, CType(StyleIdGridLookUpEdit.EditValue, Long))
        Me.PreCostingDataSet.PreCosting_CM.StyleIdColumn.DefaultValue = StyleIdGridLookUpEdit.EditValue

    End Sub


    Private Sub GetCMButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetCMButton.Click
        'On Error Resume Next
        Dim CostPerMachine As Decimal = ReadData("Select NumberValue From prmCostPerMachinePerHour", cnn)
        Dim CostPerMinute As Decimal = ReadData("Select NumberValue From parameter Where PrameterName='Cost Per Minute'", cnn)
        Dim WP As Decimal = 1 + ReadData("Select NumberValue From prmCMTargetWastage", cnn) / 100

        Dim TTLFacCM As Decimal = 0
        Dim TTLBuyerCM As Decimal = 0
        Dim TTLMC As Integer = 0
        Dim TTLSMV As Decimal = 0
        Dim TTLProd As Integer = 0

        For Each drv As DataRowView In Me.PreCosting_CMBindingSource.List

            'Dim LCOUNT As Integer = ReadIntData("Select Count(SewingLayoutNo) From SewingLayout Where StyleId=" & drv!StyleId & "And DefaultLayout=1", cnn)

            'If LCOUNT > 1 Then
            '    MessageBox.Show("Multiple default Layout in same style is not allowed. Please, inform to IE Department regarding this issue.")
            '    Exit Sub
            'End If

            Dim FactoryCost As Decimal = 0
            'Dim ProdPerDay As Integer = ReadData("Select ISNULL(TargetsPerHour,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            Dim MCQuantity As Integer = ReadData("Select ISNULL(MachineQuantity,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            Dim HLPQuantity As Integer = ReadData("Select ISNULL(Helper,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            Dim SMVALL As Decimal = ReadData("Select ISNULL(TotalSMV_Machine,0)+ISNULL(TotalSMV_Manual,0)  From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GeneratePreCostingTarget", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PreCosting_CMId", drv!PreCosting_CMId)
                cmd.Parameters.AddWithValue("@SMV", SMVALL)
                cmd.Parameters.AddWithValue("@MC", (MCQuantity + HLPQuantity))
                cmd.Parameters.AddWithValue("@TTLOrderQuantity", OrderQuantityCPSpinEdit.EditValue / SubStyleSpinEdit.Value)
                cmd.ExecuteNonQuery()

            End Using
            Me.PreCostingTargetTableAdapter.Fill(Me.PreCostingDataSet.PreCostingTarget, drv!PreCosting_CMId)

            Dim AvgTargetQuantity As Integer = ReadIntData("Select Avg(OrderQuantity) From PreCostingTarget Where PreCosting_CMId=" & drv!PreCosting_CMId, cnn)
            'Dim AllocateQuantity As Decimal = ReadData("Select ISNULL(OrderQuantity,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)

            Dim DayCount As Integer = ReadIntData("Select Count(*) From SewingTargetAllocation Where SewingLayoutId=" & drv!LayoutId, cnn)
            '({@TOTALSMV}*{SewingLayout.TotalTargetQuantity})%(({SewingLayout.MachineQuantity}+{SewingLayout.Helper})*60)

            Dim Efficiency As Decimal = FormatNumber(((SMVALL * AvgTargetQuantity / 10) / ((MCQuantity + HLPQuantity) * 60)), 2) 'ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SMVALL & " and DaySerial=" & DayCount, cnn)
            'Dim LNO As String = ReadStringData("Select Top 1 SewingLayoutNo From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            drv!Remarks = "-" 'IIf(IsDBNull(LNO) = True, "", LNO)
            drv!CostPerMCPerHour = CostPerMachine
            drv!CostPerMinute = CostPerMinute
            drv!Efficiency = Efficiency * 100 'ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SMVALL & " and DaySerial=10", cnn)
            drv!SMV = SMVALL
            drv!LineQuantity = ReadIntData("Select Max(Line) From PreCostingTarget Where PreCosting_CMId=" & drv!PreCosting_CMId, cnn) 'OrderQuantitySpinEdit.Value / AllocateQuantity
            drv!DayRequire = ReadIntData("Select Count(*) From PreCostingTarget Where PreCosting_CMId=" & drv!PreCosting_CMId, cnn)

            'If ProdPerDay > 0 AndAlso drv!CostPerMCPerHour > 0 Then
            If Efficiency > 0 AndAlso drv!CostPerMinute > 0 Then
                drv!MachineQuantity = MCQuantity
                drv!ProductionPerHour = AvgTargetQuantity

                'FactoryCost = (MCQuantity / ProdPerDay * CostPerMachine * 12) * WP
                FactoryCost = FormatNumber(((CostPerMinute * SMVALL) / (Efficiency)) * 12, 3)

            Else
                MessageBox.Show("Sewing Layout is not available.Please, send a request to IE Department.")
                Exit Sub
            End If

            If FactoryCost > 0 Then
                drv!Factory_CM = FactoryCost
            Else
                drv!Factory_CM = 0
            End If

            TTLSMV = TTLSMV + IIf(IsDBNull(drv!SMV) = True, 0, drv!SMV)
            TTLMC = TTLMC + IIf(IsDBNull(drv!MachineQuantity) = True, 0, drv!MachineQuantity)
            TTLFacCM = TTLFacCM + IIf(IsDBNull(drv!Factory_CM) = True, 0, drv!Factory_CM)
            TTLBuyerCM = TTLBuyerCM + IIf(IsDBNull(drv!Buyer_CM) = True, 0, drv!Buyer_CM)
            TTLProd = TTLProd + IIf(IsDBNull(drv!ProductionPerHour) = True, 0, drv!ProductionPerHour)


        Next


        Me.MachineQuantitySpinEdit.Value = TTLMC
        Me.SMVSpinEdit.Value = TTLSMV
        Me.ProdPerDaySpinEdit.Value = TTLProd
        Me.FactoryCMSpinEdit.Value = TTLFacCM
        Me.BuyerCMSpinEdit.Value = TTLBuyerCM


        ''Get Target







    End Sub

    'Private Sub CMCalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMCalculateButton.Click
    '    '(ISNULL(dbo.prmCostPerMachinePerhour.NumberValue, 0) *  ISNULL(dbo.SewingLayout.MachineQuantity/dbo.SewingLayout.TotalTargetQuantity , 0) * 12) * (1 + dbo.prmCMTargetWastage.NumberValue / 100)
    'End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If ApprovalCheckEdit.Checked Then

            MessageBox.Show("Not allowed To edit approved Costing")
            Exit Sub

        End If

        If EditButton.Text = "&Edit" Then

            EditButton.Text = "&Save"
            AddButton.Enabled = False
            OrderLookupGridLookUpEdit.Properties.ReadOnly = False

            'If CompleteCheckEdit.Checked = True Then
            '    Completedflag = True
            'Else
            '    Completedflag = False
            'End If

        Else



            PreCostingDateDateEdit.Text = ReadDateData("Select GetDate()", cnn)
            Save()
            'Start calculating Cost

            Dim row As PreCostingDataSet.PreCostingMainRow
            row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)

            If Me.PreCosting_TrimsBindingSource.Position > -1 Then
                CalculateTrimCost()
                Save()
            End If
            If Me.PreCosting_CMBindingSource.Position > -1 Then
                CalculateCMCost()
                Save()
            End If
            If Me.PreCostingFabricBindingSource.Position > -1 Then
                CalculateCost()
                Me.PreCostingFabricBindingSource.ResetBindings(True)
                Save()
            End If



            'End Calculating Cost



            If row.IsOrderIdNull = False Then

                OrderQuantitySpinEdit.Value = ReadIntegerData("Select OrderQuantity From OrderQuantitySummery Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)

                'If UserId = 1 Then

                If Me.PreCostingFabricBindingSource.Position = -1 AndAlso IsDBNull(row.PreCostingId) = False Then
                    GetFabricFromCAD(row.PreCostingId)
                End If

                If Me.PreCosting_TrimsBindingSource.Position = -1 AndAlso IsDBNull(row.PreCostingId) = False Then
                    GetTrimsFromAccBOM(row.PreCostingId)
                End If

                'End If

            End If



            Save()

            EditButton.Text = "&Edit"
            OrderLookupGridLookUpEdit.Properties.ReadOnly = True
            AddButton.Enabled = True

            MessageBox.Show("Saved Successfully")

        End If

    End Sub
    Private Sub AssignProgram()
        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("AssignProgram", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@PreCostingId", PrecostingGridLookUpEdit.EditValue)
            cmd.Parameters.AddWithValue("@OrderId", OrderLookupGridLookUpEdit.EditValue)

            cmd.ExecuteNonQuery()

        End Using
    End Sub

    Private Sub Save()

        Me.Validate()
        Me.PreCostingMainBindingSource.EndEdit()
        Me.PreCosting_TrimsBindingSource.EndEdit()
        Me.PreCosting_YarnBindingSource.EndEdit()
        Me.PreCostingOthersBindingSource.EndEdit()
        Me.PreCostingFabricBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.PreCostingDataSet)
        Me.AddButton.Enabled = True
        Addflag = False

    End Sub

    Private Sub GridView4_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView4.CellValueChanged

        If e.Column.Caption = "Accessories Name" Then

            Dim row As PreCostingDataSet.PreCosting_TrimsRow
            row = CType(CType(Me.PreCosting_TrimsBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_TrimsRow)


            If e.Value.ToString() <> "" Then

                Dim MaxPrice As Decimal = ReadData("Select MaxPrice From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                Dim WastagePercentage As Integer = ReadIntData("Select WastagePercentage From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim TUnitId As Integer = ReadIntegerData("Select UnitId From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                Dim UnitId As Integer = ReadIntegerData("Select UnitId From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim SupplierId As Integer = ReadIntegerData("Select SupplierId From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)


                GridView4.SetRowCellValue(e.RowHandle, GridView4.Columns("WastagePercentage"), WastagePercentage)
                GridView4.SetRowCellValue(e.RowHandle, GridView4.Columns("UnitId"), UnitId)
                GridView4.SetRowCellValue(e.RowHandle, GridView4.Columns("UnitPrice"), UnitId)


            End If


        End If




    End Sub

    Private Sub CalculateTrimCostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub CalculateTrimCost()
        On Error Resume Next

        Dim row As PreCostingDataSet.PreCostingMainRow
        row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)

        For Each drv As DataRowView In PreCosting_TrimsBindingSource.List



            Dim BookingUnitId As Integer = drv!UnitId
            Dim ConsumptionUnitId As Integer = drv!ConUnitId
            Dim CalculateSign As String = ReadStringData("Select CalculateSign From UnitConversion Where FromUnitId=" & ConsumptionUnitId & " And ToUnitId=" & BookingUnitId, cnn)
            Dim ConversionValue As Decimal = ReadData("Select ConversionValue From UnitConversion Where FromUnitId=" & ConsumptionUnitId & " And ToUnitId=" & BookingUnitId, cnn)
            Dim WP As Decimal = drv!WastagePercentage
            'Dim SSQ As Integer = 0
            'If drv!IsALL = True Then
            '    SSQ = 1
            'Else
            '    SSQ = SubStyleSpinEdit.Value
            'End If
            If BookingUnitId = ConsumptionUnitId Then

                If drv!GarmentsQuantity > 0 Then
                    'drv!OrderQuantity = OrderQuantitySpinEdit.Value / SSQ
                    drv!RequireQuantity = (drv!Consumption / drv!GarmentsQuantity * 12) * (1 + WP / 100) * (drv!OrderQuantity / 12)
                    drv!Cost = (drv!Consumption / drv!GarmentsQuantity * 12) * drv!UnitPrice * (1 + WP / 100)

                End If

            Else

                Select Case CalculateSign

                    Case "/"
                        'drv!OrderQuantity = OrderQuantitySpinEdit.Value / SSQ
                        drv!RequireQuantity = ((drv!Consumption / drv!GarmentsQuantity * 12) / ConversionValue) * (drv!OrderQuantity / 12) * (1 + WP / 100)
                        drv!Cost = (((drv!Consumption / drv!GarmentsQuantity * 12) / ConversionValue) * drv!UnitPrice) * (1 + WP / 100)
                    Case "X"
                        'drv!OrderQuantity = OrderQuantitySpinEdit.Value / SSQ
                        drv!RequireQuantity = ((drv!Consumption / drv!GarmentsQuantity * 12) * ConversionValue) * (drv!OrderQuantity / 12) * (1 + WP / 100)
                        drv!Cost = (((drv!Consumption / drv!GarmentsQuantity * 12) * ConversionValue) * drv!UnitPrice) * (1 + WP / 100)
                    Case "+"
                        'drv!OrderQuantity = OrderQuantitySpinEdit.Value / SSQ
                        drv!RequireQuantity = ((drv!Consumption / drv!GarmentsQuantity * 12) + ConversionValue) * (drv!OrderQuantity / 12) * (1 + WP / 100)
                        drv!Cost = (((drv!Consumption / drv!GarmentsQuantity * 12) + ConversionValue) * drv!UnitPrice) * (1 + WP / 100)
                    Case "-"
                        'drv!OrderQuantity = OrderQuantitySpinEdit.Value / SSQ
                        drv!RequireQuantity = ((drv!Consumption / drv!GarmentsQuantity * 12) - ConversionValue) * (drv!OrderQuantity / 12) * (1 + WP / 100)
                        drv!Cost = (((drv!Consumption / drv!GarmentsQuantity * 12) - ConversionValue) * drv!UnitPrice) * (1 + WP / 100)

                End Select

            End If

        Next


        If PreCosting_TrimsBindingSource.Position > -1 Then

            Dim TrimCost As Decimal = 0

            For Each drv As DataRowView In PreCosting_TrimsBindingSource.List
                TrimCost = TrimCost + (drv!RequireQuantity * drv!UnitPrice)
                drv!Cost = ((drv!RequireQuantity + drv!AdditionalQuantity) * drv!UnitPrice)
            Next

            row.Trim_Cost = TrimCost

        End If




    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles PreCostingYarnGridView.CellValueChanged

        If e.Column.Caption = "Yarn" Then

            If e.Value.ToString <> "" Then


                Dim YarnPrice As Decimal = ReadData("Select Max(Price) From Receive Where ItemId=" & CInt(e.Value.ToString), cnn)
                PreCostingYarnGridView.SetRowCellValue(e.RowHandle, "Yarn_Cost", YarnPrice)


            End If

        End If
    End Sub

    Private Sub BandedGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles PreCostingFabBandedGridView.CellValueChanged

        'If e.Column.Caption = "Composition" Then

        '    Dim row As PreCostingDataSet.PreCostingFabricRow
        '    row = CType(CType(Me.PreCostingFabricBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricRow)

        '    On Error Resume Next

        '    If e.Value.ToString <> "" Then

        '        Dim KPrice As Decimal = ReadData("Select Max(KnittingPrice_kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)
        '        Dim YPrice As Decimal = 0
        '        Dim DPrice As Decimal = ReadData("Select Max(DyeingPrice_Kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)
        '        Dim AOPPrice As Decimal = ReadData("Select Max(AOPPrice_Kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)


        '        row.Knitting_Cost = KPrice
        '        row.Yarn_Cost = YPrice
        '        row.Dyeing_Cost = DPrice

        '        Dim IsAOP As Boolean = ReadBooleanData("Select IsAOP From Style where StyleId=" & Me.StyleIdGridLookUpEdit.EditValue, cnn)

        '        If IsAOP Then
        '            row.AOP_Cost = AOPPrice
        '        Else
        '            row.AOP_Cost = 0
        '        End If


        '        'Using connection As New SqlConnection(cnn)

        '        '    Dim command As New SqlCommand("Select ItemId, UsagesPercentage From FabricCostingMasterDetails Where FabricCostingMasterId=" & _
        '        '                                  "(Select FabricCostingMasterId From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId & "And GSMId=" & row.GSMId & ")", connection)

        '        '    command.Connection.Open()
        '        '    command.ExecuteNonQuery()

        '        '    Dim reader As SqlDataReader = command.ExecuteReader()

        '        '    While reader.Read()


        '        '        Dim newRow As PreCostingDataSet.PreCosting_YarnRow = Me.PreCostingDataSet.PreCosting_Yarn.NewRow()

        '        '        newRow.PreCostingFabricId = row.PreCostingFabricId
        '        '        newRow.ItemId = CType(reader("ItemId").ToString, Integer)
        '        '        newRow.YarnPercentage = CType(reader("UsagesPercentage").ToString, Integer)
        '        '        newRow.WastagePercentage = 8
        '        '        newRow.YarnColor = "-"
        '        '        newRow.Yds_Cost = 0
        '        '        newRow.Yarn_Cost = ReadData("Select CurrentPrice From ItemList Where ItemId=" & CType(reader("ItemId").ToString, Integer), cnn)

        '        '        Me.PreCostingDataSet.PreCosting_Yarn.Rows.Add(newRow)


        '        '    End While


        '        '    If PreCosting_YarnBindingSource.Position > -1 Then


        '        '        Dim YarnCostbyPercentage As Decimal

        '        '        For Each drvYarn As DataRowView In PreCosting_YarnBindingSource.List

        '        '            YarnCostbyPercentage = drvYarn!Yarn_Cost * (drvYarn!YarnPercentage / 100)
        '        '            YPrice = YPrice + YarnCostbyPercentage

        '        '        Next

        '        '    End If

        '        '    row.Yarn_Cost = YPrice
        '        'End Using


        '        If row.IsDyeingTypeNull = False Then
        '            row.Dyeing_Cost = ReadData("Select CostPerKg From DyeingType Where DyeingTypeId=" & row.DyeingType, cnn)
        '        End If





        '    End If


        'End If

    End Sub
    Public Structure CSV 'Conversion Sign And Value
        Public Sign As String
        Public value As Double
    End Structure
    Private Function GetCSV(ByVal ConsumptionUnit As Integer, ByVal BookingUnit As Integer) As CSV 'Get Conversion Sign And Value Function

        Dim myCSV As CSV

        myCSV.Sign = ReadStringData("Select CalculateSign From UnitConversion Where FromUnitId=" & ConsumptionUnit & " And ToUnitId=" & BookingUnit, cnn)
        myCSV.value = ReadData("Select ConversionValue From UnitConversion Where FromUnitId=" & ConsumptionUnit & " And ToUnitId=" & BookingUnit, cnn)

        Return myCSV

    End Function

    Private Sub GetFabricData()


        Dim row As PreCostingDataSet.PreCostingMainRow
        row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)


        Dim connection As New SqlConnection(cnn)

        connection.Open()
        'MessageBox.Show(row.StyleId.ToString)
        Dim cmd As SqlCommand = New SqlCommand("Select StyleCapture_FabricId,KnittingTypeId,CompositionId,Dia,DiaType,DUnit,GSMId,WastagePercentage,GarmentsPartId,Consumption,FUnitId,GarmentsQuantity,FabricConstructionType,IsAOP,IsYDS,SPNote,AOPDescription,YDSDescription,SPNoteDetails,DyeingTypeId From StyleCapture_Fabric Where StyleId=" & row.StyleId, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'reader.Read()

        While reader.Read()

            On Error Resume Next
            Dim newRow As PreCostingDataSet.PreCostingFabricRow = Me.PreCostingDataSet.PreCostingFabric.NewRow()

            newRow.PreCostingId = row.PreCostingId
            newRow.GarmentsPartId = reader("GarmentsPartId")
            newRow.KnittingTypeId = reader("KnittingTypeId")
            newRow.CompositionId = reader("CompositionId")
            newRow.WastagePercentage = reader("WastagePercentage")
            newRow.AOP_Cost = 0
            newRow.Knitting_Cost = 0
            newRow.Dyeing_Cost = ReadData("Select CostPerKg From DyeingType Where DyeingTypeId=" & reader("DyeingTypeId"), cnn)
            newRow.Yarn_Cost = 0
            newRow.Yds_Cost = 0
            'newRow.Peach_Cost = 0
            'newRow.Brush_Cost = 0
            newRow.GSMId = reader("GSMId")
            newRow.Consumption = reader("Consumption")
            newRow.tmpStyleCapture_FabricId = reader("StyleCapture_FabricId")

            Me.PreCostingDataSet.PreCostingFabric.Rows.Add(newRow)

        End While

        reader.Close()
        connection.Close()

    End Sub



    Private Sub GetFabricButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetFabricButton.Click
        If PreCostingFabricBindingSource.Position = -1 Then
            GetFabricData()
        End If
    End Sub

    Private Sub GetYarnData()

        'Loop Through  All Fabric
        For Each drv As DataRowView In PreCostingFabricBindingSource.List

            Dim YarnCount As Integer = ReadIntData("Select Count(*) From Precosting_Yarn Where PreCostingFabricId=" & drv!PreCostingFabricId, cnn)

            If YarnCount = 0 Then

                Dim Connection As New SqlConnection(cnn)
                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("Select ItemId,UsagesPercentage,WastagePercentage,Price,YdsColor,YdsPrice,IsYd From StyleCapture_Yarn Where StyleCapture_FabricId = " & drv!tmpStyleCapture_FabricId, Connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read()

                    On Error Resume Next

                    Dim newRow As PreCostingDataSet.PreCosting_YarnRow = Me.PreCostingDataSet.PreCosting_Yarn.NewRow()
                    newRow.PreCostingFabricId = drv!PreCostingFabricId
                    newRow.ItemId = reader("ItemId")
                    newRow.YarnPercentage = reader("UsagesPercentage")
                    newRow.WastagePercentage = reader("WastagePercentage")
                    newRow.Yds_Cost = 0
                    newRow.Yarn_Cost = 0
                    newRow.Lot_No = 0
                    newRow.YarnColor = reader("YdsColor")

                    Me.PreCostingDataSet.PreCosting_Yarn.Rows.Add(newRow)

                End While

                reader.Close()
                Connection.Close()

            End If

        Next

    End Sub

    Private Sub GetYarnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetYarnButton.Click
        GetYarnData()
        GetFinishing()

        Save()
    End Sub



    Private Sub GridView9_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView9.CellValueChanged


        If e.Column.Caption = "Fabric Finishing Type" Then

            'On Error Resume Next
            'Dim row As PreCostingDataSet.PreCostingFabricFinishingRow
            'row = CType(CType(Me.PreCostingFabricFinishingBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricFinishingRow)

            Dim view As GridView = TryCast(sender, GridView)
            Dim cellValue = view.GetRowCellValue(e.RowHandle, colFabricFinishingTypeId)
            view.SetRowCellValue(e.RowHandle, colPricePerKg, ReadData("Select Price From FabricFinishingType Where FabricFinishingTypeId=" & cellValue, cnn))


        End If
    End Sub



    Private Sub GetFinishing()

        'Loop Through  All Fabric
        For Each drv As DataRowView In PreCostingFabricBindingSource.List

            Dim FinishingCount As Integer = ReadIntData("Select Count(*) From PreCostingFabricFinishing Where PreCostingFabricId=" & drv!PreCostingFabricId, cnn)

            If FinishingCount = 0 Then

                Dim Connection As New SqlConnection(cnn)
                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("Select FinishingTypeId,PricePerKg From StyleCapture_Finishing Where StyleCapture_FabricId = " & drv!tmpStyleCapture_FabricId, Connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read()

                    On Error Resume Next

                    Dim newRow As PreCostingDataSet.PreCostingFabricFinishingRow = Me.PreCostingDataSet.PreCostingFabricFinishing.NewRow()
                    newRow.PreCostingFabricId = drv!PreCostingFabricId
                    newRow.FabricFinishingTypeId = reader("FinishingTypeId").ToString()
                    newRow.PricePerKg = reader("PricePerKg").ToString()


                    Me.PreCostingDataSet.PreCostingFabricFinishing.Rows.Add(newRow)

                End While

                reader.Close()
                Connection.Close()

            End If

        Next

    End Sub

    Private Sub GetPriceFromFabricMaster()

        On Error Resume Next



        Dim row As PreCostingDataSet.PreCostingFabricRow
        row = CType(CType(Me.PreCostingFabricBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricRow)


        Dim KPrice As Decimal = ReadData("Select Max(KnittingPrice_kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)
        Dim YPrice As Decimal = 0
        Dim DPrice As Decimal = ReadData("Select Max(DyeingPrice_Kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)
        Dim AOPPrice As Decimal = ReadData("Select Max(AOPPrice_Kg) From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId, cnn)


        row.Knitting_Cost = KPrice
        row.Yarn_Cost = YPrice
        row.Dyeing_Cost = DPrice

        Dim IsAOP As Boolean = ReadBooleanData("Select IsAOP From Style where StyleId=" & Me.StyleIdGridLookUpEdit.EditValue, cnn)

        If IsAOP Then
            row.AOP_Cost = AOPPrice
        Else
            row.AOP_Cost = 0
        End If


        Using connection As New SqlConnection(cnn)

            Dim command As New SqlCommand("Select ItemId,UsagesPercentage From FabricCostingMasterDetails Where FabricCostingMasterId=" &
                                          "(Select FabricCostingMasterId From FabricCostingMaster Where KnittingTypeId=" & row.KnittingTypeId & "And CompositionId=" & row.CompositionId & "And GSMId=" & row.GSMId & ")", connection)

            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()


                Dim newRow As PreCostingDataSet.PreCosting_YarnRow = Me.PreCostingDataSet.PreCosting_Yarn.NewRow()

                newRow.PreCostingFabricId = row.PreCostingFabricId
                newRow.ItemId = CType(reader("ItemId").ToString, Integer)
                newRow.YarnPercentage = CType(reader("UsagesPercentage").ToString, Integer)
                newRow.WastagePercentage = 8
                newRow.YarnColor = "-"
                newRow.Yds_Cost = 0
                newRow.Yarn_Cost = ReadData("Select CurrentPrice From ItemList Where ItemId=" & CType(reader("ItemId").ToString, Integer), cnn)

                Me.PreCostingDataSet.PreCosting_Yarn.Rows.Add(newRow)


            End While


            If PreCosting_YarnBindingSource.Position > -1 Then


                Dim YarnCostbyPercentage As Decimal

                For Each drvYarn As DataRowView In PreCosting_YarnBindingSource.List

                    YarnCostbyPercentage = drvYarn!Yarn_Cost * (drvYarn!YarnPercentage / 100)
                    YPrice = YPrice + YarnCostbyPercentage

                Next

            End If

            row.Yarn_Cost = YPrice
        End Using


        If row.IsDyeingTypeNull = False Then
            row.Dyeing_Cost = ReadData("Select CostPerKg From DyeingType Where DyeingTypeId=" & row.DyeingType, cnn)
        End If

    End Sub


    Private Sub GPFFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GPFFButton.Click

        If Me.PreCostingFabricBindingSource.Position > -1 Then
            GetPriceFromFabricMaster()
        Else
            MessageBox.Show("Data Not available")
        End If


    End Sub

    Private Sub AccLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AccLinkLabel.LinkClicked

        frmAccItemList.BuyerId = Me.BuyerGridLookUpEdit.EditValue
        ShowMaster(frmAccItemList)

        If frmAccItemList.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.TrimListLookupTableAdapter.Fill(Me.TrimListLookupDataSet.TrimListLookup, My.Settings.AccDepartmentId)
            Me.AccNameGridLookUpEdit.EditValue = frmAccItemList.ItemID


        End If

    End Sub


    Private Sub CalculateCost()
        Try


            If PreCostingMainBindingSource.Position > -1 Then

                Dim row As PreCostingDataSet.PreCostingMainRow
                row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)

                If PreCostingFabricBindingSource.Position > -1 Then

                    Dim KCost As Decimal = 0
                    Dim ACost As Decimal = 0
                    Dim DCost As Decimal = 0
                    Dim YCost As Decimal = 0
                    Dim YDCost As Decimal = 0
                    Dim FCost As Decimal = 0
                    Dim BCost As Decimal = 0
                    Dim WCost As Decimal = 0
                    Dim TTLFabCost As Decimal = 0
                    Dim YarnCostbyPercentage As Decimal = 0
                    Dim YdsCostbyPercentage As Decimal = 0


                    'Looping though Fabric
                    For Each drv As DataRowView In PreCostingFabricBindingSource.List


                        drv!Yarn_Cost = 0
                        drv!YDS_Cost = 0

                        ''Looping through Yarn
                        'If PreCosting_YarnBindingSource.Position > -1 Then

                        '    For Each drvYarn As DataRowView In PreCosting_YarnBindingSource.List

                        '        YarnCostbyPercentage = drvYarn!Yarn_Cost * (drvYarn!YarnPercentage / 100)
                        '        YdsCostbyPercentage = drvYarn!Yds_Cost * (drvYarn!YarnPercentage / 100)

                        '        drv!Yarn_Cost = drv!Yarn_Cost + YarnCostbyPercentage
                        '        drv!YDS_Cost = drv!YDS_Cost + YdsCostbyPercentage

                        '    Next

                        'End If

                        'Getting Yarn Price 

                        Dim YarnCost As Decimal = 0
                        Dim YDSCost As Decimal = 0
                        Using connection As New SqlConnection(cnn)

                            Dim querystring As String = "Select YarnPercentage,Yarn_Cost,Yds_Cost From PreCosting_Yarn Where PreCostingFabricId=" & drv!PreCostingFabricId

                            Dim command As New SqlCommand(querystring, connection)
                            command.Connection.Open()
                            command.ExecuteNonQuery()

                            Dim reader As SqlDataReader = command.ExecuteReader()

                            While reader.Read()

                                YarnCost = YarnCost + reader("Yarn_Cost") * reader("YarnPercentage") / 100
                                YDSCost = YDSCost + reader("Yds_Cost") * reader("YarnPercentage") / 100

                                drv!Yarn_Cost = FormatNumber(YarnCost, 3)
                                drv!Yds_Cost = YDSCost

                            End While



                            reader.Close()
                            connection.Close()

                        End Using




                        drv!Finishing_Cost = ReadData("Select Sum(PricePerKg) From PreCostingFabricFinishing Where PreCostingFabricId=" & drv!PreCostingFabricId, cnn)

                        Dim ProcLoss As Decimal = 0

                        If IsDBNull(drv!ProcessLossPercentage) = False Then
                            ProcLoss = (1 + drv!ProcessLossPercentage / 100)
                        Else
                            ProcLoss = 0
                        End If

                        If IsDBNull(drv!Consumption) = False AndAlso IsDBNull(drv!WastagePercentage) = False AndAlso IsDBNull(drv!OrderQuantity) = False Then

                            drv!FQty = (drv!OrderQuantity / 12) * (1 + drv!WastagePercentage / 100) * drv!Consumption

                        Else
                            drv!FQty = 0
                        End If

                        drv!GQty = FormatNumber(drv!FQty * ProcLoss, 2)

                        If drv!FinishUnit = "Kg" Then
                            KCost = KCost + (drv!GQty + drv!AdditionalQuantity) * IIf(IsDBNull(drv!Knitting_Cost) = True, 0, drv!Knitting_Cost)
                            FCost = FCost + (drv!GQty + drv!AdditionalQuantity) * drv!Finishing_Cost
                        ElseIf drv!FinishUnit = "Pcs" Then
                            KCost = KCost + (drv!GQty + drv!AdditionalQuantity) / 12 * IIf(IsDBNull(drv!Knitting_Cost_Dzn) = True, 0, drv!Knitting_Cost_Dzn)
                            FCost = FCost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Finishing_Cost
                        ElseIf drv!FinishUnit = "Yds" Then
                            KCost = KCost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * IIf(IsDBNull(drv!Knitting_Cost) = True, 0, drv!Knitting_Cost)
                            FCost = FCost + (drv!GQty + drv!AdditionalQuantity) / 12 * IIf(IsDBNull(drv!Knitting_Cost_Dzn) = True, 0, drv!Knitting_Cost_Dzn)
                        End If

                        ACost = ACost + drv!FQty * drv!KgPerUnit * drv!AOP_Cost * (1 + IIf(DBNull.Value.Equals(drv!AOP_WP) = True, 0, drv!AOP_WP) / 100) 'IIf(DBNull.Value.Equals(drv!AOP_Cost) = True, 0, drv!AOP_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100))
                        DCost = DCost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Dyeing_Cost 'IIf(DBNull.Value.Equals(drv!Dyeing_Cost) = True, 0, drv!Dyeing_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100)) * ProcLoss
                        YCost = FormatNumber(YCost, 2) + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Yarn_Cost 'IIf(DBNull.Value.Equals(drv!Yarn_Cost) = True, 0, drv!Yarn_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100)) * ProcLoss

                        'Debug.Print("Yarn Cost :=================================================")
                        'Debug.Print("Grey Quantity:" & drv!GQty.ToString())
                        'Debug.Print("TTL Yarn_Cost:" & drv!Yarn_Cost.ToString())
                        'Debug.Print("Yarn Cost : " & (FormatNumber(drv!GQty * drv!KgPerUnit, 3) * FormatNumber(drv!Yarn_Cost, 2)).ToString())
                        'Debug.Print("Yarn Cost : " & (FormatNumber(drv!KgPerUnit, 3).ToString()).ToString())

                        YDCost = YDCost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!YDS_Cost 'IIf(DBNull.Value.Equals(drv!YDS_Cost) = True, 0, drv!YDS_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100)) * ProcLoss
                        'IIf(DBNull.Value.Equals(drv!Finishing_Cost) = True, 0, drv!Finishing_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100)) * ProcLoss
                        'BCost = BCost + drv!Burnout_Cost 'IIf(DBNull.Value.Equals(drv!Burnout_Cost) = True, 0, drv!Burnout_Cost * drv!Consumption * (1 + drv!WastagePercentage / 100)) * ProcLoss
                        'PeachCost = PeachCost + IIf(DBNull.Value.Equals(drv!Peach_Cost) = True, 0, drv!Peach_Cost * drv!Consumption) * ProcLoss
                        'BrushCost = BrushCost + IIf(DBNull.Value.Equals(drv!Brush_Cost) = True, 0, drv!Peach_Cost * drv!Consumption) * ProcLoss


                        ''If drv!CCCostPerDzn > 0 Then
                        'drv!TTLFabricCost = drv!OrderQuantity / 12 * drv!CCCostPerDzn * (1 + drv!WastagePercentage / 100)
                        'Else
                        If drv!FinishUnit = "Kg" Then
                            drv!TTLFabricCost = (drv!FQty * drv!KgPerUnit * drv!AOP_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Knitting_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Dyeing_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!YDS_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Yarn_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Finishing_Cost)
                        Else
                            'drv!TTLFabricCost = (drv!FQty * drv!KgPerUnit * drv!AOP_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Knitting_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Dyeing_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!YDS_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Yarn_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Finishing_Cost)
                            drv!TTLFabricCost = (drv!FQty * drv!KgPerUnit * drv!AOP_Cost + (drv!GQty + drv!AdditionalQuantity) / 12 * IIf(IsDBNull(drv!Knitting_Cost_Dzn) = True, 0, drv!Knitting_Cost_Dzn) + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Dyeing_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!YDS_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Yarn_Cost + ((drv!GQty * drv!KgPerUnit) + drv!AdditionalQuantity) * drv!Finishing_Cost)
                        End If


                        'End If

                        'TTLFabCost = TTLFabCost + drv!TTLFabricCost

                    Next

                    row.Knitting_Cost = KCost '/ (row.OrderQuantity / row.SubStyleQty) * 12
                    row.AOP_Cost = ACost
                    row.Dyeing_Cost = DCost
                    row.Yarn_Cost = YCost
                    row.Yds_Cost = YDCost
                    row.FabricFinishing_Cost = FCost
                    row.Burnout_Cost = BCost

                    'row.Peach_Cost = PeachCost
                    'row.Brush_Cost = BrushCost



                End If



                'If row.PreCostingId > 0 Then
                '    row.FO_Cost = ReadData("Select Sum(CostPerDzn) From PreCostingOthers Where PrecostingId=" & row.PreCostingId, cnn)
                'End If
                If PreCostingOthersBindingSource.Position > -1 Then

                    Dim FOCost As Decimal = 0

                    For Each drv As DataRowView In PreCostingOthersBindingSource.List

                        If IsDBNull(drv!Percentage) = True Then
                            drv!Percentage = 0
                        End If
                        If drv!Percentage > 0 Then
                            drv!TTLCost = (row.OrderQuantity * row.OfferPrice0) * (drv!Percentage / 100)
                        ElseIf drv!Percentage = 0 AndAlso drv!TTLCost > 0 AndAlso row.OrderQuantity > 0 AndAlso row.OfferPrice0 > 0 Then
                            drv!Percentage = (drv!TTLCost / (row.OrderQuantity * row.OfferPrice0)) * 100
                        End If

                        If IsDBNull(row.OrderQuantity) = False Then
                            drv!CostPerDzn = 0
                        Else
                            drv!CostPerDzn = drv!TTLCost / (row.OrderQuantity / row.SubStyleQty / 12)
                        End If

                        FOCost = FOCost + drv!TTLCost

                    Next
                    row.FO_Cost = FOCost
                Else
                    row.FO_Cost = 0

                End If

                Me.PreCostingOthersBindingSource.ResetBindings(True)
                'row.TTLPrintCost = row.Print_Cost * (row.OrderQuantity / row.SubStyleQty / 12 * (1 + row.ProcessLossPercentage / 100))
                Dim TTLCost As Decimal = (row.Yarn_Cost + row.Yds_Cost + row.Dyeing_Cost + row.Knitting_Cost + row.AOP_Cost + row.FabricFinishing_Cost + row.Print_Cost + row.EMB_Cost + row.Wash_Cost + row.FO_Cost + row.Trim_Cost + row.FactoryCM)
                row.TTLCost0 = TTLCost


                If row.IsMarginPercentageNull Then
                    TTLCost = 0
                ElseIf row.IsOrderQuantityNull Then
                    TTLCost = 0
                Else
                    TTLCost = TTLCost / (row.OrderQuantity / 12) * (1 + row.MarginPercentage / 100)  'Cost/Dz
                End If

                row.TTLCost = TTLCost
                row.OfferPrice = TTLCost / 12

                If row.IsOfferPrice0Null = True Then
                    row.LCValue = 0
                Else
                    row.LCValue = FormatNumber(row.OrderQuantity * row.OfferPrice0, 2)
                End If


                If row.IsLCValueNull = False AndAlso row.LCValue > 0 Then
                    ActProfitSpinEdit.Value = FormatNumber((row.LCValue - row.TTLCost0) / row.LCValue * 100, 2)
                End If



                Save()



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub UpdateCostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCostButton.Click

        If Me.PreCosting_TrimsBindingSource.Position > -1 Then
            CalculateTrimCost()
        End If
        If Me.PreCosting_CMBindingSource.Position > -1 Then
            CalculateCMCost()
        End If
        CalculateCost()

    End Sub



    Private Sub CalculateCMCost()

        'On Error Resume Next

        Dim SMV As Decimal = 0
        Dim Target As Decimal = 0
        Dim FCM As Decimal = 0
        Dim BCM As Decimal = 0
        Dim MC As Decimal = 0
        Dim PrintCost As Decimal = 0
        Dim EmbCost As Decimal = 0
        Dim WashCost As Decimal = 0

        Dim AvgPrintWP As Decimal = 0
        Dim AvgEmbWP As Decimal = 0
        Dim AvgWashWP As Decimal = 0


        Dim row As PreCostingDataSet.PreCostingMainRow
        row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)


        For Each drv As DataRowView In PreCosting_CMBindingSource.List

            'If IIf(IsDBNull(drv!ProductionPerHour) = True, 0, drv!ProductionPerHour) > 0 AndAlso drv!CostPerMCPerHour > 0 Then
            'If drv!CostPerMinute > 0 Then

            Dim CostPerMinute As Decimal = ReadData("Select NumberValue From parameter Where PrameterName='Cost Per Minute'", cnn)
            SMV = SMV + IIf(IsDBNull(drv!SMV) = True, 0, drv!SMV)
            Target = Target + IIf(IsDBNull(drv!ProductionPerHour) = True, 0, drv!ProductionPerHour)
            'drv!Factory_CM = (drv!MachineQuantity / drv!ProductionPerHour * drv!CostPerMCPerHour * 12) * (1 + row.ProcessLossPercentage / 100)
            'FCM = FCM + (drv!MachineQuantity / drv!ProductionPerHour * drv!CostPerMCPerHour * 12) * (1 + row.ProcessLossPercentage / 100)

            Dim MCQuantity As Integer = ReadData("Select ISNULL(MachineQuantity,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            Dim HLPQuantity As Integer = ReadData("Select ISNULL(Helper,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            Dim TargetQuantity As Integer = ReadData("Select ISNULL(TotalTargetQuantity,0) From SewingLayout Where LayoutId=" & drv!LayoutId, cnn)
            'Dim Efficiency As Decimal = ((drv!SMV * TargetQuantity) / ((MCQuantity + HLPQuantity) * 60))
            'Dim Efficiency As Decimal = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & drv!SMV & " and DaySerial=10", cnn)
            FCM = FCM + FormatNumber(((CostPerMinute * drv!SMV) / (drv!Efficiency / 100)) * 12, 2)
            FactoryCost = FormatNumber(((CostPerMinute * drv!SMV) / (drv!Efficiency / 100)) * 12, 2)
            drv!Factory_CM = FactoryCost
            BCM = BCM + IIf(IsDBNull(drv!Buyer_CM) = True, 0, drv!Buyer_CM)
            MC = MC + IIf(IsDBNull(drv!MachineQuantity) = True, 0, drv!MachineQuantity)

            'PrintCost = PrintCost + IIf(IsDBNull(drv!PrintCostDzn) = True, 0, drv!PrintCostDzn)
            'EmbCost = EmbCost + IIf(IsDBNull(drv!EmbCostDzn) = True, 0, drv!EmbCostDzn)
            'WashCost = WashCost + IIf(IsDBNull(drv!WashCostDzn) = True, 0, drv!WashCostDzn)

            'End If

            PrintCost = PrintCost + IIf(IsDBNull(drv!PrintCostDzn) = True, 0, drv!PrintCostDzn)
            EmbCost = EmbCost + IIf(IsDBNull(drv!EmbCostDzn) = True, 0, drv!EmbCostDzn)
            WashCost = WashCost + IIf(IsDBNull(drv!WashCostDzn) = True, 0, drv!WashCostDzn)

            AvgPrintWP = AvgPrintWP + IIf(IsDBNull(drv!PrintWP) = True, 0, drv!PrintWP)
            AvgEmbWP = AvgEmbWP + IIf(IsDBNull(drv!EmbCostDzn) = True, 0, drv!EmbWP)
            AvgWashWP = AvgWashWP + IIf(IsDBNull(drv!WashWP) = True, 0, drv!WashWP)

        Next



        row.MachineQuantity = MC
        row.SMV = SMV
        row.ProdPerDay = Target

        If Me.PreCostingMainBindingSource.Position > -1 Then

            Dim AvgCP As Decimal = ReadData("Select Avg(AvgCuttingPercentage) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.ProcessLossPercentageSpinEdit.Value = FormatNumber(AvgCP, 2)
            OrQtyWithCP = ReadData("Select SUM(TTLOrderQuantity) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.OrderQuantityCPSpinEdit.Value = OrQtyWithCP
            Me.SewingLayoutTableAdapter.FillByOrderId(Me.SewingLayoutLookupDataSet.SewingLayout, OrderLookupGridLookUpEdit.EditValue)

        End If

        row.FactoryCM = FCM * FormatNumber((OrQtyWithCP / row.SubStyleQty / 12), 2)
        row.Print_Cost = PrintCost * (row.OrderQuantity / row.SubStyleQty / 12) * (1 + AvgPrintWP / 100)
        row.EMB_Cost = EmbCost * (row.OrderQuantity / row.SubStyleQty / 12) * (1 + AvgEmbWP / 100)
        row.Wash_Cost = WashCost * (row.OrderQuantity / row.SubStyleQty / 12) * (1 + AvgWashWP / 100)

        row.BuyerCM = BCM

        PreCosting_CMBindingSource.EndEdit()

    End Sub



    Private Sub BuyerIdLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.AccessoriesCategoryLookupTableAdapter.Fill(Me.AccessoriesCategoryLookupDataSet.AccessoriesCategoryLookup, BuyerGridLookUpEdit.EditValue)
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        GetAccTemplateData()

    End Sub

    Private Sub GetAccTemplateData()

        Try
            Dim row As PreCostingDataSet.PreCostingMainRow
            row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)


            Dim connection As New SqlConnection(cnn)

            connection.Open()
            'MessageBox.Show(row.StyleId.ToString)
            Dim cmd As SqlCommand = New SqlCommand("Select ItemId,ConUnitId,UnitId,UnitPrice,Remarks,WastagePercentage,Consumption,ForGMTQty From AccessoriesTemplate Where BuyerId=" & BuyerGridLookUpEdit.EditValue & " And TemplateCategory='" & CategoryComboBox.SelectedValue & "'", connection)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Read()

            While reader.Read()


                Dim newRow As PreCostingDataSet.PreCosting_TrimsRow = Me.PreCostingDataSet.PreCosting_Trims.NewRow()

                newRow.PreCostingId = row.PreCostingId
                newRow.ItemId = reader("ItemId").ToString()
                newRow.ConUnitId = reader("ConUnitId").ToString()
                newRow.UnitId = reader("UnitId").ToString()
                newRow.UnitPrice = reader("UnitPrice").ToString()
                newRow.Consumption = reader("Consumption").ToString()
                newRow.GarmentsQuantity = reader("ForGMTQty").ToString()
                newRow.WastagePercentage = reader("WastagePercentage")
                newRow.Remarks = "-"

                Me.PreCostingDataSet.PreCosting_Trims.Rows.Add(newRow)

            End While

            reader.Close()
            connection.Close()

            MessageBox.Show("Loaded")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click

        Me.PreCostingMainTableAdapter.FillByPreCostingId(Me.PreCostingDataSet.PreCostingMain, PrecostingGridLookUpEdit.EditValue)
        Me.PreCostingOthersTableAdapter.Fill(Me.PreCostingDataSet.PreCostingOthers, PrecostingGridLookUpEdit.EditValue)
        Me.PreCostingFabricFinishingTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabricFinishing, PrecostingGridLookUpEdit.EditValue)
        Me.PreCosting_TrimsTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Trims, PrecostingGridLookUpEdit.EditValue)
        Me.PreCosting_YarnTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Yarn, PrecostingGridLookUpEdit.EditValue)
        Me.PreCostingFabricTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabric, PrecostingGridLookUpEdit.EditValue)
        Me.PreCosting_CMTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_CM, PrecostingGridLookUpEdit.EditValue)

        AddButton.Text = "&New"
        Addflag = False

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        If Me.PreCostingMainBindingSource.Position > -1 Then

            Dim row As PreCostingDataSet.PreCostingMainRow
            row = CType(CType(Me.PreCostingMainBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingMainRow)

            frmPreCostingNewUser.CID = row.PreCostingId
            ShowForm(frmPreCostingNewUser)


        End If


    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        If PrecostingGridLookUpEdit.EditValue > 0 Then
            GoTo Line1
        Else
            MessageBox.Show("Please, select a costing...")
            Exit Sub
        End If
Line1:

        If MessageBox.Show("Are you sure your want to copy ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim NCN As String = ""
            Dim ABC As String = Now.Year.ToString.Substring(2) & "CN"
            Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(PreCostingNo),0,CHARINDEX('N',REVERSE(PreCostingNo))))AS Integer)) From PreCostingMain Where PreCostingNo Like '" & ABC & "%'", cnn)

            Dim NewOrder As String = Now.Year.ToString.Substring(2) & "CN" & (Val(XYZ) + 1).ToString()
            NCN = NewOrder

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("CopyPreCosting", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PreCostingId", PrecostingGridLookUpEdit.EditValue)
                cmd.Parameters.AddWithValue("@NewPreCostingNo", NCN)

                cmd.ExecuteNonQuery()

            End Using


            Me.PreCostingProgramLookupTableAdapter.FillByOnlyLatestAndUser(Me.PreCostingDataSet.PreCostingProgramLookup, UserId)

            Dim NewPreCostingId As Integer = ReadIntegerData("Select PreCostingId From PreCostingMain Where PreCostingNo='" & NCN & "'", cnn)

            PrecostingGridLookUpEdit.EditValue = NewPreCostingId

            Me.PreCostingMainTableAdapter.FillByPreCostingId(Me.PreCostingDataSet.PreCostingMain, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCostingOthersTableAdapter.Fill(Me.PreCostingDataSet.PreCostingOthers, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCostingFabricFinishingTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabricFinishing, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCosting_TrimsTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Trims, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCosting_YarnTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Yarn, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCostingFabricTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabric, CType(PrecostingGridLookUpEdit.EditValue, Long))
            Me.PreCosting_CMTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_CM, CType(PrecostingGridLookUpEdit.EditValue, Long))


            MessageBox.Show("Copy has been done." & vbNewLine & "Your new Costing No :" & NCN.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub StyleIdLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles StyleIdLabel.LinkClicked

        On Error Resume Next

        If StyleIdGridLookUpEdit.EditValue > -1 Then
            frmStyle.StyleId = StyleIdGridLookUpEdit.EditValue
        End If

        frmStyle.ShowDialog()

        If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'On Error Resume Next

            Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
            Me.StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId
            'MessageBox.Show(frmStyle.StyleId.ToString())
            BuyerGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            GSMTextEdit.Text = ReadIntegerData("Select GSM From Style Where StyleId=" & frmStyle.StyleId, cnn)
            'Me.MachineQuantitySpinEdit.Value = ReadIntData("Select ISNULL(MCQty,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)
            'Me.ProdPerDaySpinEdit.Value = ReadIntData("Select ISNULL(DefaultTarget,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)
            'Me.SMVSpinEdit.Value = ReadData("Select ISNULL(SMV,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)


        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        On Error Resume Next
        If StyleIdGridLookUpEdit.EditValue > -1 And IsDBNull(StyleIdGridLookUpEdit.EditValue) = False Then

            frmProgramLookuByStyle.SID = StyleIdGridLookUpEdit.EditValue

        End If

        frmProgramLookuByStyle.ShowDialog()

        If frmProgramLookuByStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'On Error Resume Next

            Me.OrderLookupGridLookUpEdit.EditValue = Me.OID
            Dim TTLValue As Decimal = ReadData("Select SUM(Price*OrderQuantity) From [OrderDetails] Where OrderId=" & Me.OID, cnn)
            Dim TTLQuantity As Integer = ReadIntegerData("Select OrderQuantity From OrderQuantitySummery Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.OfferPrice0TextEdit.Text = TTLValue / TTLQuantity
            Me.OrderQuantitySpinEdit.Value = ReadIntegerData("Select OrderQuantity From OrderQuantitySummery Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Dim AvgCP As Decimal = ReadData("Select Avg(AvgCuttingPercentage) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.ProcessLossPercentageSpinEdit.Value = FormatNumber(AvgCP, 0)
            OrQtyWithCP = ReadData("Select SUM(TTLOrderQuantity) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.OrderQuantityCPSpinEdit.Value = OrQtyWithCP
            Me.SewingLayoutTableAdapter.FillByOrderId(Me.SewingLayoutLookupDataSet.SewingLayout, OrderLookupGridLookUpEdit.EditValue)

        End If

    End Sub

    Private Sub frmPreCosting_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F11 Then

            If PreCosting_CMGridControl.IsFocused Then



                Dim row As PreCostingDataSet.PreCosting_CMRow
                row = CType(CType(Me.PreCosting_CMBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_CMRow)

                If PreCostingCMGridView.FocusedColumn.AbsoluteIndex = colStyleId1.AbsoluteIndex Then
                    frmStyle.StyleId = row.StyleId
                    frmStyle.ShowDialog()

                    If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)

                        row.StyleId = frmStyle.StyleId

                        PreCosting_CMBindingSource.ResetBindings(True)

                    End If


                End If


            ElseIf StyleIdGridLookUpEdit.IsEditorActive Then

                On Error Resume Next

                If StyleIdGridLookUpEdit.EditValue > -1 Then
                    frmStyle.StyleId = StyleIdGridLookUpEdit.EditValue
                End If

                frmStyle.ShowDialog()

                If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    'On Error Resume Next

                    Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
                    Me.StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId
                    'MessageBox.Show(frmStyle.StyleId.ToString())
                    BuyerGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                    Me.MachineQuantitySpinEdit.Value = ReadIntData("Select ISNULL(MCQty,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)
                    Me.ProdPerDaySpinEdit.Value = ReadIntData("Select ISNULL(DefaultTarget,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)
                    Me.SMVSpinEdit.Value = ReadData("Select ISNULL(SMV,0) From Style Where StyleId=" & frmStyle.StyleId, cnn)


                End If


            ElseIf PreCostingFabricGridControl.IsFocused Then

                If PreCostingFabBandedGridView.FocusedColumn.AbsoluteIndex = colFabricColorName1.AbsoluteIndex Then

                    frmFabricColor.ShowDialog()

                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Dim row As PreCostingDataSet.PreCostingFabricRow
                        row = CType(CType(Me.PreCostingFabricBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricRow)

                        row.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & frmFabricColor.FabricColorId, cnn)

                        PreCostingFabricBindingSource.ResetBindings(True)


                    End If


                End If

            ElseIf PreCosting_YarnGridControl.IsFocused Then

                If PreCostingYarnGridView.FocusedColumn.AbsoluteIndex = colYarnColor.AbsoluteIndex Then


                    frmFabricColor.ShowDialog()


                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then


                        Dim row As PreCostingDataSet.PreCosting_YarnRow
                        row = CType(CType(Me.PreCosting_YarnBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_YarnRow)

                        row.YarnColor = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & frmFabricColor.FabricColorId, cnn)

                        PreCostingFabricBindingSource.ResetBindings(True)


                    End If


                End If

            ElseIf OrderLookupGridLookUpEdit.IsEditorActive Then

                If StyleIdGridLookUpEdit.EditValue > -1 Then

                    frmProgramLookuByStyle.SID = StyleIdGridLookUpEdit.EditValue

                End If

                frmProgramLookuByStyle.ShowDialog()

                If frmProgramLookuByStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    'On Error Resume Next

                    Me.OrderLookupGridLookUpEdit.EditValue = Me.OID

                End If

            End If


        End If

    End Sub

    Private Sub GetFabricFromCAD(ByVal PCID As Integer)

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("GetFabricFromCAD", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@PreCostingId", PCID)
            cmd.ExecuteNonQuery()

        End Using

        Me.PreCostingFabricTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabric, PCID)
        Me.PreCosting_YarnTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Yarn, PCID)

    End Sub

    Private Sub GetTrimsFromAccBOM(ByVal PCID As Integer)

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("GetTrimsFromAccBOM", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@PreCostingId", PCID)
            cmd.ExecuteNonQuery()

        End Using

        Me.PreCosting_TrimsTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Trims, PCID)

    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click


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

        Dim OrderQuantity As Decimal = 0

        If Color1 = String.Empty AndAlso Size1 = String.Empty Then
            OrderQuantity = OrderQuantitySpinEdit.Value / SubStyleSpinEdit.Value
        Else
            OrderQuantity = ReadIntegerData("Select SUM(TTLOrderQuantity) From OrderQuantitySummery_ColorAndSize Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And ColorDetails in ('" & Color1 & "') And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", cnn)
        End If


        Dim row As PreCostingDataSet.PreCostingFabricRow
        row = CType(CType(Me.PreCostingFabricBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricRow)

        row.OrderQuantity = OrderQuantity

        row.ForColor = ColorCheckedComboBoxEdit.Text
        row.ForSize = SizeCheckedComboBoxEdit.Text


    End Sub

    Private Sub OrderLookupGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderLookupGridLookUpEdit.EditValueChanged

        On Error Resume Next
        Me.OrderSizeLookupTableAdapter.Fill(Me.OrderSizeDataSet.OrderSizeLookup, Me.OrderLookupGridLookUpEdit.EditValue)
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, Me.OrderLookupGridLookUpEdit.EditValue)
        Me.SewingLayoutTableAdapter.FillByOrderId(Me.SewingLayoutLookupDataSet.SewingLayout, OrderLookupGridLookUpEdit.EditValue)
    End Sub

    Private Sub CopyFabricButton_Click(sender As Object, e As EventArgs) Handles CopyFabricButton.Click

        If PreCostingFabricBindingSource.Position > -1 Then

            If MessageBox.Show("Are you sure you want to copy ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim row As PreCostingDataSet.PreCostingFabricRow
                row = CType(CType(Me.PreCostingFabricBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricRow)


                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("CopyPreCostingFabric", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@PreCostingFabricId", row.PreCostingFabricId)


                    cmd.ExecuteNonQuery()

                End Using

                Me.PreCosting_YarnTableAdapter.Fill(Me.PreCostingDataSet.PreCosting_Yarn, PrecostingGridLookUpEdit.EditValue)
                Me.PreCostingFabricTableAdapter.Fill(Me.PreCostingDataSet.PreCostingFabric, PrecostingGridLookUpEdit.EditValue)
            Else

                Exit Sub

            End If




        End If


    End Sub

    Private Sub GetOrQtyTrimsButton_Click(sender As Object, e As EventArgs) Handles GetOrQtyTrimsButton.Click

        If Me.PreCosting_TrimsBindingSource.Position > -1 Then


            Dim Color As String = ""
            Dim Color1 As String = ""

            Color = Color2CheckedComboBoxEdit.Text

            Color1 = Color.Replace(", ", "','") 'You should use one space after first comma
            Color1 = Trim(Color1)


            Dim Size As String = ""
            Dim Size1 As String = ""

            Size = Size2CheckedComboBoxEdit.Text

            Size1 = Size.Replace(", ", "','") 'You should use one space after first comma
            Size1 = Trim(Size1)
            Dim OrderQuantity As Decimal = 0

            If Color1 = String.Empty AndAlso Size1 = String.Empty Then
                OrderQuantity = OrderQuantitySpinEdit.Value / SubStyleSpinEdit.Value
            Else
                OrderQuantity = ReadIntegerData("Select SUM(TTLOrderQuantity) From OrderQuantitySummery_ColorAndSize Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And ColorDetails in ('" & Color1 & "') And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", cnn)
            End If


            Dim row1 As PreCostingDataSet.PreCosting_TrimsRow
            row1 = CType(CType(Me.PreCosting_TrimsBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_TrimsRow)

            row1.OrderQuantity = OrderQuantity

            row1.ForColor = Color2CheckedComboBoxEdit.Text
            row1.ForSize = Size2CheckedComboBoxEdit.Text

        End If

    End Sub



    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim flag As Boolean = False

        If Me.PreCostingFabricBindingSource.Position > -1 Then
            MessageBox.Show("Delete Fabric")
            Exit Sub
        ElseIf Me.PreCostingOthersBindingSource.Position > -1 Then
            MessageBox.Show("Delete Others")
            Exit Sub
        ElseIf Me.PreCosting_CMBindingSource.Position > -1 Then
            MessageBox.Show("Delete CM")
            Exit Sub
        ElseIf Me.PreCosting_TrimsBindingSource.Position > -1 Then
            MessageBox.Show("Delete Trims")
            Exit Sub
        Else

            Me.Validate()
            Me.PreCostingMainBindingSource.EndEdit()
            Me.PreCosting_TrimsBindingSource.EndEdit()
            Me.PreCosting_YarnBindingSource.EndEdit()
            Me.PreCostingOthersBindingSource.EndEdit()
            Me.PreCostingFabricBindingSource.EndEdit()
            Me.PreCostingMainBindingSource.RemoveCurrent()
            Me.Validate()
            Me.PreCostingMainBindingSource.EndEdit()
            Me.PreCosting_TrimsBindingSource.EndEdit()
            Me.PreCosting_YarnBindingSource.EndEdit()
            Me.PreCostingOthersBindingSource.EndEdit()
            Me.PreCostingFabricBindingSource.EndEdit()

            If UserId = 1 Then
                Me.PreCostingProgramLookupTableAdapter.Fill(Me.PreCostingDataSet.PreCostingProgramLookup)
            Else
                Me.PreCostingProgramLookupTableAdapter.FillByOnlyLatestAndUser(Me.PreCostingDataSet.PreCostingProgramLookup, UserId)
            End If


            MessageBox.Show("Deleted Successfully")
        End If

    End Sub



    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.PreCostingMainBindingSource.Position > -1 Then

            Dim AvgCP As Decimal = ReadData("Select Avg(AvgCuttingPercentage) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.ProcessLossPercentageSpinEdit.Value = FormatNumber(AvgCP, 2)
            OrQtyWithCP = ReadData("Select SUM(TTLOrderQuantity) As TTLOrderQuantity From OrderQuantitySummery_ColorAndSizeWithCP Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Me.OrderQuantityCPSpinEdit.Value = OrQtyWithCP
            Me.SewingLayoutTableAdapter.FillByOrderId(Me.SewingLayoutLookupDataSet.SewingLayout, OrderLookupGridLookUpEdit.EditValue)

        End If
    End Sub

    Private Sub RefreshLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RefreshLinkLabel.LinkClicked

        If Me.PreCosting_CMBindingSource.Position > -1 Then

            Dim row As PreCostingDataSet.PreCosting_CMRow
            row = CType(CType(Me.PreCosting_CMBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCosting_CMRow)

            Me.PreCostingTargetTableAdapter.Fill(Me.PreCostingDataSet.PreCostingTarget, row.PreCosting_CMId)

        End If

    End Sub

    Private Sub SpinEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles SpinEdit3.EditValueChanged

    End Sub

    Private Sub DefultMiscButton_Click(sender As Object, e As EventArgs) Handles DefultMiscButton.Click
        DefaultMisc()
    End Sub

    Private Sub DefaultMisc()

        If Me.PreCostingOthersBindingSource.Position = -1 Then

            Dim newRow1 = CType(Me.PreCostingDataSet.PreCostingOthers.NewRow(), PreCostingDataSet.PreCostingOthersRow)
            newRow1.PreCostingId = PrecostingGridLookUpEdit.EditValue
            newRow1.CostItem = "TestCost"
            newRow1.Percentage = 0
            newRow1.TTLCost = 0

            Me.PreCostingDataSet.PreCostingOthers.Rows.Add(newRow1)


            Dim newRow2 = CType(Me.PreCostingDataSet.PreCostingOthers.NewRow(), PreCostingDataSet.PreCostingOthersRow)
            newRow2.PreCostingId = PrecostingGridLookUpEdit.EditValue
            newRow2.CostItem = "Buying Commission"
            newRow2.Percentage = 0
            newRow2.TTLCost = 0

            Me.PreCostingDataSet.PreCostingOthers.Rows.Add(newRow2)


            Dim newRow3 = CType(Me.PreCostingDataSet.PreCostingOthers.NewRow(), PreCostingDataSet.PreCostingOthersRow)
            newRow3.PreCostingId = PrecostingGridLookUpEdit.EditValue
            newRow3.CostItem = "Financial & Commercial Cost"
            newRow3.Percentage = 0
            newRow3.TTLCost = 0

            Me.PreCostingDataSet.PreCostingOthers.Rows.Add(newRow3)

        End If

    End Sub

    Private Sub PrecostingGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PrecostingGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub CompleteCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles CompleteCheckEdit.CheckedChanged
        If CompleteCheckEdit.Checked = True Then

        End If
    End Sub

    Private Sub PreCostingDateDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PreCostingDateDateEdit.EditValueChanged

    End Sub
End Class