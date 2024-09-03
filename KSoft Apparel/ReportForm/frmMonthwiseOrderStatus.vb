Public Class frmMonthwiseOrderStatus
    Dim SDate As Date
    Dim SDate2 As Date

    Private Sub FrmMonthwiseOrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingPortrait
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowYearlyButton_Click(sender As Object, e As EventArgs) Handles ShowYearlyButton.Click
        filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.ExYear} in " & ComboBox1.Text & " to " & ComboBox2.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingLandScape
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingLandScape
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub BuyerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BuyerCheckBox.CheckedChanged
        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.ExYear} in " & ComboBox1.Text & " to " & ComboBox2.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingBlock
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "{VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingBlock
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "{VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then

            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {VOrder.IsAdvance} And Not {VOrder.Discontinue} And {VOrder.Ex} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderVSShipmentInformation
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        filterstring = "Not {vOrder.IsAdvance} and Not {vOrder.Discontinue} and {vOrder.IsRunning}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingLandScape
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        filterstring = "Not {vOrder.IsAdvance} and Not {vOrder.Discontinue} and not {vOrder.IsPOComplete} and {vOrder.IsRunning}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseOrderBookingLandScape
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class