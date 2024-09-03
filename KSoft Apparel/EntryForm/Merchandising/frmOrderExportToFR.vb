Imports System.IO
Imports System.Data.SqlClient

Public Class frmOrderExportToFR

    Private Sub frmOrderExportToFR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrdersExportForFRTableAdapter.Fill(Me.OrderExportForFRDataSet.OrdersExportForFR)

    End Sub

    Private Sub ExportLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportLinkLabel.LinkClicked
        ExportOrders()
    End Sub
    Private Sub ExportOrders()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("E:\FR_ImportFiles\ORDERS.TXT")

        If fileExists = True Then
            My.Computer.FileSystem.RenameFile("E:\FR_ImportFiles\ORDERS.TXT", "ORDERS-" & Format(Now(), "ddMMyyHHmmss") & ".TXT")
        End If

        Dim fileLoc As String = "E:\FR_ImportFiles\ORDERS.TXT"
        Dim TargetFile As StreamWriter
        'Creating file
        Dim fs As FileStream = Nothing

        If (Not File.Exists(fileLoc)) Then
            fs = File.Create(fileLoc)
            fs.Close()
        End If

        Try
            'Writing Header
            TargetFile = New StreamWriter(fileLoc, True)


            ''O.CODE	O.PROD	O.CUST	O^DD:1	O^DQ:1	O.CONTRACT_QTY	O.STATUS

            TargetFile.Write("O.CODE" & vbTab)
            TargetFile.Write("O.PROD" & vbTab)
            TargetFile.Write("C.CUST" & vbTab)
            TargetFile.Write("O^DD:1" & vbTab)
            TargetFile.Write("O^DQ:1" & vbTab)
            TargetFile.Write("O.CONTRACT_QTY" & vbTab)
            TargetFile.Write("O.STATUS" & vbTab)
            TargetFile.WriteLine()
            'Writing Data
            Using connection As New SqlConnection(cnn)
                Dim command As New SqlCommand("Select [O.CODE],[O.PROD],[O.CUST],[O^DD:1],[O^DQ:1] From OrdersExportForFR Where SynFR=0", connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    TargetFile.Write(reader("O.CODE") & vbTab)
                    TargetFile.Write(reader("O.PROD") & vbTab)
                    TargetFile.Write(reader("O.CUST") & vbTab)
                    TargetFile.Write(reader("O^DD:1") & vbTab)
                    TargetFile.Write(reader("O^DQ:1") & vbTab)
                    TargetFile.Write("0" & vbTab)
                    TargetFile.Write("" & vbTab)
                    TargetFile.WriteLine()

                End While

                ExecuteQuery("Update OrderDetails Set SynFR=1", cnn)
                Me.OrdersExportForFRTableAdapter.Fill(Me.OrderExportForFRDataSet.OrdersExportForFR)
                reader.Close()

            End Using

            TargetFile.Close()

        Catch
            MessageBox.Show("Error opening " & fileLoc)
        End Try

    End Sub
End Class