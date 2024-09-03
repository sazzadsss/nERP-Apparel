Imports System.Data.SqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports System.Net
Imports System.Net.Mail
Imports System.Collections
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Globalization
Public Class frmOrderReceived
    Dim IsFirstLoad As Boolean = True
    Dim IsInputComplete As Boolean = False
    Dim DeleteFlag As Boolean = False
    Dim CopyODI As Integer 'ODI=Order Details Id
    Dim oldRow As OrderDataSet.OrderDetailsRow
    Dim MOID As String
    Dim AddFlag As Boolean = False
    Private _ByUserFlag As Boolean
    Public Property ByUserFlag() As Boolean
        Get
            Return _ByUserFlag
        End Get
        Set(ByVal value As Boolean)
            _ByUserFlag = value
        End Set
    End Property

    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private _MPrgNo As String
    Public Property MPrgNo() As String
        Get
            Return _MPrgNo
        End Get
        Set(ByVal value As String)
            _MPrgNo = value
        End Set
    End Property
    Dim showflag As Boolean
    Private Sub frmOrderReceived_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose(True)
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub
    Private Sub frmOrderReceived_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyData = Keys.F11 Then

            If Me.StyleIdGridLookUpEdit.IsEditorActive Then


                frmStyle.ShowDialog()

                If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
                    Me.StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId

                    Me.BuyerIdGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                    Me.DivisionIdGridLookUpEdit.EditValue = ReadIntegerData("Select DivisionId From Style Where StyleId=" & frmStyle.StyleId, cnn)

                End If


                'ElseIf BuyerIdGridLookUpEdit.IsEditorActive Then

                '    frmBuyer.ShowDialog()

                '    If frmBuyer.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
                '        Me.BuyerIdGridLookUpEdit.EditValue = frmBuyer.BuyerId

                '    End If


                'ElseIf GarmentIdGridLookUpEdit.IsEditorActive Then

                '    frmGarments.ShowDialog()

                '    If frmGarments.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '        Me.GarmentTableAdapter.Fill(Me.GarmentDataSet.Garment)
                '        Me.GarmentIdGridLookUpEdit.EditValue = frmGarments.GarmentId

                '    End If

                'ElseIf DivisionIdGridLookUpEdit.IsEditorActive Then

                '    frmDivision.ShowDialog()

                '    If frmDivision.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
                '        Me.DivisionIdGridLookUpEdit.EditValue = frmDivision.DivisionId

                '    End If

                'ElseIf SeasonIdGridLookUpEdit.IsEditorActive Then

                '    frmSeason.ShowDialog()

                '    If frmSeason.DialogResult = System.Windows.Forms.DialogResult.OK Then

                '        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
                '        Me.SeasonIdGridLookUpEdit.EditValue = frmSeason.SeasonId

                '    End If

            ElseIf OrderDetailsGridControl.IsFocused Then


                If OrderDetailsGridView.FocusedColumn.AbsoluteIndex = colFabricColorId.AbsoluteIndex Then

                    frmFabricColor.ShowDialog()


                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

                        Dim row As OrderDataSet.OrderDetailsRow
                        row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                        row.FabricColorId = frmFabricColor.FabricColorId

                    End If

                ElseIf OrderDetailsGridView.FocusedColumn.AbsoluteIndex = colDestinationId.AbsoluteIndex Then

                    frmDestination.ShowDialog()

                    If frmDestination.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)

                        Dim row As OrderDataSet.OrderDetailsRow
                        row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                        row.DestinationId = frmDestination.DestinationId


                    End If

                ElseIf OrderDetailsGridView.FocusedColumn.AbsoluteIndex = colStyleId.AbsoluteIndex Then


                    Dim row As OrderDataSet.OrderDetailsRow
                    row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                    frmStyle.StyleId = row.StyleId

                    frmStyle.ShowDialog()

                    If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)



                        row.StyleId = frmStyle.StyleId

                    End If


                End If

            End If

        End If

        If e.KeyData = Keys.F3 Then


            If OrderDetailsGridControl.IsFocused() Then

                '---Copy current row

                If IsInputCompleteCheckEdit.Checked = False Then

                    'Save()

                    Dim row As OrderDataSet.OrderDetailsRow
                    row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                    Using Connection As New SqlConnection(cnn)

                        Connection.Open()

                        Dim cmd As SqlCommand = New SqlCommand("CopyOrderDetails", Connection)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@OrderDetailsId", row.OrderDetailsId)
                        cmd.ExecuteNonQuery()

                    End Using
					

                    Me.OrderDetailsTableAdapter.Fill(Me.OrderDataSet.OrderDetails, OrderLookupGridLookUpEdit.EditValue)
                    Me.OrderSizeDetailsTableAdapter.Fill(Me.OrderDataSet.OrderSizeDetails, OrderLookupGridLookUpEdit.EditValue)

                End If

            End If

        End If
    End Sub


    Private Sub frmOrderReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdvProgramLookupDataSet.AdvProgramLookup' table. You can move, or remove it, as needed.
        Me.AdvProgramLookupTableAdapter.Fill(Me.AdvProgramLookupDataSet.AdvProgramLookup)

        Me.SusStandardMstTableAdapter.Fill(Me.SusStandardDataSet.SusStandardMst)
        Me.FabricMaterialTypeTableAdapter.Fill(Me.FabricMaterialTypeDataSet.FabricMaterialType)
        Me.FabricFinishingTypeTableAdapter.Fill(Me.FabricFinishingTypeDataSet.FabricFinishingType)

        With YarnDyeingTypeGridLookUpEdit

            .ForceInitialize() ' Force it to initialize
            .DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "YarnDyeingTypeId", True))
            .Properties.DataSource = GetYarnDyingType()
            .Properties.DisplayMember = "YarnDyeingType"
            .Properties.ValueMember = "YarnDyeingTypeId"
            .Properties.PopulateViewColumns() ' Force the lookupedit to populate
            .Properties.View.Columns("YarnDyeingTypeId").Visible = False

        End With


        FillMaster()

        Me.OrderDataSet.Order.IsRunningColumn.DefaultValue = True
        Me.OrderDataSet.Order.CompanyIdColumn.DefaultValue = 1
        Me.OrderDataSet.Order.IsCompleteColumn.DefaultValue = 0

        Me.OrderDataSet.Order.DollarValueColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterName='Dollar'", cnn)





        If ByUserFlag = True Then

            If CheckUserRights("Buyer Order [Merchandiserwise]").CanEdit = False Then

                NewButton.Enabled = False
                DeleteButton.Enabled = False
                EditButton.Enabled = False
                CancelEntryButton.Enabled = False

            ElseIf CheckUserRights("Buyer Order [Merchandiserwise]").CanDelete = False Then

                NewButton.Enabled = True
                DeleteButton.Enabled = False
                EditButton.Enabled = True
                CancelEntryButton.Enabled = True

            End If

        Else

            If CheckUserRights("Buyer Order").CanEdit = False Then

                NewButton.Enabled = False
                DeleteButton.Enabled = False
                EditButton.Enabled = False
                CancelEntryButton.Enabled = False

            ElseIf CheckUserRights("Buyer Order").CanDelete = False Then

                NewButton.Enabled = True
                DeleteButton.Enabled = False
                EditButton.Enabled = True
                CancelEntryButton.Enabled = True

            End If

        End If

    End Sub

    Private Sub FillMaster()

        If Me.ByUserFlag = False Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        Else
            Me.OrderLookupTableAdapter.FillByParticularUser(Me.OrderLookupDataSet.OrderLookup, UserId)
            Me.StyleLookupTableAdapter.FillByUserId(Me.StyleLookupDataSet.StyleLookup, UserId)
            Me.OrderDataSet.Order.UserIdColumn.DefaultValue = UserId
        End If


        Me.ActivitiesGroupTableAdapter.Fill(Me.ActivitiesGroupDataSet.ActivitiesGroup)
        Me.ActivitiesListTableAdapter.Fill(Me.ActivitiesListDataSet.ActivitiesList)
        Me.FRProcessTableAdapter.Fill(Me.FRProcessDataSet.FRProcess)
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.GarmentTableAdapter.Fill(Me.GarmentDataSet.Garment)
        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.Fill(Me.KnittingTypeDataSet.KnittingType)
        Me.DyeingTypeTableAdapter.Fill(Me.DyeingTypeDataSet.DyeingType)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)



    End Sub

    Private Sub Save()

        Try
            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.OrderDetailsBindingSource.EndEdit()
            Me.OrderSizeDetailsBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OrderDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If OrderLookupGridLookUpEdit.EditValue > 0 Then
            showflag = True
            ShowOrder(OrderLookupGridLookUpEdit.EditValue)
            showflag = False
        Else
            MessageBox.Show("Opps...")
        End If


    End Sub
    Private Sub ShowOrder(ByVal OID As Integer)

        Try

            Me.OrderTableAdapter.FillByOrderId(Me.OrderDataSet.Order, OID)
            Me.OrderDetailsTableAdapter.Fill(Me.OrderDataSet.OrderDetails, OID)
            Me.FabricTableAdapter.Fill(Me.OrderDataSet.Fabric, OID)
            Me.OrderActivitiesTableAdapter.Fill(Me.OrderDataSet.OrderActivities, OID)
            Me.OrderActivitiesPredecessorTableAdapter.Fill(Me.OrderDataSet.OrderActivitiesPredecessor, OID)
            Me.OrderInstructionTableAdapter.Fill(Me.OrderDataSet.OrderInstruction, OID)
            Me.OrderSizeDetailsTableAdapter.Fill(Me.OrderDataSet.OrderSizeDetails, OID)
            Me.OrderCuttingPercentageTableAdapter.Fill(Me.OrderDataSet.OrderCuttingPercentage, OID)
            Me.FROrderProcessTableAdapter.Fill(Me.OrderDataSet.FROrderProcess)
            Me.OrderAmndDetailsTableAdapter.Fill(Me.OrderDataSet.OrderAmndDetails)
            Me.OrderPictureTableAdapter.Fill(Me.OrderDataSet.OrderPicture, OID)
            Me.TwinPackDetailsTableAdapter.Fill(Me.OrderDataSet.TwinPackDetails)
            Me.PreCostingNoLookupTableAdapter.FillBySID(Me.PreCostingNoLookupDataSet.PreCostingNoLookup, StyleIdGridLookUpEdit.EditValue)


            CalculateAWorkingDay()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub CalculateAWorkingDay()
        If Me.OrderActivitiesBindingSource.Position > -1 Then
            'Dim IsManual As Boolean = ReadBooleanData("Select IsManual From ActivitiesGroup Where ActivitiesGroupId=" & Me.ActivitiesGroupIdGridLookUpEdit.EditValue, cnn)
            Dim MinES As DateTime = ReadDateData("Select Min(ES) From OrderActivities Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Dim MaxEF As DateTime = ReadDateData("Select Max(EF) From OrderActivities Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            Dim HLDDay = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & MinES & "' And '" & MaxEF & "'", cnn)
            TTLDayLabel2.Text = ReadIntData("Select DATEDIFF(day,Min(ES),Max(EF)) From OrderActivities Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            TTLOffDayLabel2.Text = HLDDay
            TTLWDayLabel2.Text = Val(TTLDayLabel2.Text) - HLDDay
        End If
    End Sub
    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If EditButton.Text = "&Edit" Then
            Me.OrderBindingSource.AddNew()
            Me.MasterProgramNoTextBox.Focus()
            Me.NewButton.Enabled = False
            Me.EditButton.Text = "&Update"
            Me.UserIdGridLookUpEdit.EditValue = UserId
            AddFlag = True


        Else
            MessageBox.Show("You have to update first.")
        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If Me.ApprovedSampleNoTextBox.Text = String.Empty AndAlso DeleteFlag = False Then

            MessageBox.Show("Please,mention the Approved Sample Program No", "Message")
            Me.ApprovedSampleNoTextBox.Focus()
            Exit Sub

        End If

        If Me.EditButton.Text = "&Update" Then


            If AddFlag = True Then

                Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

                'If CC <> "NCL" Then
                If ProgramNoTextEdit.Text = String.Empty Then

                    'If MasterProgramNoTextBox.Text = String.Empty Then

                    Dim ABC As String = Now.Year.ToString.Substring(2) & CC.ToString()
                    Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [Order] Where ProgramNo Like '%" & ABC & "%'", cnn)
                    Dim XYZ1 As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [MasterOrderDetails] Where ProgramNo Like '%" & ABC & "%'", cnn)

                    If (XYZ > XYZ1) Then
                        Dim NewOrder As String = Now.Year.ToString.Substring(2) & CC.ToString() & (Val(XYZ) + 1).ToString()
                        ProgramNoTextEdit.Text = NewOrder
                    Else
                        Dim NewOrder As String = Now.Year.ToString.Substring(2) & CC.ToString() & (Val(XYZ1) + 1).ToString()
                        ProgramNoTextEdit.Text = NewOrder
                    End If

                    'End If

                End If

                Save()

                Dim row As OrderDataSet.OrderRow
                row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

                Me.OrderLookupTableAdapter.Fill(OrderLookupDataSet.OrderLookup)
                OrderLookupGridLookUpEdit.EditValue = row.OrderId
                ShowOrder(row.OrderId)

                AddFlag = False

            End If


            Save()



            If Me.OrderDetailsBindingSource.Position > -1 Then

                Dim row As OrderDataSet.OrderRow
                row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

                'Selecting Activities Group
                Dim MinEx As Date = ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & row.OrderId, cnn)
                TTLDayLabel.Text = DateDiff(DateInterval.Day, OrderReceiveDateDateEdit.DateTime.Date, MinEx)
                Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & OrderReceiveDateDateEdit.DateTime.Date & "' And '" & MinEx & "'", cnn)
                'Dim WKDay As Integer = ReadIntData("select datediff(day, -2, '" & drv!EX & "')/7  - datediff(day, -3, '" & OrderReceiveDateDateEdit.DateTime.Date & "')/7", cnn)
                TTLOffDayLabel.Text = HLDDay
                WDLabel.Text = Val(TTLDayLabel.Text) - HLDDay


                For Each drv As DataRowView In Me.OrderDetailsBindingSource.List
                    On Error Resume Next

                    If DBNull.Value.Equals(drv!FirstEx) Then
                        drv!FirstEx = drv!Ex
                    End If

                Next

            End If

            Save()


            Me.EditButton.Text = "&Edit"
            Me.NewButton.Text = "&New"
            Me.NewButton.Enabled = True

            DeleteFlag = False

            If IsInputCompleteCheckEdit.Checked = True Then
                SendUserMail("Success", "Success", UserIdGridLookUpEdit.EditValue)
            End If

        Else

            Dim Inputflag As Boolean = False

            If IsDBNull(OrderLookupGridLookUpEdit.EditValue) = False Then

                Inputflag = ReadBooleanData("Select ISNULL(IsInputComplete,0) From [Order] Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)

            Else

                Inputflag = False

            End If


            If Inputflag = True Then

                MessageBox.Show("Not allowed ,need amendment.", "Message")
                Exit Sub

            End If

            Me.EditButton.Text = "&Update"

            Me.IsInputCompleteCheckEdit.Properties.ReadOnly = False
            Me.NewButton.Enabled = False

        End If

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If Me.OrderBindingSource.Position > -1 Then

            If Me.EditButton.Text = "&Edit" Then

                OrderBindingSource.RemoveCurrent()
                Me.EditButton.Text = "&Update"
                DeleteFlag = True

            End If

        End If

    End Sub

    Private Sub StyleIdLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles StyleIdLabel.LinkClicked

        If StyleIdGridLookUpEdit.EditValue > -1 Then
            frmStyle.StyleId = StyleIdGridLookUpEdit.EditValue
        End If

        frmStyle.ShowDialog()


        If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

            'On Error Resume Next

            Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
            Me.StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId





            Me.BuyerIdGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.GMTBrandIdGridLookUpEdit.EditValue = ReadIntData("Select GMTBrandId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.DivisionIdGridLookUpEdit.EditValue = ReadIntegerData("Select DivisionId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsAOPCheckEdit.Checked = ReadBooleanData("Select IsAOP From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsPrintCheckEdit.Checked = ReadBooleanData("Select IsPrint From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsEmbroideryCheckEdit1.Checked = ReadBooleanData("Select IsEmbroidery From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsYDSCheckBox.Checked = ReadBooleanData("Select IsYds From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.WashCheckEdit.Checked = ReadBooleanData("Select IsWash From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select WashTypeId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsBrushCheckEdit.Checked = ReadBooleanData("Select IsBrush From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.IsPeachFinishCheckEdit.Checked = ReadBooleanData("Select IsPeachFinish From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.GarmentDescriptionMemoEdit.Text = ReadStringData("Select GMDescription From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.PrintDetailsTextBox.Text = ReadStringData("Select PrintDetails From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.EmbroideryDetailsTextBox.Text = ReadStringData("Select EmbDetails From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.SeasonIdGridLookUpEdit.EditValue = ReadIntegerData("Select SeasonId From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.SpecialYarnCheckEdit.Checked = ReadBooleanData("Select IsSpecialYarn From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.SublimationCheckEdit.Checked = ReadBooleanData("Select IsSublimation From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.SequenceCheckEdit.Checked = ReadBooleanData("Select IsSequence From Style Where StyleId=" & frmStyle.StyleId, cnn)
            Me.YarnDyeingTypeGridLookUpEdit.EditValue = ReadIntData("Select YarnDyeingTypeId From Style Where StyleId=" & frmStyle.StyleId, cnn)


        End If

    End Sub

    Private Sub BuyerIdLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        frmBuyer.ShowDialog()

        If frmBuyer.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
            Me.BuyerIdGridLookUpEdit.EditValue = frmBuyer.BuyerId
        End If

    End Sub

    Private Sub DivisionIdLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        frmDivision.ShowDialog()

        If frmDivision.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
            Me.DivisionIdGridLookUpEdit.EditValue = frmDivision.DivisionId
        End If

    End Sub

    Private Sub GarmentIdLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GarmentIdLabel.LinkClicked

        frmGarments.ShowDialog()

        If frmGarments.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.GarmentTableAdapter.Fill(Me.GarmentDataSet.Garment)
            Me.GarmentIdGridLookUpEdit.EditValue = frmGarments.GarmentId

        End If

    End Sub

    Private Sub SeasonIdLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        frmSeason.ShowDialog()

        If frmSeason.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
            Me.SeasonIdGridLookUpEdit.EditValue = frmSeason.SeasonId
        End If

    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        Save()

        Try
            'Need to remember Copied Order Details Id

            If OrderDetailsBindingSource.Position > -1 Then

                Dim row As OrderDataSet.OrderDetailsRow
                row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)


                CopyODI = row.OrderDetailsId

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click

        'If there is no data in po grid then the procedure will exit.
        If OrderDetailsBindingSource.Position = -1 Then

            Exit Sub

        End If

        If OrderSizeDetailsBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyODI
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select SizeId,OrderQuantity,Ratio,SKUNo From OrderSizeDetails Where OrderDetailsId=" & CopyODI, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()
                'Insert Reading data From OrderSizeDetails  by CopyODI

                Dim newRow As OrderDataSet.OrderSizeDetailsRow = Me.OrderDataSet.OrderSizeDetails.NewRow()

                'Start Reading Selected OrderDetailsId
                Dim PasteODI As Integer

                Dim row As OrderDataSet.OrderDetailsRow
                row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                PasteODI = row.OrderDetailsId


                'End Reading Selected OrderDetailsId


                newRow.OrderDetailsId = PasteODI
                newRow.SizeId = reader("SizeId").ToString
                newRow.OrderQuantity = reader("OrderQuantity").ToString
                newRow.Ratio = reader("Ratio").ToString

                If reader("SKUNo").ToString <> String.Empty Then
                    newRow.SKUNo = reader("SKUNo").ToString
                End If



                Me.OrderDataSet.OrderSizeDetails.Rows.Add(newRow)


            End While

            reader.Close()
            connection.Close()
        End If

    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        FillMaster()
    End Sub

    Private Sub OrderDetailsBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles OrderDetailsBindingSource.AddingNew
        Me.OrderDataSet.OrderDetails.Columns("StyleId").DefaultValue = StyleIdGridLookUpEdit.EditValue
    End Sub


    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.OrderLookupByStyleTableAdapter.FillByStyleId(Me.OrderLookupDataSet.OrderLookupByStyle, Me.StyleIdGridLookUpEdit.EditValue)
        Me.IsPrintCheckEdit.EditValue = ReadBooleanData("Select IsPrint From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)

        Me.BuyerIdGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)
        Me.DivisionIdGridLookUpEdit.EditValue = ReadIntegerData("Select DivisionId From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)
        Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, StyleIdGridLookUpEdit.EditValue)

    End Sub

    Private Sub CalculateRatioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateRatioButton.Click
        If Me.OrderDetailsBindingSource.Position > -1 Then
            Dim row As OrderDataSet.OrderDetailsRow
            row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)
            Dim TTLRatio As Integer = 0

            If OrderSizeDetailsBindingSource.Position > -1 Then

                For Each drv As DataRowView In Me.OrderSizeDetailsBindingSource.List
                    TTLRatio = TTLRatio + drv!Ratio
                Next

                For Each drv2 As DataRowView In Me.OrderSizeDetailsBindingSource.List
                    drv2!OrderQuantity = row.OrderQuantity / TTLRatio * drv2!Ratio
                Next

            End If


        End If
    End Sub




    Private Sub OrderSizeList()

        'If there is no data in po grid then the procedure will exit.
        If OrderDetailsBindingSource.Position = -1 Then

            Exit Sub

        End If

        If OrderSizeDetailsBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyODI
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select Distinct SizeId From OrderSizeDetails Where OrderDetailsId in (Select OrderDetailsId From OrderDetails Where OrderId=" & ListBox1.SelectedValue & ")", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()
                'Insert Reading data From OrderSizeDetails  by CopyODI

                Dim newRow As OrderDataSet.OrderSizeDetailsRow = Me.OrderDataSet.OrderSizeDetails.NewRow()

                'Start Reading Selected OrderDetailsId
                Dim PasteODI As Integer

                Dim row As OrderDataSet.OrderDetailsRow
                row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                PasteODI = row.OrderDetailsId


                'End Reading Selected OrderDetailsId


                newRow.OrderDetailsId = PasteODI
                newRow.SizeId = reader("SizeId").ToString
                newRow.OrderQuantity = 0
                newRow.Ratio = 0


                Me.OrderDataSet.OrderSizeDetails.Rows.Add(newRow)


            End While

            reader.Close()
            connection.Close()
        End If
    End Sub


    Private Sub Paste2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste2Button.Click
        OrderSizeList()
    End Sub

    Private Sub AmndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmndButton.Click

        If Me.OrderBindingSource.Position > -1 Then

            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            If row.IsComplete = True Then
                MessageBox.Show("Not Done, Already Program Full And Final.")
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to AMENDMENT this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Dim AmndDetails As String = InputBox("Enter Amendment Details.", "Amendment Details", "")

                If AmndDetails = String.Empty Then
                    MessageBox.Show("Not Allowed without Amendment Details", "Message")
                    Exit Sub
                End If

                If AmendmentNoSpinEdit.Value > 0 Then

                    Dim newRow As OrderDataSet.OrderAmndDetailsRow = Me.OrderDataSet.OrderAmndDetails.NewRow()

                    newRow.OrderId = row.OrderId
                    newRow.AmndNo = AmendmentNoSpinEdit.Value
                    newRow.AmndDate = AmendmentDateDateEdit.DateTime.Date
                    newRow.Details = CauseofAmendmentMemoEdit.Text


                    Me.OrderDataSet.OrderAmndDetails.Rows.Add(newRow)


                    row.AmendmentNo = ReadIntegerData("Select Max(AmendmentNo)+1 From [Order] Where Orderid=" & row.OrderId, cnn)
                    row.AmendmentDate = Now()
                    row.IsInputComplete = False
                    row.CauseofAmendment = AmndDetails

                    Save()

                Else

                    row.AmendmentNo = ReadIntegerData("Select Max(AmendmentNo)+1 From [Order] Where Orderid=" & row.OrderId, cnn)
                    row.AmendmentDate = Now()
                    row.IsInputComplete = False
                    row.CauseofAmendment = AmndDetails
                    Save()

                End If

            End If

        End If

    End Sub


    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        frmOrderExportToFR.ShowDialog()
    End Sub

    Private Sub GetProcess(ByVal SId As Integer)

        Using connection As New SqlConnection(cnn)
            Dim command As New SqlCommand("Select FRProcessId From FRStyleProcess Where StyleId=" & Me.StyleIdGridLookUpEdit.EditValue, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)


            While reader.Read()

                Dim newRow As OrderDataSet.FROrderProcessRow = Me.OrderDataSet.FROrderProcess.NewRow()
                newRow.OrderId = row.OrderId
                newRow.FRProcessId = reader("FRProcessId")
                newRow.Factor = 0
                newRow.SMV = 0
                Me.OrderDataSet.FROrderProcess.Rows.Add(newRow)

            End While

            reader.Close()

        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GetProcess(StyleIdGridLookUpEdit.EditValue)
    End Sub

    'Private Sub GenerateActivitiesLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GenerateActivitiesLinkLabel.LinkClicked

    '    If Me.OrderActivitiesBindingSource.Position > -1 Then
    '        Save()
    '        CalculateEarly()
    '        CalculateLatest()
    '        Save()
    '        Exit Sub
    '    End If

    '    Dim row1 As OrderDataSet.OrderDetailsRow
    '    row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

    '    Using connection As New SqlConnection(cnn)

    '        Dim command As New SqlCommand("Select SL,ActivitiesListId,Duration,ES,EF,LS,LF,Slack,AAsign_UserId From ActivitiesTemplate Where ActivitiesGroupId=" & row1.ActivitiesGroupId & "ORDER BY SL ASC", connection)
    '        Command.Connection.Open()
    '        Command.ExecuteNonQuery()

    '        Dim reader As SqlDataReader = Command.ExecuteReader()

    '        While reader.Read()

    '            Dim newRow As OrderDataSet.OrderActivitiesRow = Me.OrderDataSet.OrderActivities.NewRow()
    '            newRow.OrderDetailsId = row1.OrderDetailsId
    '            newRow.SL = reader("SL")
    '            newRow.ActivitiesListId = reader("ActivitiesListId")
    '            newRow.Duration = reader("Duration")
    '            Dim ESDate As DateTime = DateAdd(DateInterval.Day, reader("ES"), OrderReceiveDateDateEdit.DateTime.Date)
    '            Dim LFDate As DateTime = DateAdd(DateInterval.Day, reader("LF"), OrderReceiveDateDateEdit.DateTime.Date)
    '            Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & LFDate & "'", cnn)
    '            Dim WKDay As Integer = ReadIntData("select datediff(day, -2, '" & LFDate & "')/7  - datediff(day, -3, '" & ESDate & "')/7", cnn)
    '            newRow.OffDay = HLDDay + WKDay
    '            newRow.ES = OrderReceiveDateDateEdit.DateTime.Date
    '            newRow.EF = OrderReceiveDateDateEdit.DateTime.Date
    '            newRow.LS = OrderReceiveDateDateEdit.DateTime.Date
    '            newRow.LF = OrderReceiveDateDateEdit.DateTime.Date
    '            newRow.Slack = reader("Slack")
    '            newRow.TaskComplete = 0
    '            newRow.AAsign_UserId = reader("AAsign_UserId")
    '            Me.OrderDataSet.OrderActivities.Rows.Add(newRow)

    '        End While

    '        reader.Close()

    '    End Using
    '    Save()

    '    For Each drv As DataRowView In Me.OrderActivitiesBindingSource.List

    '        Dim ATID As Integer = ReadIntegerData("Select ActivitiesTemplateId From ActivitiesTemplate Where ActivitiesGroupId=" & row1.ActivitiesGroupId & "And ActivitiesListId=" & drv!ActivitiesListId, cnn)

    '        Using connection As New SqlConnection(cnn)

    '            Dim command As New SqlCommand("Select ActivitiesListId From ActivitiesTemplate Where ActivitiesTemplateId in (Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & ATID & ")", connection)
    '            Command.Connection.Open()
    '            Command.ExecuteNonQuery()

    '            Dim reader As SqlDataReader = Command.ExecuteReader()

    '            While reader.Read()

    '                Dim newRow As OrderDataSet.OrderActivitiesPredecessorRow = Me.OrderDataSet.OrderActivitiesPredecessor.NewRow()

    '                newRow.OrderActivitiesId = drv!OrderActivitiesId
    '                newRow.ActivitiesListId = reader("ActivitiesListId")
    '                newRow.PreOrderActivitiesId = ReadIntegerData("Select OrderActivitiesId From OrderActivities Where ActivitiesListId = " & reader("ActivitiesListId") & " And OrderDetailsId=" & row1.OrderDetailsId, cnn)

    '                Me.OrderDataSet.OrderActivitiesPredecessor.Rows.Add(newRow)

    '            End While

    '            reader.Close()

    '        End Using

    '    Next



    'End Sub

    Private Sub CalculateDayLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)




    End Sub
    Private Sub CalculateEarly()
        'On Error Resume Next

        Dim row As OrderDataSet.OrderRow
        row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

        Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
        Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

        For Each drv As DataRowView In Me.OrderActivitiesBindingSource.List



            If drv!ActivitiesListId = Start_AID Then
                'MessageBox.Show(row.OrderReceiveDate)
                drv!ES = row.OrderReceiveDate
                drv!EF = row.OrderReceiveDate
                drv!LS = row.OrderReceiveDate
                drv!LF = row.OrderReceiveDate
                drv!StartDate = row.OrderReceiveDate
                drv!EndDate = row.OrderReceiveDate
                drv!TaskComplete = 1
                'drv!OrderQuantity = ReadData("Select Sum(OrderQuantity) From OrderDetails Where OrderId=" & drv!OrderId, cnn)
                'To Refresh
                OrderActivitiesBindingSource.MoveNext()
                OrderActivitiesBindingSource.MovePrevious()

            ElseIf drv!ActivitiesListId = End_AID Then

                Dim MaxEF As Date = ReadDateData("Select Max(EF) From OrderActivities Where OrderId=" & drv!OrderId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)
                Dim MinEX As Date = ReadDateData("Select Min(Ex) From [OrderDetails] Where OrderId=" & drv!OrderId, cnn)
                Dim ESDate As DateTime = DateAdd(DateInterval.Day, 1, MaxEF)
                Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & MinEX & "'", cnn)

                drv!ES = DateAdd(DateInterval.Day, 1, MaxEF)
                drv!EF = drv!ES
                drv!LS = drv!ES
                drv!LF = drv!ES
                drv!OffDay = HLDDay



            Else


                'Dim LeftDay As Integer = ReadIntData("Select LeftDay From ActivitiesTemplate Where ActivitiesGroupId=" & ActivitiesGroupIdGridLookUpEdit.EditValue & " And OrderActivitiesId=" & drv!OrderActivitiesId, cnn)

                If drv!LeftDay = 0 Then

                    Dim MaxEF As Date = ReadDateData("Select Max(EF) From OrderActivities Where OrderId=" & drv!OrderId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)
                    drv!ES = DateAdd(DateInterval.Day, 1, MaxEF)
                    Dim TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)

                    Dim ESDate As DateTime = drv!ES
                    Dim EFDate As DateTime = drv!EF
                    Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

                    drv!OffDay = HLDDay
                    TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)

                    ESDate = drv!ES
                    EFDate = drv!EF
                    HLDDay = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

                    drv!OffDay = HLDDay
                    TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)


                ElseIf drv!LeftDay > 0 Then

                    'Dim MaxES As Decimal = ReadData("Select Max(ES) From ActivitiesTemplate Where ActivitiesGroupId=" & ActivitiesGroupIdGridLookUpEdit.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)

                    'drv!ES = MaxES + LeftDay
                    'drv!EF = drv!ES + drv!Duration - 1


                    Dim MaxES As Date = ReadDateData("Select Max(ES) From OrderActivities Where OrderId=" & drv!OrderId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)
                    drv!ES = DateAdd(DateInterval.Day, drv!LeftDay, MaxES)
                    Dim TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)

                    Dim ESDate As DateTime = drv!ES
                    Dim EFDate As DateTime = drv!EF
                    Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

                    drv!OffDay = HLDDay
                    TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)

                    ESDate = drv!ES
                    EFDate = drv!EF
                    HLDDay = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

                    drv!OffDay = HLDDay
                    TTLDuration = drv!Duration + drv!OffDay - 1
                    drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)


                End If
















                'Dim LDay As Integer = ReadIntData("Select LeftDay From OrderActivities Where OrderId=" & drv!OrderId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)

                'MessageBox.Show("Hello")

                'If MaxEF = 0 Then
                '    drv!ES = MaxEF
                '    drv!EF = drv!ES + drv!Duration
                'Else


                'Calculating Holiday




                'End If

            End If
            Save()
        Next









    End Sub

    Private Sub CalculateLatest()
        'On Error Resume Next
        Dim i As Integer = Me.OrderActivitiesBindingSource.Count
        Dim BDay As Integer = 0
        Do While i <= Me.OrderActivitiesBindingSource.Count And i >= 0

            Me.OrderActivitiesBindingSource.Position = i

            i = i - 1

            Dim row As OrderDataSet.OrderActivitiesRow
            row = CType(CType(Me.OrderActivitiesBindingSource.Current, DataRowView).Row, OrderDataSet.OrderActivitiesRow)

            Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            If row.ActivitiesListId = End_AID Then

                row.LS = row.ES
                row.LF = row.EF
                row.BDay = 0
                'BDay = 0

            ElseIf row.ActivitiesListId = Start_AID Then

                row.LS = row.ES
                row.LF = row.EF

            Else

                Dim MinLF As Date = ReadDateData("Select Min(LS) From OrderActivities Where OrderId=" & row.OrderId & " AND OrderActivitiesId in ( Select OrderActivitiesId From OrderActivitiesPredecessor Where ActivitiesListId =" & row.ActivitiesListId & ")", cnn)
                'MessageBox.Show("Hello")
                On Error Resume Next

                row.LF = DateAdd(DateInterval.Day, -1, MinLF) 'MinLF - 1 
                Dim TTLDuration = row.Duration + row.OffDay - 1
                row.LS = DateAdd(DateInterval.Day, -TTLDuration, row.LF)  'row.LF - row.Duration + 1
                'row.Slack = DateDiff(DateInterval.Day, row.EF, row.LF) 'row.LF - row.EF
                'row.BDay = BDay - row.EF

            End If
            Save()

        Loop
        TTLWDayLabel2.Text = ReadData("Select Sum(Duration) From OrderActivities Where Slack=0 And OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
        'MessageBox.Show("Activities Generated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Private Sub RecalculateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RecalculateLinkLabel.LinkClicked

    '    Dim row As OrderDataSet.OrderRow
    '    row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

    '    If row.IsOrderReceiveDateNull = True Then
    '        Exit Sub
    '    End If


    '    CalculateEarly()
    '    CalculateLatest()
    'End Sub

    Private Sub GenerateActivities(ByVal AGID As Integer)

        Dim ShortDayBal As Integer = 0
        Dim LeadTime As Integer = ReadIntData("Select LeadTime From ActivitiesGroup Where ActivitiesGroupId=" & Me.ActivitiesGroupIdGridLookUpEdit.EditValue, cnn)
        Dim IsManual As Boolean = ReadBooleanData("Select IsManual From ActivitiesGroup Where ActivitiesGroupId=" & Me.ActivitiesGroupIdGridLookUpEdit.EditValue, cnn)
        'Dim SlackTask As Integer = ReadIntData("Select Count(*) From ActivitiesTemplate Where Slack=0 And ActivitiesGroupId=" & Me.ActivitiesGroupIdGridLookUpEdit.EditValue, cnn)
        Dim ShortDay As Integer = LeadTime - Val(WDLabel.Text)
        ShortDayBal = ShortDay

        If Me.OrderActivitiesBindingSource.Position > -1 Then
            Save()
            CalculateEarly()
            CalculateLatest()
            Save()
            CalculateAWorkingDay()
            AddToPlanning()
            Exit Sub
        End If

        Dim row1 As OrderDataSet.OrderDetailsRow
        row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

        Using connection As New SqlConnection(cnn)

            Dim command As New SqlCommand("Select SL,ActivitiesListId,Duration,ES,EF,LS,LF,Slack,AAsign_UserId,BDay,ISNULL(LeftDay,0) AS LeftDay From ActivitiesTemplate Where ActivitiesGroupId=" & AGID & "ORDER BY SL ASC", connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As OrderDataSet.OrderActivitiesRow = Me.OrderDataSet.OrderActivities.NewRow()
                newRow.OrderId = row1.OrderId
                'newRow.OrderDetailsId = row1.OrderDetailsId
                newRow.SL = reader("SL")
                newRow.ActivitiesListId = reader("ActivitiesListId")

                '======================================================================================
                'If ShortDayBal > 0 AndAlso reader("Slack") = 0 And reader("Duration") >= 2 Then
                '    newRow.Duration = reader("Duration") - 1
                '    newRow.TaskComments = "-1"
                '    ShortDayBal = ShortDayBal - 1
                'ElseIf ShortDayBal < 0 AndAlso reader("Slack") = 0 AndAlso reader("Duration") >= 2 Then

                '    If reader("ActivitiesListId") = 22 Then
                '        newRow.Duration = reader("Duration") - ShortDayBal
                '        newRow.TaskComments = (-ShortDayBal).ToString
                '        ShortDayBal = 0
                '    Else
                '        newRow.Duration = reader("Duration") + 1
                '        newRow.TaskComments = "1"
                '        ShortDayBal = ShortDayBal + 1
                '    End If
                '=======================================================================================

                'Else
                newRow.Duration = reader("Duration")
                'End If


                'Calculating Holiday
                'Dim ESDate As DateTime = DateAdd(DateInterval.Day, reader("ES"), OrderReceiveDateDateEdit.DateTime.Date)
                'Dim EFDate As DateTime = DateAdd(DateInterval.Day, reader("EF"), OrderReceiveDateDateEdit.DateTime.Date)
                'Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) As TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

                'Dim ESDate1 As DateTime = DateAdd(DateInterval.Day, HLDDay, EFDate)
                'Dim EFDate1 As DateTime = DateAdd(DateInterval.Day, HLDDay, EFDate)
                'Dim HLDDay1 As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate1 & "' And '" & EFDate1 & "'", cnn)

                newRow.OffDay = 0 'HLDDay '+ HLDDay1
                newRow.ES = OrderReceiveDateDateEdit.DateTime.Date
                newRow.EF = OrderReceiveDateDateEdit.DateTime.Date
                newRow.LS = OrderReceiveDateDateEdit.DateTime.Date
                newRow.LF = OrderReceiveDateDateEdit.DateTime.Date
                'newRow.BDay = reader("BDay")
                newRow.Slack = reader("Slack")
                newRow.Leftday = reader("LeftDay")

                newRow.TaskComplete = 0
                newRow.AAsign_UserId = reader("AAsign_UserId")
                Me.OrderDataSet.OrderActivities.Rows.Add(newRow)
                Save()
            End While

            reader.Close()

        End Using


        Save()


        For Each drv As DataRowView In Me.OrderActivitiesBindingSource.List

            Dim ATID As Integer = ReadIntegerData("Select ActivitiesTemplateId From ActivitiesTemplate Where ActivitiesGroupId=" & ActivitiesGroupIdGridLookUpEdit.EditValue & "And ActivitiesListId=" & drv!ActivitiesListId, cnn)

            Using connection As New SqlConnection(cnn)

                Dim command As New SqlCommand("Select ActivitiesListId From ActivitiesTemplate Where ActivitiesTemplateId in (Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & ATID & ")", connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    Dim newRow As OrderDataSet.OrderActivitiesPredecessorRow = Me.OrderDataSet.OrderActivitiesPredecessor.NewRow()

                    newRow.OrderActivitiesId = drv!OrderActivitiesId
                    newRow.ActivitiesListId = reader("ActivitiesListId")
                    newRow.PreOrderActivitiesId = ReadIntegerData("Select OrderActivitiesId From OrderActivities Where ActivitiesListId = " & reader("ActivitiesListId") & " And OrderId=" & row1.OrderId, cnn)

                    Me.OrderDataSet.OrderActivitiesPredecessor.Rows.Add(newRow)

                End While

                reader.Close()

            End Using

        Next

        Save()
        CalculateEarly()
        CalculateLatest()
        CalculateAWorkingDay()

        Save()

        'TTLDayLabel2.Text = ReadData("Select Sum(Duration+OffDay) From OrderActivities Where Slack=0 And OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
        'TTLOffDayLabel2.Text = ReadIntData("Select Sum(OffDay) From OrderActivities Where Slack=0 And OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
        'TTLWDayLabel2.Text = ReadData("Select Sum(Duration) From OrderActivities Where Slack=0 And OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)

        AddToPlanning()



    End Sub



    Private Sub BuyerIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerIdGridLookUpEdit.EditValueChanged

        On Error Resume Next
        If BuyerIdGridLookUpEdit.EditValue > -1 Then
            Me.ActivitiesGroupTableAdapter.FillByBuyerId(Me.ActivitiesGroupDataSet.ActivitiesGroup, Me.BuyerIdGridLookUpEdit.EditValue)
        End If

    End Sub

    Private Sub WashCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashCheckEdit.CheckedChanged

        WashTypeIdGridLookUpEdit.Enabled = WashCheckEdit.Checked

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles OrderDetailsGridView.CellValueChanged

        If e.Column.Caption = "EX" Then
            Dim row As OrderDataSet.OrderDetailsRow
            row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)
            If row.IsFirstExNull = True Then
                row.FirstEx = row.EX
            End If
            row.ETA = DateAdd(DateInterval.Day, 30, row.EX)
        End If

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If OrderBindingSource.Position > -1 Then

            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            frmOrderPrint.OrderId = row.OrderId
            ShowForm(frmOrderPrint)

        End If



    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)



    End Sub

    Public Sub GetData(ByVal name As String)
        Me.ProgramNoTextEdit.Text = name
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click

        If AddFlag = True Then







            ShowMaster(frmMasterProgramLookUp)

            If frmMasterProgramLookUp.DialogResult = System.Windows.Forms.DialogResult.OK Then

                GetMasterOrder()
                Save()
                GetMasterOrderDetails()
                Save()
                GetSizeDetails()
                Save()
                ExecuteQuery("UPDATE MasterOrderDetails Set RecieveDate = GetDate(), IsReceivedBySupplier = 1 Where ProgramNo='" & ProgramNoTextEdit.Text & "'", cnn)

            End If

        Else

            MessageBox.Show("Please, Click on add button first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub GetMasterOrder()
        Dim connection As New SqlConnection(cnn)

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select *,ISNULL(IsYDS,0) As YDS From MasterOrder Where MasterOrderId =(select Max(MasterOrderId) from MasterOrderDetails where ProgramNo = '" & Me.PrgNo.ToString() & "')", connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()


        While reader.Read
            ' On Error Resume Next
            MasterProgramNoTextBox.Text = reader("MasterProgramNo")
            ProgramNoTextEdit.Text = Me.PrgNo
            IsAdvanceCheckEdit.Checked = ReadBooleanData("select IsAdvance From MasterOrderDetails Where  ProgramNo='" & Me.PrgNo & "'", cnn)
            StyleIdGridLookUpEdit.EditValue = reader("StyleId")
            BuyerIdGridLookUpEdit.EditValue = reader("BuyerId")
            GarmentDescriptionMemoEdit.EditValue = reader("GMDescription")
            OrderRemarksTextEdit.EditValue = reader("Remarks")
            IsPrintCheckEdit.EditValue = reader("IsPrint")
            IsEmbroideryCheckEdit1.EditValue = reader("IsEmbroidary")
            IsAOPCheckEdit.EditValue = reader("IsAOP")
            WashCheckEdit.EditValue = reader("IsWash")
            AmendmentNoSpinEdit.EditValue = 0
            IsYDSCheckBox.EditValue = reader("IsYDS")
            'BrandGridLookUpEdit.EditValue  = reader("Brand").ToString()
            GMTBrandIdGridLookUpEdit.EditValue = reader("GMTBrandId").ToString
            ApprovedSampleNoTextBox.Text = "-"

            IsPeachFinishCheckEdit.Checked = ReadBooleanData("Select IsPeachFinish from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            IsBrushCheckEdit.Checked = ReadBooleanData("Select IsBrush from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select WashTypeId from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            OrderReceiveDateDateEdit.EditValue = DateTime.Now.ToString("dd-MMM-yy")
            ApprovedSampleNoTextBox.Text = ReadStringData("Select Top (1) SampleRequestNo from MasterOrderSampleStatus Where Approved = 'Approved' AND MasterOrderId = " & reader("MasterOrderId"), cnn)

        End While

        reader.Close()
        connection.Close()
    End Sub


    Private Sub GetMasterOrder2()
        Dim connection As New SqlConnection(cnn)

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select *,ISNULL(IsYDS,0) As YDS From MasterOrder Where MasterProgramNo = '" & Me.MPrgNo.ToString() & "'", connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()


        While reader.Read

            ' On Error Resume Next
            MasterProgramNoTextBox.Text = Me.MPrgNo
            ProgramNoTextEdit.Text = String.Empty
            StyleIdGridLookUpEdit.EditValue = reader("StyleId")
            BuyerIdGridLookUpEdit.EditValue = reader("BuyerId")
            GarmentDescriptionMemoEdit.EditValue = reader("GMDescription")
            OrderRemarksTextEdit.EditValue = reader("Remarks")
            IsPrintCheckEdit.EditValue = reader("IsPrint")
            IsEmbroideryCheckEdit1.EditValue = reader("IsEmbroidary")
            IsAOPCheckEdit.EditValue = reader("IsAOP")
            WashCheckEdit.EditValue = reader("IsWash")
            AmendmentNoSpinEdit.EditValue = 0
            IsYDSCheckBox.EditValue = reader("IsYDS")
            'BrandGridLookUpEdit.EditValue  = reader("Brand").ToString()
            GMTBrandIdGridLookUpEdit.EditValue = reader("GMTBrandId").ToString
            ApprovedSampleNoTextBox.Text = "-"
            IsPeachFinishCheckEdit.Checked = ReadBooleanData("Select IsPeachFinish from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            IsBrushCheckEdit.Checked = ReadBooleanData("Select IsBrush from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select WashTypeId from Style where StyleId = " & reader("StyleId").ToString(), cnn)
            OrderReceiveDateDateEdit.EditValue = DateTime.Now.ToString("dd-MMM-yy")
            ApprovedSampleNoTextBox.Text = ReadStringData("Select Top (1) SampleRequestNo from MasterOrderSampleStatus Where Approved = 'Approved' AND MasterOrderId = " & reader("MasterOrderId"), cnn)

        End While

        reader.Close()
        connection.Close()
    End Sub



    Private Sub GetMasterOrderDetails()  'Read Data From MasterOrderDetails and Save in OrderDetails - 25.07.16 Feroz

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("Select * From MasterOrderDetails Where ProgramNo = '" & ProgramNoTextEdit.Text & "'", connection)
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader()

        If Me.OrderBindingSource.Position > -1 Then

            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            While reader1.Read

                Dim newRow As OrderDataSet.OrderDetailsRow = Me.OrderDataSet.OrderDetails.NewRow()

                On Error Resume Next

                UserIdGridLookUpEdit.EditValue = reader1("AsignedForMerchandeiser")

                newRow.StyleId = StyleIdGridLookUpEdit.EditValue
                newRow.OrderId = row.OrderId

                MOID = reader1("MasterOrderDetailsId").ToString()
                newRow.MasterOrderDetailsId = MOID

                newRow.PO = reader1("PO").ToString()
                newRow.PackType = reader1("PackType").ToString()
                newRow.Code = reader1("Code").ToString()
                If reader1("ColorSL") > 0 Then
                    newRow.ColorSL = reader1("ColorSL")
                Else
                    newRow.ColorSL = 0
                End If

                newRow.FabricColorId = reader1("GarmentsColor").ToString()
                newRow.Price = reader1("Price").ToString()

                If (Not IsDBNull(reader1("LDNo")) And Not IsDBNull(reader1("NLD"))) Then
                    newRow.Reference = reader1("NLD") + " :: " + reader1("LDNo")
                ElseIf IsDBNull(reader1("NLD")) Then
                    newRow.Reference = reader1("LDNo")
                ElseIf IsDBNull(reader1("LDNo")) Then
                    newRow.Reference = reader1("NLD")
                Else
                End If


                newRow.OrderQuantity = reader1("OrderQuantity").ToString()
                newRow.FirstEx = reader1("FirstEx")
                newRow.RFIDate = reader1("RFIDate")
                newRow.EX = reader1("EX")
                newRow.ETD = reader1("ETDDate")
                newRow.ETA = reader1("ETA")
                newRow.ShipmentDate = reader1("ShipmentDate")
                newRow.A_S = reader1("ShipmentBy").ToString()
                newRow.Remarks = reader1("Remarks").ToString()
                newRow.DestinationId = reader1("DestinationId")
                newRow.PackType = reader1("PackType").ToString()

                Me.OrderDataSet.OrderDetails.Rows.Add(newRow)

            End While

            reader1.Close()

        End If
        connection.Close()

    End Sub
    Private Sub GetSizeDetails()     'Read Data From MasterOrderSizeDetails and Save in OrderSizeDetails - 25.07.16 Feroz

        For Each drv As DataRowView In Me.OrderDetailsBindingSource.List

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim Command As SqlCommand = New SqlCommand("Select * From MasterOrderSizeDetails Where MasterOrderDetailsId = '" & MOID & "'", connection)
            Dim reader As SqlDataReader = Command.ExecuteReader()

            While reader.Read()

                Dim cn As Integer = ReadIntData("Select Count(*) From OrderSizeDetails Where OrderDetailsId= " & drv!OrderDetailsId, cnn)

                If cn = 0 Then

                    ExecuteQuery("Insert into OrderSizeDetails(OrderDetailsId,SizeId,Ratio,OrderQuantity)Select (select OrderDetailsId from OrderDetails where MasterOrderDetailsId = " & drv!MasterOrderDetailsId & " ) As OrderDetailsId,SizeId,Ratio,OrderQuantity From MasterOrderSizeDetails  Where MasterOrderDetailsId=" & drv!MasterOrderDetailsId, cnn)

                End If

            End While

            reader.Close()
            connection.Close()
        Next
        On Error Resume Next
        Me.OrderSizeDetailsTableAdapter.Fill(Me.OrderDataSet.OrderSizeDetails, OrderLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub GetColorListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetColorListButton.Click
        GetColorList()
    End Sub

    Private Sub GetColorList()

        'If there is no data in po grid then the procedure will exit.
        If OrderDetailsBindingSource.Position = -1 Then

            Exit Sub

        End If

        If OrderCuttingPercentageBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyODI
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select Distinct FabricColorId From OrderDetails Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And FabricColorId not in (Select FabricColorId From OrderCuttingPercentage Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & ")", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()
                'Insert Reading data From OrderSizeDetails  by CopyODI

                Dim newRow As OrderDataSet.OrderCuttingPercentageRow = Me.OrderDataSet.OrderCuttingPercentage.NewRow()

                Dim row As OrderDataSet.OrderDetailsRow
                row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)


                newRow.OrderId = Me.OrderLookupGridLookUpEdit.EditValue
                newRow.FabricColorId = reader("FabricColorId").ToString
                newRow.CuttingPercentage = CuttingWPSpinEdit.EditValue
                newRow.Printing = 0
                newRow.Washing = 0
                newRow.Embroidery = 0
                newRow.Sewing = 0
                newRow.Finishing = 0


                Me.OrderDataSet.OrderCuttingPercentage.Rows.Add(newRow)


            End While

            reader.Close()
            connection.Close()

        End If
    End Sub

    Private Sub OFFDayLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TTLDayLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WorkDayLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IsInputCompleteCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles IsInputCompleteCheckEdit.CheckedChanged
        'For TNA Generate after complete
        If showflag = True Then
            Exit Sub
        End If
        Dim TNACount As Integer = ReadIntData("Select Count(*) From OrderActivities Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
        If TNACount = 0 Then
            MessageBox.Show("TNA has not been completed.")
            IsInputCompleteCheckEdit.Checked = False
            Exit Sub

        End If
        InputCompleteDateDateEdit.Text = Now()


    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub GridView19_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)

        'Dim view As GridView = TryCast(sender, GridView)
        'Dim summaryID As Integer = Convert.ToInt32((TryCast(e.Item, GridSummaryItem)).Tag)

        ''If e.SummaryProcess = CustomSummaryProcess.Start Then

        ''    PrgCount = 0
        ''    ProgNo = String.Empty

        ''End If

        ''If e.SummaryProcess = CustomSummaryProcess.Calculate Then

        ''    Select Case summaryID

        ''        Case 1
        ''            If String.Compare(PrgNo, Convert.ToString(e.FieldValue)) = -1 Then
        ''                PrgCount += 1
        ''                ProgNo = Convert.ToString(e.FieldValue)
        ''            End If
        ''    End Select

        ''End If

        'If e.SummaryProcess = CustomSummaryProcess.Finalize Then

        '    Select Case summaryID
        '        Case 1
        '            Dim SDuration As Integer = CType(ReadData("SELECT Sum(Duration) FROM OrderActivities WHERE Slack=0", cnn), Integer)
        '            e.TotalValue = SDuration
        '            TALabel.Text = SDuration
        '    End Select

        'End If

    End Sub

    Private Sub TALabel_Click(sender As Object, e As EventArgs) Handles TTLWDayLabel2.Click, TTLOffDayLabel2.Click, TTLDayLabel2.Click, WDLabel.Click
        AddToPlanning()
    End Sub

    Private Sub AddToPlanning()


        '        Dim row1 As OrderDataSet.OrderDetailsRow
        '        row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

        '        Dim SMC As Integer = ReadIntData("Select MCQty From Style Where StyleId=" & row1.StyleId, cnn)
        '        Dim SMV As Integer = CType(ReadData("Select SMV From Style Where StyleId=" & row1.StyleId, cnn), Integer)
        '        Dim LID As Integer = 0
        '        Dim LText As String = String.Empty


        '        If SMC = 0 AndAlso SMV = 0 Then
        '            MessageBox.Show("Not Added to Sewing Planning For Following parameters:" & vbNewLine & "Sewing Start And End Date , SMV , MCQty.")
        '            Exit Sub
        '        End If

        '        Dim SDate As DateTime = ReadDateData("Select ES From OrderActivities Where OrderId=" & row1.OrderId & "And ActivitiesListId=22", cnn)
        '        Dim FDate As DateTime = ReadDateData("Select EF From OrderActivities Where OrderId=" & row1.OrderId & "And ActivitiesListId=22", cnn)
        '        'Dim SDuration As Integer = ReadData("Select Duration From OrderActivities Where OrderId=" & row1.OrderId & "And ActivitiesListId=22", cnn)
        '        'Dim SQty As Integer = ReadData("Select Duration From OrderActivities Where OrderId=" & row1.OrderId & "And ActivitiesListId=22", cnn) * (TRGT * 10)
        '        Dim OrQty As Integer = ReadData("Select Sum(OrderQuantity) From OrderDetails Where OrderId=" & row1.OrderId, cnn)
        '        Dim PQty As Integer = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & row1.OrderId, cnn)
        '        Dim PBQty As Integer = OrQty - PQty

        '        Do While PBQty > 0
        '            If SMC > 0 Then
        '                If LText = String.Empty Then
        '                    LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
        '                    LText = LID
        '                    GoTo Line1
        '                Else
        '                    LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And LineId not in (" & LText & ") And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
        '                    LText = LText & "," & LID
        '                End If

        '            End If
        'Line1:
        '            If LID > 0 Then
        '                'Exec CRUDAppointment 0,'2016-11-08 00:00:00','2016-11-08 00:00:00',1,'Test Test','Location','Description',0,1,-1,20000,120,10,1,1,'2016-11-08 00:00:00',2,'Insert'
        '                'If PBQty > 0 Then
        '                '    'CRUDAppointment(0, SDate, FDate, 1, ProgramNoTextEdit.Text, "Location", "Description", 0, LID, row1.OrderId, SQty, TRGT, SDuration, 1, 1, row1.EX, 2)
        '                '    'Else
        '                '    '    'SDuration = PBQty / (TRGT * 10)
        '                '    '    'FDate = DateAdd("d", SDuration, SDate)
        '                '    '    CRUDAppointment(0, SDate, FDate, 1, ProgramNoTextEdit.Text, "Location", "Description", 0, LID, row1.OrderId, PBQty, TRGT, SDuration, 1, 1, row1.EX, 2)
        '                'End If
        '                AddToPlanningWithLC(PBQty, LID)
        '                'MessageBox.Show("Added to Planning")
        '                PQty = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & row1.OrderId, cnn)
        '                PBQty = OrQty - PQty
        '                'MessageBox.Show("PBQty :" & PQty.ToString() & ", SQty:" & SQty.ToString())

        '            End If

        '        Loop




    End Sub

    Private Sub AddToPlanningWithLC(ByVal PlanningBalance As Integer, ByVal LID As Integer, ByVal SID As Integer, ByVal LCSD As Integer, ByVal WHD As Integer, ByVal LCA As Integer, ByVal LC As String)

        Dim row As OrderDataSet.OrderRow
        row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

        Dim OID As Integer = row.OrderId
        Dim i As Integer = 1
        Dim CumNormalQuantity As Integer = 0
        Dim CumBonusQuantity As Integer = 0
        Dim Target As Integer = 0
        Dim MinEx As Date = ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & OID, cnn)
        Dim SSMV As Decimal = ReadData("Select SMV From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
        Dim SMC As Integer = ReadIntData("Select MCQty From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
        Dim Efficiency As Decimal
        Dim ProdEff As Integer = 0
        Dim SDate As DateTime = ReadDateData("Select ES From OrderActivities Where OrderId=" & OID & "And ActivitiesListId=22", cnn)
        Dim FDate As DateTime = ReadDateData("Select EF From OrderActivities Where OrderId=" & OID & "And ActivitiesListId=22", cnn)
        Dim DayRequire As Integer = 0
        Dim HourRequire As Integer = 0
        Dim SDate2 As DateTime
        Dim FDate2 As DateTime

        ' Create new DataTable instance.
        Dim ADTable As New DataTable
        ' Create four typed columns in the DataTable.
        ADTable.Columns.Add("AppointmentId", GetType(Integer))
        ADTable.Columns.Add("DaySerial", GetType(Integer))
        ADTable.Columns.Add("PlanningDate", GetType(Date))
        ADTable.Columns.Add("Efficiency", GetType(Integer))
        ADTable.Columns.Add("PlanningQuantity", GetType(Integer))



        If SSMV > 0 Then
            ProdEff = FormatNumber(SMC * 60 / SSMV * WHD, 0)
        Else
            MessageBox.Show("SMV Missing in Style")
        End If

        Dim CumBal As Integer = 0


        Dim connection As New SqlConnection(cnn)
        connection.Open()

        Dim cmd As SqlCommand = New SqlCommand("Select dt From all_dates Where dt not in (Select HolidayDate From Holiday) And (dt between '" & SDate & "' and '" & FDate & "') Order By dt ", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            If reader.IsDBNull(0) = False Then

                If CumNormalQuantity <= PlanningBalance Then

                    If i < 10 Then
                        Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SSMV & " and DaySerial=" & i, cnn)
                    Else
                        Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SSMV & " and DaySerial=10", cnn)
                    End If
                    Dim PQty As Integer = 0


                    If CumNormalQuantity + ProdEff * Efficiency <= PlanningBalance Then

                        PQty = ProdEff * Efficiency
                        CumNormalQuantity = CumNormalQuantity + PQty


                    ElseIf CumNormalQuantity + ProdEff * Efficiency > PlanningBalance Then

                        PQty = PlanningBalance - CumNormalQuantity
                        CumNormalQuantity = CumNormalQuantity + PQty

                    End If

                    If i = 1 Then
                        SDate2 = reader("dt")
                    End If

                    If PQty > 0 Then
                        FDate2 = DateAdd("d", 1, reader("dt"))

                        Dim dr As DataRow = ADTable.NewRow()
                        dr("DaySerial") = i
                        dr("PlanningDate") = reader("dt")
                        dr("Efficiency") = Efficiency * 100
                        dr("PlanningQuantity") = PQty
                        dr("WH") = WHD

                        ADTable.Rows.Add(dr)
                    Else
                        GoTo Line1
                    End If

                    i += 1

                End If

            End If

        End While
Line1:
        Target = (CumNormalQuantity / i / 10)
        DayRequire = DateDiff("d", SDate2, FDate2)
        HourRequire = DateDiff("d", SDate2, FDate2) * 10

        reader.Close()
        connection.Close()
        Dim aptSubject As String = ReadStringData("Select Details From OrderLookup Where OrderId=" & OID, cnn)
        CRUDAppointment(0, SDate2, FDate2, 1, aptSubject, "Inserted", "Description", 0, LID, OID, CumNormalQuantity, Target, 10, DayRequire, HourRequire, MinEx, 2, SSMV, SMC, SID, LCSD, LCA, LC)

        Dim APTId As Integer = ReadIntegerData("Select AppointmentId From Appointments Where Location='Inserted'", cnn)

        For Each drv As DataRow In ADTable.Rows
            CRUDAppointmentDetails(APTId, drv("DaySerial"), drv("PlanningDate"), drv("Efficiency"), drv("PlanningQuantity"), drv("WH"))
        Next drv

        ExecuteQuery("Update Appointments Set Location='' Where Location is not null", cnn)

    End Sub


    Private Sub GenTNAButton_Click(sender As Object, e As EventArgs) Handles GenTNAButton.Click

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        'If IsInputCompleteCheckEdit.Checked = True Then

        IsInputCompleteCheckEdit.Properties.ReadOnly = True

        If Me.OrderDetailsBindingSource.Position > -1 Then

            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            'Selecting Activities Group
            Dim MinEx As Date = ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & row.OrderId, cnn)
            TTLDayLabel.Text = DateDiff(DateInterval.Day, OrderReceiveDateDateEdit.DateTime.Date, MinEx)
            Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & OrderReceiveDateDateEdit.DateTime.Date & "' And '" & MinEx & "'", cnn)
            'Dim WKDay As Integer = ReadIntData("select datediff(day, -2, '" & drv!EX & "')/7  - datediff(day, -3, '" & OrderReceiveDateDateEdit.DateTime.Date & "')/7", cnn)
            TTLOffDayLabel.Text = HLDDay
            WDLabel.Text = Val(TTLDayLabel.Text) - HLDDay

        End If

        Dim AGID As Int32 = ReadIntData("Select Top 1 ISNULL(ActivitiesGroupId,0) From ActivitiesGroup Where IsSpecialYarn= " & IIf(SpecialYarnCheckEdit.Checked, 1, 0) & " And IsSequence= " & IIf(SequenceCheckEdit.Checked, 1, 0) & "And IsSublimation= " & IIf(SublimationCheckEdit.Checked, 1, 0) & "And IsPrint= " & IIf(IsPrintCheckEdit.Checked, 1, 0) & " And IsEmbroidery=" & IIf(IsEmbroideryCheckEdit1.Checked, 1, 0) & " And MinimumDay<=" & Val(WDLabel.Text) & " And MaximumDay>=" & Val(WDLabel.Text), cnn)

        If AGID > 0 Then
            ActivitiesGroupIdGridLookUpEdit.EditValue = AGID
            GenerateActivities(AGID)
        Else
            MessageBox.Show("Any template did not matched for this program.")
            Exit Sub

        End If

        'Else

        'MessageBox.Show("Generation is not done for incomplete order...")

        'End If

        SplashScreenManager.CloseForm(False)

    End Sub


    Public Shared Sub SendOrderMail(ByVal Host As String, ByVal Port As String, ByVal SSL As Boolean, ByVal FromEmail As String, ByVal Pass As String, ByVal PDate As Date, ByVal PrgNo As String)

        'Dim MailBody As String = String.Empty
        'Dim SMSBody As String = String.Empty
        'Dim culture As CultureInfo = New CultureInfo("en-IN")
        'Dim list_emails As ArrayList = New ArrayList()
        'Dim list_mobile As ArrayList = New ArrayList()
        'Dim i As Integer = 0
        ''Dim md As Integer = 1
        'Dim email As String = String.Empty


        'Using conn1 As SqlConnection = New SqlConnection()
        '    conn1.ConnectionString = cnn
        '    conn1.Open()

        '    Dim cmd_Email As SqlCommand = New SqlCommand("Select MailAddress,MobileNo from MailAddress Where IsActive=1 And MailAddressId in (Select MailAddressId From MailAddressDetails Where MailType='Order Received')", conn1)
        '    Dim read_Email As SqlDataReader = cmd_Email.ExecuteReader()

        '    While read_Email.Read()
        '        email = read_Email.GetValue(0).ToString()
        '        mobile = read_Email.GetValue(1).ToString()
        '        list_emails.Add(email)
        '        list_mobile.Add(mobile)
        '        i = i + 1 - 1
        '    End While

        '    read_Email.Close()
        'End Using

        'Using conn As SqlConnection = New SqlConnection()

        '    conn.ConnectionString = cnn
        '    conn.Open()
        '    Dim command As SqlCommand = New SqlCommand("Execute LastDayProductionStatus @0", conn)
        '    Dim datetime As DateTime = DateTime.Now
        '    command.Parameters.Add(New SqlParameter("0", PDate))
        '    Using reader As SqlDataReader = command.ExecuteReader()
        '        Dim HeaderString As String = "<!DOCTYPE html>" & "<html>" & "<head>" & "<style>" & "table, th, td {" & "border: 1px solid black;" & "border-collapse:collapse;" & "}" & "th, td {" & "padding: 5px;" & "text-align: left;" & "}" & "</style>" & "</head>" & "<body>"
        '        MailBody = MailBody + HeaderString
        '        SMSBody = "New Order :" & PrgNo & "\0x0A"
        '        MailBody = MailBody & "<table Style=" & "border: 1px solid blackborder - collapse: collapse;" & ">" & vbLf
        '        MailBody = MailBody & "<tr><td colspan="" 4 "" style=""background-color:Gray;color:White;"" > <b>Order No : " & PrgNo & "</b></td></tr>" & vbLf
        '        MailBody = MailBody & "<tr style=""background-color:Gray;color:White;text-align: center;"" ><td> <b>Production Type</b></td><td> <b>Target</b></td><td style=""text-align:center;""> <b>Actual</b></td><td style=""text-align:center;""><b>%</b></td></tr>" & vbLf
        '        While reader.Read()
        '            Dim ap As Decimal = 0
        '            If reader.GetDecimal(2) > 0 AndAlso reader.GetDecimal(3) > 0 AndAlso Not reader.GetDecimal(3).Equals(Nothing) Then
        '                ap = reader.GetDecimal(3) / reader.GetDecimal(2) * 100
        '            End If

        '            If Convert.ToInt32(ap) = 0 Then
        '                MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " + String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:right;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td></td></tr>" & vbLf
        '            Else
        '                MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " + String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:right;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td style=""text-align:right;""><b>" + Convert.ToInt32(ap).ToString() & "%</b></td></tr>" & vbLf
        '            End If

        '            SMSBody = SMSBody + String.Format("{0,-20}", reader(4).ToString()) & ":" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "\0x0A"
        '        End While

        '        MailBody = MailBody & "<tr><td colspan="" 4 "" style=""background-color:Gray;color:White;""><b>This is genereted by nERP Solutions.</b></td></tr>" & vbLf
        '        MailBody = MailBody & "</table></body>" & vbLf
        '    End Using
        'End Using

        'Dim from As MailAddress = New MailAddress(FromEmail)
        'Dim smtp As SmtpClient = New SmtpClient()
        'smtp.Host = Host
        'smtp.Port = Port
        'smtp.Credentials = New NetworkCredential(FromEmail, Pass)
        'smtp.EnableSsl = SSL
        'For Each email_to As String In list_emails
        '    'Console.WriteLine("Mail To")
        '    Dim [to] As MailAddress = New MailAddress(email_to)
        '    'Console.WriteLine([to])
        '    Dim mail As MailMessage = New MailMessage(from, [to])
        '    mail.Subject = "NCL Production Status on " & PDate.ToShortDateString()
        '    mail.Body = MailBody
        '    'Console.WriteLine("Sending email...")
        '    ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
        '    mail.IsBodyHtml = True
        '    smtp.Send(mail)
        '    'Console.WriteLine("Send Succesfully")
        '    MessageBox.Show("The mail has been send successfully")

        'Next



    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If AddFlag = True Then

            ShowMaster(frmMasterProgramLookup2)

            If frmMasterProgramLookup2.DialogResult = System.Windows.Forms.DialogResult.OK Then

                GetMasterOrder2()
                Save()

            End If

        Else

            MessageBox.Show("Please, Click on add button first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub CopyFullButton_Click(sender As Object, e As EventArgs) Handles CopyFullButton.Click
        If OrderLookupGridLookUpEdit.EditValue > 0 Then
            GoTo Line1
        Else
            MessageBox.Show("Please, select a Program No...")
            Exit Sub
        End If
Line1:

        If MessageBox.Show("Are you sure your want to copy ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim PrgNo As String = String.Empty

            Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

            'If CC <> "NCL" Then


            'If MasterProgramNoTextBox.Text = String.Empty Then

            Dim ABC As String = Now.Year.ToString.Substring(2) & CC.ToString()
            Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [Order] Where ProgramNo Like '%" & ABC & "%'", cnn)
            Dim XYZ1 As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [MasterOrderDetails] Where ProgramNo Like '%" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & CC.ToString() & (Val(XYZ) + 1).ToString()
                'ProgramNoTextEdit.Text = NewOrder
                PrgNo = NewOrder
            Else
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & CC.ToString() & (Val(XYZ1) + 1).ToString()
                'ProgramNoTextEdit.Text = NewOrder
                PrgNo = NewOrder
            End If

            'End If




            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("CopyBuyerOrder", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@OrderId", OrderLookupGridLookUpEdit.EditValue)
                cmd.Parameters.AddWithValue("@NewProgramNo", PrgNo)

                cmd.ExecuteNonQuery()

            End Using


            If Me.ByUserFlag = False Then
                Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            Else
                Me.OrderLookupTableAdapter.FillByParticularUser(Me.OrderLookupDataSet.OrderLookup, UserId)
            End If

            Dim NewOID As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & PrgNo & "'", cnn)

            OrderLookupGridLookUpEdit.EditValue = NewOID

            ShowOrder(NewOID)


            MessageBox.Show("Copy has been done." & vbNewLine & "Your new Program No :" & PrgNo.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub OrderLookupGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderLookupGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub BPrgNoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BPrgNoLinkLabel.LinkClicked
        If Me.OrderBindingSource.Position > -1 Then
            Dim row As OrderDataSet.OrderRow
            row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id=" & UserId, cnn)
            If UL = 1 Then
                row.SetAdvanceProgramNoNull()
            End If
        End If
    End Sub
End Class