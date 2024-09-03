Imports System.Data
Imports System.Data.SqlClient


Public Class frmStyleCapture_Accessories
    Private _StyleId As Integer

    Public Property StyleId() As Integer
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Integer)
            _StyleId = value
        End Set
    End Property

    Private Sub StyleCapture_AccessoriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleCapture_AccessoriesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.StyleCapture_AccessoriesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StylewiseAccessoriesDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub

    Private Sub frmStyleCapture_Accessories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ItemStyleTableAdapter.Fill(Me.ItemStyleDataSet.ItemStyle)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.ItemListDepartmentTableAdapter.Fill(Me.ItemListDataSet.ItemListDepartment, Val(My.Settings.AccDepartmentId))

        If DBNull.Value.Equals(Me.StyleId) = False Then

            StyleLookupGridLookUpEdit.EditValue = Me.StyleId

            Me.StyleCapture_AccessoriesTableAdapter.FillByStyleId(Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories, Me.StyleId)
            Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.StyleIdColumn.DefaultValue = Me.StyleId
            BindingNavigatorAddNewItem.Enabled = True

        End If

    End Sub

    Private Sub StyleLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleLookupGridLookUpEdit.EditValueChanged, StyleLookupGridLookUpEdit.Closed

        On Error Resume Next

        If StyleBindingSource.Position > -1 Then


            Dim row As StyleLookupDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleLookupDataSet.StyleRow)

            'MessageBox.Show(StyleLookupGridLookUpEdit.EditValue.ToString)

            Me.StyleCapture_AccessoriesTableAdapter.FillByStyleId(Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories, row.StyleId)
            Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.StyleIdColumn.DefaultValue = row.StyleId
            BindingNavigatorAddNewItem.Enabled = True


        Else

            BindingNavigatorAddNewItem.Enabled = False

        End If

    End Sub

#Region "Procedure-GetData"

    Private Sub GetData()

        If StyleCapture_AccessoriesBindingSource.Position = -1 Then

            Dim BId As Integer = ReadIntegerData("Select BuyerId From Style Where StyleId=" & Me.StyleLookupGridLookUpEdit.EditValue, cnn)

            'MessageBox.Show(BId.ToString)

            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select ItemId,IsSizeWise,IsColorWise,IsDestinationWise,WastagePercentage,IsPack,PackType,IsCosting,SupplierId,Remarks,UnitId From AccessoriesTemplate Where BuyerId=" & BId, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Read()



            While reader.Read()

                Dim newRow As StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow = Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.NewRow()

                On Error Resume Next

                newRow.ItemId = reader("ItemId")
                newRow.IsSizeWise = CType(IIf(reader("IsSizeWise") = True, 1, 0), Boolean)
                newRow.IsColorWise = CType(IIf(reader("IsColorWise") = True, 1, 0), Boolean)
                newRow.IsDestinationWise = CType(IIf(reader("IsDestinationWise") = True, 1, 0), Boolean)
                newRow.WastagePercentage = reader("WastagePercentage")
                newRow.IsPack = CType(IIf(reader("IsPack") = True, 1, 0), Boolean)
                newRow.PackType = reader("PackType")
                newRow.IsCosting = CType(IIf(reader("IsCosting") = True, 1, 0), Boolean)
                newRow.SupplierId = reader("SupplierID")
                newRow.Remarks = reader.GetString(9)
                newRow.ConUnitId = reader("UnitId")
                newRow.Consumption = 0
                newRow.GarmentsQuantity = 1
                newRow.StyleId = CType(StyleLookupGridLookUpEdit.EditValue.ToString, Long)


                Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.Rows.Add(newRow)


            End While

            'Me.StyleCapture_AccessoriesTableAdapter.FillByStyleId(Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories, StyleLookupGridLookUpEdit.EditValue)

            reader.Close()
            connection.Close()

        End If

    End Sub

#End Region


#Region "Procedure-GetDataFromStyle"

    Private Sub GetDataFromStyle()

        If StyleCapture_AccessoriesBindingSource.Position = -1 Then


            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select ItemId,IsSizeWise,IsColorWise,IsDestinationWise,WastagePercentage,IsPack,PackType,IsCosting,SupplierId,Remarks,ConUnitId,Consumption,GarmentsQuantity,SLNo From StyleCapture_Accessories Where StyleId=" & Me.StyleLookupGridLookUpEdit2.EditValue, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Read()



            While reader.Read()

                Dim newRow As StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow = Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.NewRow()

                On Error Resume Next

                newRow.ItemId = reader("ItemId")
                newRow.IsSizeWise = reader("IsSizeWise")
                newRow.IsColorWise = reader("IsColorWise")
                newRow.IsDestinationWise = reader("IsDestinationWise")
                newRow.WastagePercentage = reader("WastagePercentage")
                newRow.IsPack = reader("IsPack")
                newRow.PackType = reader("PackType")
                newRow.IsCosting = reader("IsCosting")
                newRow.SupplierId = reader("SupplierId")
                newRow.Remarks = reader("Remarks")
                newRow.ConUnitId = reader("ConUnitId")
                newRow.Consumption = reader("Consumption")
                newRow.GarmentsQuantity = reader("GarmentsQuantity")
                newRow.SLNO = reader("SLNO")
                newRow.StyleId = StyleLookupGridLookUpEdit.EditValue


                Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.Rows.Add(newRow)


            End While

            'Me.StyleCapture_AccessoriesTableAdapter.FillByStyleId(Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories, StyleLookupGridLookUpEdit.EditValue)

            reader.Close()
            connection.Close()

        End If

    End Sub

