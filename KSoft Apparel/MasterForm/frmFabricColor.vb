Public Class frmFabricColor
    
    Private _FabricColorId As Integer
    Public Property FabricColorId() As Integer
        Get
            Return _FabricColorId
        End Get
        Set(ByVal value As Integer)
            _FabricColorId = value
        End Set
    End Property

    Private _OnlyAddflag As Boolean
    Public Property OnlyAddflag() As Boolean
        Get
            Return _OnlyAddflag
        End Get
        Set(ByVal value As Boolean)
            _OnlyAddflag = value
        End Set
    End Property

    Private Sub frmFabricColor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.SearchTextBox.Focus()
    End Sub



    Private Sub frmFabricColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserTableAdapter.Fill(Me.UserDataSet.User)


        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.FabricColorDataGridView.ReadOnly = True

        Me.FabricColorDataSet.FabricColor.UserIdColumn.DefaultValue = MainModule.UserId
        Me.FabricColorDataSet.FabricColor.ModifiedDateColumn.DefaultValue = Now()

        '========================================
        'Set Userrights
        If CheckUserRights("Fabric Color").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Fabric Color").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If
    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked

        If NewLinkLabel.Text = "Add" Then
            If Len(SearchTextBox.Text) = 0 Then
                Exit Sub
            End If
            FabricColorBindingSource.AddNew()
            FabricColorDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"
            EditLinkLabel.Enabled = False
            FabricColorNameTextBox.ReadOnly = True

            Me.FabricColorNameTextBox.ReadOnly = False

        Else

            Try
                If Len(SearchTextBox.Text) = 0 Then
                    Exit Sub
                End If
                Dim clrCount As Integer = ReadIntData("Select Count(*) From FabricColor Where FabricColorName='" & Me.SearchTextBox.Text.ToString() & "'", cnn)

                If clrCount > 0 Then
                    MessageBox.Show("Color Already Exists", "Color Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SearchTextBox.Focus()
                    Exit Sub
                End If

                Me.Validate()
                Me.FabricColorBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FabricColorDataSet)
                FabricColorDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
                EditLinkLabel.Enabled = True
                FabricColorNameTextBox.ReadOnly = False

                'SendSMTP("uzzal@echotexbd.com", "Uzzal", "mahmud@echotexbd.com", "mahmud", "uzzal@echotexbd.com", "Uzzal", "FabricColorChanged", "Added-" & FabricColorNameTextBox.Text.ToString, "", "")

            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try

        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged

        On Error Resume Next

        If StartWithRadioButton.Checked Then
            Me.FabricColorTableAdapter.FillByStartWith(Me.FabricColorDataSet.FabricColor, SearchTextBox.Text)
        Else
            Me.FabricColorTableAdapter.FillByFabricColor(Me.FabricColorDataSet.FabricColor, SearchTextBox.Text)
        End If

        Me.FabricColorDataSet.FabricColor.FabricColorNameColumn.DefaultValue = SearchTextBox.Text.ToString.ToUpper

    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If FabricColorBindingSource.Position > -1 Then
            FabricColorBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
        NewLinkLabel.Enabled = True
        EditLinkLabel.Enabled = True
        Me.FabricColorNameTextBox.ReadOnly = True

    End Sub


    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        Dim row As FabricColorDataSet.FabricColorRow
        row = CType(CType(Me.FabricColorBindingSource.Current, DataRowView).Row, FabricColorDataSet.FabricColorRow)

        If IsAlreadyUsed("FabricColorId", row.FabricColorId, "FabricColor") = True Then
            Me.FabricColorNameTextBox.ReadOnly = True
        Else
            Me.FabricColorNameTextBox.ReadOnly = False
        End If


        If EditLinkLabel.Text = "Edit" Then

            FabricColorDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
            NewLinkLabel.Enabled = False
            FabricColorNameTextBox.ReadOnly = True



            row.UserId = MainModule.UserId
            row.ModifiedDate = Now()


        Else

            Me.Validate()
            Me.FabricColorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricColorDataSet)
            FabricColorDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            FabricColorDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
            NewLinkLabel.Enabled = True
            FabricColorNameTextBox.ReadOnly = True



        End If
    End Sub


    Private Sub FabricColorDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FabricColorDataGridView.RowHeaderMouseDoubleClick

        'If frmMain.ActiveMdiChild.Name = "frmOrder" Then

        If FabricColorBindingSource.Position > -1 Then


            Dim row As FabricColorDataSet.FabricColorRow
            row = CType(CType(Me.FabricColorBindingSource.Current, DataRowView).Row, FabricColorDataSet.FabricColorRow)

            FabricColorIdvar = row.FabricColorId
            Me.FabricColorId = row.FabricColorId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If


        Me.Close()

        'End If

    End Sub

    
   
    Private Sub StartWithRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWithRadioButton.CheckedChanged


        If SearchTextBox.Text <> String.Empty Then
            Me.FabricColorTableAdapter.FillByStartWith(Me.FabricColorDataSet.FabricColor, SearchTextBox.Text)
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If SearchTextBox.Text <> String.Empty Then
            Me.FabricColorTableAdapter.FillByFabricColor(Me.FabricColorDataSet.FabricColor, SearchTextBox.Text)
        End If
    End Sub

    Private Sub FabricColorDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles FabricColorDataGridView.DataError
        On Error Resume Next
    End Sub
End Class