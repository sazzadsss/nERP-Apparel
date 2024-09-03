Public Class frmApproveSheet

    Private Sub FabricBOMApproveSheetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBOMApproveSheetBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.FabricBOMApproveSheetBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ApproveSheetDataSet)

            Me.FabricBOMApproveSheetTableAdapter.Fill(Me.ApproveSheetDataSet.FabricBOMApproveSheet, UserId)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        

    End Sub


    Private Sub frmApproveSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricBOMIdSearchTableAdapter.Fill(Me.FabricBOMIdSearchDataSet.FabricBOMIdSearch)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)


        Try

            Me.FabricBOMApproveSheetTableAdapter.Fill(Me.ApproveSheetDataSet.FabricBOMApproveSheet, New System.Nullable(Of Long)(CType(UserId, Long)))

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try


        Dim SSL As Integer = ReadIntegerData("Select SignatureSL From Signature Where Interface='FabricBOM' And UserId=" & UserId, cnn)

        If SSL = 1 Then

            colSignature1.OptionsColumn.ReadOnly = False
            colSignature2.OptionsColumn.ReadOnly = True
            colSignature3.OptionsColumn.ReadOnly = True
            colSignature4.OptionsColumn.ReadOnly = True

            colSignature1.OptionsColumn.AllowEdit = True
            colSignature2.OptionsColumn.AllowEdit = False
            colSignature3.OptionsColumn.AllowEdit = False
            colSignature4.OptionsColumn.AllowEdit = False


        ElseIf SSL = 2 Then

            colSignature1.OptionsColumn.ReadOnly = True
            colSignature2.OptionsColumn.ReadOnly = False
            colSignature3.OptionsColumn.ReadOnly = True
            colSignature4.OptionsColumn.ReadOnly = True


            colSignature1.OptionsColumn.AllowEdit = False
            colSignature2.OptionsColumn.AllowEdit = True
            colSignature3.OptionsColumn.AllowEdit = False
            colSignature4.OptionsColumn.AllowEdit = False

        ElseIf SSL = 3 Then

            colSignature1.OptionsColumn.ReadOnly = True
            colSignature2.OptionsColumn.ReadOnly = True
            colSignature3.OptionsColumn.ReadOnly = False
            colSignature4.OptionsColumn.ReadOnly = True

            colSignature1.OptionsColumn.AllowEdit = False
            colSignature2.OptionsColumn.AllowEdit = False
            colSignature3.OptionsColumn.AllowEdit = True
            colSignature4.OptionsColumn.AllowEdit = False


        ElseIf SSL = 4 Then

            colSignature1.OptionsColumn.ReadOnly = True
            colSignature2.OptionsColumn.ReadOnly = True
            colSignature3.OptionsColumn.ReadOnly = True
            colSignature4.OptionsColumn.ReadOnly = False

            colSignature1.OptionsColumn.AllowEdit = False
            colSignature2.OptionsColumn.AllowEdit = False
            colSignature3.OptionsColumn.AllowEdit = False
            colSignature4.OptionsColumn.AllowEdit = True

        Else

            colSignature1.OptionsColumn.ReadOnly = True
            colSignature2.OptionsColumn.ReadOnly = True
            colSignature3.OptionsColumn.ReadOnly = True
            colSignature4.OptionsColumn.ReadOnly = True

            colSignature1.OptionsColumn.AllowEdit = False
            colSignature2.OptionsColumn.AllowEdit = False
            colSignature3.OptionsColumn.AllowEdit = False
            colSignature4.OptionsColumn.AllowEdit = False

        End If

        If CheckUserRights("Approve Sheet").CanEdit = False Then


            FabricBOMApproveSheetBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Approve Sheet").CanDelete = False Then

            FabricBOMApproveSheetBindingNavigatorSaveItem.Enabled = True
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        Dim row As ApproveSheetDataSet.FabricBOMApproveSheetRow
        row = CType(CType(Me.FabricBOMApproveSheetBindingSource.Current, DataRowView).Row, ApproveSheetDataSet.FabricBOMApproveSheetRow)


        If e.Column.Caption = "CAD Manager" Then

            If row.IsSignature1Null = False Then
                row.Signature1Date = ReadDateData("Select GetDate()", cnn)
            End If


        ElseIf e.Column.Caption = "Merchandiser/S. Merchandiser" Then

            If row.IsSignature2Null = False Then
                row.Signature2Date = ReadDateData("Select GetDate()", cnn)
            End If


        ElseIf e.Column.Caption = "M. Manager" Then
            If row.IsSignature3Null = False Then
                row.Signature3Date = ReadDateData("Select GetDate()", cnn)
            End If


        ElseIf e.Column.Caption = "Approved By" Then

            If row.IsSignature4Null = False Then
                row.Signature4Date = ReadDateData("Select GetDate()", cnn)
            End If


        End If


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If Me.FabricBOMApproveSheetBindingSource.Position > -1 Then


            Dim row As ApproveSheetDataSet.FabricBOMApproveSheetRow
            row = CType(CType(Me.FabricBOMApproveSheetBindingSource.Current, DataRowView).Row, ApproveSheetDataSet.FabricBOMApproveSheetRow)



            With frmFabricConsumptionPrint

                .MdiParent = frmMain
                .FabricBOMId = row.FabricBOMId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If


    End Sub
End Class