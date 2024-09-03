Imports DevExpress.XtraSplashScreen

Public Class LoginForm


    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Dim loc As Point
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(My.Settings.IsRemember.ToString())
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.Skins.SkinManager.EnableFormSkins()

        Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

        If CC <> "NCL" Then
            'Me.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.CompanyName256
            'Me.BackgroundImageLayout = ImageLayout.Center
            Label1.Text = "KSoft Apparel Log in "
        End If

        If My.Settings.IsRemember = "True" Then
            Me.RememberCheckBox.Checked = True
        Else
            Me.RememberCheckBox.Checked = False
        End If


        If My.Settings.IsRemember = "True" Then

            Me.Focus()
            Me.DatetimeLabel.Text = Now()
            Me.UsernameTextBox.Text = ReadStringData("Select User_Name From [User] Where User_Id=" & Val(My.Settings.UserId), cnn)
            'Me.PasswordTextBox.Text = ReadStringData("Select Password From [User] Where User_Id=" & Val(My.Settings.UserId), cnn)
            OKButton.Focus()

        Else

            Me.UsernameTextBox.Text = ""
            Me.PasswordTextBox.Text = ""
            Me.Focus()
            Me.UsernameTextBox.Focus()
            Me.DatetimeLabel.Text = Now()

        End If


    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub


    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

        Dim DepId As Integer = ReadIntegerData("Select DepartmentId As DepId From [User] Where User_Name = '" & UsernameTextBox.Text & "' And Active=1", cnn)
        Dim DepName As String = ReadStringData("Select DepartmentName From Department Where DepartmentId =" & DepId, cnn)

        DepartmentTextBox.Text = DepName

    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown

        If e.KeyData = Keys.Enter Then
            OKButton.Focus()
        End If

    End Sub



    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try

            Dim RowCount As Integer = ReadIntData("Select Count(*) From [User] Where User_Name='" & UsernameTextBox.Text & "' And Password='" & PasswordTextBox.Text & "' And Active=1", cnn)

            If RowCount = 1 Then

                UserId = ReadIntegerData("Select User_Id From [User] Where User_Name='" & UsernameTextBox.Text & "' And Password='" & PasswordTextBox.Text & "' And Active=1", cnn)
                UserName = UsernameTextBox.Text

                DepartmentId = ReadIntegerData("Select DepartmentId From [User] Where User_Id=" & UserId, cnn)

                'Creating a user session while logged in
                Dim sessionManager As New SessionManager()
                sessionManager.CreateNewSession(UserId)
                'End of Creating a user session while logged in


                'Remember 
                If RememberCheckBox.Checked = True Then
                    My.Settings.UserId = UserId.ToString
                    My.Settings.IsRemember = "True"
                    My.Settings.Save()
                Else
                    My.Settings.UserId = ""
                    My.Settings.IsRemember = "False"
                    My.Settings.Save()
                End If

                'Me.PasswordTextBox.Text = ""
                Me.Hide()
                frmMain.Show()

            ElseIf RowCount > 1 Then
                MessageBox.Show("Duplicate User has been found")
            Else
                MessageBox.Show("Wrong User Name or Password or Connection Problem," & vbNewLine & "Pls,check.", "Info..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
