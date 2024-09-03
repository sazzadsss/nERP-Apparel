Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports System.IO



Public Class frmOrderAndProductionStatus
    Private _MIS As Boolean
    Public Property MIS() As Boolean
        Get
            Return _MIS
        End Get
        Set(ByVal value As Boolean)
            _MIS = value
        End Set
    End Property
    Dim ColumnName As String = String.Empty
    Dim PrgCount As Integer = 0
    Dim PrgNo As String = String.Empty

    Dim OAPS_Color As String = "Software\KSoftSolutions\KSoftApparel\Layouts\OAPS_Color"
    Dim OAPS_Program As String = "Software\KSoftSolutions\KSoftApparel\Layouts\OAPS_Program"

    Dim regKey As String = "DevExpress\XtraGrid\Layouts\MainLayout"
    Dim regKey2 As String = "DevExpress\XtraGrid\Layouts\MainLayout2"
    Dim fileName As String = System.AppDomain.CurrentDomain.BaseDirectory() & "\Layout\OrderTrackingSheetColorwise.xml"
    Dim fileName2 As String = System.AppDomain.CurrentDomain.BaseDirectory() & "\Layout\OrderTrackingSheetProgramwise.xml"

    ' System.AppDomain.CurrentDomain.BaseDirectory()

    Dim StatusFlag As Boolean = False



    ' The cultures used to format the values for the two different currencies.
    Dim ciUSA As CultureInfo = New CultureInfo("en-US")
    'Dim ciEUR As CultureInfo = New CultureInfo("fr-FR", False)

    Private Sub frmOrderAndProductionStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg' table. You can move, or remove it, as needed.
        'Me.MasterOrderAndProductionStatusPrgTableAdapter1.Fill(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg)
        'TODO: This line of code loads data into the 'MasterOrderAndProductionStatus.MasterOrderAndProductionStatusPrg' table. You can move, or remove it, as needed.


        Me.ProgramNoWithStyleBuyerLookUpTableAdapter.Fill(Me.ProgramNoWtihStyleBuyerLookUpDataSet.ProgramNoWithStyleBuyerLookUp)
        LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)

        If ProgramwiseRadioButton.Checked Then

            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True


        Else

            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False

            'BandedGridView2.SaveLayoutToXml(fileName)


        End If

        'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\KSoftSolutions\KSoftApparel\Layouts", "OAPS_Color", Nothing) Is Nothing Then

        MasterOrAndProdGridControl.MainView.SaveLayoutToRegistry(OAPS_Color)

        'End If

        'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\KSoftSolutions\KSoftApparel\Layouts", "OAPS_Program", Nothing) Is Nothing Then

        MasterOrAndProdGridControl.MainView.SaveLayoutToRegistry(OAPS_Color)

        'End If




        Dim UL As Integer = ReadIntData("Select user_level From [User] Where User_id=" & UserId, cnn)

        If UL <> 1 Then
            HideColumn(colOrderAmount)
            HideBandedColumn(BandedGridColumn31)
        End If

    End Sub


    Private Sub ShowRunningButton_Click(sender As Object, e As EventArgs) Handles ShowRunningButton.Click


        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        If ProgramwiseRadioButton.Checked Then

            Me.MasterOrderAndProductionStatusPrgTableAdapter.SetCommandTimeOut(60000)
            Me.MasterOrderAndProductionStatusPrgTableAdapter.FillByRunningConfirmOrder(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg)
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
            LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)

        Else

            Me.MasterOrderAndProductionStatusTableAdapter.FillByRunningConfirmOrder(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus)
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False

        End If

        SplashScreenManager.CloseForm(False)





        'If ProgramwiseRadioButton.Checked Then

        '    SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        '    If UpdateCheckBox.Checked Then
        '        ExecuteQuery("Exec dbo.OrderAndProductionStatus", cnn)
        '    End If

        '    Me.OrderAndProductionStatusTableAdapter.Fill(Me.OrderAndProductionStatusDataSet.OrderAndProductionStatus)

        '    SplashScreenManager.CloseForm(False)
        '    SplitContainer1.Panel1Collapsed = False
        '    SplitContainer1.Panel2Collapsed = True

        'Else

        '    SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        '    'If UpdateCheckBox.Checked Then
        '    '    ExecuteQuery("Exec dbo.FillTempMasterOrderAndProductionStatus", cnn)
        '    'End If
        '    Me.MasterOrderAndProductionStatusTableAdapter.Fill(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus)
        '    SplashScreenManager.CloseForm(False)
        '    SplitContainer1.Panel1Collapsed = True
        '    SplitContainer1.Panel2Collapsed = False

        'End If


    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs)

        Dim row As OrderAndProductionStatusDataSet.OrderAndProductionStatusRow
        row = CType(CType(Me.OrderAndProductionStatusBindingSource.Current, DataRowView).Row, OrderAndProductionStatusDataSet.OrderAndProductionStatusRow)

    End Sub

    Private Sub BandedGridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)
        Dim View As GridView = sender

        Dim ShortQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentShortQty"))
        ' Dim SSQty As Double = Convert.ToDouble(ShortQty)
        Dim PlusQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentExcessQty"))
        'Dim PSQty As Decimal = Convert.ToDecimal(PlusQty)

        Dim ShipQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentQty"))

        If e.Column.FieldName = "ShipmentShortQty" Then
            If ShortQty = ("0").ToString Then
                e.Appearance.ForeColor = Color.LightGray
            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.Red
            End If
        End If

        If e.Column.FieldName = "ShipmentExcessQty" Then
            If PlusQty = ("0").ToString Then
                e.Appearance.ForeColor = Color.LightGray
            Else
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            End If
        End If

        If e.Column.FieldName = "ProgramNo" Then
            If ShipQty = ("0").ToString Then
                e.Appearance.ForeColor = Color.Blue
            Else
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            End If
        End If

    End Sub

    Private Sub BandedGridView1_DoubleClick(sender As Object, e As EventArgs) Handles BandedGridView3.DoubleClick
        Dim row As OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrgRow
        row = CType(CType(Me.MasterOrderAndProductionStatusPrgBindingSource.Current, DataRowView).Row, OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrgRow)

        If BandedGridView3.FocusedColumn.Caption = "Order Qty PCS" Or BandedGridView3.FocusedColumn.Caption = "Program No" Or BandedGridView3.FocusedColumn.Caption = "Buyer Order Amnd No" Or BandedGridView3.FocusedColumn.Caption = "Buyer Order Amnd Date" Or BandedGridView3.FocusedColumn.Caption = "Buyer" Or BandedGridView3.FocusedColumn.Caption = "Style" Or BandedGridView3.FocusedColumn.Caption = "Style Type" Or BandedGridView3.FocusedColumn.Caption = "Brand" Or BandedGridView3.FocusedColumn.Caption = "Division" Or BandedGridView3.FocusedColumn.Caption = "Season" Or BandedGridView3.FocusedColumn.Caption = "PO" Or BandedGridView3.FocusedColumn.Caption = "GMT Color" Or BandedGridView3.FocusedColumn.Caption = "Order Receive Date" Or BandedGridView3.FocusedColumn.Caption = "Ship Bal Min EX Date" Or BandedGridView3.FocusedColumn.Caption = "Ship Bal Max EX Date" Or BandedGridView3.FocusedColumn.Caption = "Print" Or BandedGridView3.FocusedColumn.Caption = "EMB" Or BandedGridView3.FocusedColumn.Caption = "AOP" Or BandedGridView3.FocusedColumn.Caption = "Wash" Or BandedGridView3.FocusedColumn.Caption = "YDS" Or BandedGridView3.FocusedColumn.Caption = "Brush" Or BandedGridView3.FocusedColumn.Caption = "Merchandiser" Then

            With frmOrderSheet_mrf

                .MdiParent = frmMain
                .OrderId = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Shipment Balance" Then

            With frmOrderQtyPOBal_mrf

                .MdiParent = frmMain
                .OrderId = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Master Program No" Then

            With frmMasterOrder_mrf

                .MdiParent = frmMain
                .MOID = ReadIntegerData("Select MasterOrderId From MasterOrder Where MasterProgramNo='" & row.MasterProgramNo & "'", cnn)
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Running Program" Then

            frmOrderAndProductionStatusChart.OrderId = row.OrderId
            ShowForm(frmOrderAndProductionStatusChart)

        ElseIf BandedGridView3.FocusedColumn.Caption = "Is Fabric BOM Complete" Or BandedGridView3.FocusedColumn.Caption = "Amnd No" Or BandedGridView3.FocusedColumn.Caption = "Amnd Date" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Booking Qty" Or BandedGridView3.FocusedColumn.Caption = "Grey Fabric Booking Qty" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Booking Qty [BOM]" Or BandedGridView3.FocusedColumn.Caption = "G%" Or BandedGridView3.FocusedColumn.Caption = "Knitting Require with EFR Qty" Or BandedGridView3.FocusedColumn.Caption = "Yarn Require with EFR" Then

            With frmFabricBooking_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Finish Fabric Require" Or BandedGridView3.FocusedColumn.Caption = "Grey Fabric Require" Or BandedGridView3.FocusedColumn.Caption = "G %" Then

            With frmFinishFabricBookingReceive_mrf

                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Is Acc BOM Complete" Or BandedGridView3.FocusedColumn.Caption = "Acc Amnd No" Or BandedGridView3.FocusedColumn.Caption = "Acc Amnd Date" Then

            With frmAccessoriesBooking_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Accessories Status [Receive/Issue]" Then

            With frmAccessories_Status_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Full Complete Date" Then

            With frmShipmentComplete_mrf
                .OrderId = row.OrderId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Shipment Qty" Or BandedGridView3.FocusedColumn.Caption = "Shipment Carton Qty" Or BandedGridView3.FocusedColumn.Caption = "Shipment Plus Qty" Or BandedGridView3.FocusedColumn.Caption = "Shipment Short Qty" Or BandedGridView3.FocusedColumn.Caption = "TTL Shipment $" Or BandedGridView3.FocusedColumn.Caption = "First Shipment Date" Or BandedGridView3.FocusedColumn.Caption = "Last Shipment Date" Then

            With frmShipment_mrf
                .OID = row.OrderId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Shipment Bal" Then

            With frmShipmentBalance_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With


        ElseIf BandedGridView3.FocusedColumn.Caption = "Poly Qty" Or BandedGridView3.FocusedColumn.Caption = "Finishing Input Qty" Or BandedGridView3.FocusedColumn.Caption = "Iron Qty" Or BandedGridView3.FocusedColumn.Caption = "Carton Qty" Or BandedGridView3.FocusedColumn.Caption = "Finishing WIP" Or BandedGridView3.FocusedColumn.Caption = "Hangtag Qty" Then

            With frmFinishingPoly_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Sewing Qty" Or BandedGridView3.FocusedColumn.Caption = "Sewing Input" Or BandedGridView3.FocusedColumn.Caption = "Sewing Input Bal" Or BandedGridView3.FocusedColumn.Caption = "Input %" Or BandedGridView3.FocusedColumn.Caption = "Sewing %" Or BandedGridView3.FocusedColumn.Caption = "Sewing Bal" Or BandedGridView3.FocusedColumn.Caption = "Sewing WIP" Or BandedGridView3.FocusedColumn.Caption = "Sewing Excess" Or BandedGridView3.FocusedColumn.Caption = "Sewing Input Excess" Then

            With frmSewing_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Cutting" Or BandedGridView3.FocusedColumn.Caption = "Cutting Bal" Or BandedGridView3.FocusedColumn.Caption = "Excess Cutting" Or BandedGridView3.FocusedColumn.Caption = "Cutting Input" Or BandedGridView3.FocusedColumn.Caption = "Cutting WIP" Or BandedGridView3.FocusedColumn.Caption = "Print Send" Or BandedGridView3.FocusedColumn.Caption = "Print Receive" Or BandedGridView3.FocusedColumn.Caption = "Print Receive Bal" Or BandedGridView3.FocusedColumn.Caption = "Print Supplier" Or BandedGridView3.FocusedColumn.Caption = "EMB Send" Or BandedGridView3.FocusedColumn.Caption = "EMB Receive" Or BandedGridView3.FocusedColumn.Caption = "Actual Cutting %" Then

            With frmCutting_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Picture" Then
            With frmPicture

                .StyleId = ReadIntegerData("Select Styleid From [Order] Where OrderId=" & row.OrderId, cnn)
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterParent
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Batch Qty" Then
            With frmBatch_mrf
                .MdiParent = frmMain
                .prProgramNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Dyeing Qty" Or BandedGridView3.FocusedColumn.Caption = "Dyeing Bal" Or BandedGridView3.FocusedColumn.Caption = "Dyeing Excess" Then
            With frmDyeing_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Grey EFR Qty" OrElse BandedGridView3.FocusedColumn.Caption = "Finish EFR Qty" Then

            With frmEFR_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Finish Fabric Receive Qty" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Receive Bal" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Del To Cutting" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Stock In Hand" Or BandedGridView3.FocusedColumn.Caption = "Finish Fabric Receive Excess" Then

            With frmFinishFabricReceiveIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Grey Fabric Receive Qty" Or BandedGridView3.FocusedColumn.Caption = "Grey Fabric Receive Bal" Or BandedGridView3.FocusedColumn.Caption = "Grey Issue Qty" Or BandedGridView3.FocusedColumn.Caption = "Grey Stock In Hand" Or BandedGridView3.FocusedColumn.Caption = "Grey Fabric Receive Excess" Then

            With frmGreyFabricReceiveIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Poly Qty" Then
            With frmFinishingPoly_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Knitting Order Qty" Or BandedGridView3.FocusedColumn.Caption = "Knitting Order Bal" Then

            With frmKnittingOrder_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Knitting Production" Or BandedGridView3.FocusedColumn.Caption = "Knitting Prod Amount TK" Or BandedGridView3.FocusedColumn.Caption = "Knitting Production Bal" Or BandedGridView3.FocusedColumn.Caption = "Knitting Prod Excess" Then

            With frmKnittingProduction_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Yarn Issue Qty" Or BandedGridView3.FocusedColumn.Caption = "Yarn Issue Bal" Or BandedGridView3.FocusedColumn.Caption = "Yarn Issue Excess" Then

            With frmYarnIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Fabric Receive By Cutting" Or BandedGridView3.FocusedColumn.Caption = "Fabric Receive Bal By Cutting" Or BandedGridView3.FocusedColumn.Caption = "Fabric Excess Receive By Cutting" Then

            With frmFinishFabricReceiveCutting_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Print Production Qty" Or BandedGridView3.FocusedColumn.Caption = "Print Production Bal" Then

            With frmPrint_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Embroidery Production Qty" Or BandedGridView3.FocusedColumn.Caption = "Embroidery Production Bal" Then

            With frmEmb_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Print Work Order Qty" Or BandedGridView3.FocusedColumn.Caption = "Print Work Order Bal" Then

            With frmPrintWorkOrder_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Embroidery Work Order Qty" Or BandedGridView3.FocusedColumn.Caption = "Embroidery Work Order Bal" Then

            With frmEmbWorkOrder_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Dyeing Finishing Qty" Or BandedGridView3.FocusedColumn.Caption = "Dyeing Finishing Bal" Or BandedGridView3.FocusedColumn.Caption = "Dyeing Finishing Excess" Then

            With frmDyeingFinishing_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Approved Sample No" Then

            With frmSample_mrf
                .MdiParent = frmMain
                .BookingNo = row.ApprovedSampleNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "Discount / Claim Amount $" Then

            With frmProgramFullAndFinal_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView3.FocusedColumn.Caption = "B. Yarn" Or BandedGridView3.FocusedColumn.Caption = "A. Yarn" Or BandedGridView3.FocusedColumn.Caption = "A. Knitting" Or BandedGridView3.FocusedColumn.Caption = "B. Knitting" Or BandedGridView3.FocusedColumn.Caption = "A. Dyeing" Or BandedGridView3.FocusedColumn.Caption = "B. Dyeing" Or BandedGridView3.FocusedColumn.Caption = "A. CM" Or BandedGridView3.FocusedColumn.Caption = "B. CM" Then

            With frmBudgetVsActual_Mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If


    End Sub

    Private Sub ExportExcelButton_Click(sender As Object, e As EventArgs)

        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Running Program List"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                If ProgramwiseRadioButton.Checked Then
                    MasterOrAndProdStatusPrgGridControl.ExportToXls(objSaveFileDialog.FileName)
                Else
                    MasterOrAndProdGridControl.ExportToXls(objSaveFileDialog.FileName)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        If ProgramwiseRadioButton.Checked Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            Using connection As New SqlConnection(cnn)
                connection.Open()
                Using sqlWrite = New SqlCommand("Exec dbo.OrderAndProductionStatusByOrderId @OrderId", connection)
                    sqlWrite.Parameters.Add("@OrderId", SqlDbType.BigInt).Value = ProgramNoGridLookUpEdit.EditValue
                    sqlWrite.ExecuteNonQuery()
                End Using
            End Using
            Me.MasterOrderAndProductionStatusPrgTableAdapter.FillByOID(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg, ProgramNoGridLookUpEdit.EditValue)
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True

            SplashScreenManager.CloseForm(False)
        Else
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            Me.MasterOrderAndProductionStatusTableAdapter.FillByOID(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus, Me.ProgramNoGridLookUpEdit.EditValue)
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            SplashScreenManager.CloseForm(False)
        End If

    End Sub

    Private Sub BandedGridView2_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles BandedGridView2.RowCellStyle
        Dim View As GridView = sender

        Dim ShortQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentShortQty"))
        ' Dim SSQty As Double = Convert.ToDouble(ShortQty)
        Dim PlusQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentExcessQty"))
        'Dim PSQty As Decimal = Convert.ToDecimal(PlusQty)
        Dim ShipQty As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ShipmentQuantity"))

        If e.Column.FieldName = "ShipmentShortQty" Then
            If ShortQty = ("0").ToString Then
                e.Appearance.ForeColor = Color.LightGray
            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.Red
            End If
        End If

        If e.Column.FieldName = "ShipmentExcessQty" Then
            If PlusQty = ("0").ToString Then
                e.Appearance.ForeColor = Color.LightGray
            Else
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            End If
        End If

        'If e.Column.FieldName = "ProgramNo" Then
        '    If ShipQty = ("0").ToString Then
        '        e.Appearance.ForeColor = Color.Blue
        '    Else
        '        e.Appearance.BackColor = Color.LightGreen
        '        e.Appearance.BackColor2 = Color.Green
        '    End If
        'End If

    End Sub

    Private Sub BandedGridView2_DoubleClick(sender As Object, e As EventArgs) Handles BandedGridView2.DoubleClick

        Dim row As MasterOrderAndProductionStatus.MasterOrderAndProductionStatusRow
        row = CType(CType(Me.MasterOrderAndProductionStatusBindingSource.Current, DataRowView).Row, MasterOrderAndProductionStatus.MasterOrderAndProductionStatusRow)

        If BandedGridView2.FocusedColumn.Caption = "Order Qty PCS" Or BandedGridView2.FocusedColumn.Caption = "Program No" Or BandedGridView2.FocusedColumn.Caption = "Buyer Order Amnd No" Or BandedGridView2.FocusedColumn.Caption = "Buyer Order Amnd Date" Or BandedGridView2.FocusedColumn.Caption = "Buyer" Or BandedGridView2.FocusedColumn.Caption = "Style" Or BandedGridView2.FocusedColumn.Caption = "Style Type" Or BandedGridView2.FocusedColumn.Caption = "Brand" Or BandedGridView2.FocusedColumn.Caption = "Division" Or BandedGridView2.FocusedColumn.Caption = "Season" Or BandedGridView2.FocusedColumn.Caption = "PO" Or BandedGridView2.FocusedColumn.Caption = "GMT Color" Or BandedGridView2.FocusedColumn.Caption = "Order Receive Date" Or BandedGridView2.FocusedColumn.Caption = "Min EX Date" Or BandedGridView2.FocusedColumn.Caption = "Max EX Date" Or BandedGridView2.FocusedColumn.Caption = "Print" Or BandedGridView2.FocusedColumn.Caption = "EMB" Or BandedGridView2.FocusedColumn.Caption = "AOP" Or BandedGridView2.FocusedColumn.Caption = "Wash" Or BandedGridView2.FocusedColumn.Caption = "YDS" Or BandedGridView2.FocusedColumn.Caption = "Brush" Or BandedGridView2.FocusedColumn.Caption = "Merchandiser" Then

            With frmOrderSheet_mrf

                .MdiParent = frmMain
                .OrderId = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Master Program No" Then

            With frmMasterOrder_mrf

                .MdiParent = frmMain
                .MOID = ReadIntegerData("Select MasterOrderId From MasterOrder Where MasterProgramNo='" & row.MasterProgramNo & "'", cnn)
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Running Program" Then

            frmOrderAndProductionStatusChart.OrderId = row.OrderId
            ShowForm(frmOrderAndProductionStatusChart)

        ElseIf BandedGridView2.FocusedColumn.Caption = "Is Fabric BOM Complete" Or BandedGridView2.FocusedColumn.Caption = "Amnd No" Or BandedGridView2.FocusedColumn.Caption = "Amnd Date" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Booking Qty" Or BandedGridView2.FocusedColumn.Caption = "Grey Fabric Booking Qty" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Booking Qty [BOM]" Or BandedGridView2.FocusedColumn.Caption = "G%" Or BandedGridView2.FocusedColumn.Caption = "Knitting Require with EFR Qty" Or BandedGridView2.FocusedColumn.Caption = "Yarn Require with EFR" Then

            With frmFabricBooking_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Finish Fabric Require" Or BandedGridView2.FocusedColumn.Caption = "Grey Fabric Require" Or BandedGridView2.FocusedColumn.Caption = "G %" Then

            With frmFinishFabricBookingReceive_mrf

                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With


        ElseIf BandedGridView2.FocusedColumn.Caption = "Is Acc BOM Complete" Or BandedGridView2.FocusedColumn.Caption = "Acc Amnd No" Or BandedGridView2.FocusedColumn.Caption = "Acc Amnd Date" Then

            With frmAccessoriesBooking_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Accessories Status [Receive/Issue]" Then

            With frmAccessories_Status_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Full Complete Date" Then

            With frmShipmentComplete_mrf
                .OrderId = row.OrderId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Shipment Qty" Or BandedGridView2.FocusedColumn.Caption = "Shipment Carton Qty" Or BandedGridView2.FocusedColumn.Caption = "Shipment Plus Qty" Or BandedGridView2.FocusedColumn.Caption = "Shipment Short Qty" Or BandedGridView2.FocusedColumn.Caption = "TTL Shipment $" Or BandedGridView2.FocusedColumn.Caption = "First Shipment Date" Or BandedGridView2.FocusedColumn.Caption = "Last Shipment Date" Then

            With frmShipment_mrf
                .OID = row.OrderId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Shipment Bal" Then

            With frmShipmentBalance_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With


        ElseIf BandedGridView2.FocusedColumn.Caption = "Poly Qty" Or BandedGridView2.FocusedColumn.Caption = "Finishing Input Qty" Or BandedGridView2.FocusedColumn.Caption = "Iron Qty" Or BandedGridView2.FocusedColumn.Caption = "Carton Qty" Or BandedGridView2.FocusedColumn.Caption = "Finishing WIP" Or BandedGridView2.FocusedColumn.Caption = "Hangtag Qty" Then

            With frmFinishingPoly_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Sewing Qty" Or BandedGridView2.FocusedColumn.Caption = "Sewing Input" Or BandedGridView2.FocusedColumn.Caption = "Sewing Input Bal" Or BandedGridView2.FocusedColumn.Caption = "Input %" Or BandedGridView2.FocusedColumn.Caption = "Sewing %" Or BandedGridView2.FocusedColumn.Caption = "Sewing Bal" Or BandedGridView2.FocusedColumn.Caption = "Sewing WIP" Or BandedGridView2.FocusedColumn.Caption = "Sewing Excess" Or BandedGridView2.FocusedColumn.Caption = "Sewing Input Excess" Then

            With frmSewing_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Cutting" Or BandedGridView2.FocusedColumn.Caption = "Cutting Bal" Or BandedGridView2.FocusedColumn.Caption = "Excess Cutting" Or BandedGridView2.FocusedColumn.Caption = "Cutting Input" Or BandedGridView2.FocusedColumn.Caption = "Cutting WIP" Or BandedGridView2.FocusedColumn.Caption = "Print Send" Or BandedGridView2.FocusedColumn.Caption = "Print Receive" Or BandedGridView2.FocusedColumn.Caption = "Print Receive Bal" Or BandedGridView2.FocusedColumn.Caption = "Print Supplier" Or BandedGridView2.FocusedColumn.Caption = "EMB Send" Or BandedGridView2.FocusedColumn.Caption = "EMB Receive" Or BandedGridView2.FocusedColumn.Caption = "Actual Cutting %" Then

            With frmCutting_mrf

                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Picture" Then
            With frmPicture

                .StyleId = ReadIntegerData("Select Styleid From [Order] Where OrderId=" & row.OrderId, cnn)
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterParent
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Batch Qty" Then
            With frmBatch_mrf
                .MdiParent = frmMain
                .prProgramNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Dyeing Qty" Or BandedGridView2.FocusedColumn.Caption = "Dyeing Bal" Or BandedGridView2.FocusedColumn.Caption = "Dyeing Excess" Then
            With frmDyeing_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Grey EFR Qty" OrElse BandedGridView2.FocusedColumn.Caption = "Finish EFR Qty" Then

            With frmEFR_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Finish Fabric Receive Qty" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Receive Bal" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Del To Cutting" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Stock In Hand" Or BandedGridView2.FocusedColumn.Caption = "Finish Fabric Receive Excess" Then

            With frmFinishFabricReceiveIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Grey Fabric Receive Qty" Or BandedGridView2.FocusedColumn.Caption = "Grey Fabric Receive Bal" Or BandedGridView2.FocusedColumn.Caption = "Grey Issue Qty" Or BandedGridView2.FocusedColumn.Caption = "Grey Stock In Hand" Or BandedGridView2.FocusedColumn.Caption = "Grey Fabric Receive Excess" Then

            With frmGreyFabricReceiveIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Poly Qty" Then
            With frmFinishingPoly_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Knitting Order Qty" Or BandedGridView2.FocusedColumn.Caption = "Knitting Order Bal" Then

            With frmKnittingOrder_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Knitting Production" Or BandedGridView2.FocusedColumn.Caption = "Knitting Prod Amount TK" Or BandedGridView2.FocusedColumn.Caption = "Knitting Production Bal" Or BandedGridView2.FocusedColumn.Caption = "Knitting Prod Excess" Then

            With frmKnittingProduction_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Yarn Issue Qty" Or BandedGridView2.FocusedColumn.Caption = "Yarn Issue Bal" Or BandedGridView2.FocusedColumn.Caption = "Yarn Issue Excess" Then

            With frmYarnIssue_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Fabric Receive By Cutting" Or BandedGridView2.FocusedColumn.Caption = "Fabric Receive Bal By Cutting" Or BandedGridView2.FocusedColumn.Caption = "Fabric Excess Receive By Cutting" Then

            With frmFinishFabricReceiveCutting_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()


            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Print Production Qty" Or BandedGridView2.FocusedColumn.Caption = "Print Production Bal" Then

            With frmPrint_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Embroidery Production Qty" Or BandedGridView2.FocusedColumn.Caption = "Embroidery Production Bal" Then

            With frmEmb_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Print Work Order Qty" Or BandedGridView2.FocusedColumn.Caption = "Print Work Order Bal" Then

            With frmPrintWorkOrder_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Embroidery Work Order Qty" Or BandedGridView2.FocusedColumn.Caption = "Embroidery Work Order Bal" Then

            With frmEmbWorkOrder_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Dyeing Finishing Qty" Or BandedGridView2.FocusedColumn.Caption = "Dyeing Finishing Bal" Or BandedGridView2.FocusedColumn.Caption = "Dyeing Finishing Excess" Then

            With frmDyeingFinishing_mrf
                .MdiParent = frmMain
                .PrgNo = row.ProgramNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Approved Sample No" Then

            With frmSample_mrf
                .MdiParent = frmMain
                .BookingNo = row.ApprovedSampleNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView2.FocusedColumn.Caption = "Discount / Claim Amount $" Then

            With frmProgramFullAndFinal_mrf
                .MdiParent = frmMain
                .OID = row.OrderId
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If

    End Sub


    Private Sub ToolTipController1_GetActiveObjectInfo(sender As Object, e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
        ''If e.SelectedControl <> MasterOrAndProdGridControl Then
        ''    Return
        ''End If
        'Dim view As GridView = TryCast(MasterOrAndProdGridControl.FocusedView, GridView)
        'Dim gridHitInfo As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
        'Dim o As Object = gridHitInfo.HitTest.ToString()
        'Dim text As String = gridHitInfo.HitTest.ToString()
        'e.Info = New ToolTipControlInfo(o, text)
    End Sub

    Private Sub MasterOrAndProdGridControl_Click(sender As Object, e As EventArgs) Handles MasterOrAndProdGridControl.Click

    End Sub

    Private Sub SaveLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SaveLinkLabel.LinkClicked

        MasterOrAndProdGridControl.MainView.SaveLayoutToRegistry(regKey)
        MasterOrAndProdStatusPrgGridControl.MainView.SaveLayoutToRegistry(regKey2)



    End Sub

    Private Sub BandedGridView2_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles BandedGridView2.CustomSummaryCalculate
        'Dim view As GridView = TryCast(sender, GridView)
        'Dim summaryID As Integer = Convert.ToInt32((TryCast(e.Item, GridSummaryItem)).Tag)

        'If e.SummaryProcess = CustomSummaryProcess.Start Then

        '    PrgCount = 0
        '    ProgNo = String.Empty

        'End If

        'If e.SummaryProcess = CustomSummaryProcess.Calculate Then

        '    Select Case summaryID

        '        Case 1
        '            If String.Compare(PrgNo, Convert.ToString(e.FieldValue)) = -1 Then
        '                PrgCount += 1
        '                ProgNo = Convert.ToString(e.FieldValue)
        '            End If
        '    End Select

        'End If

        'If e.SummaryProcess = CustomSummaryProcess.Finalize Then

        '    Select Case summaryID
        '        Case 1
        '            e.TotalValue = ReadIntData("SELECT Count(Distinct programNo) FROM MasterOrderAndProductionStatus WHERE IsRunning=1", cnn)
        '    End Select

        'End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Running Program List"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                If ProgramwiseRadioButton.Checked Then

                    MasterOrAndProdStatusPrgGridControl.ExportToXls(objSaveFileDialog.FileName)
                Else
                    MasterOrAndProdGridControl.ExportToXls(objSaveFileDialog.FileName)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub BandedGridView2_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles BandedGridView2.CustomColumnDisplayText
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If e.Column.FieldName = "DiscountOrClaimAmount" Then

            Dim price As Decimal = Convert.ToDecimal(e.Value)
            e.DisplayText = String.Format(ciUSA, "{0:c}", price)
        ElseIf e.Column.FieldName = "OrderAmount" Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            e.DisplayText = String.Format(ciUSA, "{0:c}", price)
        ElseIf e.Column.FieldName = "ShipmentAmount" Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            e.DisplayText = String.Format(ciUSA, "{0:c}", price)
        End If

    End Sub

    Private Sub ClearLayoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClearLayoutLinkLabel.LinkClicked

        'MasterOrAndProdGridControl.MainView.RestoreLayoutFromRegistry(OAPS_Color)
        'MasterOrAndProdStatusPrgGridControl.MainView.RestoreLayoutFromRegistry(OAPS_Program)
        MasterOrAndProdGridControl.MainView.RestoreLayoutFromRegistry(regKey)
        MasterOrAndProdStatusPrgGridControl.MainView.RestoreLayoutFromRegistry(regKey2)

    End Sub

    Private Sub ReGenLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReGenLinkLabel.LinkClicked

        LastUpdateLabel.Text = "Generating,please wait...."
        StatusFlag = False
        ShowRunningButton.Enabled = False
        ShowButton.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)


    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If StatusFlag = True Then
            ExecuteQuery("EXEC GenTempMOrAndProdStatusPrg 1", cnn)
        Else
            ExecuteQuery("EXEC GenTempMOrAndProdStatusPrg 0", cnn)
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)
        ShowRunningButton.Enabled = True
        ShowButton.Enabled = True
        'MessageBox.Show("Regeneration has been completed")


        If ProgramwiseRadioButton.Checked Then
            Me.MasterOrderAndProductionStatusPrgTableAdapter.SetCommandTimeOut(60000)
            Me.MasterOrderAndProductionStatusPrgTableAdapter.Fill(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg)
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
            LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)
        Else
            Me.MasterOrderAndProductionStatusTableAdapter.Fill(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus)
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
        End If

        SplashScreenManager.CloseForm(False)

    End Sub

    Private Sub CustomReportLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustomReportLinkLabel.LinkClicked

        Dim report As New XtraReport1
        Dim DesignTool As New ReportDesignTool(report)
        DesignTool.ShowDesignerDialog()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        If ProgramwiseRadioButton.Checked Then
            Me.MasterOrderAndProductionStatusPrgTableAdapter.SetCommandTimeOut(60000)
            Me.MasterOrderAndProductionStatusPrgTableAdapter.FillByAll(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg)
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
            LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)

        Else
            Me.MasterOrderAndProductionStatusTableAdapter.FillByAll(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus)
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
        End If

        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        If ProgramwiseRadioButton.Checked Then

            Me.MasterOrderAndProductionStatusPrgTableAdapter.SetCommandTimeOut(60000)
            Me.MasterOrderAndProductionStatusPrgTableAdapter.FillByRunningBlockOrder(Me.OrderAndProductionStatusDataSet.MasterOrderAndProductionStatusPrg)
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
            LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)

        Else

            Me.MasterOrderAndProductionStatusTableAdapter.FillByRunningBlockOrder(Me.MasterOrderAndProductionStatus._MasterOrderAndProductionStatus)
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False

        End If

        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub SaveAsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SaveAsLinkLabel.LinkClicked
        MasterOrAndProdGridControl.MainView.SaveLayoutToRegistry(OAPS_Color)
        MasterOrAndProdStatusPrgGridControl.MainView.SaveLayoutToRegistry(OAPS_Program)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        LastUpdateLabel.Text = "Generating,please wait...."
        StatusFlag = True
        ShowRunningButton.Enabled = False
        ShowButton.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked

        MasterOrAndProdGridControl.MainView.RestoreLayoutFromRegistry(OAPS_Color)
        MasterOrAndProdStatusPrgGridControl.MainView.RestoreLayoutFromRegistry(OAPS_Program)

    End Sub
End Class