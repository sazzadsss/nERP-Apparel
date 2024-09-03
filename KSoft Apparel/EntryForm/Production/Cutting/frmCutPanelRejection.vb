Public Class frmCutPanelRejection

    Private Sub CuttingCutPanelRejectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingCutPanelRejectionBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub frmCutPanelRejection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)


        If CheckUserRights("Cut Panel Rejection").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            CuttingCutPanelRejectionBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged

        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.EditValue)

    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged

        With Me.CutPanelRejectionDataSet.CuttingCutPanelRejection
            .OrderIdColumn.DefaultValue = Me.OrderNoGridLookUpEdit.EditValue
            .FabricColorIdColumn.DefaultValue = Me.FabricColorComboBox.SelectedValue
        End With

        Me.CuttingCutPanelRejectionTableAdapter.FillByOrderId(Me.CutPanelRejectionDataSet.CuttingCutPanelRejection, Me.OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        'PIN HOLE/ KNT. HOLE/NDL MARK [KNITTING]
        'FOREIGN YARN /CONTRA [KNITTING]
        'YARN LYCRA/MISSING [KNITTING]
        'SLAB/LOOP/KNOT [KNITTING]
        'OTHERS([KNITTING])
        'GSM HOLE/ROOL JOINT [DYEING]
        'DYE/CHEM SPOT [DYEING]
        'LINE/CRASE/DIA MARK [DYEING]
        'UNEVEN DIA [DYEING]
        'OTHERS([DYEING])
        'WRONG SHAPE [CUTTING]
        'MARKER PROBLEM [CAD]
        'Print([RPINT])

        If e.Column.Caption = "Rejection Type" Then

            If e.Value.ToString <> "" Then

                Dim Category As String = String.Empty

                If e.Value.ToString = "PIN HOLE/ KNT. HOLE/NDL MARK [KNITTING]" Then
                    Category = "Knitting"
                ElseIf e.Value.ToString = "FOREIGN YARN /CONTRA [KNITTING]" Then
                    Category = "Knitting"
                ElseIf e.Value.ToString = "YARN LYCRA/MISSING [KNITTING]" Then
                    Category = "Knitting"
                ElseIf e.Value.ToString = "SLAB/LOOP/KNOT [KNITTING]" Then
                    Category = "Knitting"
                ElseIf e.Value.ToString = "OTHERS([KNITTING])" Then
                    Category = "Knitting"
                ElseIf e.Value.ToString = "GSM HOLE/ROOL JOINT [DYEING]" Then
                    Category = "Dyeing"
                ElseIf e.Value.ToString = "DYE/CHEM SPOT [DYEING]" Then
                    Category = "Dyeing"
                ElseIf e.Value.ToString = "LINE/CRASE/DIA MARK [DYEING]" Then
                    Category = "Dyeing"
                ElseIf e.Value.ToString = "UNEVEN DIA [DYEING]" Then
                    Category = "Dyeing"
                ElseIf e.Value.ToString = "OTHERS([DYEING])" Then
                    Category = "Dyeing"
                ElseIf e.Value.ToString = "WRONG SHAPE [CUTTING]" Then
                    Category = "Cutting"
                ElseIf e.Value.ToString = "MARKER PROBLEM [CAD]" Then
                    Category = "CAD"
                ElseIf e.Value.ToString = "Print([RPINT])" Then
                    Category = "Print"
                End If


                'Dim YarnPrice As Decimal = ReadData("Select CurrentPrice From ItemList Where ItemId=" & CInt(e.Value.ToString), cnn)
                GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("RejectionCategory"), Category)


                'MessageBox.Show(Category.ToString)


            End If


        End If
    End Sub

    Private Sub frmCutPanelRejection_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F12 Then

            Save()
        ElseIf e.KeyData = Keys.F3 Then
            Me.CuttingCutPanelRejectionBindingSource.AddNew()

        End If

    End Sub

    Private Sub Save()
        Try

            Me.Validate()
            Me.CuttingCutPanelRejectionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CutPanelRejectionDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        
    End Sub
       

   
End Class