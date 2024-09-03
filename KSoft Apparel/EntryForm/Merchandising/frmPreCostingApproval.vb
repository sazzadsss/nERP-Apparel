Imports System.Data.SqlClient
Imports System.ServiceModel
Imports DevExpress.XtraSplashScreen
Public Class frmPreCostingApproval

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles BACancelButton.Click

        If Me.CostingApprovalBindingSource.Position > -1 Then

            Dim row As PreCostingApprovalDataSet.CostingApprovalRow
            row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)

            If row.IsApproved = True Then
                MessageBox.Show("Not allowed to cancel the approved costing.")
                Exit Sub
            End If

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("CostingApproval", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PreCostingId", row.PreCostingId)
                cmd.Parameters.AddWithValue("@IsApproved", 0)
                cmd.Parameters.AddWithValue("@ApprovedBy", UserId)
                cmd.Parameters.AddWithValue("@IsCancel", 1)
                cmd.Parameters.AddWithValue("@CauseofCancel", CauseofRemrksTextBox.Text)


                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("The Costing has been cancelled")
            Me.CostingApprovalTableAdapter.FillByApproved(Me.PreCostingApprovalDataSet.CostingApproval)

        End If

    End Sub

    Private Sub ApprovedButton_Click(sender As Object, e As EventArgs) Handles ApprovedButton.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        If Me.CostingApprovalBindingSource.Position > -1 Then

            Dim row As PreCostingApprovalDataSet.CostingApprovalRow
            row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("CostingApproval", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PreCostingId", row.PreCostingId)
                cmd.Parameters.AddWithValue("@IsApproved", 1)
                cmd.Parameters.AddWithValue("@ApprovedBy", UserId)
                cmd.Parameters.AddWithValue("@IsCancel", 0)
                cmd.Parameters.AddWithValue("@CauseofCancel", CauseofRemrksTextBox.Text)


                cmd.ExecuteNonQuery()

            End Using

            'Dim MerchandiserId As Integer = ReadIntegerData("Select UserId From [Order] Where OrderId=" & row.OrderId, cnn)
            'SendUserMail(CauseofRemrksTextBox.Text, "Program No :" & row.ProgramNo & "::" & row.AmendmentNo.ToString() & " has been approved", MerchandiserId)

            MessageBox.Show("The Costing has been approved")
            Me.CostingApprovalTableAdapter.FillByPending(Me.PreCostingApprovalDataSet.CostingApproval)
        End If
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.CostingApprovalTableAdapter.FillByApproved(Me.PreCostingApprovalDataSet.CostingApproval)
        If Me.CostingApprovalBindingSource.Position > -1 Then
            ReviseButton.Enabled = True
        Else
            ReviseButton.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.CostingApprovalTableAdapter.FillByPending(Me.PreCostingApprovalDataSet.CostingApproval)
    End Sub

    Private Sub ShowAWSToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowAWSToolStripButton.Click

        If Me.CostingApprovalBindingSource.Position > -1 Then


            Dim row As PreCostingApprovalDataSet.CostingApprovalRow
            row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)

            frmPreCostingPrint.CID = row.PreCostingId

            ShowForm(frmPreCostingPrint)

        End If

    End Sub

    Private Sub frmPreCostingApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CostingApprovalTableAdapter.FillByPending(Me.PreCostingApprovalDataSet.CostingApproval)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.CostingApprovalTableAdapter.FillByCancel(Me.PreCostingApprovalDataSet.CostingApproval)
    End Sub

    Private Sub ReviseButton_Click(sender As Object, e As EventArgs) Handles ReviseButton.Click

        '        If Me.CostingApprovalBindingSource.Position = -1 Then
        '            MessageBox.Show("Nothing to do..., Select already approved list")
        '            Exit Sub

        '        End If

        '        Dim row As PreCostingApprovalDataSet.CostingApprovalRow
        '        row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)


        '        If row.IsApproved = True Then
        '            GoTo Line1
        '        Else
        '            MessageBox.Show("Please, select a approved costing...")
        '            Exit Sub
        '        End If
        'Line1:

        '        If MessageBox.Show("Are you sure your want to revise ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

        '            'Dim NCN As String = ""
        '            'Dim ABC As String = Now.Year.ToString.Substring(2) & "CN"
        '            'Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(PreCostingNo),0,CHARINDEX('N',REVERSE(PreCostingNo))))AS Integer)) From PreCostingMain Where PreCostingNo Like '" & ABC & "%'", cnn)

        '            'Dim NewOrder As String = Now.Year.ToString.Substring(2) & "CN" & (Val(XYZ) + 1).ToString()
        '            NCN = row.PreCostingNo

        '            Using Connection As New SqlConnection(cnn)

        '                Connection.Open()

        '                Dim cmd As SqlCommand = New SqlCommand("RevisePreCosting", Connection)
        '                cmd.CommandType = CommandType.StoredProcedure
        '                cmd.Parameters.AddWithValue("@PreCostingId", row.PreCostingId)
        '                cmd.Parameters.AddWithValue("@PreCostingNo", NCN)
        '                cmd.Parameters.AddWithValue("@Comments", CauseofRemrksTextBox.Text)

        '                cmd.ExecuteNonQuery()

        '            End Using


        '            MessageBox.Show("Request Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)



        '        End If


        If Me.CostingApprovalBindingSource.Position = -1 Then
            MessageBox.Show("Nothing to do..., Select already approved list")
            Exit Sub

        End If

        Dim row As PreCostingApprovalDataSet.CostingApprovalRow
        row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)

        Dim BCount As Integer = ReadIntData("Select Count(*) From PreCostingMain Where OrderId=" & row.OrderId & " And IsApproved=0", cnn)
        If BCount > 0 Then
            MessageBox.Show("Already Done.")
            Exit Sub
        End If

        If row.IsApproved = True Then
            GoTo Line1
        Else
            MessageBox.Show("Please, select a approved costing...")
            Exit Sub
        End If



