Imports System.Data.SqlClient

Public Class frmHoliday

    Private Sub HolidayBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.HolidayBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HolidayDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub

    Private Sub frmHoliday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        YearTextBox.Text = Today.Year()
        Me.HolidayTableAdapter.Fill(Me.HolidayDataSet.Holiday, Val(YearTextBox.Text), WeekdayCheckBox.CheckState)

        If CheckUserRights("Holiday").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            HolidayBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Holiday").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            HolidayBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub


    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        Me.HolidayTableAdapter.Fill(Me.HolidayDataSet.Holiday, Val(YearTextBox.Text), True)

        If Me.HolidayBindingSource.Position = -1 Then

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("Exec GetYearWeekend " & Val(YearTextBox.Text), connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read

                If reader.IsDBNull(0) = False Then

                    Dim newRow As HolidayDataSet.HolidayRow = Me.HolidayDataSet.Holiday.NewRow()

                    newRow.HolidayDate = reader("Date")
                    newRow.Description = reader("DayName")
                    newRow.IsWeekend = True
                    newRow.Year = YearTextBox.Text

                    Me.HolidayDataSet.Holiday.Rows.Add(newRow)

                End If

            End While
            reader.Close()

            connection.Close()

        End If


    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.HolidayTableAdapter.Fill(Me.HolidayDataSet.Holiday, Val(YearTextBox.Text), WeekdayCheckBox.CheckState)
    End Sub
End Class