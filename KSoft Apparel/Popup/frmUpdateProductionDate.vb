Imports System.Windows.Forms

Public Class frmUpdateProductionDate

    Private _BatchId As Integer
    Public Property BatchId() As Integer
        Get
            Return _BatchId
        End Get
        Set(ByVal value As Integer)
            _BatchId = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
       
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmUpdateProductionDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Me.CurrentDateTimePicker.Text = frmIssueDetails.ProductionDateDateTimePicker.Text
        'Me.NewDateTimePicker.Text = frmIssueDetails.ProductionDateDateTimePicker.Text

        TextBox1.Text = ReadStringData("Select BatchNo From BatchInformation Where BatchInformationId=" & Me.BatchId, cnn)
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
