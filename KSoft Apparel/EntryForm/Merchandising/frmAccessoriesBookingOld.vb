Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmAccessoriesBookingOld
    Dim cellvalue As String = ""
    Private Sub BookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

    End Sub

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)





        'Me.ItemStyleLookupTableAdapter.Fill(Me.BookingDataSet.ItemStyleLookup)
        Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)

        Me.BookingProgramNoLookupTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoLookup, DepartmentId)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.BookingDetailsTableAdapter.Fill(Me.BookingDataSet.BookingDetails)
        Me.BookingTableAdapter.Fill(Me.BookingDataSet.Booking, DepartmentId)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, DepartmentId)
        Me.BookingDataSet.Booking.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.BookingDataSet.Booking.BookingDateColumn.DefaultValue = Today()

        DisableControl(Me)


        If BookingBindingSource.Position > -1 Then

            BookingBindingSource.MoveLast()
            BookingProgramNoLookupBindingSource.MoveLast()

            ProgramNoComboBox.Enabled = True

        End If
        '====================================================
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select ProgramNo From [Order]", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            list.Add(reader.Item("ProgramNo").ToString)
        End While
        reader.Close()
        ProgramNoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ProgramNoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        ProgramNoTextBox.AutoCompleteCustomSource = list
        connection.Close()
        '===============================================================

        'Start -------- Check and Set user rights

        Dim CANEDIT As Boolean
        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Booking'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then

            NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = False
            SaveDetailsButton.Enabled = False

        End If

        'End ------- Check and Set user rights


    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&New" Then

            EnableFormControl(Me)
            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            BookingBindingSource.AddNew()
            BookingDateDateTimePicker.Focus()
            BookingDetailsGridControl.Enabled = False
            ProgramNoComboBox.Enabled = False
            SaveDetailsButton.Enabled = False


        ElseIf NewButton.Text = "&Save" Then

            'Saveing/Updating...
            If ProgramNoTextBox.Text = String.Empty Then

                ErrorProvider1.SetError(ProgramNoTextBox, "Program No is Require")
                ProgramNoTextBox.Focus()

                Exit Sub

            Else
                ErrorProvider1.Clear()
            End If


            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

            '===================================================

            NewButton.Text = "&Save Details"
            DisableFromControl(Me)
            BookingDetailsGridControl.Enabled = True
            SaveDetailsButton.Enabled = True


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

            '===================================================
            NewButton.Text = "&New"
            EditButton.Enabled = True
            If BookingDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            Else
                DeleteButton.Enabled = False
            End If
            CancelEntryButton.Enabled = False
            ProgramNoComboBox.Enabled = True
            BookingDetailsGridControl.Enabled = False
            SaveDetailsButton.Enabled = False
        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If EditButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            ProgramNoComboBox.Enabled = False

            BookingDetailsGridControl.Enabled = True
            SaveDetailsButton.Enabled = True

        Else

            'Saveing/Updating...
            If ProgramNoTextBox.Text = String.Empty Then

                ErrorProvider1.SetError(ProgramNoTextBox, "Program No is Require")
                ProgramNoTextBox.Focus()
                Exit Sub
            Else
                ErrorProvider1.Clear()
            End If

            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

            '===================================================
            DisableFromControl(Me)
            BookingDetailsGridControl.Enabled = False
            EditButton.Text = "&Edit"
            NewButton.Enabled = True
            If BookingBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False

            ProgramNoComboBox.Enabled = True

            BookingDetailsGridControl.Enabled = False
            SaveDetailsButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If DeleteButton.Text = "&Delete" Then

            DeleteButton.Text = "&Update"
            NewButton.Enabled = False
            EditButton.Enabled = False
            SaveDetailsButton.Enabled = False
            CancelEntryButton.Enabled = True
            If BookingBindingSource.Position > -1 Then
                BookingBindingSource.RemoveCurrent()
            End If



        Else

            'Saveing/Updating...
            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
            '======================================================
            If BookingDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If

            DeleteButton.Text = "&Delete"
            NewButton.Enabled = True
            EditButton.Enabled = True
            CancelEntryButton.Enabled = False
            SaveDetailsButton.Enabled = True

        End If
    End Sub

    Private Sub CancelEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryButton.Click

        'Reset
        Me.BookingTableAdapter.Fill(Me.BookingDataSet.Booking, DepartmentId)

        DisableFromControl(Me)
        NewButton.Enabled = True
        NewButton.Text = "&New"
        EditButton.Enabled = True
        EditButton.Text = "&Edit"

        If BookingDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        End If

        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
        ProgramNoComboBox.Enabled = True
        ErrorProvider1.Clear()

        SaveDetailsButton.Enabled = False


    End Sub

    Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged
        On Error Resume Next
        Me.BookingTableAdapter.FillByProgramNo(Me.BookingDataSet.Booking, DepartmentId, ProgramNoComboBox.SelectedValue.ToString)

    End Sub

    Private Sub BookingDetailsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookingDetailsBindingSource.PositionChanged, BookingDetailsBindingSource.CurrentChanged
        If BookingDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        Else
            DeleteButton.Enabled = False
        End If
    End Sub






    'Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
    '    If e.Column.Caption = "Item Style" Then
    '        If e.Value = "No Style" Then e.DisplayText = ""
    '    End If

    'End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        On Error Resume Next

        If AutocompleteCheckBox.Checked = False Then
            Exit Sub
        End If

        'Finding Booking Id

        Dim row As BookingDataSet.BookingRow
        row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

        'Filter By Booking Id

        Me.ItemColorLookupTableAdapter.Fill(Me.BookingDataSet.ItemColorLookup, row.BookingId)


        If e.Column.Caption = "Item Color" Then

            'Dim cellValue As String = e.Value.ToString() + " " + GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("ItemStyle")).ToString()
            'Filter By Item Color Cell Value

            ItemColorLookupBindingSource.Filter = "ItemColor LIKE '" & e.Value.ToString() & "' + '%'"

            If ItemColorLookupBindingSource.Position > -1 Then

                'Get ItemColor
                Dim row2 As BookingDataSet.ItemColorLookupRow
                row2 = CType(CType(Me.ItemColorLookupBindingSource.Current, DataRowView).Row, BookingDataSet.ItemColorLookupRow)


                If e.Value.ToString() <> "" Then

                    GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("ItemColor"), row2.ItemColor)


                End If

            Else

                Exit Sub

            End If

        End If

    End Sub

    Private Sub SaveDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDetailsButton.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.BookingDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
    End Sub


    'Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown

    '    If e.KeyData = Keys.F5 Then
    '        If colItemColor.Caption = "Item Color" Then
    '            If ItemColorLookupBindingSource.Position <> -1 Then

    '                ItemColorLookupBindingSource.MoveNext()

    '            End If

    '        End If
    '    End If

    'End Sub


    Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow

        'Dim view As ColumnView = CType(sender, ColumnView)
        'Dim column1 As GridColumn = view.Columns("ItemId")
        ''Get the value of the first column
        'Dim ItemId As Integer = view.GetRowCellValue(e.RowHandle, column1)
        ''Get the value of the second column
        ''Dim time2 As DateTime = CType(view.GetRowCellValue(e.RowHandle, column2), DateTime)
        ''Validity criterion
        'If ItemId = "" Then
        '    e.Valid = False
        '    'Set errors with specific descriptions for the columns
        '    view.SetColumnError(column1, "Item Name is require")
        '    'view.SetColumnError(column2, "The value must be greater than StartTime")
        'End If

    End Sub

    Private Sub BuyerIdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerIdComboBox.SelectedIndexChanged
        'Me.ItemStyleTableAdapter.FillByBuyerId(Me.BookingDataSet.ItemStyle, BuyerIdComboBox.SelectedValue)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)

    End Sub

    Private Sub ProgramNoTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.LostFocus

        Me.BookingProgramNoSearchTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoSearch, ProgramNoTextBox.Text)

        If Me.BookingProgramNoSearchBindingSource.Position > -1 Then

            ErrorProvider1.SetError(ProgramNoTextBox, "Booking for this Program has already been done")
            ProgramNoTextBox.Focus()

        Else

            ErrorProvider1.Clear()

        End If

    End Sub

    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.TextChanged

        On Error Resume Next
        StyleTextBox.Text = ReadStringData("Select StyleName From Style Where StyleId=(Select StyleId From [Order] Where ProgramNo='" & ProgramNoTextBox.Text & "')", cnn)
        RefNoTextEdit.Text = ReadStringData("Select StyleReferenceNo From [Order] Where ProgramNo='" & ProgramNoTextBox.Text & "'", cnn)
        BuyerIdComboBox.SelectedValue = ReadIntegerData("Select BuyerId From [Order] Where ProgramNo='" & ProgramNoTextBox.Text & "'", cnn)
        OrderDateDateEdit.Text = ReadDateData("Select OrderReceiveDate From [Order] Where ProgramNo='" & ProgramNoTextBox.Text & "'", cnn).ToString

        OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, ProgramNoTextBox.Text)

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ProgramNoTextBox.Text = ListBox1.SelectedValue.ToString
    End Sub


    Private Sub GenerateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GenerateLinkLabel.LinkClicked





    End Sub
End Class