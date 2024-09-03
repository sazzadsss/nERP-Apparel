<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreCostingOpenValueless5
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RequisitionDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RequisitionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CompletedRadioButton = New System.Windows.Forms.RadioButton()
        Me.ApprovedRadioButton = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuyerButton = New System.Windows.Forms.Button()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 51)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1066, 382)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(573, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "&Show < then"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RequisitionDateTimePicker2
        '
        Me.RequisitionDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker2.Location = New System.Drawing.Point(295, 22)
        Me.RequisitionDateTimePicker2.Name = "RequisitionDateTimePicker2"
        Me.RequisitionDateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker2.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Date From :"
        '
        'RequisitionDateTimePicker
        '
        Me.RequisitionDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker.Location = New System.Drawing.Point(183, 22)
        Me.RequisitionDateTimePicker.Name = "RequisitionDateTimePicker"
        Me.RequisitionDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker.TabIndex = 34
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.Location = New System.Drawing.Point(498, 22)
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(69, 20)
        Me.StockNumericUpDown.TabIndex = 115
        Me.StockNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(397, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Open Value $ % <:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CompletedRadioButton)
        Me.GroupBox2.Controls.Add(Me.ApprovedRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 40)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approved/Completed"
        '
        'CompletedRadioButton
        '
        Me.CompletedRadioButton.AutoSize = True
        Me.CompletedRadioButton.Location = New System.Drawing.Point(92, 17)
        Me.CompletedRadioButton.Name = "CompletedRadioButton"
        Me.CompletedRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.CompletedRadioButton.TabIndex = 1
        Me.CompletedRadioButton.TabStop = True
        Me.CompletedRadioButton.Text = "Completed"
        Me.CompletedRadioButton.UseVisualStyleBackColor = True
        '
        'ApprovedRadioButton
        '
        Me.ApprovedRadioButton.AutoSize = True
        Me.ApprovedRadioButton.Checked = True
        Me.ApprovedRadioButton.Location = New System.Drawing.Point(15, 17)
        Me.ApprovedRadioButton.Name = "ApprovedRadioButton"
        Me.ApprovedRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.ApprovedRadioButton.TabIndex = 0
        Me.ApprovedRadioButton.TabStop = True
        Me.ApprovedRadioButton.Text = "Approved"
        Me.ApprovedRadioButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(654, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "&Show All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(739, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Buyer:"
        '
        'BuyerButton
        '
        Me.BuyerButton.Location = New System.Drawing.Point(894, 20)
        Me.BuyerButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.BuyerButton.Name = "BuyerButton"
        Me.BuyerButton.Size = New System.Drawing.Size(74, 22)
        Me.BuyerButton.TabIndex = 119
        Me.BuyerButton.Tag = "NR"
        Me.BuyerButton.Text = "Show"
        Me.BuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(786, 22)
        Me.BuyerGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(102, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 118
        Me.BuyerGridLookUpEdit.Tag = "NR"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.colBuyerCode, Me.colBuyerName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'frmPreCostingOpenValueless5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BuyerButton)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StockNumericUpDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RequisitionDateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RequisitionDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmPreCostingOpenValueless5"
        Me.Text = "Pre Costing/Budget List"
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button2 As Button
    Friend WithEvents RequisitionDateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RequisitionDateTimePicker As DateTimePicker
    Friend WithEvents StockNumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CompletedRadioButton As RadioButton
    Friend WithEvents ApprovedRadioButton As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents Label2 As Label
    Friend WithEvents BuyerButton As Button
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
End Class
