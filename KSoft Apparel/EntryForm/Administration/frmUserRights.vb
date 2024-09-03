Imports System.Data
Imports System.Data.SqlClient
Public Class frmUserRights

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserRightsDataSet)

    End Sub

    Private Sub frmUserRights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

        Me.ParentMenuLookupTableAdapter.Fill(Me.PartenMenuLookupDataSet.ParentMenuLooup)

        'Me.UserTableAdapter1.Fill(Me.UserDataSet.User)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.MenuTableAdapter.Fill(Me.MenuDataSet.Menu)
        Me.UserRightsTableAdapter.Fill(Me.UserRightsDataSet.UserRights)

        LoadAutoCompleteList("Select Distinct User_Name From [User]", USER_NAMETextBox)


    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.UserBindingSource.EndEdit()
            Me.UserRightsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UserRightsDataSet)

            

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            MessageBox.Show("Saved Successfully")
        End Try



    End Sub

    Private Sub PASSWORDTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PASSWORDTextBox.DoubleClick
        If PASSWORDTextBox.PasswordChar = "" Then
            PASSWORDTextBox.PasswordChar = "*"
        ElseIf PASSWORDTextBox.PasswordChar = "*" Then
            PASSWORDTextBox.PasswordChar = ""
        End If
    End Sub


    Private Sub LoadMenu()

        Dim sqlstring As String = "Select Menu_Id,Parent_Id From Menu"
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'Dim list As New AutoCompleteStringCollection

        While reader.Read
            'If reader.IsDBNull( = False Then
            '    'list.Add(reader.GetString(0))
            'End If

            'MessageBox.Show(reader("Menu_Id"))

            Dim row As UserRightsDataSet.UserRow
            row = CType(CType(Me.UserBindingSource.Current, DataRowView).Row, UserRightsDataSet.UserRow)


            Dim CheckExistMenuId As Integer = ReadIntegerData("Select Menu_Id From UserRights Where User_Id=" & row.USER_ID & "and Menu_Id=" & Val(reader("Menu_Id").ToString), cnn)



            'MessageBox.Show(CheckExistMenuId.ToString)

            If CheckExistMenuId = 0 Then

                'MessageBox.Show(CheckExistMenuId.ToString)
                Dim newRow As UserRightsDataSet.UserRightsRow = Me.UserRightsDataSet.UserRights.NewRow()

                newRow.USER_ID = row.USER_ID
                newRow.MENU_ID = reader("Menu_Id")
                newRow.PARENT_ID = reader("Parent_Id")
                newRow.CAN_DELETE = 0
                newRow.CAN_EDIT = 0
                newRow.CAN_VIEW = 0

                Me.UserRightsDataSet.UserRights.Rows.Add(newRow)
            Else

                ExecuteQuery("Update UserRights Set Parent_Id=" & reader("Parent_Id") & " Where User_Id=" & row.USER_ID & "and Menu_Id=" & Val(reader("Menu_Id").ToString), cnn)

            End If


        End While

        reader.Close()
        connection.Close()

        MessageBox.Show("List Updated Successfully", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

   

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Try


            Me.UserTableAdapter.FillByUserId(Me.UserRightsDataSet.User, GridLookUpEdit1.EditValue)


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub UpdateListToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateListToolStripButton.Click
        Try
            Me.Validate()
            Me.UserBindingSource.EndEdit()
            Me.UserRightsBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.UserRightsDataSet)

        Catch ex As Exception

            Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
            Me.MenuTableAdapter.Fill(Me.MenuDataSet.Menu)
            Me.UserRightsTableAdapter.Fill(Me.UserRightsDataSet.UserRights)


        End Try


        LoadMenu()
    End Sub

    Private Sub SetSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetSimpleButton.Click
        For Each drv As DataRowView In UserRightsBindingSource.List

            If drv!Parent_Id = GridLookUpEdit2.EditValue Then


                drv!Can_View = ViewCheckBox.Checked
                drv!Can_Delete = DeleteCheckBox.Checked
                drv!Can_Edit = EditCheckBox.Checked

            End If
        Next
    End Sub

    Private Sub MenuNameSearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNameSearchTextBox.TextChanged
        Me.UserRightsTableAdapter.FillByContainSearch(Me.UserRightsDataSet.UserRights, GridLookUpEdit1.EditValue, MenuNameSearchTextBox.Text)
    End Sub


    Private Sub RefreshMaster()
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.MenuTableAdapter.Fill(Me.MenuDataSet.Menu)
        Me.UserRightsTableAdapter.Fill(Me.UserRightsDataSet.UserRights)
    End Sub

    Private Sub RefreshToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripButton.Click
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.MenuTableAdapter.Fill(Me.MenuDataSet.Menu)
        Me.UserRightsTableAdapter.Fill(Me.UserRightsDataSet.UserRights)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
    End Sub

    Private Sub PrintSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSimpleButton.Click
        ShowForm(frmSoftwareUserList)
    End Sub
End Class