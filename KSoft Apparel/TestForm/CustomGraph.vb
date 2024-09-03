Imports DevExpress.XtraEditors.PictureEdit

Public Class CustomGraph
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const HTCAPTION = 2
    Dim TotalProcess As Integer = 0
    'Dim temp As NumericUpDown()

    Private dragging As Boolean
    Private beginX, beginY As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        TotalProcess = 100
        While i <= TotalProcess

            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls("Bar" & i.ToString))
            Me.XtraScrollableControl1.Controls.Remove(Me.XtraScrollableControl1.Controls(i.ToString))


            i += 1

        End While
        AddControl(TotalProcess)
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub

    Public Sub AddControl(ByVal PN As Integer)
        Me.AutoScroll = True

        Dim temp As NumericUpDown() = New NumericUpDown(PN) {}
        Dim temppic As DevExpress.XtraEditors.PictureEdit() = New DevExpress.XtraEditors.PictureEdit(PN) {}
        Dim temp2 As Label() = New Label(PN) {}


        Dim CNT As Integer = 1
        Dim X As Integer = 30
        Dim Y As Integer = 200




        While CNT <= PN

            temp(CNT) = New NumericUpDown
            temp(CNT).Name = CNT
            temp(CNT).Location = New System.Drawing.Point(X, Y)
            'temp(CNT).Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
            temp(CNT).Size = New System.Drawing.Size(30, 20)
            'temp(CNT).TextAlign = ContentAlignment.MiddleCenter
            temp(CNT).ForeColor = System.Drawing.Color.Black
            temp(CNT).BackColor = System.Drawing.Color.LightSalmon
            temp(CNT).Value = 1
            'temp(CNT).Text = "DYNAMIC LABEL NO" & CNT + 1


            temppic(CNT) = New DevExpress.XtraEditors.PictureEdit
            temppic(CNT).Name = "Bar" & CNT
            'temp(CNT).Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
            temppic(CNT).Size = New System.Drawing.Size(30, 50)

            temppic(CNT).Location = New System.Drawing.Point(X, Y - temppic(CNT).Height)
            'temp(CNT).TextAlign = ContentAlignment.MiddleCenter
            temppic(CNT).ForeColor = System.Drawing.Color.LightSalmon
            temppic(CNT).BackColor = System.Drawing.Color.LightSalmon
            temppic(CNT).Properties.NullText = ""

            'temp(CNT).Text = "DYNAMIC LABEL NO" & CNT + 1

            'Initialize Label
            temp2(CNT) = New Label
            temp2(CNT).Name = "Label" & CNT
            temp2(CNT).Location = New System.Drawing.Point(X, Y + 20)
            temp2(CNT).Size = New System.Drawing.Size(30, 20)
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

            X = X + 35



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
                Dim hgt As Integer
                hgt = CType(Me.XtraScrollableControl1.Controls(i.ToString), NumericUpDown).Value

                Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Size = New System.Drawing.Size(30, 50 * hgt)
                Dim h As Integer = Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Height

                Dim x As Integer = Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Location.X
                Dim y As Integer = Me.XtraScrollableControl1.Controls(i.ToString).Location.Y

                Me.XtraScrollableControl1.Controls("Bar" & i.ToString).Location = New System.Drawing.Point(x, y - h)
                Me.PictureBox1.Top = Me.PictureBox1.Top + 10
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




    Private Sub TextBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            TextBox1.Capture = False
            Dim msg As Message =
                Message.Create(TextBox1.Handle, WM_NCLBUTTONDOWN,
                    New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

   
    

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown

        dragging = True
        beginX = e.X
        beginY = e.Y

    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        If dragging = True Then
            Button2.Location = New Point(Button2.Location.X + e.X - beginX, Button2.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp

        dragging = False

    End Sub

    Private Sub CustomGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class