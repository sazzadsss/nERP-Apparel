Imports System.Data.SqlClient

Public Class frmProgramFullAndFinal


    Private _ByUserFlag As Boolean
    Public Property ByUserFlag() As Boolean
        Get
            Return _ByUserFlag
        End Get
        Set(ByVal value As Boolean)
            _ByUserFlag = value
        End Set
    End Property
    Dim CompleteFlag As Boolean = False
    Private Sub OrderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderBindingNavigatorSaveItem.Click

        Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id=" & UserId, cnn)

        If UL = 1 Then
            GoTo Line1
        End If

        If CompleteFlag = True Then

            MessageBox.Show("Not Allowed to Edit the full completed Program.")
            Exit Sub


        End If
Line1:

        For Each drv As DataRowView In Me.OrderDetailsBindingSource.List

            If drv!Discontinue = True Then

                If DBNull.Value.Equals(drv!CasuseOfDiscontinue) Then
                    MessageBox.Show("Not Allowed to save without cause of Cancel.")
                    Exit Sub
                End If

                If drv!CasuseOfDiscontinue = String.Empty Then
                    MessageBox.Show("Not Allowed to save without cause of Cancel.")
                    Exit Sub
                End If

            End If

        Next

        Try






            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.OrderDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProgramFullAndFinalDataSet)

            HoldCheckBox.Checked = CheckFullHold()
            DiscontinueCheckBox.Checked = CheckFullCancel()
            IsCompleteCheckBox.Checked = CheckFullComplete()

            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.OrderDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProgramFullAndFinalDataSet)

            If IsCompleteCheckBox.Checked Then
                UpdateFabricClose(Me.ProgramNoTextBox.Text, True)
            Else
                UpdateFabricClose(Me.ProgramNoTextBox.Text, False)
            End If




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub UpdateFabricClose(ByVal PrgNo As String, ByVal IsClose As Boolean)

        Dim flag As System.Data.SqlTypes.SqlBoolean
        flag = IsClose

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("UpdateFabricClose", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ProgramNo", PrgNo)
            cmd.Parameters.AddWithValue("@IsFullComplete", flag)

            cmd.ExecuteNonQuery()

        End Using



    End Sub

    Private Sub frmProgramFullAndFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)

        If Me.ByUserFlag Then
            Me.OrderLookupTableAdapter.FillByParticularUser(Me.OrderLookupDataSet.OrderLookup, UserId)
            If CheckUserRights("Program Full And Final").CanEdit = False Then
                OrderBindingNavigatorSaveItem.Enabled = False
            End If
        Else
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            If CheckUserRights("Program Full And Final [All]").CanEdit = False Then
                OrderBindingNavigatorSaveItem.Enabled = False
            End If
        End If



    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Me.OrderTableAdapter.Fill(Me.ProgramFullAndFinalDataSet.Order, OrderLookupGridLookUpEdit.EditValue)
        Me.OrderDetailsTableAdapter.Fill(Me.ProgramFullAndFinalDataSet.OrderDetails, OrderLookupGridLookUpEdit.EditValue)
        Me.OrderAndProductionDateStatusTableAdapter.FillByOrderId(Me.OrderAndProductionStatusDataSet.OrderAndProductionDateStatus, OrderLookupGridLookUpEdit.EditValue)

        If IsCompleteCheckBox.Checked = True Then
            CompleteFlag = True
        Else
            CompleteFlag = False
        End If


        'For Each drv As DataRowView In Me.OrderDetailsBindingSource.List
        '    drv!ShipmentQuantity = 
        'Next

        For i As Integer = 0 To GridView1.DataRowCount - 1
            'If GridView1.GetRowCellValue(i, "ShipmentQuantity").ToString() = "" Then
            '    ' Your code here
            'End If
            Dim ODID As Integer = GridView1.GetRowCellValue(i, "OrderDetailsId").ToString()
            Dim SQty As Integer = ReadData("Select SUM(ShippmentQuantity) From FinishingProduction Where OrderDetailsId = " & ODID, cnn)
            GridView1.SetRowCellValue(i, "ShipmentQuantity", SQty)
            Dim OQty As Integer = ReadIntegerData("Select OrderQuantity From vOrder Where OrderDetailsId=" & ODID, cnn)
            GridView1.SetRowCellValue(i, "OrderQuantity", OQty)

        Next i

        Me.OrderDetailsBindingSource.MoveLast()

        Try

            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.OrderDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProgramFullAndFinalDataSet)

            If IsCompleteCheckBox.Checked Then
                UpdateFabricClose(Me.ProgramNoTextBox.Text, True)
            Else
                UpdateFabricClose(Me.ProgramNoTextBox.Text, False)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub IsCompleteCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsCompleteCheckBox.CheckedChanged
        If IsCompleteCheckBox.Checked = True Then
            FullCompleteDateEdit.EditValue = Today
            IsRunningCheckBox.Checked = False

        Else
            FullCompleteDateEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub DiscontinueCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DiscontinueCheckBox.CheckedChanged
        If DiscontinueCheckBox.Checked Then
            IsRunningCheckBox.Checked = False
            CancelledOnDateEdit.EditValue = ReadDateData("Select GetDate()", cnn)
        Else
            CancelledOnDateEdit.EditValue = Nothing
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        Dim row As ProgramFullAndFinalDataSet.OrderDetailsRow
        row = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, ProgramFullAndFinalDataSet.OrderDetailsRow)

        If e.Column.Caption = "PO Complete" Then

            If Row.IsClose = True Then
                Row.ClosedOn = ReadDateData("Select GetDate()", cnn)
            Else
                Row.SetClosedOnNull()
            End If

        ElseIf e.Column.Caption = "Is Hold" Then

            If row.IsHold = True Then
                row.HoldOn = ReadDateData("Select GetDate()", cnn)
            Else
                row.SetHoldOnNull()
            End If
        ElseIf e.Column.Caption = "Cancel" Then

            If row.Discontinue = True Then
                row.CancelledOn = ReadDateData("Select GetDate()", cnn)
            Else
                row.SetCancelledOnNull()
            End If

        End If
    End Sub

    Private Sub HoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HoldCheckBox.CheckedChanged
        If HoldCheckBox.Checked Then
            IsRunningCheckBox.Checked = False
            HoldOnDateEdit.EditValue = ReadDateData("Select GetDate()", cnn)
        Else
            HoldOnDateEdit.EditValue = Nothing
        End If
    End Sub

    Function CheckFullHold() As Integer
        Dim FullHoldFlag As Boolean = HoldCheckBox.Checked
        Dim CheckCount As Integer = 0

        For Each drv As DataRowView In Me.OrderDetailsBindingSource.List
            If drv!IsHold = True Then
                CheckCount = CheckCount + 1
            End If
        Next

        If Me.OrderDetailsBindingSource.Count = CheckCount Then
            Return True
        Else
            Return FullHoldFlag

        End If


    End Function

    Function CheckFullComplete() As Integer

        Dim FullCompleteFlag As Boolean = IsCompleteCheckBox.Checked

        Dim CheckCount As Integer = 0

        For Each drv As DataRowView In Me.OrderDetailsBindingSource.List
            If drv!IsClose = True Then
                CheckCount = CheckCount + 1
            End If
        Next

        If Me.OrderDetailsBindingSource.Count = CheckCount Then
            Return True
        Else
            Return FullCompleteFlag
        End If


    End Function

    Function CheckFullCancel() As Integer
        Dim FullCancelFlag As Boolean = DiscontinueCheckBox.Checked

        Dim CheckCount As Integer = 0

        For Each drv As DataRowView In Me.OrderDetailsBindingSource.List
            If drv!Discontinue = True Then
                CheckCount = CheckCount + 1
            End If
        Next

        If Me.OrderDetailsBindingSource.Count = CheckCount Then
            Return True
        Else
            Return FullCancelFlag
        End If


    End Function
End Class