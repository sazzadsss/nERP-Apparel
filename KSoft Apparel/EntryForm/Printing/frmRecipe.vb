Public Class frmRecipe
    Dim Docalculation As Boolean = True
    Dim oldRowColor As ReceipeDataSet.RecipeColorRow
    Dim oldRowRecipe As ReceipeDataSet.RecipeRow
    Dim CANEDIT As Boolean
    Dim CopyRecipeId As Integer
    Dim PasteRecipeId As Integer

    Private _PC_ID As Integer
    Public Property PC_ID() As Integer
        Get
            Return _PC_ID
        End Get
        Set(ByVal value As Integer)
            _PC_ID = value
        End Set
    End Property
    Private _Item_Id As Integer
    Public Property Item_Id() As Integer
        Get
            Return _Item_Id
        End Get
        Set(ByVal value As Integer)
            _Item_Id = value
        End Set
    End Property


    Private Sub RecipeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecipeBindingNavigatorSaveItem.Click

        Try
            'If MessageBox.Show("Are you sure you want to save ?", "Saveing ....", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.RecipeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ReceipeDataSet)
            Docalculation = True
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub frmRecipe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmRecipe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F12 Then

            Try
                'If MessageBox.Show("Are you sure you want to save ?", "Saveing ....", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Validate()
                Me.RecipeBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ReceipeDataSet)
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf e.KeyData = Keys.F10 Then

            If RecipeDataGridView.Focused Then

                If Me.RecipeDataGridView.Columns(Me.RecipeDataGridView.CurrentCell.ColumnIndex()).HeaderText = "Style" Then

                    frmStyle.ShowDialog()

                    If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.StyleTableAdapter.Fill(StyleDataSet.Style)
                        Me.RecipeDataGridView.CurrentCell.Value = StyleIdvar
                        'Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
                        'Me.OrderDetailsDataGridView.CurrentCell.Value = FabricColorIdvar
                    End If

                ElseIf Me.RecipeDataGridView.Columns(Me.RecipeDataGridView.CurrentCell.ColumnIndex()).HeaderText = "Fabric Color" Then

                    frmFabricColor.ShowDialog()

                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
                        Me.RecipeDataGridView.CurrentCell.Value = FabricColorIdvar
                    End If

                End If


            ElseIf RecipeColorDataGridView.Focused Then

                If Me.RecipeColorDataGridView.Columns(Me.RecipeColorDataGridView.CurrentCell.ColumnIndex()).HeaderText = "Print Color" Then

                    frmPrintColor.ShowDialog()

                    If frmPrintColor.DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
                       
                        Me.RecipeColorDataGridView.CurrentCell.Value = Me.PC_ID

                    End If


                End If

            ElseIf RecipeItemDataGridView.Focused Then

                If Me.RecipeItemDataGridView.Columns(Me.RecipeItemDataGridView.CurrentCell.ColumnIndex()).HeaderText = "Item  Name" Then

                    frmItemLookup.ShowDialog()

                    If frmItemLookup.DialogResult = System.Windows.Forms.DialogResult.OK Then
                        'Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)

                        Me.RecipeItemDataGridView.CurrentCell.Value = Me.Item_Id

                        ''On Error Resume Next
                        'RecipeItemDataGridView.Rows(e.RowIndex).ErrorText = String.Empty
                        

                        If RecipeItemBindingSource.Position > -1 Then

                            Dim row As ReceipeDataSet.RecipeItemRow
                            row = CType(CType(Me.RecipeItemBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeItemRow)
                            Dim CurPrice As Double = ReadData("Select CurrentPrice From ItemList Where ItemId=" & Me.Item_Id, cnn)
                            Me.RecipeItemDataGridView.CurrentRow.Cells("colUnitPrice").Value = CurPrice

                        End If


                    End If


                End If

            End If

        End If


    End Sub

    Private Sub frmRecipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)

        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        
        Me.ReceipeStyleLookupTableAdapter.Fill(Me.ReceipeStyleLookupDataSet.ReceipeStyleLookup)
        Me.CopiedRecipeColorTableAdapter.Fill(Me.CopiedRecipeColorDataSet.CopiedRecipeColor)
        Me.CopiedRecipeItemTableAdapter.Fill(Me.CopiedRecipeItemDataSet.CopiedRecipeItem)
        Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
        Me.RecipeColorTableAdapter1.Fill(Me.PrintColorLookupDataSet.RecipeColor)
        Me.StyleTableAdapter1.Fill(Me.StyleLookupDataSet.Style)
        Me.ItemListTableAdapter1.FillByDepartmentId(Me.ItemListDataSet.ItemList, 13)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.VItemListTableAdapter.Fill(Me.ItemNameDataSet.vItemList)
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.RecipeItemTableAdapter.Fill(Me.ReceipeDataSet.RecipeItem)
        Me.RecipeColorTableAdapter.Fill(Me.ReceipeDataSet.RecipeColor)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)


        'Start -------- eck and Set user rights


        'Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Recipe'", cnn)
        'CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        'If CANEDIT = False Then
        '    RecipeBindingNavigator.Enabled = False
        '    AddLinkLabel.Enabled = False
        '    RecipeDataGridView.ReadOnly = True
        '    RecipeColorDataGridView.ReadOnly = True
        '    RecipeItemDataGridView.ReadOnly = True
        '    CopyLinkLabel.Enabled = False
        '    DefaultLinkLabel.Enabled = False
        '    PasteLinkLabel.Enabled = False
        'End If

        'End ------- Check and Set user rights

        If CheckUserRights("Print Recipe").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            RecipeBindingNavigatorSaveItem.Enabled = False
          

        End If
    End Sub
    Private Sub RecipeItemBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecipeItemBindingSource.PositionChanged, RecipeItemBindingSource.CurrentChanged



    End Sub


   
    Private Sub RecipeItemDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RecipeItemDataGridView.KeyDown

       

        
        If e.KeyData = Keys.Insert Then
            frmCalculator.ShowDialog()

        ElseIf e.KeyData = Keys.F4 Then


           

        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        blnPrintColor = False

        Dim row As ReceipeDataSet.RecipeRow
        row = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)
        Try
            If row.IsOrderIdNull Then
                frmPrintRecipeReport.IsOrderIdNull = True
            ElseIf row.OrderId = Nothing Then
                frmPrintRecipeReport.IsOrderIdNull = True
            Else
                frmPrintRecipeReport.IsOrderIdNull = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        


        With frmPrintRecipeReport
            .MdiParent = frmMain
            .RecipeId = Trim(RecipeIdLabel.Text)
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub AddLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddLinkLabel.LinkClicked
        RecipeColorBindingSource.AddNew()
        'Set False for used Quantity
        Docalculation = False
    End Sub

    Private Sub RecipeDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecipeDataGridView.CellClick

        If RecipeBindingSource.Position > -1 Then

            RecipeDataGridView.CurrentRow.Selected = True

        End If


    End Sub

    Private Sub RecipeColorDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecipeColorDataGridView.CellClick
        RecipeColorDataGridView.CurrentRow.Selected = True
    End Sub

   
   

    Private Sub RecipeColorDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecipeColorDataGridView.CellEndEdit
        ' Clear the row error in case the user presses ESC.  
        Dim WtActual As Decimal = 0

        Dim WPercentage As Integer = 0
        Dim TTLQuantity As Decimal = 0

        RecipeColorDataGridView.Rows(e.RowIndex).ErrorText = String.Empty

        Dim row As ReceipeDataSet.RecipeColorRow
        row = CType(CType(Me.RecipeColorBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeColorRow)

        WtActual = (IIf(IsDBNull(row.Weight_AfterPrint) = True, 0, row.Weight_AfterPrint) - IIf(IsDBNull(row.Weight_BeforePrint) = True, 0, row.Weight_BeforePrint))
        TTLQuantity = WtActual + WtActual * IIf(IsDBNull(row.WastagePercentage), 0, row.WastagePercentage) / 100

        row.UsedQuanty = TTLQuantity


        'Refresh Recipe Item Datagridview

        For index As Integer = 1 To RecipeItemBindingSource.Count

           
            If RecipeItemBindingSource.Position + 1 < RecipeItemBindingSource.Count Then

                RecipeItemBindingSource.MoveNext()

                ' Otherwise, move back to the first item.
            Else

                RecipeItemBindingSource.MoveFirst()

            End If


        Next

    End Sub

    Private Sub RecipeColorDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles RecipeColorDataGridView.CellValidating

        ' Validate the Print Color entry by disallowing empty strings.

        If RecipeColorDataGridView.Columns(e.ColumnIndex).Index = 0 Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                RecipeColorDataGridView.Rows(e.RowIndex).ErrorText = _
                    "Print Color must not be empty"
                e.Cancel = True
            End If
        End If

    End Sub

   

    Private Sub RecipeColorBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecipeColorBindingSource.PositionChanged
        'Me.RecipeItemTableAdapter.Fill(Me.ReceipeDataSet.RecipeItem)
    End Sub

    

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshRecipe()  

    End Sub
    Private Sub RefreshRecipe()
        'If MessageBox.Show("Are you sure want to refresh ? You may lost your last work", "Refreshing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        '    Me.ItemListTableAdapter1.Fill(Me.ItemListDataSet.ItemList)

        '    Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        '    Me.VItemListTableAdapter.Fill(Me.ItemNameDataSet.vItemList)

        '    Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)

        '    Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        '    Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)

        '    Me.RecipeItemTableAdapter.Fill(Me.ReceipeDataSet.RecipeItem)

        '    Me.RecipeColorTableAdapter.Fill(Me.ReceipeDataSet.RecipeColor)

        '    'Me.RecipeTableAdapter.Fill(Me.ReceipeDataSet.Recipe)
        '    Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
        'End If
    End Sub

    

   
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        blnPrintColor = True

        With frmPrintRecipeReport
            .PrintColorId = PrintColorLookupGridLookUpEdit.EditValue
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub CopyLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CopyLinkLabel.LinkClicked
        Try
            'Get OrderDetailsId by using oldRowColor.OrderDetailsId
            oldRowColor = CType(CType(Me.RecipeColorBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeColorRow)

            Me.CopiedRecipeItemTableAdapter.FillByRecipeColorId(Me.CopiedRecipeItemDataSet.CopiedRecipeItem, oldRowColor.RecipeColorId)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PasteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PasteLinkLabel.LinkClicked
        oldRowColor = CType(CType(Me.RecipeColorBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeColorRow)

        If CopiedRecipeItemBindingSource.Position > -1 Then

            For Each dr As DataRowView In CopiedRecipeItemBindingSource.List

                'Dim SizeId As Integer = 0
                'Dim OrderQuantity As Integer = 0
                'Dim PackType As String = String.Empty

                'Dim RecipeItemId As Integer
                Dim RecipeColorId As Integer
                Dim Itemid As Integer
                Dim RecipeQuantity As Decimal
                Dim UnitPrice As Decimal
                Dim Remarks As String
                Dim UsedQuantity As Integer



                'RecipeItemId= Auto number not require
                RecipeColorId = oldRowColor.RecipeColorId
                Itemid = dr!Itemid
                RecipeQuantity = dr!RecipeQuantity
                UnitPrice = dr!UnitPrice
                Remarks = "By Copy"
                UsedQuantity = 0


                ' Dim NewRow As OrderDataSet.OrderSizeDetailsRow = Me.OrderDataSet.OrderSizeDetails.NewRow()
                Dim NewRow As ReceipeDataSet.RecipeItemRow = Me.ReceipeDataSet.RecipeItem.NewRow()

                NewRow.RecipeColorId = RecipeColorId
                NewRow.ItemId = Itemid
                NewRow.RecipeQuantity = RecipeQuantity
                NewRow.UnitPrice = UnitPrice
                NewRow.Remarks = Remarks
                NewRow.UsedQuantity = UsedQuantity

                Me.ReceipeDataSet.RecipeItem.Rows.Add(NewRow)
            Next
        End If
    End Sub

    Private Sub CopyPrintColorLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CopyPrintColorLinkLabel.LinkClicked
        Try
            'Get OrderDetailsId by using oldRowColor.OrderDetailsId
            oldRowRecipe = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

            Me.CopiedRecipeColorTableAdapter.FillByRecipeId(Me.CopiedRecipeColorDataSet.CopiedRecipeColor, oldRowRecipe.RecipeId)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PastePrintColorLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PastePrintColorLinkLabel.LinkClicked
        oldRowRecipe = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

        If CopiedRecipeColorBindingSource.Position > -1 Then

            For Each dr As DataRowView In CopiedRecipeItemBindingSource.List


                'Dim SizeId As Integer = 0
                'Dim OrderQuantity As Integer = 0
                'Dim PackType As String = String.Empty

                'Dim RecipeItemId As Integer
                Dim RecipeColorId As Integer
                Dim Itemid As Integer
                Dim RecipeQuantity As Decimal
                Dim UnitPrice As Decimal
                Dim Remarks As String
                Dim UsedQuantity As Integer



                'RecipeItemId= Auto number not require
                RecipeColorId = oldRowColor.RecipeColorId
                Itemid = dr!Itemid
                RecipeQuantity = dr!RecipeQuantity
                UnitPrice = dr!UnitPrice
                Remarks = "By Copy"
                UsedQuantity = 0


                ' Dim NewRow As OrderDataSet.OrderSizeDetailsRow = Me.OrderDataSet.OrderSizeDetails.NewRow()
                Dim NewRow As ReceipeDataSet.RecipeItemRow = Me.ReceipeDataSet.RecipeItem.NewRow()

                NewRow.RecipeColorId = RecipeColorId
                NewRow.ItemId = Itemid
                NewRow.RecipeQuantity = RecipeQuantity
                NewRow.UnitPrice = UnitPrice
                NewRow.Remarks = Remarks
                NewRow.UsedQuantity = UsedQuantity

                Me.ReceipeDataSet.RecipeItem.Rows.Add(NewRow)


            Next
        End If
    End Sub




    Private Sub DefaultLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DefaultLinkLabel.LinkClicked
        Try
            '=========================
            'Coping ....
            'Get OrderDetailsId by using oldRowColor.OrderDetailsId
            oldRowColor = CType(CType(Me.RecipeColorBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeColorRow)
            Me.MinRecipeColorTableAdapter.Fill(Me.MinRecipeColorIdDataSet.MinRecipeColor, oldRowColor.PrintTypeId, oldRowColor.PrintColorId)

            Dim oldRow2 As MinRecipeColorIdDataSet.MinRecipeColorRow
            oldRow2 = CType(CType(Me.MinRecipeColorBindingSource.Current, DataRowView).Row, MinRecipeColorIdDataSet.MinRecipeColorRow)
            Me.CopiedRecipeItemTableAdapter.FillByRecipeColorId(Me.CopiedRecipeItemDataSet.CopiedRecipeItem, oldRow2.MinRecipeColorId)


            'End of Coping
            '=========================

            '=========================
            'Pasting....

            oldRowColor = CType(CType(Me.RecipeColorBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeColorRow)

            If CopiedRecipeItemBindingSource.Position > -1 Then

                For Each dr As DataRowView In CopiedRecipeItemBindingSource.List

                    'Dim SizeId As Integer = 0
                    'Dim OrderQuantity As Integer = 0
                    'Dim PackType As String = String.Empty

                    'Dim RecipeItemId As Integer
                    Dim RecipeColorId As Integer
                    Dim Itemid As Integer
                    Dim RecipeQuantity As Decimal
                    Dim UnitPrice As Decimal
                    Dim Remarks As String
                    Dim UsedQuantity As Integer



                    'RecipeItemId= Auto number not require
                    RecipeColorId = oldRowColor.RecipeColorId
                    Itemid = dr!Itemid
                    RecipeQuantity = dr!RecipeQuantity
                    UnitPrice = dr!UnitPrice
                    Remarks = "By Copy"
                    UsedQuantity = 0


                    ' Dim NewRow As OrderDataSet.OrderSizeDetailsRow = Me.OrderDataSet.OrderSizeDetails.NewRow()
                    Dim NewRow As ReceipeDataSet.RecipeItemRow = Me.ReceipeDataSet.RecipeItem.NewRow()

                    NewRow.RecipeColorId = RecipeColorId
                    NewRow.ItemId = Itemid
                    NewRow.RecipeQuantity = RecipeQuantity
                    NewRow.UnitPrice = UnitPrice
                    NewRow.Remarks = Remarks
                    NewRow.UsedQuantity = UsedQuantity

                    Me.ReceipeDataSet.RecipeItem.Rows.Add(NewRow)
                Next
            End If

            'End of Pasting
            '=========================


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub StyleLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleLookupGridLookUpEdit.EditValueChanged, StyleLookupGridLookUpEdit.Closed


        On Error Resume Next

        Me.OrderTableAdapter.Fill(Me.StyleOrderDataSet.Order, StyleLookupGridLookUpEdit.EditValue)
        Me.RecipeTableAdapter.FillByStyleId(Me.ReceipeDataSet.Recipe, StyleLookupGridLookUpEdit.EditValue)

        
    End Sub

    Private Sub RecipeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecipeDataGridView.CellContentClick

        If TypeOf Me.RecipeDataGridView.Columns(e.ColumnIndex) Is DataGridViewLinkColumn Then

            Dim RID As Integer = Me.RecipeDataGridView(e.ColumnIndex, e.RowIndex).Value.ToString()
            frmOtherPrintCosting.pRecipeId = RID
            ShowMaster(frmOtherPrintCosting)

        End If
      

    End Sub


    Private Sub RecipeBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles RecipeBindingSource.AddingNew

        If StyleBindingSource.Position > -1 Then

            Me.ReceipeDataSet.Recipe.StyleIdColumn.DefaultValue = StyleLookupGridLookUpEdit.EditValue

        End If

    End Sub

    
    Private Sub AddRecipeItemLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddRecipeItemLink.LinkClicked

        Me.RecipeItemBindingSource.AddNew()

    End Sub

   
    Private Sub ClearProgramLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ClearProgramLinkLabel.LinkClicked
        Dim row As ReceipeDataSet.RecipeRow
        row = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

        If MessageBox.Show("Are you sure you want to clear the program no", "Clear Program No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            row.OrderId = Nothing

        Else

            Exit Sub

        End If




    End Sub

    Private Sub RecipeDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles RecipeDataGridView.DataError
        On Error Resume Next

    End Sub

    
    

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged
        Dim StyleId As Integer = ReadIntegerData("Select StyleId From [Order] Where OrderId=" & Me.ProgramNoGridLookUpEdit.EditValue, cnn)
        StyleLookupGridLookUpEdit.EditValue = StyleId
        Me.RecipeTableAdapter.FillByStyleId(Me.ReceipeDataSet.Recipe, 0)
    End Sub

   
    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        Dim row As ReceipeDataSet.RecipeRow
        row = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)
        CopyRecipeId = row.RecipeId

    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click

        If Me.RecipeBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As ReceipeDataSet.RecipeRow
        row = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

        If Me.RecipeColorBindingSource.Position = -1 Then

            ExecuteQuery("Exec GetPrintRecipe " & CopyRecipeId & "," & row.RecipeId, cnn)
            Me.RecipeColorTableAdapter.Fill(Me.ReceipeDataSet.RecipeColor)

        End If

        If Me.RecipeItemBindingSource.Position = -1 Then
            If row.GMQuantity > 0 Then


                For Each drv As DataRowView In Me.RecipeColorBindingSource.List
                    ExecuteQuery("Insert Into RecipeItem(RecipeColorId,ItemId,RecipeQuantity,UnitPrice) Select " & drv!RecipeColorId & " As RecipeColorId,ItemId,(Select UsedQuantity/(Select GMQuantity From Recipe Where RecipeId=" & CopyRecipeId & ")*" & row.GMQuantity & ") As RecipeQuantity,(Select CurrentPrice From ItemList where ItemId=RecipeItem.ItemId) As UnitPrice From RecipeItem Where RecipeColorId=" & drv!CopyRecipeColorId, cnn)
                Next

                Me.RecipeItemTableAdapter.Fill(Me.ReceipeDataSet.RecipeItem)
            Else
                MessageBox.Show("Garments Quantity require")
            End If

        End If
        
    End Sub

    Private Sub PrintColorLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintColorLookupGridLookUpEdit.EditValueChanged

        If Me.PrintColorBindingSource.Position > -1 Then

            frmPrintRecipeReport.PrintColorId = PrintColorLookupGridLookUpEdit.EditValue

        Else

            MessageBox.Show("Print Color is not available.")

        End If
    End Sub

    Private Sub RecipeColorDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles RecipeColorDataGridView.DataError
        On Error Resume Next
    End Sub

    Private Sub CalUsedQuantitiyLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CalUsedQuantitiyLinkLabel.LinkClicked

        

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        'Calculate Total .....

        Dim TotalReceipeQuantity As Decimal = 0
        Dim TotalPrice As Decimal = 0

        If RecipeItemBindingSource.Position > -1 Then

            '>>>>>>>>>For TotalRecipeQuantity<<<<<<<<<<<<<<
            For Each row As DataRowView In RecipeItemBindingSource.List

                If IsDBNull(row!RecipeQuantity) = False Then
                    TotalReceipeQuantity = TotalReceipeQuantity + row!RecipeQuantity
                Else
                    TotalReceipeQuantity = TotalReceipeQuantity + 0
                End If

                TotalRecipeTextBox.Text = TotalReceipeQuantity

            Next

            '>>>>>>>For Price <<<<<<<<<<<<<<<<<<<<<<<<<<<<
            For Each row As DataRowView In RecipeItemBindingSource.List

                If IsDBNull(row!TotalPrice) = False Then
                    TotalPrice = TotalPrice + row!TotalPrice
                Else
                    TotalPrice = TotalPrice + 0
                End If

                TotalPriceTextBox.Text = Format(Convert.ToDecimal(TotalPrice.ToString), "##,##,##0.00")
                'Me.txtbox_amount.Text = "$ " & Format(Convert.ToDecimal(Me.txtbox_amount.Text), "###,###,##0.00")

            Next


        End If

        ' End of Calculate Total


        Dim row1 As ReceipeDataSet.RecipeRow
        row1 = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

        If row1.Development = False Then
            For Each dr As DataRowView In RecipeItemBindingSource.List
                dr!UsedQuantity = dr!RecipeQuantity
            Next
        Else
            ''>>>>>>>For UsedQuantity Coloumn in RecipeItem<<<<<<<<<<<<<<<<<
            Dim ItemwiseUsedQuantity As Decimal = 0
            Dim drRecipeItem As ReceipeDataSet.RecipeItemRow
            drRecipeItem = CType(CType(Me.RecipeItemBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeItemRow)

            If UsedQuantyTextBox.Text = String.Empty Then
                ItemwiseUsedQuantity = 0
            Else
                'If drRecipeItem.IsRecipeQuantityNull then
                ItemwiseUsedQuantity = CDbl(drRecipeItem.RecipeQuantity) / CDbl(TotalReceipeQuantity) * CDbl(UsedQuantyTextBox.Text)
            End If

            '*********************************************************
            Dim RecipeRow As ReceipeDataSet.RecipeRow
            RecipeRow = CType(CType(Me.RecipeBindingSource.Current, DataRowView).Row, ReceipeDataSet.RecipeRow)

            drRecipeItem.UsedQuantity = ItemwiseUsedQuantity
            
        End If



        
    End Sub
End Class