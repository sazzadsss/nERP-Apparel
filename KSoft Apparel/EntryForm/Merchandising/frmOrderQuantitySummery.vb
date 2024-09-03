Imports System.Windows.Forms

Public Class frmOrderQuantitySummery
    Private _SID As Integer
    Public Property SID() As Integer
        Get
            Return _SID
        End Get
        Set(ByVal value As Integer)
            _SID = value
        End Set
    End Property
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Private _OrdQty As Integer
    Public Property OrdQty() As Integer
        Get
            Return _OrdQty
        End Get
        Set(ByVal value As Integer)
            _OrdQty = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OrdQty = NumericUpDown1.Value
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmOrderQuantitySummery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderQuantitySummeryByEXTableAdapter.Fill(Me.OrderQuantitySummeryByExDataSet.OrderQuantitySummeryByEX, Me.OID, Me.SID)
    End Sub


    Private Sub OrderQuantitySummeryByEXBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles OrderQuantitySummeryByEXBindingSource.PositionChanged
        NumericUpDown1.Value = 0
        For Each drv As DataRowView In Me.OrderQuantitySummeryByEXBindingSource.List
            If drv!IsSelected = True Then
                NumericUpDown1.Value = NumericUpDown1.Value + CType(drv!OrderQuantity, Integer)
            End If

        Next
    End Sub

    Private Sub NumericUpDown1_Enter(sender As Object, e As EventArgs) Handles NumericUpDown1.Enter
        NumericUpDown1.Value = 0
        For Each drv As DataRowView In Me.OrderQuantitySummeryByEXBindingSource.List
            If drv!IsSelected = True Then
                NumericUpDown1.Value = NumericUpDown1.Value + CType(drv!OrderQuantity, Integer)
            End If

        Next
    End Sub
End Class
