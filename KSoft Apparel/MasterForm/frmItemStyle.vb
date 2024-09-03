Public Class frmItemStyle

    Private _ItemStyleId As Integer
    Public Property ItemStyleId() As Integer
        Get
            Return _ItemStyleId
        End Get
        Set(ByVal value As Integer)
            _ItemStyleId = value
        End Set
    End Property

    
    Private Sub ItemStyleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemStyleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemStyleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

    End Sub

    Private Sub frmItemStyle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        'Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)

        Me.BookingDataSet.ItemStyle.UserIdColumn.DefaultValue = UserId
        Me.BookingDataSet.ItemStyle.ModifiedDateColumn.DefaultValue = Today()
        SearchTextBox.Focus()


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        Me.ItemStyleTableAdapter.FillByItemStyle(Me.BookingDataSet.ItemStyle, SearchTextBox.Text)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.BookingDataSet.ItemStyle.ItemStyleColumn.DefaultValue = SearchTextBox.Text.Replace(" ", "").ToUpper

    End Sub

  
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click


        Me.Validate()
        Me.ItemStyleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

       
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Dim row As BookingDataSet.ItemStyleRow
        row = CType(CType(Me.ItemStyleBindingSource.Current, DataRowView).Row, BookingDataSet.ItemStyleRow)

        Me.ItemStyleId = row.ItemStyleId
        Me.Close()

    End Sub
End Class