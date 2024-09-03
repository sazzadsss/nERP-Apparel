Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Threading
Imports System.Drawing

Public Class frmMasterOrder
    Dim CopyODI As Integer
    Private Worker As BackgroundWorker = New BackgroundWorker
    Dim FileName As String
    Dim FileProcess As String
    Private _ByMerchanFlag As Boolean
    Public Property ByMerchanFlag() As Boolean
        Get
            Return _ByMerchanFlag
        End Get
        Set(ByVal value As Boolean)
            _ByMerchanFlag = value
        End Set
    End Property


    Private Sub Save()

        Try

            If Me.MasterOrderDetailsBindingSource.Position > -1 Then

                For Each drv As DataRowView In Me.MasterOrderDetailsBindingSource.List
                    

                    If DBNull.Value.Equals(drv!Re_ExFactory) Then
                        drv!Re_ExFactory = drv!Ex
                    End If

                Next

            End If

            Me.Validate()
            Me.MasterOrderBindingSource.EndEdit()
            Me.MasterOrderDetailsBindingSource.EndEdit()
            Me.MasterOrderInstructionBindingSource.EndEdit()
            Me.MasterOrderAmendmentHistoryBindingSource.EndEdit()
            Me.MasterOrderDetailsAmendmentHistoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MasterOrderDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmMasterOrder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F11 Then ' Set The Garments Color from Fabric Color interface by Pressing F11 16.06.16 - Feroz
            If MasterOrderDetailsGridControl.IsFocused Then
                If GridView3.FocusedColumn.AbsoluteIndex = colGarmentsColor.AbsoluteIndex Then

                    frmFabricColor.OnlyAddflag = True
                    frmFabricColor.ShowDialog()

                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
                        Dim row As MasterOrderDataSet.MasterOrderDetailsRow
                        row = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)
                        row.GarmentsColor = frmFabricColor.FabricColorId
                        Me.MasterOrderDetailsBindingSource.ResetBindings(True)

                    End If
                End If
            End If

        ElseIf e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then ' Ctrl + S for save 16.06.16 - Feroz

            Save()
            MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None)

        End If

    End Sub

    Private Sub frmMasterOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)

        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)

        Me.MasterOrderSampleStatusTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderSampleStatus)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.MasterOrderDetailsAmendmentHistoryTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderDetailsAmendmentHistory)
        Me.MasterOrderAmendmentHistoryTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderAmendmentHistory)
        Me.MasterOrderDetailsAmendmentHistoryTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderDetailsAmendmentHistory)
        Me.MasterOrderAmendmentHistoryTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderAmendmentHistory)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.Fill(Me.KnittingTypeDataSet.KnittingType)
        Me.MasterOrderInstructionTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderInstruction)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.SupplierTableAdapter.FillBySupplierType(Me.SupplierDataSet.Supplier, "Garments")
        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)

        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)
        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.MasterOrderSizeDetailsTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderSizeDetails)
        Me.MasterOrderInstructionTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderInstruction)
        Me.MasterOrderDetailsTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrderDetails)
        Me.SupplierGridLookUpEdit1.EditValue = 62
        Control.CheckForIllegalCrossThreadCalls = False ' Remove Cross Thead Error from BackGround Worker 30.06.16
        DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True ' Disable Cross Thead Error from BackGround Worker 30.06.16 
        Me.ProgressBar.Visible = False
        tbProgress.Visible = False

        If UserId = 1 Then
            DocDeleteButton.Visible = True
        Else
            DocDeleteButton.Visible = False
        End If

        If ByMerchanFlag = False Then

            colUserId.OptionsColumn.AllowEdit = True

            If CheckUserRights("Master Order").CanEdit = False Then

                NewButton.Enabled = False
                EditButton.Enabled = False
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = False
                RefreshButton.Enabled = False

            ElseIf CheckUserRights("Master Order").CanDelete = False Then

                NewButton.Enabled = True
                EditButton.Enabled = True
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = False
                RefreshButton.Enabled = False

            End If

        Else
            colUserId.OptionsColumn.AllowEdit = False

            If (CheckUserRights("Master Order [Merchandiser Wise]").CanEdit) = False Then

                NewButton.Enabled = False
                EditButton.Enabled = False
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = False
                RefreshButton.Enabled = False

            ElseIf (CheckUserRights("Master Order [Merchandiser Wise]").CanDelete) = False Then

                NewButton.Enabled = True
                EditButton.Enabled = True
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = False
                RefreshButton.Enabled = False

            End If
        End If
    End Sub


    Private Sub StyleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleButton.Click

        If Me.MasterOrderBindingSource.Position = -1 Then
            Exit Sub

        End If

        Dim row As MasterOrderDataSet.MasterOrderRow
        row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

        If row.IsStyleIdNull = False Then

            frmStyle.StyleId = row.StyleId

        End If


        frmStyle.ShowDialog()

        If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then ' Get Data from Style Interface 21.05.16 - Feroz


            Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
            Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)

            Dim connection As New SqlConnection(cnn)

            Dim queryString As String = "Select * From Style Where StyleId=" & frmStyle.StyleId
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then

                reader.Read()

                On Error Resume Next

                row.Picture = reader("Picture")
                row.BuyerId = reader("BuyerId").ToString() 'ReadIntegerData("Select BuyerId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.DivisionId = reader("DivisionId") 'ReadIntegerData("Select DivisionId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.StyleNameId = reader("StyleNameId") 'ReadIntegerData("Select StyleNameId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.StyleId = frmStyle.StyleId
                row.KnittingTypeId = reader("KnittingTypeId") 'ReadIntegerData("Select KnittingTypeId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.CompositionId = reader("CompositionId") 'ReadIntegerData("Select CompositionId From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.GSM = reader("GSM") ' ReadIntegerData("Select GSM From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.Dia = reader("Dia") 'ReadIntData("Select Dia From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.StyleType = reader("StyleType") ' ReadStringData("Select StyleType From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.IsPrint = reader("IsPrint") 'ReadBooleanData("Select IsPrint From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.IsEmbroidary = reader("IsEmbroidery") ' ReadBooleanData("Select IsEmbroidery  From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.IsAOP = reader("IsAOP") ' ReadBooleanData("Select IsAOP From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.IsYDS = reader("IsYDS") ' ReadBooleanData("Select IsYDS From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.IsWash = reader("IsWash") ' ReadBooleanData("Select IsWash From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.GMDescription = reader("GMDescription") 'ReadStringData("Select GMDescription From Style Where StyleId=" & frmStyle.StyleId, cnn)
                row.GMTBrandId = reader("GMTBrandId")
                row.Gauge = reader("Gauge")
                row.SeasonId = reader("SeasonID")
                row.IsPeachFinish = reader("IsPeachFinish")
                row.IsBrush = reader("IsBrush")

            End If

            reader.Close()
            connection.Close()


        End If



    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)
        Dim ABC As String = String.Empty

        If CC <> "NCL" Then
            ABC = Now.Year.ToString.Substring(2) & "MPN"
        Else
            ABC = Now.Year.ToString.Substring(2) & "NFL"
        End If

        Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(MasterProgramNo),0,CHARINDEX('L',REVERSE(MasterProgramNo))))) From MasterOrder Where MasterProgramNo Like '" & ABC & "%'", cnn)

        Dim NewOrder As String = ABC & (Val(XYZ) + 1).ToString("000000") ' Create a new MasterProgram Name With prefix 00000 20.05.16 - Feroz

        MasterOrderDataSet.MasterOrder.MasterProgramNoColumn.DefaultValue = NewOrder
        MasterOrderDataSet.MasterOrder.UserIdColumn.DefaultValue = UserId
        MasterOrderDataSet.MasterOrder.CreatedOnColumn.DefaultValue = Today
        MasterOrderDataSet.MasterOrder.GMTBrandIdColumn.DefaultValue = 0

        MasterOrderBindingSource.AddNew()
        Save()


    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        Save()

        Try
            'Need to remember Copied Order Details Id - 21.05.16 - Feroz

            If MasterOrderDetailsBindingSource.Position > -1 Then

                Dim row As MasterOrderDataSet.MasterOrderDetailsRow
                row = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)


                CopyODI = row.MasterOrderDetailsId

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Save()
        MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub



    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        Dim result As Integer = MessageBox.Show("Are you want to DELETE", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Me.MasterOrderBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click

        'If there is no data in po grid then the procedure will exit.
        If MasterOrderDetailsBindingSource.Position = -1 Then

            Exit Sub

        End If

        If MasterOrderSizeDetailsBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyODI 18.05.16 - Feroz
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select SizeId,OrderQuantity,Ratio From MasterOrderSizeDetails Where MasterOrderDetailsId=" & CopyODI, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()

                'Insert Reading data From OrderSizeDetails  by CopyODI

                Dim newRow As MasterOrderDataSet.MasterOrderSizeDetailsRow = Me.MasterOrderDataSet.MasterOrderSizeDetails.NewRow()

                'Start Reading Selected OrderDetailsId
                Dim PasteODI As Integer

                Dim row As MasterOrderDataSet.MasterOrderDetailsRow
                row = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)

                PasteODI = row.MasterOrderDetailsId


                'End Reading Selected OrderDetailsId


                newRow.MasterOrderDetailsId = PasteODI
                newRow.SizeId = reader("SizeId").ToString
                newRow.OrderQuantity = reader("OrderQuantity").ToString
                If DBNull.Value.Equals(reader("ratio")) Then
                    newRow.Ratio = 0
                Else
                    newRow.Ratio = reader("Ratio").ToString
                End If

                Me.MasterOrderDataSet.MasterOrderSizeDetails.Rows.Add(newRow)

            End While

            reader.Close()
            connection.Close()

        End If

    End Sub


    Private Sub ProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramButton.Click

        On Error Resume Next

        If Me.SupplierGridLookUpEdit1.EditValue > -1 Then


            Dim BC As String = ReadStringData("Select ProgramCode From Supplier Where SupplierId=" & SupplierGridLookUpEdit1.EditValue, cnn)

            Dim ABC As String = Now.Year.ToString.Substring(2) & BC
            Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From MasterOrderDetails Where ProgramNo Like '%" & ABC & "%'", cnn)

            Dim NewOrder As String = Now.Year.ToString.Substring(2) & BC & (Val(XYZ) + 1).ToString("0000") ' Create Program Name with Prefix 0000

            Me.MasterOrderDataSet.MasterOrderDetails.ProgramNoColumn.DefaultValue = NewOrder
            Me.MasterOrderDataSet.MasterOrderDetails.SupplierIdColumn.DefaultValue = Me.SupplierGridLookUpEdit1.EditValue
            MasterOrderDataSet.MasterOrderDetails.CreatedOnColumn.DefaultValue = Today
            MasterOrderDataSet.MasterOrderDetails.IsAdvanceColumn.DefaultValue = False
            MasterOrderDetailsBindingSource.AddNew()
            Save()

        End If

    End Sub

    Private Sub CopyPOButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPOButton.Click

        ' Copy Data From Selected Row to New Row In MasterOrderDetails - 22.06.16 Feroz 

        Save()

        Dim oldRow As MasterOrderDataSet.MasterOrderDetailsRow
        oldRow = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)

        On Error Resume Next
        Dim newRow As MasterOrderDataSet.MasterOrderDetailsRow = Me.MasterOrderDataSet.MasterOrderDetails.NewRow()

        newRow.MasterOrderId = oldRow.MasterOrderId
        newRow.ProgramNo = oldRow.ProgramNo
        newRow.PO = oldRow.PO
        newRow.ColorSL = oldRow.ColorSL
        newRow.OrderQuantity = oldRow.OrderQuantity
        newRow.RFIDate = oldRow.RFIDate
        newRow.EX = oldRow.EX
        newRow.Re_RFI = oldRow.Re_RFI
        newRow.ETDDate = oldRow.ETDDate
        newRow.Re_ETD = oldRow.Re_ETD
        newRow.ShipmentBy = oldRow.ShipmentBy
        newRow.GarmentsColor = oldRow.GarmentsColor
        newRow.Code = oldRow.Code
        newRow.DestinationId = oldRow.DestinationId
        newRow.Price = oldRow.Price
        newRow.SupplierId = oldRow.SupplierId
        newRow.PackType = oldRow.PackType
        newRow.AsignedForMerchandeiser = oldRow.AsignedForMerchandeiser
        newRow.IsReceivedBySupplier = False '.IsReceivedBySupplierColumn.DefaultValue = False
        newRow.Remarks = "-" ' .RemarksColumn.DefaultValue = "-"
        newRow.NLD = oldRow.NLD
        newRow.Re_ExFactory = oldRow.Re_ExFactory
        newRow.IsDespatch = oldRow.IsDespatch
        newRow.CreatedOn = Today
        newRow.CommercialTeam = oldRow.CommercialTeam
        newRow.Shipout = oldRow.Shipout
        newRow.ShipoutBalance = oldRow.ShipoutBalance
        newRow.ShipoutStatus = oldRow.ShipoutStatus
        newRow.ShipmentStatus = oldRow.ShipmentStatus
        newRow.ShipmentQTY = oldRow.ShipmentQTY
        newRow.DSTNO = oldRow.DSTNO
        newRow.IsAdvance = oldRow.IsAdvance

        Me.MasterOrderDataSet.MasterOrderDetails.Rows.Add(newRow)



    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If Me.MasterOrderBindingSource.Position > -1 Then

            Dim row As MasterOrderDataSet.MasterOrderRow ' Read Current Selected MasterOrderId From Master Order Grid
            row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

            frmMasterOrderPrint.MOID = row.MasterOrderId ' Pass MasterOrderId in Report Grid

            ShowForm(frmMasterOrderPrint)
        End If

    End Sub


    Private Sub btnMasterOrderAmnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterOrderAmnd.Click

        If Me.MasterOrderBindingSource.Position > -1 Then 'If There Have data in Master Order Than Work Continue 17.06.16 - Feroz

            Dim row As MasterOrderDataSet.MasterOrderRow
            row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)


            If row.IsAmendmentNoNull = False Then
                On Error Resume Next
                Dim AmndHistoryNo As Integer = ReadIntData("Select Count(*) From MasterOrderAmendmentHistory Where MasterOrderId=" & row.MasterOrderId & "And AmendmentNo=" & row.AmendmentNo, cnn)
                If row.AmendmentNo >= 0 Then
                    If AmndHistoryNo = 0 Then ' If there have no Master Amendment, Create initial amendment 0

                        Dim newRow As MasterOrderDataSet.MasterOrderAmendmentHistoryRow = Me.MasterOrderDataSet.MasterOrderAmendmentHistory.NewRow()
                        newRow.AmendmentNo = row.AmendmentNo
                        newRow.AmendmentDate = row.AmendmentDate
                        newRow.CauseOfAmendment = row.CauseOfAmendment
                        newRow.MasterOrderId = row.MasterOrderId
                        Me.MasterOrderDataSet.MasterOrderAmendmentHistory.Rows.Add(newRow)

                    End If 'If there have  amendment Add 1 with Previous 

                    row.AmendmentNo = row.AmendmentNo + 1
                    row.AmendmentDate = Today()
                    row.CauseOfAmendment = ""

                End If
            End If
        End If
    End Sub

    Private Sub btnMasterOrderDetailsAmnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterOrderDetailsAmnd.Click

        If Me.MasterOrderBindingSource.Position > -1 Then 'If There Have data in Master Order Than Work Continue 17.06.16 - Feroz
            Dim row As MasterOrderDataSet.MasterOrderDetailsRow
            row = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)

            If row.IsAmendmentNoNull = False Then
                On Error Resume Next
                Dim AmndHistoryNo As Integer = ReadIntData("Select Count(*) From MasterOrderDetailsAmendmentHistory Where MasterOrderDetailsId=" & row.MasterOrderDetailsId & "And AmendmentNo=" & row.AmendmentNo, cnn)

                If row.AmendmentNo >= 0 Then
                    If AmndHistoryNo = 0 Then ' If there have no Master Details Amendment, Create initial amendment 0

                        Dim newRow As MasterOrderDataSet.MasterOrderDetailsAmendmentHistoryRow = Me.MasterOrderDataSet.MasterOrderDetailsAmendmentHistory.NewRow()
                        newRow.AmendmentNo = row.AmendmentNo
                        newRow.AmendmentDate = row.AmendmentDate
                        newRow.CauseOfAmendment = row.CauseOfAmendment
                        newRow.MasterOrderDetailsId = row.MasterOrderDetailsId
                        Me.MasterOrderDataSet.MasterOrderDetailsAmendmentHistory.Rows.Add(newRow)

                    End If 'If there have  amendment Add 1 with Previous 

                    row.AmendmentNo = row.AmendmentNo + 1
                    row.AmendmentDate = Today()
                    row.CauseOfAmendment = ""
                End If
            End If
        End If

    End Sub

    Private Sub AddSampleStatusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSampleStatusButton.Click

        If Me.MasterOrderBindingSource.Position > -1 Then ' Check is there have Any data on Master Order 30.07.16 - Feroz

            Dim row As MasterOrderDataSet.MasterOrderRow
            row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

            On Error Resume Next

            'Dim BC As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & BuyerIdGridLookUpEdit.EditValue, cnn)

            Dim ABC As String = Now.Year.ToString.Substring(2) & "SP"
            Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(RequestNo),0,CHARINDEX('P',REVERSE(RequestNo))))) From SampleRequestFinal Where RequestNo Like '" & ABC & "%'", cnn)
            Dim XYZ1 As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(SampleRequestNo),0,CHARINDEX('P',REVERSE(SampleRequestNo))))) From MasterOrderSampleStatus Where SampleRequestNo Like '" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then ' Check Which one is Latest and Create Sample Request no 

                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ) + 1).ToString("0000")
                Me.MasterOrderDataSet.MasterOrderSampleStatus.SampleRequestNoColumn.DefaultValue = NewOrder

            Else
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ1) + 1).ToString("0000")
                Me.MasterOrderDataSet.MasterOrderSampleStatus.SampleRequestNoColumn.DefaultValue = NewOrder

            End If

            Dim NewRow As MasterOrderDataSet.MasterOrderSampleStatusRow = Me.MasterOrderDataSet.MasterOrderSampleStatus.NewRow()
            NewRow.MasterOrderId = row.MasterOrderId

            Me.MasterOrderDataSet.MasterOrderSampleStatus.Rows.Add(NewRow)

        End If
    End Sub

    Private Sub DeleteSampleStatusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSampleStatusButton.Click
        Me.MasterOrderSampleStatusBindingSource.RemoveCurrent()
    End Sub

    Private Sub DocAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocAddButton.Click

        Dim cnndoc As String = My.Settings.KSoft_Doc_ConnectionString

        Dim row As MasterOrderDataSet.MasterOrderRow
        row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)
        Dim MasterOrderId As Integer = row.MasterOrderId

        FileProcess = "Upload"
        ProgressBar.Visible = True
        tbProgress.Visible = True

        databaseFilePut(cnndoc, MasterOrderId) ' Function Of Upload a file - 30.07.16 Feroz
        Me.MasterOrderDocTableAdapter.Fill(MasterOrderDocDataSet.MasterOrderDoc)

    End Sub
    Private Sub databaseFilePut(ByVal connectionString As String, ByVal MasterOrderId As Integer)

        Dim openFileDialog1 As New OpenFileDialog()
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Select the file from dialouge Box

            Try

                FileName = openFileDialog1.FileName
                Worker.RunWorkerAsync() ' ProgressBar for uploading time with Upload file Working Process
                Me.Cursor = Cursors.WaitCursor
                SaveDocButton.Enabled = False
                DocAddButton.Enabled = False


            Catch Ex As Exception

                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)

            End Try

        End If

    End Sub

    Private Sub SaveDocButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDocButton.Click

        Dim row As MasterOrderDocDataSet.MasterOrderDocRow
        row = CType(CType(Me.MasterOrderDocBindingSource.Current, DataRowView).Row, MasterOrderDocDataSet.MasterOrderDocRow)
        FileProcess = "Downloading"
        ProgressBar.Visible = True
        tbProgress.Visible = True
        databaseFileRead(row.MasterOrderDocId, row.DocName) ' Function Of Upload a file - 30.07.16 Feroz

    End Sub

    Private Sub databaseFileRead(ByVal MODID As String, ByVal MODName As String)

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.FileName = MODName
        SaveFileDialog1.Title = "Save a file"

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = SaveFileDialog1.FileName()
            Worker.RunWorkerAsync() ' ProgressBar for Downloading time With Save Work proccess
            Me.Cursor = Cursors.WaitCursor
            SaveDocButton.Enabled = False
            DocAddButton.Enabled = False

        End If


    End Sub

    Public Sub New()

        InitializeComponent()
        Worker.WorkerReportsProgress = True
        AddHandler Worker.DoWork, AddressOf worker_DoWork
        AddHandler Worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler Worker.ProgressChanged, AddressOf worker_ProgressChanged

    End Sub


    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        'If Uploading Or Downloading Complete Show that Status as Message - 30.07.16 - Feroz

        Me.Cursor = Cursors.Arrow
        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        ProgressBar.Value = 100
        Me.tbProgress.BackColor = Color.ForestGreen
        Me.tbProgress.ForeColor = Color.WhiteSmoke
        Me.tbProgress.Text = "Complete"
        SaveDocButton.Enabled = True
        DocAddButton.Enabled = True
        Dim result As Integer = MessageBox.Show("Done", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            ProgressBar.Value = 0
            Me.tbProgress.Text = ""
            ProgressBar.Visible = False
            tbProgress.Visible = False
            If FileProcess = "Downloading" Then
                Process.Start(FileName)
            End If
        End If

    End Sub
    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        
        If FileProcess = "Upload" Then

            ' Work of Upload a File 30.07.16 Feroz

            Me.tbProgress.Text = "Uploading.."
            ProgressBar.Value = 0
            Dim file As Byte()
            Dim connectionString As String = My.Settings.KSoft_Doc_ConnectionString

            Dim row As MasterOrderDataSet.MasterOrderRow
            row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

            Dim MasterOrderId As Integer = row.MasterOrderId ' Read the current Master Program No

            Using stream = New FileStream(FileName, FileMode.Open, FileAccess.Read) ' Process Of Reading A file

                Using reader = New BinaryReader(stream)
                    file = reader.ReadBytes(CInt(stream.Length)) 'Get The file
                End Using

            End Using

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                'Process Of save File in DB
                

                Worker.ReportProgress(95)
                Using sqlWrite = New SqlCommand("INSERT INTO MasterOrderDoc (Doc,DocName,MasterOrderId,UploadedOn,UploadedBy)Values(@Doc,@DocName,@MasterOrderId,@UploadedOn,@UploadedBy)", connection)
                    sqlWrite.Parameters.Add("@Doc", SqlDbType.VarBinary, file.Length).Value = file
                    sqlWrite.Parameters.Add("@DocName", SqlDbType.VarChar).Value = System.IO.Path.GetFileName(FileName)
                    sqlWrite.Parameters.Add("@UploadedOn", SqlDbType.DateTime).Value = Now()
                    sqlWrite.Parameters.Add("@UploadedBy", SqlDbType.BigInt).Value = UserId
                    sqlWrite.Parameters.Add("@MasterOrderId", SqlDbType.BigInt).Value = MasterOrderId
                    sqlWrite.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
            MasterOrderDocTableAdapter.FillByMasterOrderId(Me.MasterOrderDocDataSet.MasterOrderDoc, MasterOrderId)

        ElseIf FileProcess = "Downloading" Then

            'Work Of download a File 30.07.16 - Feroz

            Me.tbProgress.Text = "Downloading.."
            ProgressBar.Value = 0

            Dim row As MasterOrderDocDataSet.MasterOrderDocRow
            row = CType(CType(Me.MasterOrderDocBindingSource.Current, DataRowView).Row, MasterOrderDocDataSet.MasterOrderDocRow)

            Dim MODID As String = row.MasterOrderDocId ' Get the Current File Name

            Dim varPathToNewLocation As String = FileName



            Using connection As New SqlConnection(My.Settings.KSoft_Doc_ConnectionString)
                connection.Open()
                Using sqlQuery = New SqlCommand("SELECT Doc FROM MasterOrderDoc WHERE [MasterOrderDocId] = @MODID", connection)
                    sqlQuery.Parameters.AddWithValue("@MODID", MODID)

                    Using sqlQueryResult = sqlQuery.ExecuteReader() 'Process Of Saving File On PC 30.07.16 - Feroz
                        If sqlQueryResult IsNot Nothing Then

                           
                            Worker.ReportProgress(95)

                            sqlQueryResult.Read()
                            Dim blob = New [Byte]((sqlQueryResult.GetBytes(0, 0, Nothing, 0, Integer.MaxValue)) - 1) {}
                            sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length)
                            Using fs = New FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write)
                                fs.Write(blob, 0, blob.Length)
                            End Using
                        End If
                    End Using
                End Using
            End Using
            'File.Open(FileName, FileMode.Open)


        ElseIf FileProcess = "Delete" Then 'Process When Delete a doc - 01.08.16 - Feroz

            Me.tbProgress.Text = "Deleting.."
            ProgressBar.Value = 0

            Dim connectionString As String = My.Settings.KSoft_Doc_ConnectionString
            Dim row As MasterOrderDocDataSet.MasterOrderDocRow
            row = CType(CType(Me.MasterOrderDocBindingSource.Current, DataRowView).Row, MasterOrderDocDataSet.MasterOrderDocRow)



            Using connection As New SqlConnection(connectionString)
                connection.Open()

                'Process Of Delete File in DB

               
                Worker.ReportProgress(95)

                Using sqlWrite = New SqlCommand("DELETE MasterOrderDoc Where MasterOrderDocId = " & row.MasterOrderDocId, connection)
                    sqlWrite.ExecuteNonQuery()
                End Using
                Me.MasterOrderDocBindingSource.RemoveCurrent()
                connection.Close()

            End Using

        End If
    End Sub

    Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        
        ProgressBar.Value = e.ProgressPercentage
        Me.tbProgress.BackColor = Color.ForestGreen
        Me.tbProgress.ForeColor = Color.WhiteSmoke
        Me.tbProgress.Text = e.ProgressPercentage.ToString() & "%"

    End Sub


    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Dim row As MasterOrderDataSet.MasterOrderRow
        row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

        Me.MasterOrderDocTableAdapter.FillByMasterOrderId(MasterOrderDocDataSet.MasterOrderDoc, row.MasterOrderId)
    End Sub

    Private Sub MasterOrderBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterOrderBindingSource.PositionChanged
        On Error Resume Next
        Me.MasterOrderDocTableAdapter.FillByMasterOrderId(MasterOrderDocDataSet.MasterOrderDoc, 0)
    End Sub

    Private Sub RefreshDocButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDocButton.Click
        Dim row As MasterOrderDataSet.MasterOrderRow
        row = CType(CType(Me.MasterOrderBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderRow)

        Me.MasterOrderDocTableAdapter.FillByMasterOrderId(MasterOrderDocDataSet.MasterOrderDoc, row.MasterOrderId)
    End Sub

   

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
        If ByMerchanFlag = True Then
            Me.MasterOrderTableAdapter.FillByUserId(Me.MasterOrderDataSet.MasterOrder, UserId)
        Else
            Me.MasterOrderTableAdapter.Fill(Me.MasterOrderDataSet.MasterOrder)
        End If
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        If ByMerchanFlag = True Then
            Me.MasterOrderTableAdapter.FillByMasterProgramWithUserId(Me.MasterOrderDataSet.MasterOrder, MasterProgramLookUpTextEdit.Text, UserId)
        Else
            Me.MasterOrderTableAdapter.FillByMasterProgram(Me.MasterOrderDataSet.MasterOrder, MasterProgramLookUpTextEdit.Text)
        End If
    End Sub

    Private Sub CalculateRatioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateRatioButton.Click

        If Me.MasterOrderDetailsBindingSource.Position > -1 Then

            Dim row As MasterOrderDataSet.MasterOrderDetailsRow
            row = CType(CType(Me.MasterOrderDetailsBindingSource.Current, DataRowView).Row, MasterOrderDataSet.MasterOrderDetailsRow)

            Dim TTLRatio As Integer = 0

            If MasterOrderSizeDetailsBindingSource.Position > -1 Then

                For Each drv As DataRowView In Me.MasterOrderSizeDetailsBindingSource.List
                    TTLRatio = TTLRatio + drv!Ratio
                Next

                For Each drv2 As DataRowView In Me.MasterOrderSizeDetailsBindingSource.List
                    drv2!OrderQuantity = row.OrderQuantity / TTLRatio * drv2!Ratio
                Next

            End If


        End If
    End Sub


    Private Sub DocDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocDeleteButton.Click
        FileProcess = "Delete"
        ProgressBar.Visible = True
        tbProgress.Visible = True


        Worker.RunWorkerAsync() ' ProgressBar for Deleting time With Save Work proccess
        Me.Cursor = Cursors.WaitCursor
        SaveDocButton.Enabled = False
        DocAddButton.Enabled = False
    End Sub

    Private Sub SMSToButton_Click(sender As Object, e As EventArgs) Handles SMSToButton.Click
        MessageBox.Show("Welcome to our " & SCName & ". This SMS feature is Coming Soon", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MailToButton_Click(sender As Object, e As EventArgs) Handles MailToButton.Click
        MessageBox.Show("Welcome to our " & SName & ". This Mail feature is Coming Soon", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BlockButton_Click(sender As Object, e As EventArgs) Handles BlockButton.Click

        'On Error Resume Next

        If Me.SupplierGridLookUpEdit1.EditValue > -1 Then

            Dim NewOrder As String = String.Empty
            Dim BC As String = ReadStringData("Select ProgramCode From Supplier Where SupplierId=" & SupplierGridLookUpEdit1.EditValue, cnn)

            Dim ABC As String = Now.Year.ToString.Substring(2) & BC.ToString()
            Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [Order] Where ProgramNo Like '%" & ABC & "%'", cnn)
            Dim XYZ1 As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(ProgramNo),0,CHARINDEX('L',REVERSE(ProgramNo)))) AS INT )) From [MasterOrderDetails] Where ProgramNo Like '%" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then
                NewOrder = "B" & Now.Year.ToString.Substring(2) & BC.ToString() & (Val(XYZ) + 1).ToString()
            Else
                NewOrder = "B" & Now.Year.ToString.Substring(2) & BC.ToString() & (Val(XYZ1) + 1).ToString()
            End If

            Me.MasterOrderDataSet.MasterOrderDetails.ProgramNoColumn.DefaultValue = NewOrder
            Me.MasterOrderDataSet.MasterOrderDetails.SupplierIdColumn.DefaultValue = Me.SupplierGridLookUpEdit1.EditValue
            MasterOrderDataSet.MasterOrderDetails.CreatedOnColumn.DefaultValue = Today
            MasterOrderDataSet.MasterOrderDetails.IsAdvanceColumn.DefaultValue = True
            MasterOrderDetailsBindingSource.AddNew()

            Save()

        End If
    End Sub
End Class