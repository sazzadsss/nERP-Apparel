Imports System.Deployment.Application

Public Class frmSplash
    Public ReadOnly Property AssemblyVersion() As Version
        Get
            Return ApplicationDeployment.CurrentDeployment.CurrentVersion
        End Get
    End Property

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.Skins.SkinManager.EnableFormSkins()

        Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

        If CC <> "NCL" Then
            'Me.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.CompanyName256
            'Me.BackgroundImageLayout = ImageLayout.Center
            PictureBox3.Image = Global.KSoft_Apparel.My.Resources.Resources.CompanyName256
            Label2.Text = "KSoft Apparel"
        End If



        If (ApplicationDeployment.IsNetworkDeployed) Then
            'Version.Text = "Version {0}.{1}.{2}.{3}"
            Version.Text = "Version " + AssemblyVersion.Major.ToString() + "." + AssemblyVersion.Minor.ToString() + "." + AssemblyVersion.Build.ToString() + "." + AssemblyVersion.Revision.ToString()
        Else
            Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Revision)
        End If
        Copyright.Text = My.Application.Info.Copyright
        'InstallUpdateSyncWithInfo()

    End Sub


End Class