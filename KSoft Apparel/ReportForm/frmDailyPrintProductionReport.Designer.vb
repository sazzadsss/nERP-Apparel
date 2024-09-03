<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDailyPrintProductionReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OrderIdLabel As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProdHourButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PostCostingButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SummeryButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintOrderNewLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderNewLookupDataSet = New KSoft_Apparel.PrintOrderNewLookupDataSet()
        Me.PrintOrderNewLookupTableAdapter = New KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter()
        Me.ShowByPrintOrderButton = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SampleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BulkRadioButton = New System.Windows.Forms.RadioButton()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        OrderIdLabel = New System.Windows.Forms.Label()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(678, 24)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(220, 13)
        OrderIdLabel.TabIndex = 86
        OrderIdLabel.Text = "Program No:: Style No:: Print Work Order No:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 78)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1298, 568)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(167, 24)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(85, 20)
        Me.FromDateTimePicker.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Print Production Date :"
        '
        'ShowButton
        '
        Me.ShowButton.Appearance.Options.UseTextOptions = True
        Me.ShowButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ShowButton.Location = New System.Drawing.Point(476, 24)
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(89, 48)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "Show Production Details"
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
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(283, 24)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.ToDateTimePicker.TabIndex = 9
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerName"
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(167, 51)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(204, 21)
        Me.BuyerComboBox.TabIndex = 11
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
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(108, 53)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.BuyerCheckBox.TabIndex = 12
        Me.BuyerCheckBox.Text = "Buyer:"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'ProdHourButton
        '
        Me.ProdHourButton.Appearance.Options.UseTextOptions = True
        Me.ProdHourButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ProdHourButton.Location = New System.Drawing.Point(571, 24)
        Me.ProdHourButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ProdHourButton.Name = "ProdHourButton"
        Me.ProdHourButton.Size = New System.Drawing.Size(89, 48)
        Me.ProdHourButton.TabIndex = 13
        Me.ProdHourButton.Text = "Show Production Hour"
        '
        'PostCostingButton
        '
        Me.PostCostingButton.Appearance.Options.UseTextOptions = True
        Me.PostCostingButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PostCostingButton.Location = New System.Drawing.Point(1244, 24)
        Me.PostCostingButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PostCostingButton.Name = "PostCostingButton"
        Me.PostCostingButton.Size = New System.Drawing.Size(52, 48)
        Me.PostCostingButton.TabIndex = 14
        Me.PostCostingButton.Text = "Post Costing"
        '
        'SummeryButton
        '
        Me.SummeryButton.Appearance.Options.UseTextOptions = True
        Me.SummeryButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SummeryButton.Location = New System.Drawing.Point(381, 24)
        Me.SummeryButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(89, 48)
        Me.SummeryButton.TabIndex = 16
        Me.SummeryButton.Text = "Show Prooduction Summery"
        '
        'PrintOrderNewLookupBindingSource
        '
        Me.PrintOrderNewLookupBindingSource.DataMember = "PrintOrderNewLookup"
        Me.PrintOrderNewLookupBindingSource.DataSource = Me.PrintOrderNewLookupDataSet
        '
        'PrintOrderNewLookupDataSet
        '
        Me.PrintOrderNewLookupDataSet.DataSetName = "PrintOrderNewLookupDataSet"
        Me.PrintOrderNewLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintOrderNewLookupTableAdapter
        '
        Me.PrintOrderNewLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowByPrintOrderButton
        '
        Me.ShowByPrintOrderButton.Location = New System.Drawing.Point(1149, 24)
        Me.ShowByPrintOrderButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowByPrintOrderButton.Name = "ShowByPrintOrderButton"
        Me.ShowByPrintOrderButton.Size = New System.Drawing.Size(89, 48)
        Me.ShowByPrintOrderButton.TabIndex = 22
        Me.ShowByPrintOrderButton.Text = "Show Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SampleRadioButton)
        Me.GroupBox2.Controls.Add(Me.BulkRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 64)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulk/Sample"
        '
        'SampleRadioButton
        '
        Me.SampleRadioButton.AutoSize = True
        Me.SampleRadioButton.Location = New System.Drawing.Point(15, 42)
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
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.EditValue = "[Select Program No]"
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(681, 52)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.PrintOrderNewLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "PrintOrderNewId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(272, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 87
        '
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colProgramNo})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Details"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(964, 24)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 48)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "&Show By Program No"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1060, 24)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 48)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "&Show By Work Order No"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmDailyPrintProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 646)
        Me.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.Controls.Add(OrderIdLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ShowByPrintOrderButton)
        Me.Controls.Add(Me.SummeryButton)
        Me.Controls.Add(Me.PostCostingButton)
        Me.Controls.Add(Me.ProdHourButton)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmDailyPrintProductionReport"
        Me.Text = "Daily Print Production Report"
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProdHourButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PostCostingButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SummeryButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintOrderNewLookupDataSet As KSoft_Apparel.PrintOrderNewLookupDataSet
    Friend WithEvents PrintOrderNewLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderNewLookupTableAdapter As KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter
    Friend WithEvents ShowByPrintOrderButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SampleRadioButton As RadioButton
    Friend WithEvents BulkRadioButton As RadioButton
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
