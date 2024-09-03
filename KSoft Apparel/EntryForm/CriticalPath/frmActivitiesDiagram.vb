Imports DevExpress.Diagram.Core
Imports DevExpress.XtraDiagram

Public Class frmActivitiesDiagram
    Sub New()

        InitializeComponent()

        'Dim viewModel As ViewModel = New ViewModel()
        'DiagramDataBindingController1.GenerateItem += DiagramDataBindingController1_GenerateItem_1()
        'DiagramDataBindingController1.DataSource = viewModel.Items
        'DiagramDataBindingController1.KeyMember = "Id"
        'DiagramDataBindingController1.ConnectorsSource = viewModel.Connections
        'DiagramDataBindingController1.ConnectorFromMember = "From"
        'DiagramDataBindingController1.ConnectorToMember = "To"
        'DiagramDataBindingController1.LayoutKind = DiagramLayoutKind.Circular
        'ActivitiesTemplateViewTableAdapter1.Fill(ActivitiesTemplateViewDataSet1.ActivitiesTemplateView)
    End Sub



    Private Sub DiagramDataBindingController1_GenerateItem_1(sender As Object, e As DiagramGenerateItemEventArgs)
        Dim item = New DiagramShape With {.X = 27, .Width = 75, .Height = 50, .Shape = BasicShapes.Rectangle}
        item.Bindings.Add(New DiagramBinding("Content", "Name"))
        e.Item = item
    End Sub
End Class
Public Class ViewModel

    Public Property Items As List(Of Item)

    Public Property Connections As List(Of Link)

    Public Sub New()
        Items = New List(Of Item)()
        For i As Integer = 0 To 5 - 1
            Items.Add(New Item With {.Id = i, .Name = "Item " & i})
        Next

        Connections = New List(Of Link)()
        For i As Integer = 0 To 4 - 1
            Connections.Add(New Link With {.From = Items(i).Id, .[To] = Items(i + 1).Id})
        Next

        Connections.Add(New Link With {.From = Items(4).Id, .[To] = Items(0).Id})
    End Sub
End Class

Public Class Item

    Public Property Id As Integer

    Public Property Name As String
End Class

Public Class Link

    Public Property From As Object

    Public Property [To] As Object
End Class
