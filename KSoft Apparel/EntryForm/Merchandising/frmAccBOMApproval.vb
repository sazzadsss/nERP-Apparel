Public Class frmAccBOMApproval

    Private Sub frmAccBOMApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DestinationTableAdapter.Fill(Me.DestinationDataSet.Destination)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.ItemListTableAdapter.Fill(Me.ItemListDataSet.ItemList)


        If CheckUserRights("Accessories BOM Approval").CanEdit = False Then

            ApprovedButton.Enabled = False
        End If

    End Sub

    Private Sub ShowDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDetailsButton.Click


        If Me.AccBOMApprovalBindingSource.Position > -1 Then

            Dim row As AccBOMApprovalDataSet.AccBOMApprovalRow
            row = CType(CType(Me.AccBOMApprovalBindingSource.Current, DataRowView).Row, AccBOMApprovalDataSet.AccBOMApprovalRow)

            Me.AccessoresBookingDetailsTableAdapter.FillByAccBOMIdAndCompleted(Me.AccessoriesBookingNewDataSet.AccessoresBookingDetails, row.AccessoriesBookingId)
            ApprovedButton.Enabled = True

        End If



    End Sub

    Private Sub PendingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingButton.Click
        Me.AccBOMApprovalTableAdapter.FillByPending(Me.AccBOMApprovalDataSet.AccBOMApproval)
    End Sub

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
        Me.AccBOMApprovalTableAdapter.Fill(Me.AccBOMApprovalDataSet.AccBOMApproval)
    End Sub

    Private Sub ApprovedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovedButton.Click

        Try

            Me.AccessoresBookingDetailsBindingSource.MoveFirst()

            Dim count As Integer = 0

            For count = 0 To Me.AccessoresBookingDetailsBindingSource.Count - 1

                Dim row As AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow
                row = CType(CType(Me.AccessoresBookingDetailsBindingSource.Current, DataRowView).Row, AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow)

                If row.IsSelected = True Then
                    row.IsApproved = True
                    row.ApprovedOn = Today()
                End If

                AccessoresBookingDetailsBindingSource.MoveNext()
            Next

            Me.AccessoresBookingDetailsTableAdapter.Update(AccessoriesBookingNewDataSet.AccessoresBookingDetails)
            MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SelectSimpleButton_Click(sender As Object, e As EventArgs) Handles SelectSimpleButton.Click

        If SelectSimpleButton.Text = "&Select All" Then


            Me.AccessoresBookingDetailsBindingSource.MoveFirst()

            Dim count As Integer = 0

            For count = 0 To Me.AccessoresBookingDetailsBindingSource.Count - 1

                Dim row As AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow
                row = CType(CType(Me.AccessoresBookingDetailsBindingSource.Current, DataRowView).Row, AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow)

                row.IsSelected = True

                AccessoresBookingDetailsBindingSource.MoveNext()
            Next


            SelectSimpleButton.Text = "&Deselect All"

        Else

            Me.AccessoresBookingDetailsBindingSource.MoveFirst()

            Dim count As Integer = 0

            For count = 0 To Me.AccessoresBookingDetailsBindingSource.Count - 1

                Dim row As AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow
                row = CType(CType(Me.AccessoresBookingDetailsBindingSource.Current, DataRowView).Row, AccessoriesBookingNewDataSet.AccessoresBookingDetailsRow)

                row.IsSelected = True

                AccessoresBookingDetailsBindingSource.MoveNext()
            Next

            SelectSimpleButton.Text = "&Select All"

        End If



    End Sub

    Private Sub ShowApprovedButton_Click(sender As Object, e As EventArgs) Handles ShowApprovedButton.Click
        Me.AccBOMApprovalTableAdapter.FillByApproved(Me.AccBOMApprovalDataSet.AccBOMApproval)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.AccBOMApprovalBindingSource.Position > -1 Then

            Dim row As AccBOMApprovalDataSet.AccBOMApprovalRow
            row = CType(CType(Me.AccBOMApprovalBindingSource.Current, DataRowView).Row, AccBOMApprovalDataSet.AccBOMApprovalRow)

            Me.AccessoresBookingDetailsTableAdapter.FillByAccBookingId(Me.AccessoriesBookingNewDataSet.AccessoresBookingDetails, row.AccessoriesBookingId)
            ApprovedButton.Enabled = False

        End If

    End Sub
End Class