Public Class frmSewingDeliveryChallanPrint
    Dim SDate As Date
    Dim SDate2 As Date
    Private _SDID As Integer
    Public Property SDID() As Integer
        Get
            Return _SDID
        End Get
        Set(ByVal value As Integer)
            _SDID = value
        End Set
    End Property
    Private Sub frmSewingDeliveryChallan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)

        If Me.SDID > 0 Then

            Me.ChallanLookupGridLookUpEdit.EditValue = Me.SDID

            filterstring = "{SewingDelivery.SewingDeliveryId} = " & Me.ChallanLookupGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallan
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanLookupGridLookUpEdit.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        filterstring = "{SewingDelivery.SewingDeliveryId} = " & Me.ChallanLookupGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallan
        MyReport.SetParameterValue("PType", "Report")
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanLookupGridLookUpEdit.Text, True))
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If PrintCount(Me.ChallanLookupGridLookUpEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan")
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:

        Dim ChallanDate As Date = ReadDateData("Select ChallanDate from SewingDelivery Where SewingDeliveryId =" & Me.ChallanLookupGridLookUpEdit.EditValue, cnn)

        Dim i As Integer = 0

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallan
        filterstring = "{SewingDelivery.SewingDeliveryId} = " & Me.ChallanLookupGridLookUpEdit.EditValue

        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            Dim PrintCountNo As Int32 = PrintCount(Me.ChallanLookupGridLookUpEdit.Text, False)

            Do While i <= 1

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)

                End If

                i = i + 1

            Loop

            MessageBox.Show("Challan Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CN As Int16 = ReadIntData("Select Count(GatePassNo) From GeneralGatepass Where ChallanNo='" & ChallanLookupGridLookUpEdit.Text & "'", cnn)

        If CN = 0 Then
            MessageBox.Show("Not allowed to print without Gatepass.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If PrintCount(Me.ChallanLookupGridLookUpEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)

            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:

        Dim ChallanDate As Date = ReadDateData("Select ChallanDate from SewingDelivery Where SewingDeliveryId =" & Me.ChallanLookupGridLookUpEdit.EditValue, cnn)

        Dim i As Integer = 0

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallanOutside
        filterstring = "{SewingDelivery.SewingDeliveryId} = " & Me.ChallanLookupGridLookUpEdit.EditValue

        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            Dim PrintCountNo As Int32 = PrintCount(Me.ChallanLookupGridLookUpEdit.Text, False)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallanDaterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{SewingDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingDeliveryChallanDaterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class