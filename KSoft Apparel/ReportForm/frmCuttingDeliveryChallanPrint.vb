Public Class frmCuttingDeliveryChallanPrint
    Private _CDID As Integer
    Public Property CDID() As Integer
        Get
            Return _CDID
        End Get
        Set(ByVal value As Integer)
            _CDID = value
        End Set
    End Property
    Dim SDate As Date
    Dim SDate2 As Date
    Private Sub frmCuttingDeliveryChallanPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        If Me.CDID > 0 Then

            'Dim CHFOR As Integer = ReadTinyIntData("Select ChallanFor From CuttingDelivery Where CuttingDeliveryId=" & Me.CDID, cnn)

            Me.ChallanGridLookUpEdit.EditValue = Me.CDID
            Dim row As DataRowView = TryCast(ChallanGridLookUpEdit.Properties.GetRowByKeyValue(ChallanGridLookUpEdit.EditValue), DataRowView)
            Dim filterstring As String = ""
            filterstring = "{CuttingDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "'"

            If row.Item("ChallanFor") = "Sewing" Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForSewing
                MyReport.SetParameterValue("PType", "Report")
                MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf row.Item("ChallanFor") = "Embroidery" Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForEmb
                MyReport.SetParameterValue("PType", "Report")
                MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf row.Item("ChallanFor") = "Printing" Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForPrinting
                MyReport.SetParameterValue("PType", "Report")
                MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            End If


        End If

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Dim filterstring As String = ""
        filterstring = "{CuttingDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "'"

        Dim row As DataRowView = TryCast(ChallanGridLookUpEdit.Properties.GetRowByKeyValue(ChallanGridLookUpEdit.EditValue), DataRowView)

        If row.Item("ChallanFor") = "Sewing" Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForSewing
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf row.Item("ChallanFor") = "Embroidery" Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForEmb
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf row.Item("ChallanFor") = "Printing" Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintForPrinting
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If


    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim CN As Int16 = ReadIntData("Select Count(GatePassNo) From GeneralGatepass Where ChallanNo='" & ChallanGridLookUpEdit.Text & "'", cnn)

        If CN = 0 Then
            MessageBox.Show("Not allowed to print without Gatepass.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If PrintCount(Me.ChallanGridLookUpEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)

            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:

        Dim ChallanDate As Date = ReadDateData("Select ChallanDate from CuttingDelivery Where ChallanNo ='" & ChallanGridLookUpEdit.Text & "'", cnn)
        Dim i As Integer = 0



        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument
        filterstring = "{CuttingDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "'"

        Dim row As DataRowView = TryCast(ChallanGridLookUpEdit.Properties.GetRowByKeyValue(ChallanGridLookUpEdit.EditValue), DataRowView)

        If row.Item("ChallanFor") = "Sewing" Then
            MyReport = New CuttingDeliveryChallanPrintForSewingWithoutBuyer

        ElseIf row.Item("ChallanFor") = "Embroidery" Then
            MyReport = New CuttingDeliveryChallanPrintForEmbWithoutBuyer

        ElseIf row.Item("ChallanFor") = "Printing" Then
            MyReport = New CuttingDeliveryChallanPrintForPrintingWithoutBuyer

        End If


        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Int32 = PrintCount(Me.ChallanGridLookUpEdit.Text, False)

            Do While i <= 4

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Accounts", PrintCountNo, PrintDialog1)

                ElseIf i = 3 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Gate", PrintCountNo, PrintDialog1)

                ElseIf i = 4 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)



                End If

                i = i + 1

            Loop

            MessageBox.Show("Challan Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{CuttingDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If PrintCount(Me.ChallanGridLookUpEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument
        filterstring = "{CuttingDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "'"

        Dim row As DataRowView = TryCast(ChallanGridLookUpEdit.Properties.GetRowByKeyValue(ChallanGridLookUpEdit.EditValue), DataRowView)

        If row.Item("ChallanFor") = "Sewing" Then
            MyReport = New CuttingDeliveryChallanPrintForSewing

        ElseIf row.Item("ChallanFor") = "Embroidery" Then
            MyReport = New CuttingDeliveryChallanPrintForEmb

        ElseIf row.Item("ChallanFor") = "Printing" Then
            MyReport = New CuttingDeliveryChallanPrintForPrinting

        End If


        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Integer = PrintCount(Me.ChallanGridLookUpEdit.Text, False)


            Dim i As Integer = 0

            Do While i <= 3

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

                ElseIf i = 3 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Sewing Recv", PrintCountNo, PrintDialog1)


                End If

                i = i + 1

            Loop

            MessageBox.Show("Challan Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{CuttingDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRangeSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRangeSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{CuttingDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{CuttingDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingDeliveryChallanPrintDateRangeSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class