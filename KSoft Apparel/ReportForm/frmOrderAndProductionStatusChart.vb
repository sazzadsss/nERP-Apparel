Imports DevExpress.XtraCharts

Public Class frmOrderAndProductionStatusChart
    Private _OrderId As Integer

    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property

    Private Sub frmOrderAndProductionStatusChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderAndProductionDateStatusTableAdapter.FillByOrderId(Me.OrderAndProductionStatusDataSet.OrderAndProductionDateStatus, OrderId)
        Me.OrderAndProductionChartStatusTableAdapter.Fill(Me.OrderAndProductionStatusDataSet.OrderAndProductionChartStatus, OrderId)

    End Sub

    Private Sub ChartControl1_CustomDrawSeriesPoint(sender As Object, e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles ChartControl1.CustomDrawSeriesPoint
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

        e.Series.ArgumentDataMember.Contains("CuttingExcessQty")
        'Get the value at the current series point
        Dim val As Double = e.SeriesPoint(0)
        Dim ColorBar As String = Me.ChartControl1.Series(0).Points(7).Argument

        If e.Series.ArgumentDataMember.Contains("CuttingExcessQty") = True And e.SeriesPoint(0) > 0 Then
            options.Color2 = Color.Green
            drawOptions.Color = Color.LightGreen

            ' Me.ChartControl1.Series(0).Points(7).Color = Color.Green

        End If

    End Sub

    Private Sub ChartControl1_CustomDrawAxisLabel(sender As Object, e As CustomDrawAxisLabelEventArgs) Handles ChartControl1.CustomDrawAxisLabel
        Dim axis As AxisBase = e.Item.Axis


        If TypeOf axis Is AxisX Or TypeOf axis Is AxisX Or TypeOf axis Is RadarAxisX Then
            Dim axisValue As String = e.Item.AxisValue
            If (axisValue = "ShipmentExcessQty") Then
                e.Item.TextColor = Color.Green

            ElseIf (axisValue = "ShipmentShortQty") Then
                e.Item.TextColor = Color.Red
            End If
        End If
    End Sub
End Class