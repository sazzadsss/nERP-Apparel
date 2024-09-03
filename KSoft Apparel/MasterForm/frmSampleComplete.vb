Public Class frmSampleComplete

    Private Sub SampleRequestFinalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleRequestFinalBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SampleRequestFinalBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SampleRequestDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmSampleComplete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        If CheckUserRights("Sample Delivery").CanEdit = False Then

            SampleRequestFinalBindingNavigatorSaveItem.Enabled = False

        End If


    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        If e.Column.Caption = "Complete" Then

            Dim row As SampleRequestDataSet.SampleRequestFinalRow
            row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)

            If row.IsComplete = True Then

                row.CompletedOn = ReadDateData("Select GetDate()", cnn)
                Me.SampleRequestFinalBindingSource.ResetBindings(True)

            End If

        End If

    End Sub

    Private Sub SampleRequestFinalBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles SampleRequestFinalBindingSource.PositionChanged


        Dim row As SampleRequestDataSet.SampleRequestFinalRow
        row = CType(CType(Me.SampleRequestFinalBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestFinalRow)

        If UserId <> 1 Then

            If row.IsComplete = True Then
                colIsComplete.OptionsColumn.ReadOnly = True
            Else
                colIsComplete.OptionsColumn.ReadOnly = False
            End If

        End If



    End Sub
End Class