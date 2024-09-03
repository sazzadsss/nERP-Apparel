Public Class frmCuttingMaking

    Private Sub CuttingMakingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.CuttingMakingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CuttingMakingDataSet)

    End Sub

    Private Sub frmCuttingMaking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)

        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        'Me.CM_FirstLayoutTableAdapter.Fill(Me.CuttingMakingDataSet.CM_FirstLayout, StyleLookupGridLookUpEdit.EditValue)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.CuttingMakingTableAdapter.Fill(Me.CuttingMakingDataSet.CuttingMaking)

        MessageLabel.Text = ""

        If CheckUserRights("Stylewise CM").CanEdit = False Then

            SaveButton.Enabled = False
        End If

    End Sub

   
   
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked

        If NewLinkLabel.Text = "Add" Then

            CuttingMakingBindingSource.AddNew()
            'AccessoriesListDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"


        Else

            Try
                Me.Validate()
                Me.CuttingMakingBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CuttingMakingDataSet)
                'AccessoriesListDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked

        If EditLinkLabel.Text = "Edit" Then
            'AccessoriesListDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.CuttingMakingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingMakingDataSet)
            'AccessoriesListDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            'AccessoriesListDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"

        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked

        'Me.CuttingMakingTableAdapter.FillByStyleId(Me.CuttingMakingDataSet.CuttingMaking, StyleIdGridLookUpEdit.EditValue)

        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"

    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If CuttingMakingBindingSource.Position > -1 Then

            MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If CType(DialogResult.Yes, Boolean) = True Then
                CuttingMakingBindingSource.RemoveCurrent()
                NewLinkLabel.Text = "Save"
            End If

        End If
    End Sub

    Private Sub CuttingMakingBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingMakingBindingSource.PositionChanged
        On Error Resume Next
        If CuttingMakingBindingSource.Position > -1 Then

            Dim row As CuttingMakingDataSet.CuttingMakingRow
            row = CType(CType(Me.CuttingMakingBindingSource.Current, DataRowView).Row, CuttingMakingDataSet.CuttingMakingRow)

            If DBNull.Value.Equals(row.StyleId) = False Then

                Me.CM_FirstLayoutTableAdapter.Fill(Me.CuttingMakingDataSet.CM_FirstLayout, row.StyleId)
                Me.CM_ProductionTableAdapter.Fill(Me.CuttingMakingDataSet.CM_Production, row.StyleId)

            End If
           

        End If
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.CuttingMakingTableAdapter.Fill(Me.CuttingMakingDataSet.CuttingMaking)
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Try
            Me.Validate()
            Me.CuttingMakingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingMakingDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.CuttingMakingTableAdapter.FillByStyleId(Me.CuttingMakingDataSet.CuttingMaking, CType(StyleLookupGridLookUpEdit.EditValue.ToString, Long))
        Me.CM_FirstLayoutTableAdapter.Fill(Me.CuttingMakingDataSet.CM_FirstLayout, CType(StyleLookupGridLookUpEdit.EditValue.ToString, Long))
        Me.CM_ProductionTableAdapter.Fill(Me.CuttingMakingDataSet.CM_Production, CType(StyleLookupGridLookUpEdit.EditValue.ToString, Long))

        If CuttingMakingBindingSource.Position = -1 Then
            MessageLabel.Text = "Not Found Any Buyer CM For this Style."
        Else
            MessageLabel.Text = ""

        End If

    End Sub
End Class