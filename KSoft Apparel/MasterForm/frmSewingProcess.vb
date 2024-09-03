Public Class frmSewingProcess
    Private _SewingProcessId As Integer
    Public Property SewingProcessId() As Integer
        Get
            Return _SewingProcessId
        End Get
        Set(ByVal value As Integer)
            _SewingProcessId = value
        End Set
    End Property
    Private _SewingMachinId As Integer
    Public Property SewingMachineId() As Integer
        Get
            Return _SewingMachinId
        End Get
        Set(ByVal value As Integer)
            _SewingMachinId = value
        End Set
    End Property

    Private Sub SewingProcessBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmSewingProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingMachineTableAdapter.Fill(Me.SewingLayoutDataSet.SewingMachine)

        Me.SewingProcessTableAdapter.Fill(Me.SewingLayoutDataSet.SewingProcess)

        ProcessNameTextBox.Focus()

        If CheckUserRights("Sewing Process").CanEdit = False Then
            SaveButton.Enabled = False
        End If

    End Sub

    
    Private Sub ProcessNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessNameTextBox.TextChanged

        'On Error Resume Next
        Me.SewingProcessTableAdapter.FillByProcessName(Me.SewingLayoutDataSet.SewingProcess, ProcessNameTextBox.Text)
        Me.SewingLayoutDataSet.SewingProcess.ProcessNameColumn.DefaultValue = Me.ProcessNameTextBox.Text.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub SewingProcessDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SewingProcessDataGridView.RowHeaderMouseDoubleClick

        If Me.SewingProcessBindingSource.Position > -1 Then

            Dim row As SewingLayoutDataSet.SewingProcessRow
            row = CType(CType(Me.SewingProcessBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingProcessRow)

            Me.SewingProcessId = row.SewingProcessId
            Me.SewingMachineId = row.SewingMachineId
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If


    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Me.Validate()
        Me.SewingProcessBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

        ProcessNameTextBox.Focus()

    End Sub

    Private Sub SewingProcessDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SewingProcessDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub SewingProcessDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingProcessDataGridView.CellClick
        On Error Resume Next

        If (e.ColumnIndex = 0) Then
            Dim link As String = SewingProcessDataGridView(e.ColumnIndex, e.RowIndex).Value.ToString()
            'System.Diagnostics.Process.Start(link)
            MessageBox.Show(link)
        End If

    End Sub

    Private Sub SewingProcessDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles SewingProcessDataGridView.CellEndEdit


        If (e.ColumnIndex = 2) Then

            Dim row As SewingLayoutDataSet.SewingProcessRow
            row = CType(CType(Me.SewingProcessBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingProcessRow)

            If row.SewingMachineId = 17 Then
                row.ProcessType = "Manual"
            Else
                row.ProcessType = "Machine"
            End If

        End If


    End Sub
End Class