Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Public Class frmSewingPlanningReport

    Dim regKey As String = "DevExpress\XtraGrid\Layouts\MainLayout"
    'Dim fileName As String = System.AppDomain.CurrentDomain.BaseDirectory() & "\Layout\OrderTrackingSheetColorwise.xml"

    Public Sub New()
        InitializeComponent()


        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select StyleType,ColorCode From StyleTypeMst", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection
        Dim i As Integer = 0

        While reader.Read

            If reader.IsDBNull(0) = False Then

                Dim PivotGridFormatRule As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
                Dim FormatConditionRuleExpression As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
                Dim FormatRuleTotalTypeSettings As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()

                PivotGridFormatRule.Enabled = True
                PivotGridFormatRule.Measure = Me.fieldPlanQuantity1
                'PivotGridFormatRule5.Name = "Format4"
                FormatConditionRuleExpression.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(reader("ColorCode").ToString())
                FormatConditionRuleExpression.Appearance.ForeColor = System.Drawing.Color.Black
                FormatConditionRuleExpression.Appearance.Options.UseBackColor = True
                FormatConditionRuleExpression.Appearance.Options.UseForeColor = True
                FormatConditionRuleExpression.Expression = "[StyleType] = '" & reader("StyleType") & "'"
                PivotGridFormatRule.Rule = FormatConditionRuleExpression
                FormatRuleTotalTypeSettings.ApplyToCustomTotalCell = False
                FormatRuleTotalTypeSettings.ApplyToGrandTotalCell = False
                FormatRuleTotalTypeSettings.ApplyToTotalCell = False
                PivotGridFormatRule.Settings = FormatRuleTotalTypeSettings

                Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule)
                i += 1

            End If

        End While

        reader.Close()
        connection.Close()


    End Sub
    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.PlanningReportTableAdapter.Fill(Me.SplitAppointmentDataSet.PlanningReport, DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub

    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click

        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Sewing Planning Report"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                PivotGridControl1.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing


    End Sub

    Private Sub PivotGridControl1_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance

        'Dim PivotGridFormatRule5 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        'Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        'Dim FormatRuleTotalTypeSettings5 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()

        'PivotGridFormatRule5.Measure = Me.fieldAchivement1
        'PivotGridFormatRule5.Name = "Format4"
        'FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Navy
        'FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White
        'FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        'FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        'FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        'FormatConditionRuleValue3.Expression = "[StyleType]"
        'FormatConditionRuleValue3.Value1 = "T-Shirt"
        'PivotGridFormatRule5.Rule = FormatConditionRuleValue3
        'PivotGridFormatRule5.Settings = FormatRuleTotalTypeSettings5
        'Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule5)


    End Sub

    Private Sub frmSewingPlanningReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        firstDay = New DateTime(Today.Year, Today.Month, 1)
        lastDay = firstDay.AddMonths(1).AddDays(-1)
        DateTimePicker1.Text = firstDay
        DateTimePicker2.Text = lastDay
        Me.PlanningReportTableAdapter.Fill(Me.SplitAppointmentDataSet.PlanningReport, DateTimePicker1.Text, DateTimePicker2.Text)
        PivotGridControl1.RestoreLayoutFromRegistry(regKey)


    End Sub

    Private Sub PivotGridControl1_CustomDrawCell(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles PivotGridControl1.CustomDrawCell

        'Dim r As Rectangle

        '' Paints Row Grand Totals.
        ''If e.RowValueType = PivotGridValueType.GrandTotal Then
        ''    e.GraphicsCache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.LightBlue,
        ''       Color.Blue, LinearGradientMode.Vertical), e.Bounds)
        ''    r = Rectangle.Inflate(e.Bounds, -3, -3)
        ''    e.GraphicsCache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.Blue,
        ''       Color.LightSkyBlue, LinearGradientMode.Vertical), r)
        ''    e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font, New SolidBrush(Color.White),
        ''       r, e.Appearance.GetStringFormat())
        ''    e.Handled = True
        ''    Exit Sub
        ''End If

        '' Paints the data cells.
        'Dim backBrush As Brush
        'r = e.Bounds

        'If e.Focused Then
        '    ' Initializes the brush used to paint the focused cell.
        '    backBrush = e.GraphicsCache.GetSolidBrush(Color.Pink)
        'ElseIf e.Selected Then
        '    ' Initializes the brush used to paint selected cells.
        '    backBrush = e.GraphicsCache.GetSolidBrush(Color.PaleGreen)
        'Else
        '    ' Initializes the brush used to paint data cells.
        '    backBrush = e.GraphicsCache.GetSolidBrush(Color.LemonChiffon)
        'End If

        'e.GraphicsCache.DrawRectangle(New Pen(New SolidBrush(Color.DimGray), 1), r)
        'r.Inflate(-1, -1)
        'e.GraphicsCache.FillRectangle(backBrush, r)
        'e.Appearance.DrawString(e.GraphicsCache, e.DisplayText, r)

        'e.Handled = True

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub SaveLayoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SaveLayoutLinkLabel.LinkClicked
        PivotGridControl1.SaveLayoutToRegistry(regKey)
    End Sub
End Class