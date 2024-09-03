Public Class frmShipmentCompleteReport
    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property
    Dim filtestring As String = String.Empty
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "' And not {Order.Discontinue}"
        Else
            filterstring = "{Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) And not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentCompletedProgramList
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub frmShipmentCompleteReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        If Me.OrderId > 0 Then

            filterstring = "{Order.OrderId} = " & Me.OrderId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentCompletedbyProgramList
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



    End Sub



    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click

        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentCompletedbyProgramList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub BuyerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BuyerCheckBox.CheckedChanged
        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsComplete} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'And not {Order.Discontinue}"
        Else
            filterstring = "{Order.IsComplete} And Not {Order.Discontinue} And not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AllProgramList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CancelOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{@CHK0} > 0.00 and {Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{@CHK0} > 0.00 and {Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LeftoverStatus

        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LeftoverStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.CancelledOn} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.CancelledOn} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CancelOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.HoldOn} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.HoldOn} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New HoldOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsHold} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsHold}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New HoldOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class