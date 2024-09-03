Public Class frmActivitiesPivot

    Private Sub frmActivitiesPivot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ActivitiesViewTableAdapter.Fill(Me.ActivitiesViewDataSet.ActivitiesView)

    End Sub
End Class