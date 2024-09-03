Imports System.IO

Public Class frmMasterOrderStatus

    Private Sub frmMasterOrderStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.AsignedForGridLookUpEdit.EditValue = UserId
        Me.MasterOrderStatusTableAdapter.FillByMerchandiser(Me.MasterOrderStatusDataSet.MasterOrderStatus, AsignedForGridLookUpEdit.Text)


    End Sub


    Private Sub ShowByMerchandiserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByMerchandiserButton.Click
        Me.MasterOrderStatusTableAdapter.FillByMerchandiser(Me.MasterOrderStatusDataSet.MasterOrderStatus, AsignedForGridLookUpEdit.Text)
    End Sub

    Private Sub ShowByBuyerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByBuyerButton.Click
        Me.MasterOrderStatusTableAdapter.FillByBuyer(Me.MasterOrderStatusDataSet.MasterOrderStatus, BuyerComboBox.Text)
    End Sub

    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click

        If UserId > 0 Then

            Dim di As DirectoryInfo = New DirectoryInfo("C:\Master Order Status")

            If Not di.Exists Then
                di.Create()
            End If

            Dim FileToDelete As String

            Dim UName As String = ReadStringData("Select User_Name From [User] Where User_Id=" & UserId, cnn)

            FileToDelete = "C:\Master Order Status\Master Order Status.xlsx"

            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
                'MsgBox("File Deleted")

            End If



            Me.MasterOrderStatusGridControl.ExportToXlsx("C:\Master Order Status\Master Order Status.xlsx")

            Dim BodyMessage As String = "Dear Mr. " & UName & "," & vbNewLine & _
            "Please,find the enclosed file for the Master Order Status." & vbNewLine & vbNewLine & _
            "Note : This is  an auto generated mail from KSoft Apparel Solutions "
            Dim EmailAddress As String = ReadStringData("Select EmailAddress From [User] Where User_Id=" & UserId, cnn)

            If EmailAddress <> String.Empty Then

                SendSMTP("support@ksoftslns.com", "KSoft Apparel Solutions", EmailAddress, UName.ToUpper(), "", "", "Master Order Status", BodyMessage.ToString(), "", "C:\Master Order Status\Master Order Status.xlsx")

            End If

        End If

    End Sub

    Private Sub AllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllButton.Click
        Me.MasterOrderStatusTableAdapter.FillByAll(Me.MasterOrderStatusDataSet.MasterOrderStatus)
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
    End Sub

    Private Sub SearchTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchTextBox.KeyDown

        If e.KeyData = Keys.Enter Then
            LoadingLabel.Text = "Loading..."
            Me.MasterOrderStatusTableAdapter.FillByProgramAndStyle(Me.MasterOrderStatusDataSet.MasterOrderStatus, SearchTextBox.Text)
            LoadingLabel.Text = ""
        End If

    End Sub

    Private Sub RunningButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningButton.Click

        

        Me.MasterOrderStatusTableAdapter.FillByRunning(Me.MasterOrderStatusDataSet.MasterOrderStatus)


    End Sub

    Private Sub SaveLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SaveLinkLabel.LinkClicked
        Try
            For Each drv As DataRowView In Me.MasterOrderStatusBindingSource.List
                If DBNull.Value.Equals(drv!IsCuttingRunning) <> True Then
                    If drv!IsCuttingRunning = True Then
                        ExecuteQuery("Update [Order] Set IsCuttingRunning=1  Where ProgramNo='" & drv!ProgramNo & "'", cnn)
                    ElseIf drv!IsCuttingRunning = False Then
                        ExecuteQuery("Update [Order] Set IsCuttingRunning=0  Where ProgramNo='" & drv!ProgramNo & "'", cnn)
                    End If

                End If

            Next

            MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
End Class