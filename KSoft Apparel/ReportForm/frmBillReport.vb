
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmBillReport
    Dim filterstring As String = ""
    Private Sub frmBillReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        DateTimePicker1.Value = StartMonth
        DateTimePicker2.Value = Today()

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index

    End Sub

    

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        '{Category.CategoryName} = "NEEDLE" and {Issueto.IssuetoDate} = DateTime (2010, 01, 22, 00, 00, 00)

        If ConvRadioButton.Checked = True Then
            filterstring = "{ConveyanceBill.ConveyanceDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {ConveyanceBill.DepartmentId} = " & ComboBox1.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Conveyance
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf AllowanceRadioButton.Checked = True Then
            filterstring = "{FoodAllowanceBill.FADate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {FoodAllowanceBill.DepartmentId} = " & ComboBox1.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Allowance
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            MessageBox.Show("Sorry,Transport Bill has not been done")
        End If



    End Sub

    
End Class