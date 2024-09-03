Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmOrderBookingMasterReport
    Dim filterstring As String = ""

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth


    End Sub

    Private Sub frmOrderBookingMasterReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)
        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        'If BuyerCheckBox.Checked Then
        '    filterstring = "{OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {OrderBookingMaster.BuyerCode}='" & BuyerComboBox.SelectedValue & "'"
        'Else

        'End If

        If ExRadioButton.Checked Then
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewByRcvDate
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub

    Private Sub ShowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton2.Click

        filterstring = "{OrderBookingMaster.ProgramNo} = '" & ProgramNoGridLookUpEdit.Text & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMaster
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub BuyerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerCheckBox.CheckedChanged

        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With frmOrderBookingMaster_Export
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub BookingCapacityButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingCapacityButton.Click
        If CheckBox1.Checked Then

            filterstring = "{OrderBookingMaster.Year} =" & YearDateTimePicker.Value.Year & " And {OrderBookingMaster.Month} =" & YearDateTimePicker.Value.Month & " And Not {OrderBookingMaster.IsAdvance} And not {OrderBookingMaster.Discontinue} And Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.BuyerCode} = '" & Me.ComboBox1.Text & "'"
        Else
            filterstring = "{OrderBookingMaster.Year} =" & YearDateTimePicker.Value.Year & " And {OrderBookingMaster.Month} =" & YearDateTimePicker.Value.Month & " And Not {OrderBookingMaster.IsAdvance} And not {OrderBookingMaster.Discontinue} And Not {OrderBookingMaster.IsAdvance}"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BookingCapacity
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        If MerchandiserCheckBox.Checked Then
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {OrderBookingMaster.Merchandiser} = '" & Me.MerchandiserGridLookUpEdit.EditValue & "'"
        Else
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If


        'If WithOutValueRadioButton.Checked Then
        '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNew
        '    ShowReport(MyReport, filterstring, CrystalReportViewer1)
        'Else
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterByMerchandiser
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
        'End If

    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click
        Dim filterstring As String = String.Empty
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        Dim Buyer As String = ""
        Dim StyleNo As String = ""
        Dim StyleType As String = ""
        Dim Brand As String = ""
        Dim Division As String = ""
        Dim Season As String = ""


        If BuyerCheckBox.Checked Then
            Buyer = "And {OrderBookingMaster.BuyerId} = " & BuyerComboBox.SelectedValue
        End If

        If StyleNoCheckBox.Checked Then
            StyleNo = "And {OrderBookingMaster.StyleId} = " & StyleGridLookUpEdit.EditValue
        End If

        If StyleTypeCheckBox.Checked Then
            StyleType = "And {Style.StyleType} ='" & StyleTypeComboBox.Text & "'"
        End If

        If BrandCheckBox.Checked Then
            Brand = "And {Style.GMTBrandId} =" & GMTBrandIdGridLookUpEdit.EditValue
        End If

        If DivisionCheckBox.Checked Then
            Division = "And {Style.DivisionId} = " & DivisionIdGridLookUpEdit.EditValue
        End If

        If SeasonCheckBox.Checked Then
            Season = "And {Style.SeasonId} =" & SeasonGridLookUpEdit.EditValue
        End If

        Dim tempstring As String = System.String.Format("{0}{1}{2}{3}{4}{5}", Buyer.ToString(), StyleNo.ToString(), StyleType.ToString(), Brand.ToString(), Division.ToString(), Season.ToString())
        'tempstring = tempstring.Substring(3)
        If ExRadioButton.Checked Then
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) " & tempstring
        Else
            filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) " & tempstring
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click


        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text


        filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMaster
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub WithValueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ReceiveRadioButton.CheckedChanged

        If ReceiveRadioButton.Checked Then

            POButton.Enabled = False
            SummeryButton.Enabled = False

        Else

            POButton.Enabled = True
            SummeryButton.Enabled = True

        End If

    End Sub

    Private Sub ExRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ExRadioButton.CheckedChanged
        If ReceiveRadioButton.Checked Then

            POButton.Enabled = False
            SummeryButton.Enabled = False

        Else

            POButton.Enabled = True
            SummeryButton.Enabled = True

        End If
    End Sub

    Private Sub POButton_Click(sender As Object, e As EventArgs) Handles POButton.Click
        'MessageBox.Show("Welcome to our " & SName & ". This feature is Coming Soon", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text


        filterstring = "Not {OrderBookingMasterByPO.IsAdvance} And {OrderBookingMasterByPO.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewPOwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        'If BuyerCheckBox.Checked Then
        '    filterstring = "{OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {OrderBookingMaster.BuyerCode}='" & BuyerComboBox.SelectedValue & "'"
        'Else

        'End If

        If ExRadioButton.Checked Then
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNewByRcvDate
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filterstring As String = String.Empty
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        Dim Buyer As String = ""
        Dim StyleNo As String = ""
        Dim StyleType As String = ""
        Dim Brand As String = ""
        Dim Division As String = ""
        Dim Season As String = ""


        If BuyerCheckBox.Checked Then
            Buyer = "And {OrderBookingMaster.BuyerId} = " & BuyerComboBox.SelectedValue
        End If

        If StyleNoCheckBox.Checked Then
            StyleNo = "And {OrderBookingMaster.StyleId} = " & StyleGridLookUpEdit.EditValue
        End If

        If StyleTypeCheckBox.Checked Then
            StyleType = "And {Style.StyleType} ='" & StyleTypeComboBox.Text & "'"
        End If

        If BrandCheckBox.Checked Then
            Brand = "And {Style.GMTBrandId} =" & GMTBrandIdGridLookUpEdit.EditValue
        End If

        If DivisionCheckBox.Checked Then
            Division = "And {Style.DivisionId} = " & DivisionIdGridLookUpEdit.EditValue
        End If

        If SeasonCheckBox.Checked Then
            Season = "And {Style.SeasonId} =" & SeasonGridLookUpEdit.EditValue
        End If

        Dim tempstring As String = System.String.Format("{0}{1}{2}{3}{4}{5}", Buyer.ToString(), StyleNo.ToString(), StyleType.ToString(), Brand.ToString(), Division.ToString(), Season.ToString())
        'tempstring = tempstring.Substring(3)
        If ExRadioButton.Checked Then
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) " & tempstring
        Else
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) " & tempstring
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        If MerchandiserCheckBox.Checked Then
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {OrderBookingMaster.Merchandiser} = '" & Me.MerchandiserGridLookUpEdit.EditValue & "'"
        Else
            filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.EX} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingMasterByMerchandiser
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub
End Class