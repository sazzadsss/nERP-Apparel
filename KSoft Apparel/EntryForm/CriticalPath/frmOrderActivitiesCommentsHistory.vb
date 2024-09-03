Public Class frmOrderActivitiesCommentsHistory

    Private _OAID As Integer
    Public Property OAID() As Integer
        Get
            Return _OAID
        End Get
        Set(ByVal value As Integer)
            _OAID = value
        End Set
    End Property


    Private Sub frmOrderActivitiesCommentsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(OAID.ToString())
        Me.OrderActivitiesCommentsTableAdapter.Fill(Me.OrderActivitiesCommentsDataSet.OrderActivitiesComments, OAID)

    End Sub

   
End Class