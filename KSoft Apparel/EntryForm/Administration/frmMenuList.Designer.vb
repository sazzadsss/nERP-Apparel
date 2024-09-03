<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim MENU_CODELabel1 As System.Windows.Forms.Label
        Dim MENU_NAMELabel As System.Windows.Forms.Label
        Dim PARENT_IDLabel As System.Windows.Forms.Label
        Dim PARENT_NAMELabel As System.Windows.Forms.Label
        Dim MENU_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuList))
        Me.MenuDataSet = New KSoft_Apparel.MenuDataSet
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New KSoft_Apparel.MenuDataSetTableAdapters.MenuTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.MenuDataSetTableAdapters.TableAdapterManager
        Me.MenuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.MenuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.colMENU_CODE = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMENU_NAME = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.MENU_CODETextBox = New System.Windows.Forms.TextBox
        Me.MENU_NAMETextBox = New System.Windows.Forms.TextBox
        Me.PARENT_IDSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.PARENT_NAMETextEdit = New DevExpress.XtraEditors.TextEdit
        Me.MENU_IDSpinEdit = New DevExpress.XtraEditors.SpinEdit
        MENU_CODELabel1 = New System.Windows.Forms.Label
        MENU_NAMELabel = New System.Windows.Forms.Label
        PARENT_IDLabel = New System.Windows.Forms.Label
        PARENT_NAMELabel = New System.Windows.Forms.Label
        MENU_IDLabel = New System.Windows.Forms.Label
        CType(Me.MenuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBindingNavigator.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARENT_IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARENT_NAMETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENU_IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MENU_CODELabel1
        '
        MENU_CODELabel1.AutoSize = True
        MENU_CODELabel1.Location = New System.Drawing.Point(14, 66)
        MENU_CODELabel1.Name = "MENU_CODELabel1"
        MENU_CODELabel1.Size = New System.Drawing.Size(75, 13)
        MENU_CODELabel1.TabIndex = 3
        MENU_CODELabel1.Text = "MENU CODE:"
        '
        'MENU_NAMELabel
        '
        MENU_NAMELabel.AutoSize = True
        MENU_NAMELabel.Location = New System.Drawing.Point(14, 92)
        MENU_NAMELabel.Name = "MENU_NAMELabel"
        MENU_NAMELabel.Size = New System.Drawing.Size(76, 13)
        MENU_NAMELabel.TabIndex = 4
        MENU_NAMELabel.Text = "MENU NAME:"
        '
        'PARENT_IDLabel
        '
        PARENT_IDLabel.AutoSize = True
        PARENT_IDLabel.Location = New System.Drawing.Point(364, 63)
        PARENT_IDLabel.Name = "PARENT_IDLabel"
        PARENT_IDLabel.Size = New System.Drawing.Size(68, 13)
        PARENT_IDLabel.TabIndex = 6
        PARENT_IDLabel.Text = "PARENT ID:"
        '
        'PARENT_NAMELabel
        '
        PARENT_NAMELabel.AutoSize = True
        PARENT_NAMELabel.Location = New System.Drawing.Point(363, 92)
        PARENT_NAMELabel.Name = "PARENT_NAMELabel"
        PARENT_NAMELabel.Size = New System.Drawing.Size(88, 13)
        PARENT_NAMELabel.TabIndex = 8
        PARENT_NAMELabel.Text = "PARENT NAME:"
        '
        'MENU_IDLabel
        '
        MENU_IDLabel.AutoSize = True
        MENU_IDLabel.Location = New System.Drawing.Point(14, 40)
        MENU_IDLabel.Name = "MENU_IDLabel"
        MENU_IDLabel.Size = New System.Drawing.Size(56, 13)
        MENU_IDLabel.TabIndex = 10
        MENU_IDLabel.Text = "MENU ID:"
        '
        'MenuDataSet
        '
        Me.MenuDataSet.DataSetName = "MenuDataSet"
        Me.MenuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.MenuDataSet
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MenuTableAdapter = Me.MenuTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MenuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuBindingNavigator
        '
        Me.MenuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MenuBindingNavigator.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.ToolbarBackground
        Me.MenuBindingNavigator.BindingSource = Me.MenuBindingSource
        Me.MenuBindingNavigator.CountItem = Nothing
        Me.MenuBindingNavigator.DeleteItem = Nothing
        Me.MenuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.MenuBindingNavigatorSaveItem})
        Me.MenuBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MenuBindingNavigator.MoveFirstItem = Nothing
        Me.MenuBindingNavigator.MoveLastItem = Nothing
        Me.MenuBindingNavigator.MoveNextItem = Nothing
        Me.MenuBindingNavigator.MovePreviousItem = Nothing
        Me.MenuBindingNavigator.Name = "MenuBindingNavigator"
        Me.MenuBindingNavigator.PositionItem = Nothing
        Me.MenuBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.MenuBindingNavigator.TabIndex = 0
        Me.MenuBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'MenuBindingNavigatorSaveItem
        '
        Me.MenuBindingNavigatorSaveItem.Image = CType(resources.GetObject("MenuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MenuBindingNavigatorSaveItem.Name = "MenuBindingNavigatorSaveItem"
        Me.MenuBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.MenuBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.Empty.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TreeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TreeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TreeList1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TreeList1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TreeList1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupButton.Options.UseForeColor = True
        Me.TreeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TreeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeList1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TreeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeList1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TreeList1.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.TreeList1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TreeList1.Appearance.Preview.Options.UseBackColor = True
        Me.TreeList1.Appearance.Preview.Options.UseForeColor = True
        Me.TreeList1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.TreeList1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.Row.Options.UseBackColor = True
        Me.TreeList1.Appearance.Row.Options.UseForeColor = True
        Me.TreeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.TreeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.TreeList1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeList1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TreeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.TreeList1.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TreeList1.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colMENU_CODE, Me.colMENU_NAME})
        Me.TreeList1.DataSource = Me.MenuBindingSource
        Me.TreeList1.KeyFieldName = "MENU_ID"
        Me.TreeList1.Location = New System.Drawing.Point(17, 125)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeList1.OptionsView.EnableAppearanceOddRow = True
        Me.TreeList1.ParentFieldName = "PARENT_ID"
        Me.TreeList1.PreviewFieldName = "MENU_CODE"
        Me.TreeList1.Size = New System.Drawing.Size(604, 367)
        Me.TreeList1.TabIndex = 2
        '
        'colMENU_CODE
        '
        Me.colMENU_CODE.Caption = "MENU_CODE"
        Me.colMENU_CODE.FieldName = "MENU_CODE"
        Me.colMENU_CODE.Name = "colMENU_CODE"
        Me.colMENU_CODE.Visible = True
        Me.colMENU_CODE.VisibleIndex = 0
        Me.colMENU_CODE.Width = 245
        '
        'colMENU_NAME
        '
        Me.colMENU_NAME.Caption = "MENU_NAME"
        Me.colMENU_NAME.FieldName = "MENU_NAME"
        Me.colMENU_NAME.Name = "colMENU_NAME"
        Me.colMENU_NAME.Visible = True
        Me.colMENU_NAME.VisibleIndex = 1
        Me.colMENU_NAME.Width = 321
        '
        'MENU_CODETextBox
        '
        Me.MENU_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "MENU_CODE", True))
        Me.MENU_CODETextBox.Location = New System.Drawing.Point(95, 63)
        Me.MENU_CODETextBox.Name = "MENU_CODETextBox"
        Me.MENU_CODETextBox.Size = New System.Drawing.Size(262, 20)
        Me.MENU_CODETextBox.TabIndex = 4
        '
        'MENU_NAMETextBox
        '
        Me.MENU_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "MENU_NAME", True))
        Me.MENU_NAMETextBox.Location = New System.Drawing.Point(95, 89)
        Me.MENU_NAMETextBox.Name = "MENU_NAMETextBox"
        Me.MENU_NAMETextBox.Size = New System.Drawing.Size(262, 20)
        Me.MENU_NAMETextBox.TabIndex = 5
        '
        'PARENT_IDSpinEdit
        '
        Me.PARENT_IDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource, "PARENT_ID", True))
        Me.PARENT_IDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PARENT_IDSpinEdit.Location = New System.Drawing.Point(457, 63)
        Me.PARENT_IDSpinEdit.Name = "PARENT_IDSpinEdit"
        Me.PARENT_IDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PARENT_IDSpinEdit.Size = New System.Drawing.Size(81, 20)
        Me.PARENT_IDSpinEdit.TabIndex = 7
        '
        'PARENT_NAMETextEdit
        '
        Me.PARENT_NAMETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource, "PARENT_NAME", True))
        Me.PARENT_NAMETextEdit.Location = New System.Drawing.Point(457, 89)
        Me.PARENT_NAMETextEdit.Name = "PARENT_NAMETextEdit"
        Me.PARENT_NAMETextEdit.Size = New System.Drawing.Size(164, 20)
        Me.PARENT_NAMETextEdit.TabIndex = 9
        '
        'MENU_IDSpinEdit
        '
        Me.MENU_IDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource, "MENU_ID", True))
        Me.MENU_IDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MENU_IDSpinEdit.Location = New System.Drawing.Point(95, 37)
        Me.MENU_IDSpinEdit.Name = "MENU_IDSpinEdit"
        Me.MENU_IDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MENU_IDSpinEdit.Properties.ReadOnly = True
        Me.MENU_IDSpinEdit.Size = New System.Drawing.Size(79, 20)
        Me.MENU_IDSpinEdit.TabIndex = 11
        '
        'frmMenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 504)
        Me.Controls.Add(MENU_IDLabel)
        Me.Controls.Add(Me.MENU_IDSpinEdit)
        Me.Controls.Add(PARENT_NAMELabel)
        Me.Controls.Add(Me.PARENT_NAMETextEdit)
        Me.Controls.Add(PARENT_IDLabel)
        Me.Controls.Add(Me.PARENT_IDSpinEdit)
        Me.Controls.Add(MENU_NAMELabel)
        Me.Controls.Add(Me.MENU_NAMETextBox)
        Me.Controls.Add(MENU_CODELabel1)
        Me.Controls.Add(Me.MENU_CODETextBox)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.MenuBindingNavigator)
        Me.Name = "frmMenuList"
        Me.Text = "Menu List"
        CType(Me.MenuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBindingNavigator.ResumeLayout(False)
        Me.MenuBindingNavigator.PerformLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARENT_IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARENT_NAMETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENU_IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuDataSet As KSoft_Apparel.MenuDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As KSoft_Apparel.MenuDataSetTableAdapters.MenuTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.MenuDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colMENU_CODE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMENU_NAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents MENU_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MENU_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARENT_IDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PARENT_NAMETextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MENU_IDSpinEdit As DevExpress.XtraEditors.SpinEdit
End Class
