Public Class frmShipmentDeliveryChallanPrint
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

    Private Sub frmShipmentDeliveryChallanPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
        Me.DeliveryChallanLookUpTableAdapter.FillByDepartmentId(DeliveryChallanLookUpDataSet.DeliveryChallanLookUp, ExportDepartmentId)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        If Me.SDID > 0 Then
            Me.DepartmentComboBox.SelectedValue = ExportDepartmentId
            Me.ChallanGridLookUpEdit.EditValue = Me.SDID

            Dim filterstring As String = ""
            filterstring = "{Delivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {Delivery.DepartmentId}=" & ExportDepartmentId
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanPrint
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If





    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim filterstring As String = ""
        filterstring = "{Delivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {Delivery.DepartmentId}=" & ExportDepartmentId
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanPrint
        MyReport.SetParameterValue("PType", "Report")
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub



    Private Sub ShowByDeptButton_Click(sender As Object, e As EventArgs) Handles ShowByDeptButton.Click
        On Error Resume Next
        Me.DeliveryChallanLookUpTableAdapter.FillByDepartmentId(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp, DepartmentComboBox.SelectedValue)
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

        Dim ChallanDate As Date = ReadDateData("Select ChallanDate from Delivery Where ChallanNo ='" & ChallanGridLookUpEdit.Text & "'", cnn)


        Dim i As Integer = 0

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanPrint
        Dim filterstring As String = "{Delivery.ChallanNo} = '" & ChallanGridLookUpEdit.Text & "'"

        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Int32 = PrintCount(Me.ChallanGridLookUpEdit.Text, False)

            Do While i <= 5

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Accounts", PrintCountNo, PrintDialog1)

                ElseIf i = 3 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Audit", PrintCountNo, PrintDialog1)

                ElseIf i = 4 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Gate", PrintCountNo, PrintDialog1)

                ElseIf i = 5 Then

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

        Dim filterstring As String = "{Delivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{Delivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanListDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click
        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanListDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton3_Click(sender As Object, e As EventArgs) Handles ShowButton3.Click
        filterstring = "{OrderDetails.OrderDetailsId} = " & GridLookUpEdit1.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentDeliveryChallanListDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class