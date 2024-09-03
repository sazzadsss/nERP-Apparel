Imports System.Data.SqlClient
Imports System.IO

Public Class frmOrderActivities

    Private Sub frmOrderActivities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.ActivitiesListTableAdapter.Fill(Me.ActivitiesListDataSet.ActivitiesList)
        Me.OrderActivitiesTableAdapter.Fill(Me.OrderActivitiesDataSet.OrderActivities)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        'Me.SplitContainer3.Panel1Collapsed = True
        'Me.SplitContainer2.Panel1Collapsed = True
        Me.SplitContainer1.Panel2Collapsed = True

        Me.FromDateEdit.EditValue = Today.Date
        Me.ToDateEdit.EditValue = Today.Date

    End Sub



    Private Sub SendMailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMailButton.Click


        If UserId > 0 Then

            Dim di As DirectoryInfo = New DirectoryInfo("c:\Pending Activities")

            If Not di.Exists Then
                di.Create()
            End If

            Dim FileToDelete As String

            Dim UName As String = ReadStringData("Select User_Name From [User] Where User_Id=" & UserId, cnn)

            FileToDelete = "c:\Pending Activities\Activities Pending List For " & UName & ".xlsx"

            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
                'MsgBox("File Deleted")

            End If



            Me.GridView1.ExportToXlsx("c:\Pending Activities\Activities Pending List For " & UName & ".xlsx")

            Dim BodyMessage As String = "Dear Mr. " & UName & "," & vbNewLine &
            "Please,find the enclosed file for the pending activities list." & vbNewLine & vbNewLine &
            "Note : This is  an auto generated mail from " & SCName

            Dim EmailAddress As String = ReadStringData("Select EmailAddress From [User] Where User_Id=" & UserId, cnn)

            If EmailAddress <> String.Empty Then

                SendSMTP("sazzad@norbangroup.com", SCName , EmailAddress, UName.ToUpper(), "", "", "Actiities Pending List", BodyMessage.ToString(), "", "c:\Pending Activities\Activities Pending List For " & UName & ".xlsx")

            End If

        End If



    End Sub

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
        Me.OrderActivitiesViewTableAdapter.Fill(Me.OrderActivitiesViewDataSet.OrderActivitiesView)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If Me.AsignedForCheckBox.Checked Then
            Me.OrderActivitiesViewTableAdapter.FillByStartDateAndUser(Me.OrderActivitiesViewDataSet.OrderActivitiesView, FromDateEdit.DateTime.Date, AsignedForGridLookUpEdit.EditValue, ToDateEdit.DateTime.Date)
            'SplitContainer3.Panel1Collapsed = True
        Else
            Me.OrderActivitiesViewTableAdapter.FillByStartDate(Me.OrderActivitiesViewDataSet.OrderActivitiesView, FromDateEdit.DateTime.Date, ToDateEdit.DateTime.Date)

        End If

    End Sub
    Private Sub AutoMailing()
        'Using connection As New SqlConnection(cnn)

        '    Dim command As New SqlCommand("Select Distinct USER_ID,USER_NAME From OrderActivitiesView Where USER_ID=" & UserId, connection)
        '    command.Connection.Open()
        '    command.ExecuteNonQuery()

        '    Dim reader As SqlDataReader = command.ExecuteReader()

        '    While reader.Read()

        '        Me.OrderActivitiesViewBindingSource.Filter = "USER_ID=" & reader("USER_ID")

        '        Me.GridView1.ExportToXlsx("E:\Pending Activities\Activities Pending List For " & reader("USER_NAME") & ".xlsx")

        '        Dim BodyMessage As String = "Dear Mr. " & reader("USER_NAME") & vbNewLine & "," & _
        '        "Please,find the enclosed file for your pending activities list." & vbNewLine & _
        '        "Note : This is an auto generated mail from KSoft Apparel Solutions."

        '        SendSMTP("support@ksoftslns.com", "KSoft Apparel Solutions", "ksoftslns@gmail.com", "KSoft Solutions", "", "", "Actiities Pending List", "123", "", "E:\Pending Activities\Activities Pending List For " & reader("USER_NAME") & ".xlsx")

        '    End While

        '    reader.Close()

        'End Using
    End Sub


    Private Sub EditHyperLinkEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditHyperLinkEdit.Click

        Dim row As OrderActivitiesViewDataSet.OrderActivitiesViewRow
        row = CType(CType(Me.OrderActivitiesViewBindingSource.Current, DataRowView).Row, OrderActivitiesViewDataSet.OrderActivitiesViewRow)
        If row.USER_ID = UserId Then
            Me.OrderActivitiesTableAdapter.FillByOrActityNoAndUser(Me.OrderActivitiesDataSet.OrderActivities, row.OrderActivitiesId, UserId)
            SplitContainer2.Panel1Collapsed = False

            If row.TaskComplete = True Then
                TaskCompleteCheckBox.Enabled = False
            Else
                TaskCompleteCheckBox.Enabled = True
            End If

        Else
            MessageBox.Show("You have no rights to update this activities", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub

    Private Sub HideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideButton.Click
        SplitContainer2.Panel1Collapsed = True
    End Sub


    Private Sub Save()
        Try
            Me.Validate()
            Me.OrderActivitiesBindingSource.EndEdit()
            Me.OrderActivitiesTableAdapter.Update(OrderActivitiesDataSet.OrderActivities)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        
        If Me.OrderActivitiesBindingSource.Position > -1 Then

            Dim row As OrderActivitiesDataSet.OrderActivitiesRow
            row = CType(CType(Me.OrderActivitiesBindingSource.Current, DataRowView).Row, OrderActivitiesDataSet.OrderActivitiesRow)

            If row.Duration < 2 Then
                StartDateDateEdit.EditValue = Today.Date
                EndDateDateEdit.EditValue = Today.Date
            Else
                EndDateDateEdit.EditValue = Today.Date
            End If

            TaskCompleteCheckBox.Enabled = False

            'Adding Comments

            If TaskCommentsTextBox.Text <> String.Empty Then

                Dim flag As Integer = ReadIntData("Select Count(*) From OrderActivitiesComments Where Comments='" & row.TaskComments & "'", cnn)

                If flag = 0 Then

                    ExecuteQuery("Insert into OrderActivitiesComments(OrderActivitiesId,CommentsDate,Comments) values(" & row.OrderActivitiesId & ",'" & Today.Date & "','" & TaskCommentsTextBox.Text & "')", cnn)

                End If

            End If


        End If

        Save()

    End Sub

    Private Sub OrderActivitiesViewBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderActivitiesViewBindingSource.PositionChanged
        On Error Resume Next
        Dim row As OrderActivitiesViewDataSet.OrderActivitiesViewRow
        row = CType(CType(Me.OrderActivitiesViewBindingSource.Current, DataRowView).Row, OrderActivitiesViewDataSet.OrderActivitiesViewRow)
        Me.OrderActivitiesPredecessorViewTableAdapter.FillByOrderActivitiesId(Me.OrderActivitiesViewDataSet.OrderActivitiesPredecessorView, row.OrderActivitiesId)

    End Sub

    Private Sub ShowByPOButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByPOButton.Click


        If Me.OrderLookupGridLookUpEdit.Text <> String.Empty Then
            Me.OrderActivitiesViewTableAdapter.FillByOrderId(Me.OrderActivitiesViewDataSet.OrderActivitiesView, OrderLookupGridLookUpEdit.EditValue)
        Else
            MessageBox.Show("Please, select program no.")
            Exit Sub
        End If



    End Sub


    Private Sub TaskCommentsHyperLinkEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskCommentsHyperLinkEdit.Click

        Dim row As OrderActivitiesViewDataSet.OrderActivitiesViewRow
        row = CType(CType(Me.OrderActivitiesViewBindingSource.Current, DataRowView).Row, OrderActivitiesViewDataSet.OrderActivitiesViewRow)

        'MessageBox.Show(row.OrderActivitiesId.ToString())
        frmOrderActivitiesCommentsHistory.OAID = row.OrderActivitiesId
        ShowMaster(frmOrderActivitiesCommentsHistory)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub



    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Me.PrintableComponentLink1.CreateDocument()
        Me.PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub ShowPivotButton_Click(sender As Object, e As EventArgs) Handles ShowPivotButton.Click

        If Me.ShowPivotButton.Text = "Show Pivot" Then

            Me.ShowPivotButton.Text = "Hide Pivot"
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            'SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

        Else

            Me.ShowPivotButton.Text = "Show Pivot"
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
            'SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both

        End If

    End Sub

    Private Sub PivotGridControl1_Click(sender As Object, e As EventArgs) Handles PivotGridControl1.Click

    End Sub
End Class