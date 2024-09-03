Imports System.Configuration
Public Class frmAddNewAccessories
    Private _AccId As Integer
    Public Property AccId() As Integer
        Get
            Return _AccId
        End Get
        Set(ByVal value As Integer)
            _AccId = value
        End Set
    End Property
    Private _StyleId As Integer
    Public Property StyleId() As Integer
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Integer)
            _StyleId = value
        End Set
    End Property

    Private Sub frmAddNewAccessories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.SubCategoryTableAdapter.Fill(Me.SubCategoryDataSet.SubCategory)

        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, My.Settings.AccDepartmentId)


        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)


        'LoadAutoCompleteList("Select Distinct Category From AccessoriesList", CategoryTextBox)
        LoadAutoCompleteList("Select Distinct AccessoriesName From AccessoriesList", AccessoriesNameTextBox)

        'If Me.AccId = 0 Then
        AccessoriesListDataSet.Clear()
        Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
        Me.AccessoriesListDataSet.AccessoriesList.UnitIdColumn.DefaultValue = 4
        Me.AccessoriesListDataSet.AccessoriesList.BuyerIdColumn.DefaultValue = ReadIntegerData("Select BuyerId From Style Where StyleId=" & Me.StyleId, cnn)


        AccessoriesListBindingSource.AddNew()
        NewLinkLabel.Text = "Save"
        AccessoriesNameTextBox.Focus()
        'Else

        '    EditLinkLabel.Text = "Update"
        '    Me.AccessoriesListTableAdapter.FillByAccId(Me.AccessoriesListDataSet.AccessoriesList, Me.AccId)

        'End If

    End Sub










    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            AccessoriesListBindingSource.AddNew()
            'AccessoriesListDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"
            AccessoriesNameTextBox.Focus()


        Else
            Try
                Me.Validate()
                Me.AccessoriesListBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.AccessoriesListDataSet)
                'AccessoriesListDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        If EditLinkLabel.Text = "Edit" Then
            'AccessoriesListDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.AccessoriesListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AccessoriesListDataSet)
            'AccessoriesListDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            'AccessoriesListDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If

    End Sub


    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked

        Me.AccessoriesListTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesList)

        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"

    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If AccessoriesListBindingSource.Position > -1 Then
            AccessoriesListBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Try
            Me.Validate()
            Me.AccessoriesListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AccessoriesListDataSet)
            NewLinkLabel.Text = "Add"
            EditLinkLabel.Text = "Edit"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AccId = Me.AccessoriesIdSpinEdit.EditValue
        Me.Close()

    End Sub



    Private Sub PicturePictureEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicturePictureEdit.DoubleClick
        PicturePictureEdit.LoadImage()

    End Sub

    Private Sub ItemStyleIdGridLookUpEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemStyleIdGridLookUpEdit.DoubleClick

        With frmItemStyle
            .WindowState = FormWindowState.Normal
            .Show(frmStyleCapture_Accessories)
        End With

        If frmItemStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)

            Dim indx As Integer = Me.ItemStyleBindingSource.Find("ItemStyleId", frmItemStyle.ItemStyleId)
            Me.ItemStyleBindingSource.Position = indx

        End If

    End Sub





    Private Sub ItemStyleLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ItemStyleLinkLabel.LinkClicked

        ShowMaster(frmItemStyle)

        If frmItemStyle.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)
            ItemStyleIdGridLookUpEdit.EditValue = frmItemStyle.ItemStyleId

        End If

    End Sub

    Private Sub frmAddNewAccessories_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub CategoryIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryIdGridLookUpEdit.EditValueChanged
        Me.SubCategoryTableAdapter.FillByCategoryid(Me.SubCategoryDataSet.SubCategory, CategoryIdGridLookUpEdit.EditValue)
    End Sub
End Class