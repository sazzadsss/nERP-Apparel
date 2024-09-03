Imports DevExpress.XtraCharts

Public Class frmDashboard
    Sub New()

        InitializeComponent()


    End Sub

    Private Sub frmDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderBookingMasterByRcvDateTableAdapter.FillByYearAndWOAdv(Me.OrderBookingMasterDataSet.OrderBookingMasterByRcvDate, Year(Today))
        Me.MonthWiseShipment2TableAdapter.FillByYearAndIsAdvance(Me.MonthwiseShipmentDataSet.MonthWiseShipment2, Year(Today()), 0)
        Me.MonthwiseBookingAndShipmentTableAdapter.Fill(Me.MonthwiseBookingAndShipmentDataSet.MonthwiseBookingAndShipment)
        Me.SecwiseMonthlyProductionTableAdapter.Fill(Me.SecwiseMonthlyProductionDataSet.SecwiseMonthlyProduction, DateTimePicker1.Text)
        Me.MonthWiseShipmentTableAdapter.FillByYearAndIsAdvance(Me.MonthwiseShipmentDataSet.MonthWiseShipment, Year(Today()), 0)
        Me.OrderBookingMasterTableAdapter.FillByYear(Me.OrderBookingMasterDataSet.OrderBookingMaster)
        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        Me.SecwiseDailyProductionTableAdapter.Fill(Me.SecwiseDailyProductionDataSet.SecwiseDailyProduction, StartMonth, EndMonth)
        Timer1.Start()

        'Me.SplitContainer1.Panel1Collapsed = True
        'Me.SplitContainer1.Panel2Collapsed = False

    End Sub



    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

    '    'Declare a SaveFileDialog object
    '    Dim objSaveFileDialog As New SaveFileDialog

    '    'Set the Save dialog properties
    '    With objSaveFileDialog
    '        .DefaultExt = "xls"
    '        .FileName = "Program List"
    '        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
    '        .FilterIndex = 1
    '        .OverwritePrompt = True
    '        .Title = "Save File Dialog"
    '    End With

    '    'Show the Save dialog and if the user clicks the Save button,
    '    'save the file
    '    If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


    '        Try

    '            GridControl1.ExportToXls(objSaveFileDialog.FileName)


    '        Catch ex As Exception

    '            MessageBox.Show(ex.Message)

    '        End Try



    '    End If

    '    'Clean up
    '    objSaveFileDialog.Dispose()
    '    objSaveFileDialog = Nothing
    'End Sub


    Private Sub FabBOMPendingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.AccAndFabBOMStatusTableAdapter.Fill(Me.AccAndFabBOMStatusDataSet.AccAndFabBOMStatus)

        'Me.OrderBookingMasterTableAdapter.Fill(Me.OrderBookingMasterDataSet.OrderBookingMaster)

        'Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        'Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        'Me.SecwiseDailyProductionTableAdapter.Fill(Me.SecwiseDailyProductionDataSet.SecwiseDailyProduction, StartMonth, EndMonth)


        Me.SplitContainer1.Panel1Collapsed = False
        Me.SplitContainer1.Panel2Collapsed = True


    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Dim dt As Date = DateTimePicker1.Value
        Dim StartMonth As Date = DateSerial(Year(dt), Month(dt), 1)
        Dim EndMonth As Date = DateSerial(Year(dt), Month(dt) + 1, 0)

        Me.SecwiseDailyProductionTableAdapter.Fill(Me.SecwiseDailyProductionDataSet.SecwiseDailyProduction, StartMonth, EndMonth)
        Me.MonthWiseShipmentTableAdapter.FillByYearAndIsAdvance(Me.MonthwiseShipmentDataSet.MonthWiseShipment, dt.Year(), 0)
        Me.MonthwiseBookingAndShipmentTableAdapter.Fill(Me.MonthwiseBookingAndShipmentDataSet.MonthwiseBookingAndShipment)
        Me.SecwiseMonthlyProductionTableAdapter.Fill(Me.SecwiseMonthlyProductionDataSet.SecwiseMonthlyProduction, DateTimePicker1.Text)
        Me.OrderBookingMasterByRcvDateTableAdapter.FillByYearAndWOAdv(Me.OrderBookingMasterDataSet.OrderBookingMasterByRcvDate, Year(DateTimePicker1.Text))
        Me.MonthWiseShipment2TableAdapter.FillByYearAndIsAdvance(Me.MonthwiseShipmentDataSet.MonthWiseShipment2, Year(Today()), 0)

    End Sub


    Private Sub RepositoryItemHyperLinkEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemHyperLinkEdit1.Click

        Dim row As AccAndFabBOMStatusDataSet.AccAndFabBOMStatusRow
        row = CType(CType(Me.AccAndFabBOMStatusBindingSource.Current, DataRowView).Row, AccAndFabBOMStatusDataSet.AccAndFabBOMStatusRow)

        frmOrderPrint.OrderId = row.OrderId
        blnMIS = False
        ShowForm(frmOrderPrint)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SplitContainer1.Panel1Collapsed = True
        Me.SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub ChartControl1_CustomDrawSeriesPoint(ByVal sender As System.Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles ChartControl1.CustomDrawSeriesPoint
        'These changes will be applied to bar Series Only

        Dim drawOptions = CType(e.SeriesDrawOptions, BarDrawOptions)

        If drawOptions Is Nothing Then
            Return
        End If

        'Get the fill options for the series point
        drawOptions.FillStyle.FillMode = FillMode.Gradient
        Dim options = CType(drawOptions.FillStyle.Options, RectangleGradientFillOptions)
        If options Is Nothing Then
            Return
        End If
        'Get the value at the current series point
        Dim val As Double = e.SeriesPoint(0)
        Dim sname As String = e.Series.Name
        'If the value is less the 2.5 , then fill the bar with green colors
        'Red 255,0,0 Yellow 255,255,0 Blue 0,0,255

        If sname = "By Quantity" Then

            If val > 2200000 * 1.15 Then 'Over Booking
                options.Color2 = Color.FromArgb(255, 0, 0)
                drawOptions.Color = Color.FromArgb(255, 0, 0)
            ElseIf val <= 2200000 * 1.15 And val >= 1400000 * 0.85 Then 'Perfect
                options.Color2 = Color.FromArgb(0, 255, 0)
                drawOptions.Color = Color.FromArgb(0, 255, 0)

            ElseIf val < 2200000 * 0.85 Then 'Short
                options.Color2 = Color.FromArgb(255, 255, 0)
                drawOptions.Color = Color.FromArgb(255, 255, 0)

            End If

        ElseIf sname = "By Amount" Then

            If val >= 4200000 * 0.85 Then 'Perfect
                options.Color2 = Color.FromArgb(0, 255, 0)
                drawOptions.Color = Color.FromArgb(0, 255, 0)

            ElseIf val < 3000000 * 0.85 Then 'Short
                options.Color2 = Color.FromArgb(255, 0, 0)
                drawOptions.Color = Color.FromArgb(255, 0, 0)

            End If

        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        UnitLabel.Location = New Point(UnitLabel.Location.X + 2, UnitLabel.Location.Y)
        If (UnitLabel.Location.X + UnitLabel.Width > Me.Width) Then
            Timer2.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClockLabel.Text = TimeOfDay

        Static mCount As Long
        mCount = mCount + 1
        If mCount >= SpinEdit1.Value * 60 Then

            Dim dt As Date = DateTimePicker1.Value
            Dim StartMonth As Date = DateSerial(Year(dt), Month(dt), 1)
            Dim EndMonth As Date = DateSerial(Year(dt), Month(dt) + 1, 0)

            Me.SecwiseDailyProductionTableAdapter.Fill(Me.SecwiseDailyProductionDataSet.SecwiseDailyProduction, StartMonth, EndMonth)
            Me.MonthWiseShipmentTableAdapter.Fill(Me.MonthwiseShipmentDataSet.MonthWiseShipment, dt.Year())
            Me.MonthwiseBookingAndShipmentTableAdapter.Fill(Me.MonthwiseBookingAndShipmentDataSet.MonthwiseBookingAndShipment)
            Me.SecwiseMonthlyProductionTableAdapter.Fill(Me.SecwiseMonthlyProductionDataSet.SecwiseMonthlyProduction, DateTimePicker1.Text)


            mCount = 1

        End If
    End Sub
End Class