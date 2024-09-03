'Imports System.Data.SqlClient

'Public Class Form1
'    Dim dt As New DataTable

'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim dt As New DataTable
'        dt.Columns.Add("isd", GetType(System.Boolean))
'        dt.Columns.Add("name", GetType(System.String))
'        dt.Rows.Add(True, "123")
'        dt.Rows.Add(True, "123")
'        dt.Rows.Add(False, "123")
'        dt.Rows.Add(True, "123")
'        Me.DataGridView1.DataSource = dt
'    End Sub

'    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
'        For Each dr As DataGridViewRow In DataGridView1.Rows
'            If dr.Cells(0).Value = False Then
'                dr.DefaultCellStyle.BackColor = Color.Red
'            End If
'        Next
'    End Sub
'End Class


