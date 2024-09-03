Public Class frmActivitieView

    Private Sub frmActivitieView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)

        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)

        Me.UserTableAdapter.Fill(Me.UserDataSet.User)

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.ActivitiesListTableAdapter.Fill(Me.ActivitiesListDataSet.ActivitiesList)
        Me.ActivitiesPredecessorTableAdapter.Fill(Me.ActivitiesDataSet.ActivitiesPredecessor)
        Me.ActivitiesTableAdapter.Fill(Me.ActivitiesDataSet.Activities)

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        Me.Validate()
        Me.ActivitiesBindingSource.EndEdit()
        Me.ActivitiesPredecessorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivitiesDataSet)

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'DyeingRecipeGridControl.MainView.ExportToXls("D:\LabRecipe-" & Today() & ".xls")
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        RefreshActivitiesPredecessor()
    End Sub


    Private Sub RefreshActivitiesPredecessor()

        If Me.ActivitiesPredecessorBindingSource.Position > -1 Then

            For Each drv2 As DataRowView In Me.ActivitiesPredecessorBindingSource.List
                On Error Resume Next

                Dim row As ActivitiesDataSet.ActivitiesRow
                row = CType(CType(Me.ActivitiesBindingSource.Current, DataRowView).Row, ActivitiesDataSet.ActivitiesRow)

                'drv2!PreActivitiesId = ReadIntegerData("Select ActivitiesId,ExEDate,ASDate From Activities Where ActivitiesListId=" & drv2!PreActivitiesId, cnn)
                drv2!ExEDate = Format(row.ExEDate, "dd-MMM-yy")
                drv2!AEDate = Format(row.AEDate.Date, "dd-MMM-yy")
                drv2!Status = row.Status

                ActivitiesPredecessorBindingSource.ResetBindings(True)
            Next

        End If

    End Sub

End Class