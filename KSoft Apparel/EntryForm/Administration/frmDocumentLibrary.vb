Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Threading

Public Class frmDocumentLibrary

    Private Worker As BackgroundWorker = New BackgroundWorker
    Dim FileName As String
    Dim FileProcess As String

    Private Sub frmDocumentLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Control.CheckForIllegalCrossThreadCalls = False ' Remove Cross Thead Error from BackGround Worker 30.06.16 - Feroz
        DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True ' Disable Cross Thead Error from BackGround Worker 30.06.16 - Feroz
        Me.ProgressBar.Visible = False
        tbProgress.Visible = False
        DepartmentLookUpGridLookUpEdit.EditValue = DepartmentId
        If UserId = 1 Then
            DocDeleteButton.Visible = True
            RefreshDocButton.Visible = True
            DepartmentLookUpGridLookUpEdit.Enabled = True
        Else
            DocDeleteButton.Visible = False
            RefreshDocButton.Visible = False
            DepartmentLookUpGridLookUpEdit.Enabled = False
            colUploadedBy.OptionsColumn.AllowEdit = False
        End If
        If CheckUserRights("Document Library").CanEdit = False Then

            DocAddButton.Enabled = False
            DocDeleteButton.Enabled = False


        ElseIf CheckUserRights("Document Library").CanDelete = False Then
            DocAddButton.Enabled = True
            DocDeleteButton.Enabled = False
        End If

    End Sub



    Private Sub RefreshDocButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDocButton.Click

        Me.DocumentLibraryTableAdapter.Fill(Me.DocumentLibraryNewDataSet.DocumentLibrary)

    End Sub

    Private Sub SaveDocButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDocButton.Click

        Dim row As DocumentLibraryNewDataSet.DocumentLibraryRow
        row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryNewDataSet.DocumentLibraryRow)
        FileProcess = "Downloading"
        ProgressBar.Visible = True
        tbProgress.Visible = True
        databaseFileRead(row.DocName) ' Function Of Download a file - 30.07.16 Feroz

    End Sub

    Private Sub DocAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocAddButton.Click

        Dim cnndoc As String = My.Settings.KSoft_Doc_ConnectionString
        FileProcess = "Upload"
        ProgressBar.Visible = True
        tbProgress.Visible = True

        databaseFilePut(cnndoc) ' Function Of Upload a file - 30.07.16 Feroz

    End Sub

    Private Sub DocDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocDeleteButton.Click

        FileProcess = "Delete"
        ProgressBar.Visible = True
        tbProgress.Visible = True

        Worker.RunWorkerAsync() ' ProgressBar for Deleting time With Save Work proccess
        Me.Cursor = Cursors.WaitCursor
        SaveDocButton.Enabled = False
        DocAddButton.Enabled = False

    End Sub


    Private Sub databaseFilePut(ByVal connectionString As String)

        Dim openFileDialog1 As New OpenFileDialog()
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Select the file from dialouge Box

            Try

                FileName = openFileDialog1.FileName
                Worker.RunWorkerAsync() ' ProgressBar for uploading time with Upload file Working Process
                Me.Cursor = Cursors.WaitCursor
                SaveDocButton.Enabled = False
                DocAddButton.Enabled = False

            Catch Ex As Exception

                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)

            End Try
        End If

    End Sub

    Private Sub databaseFileRead(ByVal DocName As String)

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.FileName = DocName
        SaveFileDialog1.Title = "Save a file"

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = SaveFileDialog1.FileName()
            Worker.RunWorkerAsync() ' ProgressBar for Downloading time With Save Work proccess
            Me.Cursor = Cursors.WaitCursor
            SaveDocButton.Enabled = False
            DocAddButton.Enabled = False

        End If

    End Sub

    Public Sub New()

        InitializeComponent()
        Worker.WorkerReportsProgress = True
        AddHandler Worker.DoWork, AddressOf worker_DoWork
        AddHandler Worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler Worker.ProgressChanged, AddressOf worker_ProgressChanged

    End Sub

    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        'If Uploading Or Downloading Complete Show that Status as Message - 30.07.16 - Feroz

        Me.Cursor = Cursors.Arrow
        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        ProgressBar.EditValue = 100
        Me.tbProgress.BackColor = Color.Orange
        Me.tbProgress.ForeColor = Color.WhiteSmoke
        Me.tbProgress.Text = "Complete"
        SaveDocButton.Enabled = True
        DocAddButton.Enabled = True
        Dim result As Integer = MessageBox.Show("Done", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            ProgressBar.EditValue = 0
            Me.tbProgress.Text = ""
            ProgressBar.Visible = False
            tbProgress.Visible = False
            If FileProcess = "Downloading" Then
                Process.Start(FileName)
            End If
        End If

    End Sub
    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        If FileProcess = "Upload" Then

            ' Work of Upload a File 30.07.16 Feroz

            Me.tbProgress.Text = "Uploading.."
            ProgressBar.EditValue = 0
            Dim file As Byte()
            Dim connectionString As String = My.Settings.KSoft_Doc_ConnectionString


            Using stream = New FileStream(FileName, FileMode.Open, FileAccess.Read) ' Process Of Reading A file

                Using reader = New BinaryReader(stream)
                    file = reader.ReadBytes(CInt(stream.Length)) 'Get The file
                End Using

            End Using

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                'Process Of save File in DB


                Worker.ReportProgress(95)
                Using sqlWrite = New SqlCommand("INSERT INTO DocumentLibrary (Doc,DocName,UploadedOn,UploadedBy,DepartmentId)Values(@Doc,@DocName,@UploadedOn,@UploadedBy,@DepartmentId)", connection)
                    sqlWrite.Parameters.Add("@Doc", SqlDbType.VarBinary, file.Length).Value = file
                    sqlWrite.Parameters.Add("@DocName", SqlDbType.VarChar).Value = System.IO.Path.GetFileName(FileName)
                    sqlWrite.Parameters.Add("@UploadedOn", SqlDbType.DateTime).Value = Now()
                    sqlWrite.Parameters.Add("@UploadedBy", SqlDbType.BigInt).Value = UserId
                    sqlWrite.Parameters.Add("@DepartmentId", SqlDbType.BigInt).Value = DepartmentId
                    sqlWrite.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using

            Me.DocumentLibraryTableAdapter.FillByDepartmentId(Me.DocumentLibraryNewDataSet.DocumentLibrary, DepartmentId)

        ElseIf FileProcess = "Downloading" Then

            'Work Of download a File 30.07.16 - Feroz

            Me.tbProgress.Text = "Downloading.."
            ProgressBar.EditValue = 0

            Dim row As DocumentLibraryNewDataSet.DocumentLibraryRow
            row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryNewDataSet.DocumentLibraryRow)

            Dim DocId As Integer = row.DocumentLibraryId ' Get the Current File Name

            Dim varPathToNewLocation As String = FileName



            Using connection As New SqlConnection(My.Settings.KSoft_Doc_ConnectionString)
                connection.Open()
                Using sqlQuery = New SqlCommand("SELECT Doc FROM DocumentLibrary WHERE [DocumentLibraryId] = @DocId", connection)
                    sqlQuery.Parameters.AddWithValue("@DocId", DocId)

                    Using sqlQueryResult = sqlQuery.ExecuteReader() 'Process Of Saving File On PC 30.07.16 - Feroz
                        If sqlQueryResult IsNot Nothing Then


                            Worker.ReportProgress(95)

                            sqlQueryResult.Read()
                            Dim blob = New [Byte]((sqlQueryResult.GetBytes(0, 0, Nothing, 0, Integer.MaxValue)) - 1) {}
                            sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length)
                            Using fs = New FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write)
                                fs.Write(blob, 0, blob.Length)
                            End Using
                        End If
                    End Using
                End Using
            End Using


        ElseIf FileProcess = "Delete" Then 'Process When Delete a doc - 01.08.16 - Feroz

            Me.tbProgress.Text = "Deleting.."
            ProgressBar.EditValue = 0

            Dim connectionString As String = My.Settings.KSoft_Doc_ConnectionString

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                'Process Of Delete File in DB
                Dim row As DocumentLibraryNewDataSet.DocumentLibraryRow
                row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryNewDataSet.DocumentLibraryRow)


                Worker.ReportProgress(95)

                Using sqlWrite = New SqlCommand("DELETE DocumentLibrary Where DocumentLibraryId = " & row.DocumentLibraryId, connection)
                    sqlWrite.ExecuteNonQuery()
                End Using
                Me.DocumentLibraryBindingSource.RemoveCurrent()
                connection.Close()

            End Using

        End If
    End Sub

    Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        ProgressBar.EditValue = e.ProgressPercentage
        Me.tbProgress.BackColor = Color.Orange
        Me.tbProgress.ForeColor = Color.WhiteSmoke
        Me.tbProgress.Text = e.ProgressPercentage.ToString() & "%"

    End Sub

    Private Sub ProgressBar_Click(sender As Object, e As EventArgs) Handles ProgressBar.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Me.Validate()
        Me.DocumentLibraryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DocumentLibraryNewDataSet)

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        If UserId = 1 Then
            Me.DocumentLibraryTableAdapter.FillByDepartmentId(Me.DocumentLibraryNewDataSet.DocumentLibrary, Me.DepartmentLookUpGridLookUpEdit.EditValue)
        Else
            Me.DocumentLibraryTableAdapter.FillByDepartmentId(Me.DocumentLibraryNewDataSet.DocumentLibrary, DepartmentId)
        End If

    End Sub











    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    '    Try

    '        '==========
    '        'Dim strm As System.IO.Stream
    '        'strm = OpenFileDialog1.OpenFile()
    '        'TextBox1.Text = OpenFileDialog1.FileName.ToString()
    '        'If Not (strm Is Nothing) Then
    '        '    'insert code to read the file data
    '        '    strm.Close()
    '        '    MessageBox.Show("file closed")
    '        'End If

    '        '==========
    '        Dim file1 As String = String.Empty
    '        Dim file2 As String = String.Empty


    '        If Openfile.ShowDialog = System.Windows.Forms.DialogResult.OK And Openfile.FileName <> "" Then
    '            file1 = Openfile.FileName

    '        End If

    '        'If Openfile.ShowDialog = System.Windows.Forms.DialogResult.OK And Openfile.FileName <> "" Then
    '        '    file2 = Openfile.FileName
    '        'End If

    '        If Me.StyleBindingSource.Position > -1 Then

    '            Dim Image1 As New Bitmap(file1)
    '            'Dim Image2 As New Bitmap(file2)

    '            Dim Image3 As New Bitmap(600, 1000)

    '            Dim g As Graphics = Graphics.FromImage(Image3)
    '            g.DrawImage(Image1, New Point(0, 0))
    '            'g.DrawImage(Image2, New Point(0, 500))
    '            g.Dispose()
    '            g = Nothing


    '            'PicturePictureEdit.EditValue = Image3
    '            'PicturePictureEdit.Refresh()

    '            Dim row As DocumentLibraryDataSet.DocumentLibraryRow
    '            row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryDataSet.DocumentLibraryRow)
    '            row.DocumentFile = Image3


    '        End If

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message)

    '    End Try

    'End Sub

    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    ' Create Object Instance 
    '    Dim openFileDialog1 As New OpenFileDialog()
    '    Dim ftpClient As New ftp(ftplocation, ftpuser, ftppass)

    '    If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

    '        Try

    '            Dim row As DocumentLibraryDataSet.DocumentLibraryRow
    '            row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryDataSet.DocumentLibraryRow)

    '            row.DocumentName = System.IO.Path.GetFileName(openFileDialog1.FileName)

    '            ftpClient.upload(row.DocumentName, openFileDialog1.FileName)


    '        Catch Ex As Exception

    '            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)

    '        Finally

    '            '' Check this again, since we need to make sure we didn't throw an exception on open.
    '            'If (myStream IsNot Nothing) Then
    '            '    myStream.Close()
    '            'End If

    '            MessageBox.Show("File Uploaded")

    '        End Try

    '    End If



    'End Sub

    'Private Sub UploadFile()

    '    Dim PathCV As String = ""
    '    Dim openFileDialog1 As New OpenFileDialog()
    '    openFileDialog1.Title = "Select file"

    '    If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '        If openFileDialog1.FileName.Length > 0 Then
    '            pathCV = openFileDialog1.FileName
    '        End If
    '    End If

    '    ' Read the file and convert it to Byte Array
    '    Dim filePath As String = pathCV
    '    Dim contenttype As String = [String].Empty

    '    'contenttype = "application/pdf"

    '    'If contenttype <> [String].Empty Then
    '    Dim fs As Stream = File.OpenRead(filePath)
    '    Dim br As New BinaryReader(fs)

    '    Dim row As DocumentLibraryDataSet.DocumentLibraryRow
    '    row = CType(CType(Me.DocumentLibraryBindingSource.Current, DataRowView).Row, DocumentLibraryDataSet.DocumentLibraryRow)
    '    row.DocumentFile = br.ReadBytes(DirectCast(fs.Length, Long))

    '    'End If

    'End Sub

End Class