Public Class frmBonusTopSheetGenerator

    Private Sub frmBonusTopSheetGenerator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.PictureBox1.Visible = True
    End Sub



    Private Sub frmBonusTopSheetGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BonusTopSheetNameLookupTableAdapter.Fill(Me.BonusDataSet.BonusTopSheetNameLookup)
        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)

        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.SewingLayoutTableAdapter1.Fill(Me.SewingLayoutLookupDataSet.SewingLayout)
        Me.SewingAttendanceTableAdapter.Fill(Me.BonusGenerationDataSet.SewingAttendance)
        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)

        'Dim dt As Date = "20-Feb-11"
        'Me.DateTimePicker1.Value = dt

        If CheckUserRights("Production Bonus Top Sheet").CanEdit = False Then
            AddButton.Enabled = False
            SaveButton.Enabled = False
            DeleteButton.Enabled = False

        ElseIf CheckUserRights("Production Bonus Top Sheet").CanDelete = False Then
            AddButton.Enabled = True
            SaveButton.Enabled = True
            DeleteButton.Enabled = False

        End If


    End Sub

    Private Sub CalculateProductionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateProductionButton.Click

        '=== Load If exist

        'On Error Resume Next




        'If SewingLayoutBindingSource.Position > -1 Then

        If DoubleLayoutCheckBox.Checked = True Then
            Me.SewingProductionTableAdapter.FillByDoubleLayout(Me.BonusGenerationDataSet.SewingProduction, LayoutIdGridLookUpEdit.EditValue, LayoutIdGridLookUpEdit3.EditValue)
            Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString & "+" & LayoutIdGridLookUpEdit3.Text.ToString)

        Else
            Me.SewingProductionTableAdapter.Fill(Me.BonusGenerationDataSet.SewingProduction, CType(LayoutIdGridLookUpEdit.EditValue, Integer))
            Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString)
        End If

        'Dim row As SewingLayoutDataSet.SewingLayoutRow
        'row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

        TargetLabel.Text = ReadData("Select TotalTargetQuantity From SewingLayout Where LayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)
        BonusTargetLabel.Text = ReadData("Select BonusTargetQuantity From SewingLayout Where LayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)
        OperatorLabel.Text = ReadData("Select MachineQuantity From SewingLayout Where LayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)
        HelperLabel.Text = ReadData("Select Helper From SewingLayout Where LayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)


        'End If


        If SewingProductionBindingSource.Position = -1 Then
            MessageBox.Show("Something wrong")
        End If

        '== Step2

        If BonusTopSheetBindingSource.Position = -1 Then

            MessageLabel.Text = "Starting  Generation.."

            Dim TotalProduction As Decimal = 0
            Dim TotalHour As Decimal = 0
            Dim i As Integer = 0


            Dim row As SewingLayoutDataSet.SewingLayoutRow
            row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

            Dim LastSewingDate As Date
            'Dim FirstSewingDate As Date = ReadDateData("Select Min(SewingDate)as MinSewingDate From Where SewinglayoutId=" & row.LayoutId, cnn)
            If DoubleLayoutCheckBox.Checked = True Then
                LastSewingDate = ReadDateData("Select Max(SewingDate) as MaxSewingDate From SewingProduction Where SewingLayoutId=" & LayoutIdGridLookUpEdit3.EditValue, cnn)
            Else
                LastSewingDate = ReadDateData("Select Max(SewingDate) as MaxSewingDate From SewingProduction Where SewingLayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)
            End If



            For Each dr As DataRowView In SewingProductionBindingSource.List
                MessageLabel.Text = "Started  Generation.."
                i += 1
                Dim newRow As BonusDataSet.BonusTopSheetRow = Me.BonusDataSet.BonusTopSheet.NewRow()

                'Calculate  Day Hour

                Dim H1 As Integer = ReadIntData(" Select 'H1'=CASE WHEN Sum(H1) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H2 As Integer = ReadIntData(" Select 'H2'=CASE WHEN Sum(H2) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H3 As Integer = ReadIntData(" Select 'H3'=CASE WHEN Sum(H3) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H4 As Integer = ReadIntData(" Select 'H4'=CASE WHEN Sum(H4) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H5 As Integer = ReadIntData(" Select 'H5'=CASE WHEN Sum(H5) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H6 As Integer = ReadIntData(" Select 'H6'=CASE WHEN Sum(H6) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H7 As Integer = ReadIntData(" Select 'H7'=CASE WHEN Sum(H7) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H8 As Integer = ReadIntData(" Select 'H8'=CASE WHEN Sum(H8) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H9 As Integer = ReadIntData(" Select 'H9'=CASE WHEN Sum(H9) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H10 As Integer = ReadIntData(" Select 'H10'=CASE WHEN Sum(H10) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H11 As Integer = ReadIntData(" Select 'H11'=CASE WHEN Sum(H11) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H12 As Integer = ReadIntData(" Select 'H12'=CASE WHEN Sum(H12) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H13 As Integer = ReadIntData(" Select 'HX'=CASE WHEN Sum(HX) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim HX As Integer = 0
                Dim HX2 As Integer = 0
                Dim FOT As Integer = 0 'First OT
                '==============
                'If H11 + H12 + H13 > 0 Then
                FOT = ReadData("Select Present3_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                HX = ReadData("Select Present4_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                HX2 = ReadData("Select Present5_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                'Else

                'HX = 0

                'End If
                '==============

                Dim TotalPresent As Integer = ReadIntData("Select Present2_Operator + Present2_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent3 As Integer = ReadIntData("Select Present3_Operator + Present3_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent4 As Integer = ReadIntData("Select Present4_Operator + Present4_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent5 As Integer = ReadIntData("Select Present5_Operator + Present5_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)

                newRow.LayoutId = dr!SewingLayoutId

                If DoubleLayoutCheckBox.Checked = True Then
                    newRow.BonusTopSheetName = LayoutIdGridLookUpEdit.Text.ToString & "+" & LayoutIdGridLookUpEdit3.Text.ToString
                Else
                    newRow.BonusTopSheetName = LayoutIdGridLookUpEdit.Text
                End If
                newRow.SewingDate = dr!SewingDate
                newRow.ProductionQuantity = dr!OutputQuantity
                newRow.LineId = dr!LineId
                newRow.LossHour = IIf(DBNull.Value.Equals(dr!LossHour), 0, dr!LossHour)
                newRow.General_Operator = ReadIntData("Select Present2_Operator From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.General_Helper = ReadIntData("Select Present2_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.FirstOT_Operator = ReadIntData("Select Present3_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.FirstOT_Helper = ReadIntData("Select Present3_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.SecondOT_Operator = ReadIntData("Select Present4_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.SecondOT_Helper = ReadIntData("Select Present4_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.Third_Operator = ReadIntData("Select Present5_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.Third_Helper = ReadIntData("Select Present5_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)

                Dim GeneralHour As Decimal = 0

                If i = 1 Or LastSewingDate = dr!SewingDate Then

                    'If dr!WorkingHour >= 8 Then
                    GeneralHour = H1 + H2 + H3 + H4 + H5 + H6 + H7 + H8
                    'End If

                Else
                    GeneralHour = 8
                End If


                If GeneralCheckBox.Checked Then
                    newRow.General = FormatNumber((TotalPresent * GeneralHour) / (row.MachineQuantity + row.Helper), 2)
                Else
                    newRow.General = GeneralHour
                End If

                newRow.General_WH = GeneralHour
                newRow.FirstOT = FormatNumber(((H9 + H10) * TotalPresent3) / (row.MachineQuantity + row.Helper), 2)
                newRow.FirstOT_WH = H9 + H10

                'If CheckBox1.Checked = True Then 'For Old Method.

                'newRow.SecondOT = FormatNumber((HX * TotalPresent4) / (row.MachineQuantity + row.Helper), 2)
                'newRow.SecondOT_WH = HX
                'newRow.Third_OT = 0
                'newRow.Third_WH = 0

                'Else 'For New Method.

                newRow.SecondOT = FormatNumber((H11 * TotalPresent4) / (row.MachineQuantity + row.Helper), 2)
                newRow.SecondOT_WH = H11

                If H12 + H13 > 0 Then
                    newRow.Third_OT = FormatNumber((HX2 * TotalPresent5) / (row.MachineQuantity + row.Helper), 2)
                    newRow.Third_WH = HX2
                Else
                    newRow.Third_OT = 0
                    newRow.Third_WH = 0
                End If

                'End If

                'If IsDBNull(dr!Remarks) = True Then
                '    newRow.Remarks = "-"
                'Else
                newRow.Remarks = ReadStringData("Select Remarks From SewingProduction Where SewingId=" & dr!SewingId, cnn)
                'End If

                newRow.UserId = UserId
                newRow.ModifiedDate = Today()

                Me.BonusDataSet.BonusTopSheet.Rows.Add(newRow)

                TotalProduction = TotalProduction + dr!OutputQuantity
                TotalProductionLabel.Text = TotalProduction

                TotalHour = TotalHour + newRow.TTLHour
                TotalHourLabel.Text = TotalHour

            Next


            MessageLabel.Text = "Completing Generation...."

            RefreshSummery()
        Else
            RefreshSummery()
        End If

        MessageLabel.Text = ""



    End Sub
    Private Sub RefreshSummery()

        On Error Resume Next


        If BonusTopSheetBindingSource.Position > -1 Then


            Dim TotalProduction As Decimal = 0
            Dim TotalHour As Decimal = 0


            For Each dr As DataRowView In BonusTopSheetBindingSource.List

                TotalProduction = TotalProduction + dr!ProductionQuantity
                TotalHour = TotalHour + IIf(DBNull.Value.Equals(dr!TTLHour), 0, dr!TTLHour)

            Next


            TotalProductionLabel.Text = TotalProduction
            TotalHourLabel.Text = TotalHour

            AvgProdPerHourLabel.Text = FormatNumber(Val(TotalProductionLabel.Text) / Val(TotalHourLabel.Text), 2)

            If Val(TargetLabel.Text) = 0 Then
                TargetPCLabel.Text = 0
            Else
                TargetPCLabel.Text = FormatNumber(Val(BonusTargetLabel.Text) - Val(TargetLabel.Text), 2)

            End If

            If FormatNumber(Val(AvgProdPerHourLabel.Text) - Val(TargetLabel.Text), 2) < 0 Then

                AchievementPCLabel.Text = 0

            Else
                AchievementPCLabel.Text = FormatNumber(Val(AvgProdPerHourLabel.Text) - Val(TargetLabel.Text), 2)

            End If

            AchievementPercentage.Text = FormatNumber(Val(AchievementPCLabel.Text) / Val(TargetPCLabel.Text) * 100, 2)

            If Val(AchievementPercentage.Text) <= 100 Then


                APMT100PLabel.Text = 0

            Else


                APMT100PLabel.Text = FormatNumber((Val(AchievementPercentage.Text) - 100), 2)

            End If

            If Val(AchievementPercentage.Text) >= 100 Then
                ''---------
                'MessageBox.Show(Val(AchievementPercentage.Text).ToString)
                ''---------
                BOThrsLTEQLabel.Text = FormatNumber(Val(TotalHourLabel.Text) * 0.2, 2)
            Else
                BOThrsLTEQLabel.Text = FormatNumber(Val(TotalHourLabel.Text) * 0.2 * Val(AchievementPercentage.Text) / 100, 2)
            End If


            'FormatNumber((Val(TotalHourLabel.Text) * (Val(APMT100PLabel.Text) / 100) * 0.2), 2) >= 0
            If Val(APMT100PLabel.Text) > 0 Then
                BOThrsGTLabel.Text = FormatNumber((Val(TotalHourLabel.Text) * (Val(APMT100PLabel.Text) / 100) * 0.2 * 2), 2)
            Else
                BOThrsGTLabel.Text = 0
            End If

            TotalBonusHourLabel.Text = Val(BOThrsLTEQLabel.Text) + Val(BOThrsGTLabel.Text)

            'Calculate Layout Efficiency =TTL Production * SMV/60/ManPower/TTLHour
            Dim row As SewingLayoutDataSet.SewingLayoutRow
            row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


            Dim LayoutEfficiency As Decimal = FormatNumber(TotalProduction * (row.TotalSMV_Machine + row.TotalSMV_Manual) / 60 / (row.MachineQuantity + row.Helper) / TotalHour, 2)
            LayoutEfficiencyLabel.Text = FormatPercent(LayoutEfficiency, 2)

        End If

        ChartControl1.RefreshData()


    End Sub

    Private Sub BonusTopSheetBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusTopSheetBindingSource.PositionChanged, BonusTopSheetBindingSource.CurrentChanged
        RefreshSummery()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Save()

        Me.BonusTopSheetNameLookupTableAdapter.Fill(Me.BonusDataSet.BonusTopSheetNameLookup)

        If DoubleLayoutCheckBox.Checked = True Then

            ExecuteQuery("Update BonusTopSheet Set TTLBonusHour=" & Val(TotalBonusHourLabel.Text) & "Where LayoutId in (" & LayoutIdGridLookUpEdit.EditValue & "," & LayoutIdGridLookUpEdit3.EditValue & ")", cnn)
            ExecuteQuery("Update SewingLayout Set AveragePerHour=" & Val(AvgProdPerHourLabel.Text) & "Where LayoutId in (" & LayoutIdGridLookUpEdit.EditValue & "," & LayoutIdGridLookUpEdit3.EditValue & ")", cnn)

        Else

            ExecuteQuery("Update BonusTopSheet Set TTLBonusHour=" & Val(TotalBonusHourLabel.Text) & "Where BonusTopSheetName='" & Me.BonusTopSheetNoGridLookUpEdit.Text & "'", cnn)
            ExecuteQuery("Update SewingLayout Set AveragePerHour=" & Val(AvgProdPerHourLabel.Text) & "Where LayoutId in (" & LayoutIdGridLookUpEdit.EditValue & ")", cnn)

        End If


    End Sub


    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        With frmSewingLayoutTopSheet

            .MIS = False
            .SewingLayoutId = LayoutIdGridLookUpEdit.EditValue
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub BandedGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged

        Dim row As BonusDataSet.BonusTopSheetRow
        row = CType(CType(Me.BonusTopSheetBindingSource.Current, DataRowView).Row, BonusDataSet.BonusTopSheetRow)

        'Dim row2 As SewingLayoutDataSet.SewingLayoutRow
        'row2 = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

        Dim MCQuantity As Integer = ReadData("Select MachineQuantity From SewingLayout Where LayoutId=" & row.LayoutId, cnn)
        Dim HLPQuantity As Integer = ReadData("Select Helper From SewingLayout Where LayoutId=" & row.LayoutId, cnn)



        If e.Column.Caption = "FWH" Then

            If DBNull.Value.Equals(row.FirstOT_WH) = False Then
                row.FirstOT = FormatNumber((row.FirstOT_WH * (row.FirstOT_Helper + row.FirstOT_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If

        ElseIf e.Column.Caption = "SWH" Then

            If DBNull.Value.Equals(row.SecondOT_WH) = False Then
                row.SecondOT = FormatNumber((row.SecondOT_WH * (row.SecondOT_Helper + row.SecondOT_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If

        ElseIf e.Column.Caption = "TWH" Then

            If DBNull.Value.Equals(row.Third_WH) = False Then
                row.Third_OT = FormatNumber((row.Third_WH * (row.Third_Helper + row.Third_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If

        ElseIf e.Column.Caption = "GWH" Then

            If DBNull.Value.Equals(row.Third_WH) = False Then

                If GeneralCheckBox.Checked = True Then
                    row.General = FormatNumber((row.General_WH * (row.General_Helper + row.General_Operator)) / (MCQuantity + HLPQuantity), 2)
                Else
                    row.General = row.General_WH
                End If

            End If

        End If


    End Sub

    Private Sub OTCalculate()

        If BonusTopSheetBindingSource.Position > -1 Then


            Dim row As BonusDataSet.BonusTopSheetRow
            row = CType(CType(Me.BonusTopSheetBindingSource.Current, DataRowView).Row, BonusDataSet.BonusTopSheetRow)

            Dim MCQuantity As Integer = ReadData("Select MachineQuantity From SewingLayout Where LayoutId=" & row.LayoutId, cnn)
            Dim HLPQuantity As Integer = ReadData("Select Helper From SewingLayout Where LayoutId=" & row.LayoutId, cnn)




            If DBNull.Value.Equals(row.FirstOT_WH) = False Then
                row.FirstOT = FormatNumber((row.FirstOT_WH * (row.FirstOT_Helper + row.FirstOT_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If


            If DBNull.Value.Equals(row.SecondOT_WH) = False Then
                row.SecondOT = FormatNumber((row.SecondOT_WH * (row.SecondOT_Helper + row.SecondOT_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If



            If DBNull.Value.Equals(row.Third_WH) = False Then
                row.Third_OT = FormatNumber((row.Third_WH * (row.Third_Helper + row.Third_Operator)) / (MCQuantity + HLPQuantity), 2)
            End If



            If DBNull.Value.Equals(row.Third_WH) = False Then

                If GeneralCheckBox.Checked = True Then
                    row.General = FormatNumber((row.General_WH * (row.General_Helper + row.General_Operator)) / (MCQuantity + HLPQuantity), 2)
                Else
                    row.General = row.General_WH
                End If

            End If

        End If

    End Sub

    Private Sub RecalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalculateButton.Click

        ''Saving before Recalculate 

        UpdateBonus()
        OTCalculate()
        RefreshSummery()


    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        For Each drv As DataRowView In BonusTopSheetBindingSource.List

            Dim row As BonusDataSet.BonusTopSheetRow
            row = CType(CType(Me.BonusTopSheetBindingSource.Current, DataRowView).Row, BonusDataSet.BonusTopSheetRow)

            row.ProductionMonthId = ProductionMonthComboBox.SelectedValue
            drv!ProductionMonthId = ProductionMonthComboBox.SelectedValue

        Next

    End Sub

    Private Sub Save()
        Try
            Me.Validate()
            Me.BonusTopSheetBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BonusDataSet)
            MessageBox.Show("Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If DBNull.Value.Equals(Me.BonusTopSheetNoGridLookUpEdit.EditValue) = False Then
            Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, BonusTopSheetNoGridLookUpEdit.EditValue)
        End If

        Dim PlusSignPos As Integer = BonusTopSheetNoGridLookUpEdit.Text.IndexOf("+")

        Dim Words As String() = BonusTopSheetNoGridLookUpEdit.Text.Split(New Char() {"+"c})

        Dim FirstLayoutNo As String = Words(0)
        Me.LayoutIdGridLookUpEdit.EditValue = ReadIntegerData("Select LayoutId From SewingLayout Where SewingLayoutNo='" & FirstLayoutNo.ToString & "'", cnn)

        If BonusTopSheetNoGridLookUpEdit.Text.Length > PlusSignPos AndAlso PlusSignPos > 0 Then
            Dim SecondLayoutNo As String = Words(1)
            Me.LayoutIdGridLookUpEdit3.EditValue = ReadIntegerData("Select LayoutId From SewingLayout Where SewingLayoutNo='" & SecondLayoutNo.ToString & "'", cnn)
        End If


        'Getting Information

        'If SewingLayoutBindingSource.Position > -1 Then

        'If DoubleLayoutCheckBox.Checked = True Then
        '    Me.SewingProductionTableAdapter.FillByDoubleLayout(Me.BonusGenerationDataSet.SewingProduction, LayoutIdGridLookUpEdit.EditValue, LayoutIdGridLookUpEdit3.EditValue)
        '    Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString & "+" & LayoutIdGridLookUpEdit3.Text.ToString)

        'Else
        '    Me.SewingProductionTableAdapter.Fill(Me.BonusGenerationDataSet.SewingProduction, CType(LayoutIdGridLookUpEdit.EditValue, Integer))
        '    Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString)
        'End If

        'Dim row As SewingLayoutDataSet.SewingLayoutRow
        'row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


        TargetLabel.Text = ReadData("Select TotalTargetQuantity From SewingLayout Where SewingLayoutNo='" & FirstLayoutNo.ToString & "'", cnn)



        BonusTargetLabel.Text = ReadData("Select BonusTargetQuantity From SewingLayout Where SewingLayoutNo='" & FirstLayoutNo.ToString & "'", cnn)


        OperatorLabel.Text = ReadData("Select MachineQuantity From SewingLayout Where SewingLayoutNo='" & FirstLayoutNo.ToString & "'", cnn)
        HelperLabel.Text = ReadData("Select Helper From SewingLayout Where SewingLayoutNo='" & FirstLayoutNo.ToString & "'", cnn)






    End Sub




    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click




        If Me.BonusTopSheetBindingSource.Position > -1 Then

            If DBNull.Value.Equals(Me.BonusTopSheetNoGridLookUpEdit.EditValue) = False Then

                If MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                    ExecuteQuery("Delete BonusTopSheet Where BonusTopSheetName='" & Me.BonusTopSheetNoGridLookUpEdit.EditValue & "'", cnn)
                    Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, BonusTopSheetNoGridLookUpEdit.EditValue)

                End If

            Else

                MessageBox.Show("Please, select a Bonus Sheet Name.", "Select..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BonusTopSheetNoGridLookUpEdit.Focus()


            End If

            BonusTopSheetNameLookupTableAdapter.Fill(Me.BonusDataSet.BonusTopSheetNameLookup)

            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK)

        End If



    End Sub

    Private Sub UpdateBonus()

        MessageLabel.Text = "Starting  Generation.."

        Dim TotalProduction As Decimal = 0
        Dim TotalHour As Decimal = 0
        Dim i As Integer = 0


        Dim row As SewingLayoutDataSet.SewingLayoutRow
        row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

        Dim LastSewingDate As Date
        'Dim FirstSewingDate As Date = ReadDateData("Select Min(SewingDate)as MinSewingDate From Where SewinglayoutId=" & row.LayoutId, cnn)
        If DoubleLayoutCheckBox.Checked = True Then

            LastSewingDate = ReadDateData("Select Max(SewingDate) as MaxSewingDate From SewingProduction Where SewingLayoutId=" & LayoutIdGridLookUpEdit3.EditValue, cnn)

            Me.SewingProductionTableAdapter.FillByDoubleLayout(Me.BonusGenerationDataSet.SewingProduction, LayoutIdGridLookUpEdit.EditValue, LayoutIdGridLookUpEdit3.EditValue)
            Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString & "+" & LayoutIdGridLookUpEdit3.Text.ToString)


        Else
            LastSewingDate = ReadDateData("Select Max(SewingDate) as MaxSewingDate From SewingProduction Where SewingLayoutId=" & LayoutIdGridLookUpEdit.EditValue, cnn)

            Me.SewingProductionTableAdapter.Fill(Me.BonusGenerationDataSet.SewingProduction, CType(LayoutIdGridLookUpEdit.EditValue, Integer))
            Me.BonusTopSheetTableAdapter.FillByBonusTopSheetNo(Me.BonusDataSet.BonusTopSheet, LayoutIdGridLookUpEdit.Text.ToString)

        End If



        For Each dr As DataRowView In SewingProductionBindingSource.List

            MessageLabel.Text = "Started  Generation.."
            i += 1



            If dr!SewingDate > ReadDateData("Select Max(SewingDate) as LastSewingDate From BonusTopSheet Where LayoutId=" & dr!SewingLayoutId, cnn) Then

                On Error Resume Next

                Dim newRow As BonusDataSet.BonusTopSheetRow = Me.BonusDataSet.BonusTopSheet.NewRow()

                'Calculate  Day Hour

                Dim H1 As Integer = ReadIntData(" Select 'H1'=CASE WHEN Sum(H1) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H2 As Integer = ReadIntData(" Select 'H2'=CASE WHEN Sum(H2) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H3 As Integer = ReadIntData(" Select 'H3'=CASE WHEN Sum(H3) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H4 As Integer = ReadIntData(" Select 'H4'=CASE WHEN Sum(H4) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H5 As Integer = ReadIntData(" Select 'H5'=CASE WHEN Sum(H5) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H6 As Integer = ReadIntData(" Select 'H6'=CASE WHEN Sum(H6) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H7 As Integer = ReadIntData(" Select 'H7'=CASE WHEN Sum(H7) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H8 As Integer = ReadIntData(" Select 'H8'=CASE WHEN Sum(H8) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H9 As Integer = ReadIntData(" Select 'H9'=CASE WHEN Sum(H9) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H10 As Integer = ReadIntData(" Select 'H10'=CASE WHEN Sum(H10) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H11 As Integer = ReadIntData(" Select 'H11'=CASE WHEN Sum(H11) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H12 As Integer = ReadIntData(" Select 'H12'=CASE WHEN Sum(H12) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim H13 As Integer = ReadIntData(" Select 'HX'=CASE WHEN Sum(HX) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId in (Select SewingId From SewingProduction Where SewingDate ='" & dr!SewingDate & "' And SewingLayoutId = " & dr!SewingLayoutId & ")", cnn)
                Dim HX As Integer = 0
                Dim HX2 As Integer = 0
                Dim FOT As Integer = 0 'First OT
                '==============
                'If H11 + H12 + H13 > 0 Then
                FOT = ReadData("Select Present3_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                HX = ReadData("Select Present4_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                HX2 = ReadData("Select Present5_Hour From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                'Else

                'HX = 0

                'End If
                '==============

                Dim TotalPresent As Integer = ReadIntData("Select Present2_Operator + Present2_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent3 As Integer = ReadIntData("Select Present3_Operator + Present3_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent4 As Integer = ReadIntData("Select Present4_Operator + Present4_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                Dim TotalPresent5 As Integer = ReadIntData("Select Present5_Operator + Present5_Helper as TotalPresent From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)

                newRow.LayoutId = dr!SewingLayoutId

                If DoubleLayoutCheckBox.Checked = True Then
                    newRow.BonusTopSheetName = LayoutIdGridLookUpEdit.Text.ToString & "+" & LayoutIdGridLookUpEdit3.Text.ToString
                Else
                    newRow.BonusTopSheetName = LayoutIdGridLookUpEdit.Text
                End If

                newRow.SewingDate = dr!SewingDate
                newRow.ProductionQuantity = dr!OutputQuantity
                newRow.LineId = dr!LineId
                newRow.LossHour = IIf(DBNull.Value.Equals(dr!LossHour), 0, dr!LossHour)
                newRow.General_Operator = ReadIntData("Select Present2_Operator From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.General_Helper = ReadIntData("Select Present2_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.FirstOT_Operator = ReadIntData("Select Present3_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.FirstOT_Helper = ReadIntData("Select Present3_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.SecondOT_Operator = ReadIntData("Select Present4_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.SecondOT_Helper = ReadIntData("Select Present4_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.Third_Operator = ReadIntData("Select Present5_Operator  From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)
                newRow.Third_Helper = ReadIntData("Select Present5_Helper From SewingAttendance Where AttendanceDate='" & dr!SewingDate & "' and LineId=" & dr!LineId, cnn)

                Dim GeneralHour As Decimal = 0

                If i = 1 Or LastSewingDate = dr!SewingDate Then

                    'If dr!WorkingHour >= 8 Then
                    GeneralHour = H1 + H2 + H3 + H4 + H5 + H6 + H7 + H8
                    'End If

                Else
                    GeneralHour = 8
                End If


                If GeneralCheckBox.Checked Then
                    newRow.General = FormatNumber((TotalPresent * GeneralHour) / (row.MachineQuantity + row.Helper), 2)
                Else
                    newRow.General = GeneralHour
                End If

                newRow.General_WH = GeneralHour
                newRow.FirstOT = FormatNumber(((H9 + H10) * TotalPresent3) / (row.MachineQuantity + row.Helper), 2)
                newRow.FirstOT_WH = H9 + H10

                'If CheckBox1.Checked = True Then 'For Old Method.

                'newRow.SecondOT = FormatNumber((HX * TotalPresent4) / (row.MachineQuantity + row.Helper), 2)
                'newRow.SecondOT_WH = HX
                'newRow.Third_OT = 0
                'newRow.Third_WH = 0

                'Else 'For New Method.

                newRow.SecondOT = FormatNumber((H11 * TotalPresent4) / (row.MachineQuantity + row.Helper), 2)
                newRow.SecondOT_WH = H11

                If H12 + H13 > 0 Then
                    newRow.Third_OT = FormatNumber((HX2 * TotalPresent5) / (row.MachineQuantity + row.Helper), 2)
                    newRow.Third_WH = HX2
                Else
                    newRow.Third_OT = 0
                    newRow.Third_WH = 0
                End If

                'End If

                'If IsDBNull(dr!Remarks) = True Then
                '    newRow.Remarks = "-"
                'Else
                newRow.Remarks = ReadStringData("Select Remarks From SewingProduction Where SewingId=" & dr!SewingId, cnn)
                'End If

                newRow.UserId = UserId
                newRow.ModifiedDate = Today()

                Me.BonusDataSet.BonusTopSheet.Rows.Add(newRow)


                TotalProduction = TotalProduction + dr!OutputQuantity
                TotalProductionLabel.Text = TotalProduction

                TotalHour = TotalHour + newRow.TTLHour
                TotalHourLabel.Text = TotalHour

            End If

        Next


        MessageLabel.Text = "Completing Generation...."

        RefreshSummery()


        MessageLabel.Text = ""



    End Sub


End Class