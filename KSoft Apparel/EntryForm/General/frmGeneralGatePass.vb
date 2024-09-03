Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns

Public Class frmGeneralGatePass
    Private AddFlag As Boolean
    Private DeleteFlag As Boolean = False
    Private Sub GeneralGatePassBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

        Save()

    End Sub
    Private Sub Save()

        Try

            If DeleteFlag = False Then
                Dim row1 As GeneralGatePassDataSet.GeneralGatePassRow
                row1 = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

                row1.UserId = UserId
                row1.ModifiedOn = Today()
            End If


            Me.Validate()
            Me.GeneralGatePassBindingSource.EndEdit()
            Me.GeneralGatePassDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GeneralGatePassDataSet)
            Me.GGatePassLookupTableAdapter.Fill(Me.GGatePassLookupDataSet.GGatePassLookup, DepartmentId)

            If Addflag = True Then
                Dim row As GeneralGatePassDataSet.GeneralGatePassRow
                row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

                GridLookUpEdit1.EditValue = row.GeneralGatePassId
                AddFlag = False


            End If

            If DepartmentId = ExportDepartmentId Then

                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("InsertShipmentInfoFromDelChallan", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ChallanNo", ChallanNoGridLookUpEdit.Text)
                    cmd.ExecuteNonQuery()

                End Using

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub frmGeneralGatePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserLookupDataSet.UserLookup' table. You can move, or remove it, as needed.
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

        Me.PrintingDeliveryChallanLookupTableAdapter.Fill(Me.PrintingDeliveryChallanLookupDataSet.PrintingDeliveryChallanLookup)
        Me.EmbDeliveryChallanLookupTableAdapter.Fill(Me.EmbDeliveryChallanLookupDataSet.EmbDeliveryChallanLookup)
        Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)
        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)
        Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
        Me.MiscChallanLookupTableAdapter.Fill(Me.MiscChallanLookupDataSet.MiscChallanLookup)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.GGatePassLookupTableAdapter.Fill(Me.GGatePassLookupDataSet.GGatePassLookup, DepartmentId)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.GeneralGatePassDetailsTableAdapter.Fill(Me.GeneralGatePassDataSet.GeneralGatePassDetails)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.GeneralGatePassDataSet.GeneralGatePass.DepartmentIdColumn.DefaultValue = DepartmentId

        If CheckUserRights("General Gate Pass").CanEdit = False Then

            NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False

        ElseIf CheckUserRights("General Gate Pass").CanDelete = False Then

            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False

        End If

        If DepartmentId = GreyFabricStoreId Then
            GreyStoreChallanLookup()
        ElseIf DepartmentId = FinishFabricStoreId Then
            FinishFabricChallanLookup()
        ElseIf DepartmentId = KnittingDeliveryId Then
            GFIDeliveryChallanLookup()
        ElseIf DepartmentId = CuttingDepartmentId Then
            'GetMiscDeliveryChallan(CuttingDepartmentId)
            GetCuttingDeliveryChallan()
        ElseIf DepartmentId = PrintingDepartmentId Then
            'GetMiscDeliveryChallan(PrintingDepartmentId)
            GetPrintDeliveryChallan()
        ElseIf DepartmentId = EmbroideryDepartmentId Then
            'GetMiscDeliveryChallan(EmbroideryDepartmentId)
            GetEmbDeliveryChallan()
        ElseIf DepartmentId = YarnDyeingDepartmentId Then
            GetMiscDeliveryChallan(YarnDyeingDepartmentId)
        ElseIf DepartmentId = MiscDepartmentId Then
            GetMiscDeliveryChallan(MiscDepartmentId)
        ElseIf DepartmentId = ExportDepartmentId Then
            GetExportDeliveryChallan(ExportDepartmentId)
        ElseIf DepartmentId = SewingDepartmentId Then
            GetSewingDeliveryChallan()
        Else
            StoreChallanLookup()
        End If

    End Sub

    Private Sub ChallanLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ChallanLinkLabel.LinkClicked

        If DepartmentId = GreyFabricStoreId Then
            GetGreyChallanDetails()
        ElseIf DepartmentId = FinishFabricStoreId Then
            GetFinishChallanDetails()
        ElseIf DepartmentId = KnittingDeliveryId Then
            GetKnittingChallanDetails()
        ElseIf DepartmentId = CuttingDepartmentId Then
            GetMiscChallanDetails(CuttingDepartmentId)
        ElseIf DepartmentId = PrintingDepartmentId Then
            GetMiscChallanDetails(PrintingDepartmentId)
        ElseIf DepartmentId = EmbroideryDepartmentId Then
            GetMiscChallanDetails(EmbroideryDepartmentId)
        ElseIf DepartmentId = YarnDyeingDepartmentId Then
            GetMiscChallanDetails(YarnDyeingDepartmentId)
        ElseIf DepartmentId = MiscDepartmentId Then
            GetMiscChallanDetails(MiscDepartmentId)
        ElseIf DepartmentId = ExportDepartmentId Then
            GetExportChallanDetails(ExportDepartmentId)
        ElseIf Departmentid = SewingDepartmentId Then
            ChallanDateDateEdit.EditValue = ReadDateData("Select ChallanDate From SewingDelivery Where ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'", cnn)
        Else
            GetChallanDetails()
        End If

    End Sub

    Private Sub GetCuttingDeliveryChallan()
        'Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryChallanLookup)
        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = CuttingDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub
    Private Sub GetSewingDeliveryChallan()
        'Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryChallanLookup)
        Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = SewingDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub
    Private Sub GetEmbDeliveryChallan()

        Me.EmbDeliveryChallanLookupTableAdapter.Fill(Me.EmbDeliveryChallanLookupDataSet.EmbDeliveryChallanLookup)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = EmbDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub
    Private Sub GetPrintDeliveryChallan()

        Me.PrintingDeliveryChallanLookupTableAdapter.Fill(Me.PrintingDeliveryChallanLookupDataSet.PrintingDeliveryChallanLookup)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = PrintingDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub
    Private Sub GetChallanDetails()

        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            'On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From Issue Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DepartmentId, cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            ChallanDateDateEdit.Text = ReadDateData("Select Max(IssueDate) From Issue Where ChallanNo='" & ChallanNoGridLookUpEdit.Text & "' And DepartmentId=" & DepartmentId, cnn)
            row.Attention = ReadStringData("Select Top 1 Attention From Issue Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DepartmentId, cnn)

            'Save()

            'Try
            '    Using connection As New SqlConnection(cnn)

            '        Dim sqlstring As String = "Select ItemId,(Select ItemName From ItemList where ItemList.ItemId=Issue.ItemId) as ItemName,(Select UnitId From ItemList Where ItemId=Issue.ItemId) as UnitId, IssueQuantity From Issue Where DepartmentId=" & DepartmentId & "And IssueQuantity > 0 And  ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'"

            '        Dim command As New SqlCommand(sqlstring, connection)

            '        command.Connection.Open()
            '        command.ExecuteNonQuery()

            '        Dim reader As SqlDataReader = command.ExecuteReader()

            '        While reader.Read()

            '            Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '            newRow.GeneralGatePassId = row.GeneralGatePassId
            '            newRow.ItemId = reader("ItemId").ToString()
            '            newRow.ItemName = reader("ItemName").ToString()
            '            newRow.UnitId = reader("UnitId")
            '            newRow.Quantity = reader("IssueQuantity").ToString()
            '            newRow.Remarks = "-"


            '            Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)

            '        End While

            '        reader.Close()

            '    End Using
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try


        End If

    End Sub


    Private Sub GetGreyChallanDetails()
        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From GreyFabricReceiveIssue Where ChallanNo='" & row.ChallanNo & "'", cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            row.ChallanDate = ReadDateData("Select Max(ChallanDate) From GreyFabricReceiveIssue Where ChallanNo='" & row.ChallanNo & "'", cnn)

            'Save()

            'Using connection As New SqlConnection(cnn)

            '    Dim sqlstring As String = "Select ItemId,(Select ItemName From ItemList where ItemList.ItemId=Issue.ItemId) as ItemName,(Select UnitId From ItemList Where ItemId=Issue.ItemId) as UnitId, IssueQuantity From Issue Where DepartmentId=" & DepartmentId & "And IssueQuantity > 0 And  ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'"

            '    Dim command As New SqlCommand(sqlstring, connection)

            '    command.Connection.Open()
            '    command.ExecuteNonQuery()

            '    Dim reader As SqlDataReader = command.ExecuteReader()

            '    While reader.Read()

            '        Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '        newRow.GeneralGatePassId = row.GeneralGatePassId
            '        newRow.ItemId = reader("ItemId").ToString()
            '        newRow.ItemName = reader("ItemName").ToString()
            '        newRow.UnitId = reader("UnitId").ToString()
            '        newRow.Quantity = reader("IssueQuantity").ToString()
            '        newRow.Remarks = "-"


            '        Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)

            '    End While

            '    reader.Close()

            'End Using

        End If
    End Sub

    Private Sub GetFinishChallanDetails()

        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From FinishFabricReceiveIssue Where ChallanNo='" & row.ChallanNo & "'", cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            row.ChallanDate = ReadDateData("Select Max(ChallanDate) From FinishFabricReceiveIssue Where ChallanNo='" & row.ChallanNo & "'", cnn)

            'Save()

            'Using connection As New SqlConnection(cnn)

            '    Dim sqlstring As String = "Select ItemId,(Select ItemName From ItemList where ItemList.ItemId=Issue.ItemId) as ItemName,(Select UnitId From ItemList Where ItemId=Issue.ItemId) as UnitId, IssueQuantity From Issue Where DepartmentId=" & DepartmentId & "And IssueQuantity > 0 And  ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'"

            '    Dim command As New SqlCommand(sqlstring, connection)

            '    command.Connection.Open()
            '    command.ExecuteNonQuery()

            '    Dim reader As SqlDataReader = command.ExecuteReader()

            '    While reader.Read()

            '        Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '        newRow.GeneralGatePassId = row.GeneralGatePassId
            '        newRow.ItemId = reader("ItemId").ToString()
            '        newRow.ItemName = reader("ItemName").ToString()
            '        newRow.UnitId = reader("UnitId").ToString()
            '        newRow.Quantity = reader("IssueQuantity").ToString()
            '        newRow.Remarks = "-"


            '        Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)

            '    End While

            '    reader.Close()

            'End Using

        End If
    End Sub

    Private Sub GetKnittingChallanDetails()

        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From GFIDelivery Where GFIChallanNo='" & row.ChallanNo & "'", cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            row.ChallanDate = ReadDateData("Select Max(GFIDate) From GFIDelivery Where GFIChallanNo='" & row.ChallanNo & "'", cnn)

            'Save()

            'Using connection As New SqlConnection(cnn)

            '    Dim sqlstring As String = "Select ItemId,(Select ItemName From ItemList where ItemList.ItemId=Issue.ItemId) as ItemName,(Select UnitId From ItemList Where ItemId=Issue.ItemId) as UnitId, IssueQuantity From Issue Where DepartmentId=" & DepartmentId & "And IssueQuantity > 0 And  ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'"

            '    Dim command As New SqlCommand(sqlstring, connection)

            '    command.Connection.Open()
            '    command.ExecuteNonQuery()

            '    Dim reader As SqlDataReader = command.ExecuteReader()

            '    While reader.Read()

            '        Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '        newRow.GeneralGatePassId = row.GeneralGatePassId
            '        newRow.ItemId = reader("ItemId").ToString()
            '        newRow.ItemName = reader("ItemName").ToString()
            '        newRow.UnitId = reader("UnitId").ToString()
            '        newRow.Quantity = reader("IssueQuantity").ToString()
            '        newRow.Remarks = "-"


            '        Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)

            '    End While

            '    reader.Close()

            'End Using

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 






    End Sub



    Private Sub StoreChallanLookup()

        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

        Me.ChallanLookupIssuedIssueTableAdapter.Fill(Me.ChallanLookupIssuedDataSet.ChallanLookupIssued, DepartmentId)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = ChallanLookupIssuedBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        ' Add two columns in the dropdown:
        ' A column to display the values of the ProductID field;
        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("IssueDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"

        ' Set column widths according to their contents.
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300


    End Sub

    Private Sub GreyStoreChallanLookup()

        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

        Me.GreyFabricDeliveryChallanLookupTableAdapter.Fill(Me.GreigeFabricDeliveryChallanLookupDataSet.GreyFabricDeliveryChallanLookup)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = GreyFabricDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        ' Add two columns in the dropdown:
        ' A column to display the values of the ProductID field;
        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "ChallanNo"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "ChallanDate"

        ' Set column widths according to their contents.
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub

    Private Sub FinishFabricChallanLookup()
        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

        Me.FinishFabricDeliveryChallanLookupTableAdapter.Fill(Me.FinishFabricDeliveryChallanLookupDataSet.FinishFabricDeliveryChallanLookup, False)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = FinishFabricDeliveryChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        ' Add two columns in the dropdown:
        ' A column to display the values of the ProductID field;
        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "ChallanNo"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "ChallanDate"

        ' Set column widths according to their contents.
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub

    Private Sub GFIDeliveryChallanLookup()
        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

        Me.GFIDeliveryLookupTableAdapter.Fill(Me.GFIDeliveryDataSet.GFIDeliveryLookup)


        With ChallanNoGridLookUpEdit
            .Properties.DataSource = GFIDeliveryLookupBindingSource
            .Properties.DisplayMember = "GFIChallanNo"
            .Properties.ValueMember = "GFIChallanNo"
        End With

        ' Add two columns in the dropdown:
        ' A column to display the values of the ProductID field;
        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("GFIChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("GFIDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"

        ' Set column widths according to their contents.
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300

    End Sub
    Private Sub GetMiscDeliveryChallan(ByVal DptId As Integer)
        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)


        Me.MiscChallanLookupTableAdapter.FillByDepartmentId(Me.MiscChallanLookupDataSet.MiscChallanLookup, DptId)


        With ChallanNoGridLookUpEdit
            .Properties.DataSource = MiscChallanLookupBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        ' Add two columns in the dropdown:
        ' A column to display the values of the ProductID field;
        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"

        ' Set column widths according to their contents.
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300
    End Sub

    Private Sub GetExportDeliveryChallan(ByVal DptId As Integer)     
        Me.DeliveryChallanLookUpTableAdapter.FillByDepartmentId(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp, DptId)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = DeliveryChallanLookUpBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "ChallanNo"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300
    End Sub


    Private Sub GetMiscChallanDetails(ByVal DptId As Integer)

        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            'On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From MiscDelivery Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DptId, cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            row.ChallanDate = ReadDateData("Select Max(ChallanDate) From MiscDelivery Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DptId, cnn)

            'Save()

            'Using connection As New SqlConnection(cnn)

            '    Dim MDID As Integer = ReadIntegerData("Select MiscDeliveryId From MiscDelivery Where ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'", cnn)
            '    Dim sqlstring As String = "Select Description, QTY, UnitId,Remarks From MiscDeliveryDetails Where MiscDeliveryId=" & MDID

            '    Dim command As New SqlCommand(sqlstring, connection)

            '    command.Connection.Open()
            '    command.ExecuteNonQuery()

            '    Dim reader As SqlDataReader = command.ExecuteReader()

            '    While reader.Read()
            '        'On Error Resume Next
            '        Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '        newRow.GeneralGatePassId = row.GeneralGatePassId
            '        'newRow.ItemId = reader("Description").ToString()
            '        newRow.ItemName = reader("Description").ToString()
            '        newRow.UnitId = reader("UnitId")
            '        newRow.Quantity = reader("QTY").ToString()
            '        newRow.Remarks = reader("Remarks").ToString()

            '        Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)

            '    End While

            '    reader.Close()

            'End Using

        End If

    End Sub

    Private Sub GetExportChallanDetails(ByVal DptId As Integer)

        If GeneralGatePassBindingSource.Position > -1 Then

            Dim row As GeneralGatePassDataSet.GeneralGatePassRow
            row = CType(CType(Me.GeneralGatePassBindingSource.Current, DataRowView).Row, GeneralGatePassDataSet.GeneralGatePassRow)

            'On Error Resume Next

            Dim SID As Integer = ReadIntegerData("Select Top 1 SupplierId From Delivery Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DptId, cnn)

            If SID > 0 Then
                row.SupplierId = SID
            End If

            row.ChallanDate = ReadDateData("Select Max(ChallanDate) From Delivery Where ChallanNo='" & row.ChallanNo & "' And DepartmentId=" & DptId, cnn)

            'Save()
            'Try
            '    Using connection As New SqlConnection(cnn)

            '        Dim MDID As Integer = ReadIntegerData("Select DeliveryId From Delivery Where ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'", cnn)
            '        Dim sqlstring As String = "Select OrderDetailsId, DeliveryQuantity, UnitId,Remarks From DeliveryDetails Where DeliveryId=" & MDID

            '        Dim command As New SqlCommand(sqlstring, connection)

            '        command.Connection.Open()
            '        command.ExecuteNonQuery()

            '        Dim reader As SqlDataReader = command.ExecuteReader()

            '        While reader.Read()

            '            Dim newRow As GeneralGatePassDataSet.GeneralGatePassDetailsRow = Me.GeneralGatePassDataSet.GeneralGatePassDetails.NewRow()
            '            newRow.GeneralGatePassId = row.GeneralGatePassId

            '            newRow.ItemName = ReadStringData("Select Details from OrderDetailsPOLookUp where OrderDetailsId='" & reader("OrderDetailsId").ToString & "'", cnn)
            '            newRow.UnitId = reader("UnitId")

            '            newRow.Quantity = reader("DeliveryQuantity").ToString()
            '            newRow.Remarks = reader("Remarks").ToString()


            '            Me.GeneralGatePassDataSet.GeneralGatePassDetails.Rows.Add(newRow)
            '        End While

            '        reader.Close()

            '    End Using
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try


        End If

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        MessageBox.Show("(Grey Fabric Store)," & vbCrLf & "(Finish Fabric Store)," & vbCrLf & "(General Store)," & vbCrLf & "(Knitting)," & vbCrLf & "(Cutting)," & vbCrLf & "(Printing)," & vbCrLf & "(Embroidery)," & vbCrLf & "(Yarn Dyeing)," & vbCrLf & "(Misc)," & vbCrLf & "(Export)" & vbCrLf & "Department Can Create Gate Pass Challan ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Me.GeneralGatePassTableAdapter.Fill(Me.GeneralGatePassDataSet.GeneralGatePass, GridLookUpEdit1.EditValue)
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

        If NewButton.Text = "&New" Then


            Me.NewButton.Text = "&Save"
            Me.EditButton.Enabled = False

            AddFlag = True
            Me.GeneralGatePassBindingSource.AddNew()

        Else

            Dim ABC As String = Now.Year.ToString.Substring(2) & "GP"
            Dim XYZ As String = ReadIntData("Select Max( CAST(REVERSE(SUBSTRING(REVERSE(GatePassNo),0,CHARINDEX('P',REVERSE(GatePassNo)))) AS INT)) From GeneralGatePass Where GatePassNo Like '" & ABC & "%'", cnn)

            Dim NewOrder As String = Now.Year.ToString.Substring(2) & "GP" & (Val(XYZ) + 1).ToString()

            GatePassNoTextEdit.Text = NewOrder

            Dim ChCount As Integer = ReadIntData("Select Count(ChallanNo) From GeneralGatePass Where ChallanNo='" & ChallanNoGridLookUpEdit.EditValue & "'", cnn)

            If ChCount > 0 Then
                MessageBox.Show("Duplicate Challan is not Allowed.")
                Exit Sub
            End If

            Save()

            Me.NewButton.Text = "&New"
            EditButton.Enabled = True
            DeleteButton.Enabled = True


        End If

    End Sub

    Private Sub GeneralGatePassBindingNavigator_RefreshItems(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If PrintCount(Me.ChallanNoGridLookUpEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select USER_LEVEL From [User] Where User_Id=" & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to edit a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:
        If Me.EditButton.Text = "&Edit" Then
            Me.EditButton.Text = "&Update"
            Me.NewButton.Enabled = False
        Else
            Me.EditButton.Text = "&Edit"
            Me.NewButton.Enabled = True
            Save()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GridLookUpEdit1.EditValue > 0 Then

            With frmGGatePassPrint
                .FRID = GridLookUpEdit1.EditValue
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With
        Else
            MessageBox.Show("Select GatePass No", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)
        Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
        Me.MiscChallanLookupTableAdapter.Fill(Me.MiscChallanLookupDataSet.MiscChallanLookup)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.GGatePassLookupTableAdapter.Fill(Me.GGatePassLookupDataSet.GGatePassLookup, DepartmentId)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.GeneralGatePassDetailsTableAdapter.Fill(Me.GeneralGatePassDataSet.GeneralGatePassDetails)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.GeneralGatePassDataSet.GeneralGatePass.DepartmentIdColumn.DefaultValue = DepartmentId
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Are you you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Me.GeneralGatePassDetailsBindingSource.Position = -1 Then
                Me.GeneralGatePassBindingSource.RemoveCurrent()
                DeleteFlag = True
                Save()
            Else
                MessageBox.Show("Please, delete Gatepass Details...")
            End If
        End If
    End Sub

    Private Sub ChallanNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChallanNoGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub GatePassNoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles GatePassNoTextEdit.EditValueChanged

    End Sub
End Class
