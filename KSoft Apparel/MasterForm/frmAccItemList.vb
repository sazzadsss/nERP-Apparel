Public Class frmAccItemList

    Private _ItemID As Integer
    Public Property ItemID() As Integer
        Get
            Return _ItemID
        End Get
        Set(ByVal value As Integer)
            _ItemID = value
        End Set
    End Property
    Private _BuyerId As Integer
    Public Property BuyerId() As Integer
        Get
            Return _BuyerId
        End Get
        Set(ByVal value As Integer)
            _BuyerId = value
        End Set
    End Property

    Private Sub frmAccItemList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SupplierLookupTableAdapter.Fill(Me.SupplierDataSet.SupplierLookup)
        'Me.NominatedSupplierTableAdapter.Fill(Me.ItemListDataSet.NominatedSupplier)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        'Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, My.Settings.AccDepartmentId)

        Me.ItemListDataSet.ItemList.DepartmentIdColumn.DefaultValue = Val(My.Settings.AccDepartmentId)
        Me.ItemListDataSet.ItemList.AccBuyerIdColumn.DefaultValue = BuyerId


        On Error Resume Next

        Me.ItemListBindingSource.AddNew()

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, CType(DepartmentIdToolStripTextBox.Text, Long))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub AccItemNameTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemNameTextEdit.EditValueChanged
        On Error Resume Next
        Me.ItemListLookupTableAdapter.FillByAccName(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, Me.BuyerId)
        GenerateFullAccName()
    End Sub




    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click


        If ItemListLookupBindingSource.Position > -1 Then

            Dim row As ItemListDataSet.ItemListLookupRow
            row = CType(CType(Me.ItemListLookupBindingSource.Current, DataRowView).Row, ItemListDataSet.ItemListLookupRow)
            Me.ItemID = row.ItemId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub CnclButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CnclButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try

            If AccItemNameTextEdit.Text = String.Empty Then

                MessageBox.Show("Accessories Name is Require")
                Exit Sub

            ElseIf UnitIdGridLookUpEdit.Text = String.Empty Then

                MessageBox.Show("Unit is Require")
                Exit Sub

                'ElseIf AccBuyerIdGridLookUpEdit.Text = String.Empty Then

                '    MessageBox.Show("Buyer is Require")
                '    Exit Sub

            End If



            'ExecuteQuery("Insert into ItemList(ItemName,AccItemName,AccItemStyle,CurrentPrice,DepartmentId,AccBuyerId,UnitId)values('" & ItemName & "','" & Me.AccItemNameTextEdit.Text & "','" & Me.AccItemStyleMemoEdit.Text & "'," & Me.CurrentPriceSpinEdit.Value & "," & My.Settings.AccDepartmentId & "," & Me.AccBuyerIdGridLookUpEdit.EditValue & "," & Me.UnitIdGridLookUpEdit.EditValue & ")", cnn)

            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.ItemListTableAdapter.Update(Me.ItemListDataSet.ItemList)
            'Me.NominatedSupplierTableAdapter.Update(Me.ItemListDataSet.NominatedSupplier)

            'Saveing ..

            If AccItemStyleMemoEdit.Text = String.Empty Then
                Me.ItemListLookupTableAdapter.FillByAccName(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, Me.BuyerId)
            Else
                Me.ItemListLookupTableAdapter.FillByAccNameAndStyle(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, AccItemStyleMemoEdit.Text, Me.BuyerId)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub



    Private Sub GenerateFullAccName()

        On Error Resume Next
        Dim ItemName As String = "{0}{1}{2}"
        Dim BCode As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & AccBuyerIdGridLookUpEdit.EditValue, cnn)
        Dim AccName As String = Me.AccItemNameTextEdit.Text
        Dim AccStyle As String = ""

        If Me.AccItemStyleMemoEdit.Text <> String.Empty Then
            AccStyle = "\" & Me.AccItemStyleMemoEdit.Text
        End If

        If Me.AccBuyerIdGridLookUpEdit.Text <> String.Empty Then
            BCode = "\" & BCode.ToString()
        End If

        ItemName = System.String.Format(ItemName, AccName, AccStyle, BCode)
        ItemNameMemoEdit.Text = ItemName

    End Sub

    Private Sub AccBuyerIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccBuyerIdGridLookUpEdit.EditValueChanged
        GenerateFullAccName()
    End Sub

    Private Sub AccItemStyleMemoEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemStyleMemoEdit.EditValueChanged
        Me.ItemListLookupTableAdapter.FillByAccNameAndStyle(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, AccItemStyleMemoEdit.Text, BuyerId)
        GenerateFullAccName()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NominatedSupplierGridControl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NominatedSupplierGridControl_Enter(sender As Object, e As EventArgs)
        Me.ItemListBindingSource.EndEdit()
    End Sub

    Private Sub NominatedSupplierBindingSource_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs)
        Try
            If AccItemNameTextEdit.Text = String.Empty Then

                MessageBox.Show("Accessories Name is Require")
                Exit Sub

            ElseIf UnitIdGridLookUpEdit.Text = String.Empty Then

                MessageBox.Show("Unit is Require")
                Exit Sub

            ElseIf AccBuyerIdGridLookUpEdit.Text = String.Empty Then

                MessageBox.Show("Buyer is Require")
                Exit Sub

            End If

            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.ItemListTableAdapter.Update(Me.ItemListDataSet.ItemList)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ItemListLookupBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ItemListLookupBindingSource.PositionChanged

        If Me.ItemListLookupBindingSource.Position > -1 Then
            Dim row As ItemListDataSet.ItemListLookupRow
            row = CType(CType(Me.ItemListLookupBindingSource.Current, DataRowView).Row, ItemListDataSet.ItemListLookupRow)
            Me.ItemListDataSet.NominatedSupplier.ItemIdColumn.DefaultValue = row.ItemId
            Me.NominatedSupplierTableAdapter.Fill(Me.ItemListDataSet.NominatedSupplier, New System.Nullable(Of Long)(CType(row.ItemId, Long)))


        End If

    End Sub

    Private Sub SaveSupplierButton_Click(sender As Object, e As EventArgs) Handles SaveSupplierButton.Click
        Try
            Me.Validate()
            Me.NominatedSupplierBindingSource.EndEdit()
            Me.NominatedSupplierTableAdapter.Update(Me.ItemListDataSet.NominatedSupplier)

            'Me.NominatedSupplierTableAdapter.Fill(Me.ItemListDataSet.NominatedSupplier, New System.Nullable(Of Long)(CType(row.ItemId, Long)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


End Class