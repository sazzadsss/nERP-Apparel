Imports System.Windows.Forms


Public Class FrmFabricBookingColor
    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property
    Private _AmendmendNo As Integer
    Public Property AmendmentNo() As Integer
        Get
            Return _AmendmendNo
        End Get
        Set(ByVal value As Integer)
            _AmendmendNo = value
        End Set
    End Property
    Private _Shade As String
    Public Property Shade() As String
        Get
            Return _Shade
        End Get
        Set(ByVal value As String)
            _Shade = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim row As FabricBookingColorSearchDataSet.FabricBookingColorRow
        row = CType(CType(Me.FabricBookingColorBindingSource.Current, DataRowView).Row, FabricBookingColorSearchDataSet.FabricBookingColorRow)

        Me.Shade = row.FabricColorName
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    

    
    Private Sub FrmFabricBookingColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricBookingColorTableAdapter.Fill(Me.FabricBookingColorSearchDataSet.FabricBookingColor, Me.OrderId, Me.AmendmentNo)

    End Sub

    Private Sub FabricBookingColorDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FabricBookingColorDataGridView.CellClick
        Me.FabricBookingColorDataGridView.CurrentRow.Selected = True

    End Sub
End Class
