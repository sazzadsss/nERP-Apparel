Public Class Snap
    Implements IMessageFilter


    Private selected, container As Control
    Private controls As New Dictionary(Of IntPtr, Control)
    Private mv As movement
    Private mouseoff As Point

    Public Sub Capture(ByVal container As Control)
        Application.AddMessageFilter(Me)
        Me.container = container
        getcontrols()
    End Sub

    Private Sub getcontrols()
        controls.Clear()
        Dim c As Control = container.GetNextControl(container, True)
        Do Until c Is Nothing
            If c.Visible Then
                controls.Add(c.Handle, c)
            End If
            c = container.GetNextControl(c, True)
        Loop
        If container.Parent IsNot Nothing Then
            controls.Add(container.Handle, container)
        End If
    End Sub

    Public Sub Suspend()
        Application.RemoveMessageFilter(Me)
        controls.Clear()
    End Sub


    Private Const WM_LBUTTONDOWN As Int32 = &H201
    Private Const WM_LBUTTONUP As Int32 = &H202
    Private Const WM_MOUSEMOVE As Int32 = &H200
    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
        Select Case m.Msg
            Case WM_LBUTTONDOWN
                If controls.ContainsKey(m.HWnd) Then
                    Dim c As Control = controls(m.HWnd)
                    If c IsNot container AndAlso Not TypeOf c Is ToolStrip Then
                        selected = c
                        Dim p As New Point(m.LParam)
                        mouseoff = New Point(-p.X, -p.Y)
                        mv = New movement
                        Return True 'message handled (surpresses form/controls mousedown)
                    End If
                End If

            Case WM_LBUTTONUP
                If selected IsNot Nothing Then
                    selected = Nothing
                    container.FindForm.Refresh()
                End If

            Case WM_MOUSEMOVE
                If selected IsNot Nothing Then
                    mv.calculate()
                    If mv.dir <> movement.direction.none Then
                        checksnap()
                    End If
                    Return True 'message handled (surpresses form/controls mousemove)
                End If
        End Select
    End Function

    Private Sub checksnap()
        Dim treshold As Integer = 15
        Dim snapped As Boolean = False
        Dim ps As Point = Cursor.Position
        ps.Offset(mouseoff)
        For Each c As Control In controls.Values
            If c IsNot selected Then                
                Dim pc As Point
                If c.Parent Is Nothing Then
                    pc = c.Location
                Else
                    pc = c.Parent.PointToScreen(c.Location)
                End If
                Select Case mv.dir
                    Case movement.direction.up
                        'inner (selected-top vs control-top) 
                        If WithinRange(ps.Y, _
                                       pc.Y, _
                                       pc.Y + treshold) Then
                            selected.Top = selected.Parent.PointToClient(pc).Y
                            snapped = True
                            'debug
                            container.Text = c.Name
                            frmPlanningBoard.line = c.Name
                            'draw
                            ps = selected.Parent.PointToScreen(selected.Location)
                            Dim xmax As Integer = Math.Max(ps.X + selected.Width, pc.X + c.Width)
                            Dim xmin As Integer = Math.Min(ps.X, pc.X)
                            'drawscreen(xmin, ps.Y, xmax, ps.Y)
                            '
                            Exit For
                        End If
                        'outer (selected-top vs control-bottom) 
                        If WithinRange(ps.Y, _
                                       pc.Y + c.Height, _
                                       pc.Y + c.Height + treshold) Then
                            selected.Top = selected.Parent.PointToClient(pc).Y + c.Height
                            snapped = True
                            container.Text = c.Name                            
                            ps = selected.Parent.PointToScreen(selected.Location)
                            Dim xmax As Integer = Math.Max(ps.X + selected.Width, pc.X + c.Width)
                            Dim xmin As Integer = Math.Min(ps.X, pc.X)
                            'drawscreen(xmin, ps.Y, xmax, ps.Y)
                            Exit For
                        End If

                        'Case movement.direction.down
                        '    'inner (selected-bottom vs control-bottom) 
                        '    If WithinRange(ps.Y + selected.Height, _
                        '                   pc.Y + c.Height - treshold, _
                        '                   pc.Y + c.Height) Then
                        '        selected.Top = selected.Parent.PointToClient(pc).Y + c.Height - selected.Height
                        '        snapped = True
                        '        container.Text = c.Name
                        '        ps = selected.Parent.PointToScreen(selected.Location)
                        '        Dim xmax As Integer = Math.Max(ps.X + selected.Width, pc.X + c.Width)
                        '        Dim xmin As Integer = Math.Min(ps.X, pc.X)
                        '        Dim y As Integer = ps.Y + selected.Height
                        '        'drawscreen(xmin, y, xmax, y)
                        '        Exit For
                        '    End If
                        '    'outer (selected-bottom vs control-top)
                        '    If WithinRange(ps.Y + selected.Height, _
                        '                   pc.Y - treshold, _
                        '                   pc.Y) Then
                        '        selected.Top = selected.Parent.PointToClient(pc).Y - selected.Height
                        '        snapped = True
                        '        container.Text = c.Name
                        '        ps = selected.Parent.PointToScreen(selected.Location)
                        '        Dim xmax As Integer = Math.Max(ps.X + selected.Width, pc.X + c.Width)
                        '        Dim xmin As Integer = Math.Min(ps.X, pc.X)
                        '        Dim y As Integer = ps.Y + selected.Height
                        '        'drawscreen(xmin, y, xmax, y)
                        '        Exit For
                        '    End If

                    Case movement.direction.left
                        'inner (selected-left vs control-left) 
                        If WithinRange(ps.X, _
                                       pc.X, _
                                       pc.X + treshold) Then
                            selected.Left = selected.Parent.PointToClient(pc).X
                            snapped = True
                            container.Text = c.Name
                            frmPlanningBoard.PlanningDate = c.Name
                            ps = selected.Parent.PointToScreen(selected.Location)
                            Dim ymax As Integer = Math.Max(ps.Y + selected.Height, pc.Y + c.Height)
                            Dim ymin As Integer = Math.Min(ps.Y, pc.Y)
                            'drawscreen(ps.X, ymin, ps.X, ymax)
                            Exit For
                        End If
                        'outer (selected-left vs control-right)
                        If WithinRange(ps.X, _
                                       pc.X + c.Width, _
                                       pc.X + c.Width + treshold) Then
                            selected.Left = selected.Parent.PointToClient(pc).X + c.Width
                            snapped = True
                            container.Text = c.Name
                            ps = selected.Parent.PointToScreen(selected.Location)
                            Dim ymax As Integer = Math.Max(ps.Y + selected.Height, pc.Y + c.Height)
                            Dim ymin As Integer = Math.Min(ps.Y, pc.Y)
                            'drawscreen(ps.X, ymin, ps.X, ymax)
                            Exit For
                        End If

                        '            Case movement.direction.right
                        '                'inner (selected-right vs control-right) 
                        '                If WithinRange(ps.X + selected.Width, _
                        '                               pc.X + c.Width - treshold, _
                        '                               pc.X + c.Width) Then
                        '                    selected.Left = selected.Parent.PointToClient(pc).X + c.Width - selected.Width
                        '                    snapped = True
                        '                    container.Text = c.Name
                        '                    ps = selected.Parent.PointToScreen(selected.Location)
                        '                    Dim ymax As Integer = Math.Max(ps.Y + selected.Height, pc.Y + c.Height)
                        '                    Dim ymin As Integer = Math.Min(ps.Y, pc.Y)
                        '                    Dim x As Integer = ps.X + selected.Width
                        '                    'drawscreen(x, ymin, x, ymax)
                        '                    Exit For
                        '                End If
                        '                'outer (selected-right vs control-left)
                        '                If WithinRange(ps.X + selected.Width, _
                        '                               pc.X - treshold, _
                        '                               pc.X) Then
                        '                    selected.Left = selected.Parent.PointToClient(pc).X - selected.Width
                        '                    snapped = True
                        '                    container.Text = c.Name
                        '                    ps = selected.Parent.PointToScreen(selected.Location)
                        '                    Dim ymax As Integer = Math.Max(ps.Y + selected.Height, pc.Y + c.Height)
                        '                    Dim ymin As Integer = Math.Min(ps.Y, pc.Y)
                        '                    Dim x As Integer = ps.X + selected.Width
                        '                    'drawscreen(x, ymin, x, ymax)
                        '                    Exit For
                        '                End If
                End Select
                            End If
        Next
        If Not snapped Then
            selected.Location = selected.Parent.PointToClient(ps)
            container.FindForm.Refresh()
        End If

    End Sub

    Private Function WithinRange(ByVal value As Integer, ByVal rangeFrom As Integer, ByVal rangeTo As Integer) As Boolean
        If value >= rangeFrom AndAlso value <= rangeTo Then
            Return True
        End If
    End Function



    ''' <summary>
    ''' calculates the movement and direction of mouse cursor
    ''' </summary>    
    Private Class movement
        Private prev As Point
        Public dir As direction

        Public Sub New()
            prev = Cursor.Position
        End Sub

        Public Enum direction
            none
            up
            down
            left
            right
        End Enum

        Public Sub calculate()
            Dim cur As Point = Cursor.Position
            Dim move As Point = cur - prev
            prev = cur
            If move.X > 0 Then
                dir = direction.right
            ElseIf move.X < 0 Then
                dir = direction.left
            ElseIf move.Y < 0 Then
                dir = direction.up
            ElseIf move.Y > 0 Then
                dir = direction.down
            Else
                dir = direction.none
            End If
        End Sub
    End Class


    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Sub drawscreen(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)

        container.Refresh()

        Dim dc As Integer = GetDC(0)

        If dc <> 0 Then
            Dim g As Graphics = Graphics.FromHdc(dc)
            g.DrawLine(Pens.Blue, x1, y1, x2, y2)
            g.Dispose()
            ReleaseDC(0, dc)
        End If

    End Sub

End Class
