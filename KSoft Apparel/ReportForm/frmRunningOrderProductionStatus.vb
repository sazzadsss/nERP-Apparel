Public Class frmRunningOrderProductionStatus
    Dim filtestring As String = String.Empty
    Private Sub frmRunningOrderProductionStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SusStandardMstTableAdapter.Fill(Me.SusStandardDataSet.SusStandardMst)
        Me.FabricMaterialTypeTableAdapter.Fill(Me.FabricMaterialTypeDataSet.FabricMaterialType)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click
        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatusbyProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub BuyerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BuyerCheckBox.CheckedChanged
        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{Order.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{FabricBOM.FabricBookingDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{Order.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) AND {Order.SusStandard} = '" & Me.SusStandGridLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{Order.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) AND {Order.FabMatType} = '" & Me.FabMatGridLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And {Order.IsAdvance} And Not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue} And {User.USER_ID}=" & UserGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And Not {Order.Discontinue}"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActualOrderQtyReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And {Order.IsAdvance} And Not {Order.Discontinue}"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActualOrderQtyReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        filterstring = "{Order.IsRunning} And {Order.IsAdvance} And Not {Order.Discontinue} And {User.USER_ID}=" & UserGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RunningOrederProductionStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class