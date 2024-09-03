<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreyFabricStoreReportCompact
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FinishUnitComboBox = New System.Windows.Forms.ComboBox()
        Me.BulkButton = New System.Windows.Forms.Button()
        Me.ShowCompactButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MultipleProgramTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Dyeing.FinishFabricOrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SampleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BulkRadioButton = New System.Windows.Forms.RadioButton()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Dyeing.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BuyerDataSet = New KSoft_Dyeing.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Dyeing.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.ShowByBuyerButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(105, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Select Units :"
        '
        'FinishUnitComboBox
        '
        Me.FinishUnitComboBox.FormattingEnabled = True
        Me.FinishUnitComboBox.Items.AddRange(New Object() {"Kg", "Pcs", "Yrds"})
        Me.FinishUnitComboBox.Location = New System.Drawing.Point(180, 45)
        Me.FinishUnitComboBox.Name = "FinishUnitComboBox"
        Me.FinishUnitComboBox.Size = New System.Drawing.Size(69, 21)
        Me.FinishUnitComboBox.TabIndex = 105
        '
        'BulkButton
        '
        Me.BulkButton.Location = New System.Drawing.Point(255, 17)
        Me.BulkButton.Name = "BulkButton"
        Me.BulkButton.Size = New System.Drawing.Size(108, 49)
        Me.BulkButton.TabIndex = 104
        Me.BulkButton.Text = "&Show Running"
        Me.BulkButton.UseVisualStyleBackColor = True
        '
        'ShowCompactButton
        '
        Me.ShowCompactButton.Location = New System.Drawing.Point(986, 17)
        Me.ShowCompactButton.Name = "ShowCompactButton"
        Me.ShowCompactButton.Size = New System.Drawing.Size(74, 49)
        Me.ShowCompactButton.TabIndex = 111
        Me.ShowCompactButton.Text = "&Show"
        Me.ShowCompactButton.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(815, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(19, 13)
        Me.LinkLabel1.TabIndex = 110
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>"
        '
        'MultipleProgramTextBox2
        '
        Me.MultipleProgramTextBox2.Location = New System.Drawing.Point(842, 17)
        Me.MultipleProgramTextBox2.Multiline = True
        Me.MultipleProgramTextBox2.Name = "MultipleProgramTextBox2"
        Me.MultipleProgramTextBox2.Size = New System.Drawing.Size(138, 48)
        Me.MultipleProgramTextBox2.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(684, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Filter by Program No :"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(687, 46)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(118, 20)
        Me.GridLookUpEdit1.TabIndex = 107
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.Location = New System.Drawing.Point(180, 19)
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(69, 20)
        Me.StockNumericUpDown.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(105, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Stock >=:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SampleRadioButton)
        Me.GroupBox2.Controls.Add(Me.BulkRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(86, 58)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulk/Sample"
        '
        'SampleRadioButton
        '
        Me.SampleRadioButton.AutoSize = True
        Me.SampleRadioButton.Location = New System.Drawing.Point(15, 37)
        Me.SampleRadioButton.Name = "SampleRadioButton"
        Me.SampleRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SampleRadioButton.TabIndex = 1
        Me.SampleRadioButton.TabStop = True
        Me.SampleRadioButton.Text = "Sample"
        Me.SampleRadioButton.UseVisualStyleBackColor = True
        '
        'BulkRadioButton
        '
        Me.BulkRadioButton.AutoSize = True
        Me.BulkRadioButton.Checked = True
        Me.BulkRadioButton.Location = New System.Drawing.Point(15, 17)
        Me.BulkRadioButton.Name = "BulkRadioButton"
        Me.BulkRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.BulkRadioButton.TabIndex = 0
        Me.BulkRadioButton.TabStop = True
        Me.BulkRadioButton.Text = "Bulk"
        Me.BulkRadioButton.UseVisualStyleBackColor = True
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 76)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1140, 564)
        Me.CrystalReportViewer1.TabIndex = 115
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'ShowByBuyerButton
        '
        Me.ShowByBuyerButton.Location = New System.Drawing.Point(572, 31)
        Me.ShowByBuyerButton.Name = "ShowByBuyerButton"
        Me.ShowByBuyerButton.Size = New System.Drawing.Size(96, 21)
        Me.ShowByBuyerButton.TabIndex = 118
        Me.ShowByBuyerButton.Text = "&Show Running"
        Me.ShowByBuyerButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(374, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Buyer :"
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.EditValue = "[Type Buyer]"
        Me.BuyerLookupGridLookUpEdit.Location = New System.Drawing.Point(420, 32)
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerLookupGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerLookupGridLookUpEdit.Properties.NullText = "[Type Buyer Name]"
        Me.BuyerLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerLookupGridLookUpEdit.Properties.ValueMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.View = Me.GridView2
        Me.BuyerLookupGridLookUpEdit.Size = New System.Drawing.Size(146, 20)
        Me.BuyerLookupGridLookUpEdit.TabIndex = 116
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1066, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 49)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "&Show Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGreyFabricStoreReportCompact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 641)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowByBuyerButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BuyerLookupGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StockNumericUpDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShowCompactButton)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MultipleProgramTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FinishUnitComboBox)
        Me.Controls.Add(Me.BulkButton)
        Me.Name = "frmGreyFabricStoreReportCompact"
        Me.Text = "Grey Fabric Store Compact Report"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents FinishUnitComboBox As ComboBox
    Friend WithEvents BulkButton As Button
    Friend WithEvents ShowCompactButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MultipleProgramTextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StockNumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SampleRadioButton As RadioButton
    Friend WithEvents BulkRadioButton As RadioButton
    Friend WithEvents FinishFabricOrderLookupBindingSource As BindingSource
    Friend WithEvents FinishFabricOrderLookupDataSet As FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupTableAdapter As FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents ShowByBuyerButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
End Class
