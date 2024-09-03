Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Public Class frmSewingBreakDown
    Dim TotalProcess As Integer = 0
    Dim TotalWS As Integer = 0
    Dim TackTime As Decimal = 0
    Dim TotalSMV As Decimal = 0
    Dim LowerLevel As Decimal = 0
    Dim UpperLevel As Decimal = 0
    Dim Ratio As Integer = 100
    Dim ZeroLevel As Integer = 180
    Dim TTLLayoutTime As Decimal = 0
    Dim BottleNeck As Decimal = 0
    Dim MinCapacity As Integer = 0
    Dim BottleNeckMachine As Integer = 0

    'Dim temp As NumericUpDown()

    Private _StyleId As Integer
    Public Property StyleId() As Integer
        Get
            Return _StyleId
        End Get
        Set(ByVal value As Integer)
            _StyleId = value
        End Set
    End Property
    Private _SewingLayoutId As Integer
    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property

    Private _SewingSMVId As Integer
    Public Property SewingSMVId() As Integer
        Get
            Return _SewingSMVId
        End Get
        Set(ByVal value As Integer)
            _SewingSMVId = value
        End Set
    End Property

    Private _AmendmentNo As Integer
    Public Property AmendmentNo() As Integer
        Get
            Return _AmendmentNo
        End Get
        Set(ByVal value As Integer)
            _AmendmentNo = value
        End Set
    End Property

    Private _PType As String
    Public Property PType() As String
        Get
            Return _PType
        End Get
        Set(ByVal value As String)
            _PType = value
        End Set
    End Property

    Private _TotalSMVFSL As Decimal 'FSL=From Sewing Layout
    Public Property TotalSMVFST() As Decimal
        Get
            Return _TotalSMVFSL
        End Get
        Set(ByVal value As Decimal)
            _TotalSMVFSL = value
        End Set
    End Property

    Private _MachineSMV As Decimal
    Public Property MachineSMV() As Decimal
        Get
            Return _MachineSMV
        End Get
        Set(ByVal value As Decimal)
            _MachineSMV = value
        End Set
    End Property

    Private _PcsInBundle As Integer
    Public Property PcsInBundle() As Integer
        Get
            Return _PcsInBundle
        End Get
        Set(ByVal value As Integer)
            _PcsInBundle = value
        End Set
    End Property

    Private _TotalLayoutTime As String
    Public Property TotaLayoutTime() As String
        Get
            Return _TotalLayoutTime
        End Get
        Set(ByVal value As String)
            _TotalLayoutTime = value
        End Set
    End Property


    Private Sub frmSewingBreakDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingLayoutNoLabel.Text = "Sewing Layout No  : " & ReadStringData("Select SewingLayoutNo from SewingLayout Where LayoutId=" & SewingLayoutId, cnn)
        Me.ProcessTypeLabel.Text = "ProcessType   : " & Me.PType.ToString
        Me.AmendmentNoLabel.Text = "Amendment No  : " & Me.AmendmentNo.ToString

        If Me.PType = "All" Then
            Me.SewingSMVTableAdapter.FillBy(Me.SewingLayoutDataSet.SewingSMV, Me.StyleId, Me.AmendmentNo)
            Me.SewingBreakDownTableAdapter.FillByAll(Me.SewingLayoutDataSet.SewingBreakDown, Me.SewingLayoutId)
        Else
            Me.SewingSMVTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingSMV, Me.StyleId, PType, Me.AmendmentNo)
            Me.SewingBreakDownTableAdapter.Fill(Me.SewingLayoutDataSet.SewingBreakDown, Me.SewingLayoutId, Me.PType)
        End If

        Me.SewingSMVViewTableAdapter.FillByLayoutId(Me.SewingLayoutDataSet.SewingSMVView, Me.SewingLayoutId)


        Dim i As Integer = 1

        If Me.SewingBreakDownBindingSource.Position = -1 Then

            For Each dr As DataRowView In Me.SewingSMVBindingSource.List

                Dim NewRow As SewingLayoutDataSet.SewingBreakDownRow = Me.SewingLayoutDataSet.SewingBreakDown.NewRow()


                TotalSMV = TotalSMV + dr!SMV

                NewRow.SLNo = i

                NewRow.SewingLayoutId = Me.SewingLayoutId
                NewRow.SewingSMVId = dr!SewingSMVId
                NewRow.SMV = dr!SMV
                NewRow.WorkStationQuantity = 1
                NewRow.SMV_PerMachine = dr!SMV / NewRow.WorkStationQuantity
                NewRow.TackTime = 1
                NewRow.LOWER_LEVEL = 1
                NewRow.UPPER_LEVEL = 1
                NewRow.Process_Type = dr!Process_Type
                NewRow.Capacity = dr!Capacity
                NewRow.LayoutTime = FormatNumber(dr!SMV * Me.PcsInBundle / ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=1", cnn), 2)

                'MessageBox.Show(dr!SewingSMVId & "/" & dr!SMV)

                i += 1

                Me.SewingLayoutDataSet.SewingBreakDown.Rows.Add(NewRow)


            Next

            TotalProcess = i - 1
            TotalWS = i - 1

            If TotalWS > 0 Then
                TackTime = TotalSMV / TotalWS
            Else
                TackTime = 0
            End If



        Else


            TotalProcess = Me.SewingBreakDownBindingSource.Count

            'Calculate Tack-Time and Total Machine
            TotalWS = 0
            TotalSMV = 0
            TTLLayoutTime = 0

            For Each drv As DataRowView In SewingBreakDownBindingSource.List

                TotalWS = TotalWS + drv!WorkStationQuantity
                TotalSMV = TotalSMV + IIf(IsDBNull(drv!SMV) = True, 0, drv!SMV)
                drv!LayoutTime = FormatNumber(drv!SMV * Me.PcsInBundle / ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=1", cnn), 2)
                TTLLayoutTime = TTLLayoutTime + drv!LayoutTime

            Next

            WSLabel.Text = TotalWS
            SMVLabel.Text = Me.MachineSMV
            LayoutTimeLabel.Text = DectoTimeString(TTLLayoutTime)

            TackTime = TotalSMV / TotalWS



        End If


        UpperLevelPB.Visible = False
        LowerLebelPB.Visible = False
        TackTimeLevelPB.Visible = False
        i = 0
        While i <= 100 'Use Any Suitable Maximum Value

            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls("Bar" & i.ToString))
            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls(i.ToString))
            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls("Label" & i.ToString))

            i += 1

        End While

        UpperLevelPB.Visible = True
        LowerLebelPB.Visible = True
        TackTimeLevelPB.Visible = True
        TackTimeLevelPB.Top = ZeroLevel - TackTime * Ratio
        TackTimeLebel.Text = FormatNumber(TackTime, 2)

        LowerLevel = TackTime * 0.8
        UpperLevel = TackTime * 1.2

        LowerLabel.Text = FormatNumber(LowerLevel, 2)
        UpperLabel.Text = FormatNumber(UpperLevel, 2)

        LowerLebelPB.Top = ZeroLevel - LowerLevel * Ratio
        UpperLevelPB.Top = ZeroLevel - UpperLevel * Ratio

        'Average Target

        'ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=1,cnn)


        'ATEVALUE.Text = FormatNumber((TotalWS * 60) / MachineSMV * ReadData("Select NumberValue From Parameter Where PrameterId=3", cnn), 0)
        If MachineSMV > 0 Then
            ATEVALUE.Text = FormatNumber((TotalWS * 60) / MachineSMV * ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=10", cnn), 0)
        Else
            ATEVALUE.Text = 0
        End If

        If Me.PType = "All" Then
            BOTTLENECKLabel.Text = ReadData("Select Max(SMV_PerMachine) from SewingBreakDown Where SewingLayoutId=" & Me.SewingLayoutId, cnn)
            MinCapacity = ReadIntData("Select Min(Capacity) From SewingBreakdown Where SewingLayoutId=" & Me.SewingLayoutId, cnn)
        Else
            BOTTLENECKLabel.Text = ReadData("Select Max(SMV_PerMachine) from SewingBreakDown Where SewingLayoutId=" & Me.SewingLayoutId & "And Process_Type='" & Me.PType & "'", cnn)
        End If



        Dim BottleNeckMachine As Integer = Format(ReadData("Select Max(WorkStationQuantity) From SewingBreakDown Where SMV_PerMachine=" & Val(BOTTLENECKLabel.Text) & " And SewingLayoutId=" & Me.SewingLayoutId, cnn), 0)

        BottleNeckMCLabel.Text = BottleNeckMachine.ToString
        If Val(BOTTLENECKLabel.Text) > 0 Then
            Me.BottleNeckProductionLabel.Text = FormatNumber((1 * 60) / Val(BOTTLENECKLabel.Text) * ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=10", cnn), 0)
        Else
            Me.BottleNeckProductionLabel.Text = 0
        End If



        AddControl(TotalProcess)


        'Resize
        i = 1

        While i < Me.SewingBreakDownBindingSource.Count + 1



            Me.SewingBreakDownBindingSource.Position = i - 1

            Dim row As SewingLayoutDataSet.SewingBreakDownRow
            row = CType(CType(Me.SewingBreakDownBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingBreakDownRow)

            Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Size = New System.Drawing.Size(40, Ratio * row.SMV_PerMachine)
            Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Top = ZeroLevel - Ratio * row.SMV_PerMachine
            Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Refresh()

            CType(Me.XtraScrollableControl1.Controls(i.ToString), NumericUpDown).Value = row.WorkStationQuantity


            i += 1

        End While


        UpperLevelPB.SendToBack()
        LowerLebelPB.SendToBack()
        TackTimeLevelPB.SendToBack()





    End Sub


    Public Sub AddControl(ByVal PN As Integer)

        Me.AutoScroll = True

        Dim temp As NumericUpDown() = New NumericUpDown(PN) {}
        Dim temppic As DevExpress.XtraEditors.PictureEdit() = New DevExpress.XtraEditors.PictureEdit(PN) {}
        Dim temp2 As System.Windows.Forms.Label() = New System.Windows.Forms.Label(PN) {}


        Dim CNT As Integer = 1
        Dim X As Integer = 30
        Dim Y As Integer = ZeroLevel




        While CNT <= PN

            temp(CNT) = New NumericUpDown
            temp(CNT).Name = CNT
            temp(CNT).Location = New System.Drawing.Point(X, Y)
            'temp(CNT).Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
            temp(CNT).Size = New System.Drawing.Size(40, 20)
            'temp(CNT).TextAlign = ContentAlignment.MiddleCenter
            temp(CNT).ForeColor = System.Drawing.Color.Black
            temp(CNT).BackColor = System.Drawing.Color.LightSalmon
            temp(CNT).Font = New System.Drawing.Font("Arial", 7)
            temp(CNT).Value = 1
            temp(CNT).Minimum = 0.1
            temp(CNT).Increment = 0.1
            temp(CNT).DecimalPlaces = 2
            'temp(CNT).Text = "DYNAMIC LABEL NO" & CNT + 1


            temppic(CNT) = New DevExpress.XtraEditors.PictureEdit
            temppic(CNT).Name = "Bar" & CNT
            'temp(CNT).Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
            temppic(CNT).Size = New System.Drawing.Size(40, 50)

            temppic(CNT).Location = New System.Drawing.Point(X, Y - temppic(CNT).Height)
            'temp(CNT).TextAlign = ContentAlignment.MiddleCenter
            temppic(CNT).ForeColor = System.Drawing.Color.LightSalmon
            temppic(CNT).BackColor = System.Drawing.Color.LightSalmon
            temppic(CNT).Properties.NullText = ""

            'temp(CNT).Text = "DYNAMIC LABEL NO" & CNT + 1

            'Initialize Label
            temp2(CNT) = New System.Windows.Forms.Label
            temp2(CNT).Name = "Label" & CNT
            temp2(CNT).Location = New System.Drawing.Point(X, Y + 20)
            temp2(CNT).Size = New System.Drawing.Size(40, 20)
            temp2(CNT).TextAlign = ContentAlignment.MiddleCenter
            temp2(CNT).ForeColor = System.Drawing.Color.Black
            temp2(CNT).BackColor = System.Drawing.Color.LightSkyBlue
            temp2(CNT).Text = "P:" & CNT



            Me.XtraScrollableControl1.Controls.Add(temppic(CNT))
            Me.XtraScrollableControl1.Controls.Add(temp(CNT))
            Me.XtraScrollableControl1.Controls.Add(temp2(CNT))
            'AddHandler temp(CNT).ValueChanged, AddressOf NumericUpDown1_ValueChanged
            'AddHandler .Click, AddressOf Me.btnTestNumButtons_Click
            AddHandler temp(CNT).ValueChanged, AddressOf temp_ValueChanged
            AddHandler temppic(CNT).Click, AddressOf temppic_Click

            CNT += 1

            X = X + 50



        End While

    End Sub

    Private Sub temp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Dim i As Integer
        'For i = 0 To Me.Controls.Count - 1
        '    Console.WriteLine(Me.Controls(i).ToString)
        '    If Me.Controls(i).GetType Is GetType(System.Windows.Forms.Panel) Then
        '        Dim j As Integer
        '        For j = 0 To Me.Controls(i).Controls.Count - 1

        '            'Console.WriteLine(Me.Controls(i).Controls(j).ToString)
        '        Next
        '    End If
        'Next


        'If Me.Controls(3).GetType Is GetType(System.WinForms.TextBox) Then
        '    MsgBox("It’s a TextBox control")
        'End If

        'Dim TB As Control
        'Dim Sum As Double = 0, points As Integer = 0
        'For Each TB In Me.Controls
        '    If TB.GetType Is GetType(Windows.Forms.NumericUpDown) Then
        '        If CType(TB, NumericUpDown).Name).Name ="MYNUD1" Then
        '            Sum = Sum + CType(TB, TextBox).Text
        '            points = points + 1
        '        End If
        '    End If
        'Next

        Dim i As Integer = 1

        While i <= TotalProcess

            If Me.XtraScrollableControl1.Controls(i.ToString).Focused = True Then

                'MsgBox(Me.XtraScrollableControl1.Controls(i.ToString).Name)

                Dim MachineOnProcess As Double
                MachineOnProcess = CType(Me.XtraScrollableControl1.Controls(i.ToString), NumericUpDown).Value     'Convert to get particular type data

                Me.SewingBreakDownBindingSource.Position = i - 1
                Dim row As SewingLayoutDataSet.SewingBreakDownRow
                row = CType(CType(Me.SewingBreakDownBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingBreakDownRow)
                row.WorkStationQuantity = MachineOnProcess
                row.SMV_PerMachine = FormatNumber(row.SMV / MachineOnProcess, 3)
                row.LayoutTime = FormatNumber(row.SMV * Me.PcsInBundle / ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=1", cnn), 2)
                row.Capacity = (60 / row.SMV) * row.WorkStationQuantity
                TotalWS = 0
                TotalSMV = 0
                TTLLayoutTime = 0
                BottleNeck = 0
                BottleNeckMachine = 0

                '--Start : Optimization Purpose

                For Each drv As DataRowView In SewingBreakDownBindingSource.List

                    TotalWS = TotalWS + drv!WorkStationQuantity
                    TotalSMV = TotalSMV + drv!SMV
                    TTLLayoutTime = TTLLayoutTime + drv!LayoutTime

                    'Getting Maximum Value

                    If drv!SMV_PerMachine > BottleNeck Then ' Add >= when want to add maximum machine

                        BottleNeck = drv!SMV_PerMachine
                        'Debug.Print(BottleNeck)

                        'If drv!WorkStationQuantity > BottleNeckMachine Then 'Uncomment = when want to add maximum machine

                        BottleNeckMachine = drv!WorkStationQuantity

                        'End If 'Uncomment= when want to add maximum machine

                    End If


                Next


                '--End : Optimization Purpose


                WSLabel.Text = TotalWS
                SMVLabel.Text = Me.MachineSMV

                LayoutTimeLabel.Text = DectoTimeString(TTLLayoutTime)



                Me.TackTimeLevelPB.Top = ZeroLevel - TotalSMV / TotalWS * Ratio
                Me.UpperLevelPB.Top = ZeroLevel - (TotalSMV / TotalWS * Ratio * 1.2)
                Me.LowerLebelPB.Top = ZeroLevel - (TotalSMV / TotalWS * Ratio * 0.8)
                TackTimeLebel.Text = FormatNumber(TotalSMV / TotalWS, 2)
                UpperLabel.Text = FormatNumber(TotalSMV / TotalWS * 1.2, 2)
                LowerLabel.Text = FormatNumber(TotalSMV / TotalWS * 0.8, 2)


                UpperLevel = FormatNumber(TotalSMV / TotalWS * 1.2, 2)
                LowerLevel = FormatNumber(TotalSMV / TotalWS * 0.8, 2)
                TackTime = FormatNumber(TotalSMV / TotalWS, 2)

                'Average Production Calculation

                ATEVALUE.Text = FormatNumber((TotalWS * 60) / MachineSMV * ReadData("Select NumberValue From Parameter Where PrameterId=3", cnn), 0)

                '========================================
                BOTTLENECKLabel.Text = BottleNeck.ToString

                'Filter SewingBeakDown


                'Dim index As Integer = SewingBreakDownBindingSource.Find("SMV_PerMachine", BottleNeck)
                'BottleNeckMCLabel.Text = SewingBreakDownDataGridView.Rows(index).Cells(4).Value.ToString

                'Dim BottleNeckMachine As Integer = SewingBreakDownDataGridView.Rows(index).Cells(4).Value   'Format(ReadIntegerData("Select Max(WorkStationQuantity) From SewingBreakDown Where SMV_PerMachine=" & Val(BOTTLENECKLabel.Text) & " And SewingLayoutId=" & Me.SewingLayoutId & "And Process_Type='" & Me.PType & "'", cnn), 0)
                BottleNeckMCLabel.Text = BottleNeckMachine
                BottleNeckProductionLabel.Text = FormatNumber((1 * 60) / Val(BOTTLENECKLabel.Text) * ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & Me.MachineSMV & " and DaySerial=10", cnn), 0)


                '=========================================
                If Me.PType = "All" Then
                    ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId, cnn)
                Else
                    ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId & " and Process_Type='" & Me.PType & "'", cnn)
                End If



                Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Size = New System.Drawing.Size(40, Ratio * row.SMV_PerMachine)
                Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Top = ZeroLevel - Ratio * row.SMV_PerMachine
                Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Refresh()

                'Dim h As Integer = Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Height

                'Dim x As Integer = Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Location.X
                'Dim y As Integer = Me.XtraScrollableControl1.Controls(i.ToString).Location.Y

                'Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Location = New System.Drawing.Point(x, y - h)
                'Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Refresh()

            End If

            i += 1

        End While


    End Sub

    Private Sub temppic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer = 1

        While i <= TotalProcess

            If Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Focused Then
                MsgBox(Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Name)
            End If

            i += 1

        End While


    End Sub

    Private Sub SewingBreakDownBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingBreakDownBindingNavigatorSaveItem.Click



        Try
            SewingBreakDownTableAdapter.Update(SewingLayoutDataSet)

        Catch ex As DBConcurrencyException

            Dim customErrorMessage As String
            customErrorMessage = "Concurrency violation" & vbCrLf
            customErrorMessage += CType(ex.Row.Item(0), String)
            MessageBox.Show(customErrorMessage)

            ' Add business logic code to resolve the concurrency violation...

        End Try

        If Me.PType = "All" Then
            ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId, cnn)
        Else
            ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId & " and Process_Type='" & Me.PType & "'", cnn)
        End If





    End Sub



    Private Sub DeleteGraph(ByVal TotalProcess As Integer)

        Dim i As Integer = 1
        LowerLebelPB.Visible = False
        UpperLevelPB.Visible = False
        TackTimeLevelPB.Visible = False


        While i <= TotalProcess

            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls("Bar" & i.ToString))
            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls(i.ToString))
            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls("Label" & i.ToString))
            i += 1

        End While



    End Sub


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Try

            Me.Validate()
            Me.SewingBreakDownBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        ''Me.SewingBreakDownTableAdapter.Update(Me.SewingLayoutDataSet.SewingBreakDown)
        'If Me.PType = "All" Then
        '    ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId, cnn)
        'Else
        '    ExecuteQuery("Update SewingBreakDown Set Upper_Level=" & UpperLevel & ", Lower_Level=" & LowerLevel & ", TackTime=" & TackTime & "Where SewingLayoutId=" & Me.SewingLayoutId & " and Process_Type='" & Me.PType & "'", cnn)
        'End If

        Me.TotaLayoutTime = DectoTimeString(ReadData("Select Sum(LayoutTime) From SewingBreakDown Where SewingLayoutId=" & Me.SewingLayoutId, cnn)) 'Me.LayoutTimeLabel.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub



    Function DectoTimeString(ByVal Time As Decimal) As String

        Dim MyTime As String = ""
        Dim minutes As Decimal = Time

        Dim hours As Integer = 0

        While (minutes - 60) > 0

            minutes -= 60

            hours += 1

        End While

        minutes = Math.Round(minutes)

        MyTime = hours.ToString() + ":" + minutes.ToString()

        Return MyTime

    End Function

    Private Sub Highlight()
        On Error Resume Next
        For Each dr As DataGridViewRow In SewingBreakDownDataGridView.Rows
            'If dr.Cells(5).Value = BottleNeck Then
            dr.DefaultCellStyle.BackColor = Color.White
            'End If
        Next

        For Each dr As DataGridViewRow In SewingBreakDownDataGridView.Rows
            If dr.Cells(8).Value = MinCapacity Then
                dr.DefaultCellStyle.BackColor = Color.Gold
            End If
        Next


    End Sub


    Private Sub ExportXLSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportXLSButton.Click

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim xlRange As Excel.Range

        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        With xlWorkSheet
            'insert column names
            For j = 0 To SewingBreakDownDataGridView.Columns.Count - 1
                .Cells(1, j + 1).value = SewingBreakDownDataGridView.Columns(j).HeaderText.ToString

                xlRange = xlWorkSheet.Range("A1", misValue)
                xlRange = xlRange.Resize(1, j + 1)

                With xlRange

                    '.FormulaR1C1 = "MARK LIST"
                    .Font.Bold = True
                    .BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

                End With

            Next
            ''insert the actual data
            '.Range("A2").Copy()

            For i = 0 To SewingBreakDownDataGridView.RowCount - 2
                For j = 0 To SewingBreakDownDataGridView.ColumnCount - 1

                    xlWorkSheet.Cells(i + 2, j + 1) = SewingBreakDownDataGridView(j, i).FormattedValue.ToString

                    'xlRange = xlWorkSheet.Range("A" & j + 1, "N" & i + 1)
                    xlRange = xlWorkSheet.Range("A1", misValue)
                    xlRange = xlRange.Resize(i + 2, j + 1)

                    With xlRange

                        '.FormulaR1C1 = "MARK LIST"
                        .BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

                    End With


                Next
            Next



        End With


        xlWorkSheet.SaveAs("E:\SewingBreakdown.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file E:\SewingBreakdown.xlsx")


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BTLNKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLNKButton.Click
        Highlight()
    End Sub
    Private Sub BOTTLENECKLabel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOTTLENECKLabel.TextChanged
        Highlight()
    End Sub
    Private Sub SewingBreakDownDataGridView_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles SewingBreakDownDataGridView.DataBindingComplete

        'Highlight row

        Highlight()


    End Sub

    Private Sub SewingBreakDownDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SewingBreakDownDataGridView.DataError
        On Error Resume Next
    End Sub

    Private Sub SewingBreakDownBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles SewingBreakDownBindingNavigator.RefreshItems

    End Sub
End Class




