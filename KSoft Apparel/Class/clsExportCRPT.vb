Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class clsExportCRPT
    Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Dim oRDoc As New ReportDocument
    Dim expo As New ExportOptions
    Dim sRecSelFormula As String
    Dim oDfDopt As New DiskFileDestinationOptions
    Dim strCrystalReportFilePath As String
    Dim strPdfFileDestinationPath As String

    Public Function SetCrystalReportFilePath(ByVal MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Try
            oRDoc = MyReport
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Public Function SetPdfDestinationFilePath(ByVal pdfFileNameFullPath As String)
        strPdfFileDestinationPath = pdfFileNameFullPath
    End Function

    Public Function SetRecordSelectionFormula(ByVal recSelFormula As String)
        sRecSelFormula = recSelFormula
    End Function

    Public Function Transfer()

        'oRDoc.Load(strCrystalReportFilePath) 'loads the crystalreports in to the memory
        'oRDoc = OrderPrint
        oRDoc.RecordSelectionFormula = sRecSelFormula   'used if u want pass the query to u r crystal form
        oDfDopt.DiskFileName = strPdfFileDestinationPath    'path of file where u want to locate ur PDF
        expo = oRDoc.ExportOptions
        expo.ExportDestinationType = ExportDestinationType.DiskFile
        expo.ExportFormatType = ExportFormatType.PortableDocFormat
        expo.DestinationOptions = oDfDopt
        oRDoc.SetDatabaseLogon("sa", "fkd@1994") 'login for your DataBase
        oRDoc.Export()

    End Function

End Class
