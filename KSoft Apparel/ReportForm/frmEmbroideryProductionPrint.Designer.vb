<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmbroideryProductionPrint
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
        Dim Label6 As System.Windows.Forms.Label
        Me.EmbOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderLookupDataSet = New KSoft_Apparel.EmbOrderLookupDataSet()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowByDateButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CuttingDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CuttingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmbOrderLookupTableAdapter = New KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.SummeryButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SampleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BulkRadioButton = New System.Windows.Forms.RadioButton()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShowByPrintOrderButton = New DevExpress.XtraEditors.SimpleButton()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(638, 22)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(199, 13)
        Label6.TabIndex = 101
        Label6.Text = " Work Order No::Program No:: Style No :"
        '
        'EmbOrderLookupBindingSource
        '
        Me.EmbOrderLookupBindingSource.DataMember = "EmbOrderLookup"
        Me.EmbOrderLookupBindingSource.DataSource = Me.EmbOrderLookupDataSet
        '
        'EmbOrderLookupDataSet
        '
        Me.EmbOrderLookupDataSet.DataSetName = "EmbOrderLookupDataSet"
        Me.EmbOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 80)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1208, 480)
        Me.CrystalReportViewer1.TabIndex = 16
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowByDateButton
        '
        Me.ShowByDateButton.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowByDateButton.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ShowByDateButton.Appearance.Options.UseFont = True
        Me.ShowByDateButton.Appearance.Options.UseForeColor = True
        Me.ShowByDateButton.Appearance.Options.UseTextOptions = True
        Me.ShowByDateButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ShowByDateButton.Location = New System.Drawing.Point(517, 25)
        Me.ShowByDateButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShowByDateButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowByDateButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowByDateButton.Name = "ShowByDateButton"
        Me.ShowByDateButton.Size = New System.Drawing.Size(95, 49)
        Me.ShowByDateButton.TabIndex = 24
        Me.ShowByDateButton.Text = "&Show Production Detials"
        '
        'CuttingDateTimePicker2
        '
        Me.CuttingDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.CuttingDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CuttingDateTimePicker2.Location = New System.Drawing.Point(314, 25)
        Me.CuttingDateTimePicker2.Name = "CuttingDateTimePicker2"
        Me.CuttingDateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.CuttingDateTimePicker2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Production Date :"
        '
        'CuttingDateTimePicker
        '
        Me.CuttingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.CuttingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CuttingDateTimePicker.Location = New System.Drawing.Point(172, 25)
        Me.CuttingDateTimePicker.Name = "CuttingDateTimePicker"
        Me.CuttingDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.CuttingDateTimePicker.TabIndex = 20
        '
        'EmbOrderLookupTableAdapter
        '
        Me.EmbOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "From :"
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
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(110, 51)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.BuyerCheckBox.TabIndex = 28
        Me.BuyerCheckBox.Text = "Buyer:"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerName"
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(172, 53)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(238, 21)
        Me.BuyerComboBox.TabIndex = 27
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'SummeryButton
        '
        Me.SummeryButton.Appearance.Options.UseTextOptions = True
        Me.SummeryButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SummeryButton.Location = New System.Drawing.Point(416, 25)
        Me.SummeryButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(95, 49)
        Me.SummeryButton.TabIndex = 29
        Me.SummeryButton.Text = "Show Production Summery"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SampleRadioButton)
        Me.GroupBox2.Controls.Add(Me.BulkRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(86, 69)
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
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(641, 52)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.EmbOrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "EmbOrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(271, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 100
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
        Me.Button3.Location = New System.Drawing.Point(923, 25)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 48)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "&Show By Program No"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1019, 25)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 48)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "&Show By Work Order No"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ShowByPrintOrderButton
        '
        Me.ShowByPrintOrderButton.Location = New System.Drawing.Point(1108, 25)
        Me.ShowByPrintOrderButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowByPrintOrderButton.Name = "ShowByPrintOrderButton"
        Me.ShowByPrintOrderButton.Size = New System.Drawing.Size(89, 48)
        Me.ShowByPrintOrderButton.TabIndex = 102
        Me.ShowByPrintOrderButton.Text = "Show Details"
        '
        'frmEmbroideryProductionPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 560)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowByPrintOrderButton)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SummeryButton)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShowByDateButton)
        Me.Controls.Add(Me.CuttingDateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CuttingDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmEmbroideryProductionPrint"
        Me.Text = "Daily Embroidery Production Report"
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowByDateButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CuttingDateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CuttingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmbOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderLookupDataSet As KSoft_Apparel.EmbOrderLookupDataSet
    Friend WithEvents EmbOrderLookupTableAdapter As KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents SummeryButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SampleRadioButton As RadioButton
    Friend WithEvents BulkRadioButton As RadioButton
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ShowByPrintOrderButton As DevExpress.XtraEditors.SimpleButton
End Class
