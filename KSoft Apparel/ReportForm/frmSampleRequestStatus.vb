Public Class frmSampleRequestStatus
    Dim filterString As String = ""



    Private Sub frmSampleRequestStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)
        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        filterString = "{SampleRequestFinal.SampleUpdate}And {SampleRequestFinal.SampleRequestId}=" & RequestGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleButton.Click

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.StyleId}=" & StyleGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.StyleId}=" & StyleGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerButton.Click

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        Dim Buyer As String = ""
        Dim Brand As String = ""
        Dim Division As String = ""
        Dim Season As String = ""
        Dim StyleNo As String = ""
        Dim StyleType As String = ""
        Dim SampleType As String = ""
        Dim Merchandiser As String = ""

        If BuyerCheckBox.Checked Then
            Buyer = " And {SampleRequestFinal.BuyerId} = " & BuyerGridLookUpEdit.EditValue
        End If

        If BrandCheckBox.Checked Then
            Brand = " And {SampleRequestFinal.GmtBrandId}=" & GMTBrandIdGridLookUpEdit.EditValue
        End If

        If DivisionCheckBox.Checked Then
            Division = " And {SampleRequestFinal.DivisionId}=" & DivisionIdGridLookUpEdit.EditValue
        End If

        If SeasonCheckBox.Checked Then
            Season = " And {Style.SeasonId}=" & SeasonGridLookUpEdit.EditValue
        End If

        If StyleNoCheckBox.Checked Then
            StyleNo = " And {SampleRequestFinal.StyleId}=" & StyleGridLookUpEdit.EditValue
        End If

        If StyleTypeCheckBox.Checked Then
            StyleType = " And {SampleRequestFinal.StyleType}='" & StyleTypeComboBox.Text & "'"
        End If

        If SampleTypeCheckBox.Checked Then
            SampleType = " And {SampleRequestFinal.DevTypeId}=" & DevTypeIdGridLookUpEdit.EditValue
        End If
        If MerchandiserCheckBox.Checked Then
            Merchandiser = " And {User.User_Id}= " & UserGridLookUpEdit.EditValue
        End If

        Dim tempstring As String = System.String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", Buyer.ToString, Brand.ToString, Division.ToString, Season.ToString, StyleNo.ToString, StyleType.ToString, SampleType.ToString, Merchandiser.ToString)


        filterString = "not {SampleRequestFinal.IsComplete} And {SampleRequestFinal.SampleUpdate} " & tempstring

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)


    End Sub


    Private Sub AllCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCompleteButton.Click
        'filterString = "{SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.IsComplete} = True"
        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        'ShowReport(MyReport, filterString, CrystalReportViewer1)
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        filterString = "{SampleRequestFinal.CompletedOn} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = True"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatusCompleteDate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles StyleTypeButton.Click

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.StyleType}='" & StyleTypeComboBox.SelectedText & "'"
        filterString = "not {SampleRequestFinal.IsComplete} And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.StyleType}='" & StyleTypeComboBox.Text & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MerchandiserButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {User.User_Id}= " & UserGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {User.User_Id}= " & UserGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub GMDepartmentIdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BrandLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SampleTypeButton_Click(sender As Object, e As EventArgs) Handles SampleTypeButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.DevTypeId}=" & DevTypeIdGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.DevTypeId}=" & DevTypeIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)

    End Sub

    Private Sub BrandButton_Click(sender As Object, e As EventArgs) Handles BrandButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.GmtBrandId}=" & GMTBrandIdGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.GmtBrandId}=" & GMTBrandIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub SeasonButton_Click(sender As Object, e As EventArgs) Handles SeasonButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {Style.SeasonId}=" & SeasonGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {Style.SeasonId}=" & SeasonGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub DivisionButton_Click(sender As Object, e As EventArgs) Handles DivisionButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        'filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.DivisionId}=" & DivisionIdGridLookUpEdit.EditValue
        filterString = "{SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.DivisionId}=" & DivisionIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'filterString = "{SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.IsComplete} = False"
        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        'ShowReport(MyReport, filterString, CrystalReportViewer1)
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatusRequestdate
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub ShowAllRunningButton_Click(sender As Object, e As EventArgs) Handles ShowAllRunningButton.Click
        filterString = "{SampleRequestFinal.IsComplete} = False"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        filterString = "{SampleRequestFinal.IsComplete} = False"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatusSummery
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub
End Class