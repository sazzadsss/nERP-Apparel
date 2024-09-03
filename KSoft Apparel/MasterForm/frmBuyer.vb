Imports System.IO
Imports System.Data.SqlClient

Public Class frmBuyer

    Private _BuyerId As Integer
    Public Property BuyerId() As Integer
        Get
            Return _BuyerId
        End Get
        Set(ByVal value As Integer)
            _BuyerId = value
        End Set

    End Property





    Private Sub frmBuyer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        'Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        ''TODO: This line of code loads data into the 'BuyerDataSet.BuyerAsign' table. You can move, or remove it, as needed.
        Me.BuyerAsignTableAdapter.Fill(Me.BuyerDataSet.BuyerAsign)

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        If CheckUserRights("Buyer").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Buyer").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If


    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            BuyerBindingSource.AddNew()
            BuyerDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.BuyerBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BuyerDataSet)
                BuyerDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'On Error Resume Next
        'Me.BuyerTableAdapter.FillByBuyerName(Me.BuyerDataSet.Buyer, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If BuyerBindingSource.Position > -1 Then
            BuyerBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub



    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        If EditLinkLabel.Text = "Edit" Then
            BuyerDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.BuyerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BuyerDataSet)
            BuyerDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            BuyerDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If

    End Sub


    Private Sub BuyerDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BuyerDataGridView.RowHeaderMouseDoubleClick

        If Me.BuyerBindingSource.Position > -1 Then
            Dim row As BuyerDataSet.BuyerRow
            row = CType(CType(Me.BuyerBindingSource.Current, DataRowView).Row, BuyerDataSet.BuyerRow)
            Me.BuyerId = row.BuyerId

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub ExportLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportLinkLabel.LinkClicked
        ExportBuyer()
    End Sub
    Private Sub ExportBuyer()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("E:\FR_ImportFiles\CUSTOMER.TXT")

        If fileExists = True Then
            My.Computer.FileSystem.RenameFile("E:\FR_ImportFiles\CUSTOMER.TXT", "CUSTOMER-" & Format(Now(), "ddMMyyHHmm") & ".TXT")
        End If

        Dim fileLoc As String = "E:\FR_ImportFiles\CUSTOMER.TXT"
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

            TargetFile.Write("C.CODE" & vbTab)
            TargetFile.Write("C.DESCRIPTION" & vbTab)
            TargetFile.Write("C.LATEOK" & vbTab)
            TargetFile.WriteLine()
            'Writing Data
            Using connection As New SqlConnection(cnn)
                Dim command As New SqlCommand("Select BuyerName,BuyerLateOK From Buyer Where SynFR=0", connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    TargetFile.Write(reader("BuyerName") & vbTab)
                    TargetFile.Write("" & vbTab)
                    TargetFile.Write(reader("BuyerLateOK") & vbTab)
                    TargetFile.WriteLine()

                End While

                ExecuteQuery("Update Buyer Set SynFR=1", cnn)
                BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
                reader.Close()

            End Using

            TargetFile.Close()

        Catch
            MessageBox.Show("Error opening " & fileLoc)
        End Try

    End Sub

    Private Sub BuyerBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerBindingSource.PositionChanged

        'If Me.BuyerBindingSource.Position > -1 Then
        '    Dim row As BuyerDataSet.BuyerRow
        '    row = CType(CType(Me.BuyerBindingSource.Current, DataRowView).Row, BuyerDataSet.BuyerRow)

        '    Me.DivisionTableAdapter.FillByBuyerId(Me.DivisionDataSet.Division, row.BuyerId)
        'End If
       
    End Sub
End Class




