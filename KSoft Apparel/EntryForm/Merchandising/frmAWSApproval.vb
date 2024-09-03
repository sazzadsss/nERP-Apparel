Public Class frmAWSApproval

    Private Sub AccessoriesWorkOrderSheetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.AccessoriesWorkOrderSheetBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AWS_DataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub frmAWSApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.AccBookingLookupTableAdapter.Fill(Me.AccBOMLookUpDataSet.AccBookingLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.AccessoriesWorkOrderSheetTableAdapter.FillByIsApproved(Me.AWS_DataSet.AccessoriesWorkOrderSheet, False)


        AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Enabled = CheckUserRights("AWS Approval").CanEdit


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.AccessoriesWorkOrderSheetTableAdapter.FillByIsApproved(Me.AWS_DataSet.AccessoriesWorkOrderSheet, True)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Me.AccessoriesWorkOrderSheetTableAdapter.FillByIsApproved(Me.AWS_DataSet.AccessoriesWorkOrderSheet, False)

    End Sub


    Private Sub ApprovedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovedButton.Click

        If Me.AccessoriesWorkOrderSheetBindingSource.Position > -1 Then

            Dim row As AWS_DataSet.AccessoriesWorkOrderSheetRow
            row = CType(CType(Me.AccessoriesWorkOrderSheetBindingSource.Current, DataRowView).Row, AWS_DataSet.AccessoriesWorkOrderSheetRow)

            row.IsApproved = True
            row.IsCancel = False
            row.ApprovedBy = UserId


            row.ApprovedOn = Today()

        End If
      

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWSCancelButton.Click

        If Me.AccessoriesWorkOrderSheetBindingSource.Position > -1 Then

            Dim row As AWS_DataSet.AccessoriesWorkOrderSheetRow
            row = CType(CType(Me.AccessoriesWorkOrderSheetBindingSource.Current, DataRowView).Row, AWS_DataSet.AccessoriesWorkOrderSheetRow)


            row.IsApproved = False
            row.IsCancel = True

            row.CauseOfCancel = CauseofRemrksTextBox.Text

        End If

    End Sub

    Private Sub ShowAWSToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAWSToolStripButton.Click

        If Me.AccessoriesWorkOrderSheetBindingSource.Position > -1 Then

            Dim row As AWS_DataSet.AccessoriesWorkOrderSheetRow
            row = CType(CType(Me.AccessoriesWorkOrderSheetBindingSource.Current, DataRowView).Row, AWS_DataSet.AccessoriesWorkOrderSheetRow)

            frmAccessoriesWorkOrderSheetPrint.AWSId = row.AWSId

            ShowForm(frmAccessoriesWorkOrderSheetPrint)

        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Me.AccessoriesWorkOrderSheetTableAdapter.FillByIsCancel(Me.AWS_DataSet.AccessoriesWorkOrderSheet, True)

    End Sub

    Private Sub AccessoriesWorkOrderSheetBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesWorkOrderSheetBindingSource.PositionChanged

       
      
    End Sub

    Private Sub ShowProgramToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProgramToolStripButton.Click

        If Me.AccessoriesWorkOrderSheetBindingSource.Position > -1 Then



            Dim row As AWS_DataSet.AccessoriesWorkOrderSheetRow
            row = CType(CType(Me.AccessoriesWorkOrderSheetBindingSource.Current, DataRowView).Row, AWS_DataSet.AccessoriesWorkOrderSheetRow)

            Me.ProgramLookupAWSTableAdapter.Fill(Me.AWS_DataSet.ProgramLookupAWS, row.AWSId)


        End If

    End Sub
End Class