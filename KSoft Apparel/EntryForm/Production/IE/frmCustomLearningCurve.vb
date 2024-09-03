Imports System.Data.SqlClient

Public Class frmCustomLearningCurve
    Private Sub SewingCustomLearningCurveBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SewingCustomLearningCurveBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SewingCustomLearningCurveBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingCustomLearningCurveDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        If StyleTypeTextBox.Text <> String.Empty Then

            Dim ChkDuplicate As Integer = ReadIntData("Select Count(*) From SewingCustomLearningCurve Where StyleType like '" & StyleTypeTextBox.Text & "'", cnn)
            ' Dim SID As Integer = ReadIntegerData("Select StyleId From Style Where StyleName like '" & StyleTypeTextBox.Text & "'", cnn)

            If ChkDuplicate = 1 Then
                SewingCustomLearningCurveTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SewingCustomLearningCurve, StyleTypeTextBox.Text)
                Exit Sub
            End If

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("AddCutomLearningCurve", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@StyleType", StyleTypeTextBox.Text)

                cmd.ExecuteNonQuery()

            End Using


            SewingCustomLearningCurveTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SewingCustomLearningCurve, StyleTypeTextBox.Text)
            Me.SCLStyleTypeLookupTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SCLStyleTypeLookup)
            Me.SCLGridLookUpEdit.EditValue = StyleTypeTextBox.Text
            MessageBox.Show("Copied Successfully.")

        End If

    End Sub

    Private Sub frmCustomLearningCurve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewingCustomLearningCurveDataSet.SCLStyleTypeLookup' table. You can move, or remove it, as needed.
        Me.SCLStyleTypeLookupTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SCLStyleTypeLookup)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If Me.SewingCustomLearningCurveBindingSource.Position > -1 Then
            Me.SewingCustomLearningCurveBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SCLGridLookUpEdit.EditValueChanged
        On Error Resume Next

        SewingCustomLearningCurveTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SewingCustomLearningCurve, SCLGridLookUpEdit.EditValue)
    End Sub
End Class