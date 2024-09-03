Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient


Public Class frmPrintRecipeReport

    Private _IsOrderIdNull As Boolean
    Public Property IsOrderIdNull() As Boolean

        Get
            Return _IsOrderIdNull
        End Get
        Set(ByVal value As Boolean)
            _IsOrderIdNull = value
        End Set

    End Property

    Private _PrintColorId As Integer
    Public Property PrintColorId() As Integer

        Get
            Return _PrintColorId
        End Get
        Set(ByVal value As Integer)
            _PrintColorId = value
        End Set

    End Property
    Private _RecipeId As Integer
    Public Property RecipeId() As Integer
        Get
            Return _RecipeId
        End Get
        Set(ByVal value As Integer)
            _RecipeId = value
        End Set
    End Property

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load


    End Sub

    Private Sub SearchByRecipeId(Optional ByVal ReportName As String = "Sample_Costing_Sheet_Final4")

        'Dim MyReport As New ReportDocument
        'MyReport.Load(Application.StartupPath & "\Report\" & ReportName & ".rpt", OpenReportMethod.OpenReportByTempCopy)

        Dim MyReport As New Sample_Costing_Sheet_Final4

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table


        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog




        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If


        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = "{Recipe.RecipeId}=" & CType(frmRecipe.RecipeIdLabel.Text, Integer)
        CrystalReportViewer1.Refresh()

    End Sub
    Private Sub SearchByPrintColor()

        Dim MyReport As New ReceipeByPrintColor

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table
        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If


        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = "{RecipeColor.PrintColorId}=" & Me.PrintColorId

        CrystalReportViewer1.Refresh()
    End Sub
    Private Sub SearchByRecipeIdProduction()

        Dim MyReport As New Sample_Costing_Sheet_Final_Production



        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If


        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = "{Recipe.RecipeId}=" & CType(frmRecipe.RecipeIdLabel.Text, Integer) & ""
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub frmSampleCosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.PrintRecipeLookupTableAdapter.Fill(Me.PrintRecipeLookupDataSet.PrintRecipeLookup)
        Me.PrintColorTableAdapter.Fill(Me.PrintColorDataSet.PrintColor)
        Dim filterstring As String = String.Empty

        If Me.PrintColorId > 0 Then

            'SearchByPrintColor()
            filterstring = "{RecipeColor.PrintColorId}=" & Me.PrintColorId
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceipeByPrintColor
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf Me.RecipeId > 0 Then

            If Me.IsOrderIdNull = True Then

                'SearchByRecipeId()
                filterstring = "{Recipe.RecipeId}=" & CType(frmRecipe.RecipeIdLabel.Text, Integer)
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Costing_Sheet_Final4
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                'SearchByRecipeIdProduction()
                filterstring = "{Recipe.RecipeId}=" & CType(frmRecipe.RecipeIdLabel.Text, Integer)
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Costing_Sheet_Final_Production
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowByRecipeButton.Click

        Dim OID As Integer = ReadIntegerData("Select OrderId From Recipe Where RecipeId=" & GridLookUpEdit1.EditValue, cnn)

        If OID = 0 Then


            filterstring = "{Recipe.RecipeId}=" & Me.GridLookUpEdit1.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Costing_Sheet_Final4
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else


            filterstring = "{Recipe.RecipeId}=" & Me.GridLookUpEdit1.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Costing_Sheet_Final_Production
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        filterstring = "{RecipeColor.PrintColorId}=" & Me.PrintColorLookupGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceipeByPrintColor
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class

