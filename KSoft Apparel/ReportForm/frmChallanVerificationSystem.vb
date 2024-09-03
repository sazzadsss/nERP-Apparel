Imports System.Text

Public Class frmChallanVerificationSystem
    Dim SDate As Date
    Dim SDate2 As Date
    Dim DID As Integer
    Function RemoveDigits(ByVal S As String) As String
        Return RegularExpressions.Regex.Replace(S, "\d", "")
    End Function

    Private Sub ShowChallanReport()
        Dim filterstring As String = ""
        Dim ChallanCode As String = RemoveDigits(ChallanNoTextBox.Text)

        If ChallanCode.ToUpper() = "EDC" Then
            'Export
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Export'", cnn)
            filterstring = "{Delivery.ChallanNo}='" & ChallanNoTextBox.Text & "'"   'For Export Challan
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanPrint
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "SG" Then
            'Sample
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Sample'", cnn)
            filterstring = "{GatePass.GatePassNo} = '" & ChallanNoTextBox.Text & "'" 'For Sample Gate Pass
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "EMBDC" Then
            'Embroidery
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Embroidery'", cnn)
            filterstring = "{EmbDelivery.ChallanNo} = '" & ChallanNoTextBox.Text & "'" 'For Embroidery Delivery Challan
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbroideryDeliveryChallanPrintWithoutBuyer
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "PDC" Then
            'Printing
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Printing'", cnn)
            filterstring = "{PrintingDelivery.ChallanNo} = '" & ChallanNoTextBox.Text & "'" 'For Printing Delivery Challan
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintingDeliveryChallanPrintWithoutBuyer
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "GFS" Then
            'Greige Fabric Store
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Greige Fabric Store'", cnn)
            filterstring = "{GreyFabricReceiveIssue.ChallanNo}='" & ChallanNoTextBox.Text & "' And {@CheckIssueQty} > 0"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GreyFabricDeliveryChallan_Print
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "FFS" Then
            'Finish Fabric Store
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Finish Fabric Store'", cnn)
            filterstring = "{@CheckIssueQty}>0 And {FinishFabricReceiveIssue.ChallanNo} = '" & ChallanNoTextBox.Text & "' And Not {FinishFabricReceiveIssue.IsGMTStore}"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricDeliveryChallan_Print
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "GFI" Then
            'Knitting
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Knitting'", cnn)
            filterstring = "{GFIDelivery.GFIChallanNo} = '" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New KPChallanPrint
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "FFI" Then
            'Dyeing
            filterstring = "{FFIDeliveryChallan.FFIChallanNo} = '" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinalInspectionDeliveryChallanPrint
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "YSC" Then
            'Yarn Store
            DID = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Yarn Store'", cnn)
            filterstring = "{Issue.ChallanNo}='" & ChallanNoTextBox.Text & "' And {Issue.DepartmentId}=" & YarnStoreId
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDeliveryChallan
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "GSC" Then
            'Multi Department
            DID = ReadIntegerData("Select Max(DepartmentId) From Issue Where ChallanNo='" & ChallanNoTextBox.Text & "'", cnn)
            filterstring = "{Issue.ChallanNo}='" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreDeliveryChallan
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "YDC" Then
            'Yarn Dyeing Department
            DID = ReadIntegerData("Select Max(DepartmentId) From Issue Where ChallanNo='" & ChallanNoTextBox.Text & "'", cnn)
            filterstring = "{Issue.ChallanNo}='" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingDeliveryChallan
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "MDC" Then
            'MISC
            DID = ReadIntegerData("Select Max(DepartmentId) From MiscDelivery Where ChallanNo='" & ChallanNoTextBox.Text & "'", cnn)
            filterstring = "{MiscDelivery.ChallanNo}='" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()

        ElseIf ChallanCode.ToUpper() = "CDC" Then
            'MISC
            'DID = ReadIntegerData("Select Max(DepartmentId) From MiscDelivery Where ChallanNo='" & ChallanNoTextBox.Text & "'", cnn)
            filterstring = "{CuttingDelivery.ChallanNo}='" & ChallanNoTextBox.Text & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintWithoutBuyer
            MyReport.SetParameterValue("PType", "Gate")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanNoTextBox.Text, True))
            PrintCountLabel.Text = String.Format(PrintCountLabel.Text, PrintCount(Me.ChallanNoTextBox.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            CheckedButton.Focus()
        Else

            MessageBox.Show("Not Allowed This Challan.")

        End If
    End Sub
    Private Sub ChallanNoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ChallanNoTextBox.KeyDown

        If e.KeyData = Keys.Enter Then

            ShowChallanReport()

        End If
    End Sub




    Private Sub frmChallanVerificationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChallanNoTextBox.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{PrintCount.CheckedOn} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ChallanVerifySystem
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ChallanNoTextBox_Enter(sender As Object, e As EventArgs) Handles ChallanNoTextBox.Enter
        ChallanNoTextBox.SelectAll()

    End Sub

    Private Sub CheckedButton_Click(sender As Object, e As EventArgs) Handles CheckedButton.Click

        If ChallanNoTextBox.Text = String.Empty Then

            ChallanNoTextBox.Focus()
            ChallanNoTextBox.SelectAll()
            Exit Sub

        End If

        Dim MaxPrintCountId As Integer = ReadIntegerData("Select Max(PrintCountId) From PrintCount Where ChallanNo='" & ChallanNoTextBox.Text & "'", cnn)
        Dim IsChecked As Boolean = ReadBooleanData("Select IsChecked From PrintCount Where PrintCountId=" & MaxPrintCountId, cnn)

        If IsChecked Then
            MessageBox.Show("Already Checked.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChallanNoTextBox.Focus()
            ChallanNoTextBox.SelectAll()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to checked ?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ExecuteQuery("Update PrintCount Set IsChecked=1 ,CheckedOn=GetDate(),DepartmentId=" & DID & " Where PrintCountId=" & MaxPrintCountId, cnn)
            MessageBox.Show("Checked Completed ?.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowChallanReport()
            ChallanNoTextBox.Focus()
            ChallanNoTextBox.SelectAll()

        Else
            ChallanNoTextBox.Focus()
            ChallanNoTextBox.SelectAll()
        End If

    End Sub

    Private Sub ChallanNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ChallanNoTextBox.TextChanged

    End Sub
End Class