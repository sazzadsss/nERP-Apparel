<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderStatusReport
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
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.LPDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SewingRadioButton = New System.Windows.Forms.RadioButton()
        Me.CuttingRadioButton = New System.Windows.Forms.RadioButton()
        Me.FinishingRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShowByLPDButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowDetailsCheckBox = New System.Windows.Forms.CheckBox()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderP0LookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupDataSet = New KSoft_Apparel.OrderPOLookupDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OrderPOTableAdapter = New KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter()
        Me.CheckedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StyleNameTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.StyleNameMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.POTextBox = New System.Windows.Forms.TextBox()
        Me.POListBox = New System.Windows.Forms.ListBox()
        Me.StyleListBox = New System.Windows.Forms.ListBox()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StyleTextBox = New System.Windows.Forms.TextBox()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.ProgramNoListBox = New System.Windows.Forms.ListBox()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ShowMultipleButton = New System.Windows.Forms.Button()
        Me.MultipleProgramTextBox2 = New System.Windows.Forms.TextBox()
        Me.MultipleProgramTextBox = New System.Windows.Forms.TextBox()
        Me.MultipleProgramListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.DetailsCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.ProgramNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProgramNoTextBox2 = New System.Windows.Forms.TextBox()
        Me.ProgramNoListBox2 = New System.Windows.Forms.ListBox()
        Me.StyleCountButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrgLongProcess = New System.Windows.Forms.ProgressBar()
        Me.btnStartProcess = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.bgrLongProcess = New System.ComponentModel.BackgroundWorker()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.StyleNameMstTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1070, 371)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'LPDDateTimePicker
        '
        Me.LPDDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LPDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LPDDateTimePicker.Location = New System.Drawing.Point(248, 28)
        Me.LPDDateTimePicker.Name = "LPDDateTimePicker"
        Me.LPDDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.LPDDateTimePicker.TabIndex = 3
        '
        'SewingRadioButton
        '
        Me.SewingRadioButton.AutoSize = True
        Me.SewingRadioButton.Location = New System.Drawing.Point(98, 29)
        Me.SewingRadioButton.Name = "SewingRadioButton"
        Me.SewingRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SewingRadioButton.TabIndex = 4
        Me.SewingRadioButton.TabStop = True
        Me.SewingRadioButton.Text = "Sewing"
        Me.SewingRadioButton.UseVisualStyleBackColor = True
        '
        'CuttingRadioButton
        '
        Me.CuttingRadioButton.AutoSize = True
        Me.CuttingRadioButton.Location = New System.Drawing.Point(167, 29)
        Me.CuttingRadioButton.Name = "CuttingRadioButton"
        Me.CuttingRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.CuttingRadioButton.TabIndex = 5
        Me.CuttingRadioButton.TabStop = True
        Me.CuttingRadioButton.Text = "Cutting"
        Me.CuttingRadioButton.UseVisualStyleBackColor = True
        '
        'FinishingRadioButton
        '
        Me.FinishingRadioButton.AutoSize = True
        Me.FinishingRadioButton.Checked = True
        Me.FinishingRadioButton.Location = New System.Drawing.Point(22, 29)
        Me.FinishingRadioButton.Name = "FinishingRadioButton"
        Me.FinishingRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.FinishingRadioButton.TabIndex = 6
        Me.FinishingRadioButton.TabStop = True
        Me.FinishingRadioButton.Text = "Finishing"
        Me.FinishingRadioButton.UseVisualStyleBackColor = True
        '
        'ShowByLPDButton
        '
        Me.ShowByLPDButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowByLPDButton.Location = New System.Drawing.Point(383, 28)
        Me.ShowByLPDButton.Name = "ShowByLPDButton"
        Me.ShowByLPDButton.Size = New System.Drawing.Size(81, 20)
        Me.ShowByLPDButton.TabIndex = 9
        Me.ShowByLPDButton.Text = "Show"
        Me.ShowByLPDButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Program No"
        '
        'ShowDetailsCheckBox
        '
        Me.ShowDetailsCheckBox.AutoSize = True
        Me.ShowDetailsCheckBox.Location = New System.Drawing.Point(543, 11)
        Me.ShowDetailsCheckBox.Name = "ShowDetailsCheckBox"
        Me.ShowDetailsCheckBox.Size = New System.Drawing.Size(110, 17)
        Me.ShowDetailsCheckBox.TabIndex = 12
        Me.ShowDetailsCheckBox.Text = "Show with Details"
        Me.ShowDetailsCheckBox.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(987, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show All"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(907, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cutting >=0"
        Me.Label3.Visible = False
        '
        'OrderP0LookupBindingSource
        '
        Me.OrderP0LookupBindingSource.DataMember = "OrderP0Lookup"
        Me.OrderP0LookupBindingSource.DataSource = Me.OrderPOLookupDataSet
        '
        'OrderPOLookupDataSet
        '
        Me.OrderPOLookupDataSet.DataSetName = "OrderPOLookupDataSet"
        Me.OrderPOLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(557, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 14)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "PO"
        '
        'OrderPOTableAdapter
        '
        Me.OrderPOTableAdapter.ClearBeforeFill = True
        '
        'CheckedComboBoxEdit1
        '
        Me.CheckedComboBoxEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedComboBoxEdit1.EditValue = ""
        Me.CheckedComboBoxEdit1.Location = New System.Drawing.Point(781, 34)
        Me.CheckedComboBoxEdit1.Name = "CheckedComboBoxEdit1"
        Me.CheckedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CheckedComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CheckedComboBoxEdit1.Size = New System.Drawing.Size(190, 20)
        Me.CheckedComboBoxEdit1.TabIndex = 36
        Me.CheckedComboBoxEdit1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1058, 98)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Bisque
        Me.TabPage1.Controls.Add(Me.StyleNameTextBox)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.POTextBox)
        Me.TabPage1.Controls.Add(Me.POListBox)
        Me.TabPage1.Controls.Add(Me.StyleListBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.StyleTextBox)
        Me.TabPage1.Controls.Add(Me.ProgramNoTextBox)
        Me.TabPage1.Controls.Add(Me.ProgramNoListBox)
        Me.TabPage1.Controls.Add(Me.ProgressLabel)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1050, 69)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search by Single Criteria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StyleNameTextBox
        '
        Me.StyleNameTextBox.Location = New System.Drawing.Point(797, 35)
        Me.StyleNameTextBox.Name = "StyleNameTextBox"
        Me.StyleNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.StyleNameTextBox.TabIndex = 51
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBox1.DataSource = Me.StyleNameMstBindingSource
        Me.ListBox1.DisplayMember = "StyleName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(907, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(126, 43)
        Me.ListBox1.TabIndex = 50
        Me.ListBox1.ValueMember = "StyleNameId"
        '
        'StyleNameMstBindingSource
        '
        Me.StyleNameMstBindingSource.DataMember = "StyleNameMst"
        Me.StyleNameMstBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(797, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Style Name"
        '
        'POTextBox
        '
        Me.POTextBox.Location = New System.Drawing.Point(557, 35)
        Me.POTextBox.Name = "POTextBox"
        Me.POTextBox.Size = New System.Drawing.Size(104, 20)
        Me.POTextBox.TabIndex = 48
        '
        'POListBox
        '
        Me.POListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.POListBox.DataSource = Me.OrderP0LookupBindingSource
        Me.POListBox.DisplayMember = "POandColor"
        Me.POListBox.FormattingEnabled = True
        Me.POListBox.Location = New System.Drawing.Point(667, 12)
        Me.POListBox.Name = "POListBox"
        Me.POListBox.Size = New System.Drawing.Size(126, 43)
        Me.POListBox.TabIndex = 47
        Me.POListBox.ValueMember = "OrderId"
        '
        'StyleListBox
        '
        Me.StyleListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StyleListBox.DataSource = Me.StyleLookupBindingSource
        Me.StyleListBox.DisplayMember = "StyleName"
        Me.StyleListBox.FormattingEnabled = True
        Me.StyleListBox.Location = New System.Drawing.Point(394, 11)
        Me.StyleListBox.Name = "StyleListBox"
        Me.StyleListBox.Size = New System.Drawing.Size(158, 43)
        Me.StyleListBox.TabIndex = 46
        Me.StyleListBox.ValueMember = "StyleId"
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(266, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Style No"
        '
        'StyleTextBox
        '
        Me.StyleTextBox.Location = New System.Drawing.Point(269, 34)
        Me.StyleTextBox.Name = "StyleTextBox"
        Me.StyleTextBox.Size = New System.Drawing.Size(119, 20)
        Me.StyleTextBox.TabIndex = 44
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(19, 34)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProgramNoTextBox.TabIndex = 43
        '
        'ProgramNoListBox
        '
        Me.ProgramNoListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgramNoListBox.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoListBox.DisplayMember = "ProgramNo"
        Me.ProgramNoListBox.FormattingEnabled = True
        Me.ProgramNoListBox.Location = New System.Drawing.Point(125, 11)
        Me.ProgramNoListBox.Name = "ProgramNoListBox"
        Me.ProgramNoListBox.Size = New System.Drawing.Size(120, 43)
        Me.ProgramNoListBox.TabIndex = 42
        Me.ProgramNoListBox.ValueMember = "OrderId"
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressLabel.Location = New System.Drawing.Point(16, 3)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(0, 13)
        Me.ProgressLabel.TabIndex = 41
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Bisque
        Me.TabPage2.Controls.Add(Me.LPDDateTimePicker)
        Me.TabPage2.Controls.Add(Me.SewingRadioButton)
        Me.TabPage2.Controls.Add(Me.CuttingRadioButton)
        Me.TabPage2.Controls.Add(Me.FinishingRadioButton)
        Me.TabPage2.Controls.Add(Me.ShowByLPDButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1050, 69)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search by Last Production Date"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Bisque
        Me.TabPage3.Controls.Add(Me.ShowMultipleButton)
        Me.TabPage3.Controls.Add(Me.MultipleProgramTextBox2)
        Me.TabPage3.Controls.Add(Me.MultipleProgramTextBox)
        Me.TabPage3.Controls.Add(Me.MultipleProgramListBox)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.CheckedComboBoxEdit1)
        Me.TabPage3.Controls.Add(Me.ShowDetailsCheckBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1050, 69)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Search by Multiple Program No"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ShowMultipleButton
        '
        Me.ShowMultipleButton.Location = New System.Drawing.Point(542, 31)
        Me.ShowMultipleButton.Name = "ShowMultipleButton"
        Me.ShowMultipleButton.Size = New System.Drawing.Size(110, 23)
        Me.ShowMultipleButton.TabIndex = 48
        Me.ShowMultipleButton.Text = "&Show"
        Me.ShowMultipleButton.UseVisualStyleBackColor = True
        '
        'MultipleProgramTextBox2
        '
        Me.MultipleProgramTextBox2.Location = New System.Drawing.Point(251, 10)
        Me.MultipleProgramTextBox2.Multiline = True
        Me.MultipleProgramTextBox2.Name = "MultipleProgramTextBox2"
        Me.MultipleProgramTextBox2.Size = New System.Drawing.Size(276, 43)
        Me.MultipleProgramTextBox2.TabIndex = 47
        '
        'MultipleProgramTextBox
        '
        Me.MultipleProgramTextBox.Location = New System.Drawing.Point(19, 33)
        Me.MultipleProgramTextBox.Name = "MultipleProgramTextBox"
        Me.MultipleProgramTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MultipleProgramTextBox.TabIndex = 46
        '
        'MultipleProgramListBox
        '
        Me.MultipleProgramListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MultipleProgramListBox.DataSource = Me.OrderLookupBindingSource
        Me.MultipleProgramListBox.DisplayMember = "ProgramNo"
        Me.MultipleProgramListBox.FormattingEnabled = True
        Me.MultipleProgramListBox.Location = New System.Drawing.Point(125, 11)
        Me.MultipleProgramListBox.Name = "MultipleProgramListBox"
        Me.MultipleProgramListBox.Size = New System.Drawing.Size(120, 43)
        Me.MultipleProgramListBox.TabIndex = 45
        Me.MultipleProgramListBox.ValueMember = "OrderId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Program No"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(875, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(778, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Program No"
        Me.Label5.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.BuyerCheckBox)
        Me.TabPage4.Controls.Add(Me.BuyerComboBox)
        Me.TabPage4.Controls.Add(Me.DetailsCheckBox)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.DateTimePicker3)
        Me.TabPage4.Controls.Add(Me.DateTimePicker4)
        Me.TabPage4.Controls.Add(Me.ProgramNoCheckBox)
        Me.TabPage4.Controls.Add(Me.ProgramNoTextBox2)
        Me.TabPage4.Controls.Add(Me.ProgramNoListBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1050, 69)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Search by ExDate"
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyerCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuyerCheckBox.Location = New System.Drawing.Point(369, 12)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(58, 18)
        Me.BuyerCheckBox.TabIndex = 69
        Me.BuyerCheckBox.Text = "Buyer"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerName"
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(369, 35)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(119, 21)
        Me.BuyerComboBox.TabIndex = 68
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
        'DetailsCheckBox
        '
        Me.DetailsCheckBox.AutoSize = True
        Me.DetailsCheckBox.Location = New System.Drawing.Point(877, 17)
        Me.DetailsCheckBox.Name = "DetailsCheckBox"
        Me.DetailsCheckBox.Size = New System.Drawing.Size(58, 17)
        Me.DetailsCheckBox.TabIndex = 66
        Me.DetailsCheckBox.Text = "Details"
        Me.DetailsCheckBox.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(877, 37)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(162, 23)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "PO And Program Count"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(698, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 23)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = "Show  Layout Complete Style"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(529, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 23)
        Me.Button4.TabIndex = 63
        Me.Button4.Text = "Show Picture Pending Style"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(698, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "Show  Layout Pending Style"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "From"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(43, 36)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker3.TabIndex = 59
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(43, 10)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker4.TabIndex = 58
        '
        'ProgramNoCheckBox
        '
        Me.ProgramNoCheckBox.AutoSize = True
        Me.ProgramNoCheckBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramNoCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgramNoCheckBox.Location = New System.Drawing.Point(137, 12)
        Me.ProgramNoCheckBox.Name = "ProgramNoCheckBox"
        Me.ProgramNoCheckBox.Size = New System.Drawing.Size(91, 18)
        Me.ProgramNoCheckBox.TabIndex = 57
        Me.ProgramNoCheckBox.Text = "Program No"
        Me.ProgramNoCheckBox.UseVisualStyleBackColor = True
        '
        'ProgramNoTextBox2
        '
        Me.ProgramNoTextBox2.Location = New System.Drawing.Point(137, 34)
        Me.ProgramNoTextBox2.Name = "ProgramNoTextBox2"
        Me.ProgramNoTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.ProgramNoTextBox2.TabIndex = 56
        '
        'ProgramNoListBox2
        '
        Me.ProgramNoListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgramNoListBox2.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoListBox2.DisplayMember = "ProgramNo"
        Me.ProgramNoListBox2.FormattingEnabled = True
        Me.ProgramNoListBox2.Location = New System.Drawing.Point(243, 11)
        Me.ProgramNoListBox2.Name = "ProgramNoListBox2"
        Me.ProgramNoListBox2.Size = New System.Drawing.Size(120, 43)
        Me.ProgramNoListBox2.TabIndex = 55
        Me.ProgramNoListBox2.ValueMember = "OrderId"
        '
        'StyleCountButton
        '
        Me.StyleCountButton.Location = New System.Drawing.Point(26, 144)
        Me.StyleCountButton.Name = "StyleCountButton"
        Me.StyleCountButton.Size = New System.Drawing.Size(98, 23)
        Me.StyleCountButton.TabIndex = 67
        Me.StyleCountButton.Text = "Style Count"
        Me.StyleCountButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(56, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Ex Date"
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'PrgLongProcess
        '
        Me.PrgLongProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrgLongProcess.Location = New System.Drawing.Point(906, 126)
        Me.PrgLongProcess.Name = "PrgLongProcess"
        Me.PrgLongProcess.Size = New System.Drawing.Size(153, 27)
        Me.PrgLongProcess.TabIndex = 38
        '
        'btnStartProcess
        '
        Me.btnStartProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartProcess.Location = New System.Drawing.Point(906, 56)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(75, 30)
        Me.btnStartProcess.TabIndex = 39
        Me.btnStartProcess.Text = "Load List"
        Me.btnStartProcess.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(989, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 30)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'bgrLongProcess
        '
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleNameMstTableAdapter
        '
        Me.StyleNameMstTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'frmOrderStatusReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 483)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrgLongProcess)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStartProcess)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.StyleCountButton)
        Me.Name = "frmOrderStatusReport"
        Me.Text = "Order Status Report"
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LPDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SewingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CuttingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FinishingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ShowByLPDButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowDetailsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderPOLookupDataSet As KSoft_Apparel.OrderPOLookupDataSet
    Friend WithEvents OrderP0LookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOTableAdapter As KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter
    Friend WithEvents CheckedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrgLongProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStartProcess As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents bgrLongProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgramNoListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents StyleListBox As System.Windows.Forms.ListBox
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents POTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POListBox As System.Windows.Forms.ListBox
    Friend WithEvents MultipleProgramTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MultipleProgramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MultipleProgramListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowMultipleButton As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgramNoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProgramNoTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProgramNoListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents StyleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleNameMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleNameMstTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DetailsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StyleCountButton As System.Windows.Forms.Button
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerCheckBox As System.Windows.Forms.CheckBox
End Class