#End Region

    Private Sub InsertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim BId As Integer = ReadIntegerData("Select BuyerId From Style Where StyleId=" & Me.StyleLookupGridLookUpEdit.EditValue & "", cnn)
        'Dim ATRowCount As Integer = ReadIntData("Select Count(*) From AccessoriesTemplate Where BuyerId=" & BId, cnn)


        'If ATRowCount < 1 Then
        '    For Each drv As DataRowView In StyleCapture_AccessoriesBindingSource.List

        '        Dim IsSizeWise As Integer = IIf(drv!IsSizeWise = True, 1, 0)
        '        Dim IsColorWise As Integer = IIf(drv!IsColorWise = True, 1, 0)
        '        Dim IsDestinationWise As Integer = IIf(drv!IsDestinationWise = True, 1, 0)
        '        Dim IsPack As Integer = IIf(drv!IsPack = True, 1, 0)
        '        Dim IsCosting As Integer = IIf(drv!IsCosting = True, 1, 0)

        '        ExecuteQuery("Insert into AccessoriesTemplate(ItemId,BuyerId,IsSizeWise,IsColorWise,IsDestinationWise,WastagePercentage,IsPack,PackType,IsCosting,SupplierId,UnitId,Remarks)values(" & drv!ItemId & "," & BId & "," & IsSizeWise & "," & IsColorWise & "," & IsDestinationWise & "," & drv!WastagePercentage & "," & IsPack & ",'" & drv!PackType & "'," & IsCosting & "," & drv!SupplierId & "," & drv!ConUnitId & ",'" & drv!Remarks & "')", cnn)

        '    Next

        '    MessageBox.Show("Accessories Template has been created Successfully", "Inserted to Accessories Template", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Accessories Template is Already Available", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

    End Sub


    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click

        GetData()

    End Sub


    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        'If e.Column.Caption = "Item/Style" Then

        '    Dim row As StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow
        '    row = CType(CType(Me.StyleCapture_AccessoriesBindingSource.Current, DataRowView).Row, StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow)

        '    If e.Value.ToString() <> "" Then


        '        Dim WastagePercentage As Integer = ReadIntData("Select WastagePercentage From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim TUnitId As Integer = ReadIntegerData("Select UnitId From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim IsSizeWise As Boolean = ReadBooleanData("Select IsSizeWise From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim IsColorWise As Boolean = ReadBooleanData("Select IsColorWise From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim IsPack As Boolean = ReadBooleanData("Select IsPack From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim PackType As String = ReadStringData("Select PackType From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim IsCosting As Boolean = ReadBooleanData("Select IsCosting From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)
        '        Dim SupplierId As Integer = ReadIntegerData("Select SupplierId From ItemList Where AccessoriesId=" & row.AccessoriesId, cnn)


        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("WastagePercentage"), WastagePercentage)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("TUnitId"), TUnitId)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsSizeWise"), IsSizeWise)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsColorWise"), IsColorWise)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsPack"), IsPack)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("PackType"), PackType)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsCosting"), IsCosting)
        '        GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("SupplierId"), SupplierId)


        '    End If


        'End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddNewAcc()


    End Sub
    Private Sub AddNewAcc()

        If Me.StyleCapture_AccessoriesBindingSource.Position > -1 Then


            Dim row As StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow
            row = CType(CType(Me.StyleCapture_AccessoriesBindingSource.Current, DataRowView).Row, StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow)

            'If row.IsAccessoriesIdNull = True Then
            '    frmAddNewAccessories.AccId = row.AccessoriesId

            'Else
            'frmAddNewAccessories.AccId = 0
            'frmAddNewAccessories.StyleId = row.StyleId
            'ShowMaster(frmAddNewAccessories)
            'End If


            'If frmAddNewAccessories.DialogResult = System.Windows.Forms.DialogResult.OK Then

            '    'Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
            '    'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "AccessoriesId", frmAddNewAccessories.AccId)

            'End If

        End If
    End Sub
    
    Private Sub RefreshToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripButton.Click
        Me.ItemListDepartmentTableAdapter.Fill(Me.ItemListDataSet.ItemListDepartment, My.Settings.AccDepartmentId)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
       

        On Error Resume Next
        Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.Columns("SLNo").DefaultValue = StyleCapture_AccessoriesBindingSource.Count + 1


       
    End Sub

    Private Sub frmStyleCapture_Accessories_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        On Error Resume Next

        If e.KeyData = Keys.F11 Or e.KeyData = Keys.Control + Keys.F11 Then

            ShowMaster(frmAccItemList)

            If frmAccItemList.DialogResult = System.Windows.Forms.DialogResult.OK Then
                GridView1.SetFocusedRowCellValue("ItemId", frmAccItemList.ItemID)
            End If

        ElseIf e.KeyData = Keys.F3 Or e.KeyData = Keys.Control + Keys.F3 Then

            Me.StylewiseAccessoriesDataSet.StyleCapture_Accessories.Columns("SLNo").DefaultValue = StyleCapture_AccessoriesBindingSource.Count + 1
            StyleCapture_AccessoriesBindingSource.AddNew()

        End If

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GetDataFromStyle()
    End Sub
End Class