Line1:

        If MessageBox.Show("Are you sure your want to revise ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Dim NCN As String = ""
            'Dim ABC As String = Now.Year.ToString.Substring(2) & "CN"
            'Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(PreCostingNo),0,CHARINDEX('N',REVERSE(PreCostingNo))))AS Integer)) From PreCostingMain Where PreCostingNo Like '" & ABC & "%'", cnn)

            'Dim NewOrder As String = Now.Year.ToString.Substring(2) & "CN" & (Val(XYZ) + 1).ToString()
            NCN = row.PreCostingNo

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("RevisePreCosting", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PreCostingId", row.PreCostingId)
                cmd.Parameters.AddWithValue("@PreCostingNo", NCN)
                cmd.Parameters.AddWithValue("@Comments", CauseofRemrksTextBox.Text)

                cmd.ExecuteNonQuery()

            End Using


            MessageBox.Show("Request Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)



        End If

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ShowForm(frmPreCostingPrint)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles SendBudgetToolStripButton.Click

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim client As MailServiceReference.MailServiceSoapClient = New MailServiceReference.MailServiceSoapClient
        If builder.DataSource = "192.168.0.100,40000" Then
            client.Endpoint.Address = New EndpointAddress("http://localhost/mailservice.asmx")
        End If

        client.SendMail()
        'If Me.CostingApprovalBindingSource.Position > -1 Then

        '    Dim row As PreCostingApprovalDataSet.CostingApprovalRow
        '    row = CType(CType(Me.CostingApprovalBindingSource.Current, DataRowView).Row, PreCostingApprovalDataSet.CostingApprovalRow)
        'Dim MerchandiserId As Integer = ReadIntegerData("Select UserId From [Order] Where OrderId=" & Row.OrderId, cnn)
        'SendUserMail(CauseofRemrksTextBox.Text, "Program No :" & Row.ProgramNo & "::" & Row.AmendmentNo.ToString() & " has been approved", MerchandiserId)
        'End If

    End Sub

End Class