Public Class frmLine

    Private Sub LineBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.LineBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LineDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.LineChiefListTableAdapter.Fill(Me.LineCheifDataSet.LineChiefList)
        Me.FloorInchargeListTableAdapter.Fill(Me.FloorInchargeDataSet.FloorInchargeList)
        Me.PMListTableAdapter.Fill(Me.PMListDataSet.PMList)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        'Me.LineTableAdapter.Fill(Me.LineDataSet.Line)


        If CheckUserRights("Line").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            LineBindingNavigatorSaveItem.Enabled = False

        End If


    End Sub


    Private Sub LineDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        LineTableAdapter.FillBySection(Me.LineDataSet.Line, SectionComboBox.Text)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LineTableAdapter.Fill(Me.LineDataSet.Line)
    End Sub
End Class