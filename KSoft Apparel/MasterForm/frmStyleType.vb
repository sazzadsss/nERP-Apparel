Public Class frmStyleType

    Private Sub frmStyleType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)

        If CheckUserRights("Style Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Style Type").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StyleTypeMstBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StyleTypeDataSet)
    End Sub

    Private Sub SetColorToolStripLabel_Click(sender As Object, e As EventArgs) Handles SetColorToolStripLabel.Click

        Dim col As New ColorDialog
        col.ShowDialog()

        Dim color As String = col.Color.ToArgb().ToString
        'color = color.Substring(2, 6)
        'color = "#" + color

        Dim row As StyleTypeDataSet.StyleTypeMstRow
        row = CType(CType(Me.StyleTypeMstBindingSource.Current, DataRowView).Row, StyleTypeDataSet.StyleTypeMstRow)


        row.ColorCode = color

        'MessageBox.Show(color)
        'Button1.BackColor = System.Drawing.ColorTranslator.FromHtml(color)

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.Column.Caption = "Color" Then

            If DBNull.Value.Equals(e.CellValue) = False Then

                e.Appearance.BackColor = Color.FromArgb(e.CellValue)
                e.Appearance.ForeColor = Color.FromArgb(e.CellValue)

            End If

        End If
    End Sub
End Class