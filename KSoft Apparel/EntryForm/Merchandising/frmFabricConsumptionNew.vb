Imports System.Data.SqlClient

Public Class frmFabricConsumptionNew
    Dim IsFirstLoad As Boolean = True
    Dim CopyODI As Integer 'ODI=Order Details Id
    Dim oldRow As OrderDataSet.OrderDetailsRow
    Private Sub frmOrderReceived_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyData = Keys.F11 Then

            If Me.StyleIdGridLookUpEdit.IsEditorActive Then


                frmStyle.ShowDialog()

                If frmStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
                    Me.StyleIdGridLookUpEdit.EditValue = frmStyle.StyleId

                End If


            ElseIf BuyerIdGridLookUpEdit.IsEditorActive Then

                frmBuyer.ShowDialog()

                If frmBuyer.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
                    Me.BuyerIdGridLookUpEdit.EditValue = frmBuyer.BuyerId

                End If


            ElseIf GarmentIdGridLookUpEdit.IsEditorActive Then

                frmGarments.ShowDialog()

                If frmGarments.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.GarmentTableAdapter.Fill(Me.GarmentDataSet.Garment)
                    Me.GarmentIdGridLookUpEdit.EditValue = frmGarments.GarmentId

                End If

            ElseIf DivisionIdGridLookUpEdit.IsEditorActive Then

                frmDivision.ShowDialog()

                If frmDivision.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
                    Me.DivisionIdGridLookUpEdit.EditValue = frmDivision.DivisionId

                End If

            ElseIf SeasonIdGridLookUpEdit.IsEditorActive Then

                frmSeason.ShowDialog()

                If frmSeason.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
                    Me.SeasonIdGridLookUpEdit.EditValue = frmSeason.SeasonId

                End If

            ElseIf OrderDetailsGridControl.IsFocused Then


                If GridView1.FocusedColumn.AbsoluteIndex = colFabricColorId.AbsoluteIndex Then

                    frmFabricColor.ShowDialog()


                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

                        Dim row As OrderDataSet.OrderDetailsRow
                        row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                        row.FabricColorId = frmFabricColor.FabricColorId

                    End If

                ElseIf GridView1.FocusedColumn.AbsoluteIndex = colDestinationId.AbsoluteIndex Then

                    frmDestination.ShowDialog()

                    If frmDestination.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)

                        Dim row As OrderDataSet.OrderDetailsRow
                        row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                        row.DestinationId = frmDestination.DestinationId


                    End If

                End If

            End If

        End If

        If e.KeyData = Keys.F3 Then


            If OrderDetailsGridControl.IsFocused() Then

                '---Copy current row
                Save()

                oldRow = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

                Dim newRow As OrderDataSet.OrderDetailsRow = Me.OrderDataSet.OrderDetails.NewRow()
                newRow.POGroup = oldRow.POGroup
                newRow.PO = oldRow.PO
                newRow.PO_Type = oldRow.PO_Type
                newRow.OrderId = oldRow.OrderId
                newRow.EX = oldRow.EX
                newRow.ETA = oldRow.ETA
                newRow.PayBy = oldRow.PayBy
                newRow.FabricColorId = oldRow.FabricColorId
                newRow.Code = oldRow.Code
                newRow.DestinationId = oldRow.DestinationId
                newRow.Price = oldRow.Price
                newRow.A_S = oldRow.A_S
                newRow.StyleId = oldRow.StyleId
                newRow.Discontinue = 0
                newRow.PackType = oldRow.PackType
                newRow.CasuseOfDiscontinue = "-"

                Me.OrderDataSet.OrderDetails.Rows.Add(newRow)

            End If
        End If
    End Sub


    Private Sub frmOrderReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.FinishingProcessTableAdapter.Fill(Me.OrderDataSet.FinishingProcess)


        Me.FabricForSizeTableAdapter.Fill(Me.OrderDataSet.FabricForSize)
        Me.OrderAmndDetailsTableAdapter.Fill(Me.OrderDataSet.OrderAmndDetails)

        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.TwinPackDetailsTableAdapter.Fill(Me.OrderDataSet.TwinPackDetails)

        Me.OrderDataSet.Order.CompanyIdColumn.DefaultValue = 1

        FillMaster()


        If CheckUserRights("CAD Information").CanEdit = False Then

            EditButton.Enabled = False
            RefreshButton.Enabled = False

        End If

    End Sub

    Private Sub FillMaster()

        If UserId = 1 Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Else
            Me.OrderLookupTableAdapter.FillByParticularUser(Me.OrderLookupDataSet.OrderLookup, UserId)
        End If

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



    End Sub

    Private Sub Save()

        Try
            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.OrderDetailsBindingSource.EndEdit()
            Me.OrderSizeDetailsBindingSource.EndEdit()
            Me.FabricBindingSource.EndEdit()
            Me.OrderCuttingPercentageBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OrderDataSet)

            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, Me.OrderLookupGridLookUpEdit.EditValue)
            Me.OrderSizeLookupTableAdapter.Fill(Me.OrderSizeDataSet.OrderSizeLookup, Me.OrderLookupGridLookUpEdit.EditValue)

            CalcCon()

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

        Try

            Me.OrderTableAdapter.FillByOrderId(Me.OrderDataSet.Order, OrderLookupGridLookUpEdit.EditValue)
            Dim IsProceed As Boolean = ReadBooleanData("Select IsFabricBOMComplete From FabricBOM Where OrderId=" & OrderLookupGridLookUpEdit.EditValue, cnn)
            If IsProceed = True Then
                EditButton.Enabled = False
            Else
                EditButton.Enabled = True
            End If
            If IsFirstLoad = True Then

                Me.IsFirstLoad = False
                Me.OrderInstructionTableAdapter.Fill(Me.OrderDataSet.OrderInstruction, OrderLookupGridLookUpEdit.EditValue)
                Me.FabricTableAdapter.Fill(Me.OrderDataSet.Fabric, OrderLookupGridLookUpEdit.EditValue)
                Me.OrderCuttingPercentageTableAdapter.Fill(Me.OrderDataSet.OrderCuttingPercentage, OrderLookupGridLookUpEdit.EditValue)

                Me.OrderDetailsTableAdapter.Fill(Me.OrderDataSet.OrderDetails, OrderLookupGridLookUpEdit.EditValue)
                Me.OrderSizeDetailsTableAdapter.Fill(Me.OrderDataSet.OrderSizeDetails, OrderLookupGridLookUpEdit.EditValue)

            End If

            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, Me.OrderLookupGridLookUpEdit.EditValue)
            Me.OrderSizeLookupTableAdapter.Fill(Me.OrderSizeDataSet.OrderSizeLookup, Me.OrderLookupGridLookUpEdit.EditValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If Me.EditButton.Text = "&Update" Then

            Save()
            Me.EditButton.Text = "&Edit"


        Else
            Me.EditButton.Text = "&Update"

        End If
    End Sub

   

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If there is no data in po grid then the procedure will exit.
        If OrderDetailsBindingSource.Position = -1 Then

            Exit Sub

        End If

        If OrderSizeDetailsBindingSource.Position = -1 Then


            'Read Data From OrderSizeDetails by CopyODI
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select SizeId,OrderQuantity,Ratio From OrderSizeDetails Where OrderDetailsId=" & CopyODI, connection)
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


                Me.OrderDataSet.OrderSizeDetails.Rows.Add(newRow)


            End While

            reader.Close()
            connection.Close()
        End If

    End Sub

   

    Private Sub OrderDetailsBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles OrderDetailsBindingSource.AddingNew
        Me.OrderDataSet.OrderDetails.Columns("StyleId").DefaultValue = StyleIdGridLookUpEdit.EditValue
    End Sub


    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.OrderLookupByStyleTableAdapter.FillByStyleId(Me.OrderLookupDataSet.OrderLookupByStyle, Me.StyleIdGridLookUpEdit.EditValue)
        Me.IsPrintCheckEdit.EditValue = ReadBooleanData("Select IsPrint From Style Where StyleId=" & StyleIdGridLookUpEdit.EditValue, cnn)
    End Sub

    Private Sub CalculateRatioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub Paste2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OrderSizeList()
    End Sub

    Private Sub AmndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim row As OrderDataSet.OrderRow
        row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

        If AmendmentNoSpinEdit.Value > 0 Then

            Dim newRow As OrderDataSet.OrderAmndDetailsRow = Me.OrderDataSet.OrderAmndDetails.NewRow()
            newRow.OrderId = row.OrderId
            newRow.AmndNo = AmendmentNoSpinEdit.Value
            newRow.AmndDate = AmendmentDateDateEdit.DateTime.Date
            newRow.Details = CauseofAmendmentMemoEdit.Text
            Me.OrderDataSet.OrderAmndDetails.Rows.Add(newRow)

        End If


    End Sub


   
    
    Private Sub SetColorAndSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetColorAndSizeButton.Click
        SetColorAndSize()
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

        Dim row As OrderDataSet.FabricRow
        row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, OrderDataSet.FabricRow)

        Using connection As New SqlConnection(cnn)

            Dim command As New SqlCommand("Select FabricColorId,Code,Reference,SizeId,TTLOrderQuantity From OrderQuantitySummery_ColorAndSize Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And FabricColorId in(Select FabricColorId From FabricColor Where FabricColorName in ('" & Color1 & "'))And SizeId in ( Select SizeId From Size Where SizeCode in ('" & Size1 & "'))", connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                

                Dim newRow As OrderDataSet.FabricForSizeRow = Me.OrderDataSet.FabricForSize.NewRow()
                newRow.FabricId = row.FabricId
                newRow.FabricColorId = Val(reader("FabricColorId").ToString())
                newRow.SizeId = Val(reader("SizeId").ToString())
                Dim CP As Decimal = ReadData("Select ISNULL(CuttingPercentage,0) From OrderCuttingPercentage Where OrderId=" & OrderLookupGridLookUpEdit.EditValue & " And FabricColorId=" & Val(reader("FabricColorId").ToString()), cnn)
                newRow.OrderQuantity = Val(reader("TTLOrderQuantity").ToString()) * (1 + CP / 100)
                newRow.CuttingPercentage = CP
                newRow.Code = reader("Code").ToString()
                newRow.Reference = reader("Reference").ToString()
                newRow.ContrastColorId = Val(reader("FabricColorId").ToString())
                newRow.FabricQuantity = row.Con / 12 * Val(reader("TTLOrderQuantity").ToString()) * (1 + CP / 100)

                If row.IsLengthNull Then
                    row.Length = 0
                End If

                If row.Length > 0 Then
                    newRow.CCSize = row.Length & "X" & row.FinishFabricDia
                End If



                Me.OrderDataSet.FabricForSize.Rows.Add(newRow)


            End While



            reader.Close()

        End Using

        row.ForColor = ColorCheckedComboBoxEdit.Text
        row.ForSize = SizeCheckedComboBoxEdit.Text
        
    End Sub

    Private Sub CalcCon()

        For Each drv As DataRowView In Me.FabricBindingSource.List

            On Error Resume Next

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
    
    Private Sub BandedGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged

    End Sub

    Private Sub IsConCompleteCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsConCompleteCheckEdit.CheckedChanged
        ConDateDateEdit.Text = Today()
    End Sub

    Private Sub SetCColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCColorButton.Click

        Dim row As OrderDataSet.FabricRow
        row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, OrderDataSet.FabricRow)


        Dim Color As String = ""
        Dim Color1 As String = ""

        Color = ColorCheckedComboBoxEdit.Text

        Color1 = Color.Replace(", ", "','") 'You should use one space after first comma
        Color1 = Trim(Color1)

        ExecuteQuery("Update FabricForSize Set ContrastColorId=" & CColorGridLookUpEdit.EditValue & " , Code='" & CodeTextBox.Text & "' Where FabricId=" & row.FabricId & " And FabricColorId in (Select FabricColorId From FabricColor Where FabricColorName in ( '" & Color1 & "'))", cnn)
        FabricForSizeTableAdapter.Fill(Me.OrderDataSet.FabricForSize)

    End Sub

    Private Sub CopyButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        Dim i As Integer = 0


        If FabricBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As OrderDataSet.FabricRow
        row = CType(CType(Me.FabricBindingSource.Current, DataRowView).Row, OrderDataSet.FabricRow)


        Do Until i = Val(CopyTextBox.Value)

            Dim newRow As OrderDataSet.FabricRow = Me.OrderDataSet.Fabric.NewRow()

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
                '.FabricBOMId = row.FabricBOMId
                .Con = row.Con
                .Length = 0

            End With

            Me.OrderDataSet.Fabric.Rows.Add(newRow)
            i = i + 1
        Loop
    End Sub

    Private Sub FabricBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles FabricBindingSource.AddingNew
        Me.OrderDataSet.Fabric.ExcessCuttingPercentageColumn.DefaultValue = Me.CuttingWPSpinEdit.Value
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

   
    
    Private Sub SetPercentageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each drv As DataRowView In Me.OrderCuttingPercentageBindingSource.List
            ExecuteQuery("Update OrderDetails Set CuttingPercentage=" & drv!CuttingPercentage, cnn)
        Next



    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click

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

    End Sub
End Class