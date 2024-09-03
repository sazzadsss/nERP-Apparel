Imports System.Data.SqlClient
Imports System.Data

Public Class frmSewingLayoutDetails
    Private _SewingLayoutId As Integer

    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property

    Private Sub SewingLayoutDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLayoutDetailsBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.SewingLayoutDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

        'For Each dr As DataRowView In Me.SewingLayoutDetailsBindingSource.List

        'Next

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.SewingLayoutDetailsTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayoutDetails, New System.Nullable(Of Long)(CType(SewingLayoutIdToolStripTextBox.Text, Long)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub frmSewingLayoutDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingSMVViewTableAdapter.FillByLayoutId(Me.SewingLayoutDataSet.SewingSMVView, Me.SewingLayoutId)
        Me.SewingLayoutDetailsTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayoutDetails, Me.SewingLayoutId)

    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        If SewingLayoutDetailsBindingSource.Position = -1 Then

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim SN As Integer = 1
            Dim cmd As SqlCommand = New SqlCommand("Select SewingSMVId,WorkStationQuantity,Process_Type From SewingBreakDown Where SewingLayoutId=" & Me.SewingLayoutId, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            Do While reader.Read()

                Dim i2 As Integer = 1

                While i2 <= reader("WorkStationQuantity")


                    Dim NewRow As SewingLayoutDataSet.SewingLayoutDetailsRow = Me.SewingLayoutDataSet.SewingLayoutDetails.NewRow()

                    NewRow.SewingLayoutId = Me.SewingLayoutId
                    NewRow.SlNo = SN
                    NewRow.SewingSMVId = reader.GetInt64(0)
                    NewRow.Process_Type = reader("Process_Type").ToString()
                    Dim CapPer As Integer = ReadData("Select CapacityPercentage From SewingSMV Where SewingSMVId=" & reader.GetInt64(0), cnn)
                    NewRow.CapacityPercentage = CapPer
                    NewRow.SlNo2 = ReadIntData("Select SlNo From SewingSMV Where SewingSMVId=" & reader.GetInt64(0), cnn)

                    Dim FullCapacity As Integer = ReadData("Select Capacity From SewingSMV Where SewingSMVId=" & reader.GetInt64(0), cnn)
                    NewRow.Capacity = FullCapacity * CapPer / 100

                    Me.SewingLayoutDataSet.SewingLayoutDetails.Rows.Add(NewRow)

                    i2 += 1

                    SN += 1

                End While


            Loop

            reader.Close()
            connection.Close()
        Else

            MessageBox.Show("You have to delete the exiting data first", "Data Already Exits", MessageBoxButtons.OK)

        End If

       




    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.Close()

    End Sub

    Private Sub SewingLayoutDetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        With frmSewingLayoutDetailsPrint

            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .SewingLayoutId = Me.SewingLayoutId
            .Show()

        End With

        Me.Hide()




    End Sub

    Private Sub SewingLayoutDetailsDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        'If SewingLayoutDetailsDataGridView.Columns(SewingLayoutDetailsDataGridView.CurrentCell.ColumnIndex).HeaderText = "Capacity %" Then
        '    '{SewingSMV.Capacity}*65/100

        '    Dim row As SewingLayoutDataSet.SewingLayoutDetailsRow
        '    row = CType(CType(Me.SewingLayoutDetailsBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutDetailsRow)

        '    Dim FullCapacity As Integer = ReadData("Select Capacity From SewingSMV Where SewingSMVId=" & row.SewingSMVId, cnn)

        '    SewingLayoutDetailsDataGridView.CurrentRow.Cells("Capacity").Value = FullCapacity * row.CapacityPercentage / 100


        'End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        If Me.CapacityPercentageToolStripTextBox.Text = String.Empty Then
            MessageBox.Show("Please,mention your capacity percentage")
            Exit Sub
        End If


        If Me.SewingLayoutDetailsBindingSource.Position > -1 Then


            Dim row As SewingLayoutDataSet.SewingLayoutDetailsRow
            row = CType(CType(Me.SewingLayoutDetailsBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutDetailsRow)


            For Each dr As DataRowView In Me.SewingLayoutDetailsBindingSource.List

                If dr!SewingSMVId = row.SewingSMVId Then


                    dr!CapacityPercentage = Val(Me.CapacityPercentageToolStripTextBox.Text.ToString)

                    Dim FullCapacity As Integer = ReadData("Select Capacity From SewingSMV Where SewingSMVId=" & row.SewingSMVId, cnn)
                    dr!Capacity = FullCapacity * Val(Me.CapacityPercentageToolStripTextBox.Text.ToString) / 100

                    ExecuteQuery("Update SewingSMV Set CapacityPercentage=" & Val(Me.CapacityPercentageToolStripTextBox.Text.ToString) & "Where SewingSMVId=" & row.SewingSMVId, cnn)


                End If

            Next


            Me.Validate()
            Me.SewingLayoutDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)


        End If

    End Sub

    Private Sub ShowAllToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllToolStripButton.Click

    End Sub

    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1

        view.GridControl.Focus()

        Dim index As Integer = view.FocusedRowHandle

        If index <= 0 Then Exit Sub



        Dim row1 As DataRow = view.GetDataRow(index)

        Dim row2 As DataRow = view.GetDataRow((index - 1))

        Dim val1 As Object = row1("SLNo")

        Dim val2 As Object = row2("SLNo")

        row1("SLNo") = val2

        row2("SLNo") = val1

        view.FocusedRowHandle = index - 1


    End Sub

    Private Sub DownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownButton.Click

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1
        view.GridControl.Focus()

        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)

        Dim row2 As DataRow = view.GetDataRow((index + 1))

        Dim val1 As Object = row1("SLNo")

        Dim val2 As Object = row2("SLNo")

        row1("SLNo") = val2

        row2("SLNo") = val1

        view.FocusedRowHandle = index + 1

    End Sub

    Private Sub SewingLayoutDetailsGridControl_Click(sender As Object, e As EventArgs) Handles SewingLayoutDetailsGridControl.Click

    End Sub
End Class