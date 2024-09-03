Public Class frmFinishingAttendance

    Private Sub frmFinishingAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.FinishingAttendanceTableAdapter.FillByDate(Me.FinishingAttendanceDataSet.FinishingAttendance, DateTimePicker1.Text)

        If CheckUserRights("Finishing Attendance").CanEdit = False Then

            AddButton.Enabled = False
            SaveButton.Enabled = False
            DeleteButton.Enabled = False

        ElseIf CheckUserRights("Finishing Attendance").CanDelete = False Then
            AddButton.Enabled = True
            SaveButton.Enabled = True
            DeleteButton.Enabled = False

        End If



    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Try

            Me.Validate()
            Me.FinishingAttendanceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FinishingAttendanceDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
       


    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'Me.LineTableAdapter.FillBySectionAndBranch(Me.LineDataSet.Line, BranchComboBox.SelectedValue, "Finishing") 'Garments Finishing

        'RefreshSummery()



    End Sub

    
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Me.FinishingAttendanceDataSet.FinishingAttendance.AttendanceDateColumn.DefaultValue = DateTimePicker1.Text

        Me.FinishingAttendanceBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Me.FinishingAttendanceBindingSource.RemoveCurrent()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.FinishingAttendanceTableAdapter.FillByDate(Me.FinishingAttendanceDataSet.FinishingAttendance, CDate(DateTimePicker1.Text))
    End Sub

End Class