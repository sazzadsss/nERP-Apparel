

Public Class frmActiveMonth
    
    Private Sub ActiveMonthBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveMonthBindingNavigatorSaveItem.Click


        Me.Validate()
        Me.ActiveMonthBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActiveMonthDataSet)

        Dim yr As Integer = ReadIntData("Select YearNo From ActiveMonth Where Active=1", cnn)
        Dim mnth As Integer = ReadIntData("Select MonthNo From ActiveMonth Where Active=1", cnn)

        Dim FromDate As Date = DateSerial(yr, mnth, 1)
        'Debug.Print(StartMonth)

        Dim ToDate As Date = DateSerial(yr, mnth + 1, 0)
        'Debug.Print(EndMonth)



        '=========================

        Dim sqlstring As String = ""


        sqlstring = "SET QUOTED_IDENTIFIER ON "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "ALTER VIEW dbo.LineWiseEfficiency " &
        "AS " &
        "SELECT     Line, SUM(PRDHOURS) AS PRDHOURS, SUM(SPNDHOURS) AS SPNDHOURS " &
        "FROM         dbo.vSewingProduction " &
        "WHERE     (SewingDate BETWEEN CONVERT(DATETIME, '" & FromDate.Year & "-" & FromDate.Month & "-" & FromDate.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & ToDate.Year & "-" & ToDate.Month & "-" & ToDate.Day & " 00:00:00', 102)) " &
        "GROUP BY Line " &
        "HAVING      (NOT (Line IS NULL)) "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER OFF "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER ON "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)

        sqlstring = "ALTER VIEW dbo.MonthlyFloorInchargeWiseEfficiency " &
        "AS " &
        "SELECT     FloorInchargeId, SUM(ISNULL(PRDHOURS, 0)) AS PRODHOURS, SUM(ISNULL(SPNDHOURS, 0)) AS SPNDHOURS, SUM(TTLProduction) AS PRODUCTION " &
        "FROM         dbo.vSewingProductionNew " &
        "WHERE     (SewingDate BETWEEN CONVERT(DATETIME, '" & FromDate.Year & "-" & FromDate.Month & "-" & FromDate.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & ToDate.Year & "-" & ToDate.Month & "-" & ToDate.Day & " 00:00:00', 102)) " &
        "GROUP BY FloorInchargeId " &
        "HAVING      (FloorInchargeId IS NOT NULL) "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER OFF "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)


        sqlstring = "SET QUOTED_IDENTIFIER ON "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)


        sqlstring = "ALTER VIEW dbo.MonthlyLineWiseEfficiency " &
        "AS " &
        "SELECT     LineId, SUM(PRDHOURS) AS PRDHOURS, SUM(SPNDHOURS) AS SPNDHOURS, SUM(TTLProduction) AS PRODUCTION, SUM(WH) AS WH " &
        "FROM         dbo.vSewingProductionNew " &
        "WHERE     (SewingDate BETWEEN CONVERT(DATETIME, '" & FromDate.Year & "-" & FromDate.Month & "-" & FromDate.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & ToDate.Year & "-" & ToDate.Month & "-" & ToDate.Day & " 00:00:00', 102)) " &
        "GROUP BY LineId "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER OFF  "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON  "
        ExecuteQuery(sqlstring, cnn)

        sqlstring = "SET QUOTED_IDENTIFIER ON  "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON  "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "ALTER VIEW dbo.MonthlyPMWiseEfficiency " &
        "AS " &
        "SELECT     PMId, SUM(ISNULL(SPNDHOURS, 0)) AS SPNDHOURS, SUM(ISNULL(TTLProduction, 0)) AS PRODUCTION, SUM(ISNULL(PRDHOURS, 0)) AS PRODHOURS " &
        "FROM         dbo.vSewingProductionNew " &
        "WHERE     (SewingDate BETWEEN CONVERT(DATETIME, '" & FromDate.Year & "-" & FromDate.Month & "-" & FromDate.Day & " 00:00:00', 102) AND CONVERT(DATETIME, '" & ToDate.Year & "-" & ToDate.Month & "-" & ToDate.Day & " 00:00:00', 102)) " &
        "GROUP BY PMId " &
        "HAVING      (PMId IS NOT NULL)"
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER OFF "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)



        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER ON  "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON  "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "ALTER VIEW [dbo].[LinewiseStyleAndSMVSummery] " &
                    "AS " &
                    "SELECT     TOP (100) PERCENT dbo.SewingProduction.LineId, COUNT(DISTINCT dbo.SewingLayout.StyleId) AS StyleQty, AVG(ISNULL(dbo.SewingLayout.TotalSMV_Machine + dbo.SewingLayout.TotalSMV_Manual, 0)) AS AVGSMV, AVG(dbo.LINE_MACHINE_USAGES.TTLMC) AS AVGMC 
	                FROM  dbo.SewingAttendance LEFT OUTER JOIN 
	                    dbo.LINE_MACHINE_USAGES ON dbo.SewingAttendance.AttendanceId = dbo.LINE_MACHINE_USAGES.AttendanceId RIGHT OUTER JOIN  
	                    dbo.SewingProduction ON dbo.SewingAttendance.AttendanceDate = dbo.SewingProduction.SewingDate AND dbo.SewingAttendance.LineId = dbo.SewingProduction.LineId LEFT OUTER JOIN 
                        dbo.Style Right OUTER JOIN 
	                    dbo.SewingLayout ON dbo.Style.StyleId = dbo.SewingLayout.StyleId ON dbo.SewingProduction.SewingLayoutId = dbo.SewingLayout.LayoutId 
	                WHERE     (dbo.SewingProduction.SewingDate BETWEEN CONVERT(DATETIME, '2016-09-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-09-30 00:00:00', 102)) 
	                GROUP BY dbo.SewingProduction.LineId 
	                ORDER BY dbo.SewingProduction.LineId "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET QUOTED_IDENTIFIER OFF "
        ExecuteQuery(sqlstring, cnn)
        sqlstring = "SET ANSI_NULLS ON "
        ExecuteQuery(sqlstring, cnn)


        MessageBox.Show("Update Succesfully")
        '========================

        'filterstring = ""

        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Efficiency_Report_Final
        'ShowReport(MyReport, filterstring, CrystalReportViewer1)




    End Sub

    Private Sub frmActiveMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ActiveMonthTableAdapter.Fill(Me.ActiveMonthDataSet.ActiveMonth)

    End Sub

End Class