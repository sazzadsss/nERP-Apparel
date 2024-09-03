Imports System.Data
Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties

Public Class FabricBookingReport

    Public Sub CreateFabricBookingReport()
        'Try
        ' Create a DataTable with some example data
        Dim dt As New DataTable()

        ' Example columns (Dynamic columns can be created based on your data)
        dt.Columns.Add("Category", GetType(String))
        dt.Columns.Add("Jan", GetType(Integer))
        dt.Columns.Add("Feb", GetType(Integer))
        dt.Columns.Add("Mar", GetType(Integer))

        ' Add data to DataTable
        dt.Rows.Add("A", 10, 20, 30)
        dt.Rows.Add("B", 15, 25, 35)
        dt.Rows.Add("C", 20, 30, 40)

        ' Add a column for Grand Total
        dt.Columns.Add("Grand Total", GetType(Integer))

        ' Compute Grand Total for each row
        For Each row As DataRow In dt.Rows
            Dim total As Integer = 0
            For i As Integer = 1 To dt.Columns.Count - 2 ' Exclude Category and Grand Total columns
                total += Convert.ToInt32(row(i))
            Next
            row("Grand Total") = total
        Next

        ' Add additional column after Grand Total
        dt.Columns.Add("Additional Column", GetType(String))

        ' Example values for Additional Column
        For Each row As DataRow In dt.Rows
            row("Additional Column") = "Some Value"
        Next
        Dim filePath As String = "D:/CrossTabReport_iText7.pdf"
        ' Create a PDF document using iText 7
        Dim pdfWriter As New PdfWriter(filePath)
        Dim pdfDoc As New PdfDocument(pdfWriter)
        Dim document As New Document(pdfDoc)

        ' Add Title to PDF
        Dim title As New Paragraph("CrossTab Report")
        document.Add(title)
        document.Add(New Paragraph(Environment.NewLine)) ' Add a line break

        ' Create a Table with the number of columns in the DataTable
        Dim table As New Table(dt.Columns.Count)

        ' Add column headers to the PDF table
        For Each column As DataColumn In dt.Columns
            Dim cell As New Cell()
            cell.Add(New Paragraph(column.ColumnName))
            cell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
            cell.SetTextAlignment(TextAlignment.CENTER)
            table.AddHeaderCell(cell)
        Next

        ' Add rows to the PDF table
        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                ' Ensure the cell value is converted to string properly
                table.AddCell(New Cell().Add(New Paragraph(row(column).ToString())))
            Next
        Next

        ' Add the Table to the document
        document.Add(table)

        ' Close the document
        document.Close()

        MessageBox.Show("PDF Report Created Successfully with iText 7!")
        OpenPdf(filePath)
        'Catch ex As Exception
        '    ' Handle exceptions
        '    MessageBox.Show("An error occurred: " & ex.Message)
        'End Try
    End Sub

    Private Sub OpenPdf(filePath As String)
        Try
            ' Open the PDF file using the default PDF viewer
            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Unable to open the PDF file: " & ex.Message)
        End Try
    End Sub

End Class
