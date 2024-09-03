Public Class frmOrderQuantity
    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property
    Private _FabricColorId As Integer
    Public Property FabricColorId() As Integer
        Get
            Return _FabricColorId
        End Get
        Set(ByVal value As Integer)
            _FabricColorId = value
        End Set
    End Property
    Private _OrderQuantity As Integer
    Public Property OrderQuantity() As Integer
        Get
            Return _OrderQuantity
        End Get
        Set(ByVal value As Integer)
            _OrderQuantity = value
        End Set
    End Property



    Private Sub frmOrderQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Color_Size_OrderQuantityTableAdapter.FillByOrderIdAndColorId(Me.Color_Size_OrderQuantityDataSet.Color_Size_OrderQuantity, Me.OrderId, Me.FabricColorId)

    End Sub

    
    Private Sub Color_Size_OrderQuantityDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Color_Size_OrderQuantityDataGridView.CellEndEdit

        Dim varOrderQuantity As Integer = 0

        For Each drv As DataRowView In Color_Size_OrderQuantityBindingSource.List


            If drv!CheckBoxColumn Then
                varOrderQuantity = varOrderQuantity + drv!OrderQuantity
            End If

        Next

        OrderQuantityLabel.Text = varOrderQuantity

        Me.OrderQuantity = varOrderQuantity



    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

   
    Private Sub DialogCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogCancelButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class