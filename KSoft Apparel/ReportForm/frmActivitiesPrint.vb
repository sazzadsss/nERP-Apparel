Public Class frmActivitiesPrint
    Dim filterstring As String = ""
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox2.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)

        'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
        'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

        'MessageBox.Show(s1)

        filterstring = "{Activities.ProgramNo} like ['" & s1 & "']"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActivitiesPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.MultipleProgramTextBox2.Text = String.Empty Then
            Me.MultipleProgramTextBox2.Text = Me.ProgramNoGridLookUpEdit.EditValue
        Else
            Me.MultipleProgramTextBox2.Text = Me.MultipleProgramTextBox2.Text & ", " & Me.ProgramNoGridLookUpEdit.EditValue
        End If
    End Sub

    Private Sub frmActivitiesPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.ActivitiesProgramNoLookupTableAdapter.Fill(Me.ActivitiesDataSet.ActivitiesProgramNoLookup)
        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)

    End Sub

    Private Sub ShowByExButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByExButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text
        If BuyerCheckBox.Checked Then
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND {Activities.BuyerId}=" & ComboBox1.SelectedValue
        Else
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActivitiesPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub DepartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text
        If BuyerCheckBox.Checked Then
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND {Activities.BuyerId}=" & ComboBox1.SelectedValue & "AND {Activities.GMDepartmentId}=" & GMDepGridLookUpEdit.EditValue
        Else
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND {Activities.GMDepartmentId}=" & GMDepGridLookUpEdit.EditValue
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActivitiesPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub SeasonButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeasonButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        If BuyerCheckBox.Checked Then
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND {Activities.BuyerId}=" & ComboBox1.SelectedValue & "AND {Activities.SeasonId}=" & SeasonGridLookUpEdit.EditValue
        Else
            filterstring = "{Activities.ExDate} in DateTime (" & FDate.Year.ToString & "," & FDate.Month.ToString & "," & FDate.Day.ToString & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND {Activities.SeasonId}=" & SeasonGridLookUpEdit.EditValue
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ActivitiesPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class