Public Class frmBill

    Private Sub ConveyanceBillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        Me.TransportBillTableAdapter.Fill(Me.TransportDataSet.TransportBill)

        Me.FoodAllowanceBillTableAdapter.Fill(Me.FoodAllowanceDataSet.FoodAllowanceBill)

        Me.ConveyanceDetailsTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceDetails)

        Me.ConveyanceBillTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceBill, DepartmentId)




        Me.ConveyanceDataSet.ConveyanceBill.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.ConveyanceDataSet.ConveyanceBill.ConveyanceDateColumn.DefaultValue = Today

        Me.FoodAllowanceDataSet.FoodAllowanceBill.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.FoodAllowanceDataSet.FoodAllowanceBill.FADateColumn.DefaultValue = Today

        Me.TransportDataSet.TransportBill.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.TransportDataSet.TransportBill.TransportDateColumn.DefaultValue = Today

        DisableFromControl(Me)

        If CheckUserRights("Bill").CanEdit = False Then
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            EditButton.Enabled = False
            CancelEntryButton.Enabled = False

        ElseIf CheckUserRights("Bill").CanDelete = False Then
            NewButton.Enabled = True
            DeleteButton.Enabled = False
            EditButton.Enabled = True
            CancelEntryButton.Enabled = True

        End If

    End Sub

    'Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

    '    If AddButton.Text = "&New" Then

    '        AddButton.Text = "&Save"
    '        ConveyanceBillBindingSource.AddNew()
    '        Me.ConveyanceDetailsDataGridView.ReadOnly = True
    '        Me.SaveDetailsButton.Enabled = False

    '    Else

    '        Me.Validate()
    '        Me.ConveyanceBillBindingSource.EndEdit()
    '        Me.TableAdapterManager.UpdateAll(Me.ConveyanceDataSet)
    '        AddButton.Text = "&New"
    '        Me.ConveyanceDetailsDataGridView.ReadOnly = False
    '        Me.SaveDetailsButton.Enabled = True
    '    End If


    'End Sub

    'Private Sub FoodAllowanceAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodAllowanceAddButton.Click
    '    If Me.FoodAllowanceAddButton.Text = "&New" Then
    '        Me.FoodAllowanceAddButton.Text = "&Save"
    '        Me.FoodAllowanceBillBindingSource.AddNew()
    '    Else
    '        Me.Validate()
    '        Me.FoodAllowanceBillBindingSource.EndEdit()
    '        Me.TableAdapterManager1.UpdateAll(Me.FoodAllowanceDataSet)
    '        Me.FoodAllowanceAddButton.Text = "&New"
    '    End If

    'End Sub

    'Private Sub TransportBillAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportBillAddButton.Click

    '    If TransportBillAddButton.Text = "&New" Then

    '        Me.TransportBillAddButton.Text = "&Save"
    '        Me.TransportBillBindingSource.AddNew()

    '    Else

    '        Me.Validate()
    '        Me.TransportBillBindingSource.EndEdit()
    '        Me.TableAdapterManager2.UpdateAll(Me.TransportDataSet)
    '        Me.TransportBillAddButton.Text = "&New"

    '    End If


    'End Sub

    
    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&New" Then

            EnableFormControl(Me)
            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            ConveyanceBillBindingSource.AddNew()


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.ConveyanceBillBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ConveyanceDataSet)

            '===================================================



            DisableFromControl(Me)
            NewButton.Text = "&New"
            EditButton.Enabled = True
            If ConveyanceDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False

        End If



    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If EditButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.ConveyanceBillBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ConveyanceDataSet)

            '===================================================



            DisableFromControl(Me)
            EditButton.Text = "&Edit"
            NewButton.Enabled = True
            If ConveyanceDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False


        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If DeleteButton.Text = "&Delete" Then

            DeleteButton.Text = "&Update"
            NewButton.Enabled = False
            EditButton.Enabled = False
            CancelEntryButton.Enabled = True
            ConveyanceBillBindingSource.RemoveCurrent()


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.ConveyanceBillBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ConveyanceDataSet)
            '======================================================


            DeleteButton.Text = "&Delete"
            NewButton.Enabled = True
            EditButton.Enabled = True
            CancelEntryButton.Enabled = False


        End If
    End Sub

    Private Sub CancelEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryButton.Click
        'Reset
        Me.ConveyanceDetailsTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceDetails)

        Me.ConveyanceBillTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceBill,DepartmentId)
        

        DisableFromControl(Me)
        NewButton.Enabled = True
        NewButton.Text = "&New"
        EditButton.Enabled = True
        EditButton.Text = "&Edit"
        If ConveyanceDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        End If
        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
    End Sub

    
    Private Sub NewFAButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFAButton.Click
        If NewFAButton.Text = "&New" Then

            EnableFormControl(Me)
            NewFAButton.Text = "&Save"
            EditFAButton.Enabled = False
            DeleteFAButton.Enabled = False
            CancelEntryFAButton.Enabled = True
            FoodAllowanceBillBindingSource.AddNew()


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.FoodAllowanceBillBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.FoodAllowanceDataSet)

            '===================================================



            DisableFromControl(Me)
            NewFAButton.Text = "&New"
            EditFAButton.Enabled = True
            DeleteFAButton.Enabled = True
            CancelEntryFAButton.Enabled = False

        End If
    End Sub

    Private Sub EditFAButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFAButton.Click
        If EditFAButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditFAButton.Text = "&Update"
            NewFAButton.Enabled = False
            DeleteFAButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.FoodAllowanceBillBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.FoodAllowanceDataSet)

            '===================================================



            DisableFromControl(Me)
            EditFAButton.Text = "&Edit"
            NewFAButton.Enabled = True
            DeleteFAButton.Enabled = True
            CancelEntryFAButton.Enabled = False


        End If
    End Sub

    Private Sub DeleteFAButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFAButton.Click

        If DeleteFAButton.Text = "&Delete" Then

            DeleteFAButton.Text = "&Update"
            NewFAButton.Enabled = False
            EditFAButton.Enabled = False
            CancelEntryFAButton.Enabled = True
            FoodAllowanceBillBindingSource.RemoveCurrent()


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.FoodAllowanceBillBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.FoodAllowanceDataSet)
            '=========================================================


            DeleteFAButton.Text = "&Delete"
            NewFAButton.Enabled = True
            EditFAButton.Enabled = True
            CancelEntryFAButton.Enabled = False


        End If

    End Sub

    Private Sub CancelEntryFAButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryFAButton.Click

        'Reset
        Me.FoodAllowanceBillTableAdapter.Fill(Me.FoodAllowanceDataSet.FoodAllowanceBill)

        DisableFromControl(Me)
        NewFAButton.Enabled = True
        NewFAButton.Text = "&New"
        EditFAButton.Enabled = True
        EditFAButton.Text = "&Edit"
        DeleteFAButton.Enabled = True
        DeleteFAButton.Text = "&Delete"
        CancelEntryFAButton.Enabled = False

    End Sub

    Private Sub NewTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTButton.Click

        If NewTButton.Text = "&New" Then

            EnableFormControl(Me)
            NewTButton.Text = "&Save"
            EditTButton.Enabled = False
            DeleteTButton.Enabled = False
            CancelEntryTButton.Enabled = True
            TransportBillBindingSource.AddNew()


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.TransportBillBindingSource.EndEdit()
            Me.TableAdapterManager2.UpdateAll(Me.TransportDataSet)
            '===================================================

            DisableFromControl(Me)
            NewTButton.Text = "&New"
            EditTButton.Enabled = True
            DeleteTButton.Enabled = True
            CancelEntryFAButton.Enabled = False

        End If

    End Sub

    Private Sub EditTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTButton.Click

        If EditTButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditTButton.Text = "&Update"
            NewTButton.Enabled = False
            DeleteTButton.Enabled = False
            CancelEntryTButton.Enabled = True


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.TransportBillBindingSource.EndEdit()
            Me.TableAdapterManager2.UpdateAll(Me.TransportDataSet)

            '===================================================



            DisableFromControl(Me)
            EditTButton.Text = "&Edit"
            NewTButton.Enabled = True
            DeleteTButton.Enabled = True
            CancelEntryTButton.Enabled = False


        End If

    End Sub

    Private Sub DeleteTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTButton.Click

        If DeleteTButton.Text = "&Delete" Then

            DeleteTButton.Text = "&Update"
            NewTButton.Enabled = False
            EditTButton.Enabled = False
            CancelEntryTButton.Enabled = True
            TransportBillBindingSource.RemoveCurrent()

        Else

            'Saveing/Updating...
            Me.Validate()
            Me.TransportBillBindingSource.EndEdit()
            Me.TableAdapterManager2.UpdateAll(Me.TransportDataSet)
            '=========================================================


            DeleteTButton.Text = "&Delete"
            NewTButton.Enabled = True
            EditTButton.Enabled = True
            CancelEntryTButton.Enabled = False

        End If

    End Sub

    Private Sub CancelEntryTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryTButton.Click
        'Reset
        Me.TransportBillTableAdapter.Fill(Me.TransportDataSet.TransportBill)

        DisableFromControl(Me)
        NewTButton.Enabled = True
        NewTButton.Text = "&New"
        EditTButton.Enabled = True
        EditTButton.Text = "&Edit"
        DeleteTButton.Enabled = True
        DeleteTButton.Text = "&Delete"
        CancelEntryTButton.Enabled = False

    End Sub

    Private Sub ConveyanceTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveyanceTab.Click

    End Sub
End Class