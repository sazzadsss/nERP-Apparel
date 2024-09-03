Public Class frmAWSNew
    Dim Newflag As Boolean = False

    Private _IsMerchandising As Boolean
    Public Property IsMerchandising() As Boolean
        Get
            Return _IsMerchandising
        End Get
        Set(ByVal value As Boolean)
            _IsMerchandising = value
        End Set
    End Property

    Private Sub AccessoriesWorkOrderSheetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AccessoriesWorkOrderSheetBindingSource.EndEdit()
        Me.AccessoriesWorkOrderSheetDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AWS_DataSet)

    End Sub

    Private Sub frmAWSNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.AccBOMItemLookupNewTableAdapter.Fill(Me.AccBOMItemLookupNewDataSet.AccBOMItemLookupNew)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, My.Settings.AccDepartmentId)
        Me.AccOrderLookupTableAdapter.FillByUserId(Me.AccessoriesBookingNewDataSet.AccOrderLookup, UserId)

        If IsMerchandising = True Then
            Me.AWSLookupTableAdapter.FillByUserId(Me.AWSLookupDataSet.AWSLookup, UserId)

            If CheckUserRights("Accessories Work Order [Merchandising]").CanEdit = False Then

                cmdAddNew.Enabled = False
                CmdEdit.Enabled = False
                CmdDelete.Enabled = False
                CmdShowHide.Enabled = False

            ElseIf CheckUserRights("Accessories Work Order [Merchandising]").CanDelete = False Then
                cmdAddNew.Enabled = True
                CmdEdit.Enabled = True
                CmdDelete.Enabled = False
                CmdShowHide.Enabled = False
            End If

        Else
            Me.AWSLookupTableAdapter.Fill(Me.AWSLookupDataSet.AWSLookup)

            If CheckUserRights("Accessories Work Order [Procurement]").CanEdit = False Then

                cmdAddNew.Enabled = False
                CmdEdit.Enabled = False
                CmdDelete.Enabled = False
                CmdShowHide.Enabled = False

            ElseIf CheckUserRights("Accessories Work Order [Procurement]").CanDelete = False Then
                cmdAddNew.Enabled = True
                CmdEdit.Enabled = True
                CmdDelete.Enabled = False
                CmdShowHide.Enabled = False
            End If

        End If

        Me.AccAmendmentHistoryTableAdapter.Fill(Me.AWS_DataSet.AccAmendmentHistory)
        Me.AccBookingLookupTableAdapter.FillByUserId(Me.AccBOMLookUpDataSet.AccBookingLookup, UserId)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)
        Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)


        Me.AWS_DataSet.AccessoriesWorkOrderSheet.IsApprovedColumn.DefaultValue = False
        Me.AWS_DataSet.AccessoriesWorkOrderSheet.IsCompleteColumn.DefaultValue = False
        Me.AWS_DataSet.AccessoriesWorkOrderSheet.UserIdColumn.DefaultValue = UserId
        Me.AWS_DataSet.AccessoriesWorkOrderSheet.IPAddressColumn.DefaultValue = GetIPAddress()

        Dim termCondition As String = "1. Goods must be AZO free. And Free from other harmful substance." & vbCrLf & "2. You are requested to delivery the goods by as per approved sample." & vbCrLf & "3. PI must be send within 24 Hours after receive booking." & vbCrLf & "4. Payment should be done through account pay cheque/BBLC." & vbCrLf & "5. Please take approval/confirmation before start bulk production." & vbCrLf & "6. Partial shipment is allowed." & vbCrLf & "7. If any claim comes from buyer supplier should take all responsibility"
        Me.AWS_DataSet.AccessoriesWorkOrderSheet.TermsConditionColumn.DefaultValue = termCondition

        Me.IsCancelCheckEdit.Checked = False
        Me.IsApprovedCheckEdit.Checked = False
        Me.BookingDateTimePicker.CustomFormat = " "
        'SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2

    End Sub


    Private Sub cmdInvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInvert.Click
        For Each drv As DataRowView In Me.AccessoresBookingDetailsBindingSource.List
            If drv!IsSelected = True Then
                drv!IsSelected = False
            ElseIf drv!IsSelected = False Then
                drv!IsSelected = True
            End If
        Next
        Me.AccessoresBookingDetailsBindingSource.ResetBindings(True)
    End Sub

    Private Sub AllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCheckBox.CheckedChanged
        For Each drv As DataRowView In Me.AccessoresBookingDetailsBindingSource.List
            drv!IsSelected = AllCheckBox.Checked
        Next
        Me.AccessoresBookingDetailsBindingSource.ResetBindings(True)
    End Sub

    Private Sub CmdAccBOMNoShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAccBOMNoShow.Click

        'On Error Resume Next
        GMQtyTextEdit.Text = ReadData("select sum(OrderQuantity)  from OrderDetails where OrderId=(Select OrderId from AccessoriesBooking Where AccessoriesBookingId =" & AccBOMNoLookUpEdit.EditValue & ")", cnn)
        Dim BookingTime As DateTime = ReadDateData("Select BookingDate from AccessoriesBooking Where AccessoriesBookingId = " & AccBOMNoLookUpEdit.EditValue, cnn)
        Dim Check As Integer = ReadIntegerData("Select AccessoriesBookingId from AccessoriesBooking Where BookingDate is not null And AccessoriesBookingId = " & AccBOMNoLookUpEdit.EditValue, cnn)

        If Check > 0 Then

            Me.BookingDateTimePicker.CustomFormat = "dd-MMM-yy"
            Me.BookingDateTimePicker.Text = BookingTime
        Else

            Me.BookingDateTimePicker.CustomFormat = " "
        End If

        Me.AccessoresBookingDetailsTableAdapter.FillByCompleteAndApprove(Me.AccessoriesBookingNewDataSet.AccessoresBookingDetails, AccBOMNoLookUpEdit.EditValue)

    End Sub

    Private Sub CmdAWSNoShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAWSNoShow.Click

        Me.AccessoriesWorkOrderSheetTableAdapter.FillByAwsId(Me.AWS_DataSet.AccessoriesWorkOrderSheet, AWSNoLookUpEdit.EditValue)
        Me.AccessoriesWorkOrderSheetDetailsTableAdapter.Fill(Me.AWS_DataSet.AccessoriesWorkOrderSheetDetails, AWSNoLookUpEdit.EditValue)

    End Sub

    Private Sub CmdGetSelectedData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGetSelectedData.Click

        For Each drv As DataRowView In Me.AccessoresBookingDetailsBindingSource.List

            If drv!IsSelected = True Then


                Dim TTLAlreadyOrQty As Decimal = ReadData("Select ISNULL(Sum(OrderQuantity),0) From AccessoriesWorkOrderSheetDetails Where AccessoriesBookingDetailsId=" & drv!AccessoriesBookingDetailsId, cnn)
                Dim BalQty As Decimal = ReadData("Select SUM(ISNULL(BookingQuantity,0)) From AccessoresBookingDetails  Where AccessoriesBookingDetailsId=" & drv!AccessoriesBookingDetailsId, cnn) - TTLAlreadyOrQty

                If BalQty > 0 Then

                    Dim newRow As AWS_DataSet.AccessoriesWorkOrderSheetDetailsRow = Me.AWS_DataSet.AccessoriesWorkOrderSheetDetails.NewRow()
                    newRow.AWSId = Me.AWSIdSpinEdit.Value
                    'Dim TTLAWSQty As Decimal = ReadData("Select Sum(OrderQuantity) From AccessoriesWorkOrderSheetDetails Where AccessoriesBookingDetailsId= " & drv!AccessoriesBookingDetailsId, cnn)
                    newRow.OrderQuantity = BalQty 'drv!BookingQuantity
                    newRow.UnitPrice = drv!UnitPrice
                    newRow.UnitId = drv!BookingUnitId
                    newRow.Remarks = drv!Remarks
                    newRow.AccessoriesBookingDetailsId = drv!AccessoriesBookingDetailsId

                    Me.AWS_DataSet.AccessoriesWorkOrderSheetDetails.Rows.Add(newRow)

                End If


            End If

        Next


    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click

        If cmdAddNew.Text = "&New" Then

            cmdAddNew.Text = "&Save"

            Me.AccessoriesWorkOrderSheetBindingSource.AddNew()

            NewFlag = True





        Else
            If Newflag = True Then

                Dim ABC As String = Now.Year.ToString.Substring(2) & "AWS"
                Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(AWSNo),0,CHARINDEX('S',REVERSE(AWSNo))))) From [AccessoriesWorkOrderSheet] Where AWSNo Like '" & ABC & "%'", cnn)

                Dim NewOrder As String = ABC & (Val(XYZ) + 1).ToString("0000")
                AWSNoTextEdit.Text = NewOrder

            End If

            Save()

            If Me.AccessoriesWorkOrderSheetBindingSource.Position > -1 Then
                Dim row As AWS_DataSet.AccessoriesWorkOrderSheetRow
                row = CType(CType(Me.AccessoriesWorkOrderSheetBindingSource.Current, DataRowView).Row, AWS_DataSet.AccessoriesWorkOrderSheetRow)
                Me.AWSLookupTableAdapter.FillByUserId(Me.AWSLookupDataSet.AWSLookup, UserId)
                Me.AWSNoLookUpEdit.EditValue = row.AWSId

            End If


            cmdAddNew.Text = "&New"

        End If

    End Sub

    Private Sub Save()

        Try


            Me.Validate()
            Me.AccessoriesWorkOrderSheetBindingSource.EndEdit()
            Me.AccessoriesWorkOrderSheetDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AWS_DataSet)

            MessageBox.Show("Your Data is Successfully Updated......... ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
       

    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click

        If CmdEdit.Text = "&Edit" Then

            If IsApprovedCheckEdit.Checked Then
                MessageBox.Show("Approved Work Sheet doesn't allow to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            CmdEdit.Text = "&Update"

        Else

            Dim ZeroPriceCount As Integer = 0

            If Me.AccessoriesWorkOrderSheetDetailsBindingSource.Position > -1 Then

                Dim i As Integer = 0
                For Each drv As DataRowView In Me.AccessoriesWorkOrderSheetDetailsBindingSource.List

                    If CType(GridView1.GetRowCellDisplayText(i, colUnitPrice1), Double) = 0.0000 Then
                        ZeroPriceCount = ZeroPriceCount + 1
                    End If
                    i = i + 1

                Next


                If ZeroPriceCount > 0 Then
                    MessageBox.Show("Not Saved, Because, Zero Price is not allowed in AWS Sheet.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit Sub
                End If

            End If

            Save()

            CmdEdit.Text = "&Edit"

        End If
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If AccessoriesWorkOrderSheetBindingSource.Position = -1 Then
            Exit Sub
        End If

        If IsApprovedCheckEdit.Checked Then
            MessageBox.Show("Approved Work Sheet doesn't allow to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgBoxResult.Yes Then

            AccessoriesWorkOrderSheetBindingSource.RemoveCurrent()

            'MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Exit Sub

        End If
    End Sub


    Private Sub CmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.IsCancelCheckEdit.Checked = False
        Me.IsApprovedCheckEdit.Checked = True
        Me.AccessoriesWorkOrderSheetTableAdapter.Fill(Me.AWS_DataSet.AccessoriesWorkOrderSheet)


        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2

    End Sub

   

    Private Sub CmdAccBOMRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAccBOMRefresh.Click

        'If SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1 Then
        '    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2

        'Else
        '    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

        'End If

        Me.AccBookingLookupTableAdapter.FillByUserId(Me.AccBOMLookUpDataSet.AccBookingLookup, UserId)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)
        Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)


    End Sub
  

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click


        With frmAccessoriesWorkOrderSheetPrint

            .AWSId = Me.AWSNoLookUpEdit.EditValue
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub CmdShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdShowHide.Click
              
        If CmdShowHide.Text = "&Hide" Then
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            CmdShowHide.Text = "&Show"
        Else
            CmdShowHide.Text = "&Hide"
            SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        End If

    End Sub

End Class