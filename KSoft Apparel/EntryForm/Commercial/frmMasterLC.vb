Public Class frmMasterLC
    Dim Addflag As Boolean = False

    Private Sub MasterLCBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub frmMasterLC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BankAccountTableAdapter.Fill(Me.BankAccountDataSet.BankAccount)

        Me.PackingCreditTableAdapter.Fill(Me.MasterLCDataSet.PackingCredit)

        Me.B2BLookupTableAdapter.Fill(Me.B2BLookupDataSet.B2BLookup)

       
        ExecuteQuery("Exec UpdateMasterLCAll", cnn)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.TTMasterTableAdapter.Fill(Me.MasterLCDataSet.TTMaster)
        Me.ExportBillTableAdapter.Fill(Me.MasterLCDataSet.ExportBill)
        Me.BTBLCTableAdapter.Fill(Me.MasterLCDataSet.BTBLC)
        Me.MasterLCTableAdapter.Fill(Me.MasterLCDataSet.MasterLC)
        Me.MasterLCLookupTableAdapter.Fill(Me.MasterLCDataSet.MasterLCLookup)
        Me.Buyer2TableAdapter.Fill(Me.Buyer2DataSet.Buyer2)

        If CheckUserRights("Master LC").CanEdit = False Then

            AddButton.Enabled = False
            SaveButton.Enabled = False

        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)

        If Me.MasterLCBindingSource.Position > -1 Then

            Dim row As MasterLCDataSet.MasterLCRow
            row = CType(CType(Me.MasterLCBindingSource.Current, DataRowView).Row, MasterLCDataSet.MasterLCRow)


            If e.Column.Caption = "FA Commission Percentage" Then
                row.FACommission = row.MLCValue * (row.FACommissionPercentage / 100)
            ElseIf e.Column.Caption = "FA Commission Percentage" Then
                row.LACommission = row.MLCValue * (row.LACommissionPercentage / 100)
            End If

        End If


    End Sub

   

    Private Sub GridView3_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged

        Dim row As MasterLCDataSet.BTBLCRow
        row = CType(CType(Me.BTBLCBindingSource.Current, DataRowView).Row, MasterLCDataSet.BTBLCRow)

        If e.Column.Caption = "Dollar Rate" Then

          

            If row.IsDollarRateNull Then
                Exit Sub
            End If

            If row.DollarRate > 0 AndAlso row.AmountBDT > 0 Then

                row.AmountUSD = row.AmountBDT / row.DollarRate

            End If

        ElseIf e.Column.Caption = "Amount BDT" Then

            If row.IsDollarRateNull Then
                Exit Sub
            End If

            If row.DollarRate > 0 AndAlso row.AmountBDT > 0 Then

                row.AmountUSD = row.AmountBDT / row.DollarRate

            End If


        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Try

            Me.Validate()
            Me.MasterLCBindingSource.EndEdit()
            Me.BTBLCBindingSource.EndEdit()
            Me.TTMasterBindingSource.EndEdit()
            Me.ExportBillBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MasterLCDataSet)

            If Addflag = True Then

                Me.MasterLCLookupTableAdapter.Fill(Me.MasterLCDataSet.MasterLCLookup)

                Dim row As MasterLCDataSet.MasterLCRow
                row = CType(CType(Me.MasterLCBindingSource.Current, DataRowView).Row, MasterLCDataSet.MasterLCRow)

                GridLookUpEdit1.EditValue = row.MLCId
                Me.Addflag = False

            End If
          
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click

        ExecuteQuery("Exec UpdateMasterLCAll", cnn)
        Me.MasterLCTableAdapter.Fill(Me.MasterLCDataSet.MasterLC)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If Me.GridLookUpEdit1.EditValue > -1 Then

            ExecuteQuery("Exec UpdateMasterLC " & GridLookUpEdit1.EditValue, cnn)
            Me.MasterLCTableAdapter.FillByMLCId(Me.MasterLCDataSet.MasterLC, GridLookUpEdit1.EditValue)

        End If
        

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Me.MasterLCTableAdapter.FillByMLCId(Me.MasterLCDataSet.MasterLC, 0)
        Me.MasterLCBindingSource.AddNew()
        Addflag = True


    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.Buyer2TableAdapter.Fill(Me.Buyer2DataSet.Buyer2)
    End Sub

    Private Sub ShowByButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByButton.Click
        Me.MasterLCTableAdapter.FillByBTBLCId(Me.MasterLCDataSet.MasterLC, Me.GridLookUpEdit2.EditValue)
    End Sub
End Class