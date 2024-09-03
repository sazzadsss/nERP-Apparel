Public Class frmShipmentBalanceReport
    Dim filterstring As String = ""
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If CancelOrderCheckBox.Checked Then


            If DetailsRadioButton.Checked Then


                'If BuyerCheckBox.Checked Then
                '    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {vOrder.BuyerCode}='" & BuyerComboBox.Text & "' And {vOrder.Discontinue}= True "
                'Else
                '    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & " And {vOrder.Discontinue}= True"
                'End If

                If BuyerCheckBox.Checked Then
                    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {vOrder.BuyerCode}='" & BuyerComboBox.Text & "'"
                Else
                    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value
                End If



                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactDetails 'Shipment_Balance__Compact_Details
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)



            ElseIf CompactRadioButton.Checked Then




                If FabricStatusCheckBox.Checked Then

                    If BuyerCheckBox.Checked Then

                        filterstring = "{@FabDelBalancePer} >=" & FFDBalanceNumericUpDown.Value & " and {vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {vOrder.BuyerCode}='" & BuyerComboBox.Text & "'"


                    Else

                        filterstring = "{@FabDelBalancePer} >=" & FFDBalanceNumericUpDown.Value & " and {vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value


                    End If


                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactWithFabricStatusNew  'Shipment_Balance__Compact
                    MyReport.SetParameterValue("FromDate", FDate.Date)
                    MyReport.SetParameterValue("ToDate", TDate.Date)
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)
                Else

                    If BuyerCheckBox.Checked Then
                        filterstring = "{OrderQuantitySummery.MinEx} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & " and {Buyer.BuyerCode}='" & BuyerComboBox.Text & "'"
                    Else
                        filterstring = "{OrderQuantitySummery.MinEx} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value
                    End If



                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactNew   'Shipment_Balance__Compact
                    MyReport.SetParameterValue("FromDate", FDate.Date)
                    MyReport.SetParameterValue("ToDate", TDate.Date)
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)
                End If


            End If


        Else 'CancelOrderCheckBox.Checked=False

            If DetailsRadioButton.Checked Then


                If BuyerCheckBox.Checked Then
                    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {vOrder.BuyerCode}='" & BuyerComboBox.Text & "' And {vOrder.Discontinue}= False"
                Else
                    filterstring = "{vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & " And {vOrder.Discontinue}= False"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactDetails 'Shipment_Balance__Compact_Details
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)



            ElseIf CompactRadioButton.Checked Then



                If FabricStatusCheckBox.Checked Then

                    If BuyerCheckBox.Checked Then

                        filterstring = "{@FabDelBalancePer} >=" & FFDBalanceNumericUpDown.Value & " and {vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {vOrder.BuyerCode}='" & BuyerComboBox.Text & "' And {vOrder.Discontinue}= false"


                    Else

                        filterstring = "{@FabDelBalancePer} >=" & FFDBalanceNumericUpDown.Value & " and {vOrder.EX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "And {vOrder.Discontinue}= false"



                    End If


                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactWithFabricStatusNew   'Shipment_Balance__Compact
                    MyReport.SetParameterValue("FromDate", FDate.Date)
                    MyReport.SetParameterValue("ToDate", TDate.Date)
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)
                Else

                    If BuyerCheckBox.Checked Then
                        filterstring = "{OrderQuantitySummery.MinEX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & "and {Buyer.BuyerCode}='" & BuyerComboBox.Text & "' And {OrderQuantitySummery.Discontinue}= False"
                    Else
                        filterstring = "{OrderQuantitySummery.MinEX} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)and {@BalancePercentage} >= " & BalancePercentageNumericUpDown.Value & " And {OrderQuantitySummery.Discontinue}= False"
                    End If


                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactNew 'ShipmentBalanceCompact   'Shipment_Balance__Compact
                    MyReport.SetParameterValue("FromDate", FDate.Date)
                    MyReport.SetParameterValue("ToDate", TDate.Date)
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)

                End If


            End If

        End If

    End Sub

    Private Sub frmShipmentBalanceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

        If Me.OID > 0 Then

            filterstring = "{vOrder.OrderId} =" & OID
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactDetailsbyprogram
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



    End Sub

   
    Private Sub BuyerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerCheckBox.CheckedChanged

        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If

    End Sub

   
    
    Private Sub CancelOrderCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelOrderCheckBox.CheckedChanged

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.FullCompleteDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentCompletedProgramList
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   

    Private Sub CompactRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompactRadioButton.CheckedChanged

        FabricStatusCheckBox.Enabled = Me.CompactRadioButton.Checked
        
    End Sub

    Private Sub FabricStatusCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricStatusCheckBox.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        filterstring = "{vOrder.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceCompactDetailsbyprogram

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{vOrder.IsRunning} And Not {vOrder.IsAdvance} And Not {vOrder.Discontinue} And {vOrder.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{vOrder.IsRunning} And Not {vOrder.IsAdvance} And Not {vOrder.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceRunningProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If BuyerCheckBox.Checked Then
            filterstring = "{vOrder.IsRunning} And Not {vOrder.IsAdvance} And Not {vOrder.Discontinue} And {vOrder.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{vOrder.IsRunning} And Not {vOrder.IsAdvance} And Not {vOrder.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewPOwiseStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{vOrder.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewPOwiseStatus

        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If BuyerCheckBox.Checked Then
            filterstring = "Not {vOrder.Discontinue} And Not {vOrder.PODiscontinue} And Not {vOrder.IsAdvance} And Not {vOrder.IsPOComplete} And {vOrder.IsRunning} And {vOrder.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {vOrder.Discontinue} And Not {vOrder.PODiscontinue} And Not {vOrder.IsAdvance} And Not {vOrder.IsPOComplete} And {vOrder.IsRunning}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewPOwiseStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If BuyerCheckBox.Checked Then
            filterstring = "Not {vOrder.Discontinue} And Not {vOrder.PODiscontinue} And Not {vOrder.IsAdvance} And Not {vOrder.IsPOComplete} And {vOrder.IsRunning} And {vOrder.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "Not {vOrder.Discontinue} And Not {vOrder.PODiscontinue} And Not {vOrder.IsAdvance} And Not {vOrder.IsPOComplete} And {vOrder.IsRunning}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentBalanceRunningProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class