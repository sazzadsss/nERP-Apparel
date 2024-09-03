Imports System.Windows.Forms

Public Class frmInchCalculator
    Private _TTLInch As Integer
    Public Property TTLInch() As Integer
        Get
            Return _TTLInch
        End Get
        Set(ByVal value As Integer)
            _TTLInch = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        _TTLInch = TotalInchTextBox.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        _TTLInch = 0
        Me.Close()
    End Sub

    Private Sub YardTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YardTextBox.TextChanged
        On Error Resume Next
        TotalInchTextBox.Text = YardTextBox.Text * 36 + InchTextBox.Text

    End Sub

    Private Sub InchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InchTextBox.TextChanged
        On Error Resume Next
        TotalInchTextBox.Text = YardTextBox.Text * 36 + InchTextBox.Text

    End Sub
End Class
