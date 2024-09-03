Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO

Public Class frmStyle
    Private _StyleName As String
    Public Property StyleName() As String
        Get
            Return _StyleName
        End Get
        Set(ByVal value As String)
            _StyleName = value
        End Set
    End Property

    Private _StyleId As Integer
    Public Property StyleId() As Integer
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Integer)
            _StyleId = value
        End Set
    End Property

    Private Sub frmStyle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        StyleLookupGridLookUpEdit.Focus()
    End Sub

    Private Sub save()
        Try
            Me.Validate()
            Me.StyleBindingSource.EndEdit()
            Me.FRStyleProcessBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StyleDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub frmStyle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        LoadData()

        Me.FRStyleProcessTableAdapter.Fill(Me.StyleDataSet.FRStyleProcess)

        If Me.StyleId > 0 Then
            Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, Me.StyleId)
            Me.StyleLookupGridLookUpEdit.EditValue = Me.StyleId
        End If

        'If Me.StyleName = String.Empty Then

        '    Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)

        'Else

        '    Me.StyleTableAdapter.FillByStyleName(Me.StyleDataSet.Style, Me.StyleName)

        'End If
        NewLinkLabel.Enabled = True
        EditLinkLabel.Enabled = True
        DeleteLinkLabel.Enabled = True
        CancelLinkLabel.Enabled = True

        StyleDataSet.Style.UserIdColumn.DefaultValue = UserId
        StyleDataSet.Style.ModifiedOnColumn.DefaultValue = Now()
        StyleNameTextEdit.Properties.ReadOnly = True


        With YarnDyeingTypeGridLookUpEdit

            .ForceInitialize() ' Force it to initialize
            '.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "YarnDyeingTypeId", True))
            .Properties.DataSource = GetYarnDyingType()
            .Properties.DisplayMember = "YarnDyeingType"
            .Properties.ValueMember = "YarnDyeingTypeId"
            .Properties.PopulateViewColumns() ' Force the lookupedit to populate
            .Properties.View.Columns("YarnDyeingTypeId").Visible = False

        End With



        If CheckUserRights("Style").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Style").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If
    End Sub

    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked

        If NewLinkLabel.Text = "Add" Then

            StyleBindingSource.AddNew()

            NewLinkLabel.Text = "Save"
            StyleNameTextEdit.Focus()
            StyleNameTextEdit.Properties.ReadOnly = False

        Else
            Try
                If Me.StyleNameTextEdit.EditValue = String.Empty Then
                    MessageBox.Show("Style No is Require")
                    Exit Sub
                End If

                Dim row As StyleDataSet.StyleRow
                row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)


                row.UserId = UserId
                row.ModifiedOn = Now()

                Me.Validate()
                Me.StyleBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.StyleDataSet)

                If row.IsPictureNull = False Then
                    Resizer(row.StyleId)
                End If

                NewLinkLabel.Text = "Add"
                OKButton.Focus()
                StyleNameTextEdit.Properties.ReadOnly = True



            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If

        'Me.TableAdapterManager.UpdateAll(Me.StyleDataSet)


    End Sub



    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        Dim Result As Integer = MessageBox.Show("Are you want to DELETE !", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If Result = DialogResult.OK Then
            If StyleBindingSource.Position > -1 And UserId = 1 Then
                StyleBindingSource.RemoveCurrent()
                save()
            Else
                MessageBox.Show("You Can't Delete This Style")
            End If
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked

        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
        StyleNameTextEdit.Properties.ReadOnly = True

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        '=============================
        'Start : Checking Style Used or No ...
        '=============================
        'Dim StyleCount As Integer = 0

        'Using connection As New SqlConnection(cnn)

        '    Dim querystring As String = "SELECT name FROM sysobjects WHERE id IN ( SELECT id FROM syscolumns WHERE name = 'styleId' ) And xtype='U'"

        '    Dim command As New SqlCommand(querystring, connection)
        '    command.Connection.Open()
        '    command.ExecuteNonQuery()

        '    Dim reader As SqlDataReader = command.ExecuteReader()

        '    Dim row As StyleDataSet.StyleRow
        '    row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

        '    While reader.Read()

        '        If reader(0).ToString <> "Style" Then
        '            Dim i As Integer
        '            If reader(0).ToString = "Order" Then
        '                i = ReadIntData("Select Count(StyleId) As SCount From [" & reader(0).ToString & "] Where StyleId = " & row.StyleId, cnn)
        '            Else
        '                i = ReadIntData("Select Count(StyleId) As SCount From " & reader(0).ToString & " Where StyleId = " & row.StyleId, cnn)
        '            End If

        '            StyleCount = StyleCount + i
        '        End If


        '    End While

        '    reader.Close()
        '    connection.Close()

        'End Using


        'If StyleCount > 0 Then
        '    StyleNameTextEdit.Enabled = False
        'End If

        '=============================
        'End : Checking Style Used or No ...

        '=============================
        If StyleBindingSource.Position > -1 Then

            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

            If UserId > 1 Then
                If IsAlreadyUsed("StyleId", row.StyleId, "Style") = True Then
                    StyleNameTextEdit.Properties.ReadOnly = True
                Else
                    StyleNameTextEdit.Properties.ReadOnly = False
                End If
            Else
                StyleNameTextEdit.Properties.ReadOnly = False
            End If

            If EditLinkLabel.Text = "Edit" Then

                EditLinkLabel.Text = "Update"

            Else

                If Me.StyleNameTextEdit.EditValue = String.Empty Then
                    MessageBox.Show("Style No is Require")
                    Exit Sub
                End If

                row.UserId = UserId
                row.ModifiedOn = Now()

                Me.Validate()
                Me.StyleBindingSource.EndEdit()
                Me.FRStyleProcessBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.StyleDataSet)

                NewLinkLabel.Text = "Add"
                EditLinkLabel.Text = "Edit"


                If row.IsPictureNull = False Then
                    Resizer(row.StyleId)
                End If


            End If

            End If

    End Sub

    Private Sub PicturePictureEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        PicturePictureEdit.LoadImage()

    End Sub

    Private Sub StyleDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next
    End Sub


    Private Sub StyleLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleLookupGridLookUpEdit.EditValueChanged

        Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, StyleLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        If StyleBindingSource.Position > -1 Then

            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)
            Me.StyleId = row.StyleId
            StyleIdvar = row.StyleId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub



    Private Sub StyleNameIdGridLookUpEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StyleNameIdGridLookUpEdit.KeyDown

        'MessageBox.Show("Under Construction !!!!")
        'Exit Sub


        On Error Resume Next

        If e.KeyData = Keys.F10 Then

            Dim mystring As String = StyleNameIdGridLookUpEdit.Text

            If mystring <> "" Then

                If MessageBox.Show("Are you sure you want to add?", "StyleName", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    ExecuteQuery("Insert into StyleNameMst(StyleName)values('" & mystring & "')", cnn)
                    Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)
                    StyleNameIdGridLookUpEdit.EditValue = ReadIntegerData("Select StyleNameId From StyleNameMst Where StyleName ='" & mystring & "'", cnn)

                End If


            Else

                MessageBox.Show("Type The Style Name", "Style Name")

            End If


        End If

    End Sub
    Private Sub BuyerIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerIdGridLookUpEdit.EditValueChanged
        'Me.GMDepartmentTableAdapter.FillByBuyerId(Me.GMDepartmentDataSet.GMDepartment, Me.BuyerIdGridLookUpEdit.EditValue)
       
    End Sub

    Private Sub FabricDetailsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FabricDetailsLinkLabel.LinkClicked

        If Me.StyleBindingSource.Position > -1 Then

            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

            frmStyleCapture_Fabric.StyleId = row.StyleId
            frmStyleCapture_Fabric.Show(Me)
            frmStyleCapture_Fabric.WindowState = FormWindowState.Maximized
        End If


    End Sub


    Private Sub MergeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeButton.Click

        Try

            '==========
            'Dim strm As System.IO.Stream
            'strm = OpenFileDialog1.OpenFile()
            'TextBox1.Text = OpenFileDialog1.FileName.ToString()
            'If Not (strm Is Nothing) Then
            '    'insert code to read the file data
            '    strm.Close()
            '    MessageBox.Show("file closed")
            'End If

            '==========
            Dim file1 As String = String.Empty
            Dim file2 As String = String.Empty


            If Openfile.ShowDialog = System.Windows.Forms.DialogResult.OK And Openfile.FileName <> "" Then
                file1 = Openfile.FileName

            End If

            If Openfile.ShowDialog = System.Windows.Forms.DialogResult.OK And Openfile.FileName <> "" Then
                file2 = Openfile.FileName
            End If

            If Me.StyleBindingSource.Position > -1 Then

                Dim Image1 As New Bitmap(file1)
                Dim Image2 As New Bitmap(file2)




                Dim Image3 As New Bitmap(600, 1000)

                Dim g As Graphics = Graphics.FromImage(Image3)
                g.DrawImage(Image1, New Point(0, 0))
                g.DrawImage(Image2, New Point(0, 500))
                g.Dispose()
                g = Nothing


                PicturePictureEdit.Image = Image3
                PicturePictureEdit.Refresh()



            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Function JoinImagesVert(ByVal Image1 As Bitmap, ByVal Image2 As Bitmap) As Bitmap

        Dim Result As New Bitmap(Math.Max(Image1.Width, Image2.Width), _
            Image1.Height + Image2.Height)
        Dim gResult As Graphics = Graphics.FromImage(Result)
        gResult.DrawImage(Image1, New Point(0, 0))
        gResult.DrawImage(Image2, New Point(0, Image1.Height))
        gResult.Dispose()
        gResult = Nothing

        Return Result

    End Function

    Private Sub MergePicture()



        Dim Image1 As New Bitmap("d:\1.jpg")
        Dim Image2 As New Bitmap("d:\2.jpg")

        Dim Image3 As New Bitmap(600, 1000)
        Dim g As Graphics = Graphics.FromImage(Image3)
        g.DrawImage(Image1, New Point(0, 0))
        g.DrawImage(Image2, New Point(0, 500))
        g.Dispose()
        g = Nothing

        PicturePictureEdit.EditValue = Image3



    End Sub



    Private Sub TrimDetailsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TrimDetailsLinkLabel.LinkClicked

        If Me.StyleBindingSource.Position > -1 Then

            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

            frmStyleCapture_Accessories.StyleId = row.StyleId
            frmStyleCapture_Accessories.Show(Me)
            frmStyleCapture_Accessories.WindowState = FormWindowState.Maximized

        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Capture_The_Webcam.frmCapture.Show()

        'If Capture_The_Webcam.frmCapture.DialogResult = System.Windows.Forms.DialogResult.OK Then
        ' PicturePictureEdit.Image = Capture_The_Webcam.frmCapture.MyPic

        'End If
    End Sub

    Private Sub RefreshLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RefreshLinkLabel.LinkClicked
        LoadData()

    End Sub

    Private Sub LoadData()

        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.Fill(Me.KnittingTypeDataSet.KnittingType)
        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        If UserId <> 1 Then
            Me.StyleLookupTableAdapter.FillByUserId(Me.StyleLookupDataSet.StyleLookup, UserId)
        Else
            Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        End If

        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.FRProcessTableAdapter.Fill(Me.FRProcessDataSet.FRProcess)
        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)





    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ShowMaster(frmStyleName)

        If frmStyleName.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)
            StyleNameIdGridLookUpEdit.EditValue = frmStyleName.StyleNameId
        End If

    End Sub

    Private Sub DepartmentLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        ShowMaster(frmGMDepartment)
    End Sub

    Private Sub PrintTypeLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PrintTypeLinkLabel.LinkClicked
        ShowMaster(frmPrintType)
    End Sub

    Private Sub PrintPartLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PrintPartLinkLabel.LinkClicked
        ShowMaster(frmPrintPart)
    End Sub

    Private Sub StyleNameTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleNameTextEdit.EditValueChanged

    End Sub

    Private Sub ExportLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportLinkLabel.LinkClicked
        ExportStyle()

    End Sub
    Private Sub GetProcess(ByVal SId As Integer)

        Using connection As New SqlConnection(cnn)
            Dim command As New SqlCommand("Select FRProcessId From FRProcess", connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As StyleDataSet.FRStyleProcessRow = Me.StyleDataSet.FRStyleProcess.NewRow()
                newRow.StyleId = SId
                newRow.FRProcessId = reader("FRProcessId")
                newRow.Factor = 0
                newRow.SMV = 0
                Me.StyleDataSet.FRStyleProcess.Rows.Add(newRow)

            End While

            reader.Close()

        End Using
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If FRStyleProcessBindingSource.Position = -1 Then

            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

            GetProcess(row.StyleId)
        End If
    End Sub

    Private Sub ExportStyle()
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("e:\FR_ImportFiles\PRODUCT.TXT")

        If fileExists = True Then
            My.Computer.FileSystem.RenameFile("E:\FR_ImportFiles\PRODUCT.TXT", "PRODUCT-" & Format(Now(), "ddMMyyHHmmss") & ".TXT")
        End If

        Dim fileLoc As String = "e:\FR_ImportFiles\PRODUCT.TXT"
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

            TargetFile.Write("P.CODE" & vbTab)

            Using connection As New SqlConnection(cnn)
                Dim command As New SqlCommand("Select FRNo From FRProcess", connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    TargetFile.Write("P^WC:" & reader("FRNo") & vbTab)
                    
                End While

                
                reader.Close()
            End Using

            TargetFile.Write("P.Type" & vbTab)
            TargetFile.WriteLine()

            'Writing Data
            Using connection2 As New SqlConnection(cnn)
                Dim command2 As New SqlCommand("Select StyleId,StyleName,StyleType From Style Where SynFR=0", connection2)
                command2.Connection.Open()
                command2.ExecuteNonQuery()

                Dim reader2 As SqlDataReader = command2.ExecuteReader()

                While reader2.Read()

                    TargetFile.Write(reader2("StyleName") & vbTab)
                    'For Each drv2 As DataRowView In Me.FRStyleProcessBindingSource.List
                    '    TargetFile.Write(drv2!SMV & vbTab)
                    'Next
                    Using connection3 As New SqlConnection(cnn)
                        Dim command3 As New SqlCommand("Select SMV From FRStyleProcess Where StyleId=" & reader2("StyleId").ToString, connection3)
                        command3.Connection.Open()
                        command3.ExecuteNonQuery()

                        Dim reader3 As SqlDataReader = command3.ExecuteReader()

                        While reader3.Read()

                            TargetFile.Write(reader3("SMV") & vbTab)

                        End While


                        reader3.Close()
                    End Using
                    TargetFile.Write(reader2("StyleType") & vbTab)
                    TargetFile.WriteLine()

                End While

                reader2.Close()

                TargetFile.Close()

            End Using

            ExecuteQuery("Update Style Set SynFR = 1", cnn)

        Catch
            MessageBox.Show("Error opening " & fileLoc)
        End Try
    End Sub

    Private Sub PrintPartIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPartIdGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub IsPrintCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsPrintCheckEdit.CheckedChanged, SequenceCheckEdit.CheckedChanged, SublimationCheckEdit.CheckedChanged, ForeignCheckEdit.CheckedChanged

        If IsPrintCheckEdit.Checked Then
            PrintTypeLinkLabel.Enabled = True
            PrintTypeIdGridLookUpEdit.Enabled = True
            PrintPartIdGridLookUpEdit.Enabled = True
            PrintPartLinkLabel.Enabled = True
        Else
            PrintTypeLinkLabel.Enabled = False
            PrintTypeIdGridLookUpEdit.Enabled = False
            PrintPartIdGridLookUpEdit.Enabled = False
            PrintPartLinkLabel.Enabled = False
        End If

    End Sub

    Private Sub IsWashCheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsWashCheckEdit.CheckedChanged

        If IsWashCheckEdit.Checked Then

            WashTypeIdGridLookUpEdit.Enabled = True

        Else

            WashTypeIdGridLookUpEdit.Enabled = True

        End If

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If StyleLookupGridLookUpEdit.EditValue > 0 Then

            Dim ChkDuplicate As Integer = ReadIntData("Select Count(*) From Style Where StyleName like '" & StyleNameTextEdit.Text & "Copy'", cnn)
            Dim SID As Integer = ReadIntegerData("Select StyleId From Style Where StyleName like '" & StyleNameTextEdit.Text & "Copy'", cnn)

            If ChkDuplicate = 1 Then
                StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, SID)
                Exit Sub
            End If

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("CopyStyle", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@StyleId", StyleLookupGridLookUpEdit.EditValue)

                cmd.ExecuteNonQuery()

            End Using

            Me.StyleLookupTableAdapter.FillByUserId(Me.StyleLookupDataSet.StyleLookup, UserId)

            Dim NewSID As Integer = ReadIntegerData("Select Max(StyleId) From Style Where BuyerId in (Select BuyerId From BuyerAsign Where UserId=" & UserId & ") And  DivisionId in (Select DivisionId From BuyerAsign Where UserId=" & UserId & ") And StyleName like '%Copy'", cnn)
            StyleLookupGridLookUpEdit.EditValue = NewSID
            StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, NewSID)
            MessageBox.Show("Copied Successfully.")

        End If

    End Sub
End Class
