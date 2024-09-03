Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class frmFloorRequisition
    Dim Addflag As Boolean = False
    Private Sub RequisitionFloorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionFloorBindingNavigatorSaveItem.Click

        Try
            If Addflag = False Then
                If PrintCount(Me.GridLookUpEdit1.Text, True) > 0 AndAlso Me.GridLookUpEdit1.Text <> String.Empty Then

                    Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
                    If UL <> 1 Then
                        MessageBox.Show("Not allowed to print a already printed Floor Requisition", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        GoTo Line1
                    End If

                End If
            End If

Line1:

            If Addflag = True Then

                Dim ABC As String = "FR" & Now.Year.ToString.Substring(2)
                'Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(CuttingNo),0,CHARINDEX('C',REVERSE(CuttingNo))))AS Integer)) From CuttingProductionNew Where CuttingNo Like '" & ABC & "%'", cnn)
                Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(RequisitionNo),0,CHARINDEX('-',REVERSE(RequisitionNo))))AS Integer)) From RequisitionFloor  Where RequisitionNo Like '" & ABC & "%'", cnn)

                Dim NewOrder As String = "FR" & Now.Year.ToString.Substring(2) & "-" & (XYZ + 1).ToString("00000")
                RequisitionNoTextBox.Text = NewOrder

                Me.Validate()
                Me.RequisitionFloorBindingSource.EndEdit()
                Me.RequisitionFloorDetailsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.RequisitionFloorDataSet)

                Me.RequisitionFloorLookupTableAdapter.FillByDepartmentId(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookUp, DepartmentId)

                Dim row As RequisitionFloorDataSet.RequisitionFloorRow
                row = CType(CType(Me.RequisitionFloorBindingSource.Current, DataRowView).Row, RequisitionFloorDataSet.RequisitionFloorRow)

                GridLookUpEdit1.EditValue = row.RequistionFloorId

                Addflag = False

            End If

            Me.Validate()
            Me.RequisitionFloorBindingSource.EndEdit()
            Me.RequisitionFloorDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RequisitionFloorDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FinishFabricBookingLookUpTableAdapter.Fill(Me.FFBLookupDataSet.FinishFabricBookingLookUp)
        Me.RequisitionFloorLookupTableAdapter.FillByDepartmentId(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookUp, DepartmentId)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentLookupDataSet.Department)
        Me.RequisitionFloorDetailsTableAdapter.Fill(Me.RequisitionFloorDataSet.RequisitionFloorDetails)
        Me.RequisitionFloorDataSet.RequisitionFloor.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.PrintingMediaTableAdapter.FillDepartmentId(Me.PrintingMediaDataSet.PrintingMedia, ItemDepartmentIdGridLookUpEdit.EditValue)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, ItemDepartmentIdGridLookUpEdit.EditValue)

        If CheckUserRights("Floor Requisition").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            RequisitionFloorBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Floor Requisition").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False
            RequisitionFloorBindingNavigatorSaveItem.Enabled = True

        End If

        PopulateAccBookingDetails()

    End Sub
    Private Sub PopulateAccBookingDetails()

        With BookingDetailsIdGridLookUpEdit
            .ForceInitialize()
            .Properties.DataSource = VBookingLookupBindingSource
            .Properties.DisplayMember = "ItemDetails"
            .Properties.ValueMember = "ItemId"
            .Properties.View.OptionsBehavior.AutoPopulateColumns = False
            .Properties.View.BestFitColumns()
            .Properties.PopupFormWidth = 300
        End With

        Dim col1 As GridColumn = BookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("ItemDetails")
        'Dim col2 As GridColumn = BookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("ItemId")
        col1.VisibleIndex = 0
        col1.Caption = "Item Details"
        'col2.VisibleIndex = 1
        'col2.Caption = "ItemId"

    End Sub

    Private Sub ItemDepartmentIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDepartmentIdGridLookUpEdit.EditValueChanged


        On Error Resume Next
        Me.PrintingMediaTableAdapter.FillDepartmentId(Me.PrintingMediaDataSet.PrintingMedia, ItemDepartmentIdGridLookUpEdit.EditValue)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, ItemDepartmentIdGridLookUpEdit.EditValue)

        'If GarmentsStoreId = ItemDepartmentIdGridLookUpEdit.EditValue Then
        '    'MessageBox.Show("GarmentStoreId" & GarmentsStoreId & "ItemDept:" & ItemDepartmentIdGridLookUpEdit.EditValue)
        '    PopulateAccBookingDetails()
        'End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.RequisitionFloorBindingSource.AddNew()

        Me.Addflag = True


    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        On Error Resume Next
        Me.RequisitionFloorTableAdapter.Fill(Me.RequisitionFloorDataSet.RequisitionFloor, GridLookUpEdit1.EditValue)
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If GridLookUpEdit1.EditValue > 0 Then
            frmRequisitionFloorPrint.FRID = GridLookUpEdit1.EditValue
            ShowForm(frmRequisitionFloorPrint)
        Else
            MessageBox.Show("Select Requisition No", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub ItemLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLookupGridLookUpEdit.EditValueChanged


    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.Caption = "Item Name" Then
            Dim row As RequisitionFloorDataSet.RequisitionFloorDetailsRow
            row = CType(CType(Me.RequisitionFloorDetailsBindingSource.Current, DataRowView).Row, RequisitionFloorDataSet.RequisitionFloorDetailsRow)
            row.UnitId = ReadIntegerData("Select UnitId From ItemList Where ItemId=" & row.ItemId, cnn)
        End If
    End Sub

    Private Sub FinishFabricBookingIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles FinishFabricBookingIdGridLookUpEdit.EditValueChanged

        On Error Resume Next


        If ItemDepartmentIdGridLookUpEdit.EditValue = GarmentsStoreId Then
            'Dim row As DataRowView = TryCast(BookingDetailsIdGridLookUpEdit.Properties.GetRowByKeyValue(BookingDetailsIdGridLookUpEdit.EditValue), DataRowView)
            'MsgBox(row.Item("t_1"))
            'Dim edit = TryCast(sender, GridLookUpEdit)
            'Dim dr As DataRow = (TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)).Row
            Dim PrgNo As String = ReadStringData("Select ProgramNo From FinishFabricBooking Where FinishFabricBookingId=" & FinishFabricBookingIdGridLookUpEdit.EditValue, cnn)
            Me.VBookingLookupTableAdapter.FillByProgramNo2(Me.BookingDataSet.vBookingLookup, GarmentsStoreId, PrgNo)
        End If


    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If Me.RequisitionFloorBindingSource.Position > -1 Then

            Dim row As RequisitionFloorDataSet.RequisitionFloorRow
            row = CType(CType(Me.RequisitionFloorBindingSource.Current, DataRowView).Row, RequisitionFloorDataSet.RequisitionFloorRow)

            Dim newRow = CType(Me.RequisitionFloorDataSet.RequisitionFloorDetails.NewRow(), RequisitionFloorDataSet.RequisitionFloorDetailsRow)
            newRow.RequisitionFloorId = row.RequistionFloorId
            newRow.ItemId = Me.BookingDetailsIdGridLookUpEdit.EditValue
            newRow.UnitId = ReadIntegerData("Select UnitId From ItemList Where ItemId=" & Me.BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            newRow.RequisitionQuantity = 0

            Me.RequisitionFloorDataSet.RequisitionFloorDetails.Rows.Add(newRow)

        End If


    End Sub

    Private Sub BookingDetailsIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BookingDetailsIdGridLookUpEdit.EditValueChanged

    End Sub
End Class