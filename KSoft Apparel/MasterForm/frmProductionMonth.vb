Public Class frmProductionMonth
    Private Sub ProductionMonthBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductionMonthBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionMonthBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionMonthDataSet)
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub frmProductionMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Dim DBNowYear As Integer = ReadIntData("SELECT Top 1 ProductionYear from ProductionMonth  ORDER BY ProductionYear DESC", cnn)
        If DBNowYear <> Now.Year.ToString.Substring(2) Then

            Dim i As Integer = 1
            While i < 13

                Dim newRow = CType(Me.ProductionMonthDataSet.ProductionMonth.NewRow(), ProductionMonthDataSet.ProductionMonthRow)
                newRow.ProductionMonth = i
                newRow.ProductionYear = Now.Year.ToString.Substring(2)
                Select Case i
                    Case 1
                        newRow.ProductionMonthName = "Jan'" + Now.Year.ToString.Substring(2)
                    Case 2
                        newRow.ProductionMonthName = "Feb'" + Now.Year.ToString.Substring(2)
                    Case 3
                        newRow.ProductionMonthName = "Mar'" + Now.Year.ToString.Substring(2)
                    Case 4
                        newRow.ProductionMonthName = "Apr'" + Now.Year.ToString.Substring(2)
                    Case 5
                        newRow.ProductionMonthName = "May'" + Now.Year.ToString.Substring(2)
                    Case 6
                        newRow.ProductionMonthName = "Jun'" + Now.Year.ToString.Substring(2)
                    Case 7
                        newRow.ProductionMonthName = "July'" + Now.Year.ToString.Substring(2)
                    Case 8
                        newRow.ProductionMonthName = "Aug'" + Now.Year.ToString.Substring(2)
                    Case 9
                        newRow.ProductionMonthName = "Sep'" + Now.Year.ToString.Substring(2)
                    Case 10
                        newRow.ProductionMonthName = "Oct'" + Now.Year.ToString.Substring(2)
                    Case 11
                        newRow.ProductionMonthName = "Nov'" + Now.Year.ToString.Substring(2)
                    Case 12
                        newRow.ProductionMonthName = "Dec'" + Now.Year.ToString.Substring(2)
                End Select

                Me.ProductionMonthDataSet.ProductionMonth.Rows.Add(newRow)
                i += 1

                BindingNavigatorAddNewItem.Enabled = False
            End While
            ProductionMonthBindingSource.MoveLast()
        Else
            MessageBox.Show("This year already added", "Duplicate Entity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class