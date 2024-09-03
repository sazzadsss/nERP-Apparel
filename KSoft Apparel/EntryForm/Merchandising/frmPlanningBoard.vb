Public Class frmPlanningBoard
    Dim DateRange As Integer
    Dim Dragging As Boolean
    Dim BeginX As Integer
    Dim BeginY As Integer
    Public line As String = ""
    Public PlanningDate As String = ""
    Dim LineCount As Integer
    Dim firstLineName As String = String.Empty
    Private s As New Snap

    Private Sub frmPlanningBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LineTableAdapter.FillByPlanning(Me.LineDataSet.Line)

        Me.PlanningTableAdapter.Fill(Me.PlanningNewDataSet.Planning)

        
        '=======eg: To resize form at runtime on computers========
        '=======that have 800x600 screen==========================

        'If Screen.PrimaryScreen.Bounds.Width = 800 AndAlso
        'Screen.PrimaryScreen.Bounds.Height = 600 Then
        'Me.Size = New Size(width,height )
        'End If


        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

        Me.LineBindingSource.MoveFirst()
        Dim row As LineDataSet.LineRow
        row = CType(CType(Me.LineBindingSource.Current, DataRowView).Row, LineDataSet.LineRow)
        firstLineName = row.Line



    End Sub

    Private Sub LoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadButton.Click

        'FromDateTimePicker.Text = #4/1/2010#
        'ToDateTimePicker.Text = #4/30/2010#
        Dim FDate As Date = FromDateTimePicker.Text


        DateRange = DateDiff(DateInterval.Day, DateValue(FromDateTimePicker.Text), DateAdd(DateInterval.Day, 1, DateValue(ToDateTimePicker.Text)))

        DateRangeLabelControl.Text = DateRange
        LineCount = LineBindingSource.Count 'ReadIntData("Select Count(LineId) from Line Where Planning=1", cnn)

        AddDateColumn(DateRange)
        AddLineRow(LineCount)
        AddOrder(DateRange)

        Dim i As Integer = 1
        Dim i2 As Integer = 1
        While i <= DateRange

            Me.XtraScrollableControl2.Controls("P:" & i.ToString).BringToFront()
            Me.LineBindingSource.Position = LineCount - 1
            Dim row As LineDataSet.LineRow
            row = CType(CType(Me.LineBindingSource.Current, DataRowView).Row, LineDataSet.LineRow)


            Dim hght As Integer = Me.XtraScrollableControl1.Controls("Line" & row.LineId).Top + Me.XtraScrollableControl1.Controls("Line" & row.LineId).Height
            Me.XtraScrollableControl2.Controls(FDate.ToString).Height = hght


            Dim TDate As Date = Me.ToDateTimePicker.Text

            Dim wdth As Integer = Me.XtraScrollableControl2.Controls(TDate.ToString).Left + 50

            While i2 <= LineCount 'I woulb be different value

                Me.LineBindingSource.Position = i2 - 1
                Dim row1 As LineDataSet.LineRow
                row1 = CType(CType(Me.LineBindingSource.Current, DataRowView).Row, LineDataSet.LineRow)

                Me.XtraScrollableControl2.Controls(row1.Line).Width = wdth

                i2 += 1
            End While

            FDate = DateAdd(DateInterval.Day, 1, DateValue(FDate.ToString))

            i += 1
        End While



        'Me.XtraScrollableControl2.VerticalScroll.Visible = False


    End Sub

    Public Sub AddDateColumn(ByVal PN As Integer)

        'Declare Variable
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim FDate As Date = FromDateTimePicker.Text
        Dim CNT As Integer = 1
        Dim DateColumnLabel As Label() = New Label(PN) {}
        Dim ColumnBackground As Label() = New Label(PN) {}



        Me.AutoScroll = True


        'Initialize Date Column
        While CNT <= PN

            

            ColumnBackground(CNT) = New Label
            ColumnBackground(CNT).Name = FDate.ToString '"ColumnBackground" & CNT
            ColumnBackground(CNT).Location = New System.Drawing.Point(X, Y)
            ColumnBackground(CNT).Size = New System.Drawing.Size(1, Me.XtraScrollableControl2.Height)
            'ColumnBackground(CNT).BorderStyle = BorderStyle.FixedSingle
            ColumnBackground(CNT).TextAlign = ContentAlignment.MiddleCenter
            ColumnBackground(CNT).Enabled = False
            ColumnBackground(CNT).ForeColor = System.Drawing.Color.White
            ColumnBackground(CNT).BackColor = System.Drawing.Color.LightGray
            'ColumnBackground(CNT).Text = Format(FDate, "dd/MM") '& " [" & DatePart(DateInterval.WeekOfYear, DateValue(FDate)) & "]"

            DateColumnLabel(CNT) = New Label
            DateColumnLabel(CNT).Name = "Day" & FDate
            DateColumnLabel(CNT).Location = New System.Drawing.Point(X, Y)
            DateColumnLabel(CNT).Size = New System.Drawing.Size(50, 33)
            DateColumnLabel(CNT).BorderStyle = BorderStyle.Fixed3D
            DateColumnLabel(CNT).TextAlign = ContentAlignment.MiddleCenter
            DateColumnLabel(CNT).ForeColor = System.Drawing.Color.Black
            DateColumnLabel(CNT).BackColor = System.Drawing.Color.Gold
            DateColumnLabel(CNT).Text = Format(FDate, "dd/MM") '& " [" & DatePart(DateInterval.WeekOfYear, DateValue(FDate)) & "]"



            Me.XtraScrollableControl3.Controls.Add(DateColumnLabel(CNT))
            Me.XtraScrollableControl2.Controls.Add(ColumnBackground(CNT))

            X = X + 50
            FDate = DateAdd(DateInterval.Day, 1, DateValue(FDate.ToString))
            CNT += 1


        End While

    End Sub

    Public Sub AddLineRow(ByVal PN As Integer)


        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim FDate As Date = FromDateTimePicker.Text
        Dim CNT As Integer = 1
        Dim LineLabel As Label() = New Label(PN) {}
        Dim RowBackground As Label() = New Label(PN) {}

        Me.AutoScroll = True

        'Initialize Line
        While CNT <= PN
            Me.LineBindingSource.Position = CNT - 1

            Dim row As LineDataSet.LineRow
            row = CType(CType(Me.LineBindingSource.Current, DataRowView).Row, LineDataSet.LineRow)



            LineLabel(CNT) = New Label
            LineLabel(CNT).Name = "Line" & row.LineId
            LineLabel(CNT).Location = New System.Drawing.Point(X, Y)
            LineLabel(CNT).Size = New System.Drawing.Size(Me.XtraScrollableControl1.Width - 18, 30)
            LineLabel(CNT).BorderStyle = BorderStyle.Fixed3D
            LineLabel(CNT).TextAlign = ContentAlignment.MiddleLeft
            LineLabel(CNT).ForeColor = System.Drawing.Color.Black
            LineLabel(CNT).BackColor = System.Drawing.Color.Gold
            LineLabel(CNT).Text = row.Line  '"Line" & CNT 'Format(FDate, "dd/MM") '& " [" & DatePart(DateInterval.WeekOfYear, DateValue(FDate)) & "]"

            RowBackground(CNT) = New Label
            RowBackground(CNT).Name = row.Line  '"L" & CNT
            RowBackground(CNT).Location = New System.Drawing.Point(X, Y)
            RowBackground(CNT).Size = New System.Drawing.Size(Me.XtraScrollableControl2.Width, 1)
            RowBackground(CNT).TextAlign = ContentAlignment.MiddleCenter
            RowBackground(CNT).ForeColor = System.Drawing.Color.White
            RowBackground(CNT).Enabled = False
            RowBackground(CNT).BackColor = System.Drawing.Color.LightGray
            'RowBackground(CNT).Text = "Line" & CNT 'Format(FDate, "dd/MM") '& " [" & DatePart(DateInterval.WeekOfYear, DateValue(FDate)) & "]"



            Me.XtraScrollableControl1.Controls.Add(LineLabel(CNT))
            Me.XtraScrollableControl2.Controls.Add(RowBackground(CNT))

            Y = Y + 30
            CNT += 1


        End While

    End Sub

    Public Sub AddOrder(ByVal PN As Integer)
        Me.AutoScroll = True

        'Dim OrderBar As DevExpress.XtraEditors.PictureEdit() = New DevExpress.XtraEditors.PictureEdit(PN) {}
        Dim OrderBar As Label() = New Label(PN) {}
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim CNT As Integer = 1


        'Initialize Label
        While CNT <= PN


            OrderBar(CNT) = New Label 'DevExpress.XtraEditors.PictureEdit

            OrderBar(CNT).Name = "P:" & CNT
            OrderBar(CNT).Location = New System.Drawing.Point(X, Y)
            OrderBar(CNT).Size = New System.Drawing.Size(50, 30)
            OrderBar(CNT).BorderStyle = BorderStyle.FixedSingle
            OrderBar(CNT).TextAlign = ContentAlignment.MiddleLeft
            OrderBar(CNT).ForeColor = System.Drawing.Color.MidnightBlue
            OrderBar(CNT).BackColor = System.Drawing.Color.LightGreen
            OrderBar(CNT).Text = "P:" & CNT
            
            Me.XtraScrollableControl2.Controls.Add(OrderBar(CNT))


            AddHandler OrderBar(CNT).MouseDown, AddressOf OrderBar_MouseDown
            AddHandler OrderBar(CNT).MouseMove, AddressOf OrderBar_MouseMove
            AddHandler OrderBar(CNT).MouseUp, AddressOf OrderBar_MouseUp
            'AddHandler OrderBar(CNT).GotFocus, AddressOf OrderBar_GotFocus
            'AddHandler OrderBar(CNT).LostFocus, AddressOf OrderBar_LostFocus



            X = X + 50
            Y += 30

            CNT += 1


        End While

    End Sub

    Private Sub OrderBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'On Error Resume Next
        Dragging = True
        beginX = e.X
        BeginY = e.Y

        Dim FDate As Date = FromDateTimePicker.Text
        RefreshGrid(30, FDate, LineCount, 30)

        If SelectedFromDateButton.Text <> String.Empty AndAlso SelectedLineButton.Text <> String.Empty Then
            Me.XtraScrollableControl2.Controls(SelectedFromDateButton.Text.ToString).BackColor = Color.Red
            Me.XtraScrollableControl2.Controls(SelectedLineButton.Text.ToString).BackColor = Color.Red
        End If

        CType(sender, Label).BackColor = Color.Gold

        'Dim OrderBarName As String = CType(sender, Label).Name.ToString


        'Repositon

        'Dim i3 As Integer = 1
        'While i3 <= 30

        '    If Me.XtraScrollableControl2.Controls("P:" & i3.ToString).Top = Me.XtraScrollableControl2.Controls(SelectedLineButton.Text.ToString).Top AndAlso Me.XtraScrollableControl2.Controls("P:" & i3.ToString).Name <> OrderBarName AndAlso Me.XtraScrollableControl2.Controls("P:" & i3.ToString).Left >= CType(sender, Label).Left Then
        '        Me.XtraScrollableControl2.Controls("P:" & i3.ToString).Left = Me.XtraScrollableControl2.Controls("P:" & i3.ToString).Left + CType(sender, Label).Width

        '    End If
        '    i3 += 1
        'End While




    End Sub

    Private Sub OrderBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'If Dragging = True Then
        '    Dim i As Integer = 1
        '    While i <= 30
        '        If Me.XtraScrollableControl2.Controls("P:" & i.ToString).Focused = True Then

        '            Me.XtraScrollableControl2.Controls("P:" & i.ToString).Location = New Point(Me.XtraScrollableControl2.Controls("P:" & i.ToString).Location.X + e.X - BeginX, Me.XtraScrollableControl2.Controls("P:" & i.ToString).Location.Y + e.Y - BeginY)
        '            Me.Refresh()


        '            'If Me.XtraScrollableControl2.Controls("P:" & i.ToString).Top < 20 Then

        '            '    Me.XtraScrollableControl2.Controls("P:" & i.ToString).Top = 20

        '            'End If





        '        End If

        '        i += 1

        '    End While

        'End If
        's.drawscreen(e.X, e.Y, e.X + Me.XtraScrollableControl2.Width, e.Y + Me.XtraScrollableControl2.Height)
        s.Capture(Me.XtraScrollableControl2)

        Static ct, ct2 As String

        ct = Me.line.ToString
        ct2 = Me.PlanningDate.ToString

        If Strings.Len(ct) > 5 Then
            ct = firstLineName
        End If

        SelectedLineButton.Text = ct
        SelectedFromDateButton.Text = ct2

        Me.Refresh()


    End Sub

    Private Sub OrderBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dragging = False
        Dim i As Integer = 1
        Dim i2 As Integer = 1

        

        'Static c As Integer
        'c += 1
        'Label1.Text = c.ToString

        's.Suspend()


        While i <= 30

            If Me.XtraScrollableControl2.Controls("P:" & i.ToString).Focused = True Then

                If e.X < 2 Then
                    Me.XtraScrollableControl2.Controls("P:" & i.ToString).Left = 2
                ElseIf e.Y < 2 Then
                    Me.XtraScrollableControl2.Controls("P:" & i.ToString).Top = 2
                End If

                'While i2 <= 30

                '    If e.Y > Me.XtraScrollableControl2.Controls("RowBackground" & i2.ToString).Top AndAlso e.Y < Me.XtraScrollableControl2.Controls("RowBackground" & i2.ToString).Top + 30 Then
                '        Me.XtraScrollableControl2.Controls("P:" & i.ToString).Top = Me.XtraScrollableControl2.Controls("RowBackground" & i2.ToString).Top
                '        Exit Sub
                '    End If
                '    i2 += 1

                'End While
                'SnapToControl(Me.XtraScrollableControl2.Controls("P:" & (i + 1).ToString))
                'If e.X > Me.XtraScrollableControl2.Controls("RowBackground" & i.ToString).Top AndAlso e.X < Me.XtraScrollableControl2.Controls("RowBackground" & (i + 1).ToString).Top Then
                '    Me.XtraScrollableControl2.Controls("P:" & i.ToString).Top = Me.XtraScrollableControl2.Controls("RowBackground" & i.ToString).Top
                'End If

            End If
            i += 1
        End While




        

       



    End Sub
   

    Public Sub SnapToControl(ByVal Control As Control)
        Dim objPoint As Point = Control.PointToScreen(New Point(0, 0))
        Cursor.Position = objPoint
    End Sub
    
    'Private Sub HScrollBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.HScrollBar1.Value = XtraScrollableControl2.HorizontalScroll.Value
    '    Me.HScrollBar1.Maximum = XtraScrollableControl2.HorizontalScroll.Maximum
    '    Me.HScrollBar1.Minimum = XtraScrollableControl2.HorizontalScroll.Minimum

    'End Sub

    'Private Sub HScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    '    XtraScrollableControl2.HorizontalScroll.Value = Me.HScrollBar1.Value

    '    'Dim pp As Point = New Point(0, 500)

    '    'XtraScrollableControl1.AutoScrollPosition = pp


    'End Sub

   

    Private Sub XtraScrollableControl1_Scroll(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.XtraScrollEventArgs) Handles XtraScrollableControl1.Scroll
        XtraScrollableControl2.VerticalScroll.Value = e.NewValue

    End Sub

    Private Sub XtraScrollableControl3_Scroll(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.XtraScrollEventArgs) Handles XtraScrollableControl3.Scroll
        XtraScrollableControl2.HorizontalScroll.Value = e.NewValue
    End Sub

   

    Private Sub XtraScrollableControl2_Scroll(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.XtraScrollEventArgs) Handles XtraScrollableControl2.Scroll
        XtraScrollableControl3.HorizontalScroll.Value = e.NewValue
    End Sub

    Private Sub frmPlanningBoard_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        s.Suspend()
    End Sub

    'Private Sub OrderBar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    CType(sender, Label).BackColor = Color.Gold
    'End Sub

    'Private Sub OrderBar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    CType(sender, Label).BackColor = Color.LightGreen
    'End Sub

    'Private Sub OrderBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    'End Sub

    

    Private Sub SelectedLineButton_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectedLineButton.TextChanged
        On Error Resume Next
        Dim FDate As Date = FromDateTimePicker.Text
        RefreshGrid(30, FDate, LineCount, 30)

        Me.XtraScrollableControl2.Controls(SelectedFromDateButton.Text.ToString).BackColor = Color.Red
        Me.XtraScrollableControl2.Controls(SelectedLineButton.Text.ToString).BackColor = Color.Red
    End Sub

  
    Private Sub SelectedFromDateButton_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectedFromDateButton.TextChanged
        On Error Resume Next
        Dim FDate As Date = FromDateTimePicker.Text
        RefreshGrid(30, FDate, LineCount, 30)

        Me.XtraScrollableControl2.Controls(SelectedFromDateButton.Text.ToString).BackColor = Color.Red
        Me.XtraScrollableControl2.Controls(SelectedLineButton.Text.ToString).BackColor = Color.Red


    End Sub
    Private Sub RefreshGrid(ByVal DateRange As Integer, ByVal FDate As Date, ByVal RowCount As Integer, ByVal OrderCount As Integer)

        Dim i As Integer = 1
        Dim i2 As Integer = 1
        Dim i3 As Integer = 1
        While i <= DateRange

            'Me.XtraScrollableControl2.Controls("P:" & i.ToString).BringToFront()
            'Dim hght As Integer = Me.XtraScrollableControl1.Controls("Line30").Top + Me.XtraScrollableControl1.Controls("Line30").Height
            'Me.XtraScrollableControl2.Controls(FDate.ToString).Height = hght


            'Dim TDate As Date = Me.ToDateTimePicker.Text

            'Dim wdth As Integer = Me.XtraScrollableControl2.Controls(TDate.ToString).Left + 50
            Me.XtraScrollableControl2.Controls(FDate.ToString).BackColor = Color.LightGray




            FDate = DateAdd(DateInterval.Day, 1, DateValue(FDate.ToString))

            i += 1
        End While

        While i2 <= RowCount 'I would be different value
            Me.LineBindingSource.Position = i2 - 1

            Dim row As LineDataSet.LineRow
            row = CType(CType(Me.LineBindingSource.Current, DataRowView).Row, LineDataSet.LineRow)


            Me.XtraScrollableControl2.Controls(row.Line).BackColor = Color.LightGray
            i2 += 1
        End While

        While i3 <= OrderCount 'I would be different value
            Me.XtraScrollableControl2.Controls("P:" & i3.ToString).BackColor = Color.LightGreen
            i3 += 1
        End While

    End Sub

   
    Private Sub SelectedLineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedLineButton.Click

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        frmPlanningEntry.ShowDialog()

    End Sub

    'Private Sub PlanningBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.PlanningBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PlanningNewDataSet)

    'End Sub

    Private Sub PlanningBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PlanningBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PlanningNewDataSet)

    End Sub
End Class