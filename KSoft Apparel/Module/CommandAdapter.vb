'Imports DevExpress.XtraScheduler.Commands
'Imports DevExpress.Utils.Menu
'Imports DevExpress.XtraScheduler
' ... Imports DevExpress.XtraScheduler.Commands



Public Class CommandAdapter
    '    Private command_Renamed As SchedulerCommand

    '    Public Sub New(ByVal command_Renamed As SchedulerCommand)
    '        If command_Renamed Is Nothing Then
    '            Throw New ArgumentNullException("command")
    '        End If
    '        Me.command_Renamed = command_Renamed
    '    End Sub

    '    Public ReadOnly Property Command() As SchedulerCommand
    '        Get
    '            Return command_Renamed
    '        End Get
    '    End Property

    '    Public Function CreateMenuItem() As DXMenuItem
    '        Dim item As SchedulerMenuItem = New SchedulerMenuItem(command_Renamed.MenuCaption, New EventHandler(AddressOf OnClick), command_Renamed.Image, New EventHandler(AddressOf OnUpdate))
    '        item.Id = command_Renamed.MenuId
    '        Return item
    '    End Function
    '    'Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim item As SchedulerMenuItem = CType(sender, SchedulerMenuItem)
    '    If item.Visible AndAlso item.Enabled Then
    '        Dim commandState As SchedulerMenuItemId = New SchedulerMenuCheckItem(item)
    '        command_Renamed.ForceExecute(commandState)
    '    End If
    'End Sub
    'Private Sub OnUpdate(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim item As SchedulerMenuItem = CType(sender, SchedulerMenuItem)
    '    If item.Visible AndAlso item.Enabled Then
    '        Dim commandState As SchedulerMenuItemUIState = New SchedulerMenuItemUIState(item)
    '        command_Renamed.UpdateUIState(commandState)
    '    End If
    'End Sub
End Class

