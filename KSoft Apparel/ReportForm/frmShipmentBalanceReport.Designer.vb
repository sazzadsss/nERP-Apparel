<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentBalanceReport
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
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.DetailsRadioButton = New System.Windows.Forms.RadioButton()
        Me.CompactRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.CancelOrderCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.FabricStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FFDBalanceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BalancePercentageNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FFDBalanceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalancePercentageNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 144)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1290, 343)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(89, 13)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FromDateTimePicker.TabIndex = 1
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(224, 13)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.ToDateTimePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To :"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(863, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(99, 81)
        Me.ShowButton.TabIndex = 6
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'DetailsRadioButton
        '
        Me.DetailsRadioButton.AutoSize = True
        Me.DetailsRadioButton.Checked = True
        Me.DetailsRadioButton.Location = New System.Drawing.Point(5, 15)
        Me.DetailsRadioButton.Name = "DetailsRadioButton"
        Me.DetailsRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.DetailsRadioButton.TabIndex = 7
        Me.DetailsRadioButton.TabStop = True
        Me.DetailsRadioButton.Text = "Details"
        Me.DetailsRadioButton.UseVisualStyleBackColor = True
        '
        'CompactRadioButton
        '
        Me.CompactRadioButton.AutoSize = True
        Me.CompactRadioButton.Location = New System.Drawing.Point(61, 15)
        Me.CompactRadioButton.Name = "CompactRadioButton"
        Me.CompactRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.CompactRadioButton.TabIndex = 8
        Me.CompactRadioButton.Text = "Compact"
        Me.CompactRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BuyerCheckBox)
        Me.GroupBox1.Controls.Add(Me.CancelOrderCheckBox)
        Me.GroupBox1.Controls.Add(Me.BuyerComboBox)
        Me.GroupBox1.Controls.Add(Me.FabricStatusCheckBox)
        Me.GroupBox1.Controls.Add(Me.CompactRadioButton)
        Me.GroupBox1.Controls.Add(Me.DetailsRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(350, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 38)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Type"
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(237, 16)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.BuyerCheckBox.TabIndex = 7
        Me.BuyerCheckBox.Text = "Buyer"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'CancelOrderCheckBox
        '
        Me.CancelOrderCheckBox.AutoSize = True
        Me.CancelOrderCheckBox.Location = New System.Drawing.Point(376, 15)
        Me.CancelOrderCheckBox.Name = "CancelOrderCheckBox"
        Me.CancelOrderCheckBox.Size = New System.Drawing.Size(126, 17)
        Me.CancelOrderCheckBox.TabIndex = 8
        Me.CancelOrderCheckBox.Text = "Include Cancel Order"
        Me.CancelOrderCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.Enabled = False
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(296, 13)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(74, 21)
        Me.BuyerComboBox.TabIndex = 6
        Me.BuyerComboBox.ValueMember = "BuyerId"
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
        'FabricStatusCheckBox
        '
        Me.FabricStatusCheckBox.AutoSize = True
        Me.FabricStatusCheckBox.Enabled = False
        Me.FabricStatusCheckBox.Location = New System.Drawing.Point(127, 16)
        Me.FabricStatusCheckBox.Name = "FabricStatusCheckBox"
        Me.FabricStatusCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.FabricStatusCheckBox.TabIndex = 9
        Me.FabricStatusCheckBox.Text = "With Fabric Status"
        Me.FabricStatusCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.FFDBalanceNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BalancePercentageNumericUpDown)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 39)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condition"
        '
        'FFDBalanceNumericUpDown
        '
        Me.FFDBalanceNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.FFDBalanceNumericUpDown.Location = New System.Drawing.Point(411, 12)
        Me.FFDBalanceNumericUpDown.Name = "FFDBalanceNumericUpDown"
        Me.FFDBalanceNumericUpDown.Size = New System.Drawing.Size(75, 20)
        Me.FFDBalanceNumericUpDown.TabIndex = 7
        Me.FFDBalanceNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fab. Del. Balance (%) >="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Shipment Balance (%) >="
        '
        'BalancePercentageNumericUpDown
        '
        Me.BalancePercentageNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.BalancePercentageNumericUpDown.Location = New System.Drawing.Point(174, 12)
        Me.BalancePercentageNumericUpDown.Name = "BalancePercentageNumericUpDown"
        Me.BalancePercentageNumericUpDown.Size = New System.Drawing.Size(75, 20)
        Me.BalancePercentageNumericUpDown.TabIndex = 3
        Me.BalancePercentageNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ToDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.FromDateTimePicker)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(327, 38)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ex Date Date:"
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1188, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Shipment Completed/Closed Program"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Select Program No"
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(176, 12)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(310, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 25
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 99)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 39)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Program"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(863, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(968, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 48)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Show Running Program Shipment Balance"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1075, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 48)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Show Running Program PO Wise Shipment Balance"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1075, 99)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 40)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "&Show PO Wise"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1075, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 27)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Show Only PO Ship Bal"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(968, 64)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 27)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Show Only PO Ship Bal"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmShipmentBalanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 488)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmShipmentBalanceReport"
        Me.Text = "Shipment Balance Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FFDBalanceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalancePercentageNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents DetailsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CompactRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BalancePercentageNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuyerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents CancelOrderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FabricStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FFDBalanceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
