Imports System.Data.SqlClient

Public Class frmProductionTarget
    Private Sub ProductionTargetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductionTargetBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionTargetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionTargetDataSet)

    End Sub



    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.ProductionTargetTableAdapter.FillByUserId(Me.ProductionTargetDataSet.ProductionTarget, ProductionDateEdit.DateTime.Date, UserId)

        If Me.ProductionTargetBindingSource.Position = -1 Then

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("Select ProductionTypeId,TargetQuantity From ProductionType Where UserId=" & UserId, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim list As New AutoCompleteStringCollection

            While reader.Read

                If reader.IsDBNull(0) = False Then

                    Dim newRow = CType(Me.ProductionTargetDataSet.ProductionTarget.NewRow(), ProductionTargetDataSet.ProductionTargetRow)
                    newRow.ProductionDate = ProductionDateEdit.DateTime.Date
                    newRow.ProductionTypeId = reader("ProductionTypeId")
                    newRow.TargetQuantity = reader("TargetQuantity")
                    newRow.UserId = UserId
                    ProductionTargetDataSet.ProductionTarget.Rows.Add(newRow)

                End If

            End While

            reader.Close()
            connection.Close()
        Else
            MessageBox.Show("Already Added.")
        End If


    End Sub

    Private Sub frmProductionTarget_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductionTypeTableAdapter.Fill(Me.ProductionTypeDataSet.ProductionType)

    End Sub

    Private Sub ProductionDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ProductionDateEdit.EditValueChanged
        On Error Resume Next
        Me.ProductionTargetTableAdapter.FillByUserId(Me.ProductionTargetDataSet.ProductionTarget, ProductionDateEdit.DateTime.Date, UserId)
    End Sub
End Class