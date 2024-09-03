Imports System.Windows.Forms

Public Class frmChangePassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim PrePass As String = Trim(ReadStringData("Select Password From [User] Where User_Id=" & UserId, cnn))

        If PrePass = Trim(UserPassTextBox.Text).ToString() Then

            ExecuteQuery("Update [User] Set Password= '" & Trim(NewPassTextBox.Text) & "' Where User_Id=" & UserId, cnn)
            MessageBox.Show("Password has been changed Successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else

            MessageBox.Show("OLD Password doesn't match", "Not Match", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If




    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserNameTextBox.Text = ReadStringData("Select User_Name From [User] Where User_Id=" & UserId, cnn)
       
    End Sub
End Class
