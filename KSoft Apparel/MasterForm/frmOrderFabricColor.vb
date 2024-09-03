Public Class frmOrderFabricColor
    Private _prOrderId As Integer
    Public Property prOrderId() As Integer
        Get
            Return _prOrderId
        End Get
        Set(ByVal value As Integer)
            _prOrderId = value
        End Set
    End Property

    Private _prFabricColorName As String
    Public Property prFabricColorName() As String
        Get
            Return _prFabricColorName
        End Get
        Set(ByVal value As String)
            _prFabricColorName = value
        End Set
    End Property
    Private _prProgramNo As String
    Public Property prProgramNo() As String
        Get
            Return _prProgramNo
        End Get
        Set(ByVal value As String)
            _prProgramNo = value
        End Set
    End Property
    Private _prFabricColorId As Integer
    Public Property prFabricColorId() As Integer
        Get
            Return _prFabricColorId
        End Get
        Set(ByVal value As Integer)
            _prFabricColorId = value
        End Set
    End Property




    Private Sub OrderFabricColorDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles OrderFabricColorDataGridView.RowHeaderMouseDoubleClick

        Dim row As OrderFabricColorDataSet.OrderFabricColorRow
        row = CType(CType(Me.OrderFabricColorBindingSource.Current, DataRowView).Row, OrderFabricColorDataSet.OrderFabricColorRow)

        FabricColorIdvar = row.FabricColorId

        Me.prOrderId = row.OrderId
        Me.prFabricColorId = row.FabricColorId
        Me.prFabricColorName = row.FabricColorName

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

 

   
    Private Sub frmOrderFabricColor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Dim ProgramNo As String

        If Me.prOrderId = Nothing Or Me.prOrderId.ToString = String.Empty Then

            ProgramNo = Me.ProgramNo.ToString

        Else

            ProgramNo = ReadStringData("Select  ProgramNo From [Order] Where OrderId =" & Me.prOrderId, cnn)

        End If

        If ProgramNo <> Nothing Then
            Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNo)
        End If


    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged

        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, GridLookUpEdit1.Text)

    End Sub

End Class