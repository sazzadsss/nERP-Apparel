Imports System.Data.SqlClient
Public Class frmSampleOrder
    Dim Addflag As Boolean = False
    Dim Getflag As Boolean = False

    Private _SampleReqNo As String
    Public Property SampleReqNo() As String
        Get
            Return _SampleReqNo
        End Get
        Set(ByVal value As String)
            _SampleReqNo = value
        End Set
    End Property
    Function SFBStatus() As Boolean

        Dim SFB As Boolean = False

        If Me.SampleRequestFinalDetailsBindingSource.Position > -1 Then

            Dim row As SampleRequestDataSet.SampleRequestFinalRow
            row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)

            Dim FFBCount As Integer = ReadIntData("Select COUNT(SampleRequestId) From SampleFabricBooking Where SampleRequestId=" & row.SampleRequestId, cnn)

            If FFBCount > 0 Then
                SFB = True
            Else
                SFB = False
            End If

        End If


        Return SFB

    End Function
    Private Sub frmSampleOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SRLookupByDivUserTableAdapter.Fill(Me.SampleRequestLookupDataSet.SRLookupByDivUser, UserId)
        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)
        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        'Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)


        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)

        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)

        'Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)
        'Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)
        'Me.SampleRequestFinalDetailsTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinalDetails)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, YarnStoreId)


        DisableFromControl(Me)


        If CheckUserRights("Sample Order").CanEdit = False Then

            NewButton.Enabled = False
            SaveButton.Enabled = False
            DeleteButton.Enabled = False
            RefreshButton.Enabled = False

        ElseIf CheckUserRights("Sample Order").CanDelete = False Then

            NewButton.Enabled = True
            SaveButton.Enabled = True
            DeleteButton.Enabled = False
            RefreshButton.Enabled = False

        End If



        '    '==============
        '    Dim connection As New SqlConnection(cnn)
        '    connection.Open()

        '    Dim cmd As SqlCommand = New SqlCommand("Select Distinct Style From SampleRequestFinal", connection)
        '    Dim reader As SqlDataReader = cmd.ExecuteReader()
        '    Dim list As New AutoCompleteStringCollection

        '    While reader.Read

        '        If reader.IsDBNull(0) = False Then

        '            list.Add(reader.Item("Style").ToString)

        '        End If

        '    End While

        '    reader.Close()


        '    StyleTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    StyleTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    StyleTextBox.AutoCompleteCustomSource = list

        '    connection.Close()
        '    '====================



    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&Add" Then

            StyleDataSet.Style.UserIdColumn.DefaultValue = UserId
            StyleDataSet.Style.ModifiedOnColumn.DefaultValue = Now()

            Me.SampleRequestFinalBindingSource.AddNew()
            Me.MasterProgramNoTextBox.Focus()

            'Generationg Sample Requst No 

            'Dim BC As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & BuyerIdGridLookUpEdit.EditValue, cnn)

            Dim ABC As String = Now.Year.ToString.Substring(2) & "SP"
            Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(RequestNo),0,CHARINDEX('P',REVERSE(RequestNo))))) From SampleRequestFinal Where RequestNo Like '" & ABC & "%'", cnn)
            Dim XYZ1 As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(SampleRequestNo),0,CHARINDEX('P',REVERSE(SampleRequestNo))))) From MasterOrderSampleStatus Where SampleRequestNo Like '" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ) + 1).ToString("0000")
                RequestNoTextEdit.Text = NewOrder
            Else
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ1) + 1).ToString("0000")
                RequestNoTextEdit.Text = NewOrder
            End If

            'End of Generating Sample Request No

            NewButton.Text = "&Save"
            NewButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            SaveButton.Enabled = False
            EnableFormControl(Me)

            Addflag = True
            Getflag = False


        Else


            'Generationg Sample Requst No , Generating Again to avoid conflict.

            Dim BC As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & BuyerGridLookUpEdit.EditValue, cnn)

            Dim ABC As String = Now.Year.ToString.Substring(2) & "SP"
            Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(RequestNo),0,CHARINDEX('P',REVERSE(RequestNo))))) From SampleRequestFinal Where RequestNo Like '" & ABC & "%'", cnn)
            Dim XYZ1 As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(SampleRequestNo),0,CHARINDEX('P',REVERSE(SampleRequestNo))))) From MasterOrderSampleStatus Where SampleRequestNo Like '" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ) + 1).ToString("0000")
                RequestNoTextEdit.Text = NewOrder
            Else
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ1) + 1).ToString("0000")
                RequestNoTextEdit.Text = NewOrder
            End If

            'End of Generating Sample Request No



            Save()

            If Getflag = True Then

                ExecuteQuery("UPDATE MasterOrderSampleStatus SET  IsReceived=1 Where SampleRequestNo='" & Me.SampleReqNo.ToString() & "'", cnn)

            End If

            'Getflag = False

            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Me.SampleRequestFinalBindingSource.Position > -1 Then

                Dim row As SampleRequestDataSet.SampleRequestFinalRow
                row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)

                GridLookUpEdit1.EditValue = row.SampleRequestId

            End If


            NewButton.Text = "&Add"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
            SaveButton.Enabled = True
            DisableFromControl(Me)
            Addflag = False
            Getflag = True
            'Save()



        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If SaveButton.Text = "&Edit" Then

            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            NewButton.Enabled = False
            EnableFormControl(Me)

            If SFBStatus() = True Then

                SampleFabricDataGridView.ReadOnly = True
                YarnAllocationSampleGridControl.Enabled = False
                CopyFabricButton.Enabled = False

            Else

                SampleFabricDataGridView.ReadOnly = False
                YarnAllocationSampleGridControl.Enabled = True
                CopyFabricButton.Enabled = True

            End If

            SaveButton.Text = "&Save"

        Else

            Dim TTLSampleQty As Integer = 0

            For Each drv As DataRowView In Me.SampleRequireQuantityBindingSource.List
                TTLSampleQty = TTLSampleQty + drv!Quantity
            Next

            SampleQuantitySpinEdit.Value = TTLSampleQty

            Save()

            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Addflag = False

            SaveButton.Text = "&Edit"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Edit
            NewButton.Enabled = True
            DisableFromControl(Me)


        End If

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        If SampleFabricBindingSource.Position > -1 Then
            MessageBox.Show("Delete Fabric Details", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        ElseIf SamplePrintColorBindingSource.Position > -1 Then
            MessageBox.Show("Delete PrintColor ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        ElseIf SampleRequireQuantityBindingSource.Position > -1 Then

            MessageBox.Show("Delete Require Quantity ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If



        MessageBox.Show("Are you sure you want to delete the booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If CType(MsgBoxResult.Yes, Boolean) = True Then

            SampleRequestFinalBindingSource.RemoveCurrent()

        Else

            Exit Sub

        End If



    End Sub




    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        'Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)
        Me.SRLookupByDivUserTableAdapter.Fill(Me.SampleRequestLookupDataSet.SRLookupByDivUser, UserId)
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged, GridLookUpEdit1.Closed

        If SRLookupByDivUserBindingSource.Position > -1 Then

            Me.SampleRequestFinalTableAdapter.FillBySampleRequestId(Me.SampleRequestDataSet.SampleRequestFinal, CType(GridLookUpEdit1.EditValue, Integer))
            Me.SampleRequestFinalDetailsTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleRequestFinalDetails, CType(GridLookUpEdit1.EditValue, Integer))
            Me.SampleFabricTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleFabric, CType(GridLookUpEdit1.EditValue, Integer))
            Me.SampleRequireQuantityTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleRequireQuantity, CType(GridLookUpEdit1.EditValue, Integer))
            Me.SamplePrintColorTableAdapter.FillBySRId(Me.SampleRequestDataSet.SamplePrintColor, CType(GridLookUpEdit1.EditValue, Integer))
            Me.YarnAllocationSampleTableAdapter.Fill(Me.SampleRequestDataSet.YarnAllocationSample, CType(GridLookUpEdit1.EditValue, Integer))


        End If

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RequestNoTextEdit.Text = String.Empty Then

            MessageBox.Show("Please, select a request no", "Request no Require", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If


        With frmSampleFabricBookingPrint

            .BookingNo = RequestNoTextEdit.Text
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()

        End With


    End Sub

    Private Sub SampleFabricDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SampleFabricDataGridView.CellEndEdit

        Dim ColName As String = SampleFabricDataGridView.Columns(SampleFabricDataGridView.CurrentCell.ColumnIndex).HeaderText


        Select Case ColName

            Case "IsDelivered"
                SampleFabricDataGridView.CurrentRow.Cells("DeliveredDate").Value = Today
                SampleFabricDataGridView.CurrentRow.Cells("Status").Value = "Delivered"
            Case "Delivered Date"
                SampleFabricDataGridView.CurrentRow.Cells("Status").Value = "Delivered"
            Case "Print Send"
                SampleFabricDataGridView.CurrentRow.Cells("Status").Value = "Send to Print"
            Case "Print Received"
                SampleFabricDataGridView.CurrentRow.Cells("Status").Value = "Received from Print"

            Case "Main Fabric"

                Dim row As SampleRequestDataSet.SampleRequestFinalRow
                row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)

                Dim row1 As SampleRequestDataSet.SampleFabricRow
                row1 = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleFabricRow)

                On Error Resume Next
                row.KnittingTypeId = row1.KnittingTypeId
                row.CompositionId = row1.CompositionId
                row.GSM = row1.FGSM

                ' Mahmud/100815 , For Grey Quantity 
                ' 1. GreyPercentage And GreyQuantity Column Added in SampleFabric (SQL) 
                ' 2. Changed SampleFabric Table in SampleRequestDataset.
                ' 3. And Sample Request(Interface).

            Case "Booking Quantity"

                Dim row As SampleRequestDataSet.SampleFabricRow
                row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleFabricRow)

                If row.IsGreyQuantityNull = False Then
                    SampleFabricDataGridView.CurrentRow.Cells("GreyQuantity").Value = row.BookingQuantity * (1 + row.GreyPercentage / 100)

                End If

            Case "Grey Percentage"
                Dim row As SampleRequestDataSet.SampleFabricRow
                row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleFabricRow)

                If row.IsBookingQuantityNull = False Then
                    SampleFabricDataGridView.CurrentRow.Cells("GreyQuantity").Value = row.BookingQuantity * (1 + row.GreyPercentage / 100)
                End If

                ' // End  Grey 

        End Select







    End Sub

    Private Sub IsFabricAvailableCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AgreedLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AgreedLinkLabel.LinkClicked
        CalcualteAgreedLeadTime()

    End Sub
    Private Sub CalcualteAgreedLeadTime()

        If SampleRequestFinalBindingSource.Position > -1 Then

            Dim row As SampleRequestDataSet.SampleRequestFinalRow
            row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)


            If Me.SampleRequestFinalDetailsBindingSource.Position > -1 Then

                For Each drv As DataRowView In Me.SampleRequestFinalDetailsBindingSource.List


                    If row.IsTrim = True AndAlso row.IsTrimAvailable = False Then

                        drv!AgreedLeadTime = 30

                    ElseIf drv!IsYds = True AndAlso drv!IsFabricAvailable = False Then

                        drv!AgreedLeadTime = 30

                    ElseIf drv!IsAOP = True AndAlso drv!IsFabricAvailable = False Then

                        drv!AgreedLeadTime = 30

                    Else

                        If row.IsPrint = True AndAlso drv!IsFabricAvailable = False Then
                            drv!AgreedLeadTime = 15
                        ElseIf row.IsPrint = True And drv!IsFabricAvailable = True Then
                            drv!AgreedLeadTime = 10
                        ElseIf row.IsPrint = False AndAlso drv!IsFabricAvailable = False Then
                            drv!AgreedLeadTime = 10
                        ElseIf row.IsPrint = False AndAlso drv!IsFabricAvailable = True Then
                            drv!AgreedLeadTime = 5
                        End If

                    End If

                    drv!ExSendDate = row.RequestDate.AddDays(drv!AgreedLeadTime)

                Next

            End If







        End If

    End Sub


    Private Sub SampleRequestFinalDetailsGridControl_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleRequestFinalDetailsGridControl.Enter
        Me.SampleRequestFinalBindingSource.EndEdit()
    End Sub

    Private Sub SampleFabricDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleFabricDataGridView.Enter
        Me.SampleRequestFinalBindingSource.EndEdit()
    End Sub

    Private Sub SamplePrintColorDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SamplePrintColorDataGridView.Enter
        Me.SampleRequestFinalBindingSource.EndEdit()
    End Sub

    Private Sub SampleRequireQuantityDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleRequireQuantityDataGridView.Enter
        Me.SampleRequestFinalBindingSource.EndEdit()
    End Sub

    Private Sub Save()

        Try


            Me.Validate()
            Me.SampleRequestFinalBindingSource.EndEdit()
            Me.SampleRequestFinalDetailsBindingSource.EndEdit()
            Me.SampleFabricBindingSource.EndEdit()
            Me.SamplePrintColorBindingSource.EndEdit()
            Me.YarnAllocationSampleBindingSource.EndEdit()

            Me.SampleRequestFinalTableAdapter.Update(Me.SampleRequestDataSet.SampleRequestFinal)
            Me.SampleRequestFinalDetailsTableAdapter.Update(Me.SampleRequestDataSet.SampleRequestFinalDetails)
            Me.SampleFabricTableAdapter.Update(Me.SampleRequestDataSet.SampleFabric)
            Me.SamplePrintColorTableAdapter.Update(Me.SampleRequestDataSet.SamplePrintColor)
            Me.SampleRequireQuantityTableAdapter.Update(Me.SampleRequestDataSet.SampleRequireQuantity)
            Me.YarnAllocationSampleTableAdapter.Update(Me.SampleRequestDataSet.YarnAllocationSample)

            'Me.TableAdapterManager.UpdateAll(Me.SampleRequestDataSet)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub Clear(ByVal table As DataTable)
        For Each r As DataRelation In table.ChildRelations
            Clear(r.ChildTable)
        Next
        table.Clear()
    End Sub


    Private Sub StyleIdGridLookUpEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StyleIdGridLookUpEdit.KeyDown

        If e.KeyData = Keys.F11 Then

            ShowMaster(frmStyle)

            If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                GetStyleDetails(frmStyle.StyleId)


            End If


        End If

    End Sub

    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged

        'If SampleUpdateCheckEdit.Checked Then
        '    StyleTextEdit.Text = StyleIdGridLookUpEdit.Text
        'End If
        On Error Resume Next
        Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, StyleIdGridLookUpEdit.EditValue)
        Me.BuyerGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)
    End Sub



    Private Sub GetDataLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GetDataLinkLabel.LinkClicked

        If SampleFabricBindingSource.Position = -1 Then

            For Each drv As DataRowView In SampleRequestFinalDetailsBindingSource.List

                'If drv!IsFabricAvailable = False Then

                On Error Resume Next
                Dim newRow As SampleRequestDataSet.SampleFabricRow = Me.SampleRequestDataSet.SampleFabric.NewRow()

                newRow.SampleRequestId = drv!SampleRequestId
                newRow.KnittingTypeId = drv!KnittingTypeId
                newRow.CompositionId = drv!CompositionId
                newRow.FGSM = drv!GSM
                newRow.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & drv!FabricColorId, cnn)
                newRow.ELD = drv!ELD
                newRow.IsFabricAvailable = drv!IsFabricAvailable
                newRow.MainFabric = True
                newRow.Remarks = "-"

                Me.SampleRequestDataSet.SampleFabric.Rows.Add(newRow)


                'End If


            Next


        End If

    End Sub

    Private Sub SampleFabricDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SampleFabricDataGridView.DataError
        On Error Resume Next

    End Sub


    Private Sub frmSampleOrder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F11 Then

            If SampleRequestFinalDetailsGridControl.IsFocused Then

                If SampleRequestFinalDetailsGridView.FocusedColumn.AbsoluteIndex = colFabricColorId.AbsoluteIndex Then

                    frmFabricColor.ShowDialog()

                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

                        Dim row As SampleRequestDataSet.SampleRequestFinalDetailsRow
                        row = CType(CType(Me.SampleRequestFinalDetailsBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalDetailsRow)

                        row.FabricColorId = frmFabricColor.FabricColorId

                        'SampleRequestFinalDetailsBindingSource.ResetBindings(True)

                    End If


                End If


            End If

        End If



    End Sub



    Private Sub StyleNoLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles StyleNoLinkLabel.LinkClicked


        Dim row As SampleRequestDataSet.SampleRequestFinalRow
        row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)


        With frmStyle


            If row.IsStyleIdNull = False Then
                .StyleId = StyleIdGridLookUpEdit.EditValue
            End If

            .ShowDialog()

        End With


        'If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then
        '    Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        '    StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId
        'End If


        If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then


            GetStyleDetails(frmStyle.StyleId)


        End If


    End Sub

    Private Sub GetStyleDetails(ByVal SID As Integer)

        If Me.SampleRequestFinalBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As SampleRequestDataSet.SampleRequestFinalRow
        row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)


        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)


        StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId
        WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select ISNULL(WashTypeId,-1) From Style Where StyleId=" & SID, cnn)
        BuyerGridLookUpEdit.EditValue = ReadIntegerData("Select ISNULL(BuyerId,-1) From Style where StyleId=" & SID, cnn)
        GarmentsDescriptionMemoEdit.Text = ReadStringData("Select GMDescription From Style Where StyleId=" & SID, cnn)
        IsEmbroideryCheckEdit.Checked = ReadBooleanData("Select IsNull(IsEmbroidery,0) From Style Where StyleId=" & SID, cnn)
        IsPrintCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsPrint,0) From Style Where StyleId=" & SID, cnn)
        PrintTypeIdGridLookUpEdit.EditValue = ReadIntegerData("Select ISNULL(PrintTypeId,-1) From Style where StyleId=" & SID, cnn)
        IsWashCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsWash,0) From Style Where StyleId=" & SID, cnn)
        IsPeachFinishCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsPeachFinish,0) From Style Where StyleId=" & SID, cnn)
        IsBrushCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsBrush,0) From Style Where StyleId=" & SID, cnn)
        DivisionIdGridLookUpEdit.EditValue = ReadIntegerData("Select ISNULL(DivisionId,-1) From Style where StyleId=" & SID, cnn)
        GMTBrandIdGridLookUpEdit.EditValue = ReadIntData("Select ISNULL(GMTBrandId,-1) From Style where StyleId=" & SID, cnn)
        StyleNameIdGridLookUpEdit.EditValue = ReadIntegerData("Select ISNULL(StyleNameId,-1) From Style where StyleId=" & SID, cnn)
        StyleTypeComboBox.Text = ReadStringData("Select ISNULL(StyleType,'') From Style where StyleId=" & SID, cnn)
        IsAOPCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsAOP,0) From Style Where StyleId=" & SID, cnn)
        IsYDSCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsYDS,0) From Style Where StyleId=" & SID, cnn)
        IsSublimationCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsSublimation,0) From Style Where StyleId=" & SID, cnn)
        IsSequnceCheckEdit.Checked = ReadBooleanData("Select ISNULL(IsSequence,0) From Style Where StyleId=" & SID, cnn)



    End Sub


    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        If Me.SampleRequestFinalDetailsBindingSource.Position > -1 Then


            Dim row As SampleRequestDataSet.SampleRequestFinalDetailsRow
            row = CType(CType(Me.SampleRequestFinalDetailsBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalDetailsRow)

            Dim newRow As SampleRequestDataSet.SampleRequestFinalDetailsRow = Me.SampleRequestDataSet.SampleRequestFinalDetails.NewRow()

            On Error Resume Next


            newRow.SampleRequestId = row.SampleRequestId
            newRow.KnittingTypeId = row.KnittingTypeId
            newRow.CompositionId = row.CompositionId
            newRow.GSM = row.GSM
            newRow.IsFabricAvailable = row.IsFabricAvailable
            newRow.Color = row.Color
            newRow.ELD = row.ELD
            newRow.SampleSendDate = row.SampleSendDate
            newRow.IsSealed = row.IsSealed
            newRow.SealedDate = row.SealedDate
            newRow.ExFabricRcvDate = row.ExFabricRcvDate
            newRow.IsAOP = row.IsAOP
            newRow.IsYDS = row.IsYDS
            newRow.ExSendDate = row.ExSendDate
            newRow.FabricColorId = row.FabricColorId
            newRow.Remarks = row.Remarks
            newRow.IsCancel = row.IsCancel
            newRow.CancelReason = row.CancelReason


            Me.SampleRequestDataSet.SampleRequestFinalDetails.Rows.Add(newRow)


        End If

    End Sub

    Private Sub CopyFabricButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFabricButton.Click

        If Me.SampleFabricBindingSource.Position > -1 Then

            Dim row As SampleRequestDataSet.SampleFabricRow
            row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleFabricRow)


            Dim newRow As SampleRequestDataSet.SampleFabricRow = Me.SampleRequestDataSet.SampleFabric.NewRow()

            On Error Resume Next

            newRow.SampleRequestId = row.SampleRequestId
            newRow.FabricColorName = row.FabricColorName
            newRow.ELD = row.ELD
            newRow.GarmentsPartId = row.GarmentsPartId
            newRow.KnittingTypeId = row.KnittingTypeId
            newRow.CompositionId = row.CompositionId
            newRow.FGSM = row.FGSM
            newRow.Dia = row.Dia
            newRow.DiaType = row.DiaType
            newRow.FinishUnit = row.FinishUnit
            newRow.BookingQuantity = row.BookingQuantity
            newRow.Remarks = row.Remarks
            newRow.SPNote = row.SPNote
            newRow.IsDelivered = row.IsDelivered
            newRow.DeliveredDate = row.DeliveredDate
            newRow.Priority = row.Priority
            newRow.PrintSend = row.PrintSend
            newRow.PrintReceived = row.PrintReceived
            newRow.Status = row.Status
            newRow.IsImportant = row.IsImportant
            newRow.MainFabric = row.MainFabric
            newRow.GreyPercentage = row.GreyPercentage
            newRow.GreyQuantity = row.GreyQuantity
            newRow.Length = row.Length
            newRow.KgPerUnit = row.KgPerUnit
            newRow.Consumption = row.Consumption
            newRow.DUnit = row.DUnit


            Me.SampleRequestDataSet.SampleFabric.Rows.Add(newRow)


        End If

    End Sub



    Private Sub GetStyleDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetStyleDetailsButton.Click

        Dim SID As Integer = Me.StyleIdGridLookUpEdit.EditValue
        GetStyleDetails(SID)

    End Sub

    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click

        If Addflag = True Then

            ShowMaster(frmMasterOrderSampleLookUp)

            If frmMasterOrderSampleLookUp.DialogResult = System.Windows.Forms.DialogResult.OK Then

                Getflag = True
                RequestNoTextEdit.Text = Me.SampleReqNo.ToString()
                GetMasterData()
                GetMasterSample()

                'Save()

            End If
        Else

            MessageBox.Show("Please, Click on Add button first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub GetMasterData()
        Dim connection As New SqlConnection(cnn)

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select * From MasterOrder Where MasterOrderId =(select Max(MasterOrderId) from MasterOrderSampleStatus where SampleRequestNo = '" & Me.SampleReqNo.ToString() & "')", connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()

        While reader.Read

            'On Error Resume Next

            MasterProgramNoTextBox.Text = reader("MasterProgramNo").ToString
            StyleIdGridLookUpEdit.EditValue = reader("StyleId").ToString
            BuyerGridLookUpEdit.EditValue = reader("BuyerId").ToString
            GarmentsDescriptionMemoEdit.EditValue = reader("GMDescription").ToString
            DivisionIdGridLookUpEdit.EditValue = reader("DivisionId").ToString
            IsPrintCheckEdit.EditValue = reader("IsPrint")
            IsWashCheckEdit.EditValue = reader("IsWash")
            IsEmbroideryCheckEdit.EditValue = reader("IsEmbroidary")

        End While
        reader.Close()
        connection.Close()

    End Sub

    Private Sub GetMasterSample()

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("select * from MasterOrderSampleStatus where SampleRequestNo = '" & Me.SampleReqNo.ToString() & "'", connection)
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader()

        While reader1.Read
            On Error Resume Next

            RequestDateDateEdit.EditValue = reader1("SampleRequestDate")
            ExDateDateEdit.EditValue = reader1("SampleRequiredDate")
            DevTypeIdGridLookUpEdit.EditValue = reader1("DevTypeId")
            SampleSendDateDateEdit.EditValue = reader1("SampleSendDate")
            SendingInfoTextEdit.Text = reader1("SendingInfo")
            CommentsReceiveDateDateEdit.EditValue = reader1("CommentsReceive")
            ApprovalStatusTextEdit.Text = reader1("Approved")
            RemarksMemoEdit.Text = reader1("Remarks")

        End While

        reader1.Close()
        connection.Close()

    End Sub

    Private Sub RequestNoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RequestNoLinkLabel.LinkClicked

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CopyAllButton_Click(sender As Object, e As EventArgs) Handles CopyAllButton.Click

        If MessageBox.Show("Are you sure your want to copy ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim NRNo As String = ""
            Dim ABC As String = Now.Year.ToString.Substring(2) & "SP"
            Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(RequestNo),0,CHARINDEX('P',REVERSE(RequestNo))))) From SampleRequestFinal Where RequestNo Like '" & ABC & "%'", cnn)
            Dim XYZ1 As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(SampleRequestNo),0,CHARINDEX('P',REVERSE(SampleRequestNo))))) From MasterOrderSampleStatus Where SampleRequestNo Like '" & ABC & "%'", cnn)

            If (XYZ > XYZ1) Then
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ) + 1).ToString("0000")
                NRNo = NewOrder
            Else
                Dim NewOrder As String = Now.Year.ToString.Substring(2) & "SP" & (Val(XYZ1) + 1).ToString("0000")
                NRNo = NewOrder
            End If

            ' GetConnection is a method that creates and return the '
            ' SqlConnection used here according to your connection string'
            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                ' Create the command with the sproc name and add the parameter required'
                Dim cmd As SqlCommand = New SqlCommand("CopySampleRequest", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@SampleRequestId", GridLookUpEdit1.EditValue)
                cmd.Parameters.AddWithValue("@NewRequestNo", NRNo)

                cmd.ExecuteNonQuery()

            End Using


            Me.SRLookupByDivUserTableAdapter.Fill(Me.SampleRequestLookupDataSet.SRLookupByDivUser, UserId)
            Dim SRId As Integer = ReadIntegerData("Select SampleRequestId From SampleRequestFinal Where RequestNo='" & NRNo & "'", cnn)
            GridLookUpEdit1.EditValue = SRId

            Me.SampleRequestFinalTableAdapter.FillBySampleRequestId(Me.SampleRequestDataSet.SampleRequestFinal, SRId)
            Me.SampleRequestFinalDetailsTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleRequestFinalDetails, SRId)
            Me.SampleFabricTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleFabric, SRId)
            Me.SampleRequireQuantityTableAdapter.FillBySRId(Me.SampleRequestDataSet.SampleRequireQuantity, SRId)
            Me.SamplePrintColorTableAdapter.FillBySRId(Me.SampleRequestDataSet.SamplePrintColor, SRId)

        End If

    End Sub

    Private Sub BuyerGridLookUpEdit_EditValueChanged_1(sender As Object, e As EventArgs) Handles BuyerGridLookUpEdit.EditValueChanged
        On Error Resume Next
        If Getflag = False Then
            If Addflag = True Then


                'Dim BC As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & BuyerIdGridLookUpEdit.EditValue, cnn)

                'Dim ABC As String = BC & Now.Year.ToString.Substring(2)
                'Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(RequestNo),0,CHARINDEX('-',REVERSE(RequestNo))))) From SampleRequestFinal Where RequestNo Like '" & ABC & "%'", cnn)
                'Dim XYZ1 As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(SampleRequestNo),0,CHARINDEX('-',REVERSE(SampleRequestNo))))) From MasterOrderSampleStatus Where SampleRequestNo Like '" & ABC & "%'", cnn)
                'If (XYZ > XYZ1) Then
                '    Dim NewOrder As String = BC & Now.Year.ToString.Substring(2) & "-" & (Val(XYZ) + 1).ToString("0000")
                '    RequestNoTextEdit.Text = NewOrder
                'Else
                '    Dim NewOrder As String = BC & Now.Year.ToString.Substring(2) & "-" & (Val(XYZ1) + 1).ToString("0000")
                '    RequestNoTextEdit.Text = NewOrder
                'End If
                If DBNull.Value.Equals(BuyerGridLookUpEdit.EditValue) = False Then
                    Me.DivisionTableAdapter.FillByBuyerId(Me.DivisionDataSet.Division, BuyerGridLookUpEdit.EditValue)
                End If


            End If
        End If
    End Sub
End Class
