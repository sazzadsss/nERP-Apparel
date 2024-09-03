Public Class frmDateTime

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub frmDateTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.LoadDateEdit.Text = DateAndTime.Today
        'Me.UnloadDateEdit.Text = DateAndTime.Today
    End Sub
End Class