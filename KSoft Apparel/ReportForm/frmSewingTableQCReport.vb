Public Class frmSewingTableQCReport
    Dim filterstring As String = ""

    Private Sub frmSewingTableQCReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LineTableAdapter.FillByPlanning(Me.LineDataSet.Line)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click


        '{SewingTableQC.QCDate} = DateTime (2010, 08, 17, 00, 00, 00) and
        '{Branch.BranchCode} = "ET1"


        filterstring = "{SewingTableQC.QCDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {SewingTableQC.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyTabeQCReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    
    Private Sub MonthlyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyButton.Click

        Try

      
            Dim sqlstring As String = ""



            sqlstring = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SewingTableQC_Monthly]') and OBJECTPROPERTY(id, N'IsView') = 1) " & _
                        "drop view [dbo].[SewingTableQC_Monthly]"

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SewingTableQC_Monthly_Summery]') and OBJECTPROPERTY(id, N'IsView') = 1) " & _
                        "drop view [dbo].[SewingTableQC_Monthly_Summery]"

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET QUOTED_IDENTIFIER ON"

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET ANSI_NULLS ON"

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "CREATE VIEW dbo.SewingTableQC_Monthly_Summery " & _
                        "AS " & _
                        "SELECT    LineId, SUM(CheckQuantity) AS CheckQuantity, SUM(OKQuantity) AS OKQuantity, SUM(ALTEROKQuantity) AS ALTEROKQuantity " & _
                        "FROM         dbo.SewingTableQC " & _
                        "WHERE (QCDate BETWEEN CONVERT(DATETIME, '" & DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & " 00:00:00', 102)) " & _
                        "GROUP BY LineId "

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET QUOTED_IDENTIFIER OFF "

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET ANSI_NULLS ON "

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET QUOTED_IDENTIFIER ON "

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET ANSI_NULLS ON"

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "CREATE VIEW dbo.SewingTableQC_Monthly " & _
                        "AS " & _
                        "SELECT     dbo.SewingTableQC.LineId, dbo.SewingTableQCDetails.QCCheckListId, SUM(dbo.SewingTableQCDetails.Quantity) AS QCQuantity, MIN(dbo.SewingTableQC.QCDate) " & _
                                              "AS FromDate, MAX(dbo.SewingTableQC.QCDate) AS ToDate, dbo.SewingTableQC.BranchId " & _
                        "FROM         dbo.SewingTableQC LEFT OUTER JOIN " & _
                                              "dbo.SewingTableQCDetails ON dbo.SewingTableQC.SewingTableQCId = dbo.SewingTableQCDetails.SewingTableQCId " & _
                        "WHERE     (dbo.SewingTableQC.QCDate BETWEEN CONVERT(DATETIME,'" & DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & " 00:00:00', 102)) " & _
                        "GROUP BY dbo.SewingTableQC.LineId, dbo.SewingTableQCDetails.QCCheckListId, dbo.SewingTableQC.BranchId " & _
                        "HAVING      (SUM(dbo.SewingTableQCDetails.Quantity) > 0) "

            ExecuteQuery(sqlstring, cnn)
            'Debug.Print(sqlstring)

            sqlstring = "SET QUOTED_IDENTIFIER OFF "

            ExecuteQuery(sqlstring, cnn)

            sqlstring = "SET ANSI_NULLS ON "

            ExecuteQuery(sqlstring, cnn)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try



        filterstring = "{SewingTableQC_Monthly.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyTableQCReport

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub LineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineButton.Click

        filterstring = "{SewingTableQC_Line.QCDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {SewingTableQC_Line.LineId} = " & LineComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_LineTableQCReport

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class