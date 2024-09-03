Imports System.Data.OleDb
Public Class CrystalReportForm

    'How to Implement

    'Dim ReportForm As New CrystalReportForm
    'Dim TableName(1) As String
    'Dim QueryString(1) As String
    '    TableName(0) = "Table1"
    '    TableName(1) = "Table2"
    '    QueryString(0) = "SELECT * FROM Table1"
    '    QueryString(1) = "SELECT * FROM Table2"
    '    ReportForm.MdiParent = MainForm
    ''Here I am Passing the value of Parameter
    '    ReportForm.ViewReport("CrystalReport1.rpt", TableName, QueryString, "UnRegister")
    '    ReportForm.Show()



    Public Function GetDataAdeptor(ByVal QueryString As String) As OleDbDataAdapter
        Dim DataAdapter As New OleDbDataAdapter
        Try
            Dim NewConnection As OleDbConnection = OpenNewConnection()
            DataAdapter = New OleDbDataAdapter(QueryString, NewConnection)
            Return DataAdapter
        Catch ex1 As OleDbException
            Throw New Exception("Error Getting The Table", ex1)
        Catch ex As Exception
            Throw New Exception("Error Getting The DataAdapter", ex)
        End Try

    End Function

    ''' <summary>
    ''' Open Connection Here
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OpenNewConnection() As OleDbConnection
        Dim NewConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StartUpPath\Database.mdb;Jet OLEDB:Database Password='ShaktiSinghDulawat';")
        Try
            NewConnection.Open()
            Return NewConnection
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    ''' <summary>
    ''' 1)Add Windows Form Name CrystalReportForm
    ''' 2)Add A Panel Set Dock Proprty To Fill
    ''' </summary>
    ''' <param name="ReportName">Report Name Contain The Name</param>
    ''' <param name="TableName">Table Name In Array</param>
    ''' <param name="QueryString">Query String In Array</param>
    ''' <param name="Parameter">Parameter If Any</param>
    ''' <remarks></remarks>
    ''' 

    Friend Sub ViewReport(ByVal ReportName As String, ByVal TableName() As String, ByVal QueryString() As String, Optional ByVal [Parameter] As String = "")

        Me.MdiParent = frmMain
        If Not UBound(TableName).Equals(UBound(QueryString)) Then MessageBox.Show("Passed Variable Are Not Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CrystalReportViewer.ActiveViewIndex = 0
        CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'CrystalReportViewer.DisplayGroupTr
        CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        CrystalReportViewer.Name = "CrystalReportViewer"
        Dim Adapter As New OleDb.OleDbDataAdapter
        Dim DataSet As New DataSet

        For I As Integer = 0 To UBound(TableName)
            Adapter = GetDataAdeptor(QueryString(I))
            Adapter.Fill(DataSet, TableName(I))
        Next

        'Report In the report Folder
        Report.Load(Application.StartupPath & "/Report/" & ReportName & "")
        Report.SetDataSource(DataSet)
        If Not [Parameter] = "" Then Report.SetParameterValue(0, [Parameter])
        CrystalReportViewer.ReportSource = Report
        Me.Panel1.Controls.Add(CrystalReportViewer)

    End Sub

End Class