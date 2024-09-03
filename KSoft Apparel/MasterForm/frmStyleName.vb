Public Class frmStyleName

    Private _StyleNameId As Integer
    Public Property StyleNameId() As Integer
        Get
            Return _StyleNameId
        End Get
        Set(ByVal value As Integer)
            _StyleNameId = value
        End Set
    End Property

    Private Sub StyleNameMstBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleNameMstBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.StyleNameMstBindingSource.EndEdit()

        Dim row As StyleDataSet.StyleNameMstRow
        row = CType(CType(Me.StyleNameMstBindingSource.Current, DataRowView).Row, StyleDataSet.StyleNameMstRow)

        Dim Check As Int32 = ReadIntData("Select Count(StyleNameId) From StyleNameMst Where StyleName = '" & row.StyleName & "'", cnn)
        If Check <= 0 Then
            Me.Validate()
            Me.StyleNameMstBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StyleDataSet)
        Else
            MessageBox.Show("Style Name Already Exist")
        End If


    End Sub

    Private Sub frmStyleName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)

        If CheckUserRights("Style Name").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            StyleNameMstBindingNavigatorSaveItem.Enabled = False

        End If

    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        Me.StyleNameMstBindingSource.Filter = "StyleName like '%" & SearchTextBox.Text & "%'"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.StyleNameMstBindingSource.Filter = ""
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click


        If Me.StyleNameMstBindingSource.Position > -1 Then

            Dim row As StyleDataSet.StyleNameMstRow
            row = CType(CType(Me.StyleNameMstBindingSource.Current, DataRowView).Row, StyleDataSet.StyleNameMstRow)

            Me.StyleNameId = row.StyleNameId

        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNCancelButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

End Class