Public Class frmSampleDelivery

   
    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        If SampleRequestNoLookupBindingSource.Position > -1 Then

            Dim row As SampleRequestDataSet.SampleRequestNoLookupRow
            row = CType(CType(Me.SampleRequestNoLookupBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestNoLookupRow)



            'Clear(Me.SampleRequestDataSet.SampleRequestFinal)

            Me.SampleRequestFinalTableAdapter.FillBySampleRequestId(Me.SampleRequestDataSet.SampleRequestFinal, row.SampleRequestId)
            'Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)


        End If
    End Sub

    Private Sub GridLookUpEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit2.EditValueChanged

        If SampleRequestNoLookupBindingSource.Position > -1 Then

            Dim row As SampleRequestDataSet.SampleRequestNoLookupRow
            row = CType(CType(Me.SampleRequestNoLookupBindingSource.Current, DataRowView).Row, SampleRequestDataSet.SampleRequestNoLookupRow)

            Me.SampleRequestFinalTableAdapter.FillBySampleRequestId(Me.SampleRequestDataSet.SampleRequestFinal, row.SampleRequestId)

        End If

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        If NewButton.Text = "&Add" Then

            StyleDataSet.Style.UserIdColumn.DefaultValue = UserId
            StyleDataSet.Style.ModifiedOnColumn.DefaultValue = Now()

            Me.SampleRequestFinalBindingSource.AddNew()
            Me.RequestNoTextEdit.Focus()

            NewButton.Text = "&Save"
            NewButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            SaveButton.Enabled = False
            EnableFormControl(Me)


        Else

            Save()



            NewButton.Text = "&Add"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Add_icon
            SaveButton.Enabled = True
            DisableFromControl(Me)

        End If
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If SaveButton.Text = "&Edit" Then

            SaveButton.Text = "&Save"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            NewButton.Enabled = False
            EnableFormControl(Me)

        Else

            Save()


            SaveButton.Text = "&Edit"
            SaveButton.Image = KSoft_Apparel.My.Resources.Resources.Edit
            NewButton.Enabled = True
            DisableFromControl(Me)
        End If

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If SampleFabricBindingSource.Position > -1 Then
            MessageBox.Show("Delete Fabric Details", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        ElseIf SamplePrintColorBindingSource.Position > -1 Then
            MessageBox.Show("Delete PrintColor ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        ElseIf SampleRequireQuantityBindingSource.Position > -1 Then

            MessageBox.Show("Delete Require Quantity ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If



        MessageBox.Show("Are you sure you want to delete the booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If CType(MsgBoxResult.Yes, Boolean) = True Then

            SampleRequestFinalBindingSource.RemoveCurrent()

        Else

            Exit Sub

        End If

    End Sub

    Private Sub frmSampleDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)
        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestNoLookup)
        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)

        Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)
        'Me.SampleRequestFinalTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinal)
        Me.SampleRequestFinalDetailsTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestFinalDetails)
        Me.SampleFabricTableAdapter.Fill(Me.SampleRequestDataSet.SampleFabric)
        Me.SampleRequireQuantityTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequireQuantity)
        Me.SamplePrintColorTableAdapter.Fill(Me.SampleRequestDataSet.SamplePrintColor)






        DisableFromControl(Me)



        '    '==============
        '    Dim connection As New SqlConnection(cnn)
        '    connection.Open()

        '    Dim cmd As SqlCommand = New SqlCommand("Select Distinct Style From SampleRequestFinal", connection)
        '    Dim reader As SqlDataReader = cmd.ExecuteReader()
        '    Dim list As New AutoCompleteStringCollection

        '    While reader.Read

        '        If reader.IsDBNull(0) = False Then

        '            list.Add(reader.Item("Style").ToString)

        '        End If

        '    End While

        '    reader.Close()


        '    StyleTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    StyleTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    StyleTextBox.AutoCompleteCustomSource = list

        '    connection.Close()
        '    '====================
    End Sub

    Private Sub Save()

        Try

            Me.Validate()
            Me.SampleRequestFinalBindingSource.EndEdit()
            Me.SampleRequestFinalDetailsBindingSource.EndEdit()
            Me.SampleFabricBindingSource.EndEdit()
            Me.SamplePrintColorBindingSource.EndEdit()

            Me.SampleRequestFinalTableAdapter.Update(Me.SampleRequestDataSet.SampleRequestFinal)
            Me.SampleRequestFinalDetailsTableAdapter.Update(Me.SampleRequestDataSet.SampleRequestFinalDetails)
            Me.SampleFabricTableAdapter.Update(Me.SampleRequestDataSet.SampleFabric)
            Me.SamplePrintColorTableAdapter.Update(Me.SampleRequestDataSet.SamplePrintColor)
            Me.SampleRequireQuantityTableAdapter.Update(Me.SampleRequestDataSet.SampleRequireQuantity)

            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class