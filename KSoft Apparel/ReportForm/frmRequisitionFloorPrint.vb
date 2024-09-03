Public Class frmRequisitionFloorPrint
    Dim querystring As String = ""

    Private _FRID As Integer
    Public Property FRID() As Integer
        Get
            Return _FRID
        End Get
        Set(ByVal value As Integer)
            _FRID = value
        End Set
    End Property


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load


    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click


        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloor2

        'PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Challan", PrintCount(Me.GridLookUpEdit1.Text, False), PrintDialog1)


        If PrintCount(Me.GridLookUpEdit1.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Floor Requisition", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloor2
        Dim filterstring As String = "{RequisitionFloor.RequistionFloorId} = " & Me.GridLookUpEdit1.EditValue

        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Integer = PrintCount(Me.GridLookUpEdit1.Text, False)


            Dim i As Integer = 0

            Do While i <= 1

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)



                End If

                i = i + 1

            Loop

            MessageBox.Show("Floor Requisition Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub frmRequisitionFloorPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, GridLookUpEdit2.EditValue)
        Me.RequisitionFloorLookupTableAdapter.Fill(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookUp)
        Me.GridLookUpEdit1.EditValue = Me.FRID
        Dim filterstring As String = "{RequisitionFloor.RequistionFloorId} = " & Me.FRID
        Me.DepartmentTableAdapter.Fill(Me.DepartmentLookupDataSet.Department)
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloor2
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))
        MyReport.SetParameterValue("PType", "Report")
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Dim filterstring As String = "{RequisitionFloor.RequistionFloorId} = " & Me.GridLookUpEdit1.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloor2
        MyReport.SetParameterValue("PType", "Report")
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{RequisitionFloor.RequistionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} = " & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloorDepartmentAndDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{RequisitionFloor.RequistionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloorDepartmentAndDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{RequisitionFloor.RequistionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloorDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{RequisitionFloor.RequistionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} = " & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloorDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        querystring = "{ItemList.ItemId}=" & Me.ItemLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionForFloorDetails
        ShowReport(MyReport, querystring, CrystalReportViewer1)
    End Sub

    Private Sub GridLookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpEdit2.EditValueChanged
        Me.RequisitionFloorLookupTableAdapter.Fill(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookUp)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, GridLookUpEdit2.EditValue)
    End Sub
End Class