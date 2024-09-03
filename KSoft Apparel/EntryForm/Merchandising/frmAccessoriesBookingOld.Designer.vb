<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesBookingOld
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
        Dim BookingDateLabel As System.Windows.Forms.Label
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim StyleLabel As System.Windows.Forms.Label
        Dim BuyerLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim RefNoLabel As System.Windows.Forms.Label
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Apparel.BookingDataSet
        Me.StyleTextBox = New System.Windows.Forms.TextBox
        Me.RemarksTextBox = New System.Windows.Forms.TextBox
        Me.BookingDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GenerateLinkLabel = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.RefNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.OrderDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.BuyerIdComboBox = New System.Windows.Forms.ComboBox
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.DiscontinedCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.NewButton = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CancelEntryButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgramNoComboBox = New System.Windows.Forms.ComboBox
        Me.BookingProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.BookingTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.BookingTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager
        Me.BookingDetailsTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.BookingDetailsTableAdapter
        Me.BookingProgramNoLookupTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter
        Me.BookingProgramNoSearchTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.BookingProgramNoSearchTableAdapter
        Me.ItemStyleTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BookingDetailsGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colItemSize = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet
        Me.colItemStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemStyleRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ItemColorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemColorLookupTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.ItemColorLookupTableAdapter
        Me.AutocompleteCheckBox = New System.Windows.Forms.CheckBox
        Me.SaveDetailsButton = New System.Windows.Forms.Button
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.BookingProgramNoSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        BookingDateLabel = New System.Windows.Forms.Label
        ProgramNoLabel = New System.Windows.Forms.Label
        StyleLabel = New System.Windows.Forms.Label
        BuyerLabel = New System.Windows.Forms.Label
        RemarksLabel = New System.Windows.Forms.Label
        OrderDateLabel = New System.Windows.Forms.Label
        RefNoLabel = New System.Windows.Forms.Label
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscontinedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemColorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingProgramNoSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingDateLabel
        '
        BookingDateLabel.AutoSize = True
        BookingDateLabel.Location = New System.Drawing.Point(34, 26)
        BookingDateLabel.Name = "BookingDateLabel"
        BookingDateLabel.Size = New System.Drawing.Size(75, 13)
        BookingDateLabel.TabIndex = 5
        BookingDateLabel.Text = "Booking Date:"
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(34, 52)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(66, 13)
        ProgramNoLabel.TabIndex = 6
        ProgramNoLabel.Text = "Program No:"
        '
        'StyleLabel
        '
        StyleLabel.AutoSize = True
        StyleLabel.Location = New System.Drawing.Point(284, 52)
        StyleLabel.Name = "StyleLabel"
        StyleLabel.Size = New System.Drawing.Size(33, 13)
        StyleLabel.TabIndex = 7
        StyleLabel.Text = "Style:"
        '
        'BuyerLabel
        '
        BuyerLabel.AutoSize = True
        BuyerLabel.Location = New System.Drawing.Point(284, 77)
        BuyerLabel.Name = "BuyerLabel"
        BuyerLabel.Size = New System.Drawing.Size(37, 13)
        BuyerLabel.TabIndex = 8
        BuyerLabel.Text = "Buyer:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(34, 106)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 9
        RemarksLabel.Text = "Remarks:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(34, 78)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(62, 13)
        OrderDateLabel.TabIndex = 11
        OrderDateLabel.Text = "Order Date:"
        '
        'RefNoLabel
        '
        RefNoLabel.AutoSize = True
        RefNoLabel.Location = New System.Drawing.Point(284, 27)
        RefNoLabel.Name = "RefNoLabel"
        RefNoLabel.Size = New System.Drawing.Size(44, 13)
        RefNoLabel.TabIndex = 13
        RefNoLabel.Text = "Ref No:"
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(115, 49)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ProgramNoTextBox.TabIndex = 1
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTextBox
        '
        Me.StyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Style", True))
        Me.StyleTextBox.Location = New System.Drawing.Point(341, 49)
        Me.StyleTextBox.Name = "StyleTextBox"
        Me.StyleTextBox.Size = New System.Drawing.Size(147, 20)
        Me.StyleTextBox.TabIndex = 2
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(115, 103)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(373, 20)
        Me.RemarksTextBox.TabIndex = 4
        '
        'BookingDateDateTimePicker
        '
        Me.BookingDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.BookingDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "BookingDate", True))
        Me.BookingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BookingDateDateTimePicker.Location = New System.Drawing.Point(115, 23)
        Me.BookingDateDateTimePicker.Name = "BookingDateDateTimePicker"
        Me.BookingDateDateTimePicker.Size = New System.Drawing.Size(132, 20)
        Me.BookingDateDateTimePicker.TabIndex = 0
        '
        'BookingDetailsBindingSource
        '
        Me.BookingDetailsBindingSource.DataMember = "FK_BookingDetails_Booking"
        Me.BookingDetailsBindingSource.DataSource = Me.BookingBindingSource
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(RefNoLabel)
        Me.GroupBox1.Controls.Add(Me.RefNoTextEdit)
        Me.GroupBox1.Controls.Add(OrderDateLabel)
        Me.GroupBox1.Controls.Add(Me.OrderDateDateEdit)
        Me.GroupBox1.Controls.Add(Me.BuyerIdComboBox)
        Me.GroupBox1.Controls.Add(Me.DiscontinedCheckEdit)
        Me.GroupBox1.Controls.Add(Me.BookingDateDateTimePicker)
        Me.GroupBox1.Controls.Add(BookingDateLabel)
        Me.GroupBox1.Controls.Add(ProgramNoLabel)
        Me.GroupBox1.Controls.Add(Me.ProgramNoTextBox)
        Me.GroupBox1.Controls.Add(StyleLabel)
        Me.GroupBox1.Controls.Add(Me.StyleTextBox)
        Me.GroupBox1.Controls.Add(BuyerLabel)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1067, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking"
        '
        'GenerateLinkLabel
        '
        Me.GenerateLinkLabel.AutoSize = True
        Me.GenerateLinkLabel.Enabled = False
        Me.GenerateLinkLabel.Location = New System.Drawing.Point(311, 6)
        Me.GenerateLinkLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.GenerateLinkLabel.Name = "GenerateLinkLabel"
        Me.GenerateLinkLabel.Size = New System.Drawing.Size(51, 13)
        Me.GenerateLinkLabel.TabIndex = 17
        Me.GenerateLinkLabel.TabStop = True
        Me.GenerateLinkLabel.Text = "Generate"
        Me.GenerateLinkLabel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(607, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Matching Program List.."
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Yellow
        Me.ListBox1.DataSource = Me.OrderLookupBindingSource
        Me.ListBox1.DisplayMember = "ProgramNo"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(607, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 82)
        Me.ListBox1.TabIndex = 15
        Me.ListBox1.ValueMember = "ProgramNo"
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RefNoTextEdit
        '
        Me.RefNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "RefNo", True))
        Me.RefNoTextEdit.Location = New System.Drawing.Point(341, 24)
        Me.RefNoTextEdit.Name = "RefNoTextEdit"
        Me.RefNoTextEdit.Size = New System.Drawing.Size(147, 20)
        Me.RefNoTextEdit.TabIndex = 14
        '
        'OrderDateDateEdit
        '
        Me.OrderDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "OrderDate", True))
        Me.OrderDateDateEdit.EditValue = Nothing
        Me.OrderDateDateEdit.Location = New System.Drawing.Point(115, 75)
        Me.OrderDateDateEdit.Name = "OrderDateDateEdit"
        Me.OrderDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.OrderDateDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.OrderDateDateEdit.TabIndex = 12
        '
        'BuyerIdComboBox
        '
        Me.BuyerIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BookingBindingSource, "BuyerId", True))
        Me.BuyerIdComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerIdComboBox.DisplayMember = "BuyerCode"
        Me.BuyerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BuyerIdComboBox.FormattingEnabled = True
        Me.BuyerIdComboBox.Location = New System.Drawing.Point(341, 74)
        Me.BuyerIdComboBox.Name = "BuyerIdComboBox"
        Me.BuyerIdComboBox.Size = New System.Drawing.Size(147, 21)
        Me.BuyerIdComboBox.TabIndex = 3
        Me.BuyerIdComboBox.ValueMember = "BuyerId"
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
        'DiscontinedCheckEdit
        '
        Me.DiscontinedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "Discontined", True))
        Me.DiscontinedCheckEdit.Location = New System.Drawing.Point(506, 105)
        Me.DiscontinedCheckEdit.Name = "DiscontinedCheckEdit"
        Me.DiscontinedCheckEdit.Properties.Caption = "Discontinued"
        Me.DiscontinedCheckEdit.Size = New System.Drawing.Size(96, 19)
        Me.DiscontinedCheckEdit.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Booking Details..."
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.GenerateLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgramNoComboBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1091, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(95, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(104, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(173, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 21)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEntryButton.Location = New System.Drawing.Point(242, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter By Program No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgramNoComboBox
        '
        Me.ProgramNoComboBox.DataSource = Me.BookingProgramNoLookupBindingSource
        Me.ProgramNoComboBox.DisplayMember = "ProgramNo"
        Me.ProgramNoComboBox.FormattingEnabled = True
        Me.ProgramNoComboBox.Location = New System.Drawing.Point(500, 3)
        Me.ProgramNoComboBox.Name = "ProgramNoComboBox"
        Me.ProgramNoComboBox.Size = New System.Drawing.Size(138, 21)
        Me.ProgramNoComboBox.TabIndex = 5
        Me.ProgramNoComboBox.Tag = "NR"
        Me.ProgramNoComboBox.ValueMember = "ProgramNo"
        '
        'BookingProgramNoLookupBindingSource
        '
        Me.BookingProgramNoLookupBindingSource.DataMember = "BookingProgramNoLookup"
        Me.BookingProgramNoLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingDetailsTableAdapter = Me.BookingDetailsTableAdapter
        Me.TableAdapterManager.BookingProgramNoLookupTableAdapter = Me.BookingProgramNoLookupTableAdapter
        Me.TableAdapterManager.BookingProgramNoSearchTableAdapter = Me.BookingProgramNoSearchTableAdapter
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.ItemStyleTableAdapter = Me.ItemStyleTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookingDetailsTableAdapter
        '
        Me.BookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoLookupTableAdapter
        '
        Me.BookingProgramNoLookupTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoSearchTableAdapter
        '
        Me.BookingProgramNoSearchTableAdapter.ClearBeforeFill = True
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BookingDetailsGridControl
        '
        Me.BookingDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookingDetailsGridControl.DataSource = Me.BookingDetailsBindingSource
        Me.BookingDetailsGridControl.Location = New System.Drawing.Point(11, 220)
        Me.BookingDetailsGridControl.MainView = Me.GridView1
        Me.BookingDetailsGridControl.Name = "BookingDetailsGridControl"
        Me.BookingDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.SupplierRepositoryItemLookUpEdit, Me.ItemStyleRepositoryItemLookUpEdit})
        Me.BookingDetailsGridControl.Size = New System.Drawing.Size(1067, 317)
        Me.BookingDetailsGridControl.TabIndex = 3
        Me.BookingDetailsGridControl.UseEmbeddedNavigator = True
        Me.BookingDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemSize, Me.colItemColor, Me.colBookingQuantity, Me.colRemarks, Me.colSupplierId, Me.colItemStyleId})
        Me.GridView1.GridControl = Me.BookingDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colItemId, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.SummaryItem.FieldName = "BookingQuantity"
        Me.colItemId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 149
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepositoryItemLookUpEdit1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepositoryItemLookUpEdit1.Appearance.Options.UseBackColor = True
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "ItemId"
        '
        'colItemSize
        '
        Me.colItemSize.FieldName = "ItemSize"
        Me.colItemSize.Name = "colItemSize"
        Me.colItemSize.Visible = True
        Me.colItemSize.VisibleIndex = 2
        '
        'colItemColor
        '
        Me.colItemColor.Caption = "Item Color"
        Me.colItemColor.FieldName = "ItemColor"
        Me.colItemColor.Name = "colItemColor"
        Me.colItemColor.Visible = True
        Me.colItemColor.VisibleIndex = 3
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 4
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 5
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierRepositoryItemLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 6
        Me.colSupplierId.Width = 159
        '
        'SupplierRepositoryItemLookUpEdit
        '
        Me.SupplierRepositoryItemLookUpEdit.AutoHeight = False
        Me.SupplierRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierRepositoryItemLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierRepositoryItemLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierRepositoryItemLookUpEdit.Name = "SupplierRepositoryItemLookUpEdit"
        Me.SupplierRepositoryItemLookUpEdit.NullText = "[TBC]"
        Me.SupplierRepositoryItemLookUpEdit.ValueMember = "SupplierId"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colItemStyleId
        '
        Me.colItemStyleId.Caption = "Item Style"
        Me.colItemStyleId.ColumnEdit = Me.ItemStyleRepositoryItemLookUpEdit
        Me.colItemStyleId.FieldName = "ItemStyleId"
        Me.colItemStyleId.Name = "colItemStyleId"
        Me.colItemStyleId.Visible = True
        Me.colItemStyleId.VisibleIndex = 1
        Me.colItemStyleId.Width = 138
        '
        'ItemStyleRepositoryItemLookUpEdit
        '
        Me.ItemStyleRepositoryItemLookUpEdit.AutoHeight = False
        Me.ItemStyleRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStyle", "Item Style", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ItemStyleRepositoryItemLookUpEdit.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleRepositoryItemLookUpEdit.DisplayMember = "ItemStyle"
        Me.ItemStyleRepositoryItemLookUpEdit.Name = "ItemStyleRepositoryItemLookUpEdit"
        Me.ItemStyleRepositoryItemLookUpEdit.NullText = "[NO STYLE]"
        Me.ItemStyleRepositoryItemLookUpEdit.ValueMember = "ItemStyleId"
        '
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.BookingDataSet
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStye", "Item Stye", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ItemStyleBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "ItemStyle"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "ItemStyleId"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.BookingDetailsGridControl
        Me.GridView2.Name = "GridView2"
        '
        'ItemColorLookupBindingSource
        '
        Me.ItemColorLookupBindingSource.DataMember = "ItemColorLookup"
        Me.ItemColorLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'ItemColorLookupTableAdapter
        '
        Me.ItemColorLookupTableAdapter.ClearBeforeFill = True
        '
        'AutocompleteCheckBox
        '
        Me.AutocompleteCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteCheckBox.AutoSize = True
        Me.AutocompleteCheckBox.Checked = True
        Me.AutocompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutocompleteCheckBox.Location = New System.Drawing.Point(872, 195)
        Me.AutocompleteCheckBox.Name = "AutocompleteCheckBox"
        Me.AutocompleteCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.AutocompleteCheckBox.TabIndex = 4
        Me.AutocompleteCheckBox.Text = "&Auto Complete"
        Me.AutocompleteCheckBox.UseVisualStyleBackColor = True
        '
        'SaveDetailsButton
        '
        Me.SaveDetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveDetailsButton.Location = New System.Drawing.Point(973, 191)
        Me.SaveDetailsButton.Name = "SaveDetailsButton"
        Me.SaveDetailsButton.Size = New System.Drawing.Size(105, 23)
        Me.SaveDetailsButton.TabIndex = 5
        Me.SaveDetailsButton.Text = "Sa&ve Details (F5)"
        Me.SaveDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveDetailsButton.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(127, 196)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Reload Item Style List"
        '
        'BookingProgramNoSearchBindingSource
        '
        Me.BookingProgramNoSearchBindingSource.DataMember = "BookingProgramNoSearch"
        Me.BookingProgramNoSearchBindingSource.DataSource = Me.BookingDataSet
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 549)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SaveDetailsButton)
        Me.Controls.Add(Me.AutocompleteCheckBox)
        Me.Controls.Add(Me.BookingDetailsGridControl)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBooking"
        Me.Text = "Booking"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscontinedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemColorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingProgramNoSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingDataSet As KSoft_Apparel.BookingDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookingDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookingDetailsTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.BookingDetailsTableAdapter
    Friend WithEvents BookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents DiscontinedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BookingProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingProgramNoLookupTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BookingDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemColorLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemColorLookupTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.ItemColorLookupTableAdapter
    Friend WithEvents AutocompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveDetailsButton As System.Windows.Forms.Button
    Friend WithEvents ItemStyleTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents colItemStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RefNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BookingProgramNoSearchTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.BookingProgramNoSearchTableAdapter
    Friend WithEvents BookingProgramNoSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GenerateLinkLabel As System.Windows.Forms.LinkLabel
End Class
