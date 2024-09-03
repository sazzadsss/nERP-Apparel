Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmFabricConsumptionPrint

    Private _FabricBOMId As Integer
    Public Property FabricBOMId() As Integer
        Get
            Return _FabricBOMId
        End Get
        Set(ByVal value As Integer)
            _FabricBOMId = value
        End Set
    End Property


    Dim filterstring As String = ""


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load




    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If ProgramGridLookUpEdit.EditValue > -1 Then


            Me.FabricBOMId = ProgramGridLookUpEdit.EditValue
            Dim ProgAndAmnd As String = ProgramGridLookUpEdit.Text.Substring(0, ProgramGridLookUpEdit.Text.IndexOf(":")).Trim()
            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId.ToString()

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricConsumptionFinal
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(ProgAndAmnd, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub frmFabricConsumptionPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SampleFabricBookingLookup.Fill(Me.SampleFabricBookingDataSet.SampleFabricBookingLookup)

        'Me.SampleFabricBookingTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabricBooking)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestNoLookup)
        Me.FabricBOMProgramListTableAdapter.Fill(Me.FabricBOMProgramListDataSet.FabricBOMProgramList)

        'Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)

        ''If UserLevel = 1 Then
        'Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)
        ''Else
        '    Me.FabricBOMIdSearchTableAdapter.FillByUserId(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch, UserId)
        'End If

        SplitContainer1.Panel2Collapsed = True
        SplitContainer1.Panel1Collapsed = False


        If Me.FabricBOMId > 0 Then

            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId
            ProgramGridLookUpEdit.EditValue = Me.FabricBOMId
            Dim ProgAndAmnd As String = ProgramGridLookUpEdit.Text.Substring(0, ProgramGridLookUpEdit.Text.IndexOf(":")).Trim()
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricConsumptionFinal
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(ProgAndAmnd, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



    End Sub



    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'On Error Resume Next

        'Using connection As New SqlConnection(cnn)

        '    Dim command As New SqlCommand("Select Distinct AmendmendNo From FabricBOM Where ProgramNo='" & ProgramNoTextBox.Text & "'", connection)
        '    command.Connection.Open()
        '    command.ExecuteNonQuery()

        '    Dim reader As SqlDataReader = command.ExecuteReader()

        '    Do While reader.Read()
        '        ComboBox1.Items.Add(reader("AmendmentNo").ToString())
        '    Loop

        '    reader.Close()

        'End Using

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If GridLookUpEdit2.EditValue > 1 Then

            filterstring = "{Order.OrderId} =" & Me.GridLookUpEdit2.EditValue.ToString()

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MarkerReport2
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub ProgramGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramGridLookUpEdit.EditValueChanged
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select AmendmentNo From FabricBOM_History Where FabricBOMId=" & ProgramGridLookUpEdit.EditValue & "Order By AmendmentNo", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        ComboBox1.Items.Clear()

        While reader.Read
            If reader.IsDBNull(0) = False Then
                ComboBox1.Items.Add(reader("AmendmentNo").ToString())
            End If
        End While

        reader.Close()
        connection.Close()

    End Sub

    Private Sub HistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryButton.Click
        If ProgramGridLookUpEdit.EditValue > 1 Then


            Me.FabricBOMId = ProgramGridLookUpEdit.EditValue
            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId.ToString() & "And {FabricBOM.AmendmentNo}=" & ComboBox1.Text.ToCharArray()

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricBooking_History
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
    End Sub

    Private Sub ProceedDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedDateButton.Click

        Me.FabricBOMProcceedListTableAdapter.Fill(Me.FabricBOMProcceedListDataSet.FabricBOMProcceedList, DateTimePicker1.Text, DateTimePicker2.Text)
        Me.SampleFabricBookingProceedListTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabricBookingProceedList, DateTimePicker1.Text, DateTimePicker2.Text)

        Me.SplitContainer1.Panel2Collapsed = False
        Me.SplitContainer1.Panel1Collapsed = True


    End Sub

    Private Sub HideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideButton.Click
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Panel1Collapsed = False

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub RepositoryItemHyperLinkEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemHyperLinkEdit1.Click

        If Me.FabricBOMProcceedListBindingSource.Position > -1 Then

            Dim row As FabricBOMProcceedListDataSet.FabricBOMProcceedListRow
            row = CType(CType(Me.FabricBOMProcceedListBindingSource.Current, DataRowView).Row, FabricBOMProcceedListDataSet.FabricBOMProcceedListRow)

            Me.FabricBOMId = row.FabricBOMId
            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId.ToString()
            ' Dim ProgAndAmnd As String = ProgramGridLookUpEdit.Text.Substring(0, ProgramGridLookUpEdit.Text.IndexOf(":")).Trim()
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricConsumptionFinal
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(row.ProgramNo, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Me.SplitContainer1.Panel2Collapsed = True

        End If
       
    End Sub

    Private Sub frmFabricConsumptionPrint_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        filterstring = "{SampleFabricBooking.SampleFabricBookingId} =" & Me.GridLookUpEdit1.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If ProgramGridLookUpEdit.EditValue > -1 Then


            Me.FabricBOMId = ProgramGridLookUpEdit.EditValue
            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId.ToString()

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricBookingCompact
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Order Booking-Bulk"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                GridControl1.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Order Booking-Bulk"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                SampleFabricBookingGridControl.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub RepositoryItemHyperLinkEdit2_Click(sender As Object, e As EventArgs) Handles RepositoryItemHyperLinkEdit2.Click

        If Me.SampleFabricBookingProceedListBindingSource.Position > -1 Then

            Dim row As SampleFabricBookingDataSet.SampleFabricBookingProceedListRow
            row = CType(CType(Me.SampleFabricBookingProceedListBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricBookingProceedListRow)

            filterstring = "{SampleFabricBooking.SampleFabricBookingId} =" & row.SampleFabricBookingId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Me.SplitContainer1.Panel2Collapsed = True

        End If

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        Dim ProgAndAmnd As String = ProgramGridLookUpEdit.Text.Substring(0, ProgramGridLookUpEdit.Text.IndexOf(":")).Trim()

        Dim ProFlag As Boolean = ReadBooleanData("Select IsFabricBOMComplete From FabricBOM Where FabricBOMId=" & ProgramGridLookUpEdit.EditValue, cnn)

        If ProFlag = False Then
            MessageBox.Show("Not allowed to print whitout proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If PrintCount(ProgAndAmnd, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Fabric Booking.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:

        'Dim ChallanDate As Date = ReadDateData("Select GatePassDate from GatePass Where GatePassNo ='" & GridLookUpEdit1.Text & "'", cnn)


        Dim i As Integer = 0

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricConsumptionFinal
        Dim filterstring As String = "{FabricBOM.FabricBOMId}=" & Me.ProgramGridLookUpEdit.EditValue

        If MessageBox.Show("Are you sure you want to print this Fabric Booking ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            Dim PrintCountNo As Integer = PrintCount(ProgAndAmnd, False)

            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Merchandiser", PrintCountNo, PrintDialog1)

            MessageBox.Show("Fabric Booking Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class