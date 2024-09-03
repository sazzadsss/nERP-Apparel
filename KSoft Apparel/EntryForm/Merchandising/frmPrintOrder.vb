Public Class frmPrintOrder
    Private _OrId As Integer
    Public Property OrId() As Integer
        Get
            Return _OrId
        End Get
        Set(ByVal value As Integer)
            _OrId = value
        End Set
    End Property
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property

    Private Sub frmPrintOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPrintOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)

        

        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox.SelectedValue)



        Dim OrderIndex As Integer

        'If Me.pProgramNo <> String.Empty Then

        OrderIndex = Me.OrderLookupBindingSource.Find("ProgramNo", Me.PrgNo)

        'End If

        Me.OrderLookupBindingSource.Position = OrderIndex
        'Me.ProgramNoComboBox.Text = Me.pProgramNo

        Me.PrintProductionDataSet.PrintOrder.OrderIdColumn.DefaultValue = ProgramNoComboBox.SelectedValue


        'Start -------- Check and Set user rights

        Dim CANEDIT As Boolean
        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Printing Order'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then
            SaveButton.Enabled = False
        End If

        'End ------- Check and Set user rights

        ProgramNoTextBox.Visible = OutSideRadioButton.Checked
        FabricColorTextBox.Visible = OutSideRadioButton.Checked
        ProgramNoComboBox.Visible = InHouseRadioButton.Checked
        FabricColorComboBox.Visible = InHouseRadioButton.Checked

    End Sub

   

    
    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged

    

    'End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Me.Validate()
        Me.PrintOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)


        LoadAutoCompleteList("Select Distinct ProgramNo From PrintOrder", ProgramNoTextBox)


    End Sub

    Private Sub PrintOrderDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintOrderDataGridView.DoubleClick

    End Sub



    Private Sub PrintOrderDataGridView_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PrintOrderDataGridView.RowHeaderMouseDoubleClick

        Me.Validate()
        Me.PrintOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)

        Dim row As PrintProductionDataSet.PrintOrderRow
        row = CType(CType(Me.PrintOrderBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintOrderRow)

        Me.PrgNo = row.ProgramNo
        PrintOrderId = row.PrintOrderId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ProgramNoComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.TextChanged
        ProgramNoTextBox.Text = ProgramNoComboBox.Text
        FabricColorTextBox.Text = Me.FabricColorComboBox.Text
    End Sub

    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.TextChanged

        If InHouseRadioButton.Checked Then

            Me.PrintOrderTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrder, ProgramNoComboBox.SelectedValue)
            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox.SelectedValue)
            Me.PrintProductionDataSet.PrintOrder.OrderIdColumn.DefaultValue = ProgramNoComboBox.SelectedValue
            Me.PrintProductionDataSet.PrintOrder.ProgramNoColumn.DefaultValue = ProgramNoTextBox.Text
            FabricColorTextBox.Text = Me.FabricColorComboBox.Text
        Else
            Me.PrintOrderTableAdapter.FillByProgramNo(Me.PrintProductionDataSet.PrintOrder, ProgramNoTextBox.Text)
            Me.PrintProductionDataSet.PrintOrder.OrderIdColumn.DefaultValue = DBNull.Value
            Me.PrintProductionDataSet.PrintOrder.ProgramNoColumn.DefaultValue = ProgramNoTextBox.Text
            FabricColorTextBox.Text = String.Empty
        End If



       
    End Sub

    Private Sub InHouseRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InHouseRadioButton.CheckedChanged

        ProgramNoTextBox.Visible = OutSideRadioButton.Checked
        FabricColorTextBox.Visible = OutSideRadioButton.Checked
        ProgramNoComboBox.Visible = InHouseRadioButton.Checked
        FabricColorComboBox.Visible = InHouseRadioButton.Checked

    End Sub

    Private Sub OutSideRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutSideRadioButton.CheckedChanged
        ProgramNoTextBox.Visible = OutSideRadioButton.Checked
        FabricColorTextBox.Visible = OutSideRadioButton.Checked
        ProgramNoComboBox.Visible = InHouseRadioButton.Checked
        FabricColorComboBox.Visible = InHouseRadioButton.Checked
        LoadAutoCompleteList("Select Distinct ProgramNo From PrintOrder", ProgramNoTextBox)

    End Sub

    Private Sub FabricColorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorTextBox.TextChanged
        'On Error Resume Next

        Me.PrintProductionDataSet.PrintOrder.FabricColorNameColumn.DefaultValue = Me.FabricColorTextBox.Text

        If InHouseRadioButton.Checked Then
            Me.PrintProductionDataSet.PrintOrder.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        Else
            Me.PrintProductionDataSet.PrintOrder.FabricColorIdColumn.DefaultValue = DBNull.Value
            Me.PrintProductionDataSet.PrintOrder.PrintOrderQuantityColumn.DefaultValue = 0
        End If

    End Sub

    Private Sub FabricColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.LostFocus
        On Error Resume Next

        Me.PrintProductionDataSet.PrintOrder.PrintOrderQuantityColumn.DefaultValue = ReadIntegerData("Select TotalOrderQuantity From OrderSummery_Colorwise Where OrderId = " & ProgramNoComboBox.SelectedValue & " And FabricColorId = " & FabricColorComboBox.SelectedValue, cnn)
    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        'On Error Resume Next

        FabricColorTextBox.Text = Me.FabricColorComboBox.Text

        If InHouseRadioButton.Checked Then
            Me.PrintProductionDataSet.PrintOrder.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        Else
            Me.PrintProductionDataSet.PrintOrder.FabricColorIdColumn.DefaultValue = DBNull.Value
            Me.PrintProductionDataSet.PrintOrder.PrintOrderQuantityColumn.DefaultValue = 0
        End If

    End Sub

    
    Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged

        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, Me.ProgramNoComboBox.SelectedValue)
        Me.PrintProductionDataSet.PrintOrder.OrderIdColumn.DefaultValue = Me.ProgramNoComboBox.SelectedValue

    End Sub
End Class