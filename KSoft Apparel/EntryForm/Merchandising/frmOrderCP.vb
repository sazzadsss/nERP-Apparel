Public Class frmOrderCP

    Private Sub OrderCPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCPBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrderCPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OrderCPDataSet)

    End Sub

    Private Sub frmOrderCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If UserLevel = 1 Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            Me.OrderCPTableAdapter.Fill(Me.OrderCPDataSet.OrderCP)
        Else
            Me.OrderLookupTableAdapter.FillByUserId(Me.OrderLookupDataSet.OrderLookup, UserId)
            Me.OrderCPTableAdapter.FillByUserId(Me.OrderCPDataSet.OrderCP, UserId)

        End If


    End Sub

    Private Sub OrderCPBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCPBindingSource.PositionChanged

        Dim row As OrderCPDataSet.OrderCPRow
        row = CType(CType(Me.OrderCPBindingSource.Current, DataRowView).Row, OrderCPDataSet.OrderCPRow)

        Dim varSewingStartDate As Date = ReadDateData("Select Min(SewingDate) from SewingProduction Where OrderId=" & row.OrderId, cnn)
        Dim varPrintStartDate As Date = ReadDateData("Select Min(PrintProductionDate) from vPrintProduction Where OrderId=" & row.OrderId, cnn)

        Dim varShipmentDate As Date = ReadDateData("Select Min(FinishingDate) from vShipment Where OrderId=" & row.OrderId, cnn)
        Dim varShipmentQuantity As Decimal = ReadData("Select Sum(ShippmentQuantity) from vShipment Where OrderId=" & row.OrderId, cnn)


        SewingStartDateLabel.Text = FormatDateTime(varSewingStartDate.ToString, DateFormat.ShortDate)
        PrintStartDateLabel.Text = FormatDateTime(varPrintStartDate.ToString, DateFormat.ShortDate)
        ShipmentDateLabel.Text = FormatDateTime(varShipmentDate.ToString, DateFormat.ShortDate)
        ShipmentDateLabel.Text = varShipmentQuantity


    End Sub

    
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        On Error Resume Next

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        Dim rowcount As Integer = ReadIntData("Select count(OrderId) from OrderCP Where OrderId=" & row.OrderId, cnn)

        If rowcount < 1 Then

            Me.OrderCPDataSet.OrderCP.OrderIdColumn.DefaultValue = row.OrderId
            Me.OrderCPDataSet.OrderCP.OrderDateColumn.DefaultValue = FormatDateTime(ReadDateData("Select OrderReceiveDate From [Order] Where OrderId=" & row.OrderId, cnn), DateFormat.LongDate)
            Me.OrderCPDataSet.OrderCP.ExDateColumn.DefaultValue = ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & row.OrderId, cnn)
            Me.OrderCPDataSet.OrderCP.OrderQuantityColumn.DefaultValue = ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderId=" & row.OrderId, cnn)

            OrderCPBindingSource.AddNew()

        Else

            MessageBox.Show("This order is already exist", "Order Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click


        For Each dr As DataRowView In OrderCPBindingSource.List

            Dim varOrderDate As Date = ReadDateData("Select OrderReceiveDate From [Order] Where OrderId=" & dr!OrderId, cnn)
            Dim varExDate As Date = ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & dr!OrderId, cnn)
            Dim varOrderQuantity As Decimal = ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderId=" & dr!OrderId, cnn)

            dr!OrderDate = varOrderDate
            dr!ExDate = varExDate
            dr!OrderQuantity = varOrderQuantity



        Next

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click

        'PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        'knKGridControl1.MainView.ExportToXls(Application.StartupPath + "\\Test.xls", false);
        'OrderCPGridControl.ShowPrintPreview()
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Order CP-" & Today
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                'Dim filePath As String
                ''Open or Create the file
                'filePath = System.IO.Path.Combine( _
                '    My.Computer.FileSystem.SpecialDirectories.MyDocuments, _
                '    objSaveFileDialog.FileName)
                ''Replace the contents of the file
                'My.Computer.FileSystem.WriteAllText(filePath, "D:\\a.xls", False)
                OrderCPGridControl.MainView.ExportToXls(objSaveFileDialog.FileName)

            Catch fileException As Exception
                Throw fileException
            End Try
        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

        'PrintForm1.Print()
    End Sub
End Class