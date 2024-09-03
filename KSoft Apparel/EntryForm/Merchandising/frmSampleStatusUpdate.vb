Public Class frmSampleStatusUpdate
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If SaveButton.Text = "&Edit" Then

            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            SaveButton.Text = "&Save"

        Else

            Save()

            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SaveButton.Text = "&Edit"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Edit

        End If

    End Sub

    Private Sub Save()

        Try


            Me.Validate()
            Me.SampleRequestFinalBindingSource.EndEdit()
            Me.SampleRequestFinalTableAdapter.Update(Me.SampleRequestDataSet.SampleRequestFinal)

            'Me.TableAdapterManager.UpdateAll(Me.SampleRequestDataSet)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmSampleStatusUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)

    End Sub


    Private Sub ShowByRqButton_Click(sender As Object, e As EventArgs) Handles ShowByRqButton.Click

        filterstring = "{SampleRequestFinal.RequestNo} ='" & GridLookUpEdit1.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        If Me.GridLookUpEdit1.EditValue IsNot String.Empty Then

            Me.SampleRequestFinalTableAdapter.FillByRequestNo(Me.SampleRequestDataSet.SampleRequestFinal, Me.GridLookUpEdit1.EditValue)
            SampleDeliveryQuantitySpinEdit.Value = ReadData("Select SampleDeliveryQuantity From SampleDeliverySummery Where RequestNo='" & Me.GridLookUpEdit1.EditValue & "'", cnn)
            DelDateEdit.Text = ReadDateData("Select FirstSampleDeliveryDate From SampleDeliverySummery Where RequestNo='" & Me.GridLookUpEdit1.EditValue & "'", cnn)

        End If

    End Sub
End Class