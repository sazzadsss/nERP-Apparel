Imports System.Web.Mail
Imports System.Data.SqlClient
Imports System.Data
Public Class frmSewingAttendance
    Dim PreviousDay As Date
    Dim dgvHeight As Integer
    Dim dgvWeight As Integer
    Dim dgvX As Integer
    Dim dgvY As Integer


    Private Sub frmSewingAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.SewingMachineTableAdapter.Fill(Me.SewingLayoutDataSet.SewingMachine)
        Me.SewingMachineUsageTableAdapter.Fill(Me.SewingAttendanceDataSet.SewingMachineUsage)
        Me.SewingMachineUsageTableAdapter.Fill(Me.SewingAttendanceDataSet.SewingMachineUsage)

        Me.SewingAttendanceDataSet.SewingAttendance.AttendanceDateColumn.DefaultValue = DateTimePicker1.Text

        'Dim PreviousDay As Date = DateSerial(Year(CDate(DateTimePicker1.Text)), Month(CDate(DateTimePicker1.Text), Day(DateTimePicker1.text)-1)
        
        If CheckUserRights("Sewing Attendance").CanEdit = False Then
            SaveButton.Enabled = False

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.SewingAttendanceDataSet.SewingAttendance.AttendanceDateColumn.DefaultValue = DateTimePicker1.Text
        Me.SewingAttendanceDataSet.SewingAttendance.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)
        Me.SewingAttendanceTableAdapter.Fill(Me.SewingAttendanceDataSet.SewingAttendance, BranchComboBox.SelectedValue, CDate(DateTimePicker1.Text))

        RefreshSummery()


    End Sub



    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.SewingAttendanceDataSet.SewingAttendance.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.SewingAttendanceTableAdapter.Fill(Me.SewingAttendanceDataSet.SewingAttendance, BranchComboBox.SelectedValue, CDate(DateTimePicker1.Text))
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)

        RefreshSummery()


        If SewingAttendanceBindingSource.Position > -1 Then

            Exit Sub

        Else
            

            For Each dr As DataRowView In LineBindingSource.List


                Dim NewRow As SewingAttendanceDataSet.SewingAttendanceRow = Me.SewingAttendanceDataSet.SewingAttendance.NewRow()

                NewRow.BranchId = BranchComboBox.SelectedValue
                NewRow.LineId = dr!LineId
                NewRow.AttendanceDate = DateTimePicker1.Text
                NewRow.Strength_Operator = 0
                NewRow.Strength_Helper = 0
                NewRow.Present_Helper = 0
                NewRow.Present_Operator = 0
                NewRow.Present2_Helper = 0
                NewRow.Present2_Operator = 0
                NewRow.Present3_Helper = 0
                NewRow.Present3_Hour = 0
                NewRow.Present4_Helper = 0
                NewRow.Present4_Operator = 0
                NewRow.Present4_Hour = 0
                NewRow.Remarks = "-"

                Me.SewingAttendanceDataSet.SewingAttendance.Rows.Add(NewRow)

            Next


        End If


    End Sub


    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click


        Me.Validate()
        Me.SewingAttendanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingAttendanceDataSet)
        GTMachineUsages.Text = ReadData("Select Sum(Quantity) From vSewingMachineUsages Where AttendanceDate='" & DateTimePicker1.Text & "' and BranchId=" & BranchComboBox.SelectedValue, cnn)

        RefreshSummery()


    End Sub



    Private Sub LoadMachineLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LoadMachineLinkLabel.LinkClicked


        If SewingAttendanceBindingSource.Position > -1 Then

            Dim row As SewingAttendanceDataSet.SewingAttendanceRow
            row = CType(CType(Me.SewingAttendanceBindingSource.Current, DataRowView).Row, SewingAttendanceDataSet.SewingAttendanceRow)


            If SewingMachineUsageBindingSource.Position < 0 And row.AttendanceId > -1 Then

                For Each dr As DataRowView In SewingMachineBindingSource.List

                    Dim NewRow As SewingAttendanceDataSet.SewingMachineUsageRow = Me.SewingAttendanceDataSet.SewingMachineUsage.NewRow()

                    NewRow.AttendanceId = row.AttendanceId
                    NewRow.SewingMachineId = dr!SewingMachineId
                    NewRow.Quantity = 0
                    NewRow.Remarks = "-"

                    Me.SewingAttendanceDataSet.SewingMachineUsage.Rows.Add(NewRow)

                Next

            End If
        End If

    End Sub


    Private Sub RefreshSummery()


        ''Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        'For index As Integer = 1 To SewingAttendanceBindingSource.Count


        '    If SewingAttendanceBindingSource.Position + 1 < SewingAttendanceBindingSource.Count Then

        '        SewingProductionBindingSource.MoveNext()

        '        ' Otherwise, move back to the first item.
        '    Else

        '        SewingProductionBindingSource.MoveFirst()

        '    End If


        'Next


        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vSOperator As Decimal = 0
        Dim vSHelper As Decimal = 0
        Dim vPOperator As Decimal = 0
        Dim vPHelper As Decimal = 0
        Dim vP2Operator As Decimal = 0
        Dim vP2Helper As Decimal = 0
        Dim vP3Operator As Decimal = 0
        Dim vP3Helper As Decimal = 0




        SOperatorLabel.Text = 0
        SHelperLabel.Text = 0
        POperatorLabel.Text = 0
        PHelperLabel.Text = 0
        P2OperatorLabel.Text = 0
        P2HelperLabel.Text = 0
        P3OperatorLabel.Text = 0
        P3HelperLabel.Text = 0



        For Each dr As DataRowView In SewingAttendanceBindingSource.List

            If IsDBNull(dr!Strength_Operator) = False Then
                vSOperator = vSOperator + dr!Strength_Operator
            Else
                vSOperator = 0
            End If
            SOperatorLabel.Text = vSOperator


            If IsDBNull(dr!Strength_Helper) = False Then
                vSHelper = vSHelper + dr!Strength_Helper
            Else
                vSHelper = 0
            End If
            SHelperLabel.Text = vSHelper


            If IsDBNull(dr!Present_Helper) = False Then
                vPHelper = vPHelper + dr!Present_Helper
            Else
                vPHelper = 0
            End If
            PHelperLabel.Text = vPHelper

            If IsDBNull(dr!Present_Operator) = False Then
                vPOperator = vPOperator + dr!Present_Operator
            Else
                vPOperator = 0
            End If
            POperatorLabel.Text = vPOperator


            If IsDBNull(dr!Present2_Operator) = False Then
                vP2Operator = vP2Operator + dr!Present2_Operator
            Else
                vP2Operator = 0
            End If
            P2OperatorLabel.Text = vP2Operator


            If IsDBNull(dr!Present2_Helper) = False Then
                vP2Helper = vP2Helper + dr!Present2_Helper
            Else
                vP2Helper = 0
            End If
            P2HelperLabel.Text = vP2Helper


            If IsDBNull(dr!Present3_Helper) = False Then
                vP3Helper = vP3Helper + dr!Present3_Helper
            Else
                vP3Helper = 0
            End If
            P3HelperLabel.Text = vP3Helper


            If IsDBNull(dr!Present3_Operator) = False Then
                vP3Operator = vP3Operator + dr!Present3_Operator
            Else
                vP3Operator = 0
            End If
            P3OperatorLabel.Text = vP3Operator




        Next


    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        ShowDefaultStrength()



    End Sub

    Private Sub ShowDefaultStrength()


        'Dim PreviousDay As Date = DateAdd(DateInterval.Day, -1, DateTimePicker1.Value)

        DateTimePicker2.Text = DateTimePicker1.Value.AddDays(-1)

        

        If SewingAttendanceBindingSource.Position > -1 Then

            If MessageBox.Show("Are you sure you want to load default strength ?", "Attention !!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then



                ''Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                For index As Integer = 1 To SewingAttendanceBindingSource.Count

                    Dim row As SewingAttendanceDataSet.SewingAttendanceRow
                    row = CType(CType(Me.SewingAttendanceBindingSource.Current, DataRowView).Row, SewingAttendanceDataSet.SewingAttendanceRow)


                    Dim connection As New SqlConnection(cnn)

                    connection.Open()



                    Dim cmd As SqlCommand = New SqlCommand("Select Strength_Operator,Strength_Helper from SewingAttendance where LineId=" & row.LineId & " and AttendanceDate='" & DateTimePicker2.Text & "'", connection)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    reader.Read()


                    If reader.IsDBNull(0) Then
                        row.Strength_Operator = 0
                    Else
                        row.Strength_Operator = reader.GetInt32(0)
                    End If

                    If reader.IsDBNull(1) Then
                        row.Strength_Helper = 0
                    Else
                        row.Strength_Helper = reader.GetInt32(1)
                    End If


                    If SewingAttendanceBindingSource.Position + 1 < SewingAttendanceBindingSource.Count Then

                        SewingAttendanceBindingSource.MoveNext()

                        'Otherwise, move back to the first item.
                    Else

                        SewingAttendanceBindingSource.MoveFirst()

                    End If


                Next





            End If

        End If




       

       

    End Sub

    Private Sub SewingMachineUsageDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingMachineUsageDataGridView.KeyDown
        'If e.KeyCode = Keys.F12 Then
        '    dgvHeight = SewingMachineUsageDataGridView.Size.Height
        '    dgvWeight = SewingMachineUsageDataGridView.Size.Width

        '    dgvX = SewingMachineUsageDataGridView.Location.X
        '    dgvY = SewingMachineUsageDataGridView.Location.Y
        '    SewingMachineUsageDataGridView.Dock = DockStyle.Fill
        '    e.Handled = True

        'ElseIf e.KeyCode = Keys.Shift + Keys.F12 Then

        '    SewingMachineUsageDataGridView.Dock = DockStyle.None
        '    SewingMachineUsageDataGridView.Size =
        '    SewingMachineUsageDataGridView.Size.Height = 

        '    SewingMachineUsageDataGridView.Location.X = dgvX
        '    SewingMachineUsageDataGridView.Location.Y = dgvY

        '    e.Handled = True


        'End If
    End Sub

    Private Sub SewingMachineUsageBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingMachineUsageBindingSource.PositionChanged, SewingMachineUsageBindingSource.CurrentChanged

        If SewingMachineUsageBindingSource.Position > -1 Then

            Dim TTLMachine As Integer = 0
            TTLMachineUsageLabel2.Text = 0

            For Each drv As DataRowView In SewingMachineUsageBindingSource.List

                TTLMachine = TTLMachine + drv!Quantity

            Next

            TTLMachineUsageLabel2.Text = TTLMachine

        End If


    End Sub

    
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        frmSAComments.SADate = DateTimePicker1.Text
        frmSAComments.BranchId = BranchComboBox.SelectedValue
        ShowMaster(frmSAComments)

    End Sub

    Private Sub MailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailButton.Click

        'Try
        '    Dim insMail As New System.Net.Mail.MailMessage()
        '    With insMail
        '        .From = "mahmud@echotexbd.com"
        '        .To = "mahmud@echotexbd.com"
        '        .Subject = "test"
        '        .Body = "test sending email"
        '    End With
        '    SmtpMail.SmtpServer = "your smtp server"
        '    SmtpMail.Send(insMail)
        '    Console.WriteLine("Successfully sent email message" + vbCrLf)
        'Catch err As Exception
        '    Console.WriteLine("EXCEPTION " + err.Message + vbCrLf)
        'End Try
        'SmtpMail.Send(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text)

    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        Dim RecordCount As Integer = ReadIntData("Select Count(*) As TotalRecord From DailySewingMachineRecord Where SewingDate='" & DateTimePicker1.Text & "'", cnn)

        If RecordCount = 0 Or RecordCount = Nothing Then

            ExecuteQuery("Insert into DailySewingMachineRecord(SewingMachineId,SewingDate,MachineQuantity,LoanFrom,LoanTo,OutOfOrder,Remarks) Select SewingMachineId,'" & DateTimePicker1.Text & "' As SewingDate,MachineQuantity,LoanFrom,LoanTo,OutOfOrder,Remarks From SewingMachine", cnn)

            MessageBox.Show("Ondate Machine Loaded Successfully", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Ondate Machine Record Already Exist", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub SewingAttendanceDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingAttendanceDataGridView.KeyDown

        If e.KeyCode = Keys.F10 Then


            If SewingAttendanceDataGridView.Columns(SewingAttendanceDataGridView.CurrentCell.ColumnIndex).HeaderText = "Main Layout No" Then


                Dim row As SewingAttendanceDataSet.SewingAttendanceRow
                row = CType(CType(Me.SewingAttendanceBindingSource.Current, DataRowView).Row, SewingAttendanceDataSet.SewingAttendanceRow)

                frmSewingLayoutNoSearch.SewingDate = row.AttendanceDate
                frmSewingLayoutNoSearch.LineId = row.LineId


                ShowMaster(frmSewingLayoutNoSearch)


                If frmSewingLayoutNoSearch.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    If DBNull.Value.Equals(frmSewingLayoutNoSearch) = False Then

                        Dim row1 As SewingAttendanceDataSet.SewingAttendanceRow
                        row1 = CType(CType(Me.SewingAttendanceBindingSource.Current, DataRowView).Row, SewingAttendanceDataSet.SewingAttendanceRow)

                        row1.SewingLayoutId = frmSewingLayoutNoSearch.SewinglayoutId

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If Me.SewingAttendanceBindingSource.Position > -1 Then

            Dim row1 As SewingAttendanceDataSet.SewingAttendanceRow
            row1 = CType(CType(Me.SewingAttendanceBindingSource.Current, DataRowView).Row, SewingAttendanceDataSet.SewingAttendanceRow)

            If row1.SewingLayoutId > 0 Then

                Dim SMID As Integer = 0
                Dim connection As New SqlConnection(cnn)
                connection.Open()
                MessageBox.Show(row1.SewingLayoutId.ToString)
                Dim cmd As SqlCommand = New SqlCommand("Select SewingSMVId,WorkStationQuantity From SewingBreakDown Where Process_Type='Machine' And SewingLayoutId=" & row1.SewingLayoutId, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read

                    If reader.IsDBNull(0) = False Then

                        SMID = ReadIntegerData("Select SewingMachineId From SewingSMV Where SewingSMVId=" & reader("SewingSMVId").ToString(), cnn)

                        Dim NewRow As SewingAttendanceDataSet.SewingMachineUsageRow = Me.SewingAttendanceDataSet.SewingMachineUsage.NewRow()

                        NewRow.AttendanceId = row1.AttendanceId
                        NewRow.SewingMachineId = SMID
                        NewRow.Quantity = reader("WorkStationQuantity")
                        NewRow.Remarks = "-"

                        Me.SewingAttendanceDataSet.SewingMachineUsage.Rows.Add(NewRow)

                    End If

                End While


                reader.Close()
                connection.Close()


            End If

        End If
    End Sub

    Private Sub SewingAttendanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SewingAttendanceDataGridView.CellContentClick

    End Sub

    Private Sub SewingAttendanceDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SewingAttendanceDataGridView.DataError
        On Error Resume Next
    End Sub

    Private Sub SewingMachineUsageDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SewingMachineUsageDataGridView.CellContentClick

    End Sub

    Private Sub SewingMachineUsageDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SewingMachineUsageDataGridView.DataError
        On Error Resume Next
    End Sub
End Class