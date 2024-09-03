<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderShippmentStatus
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.CompletedRadioButton = New System.Windows.Forms.RadioButton()
        Me.IncompleteRedioButton = New System.Windows.Forms.RadioButton()
        Me.ExCheckBox = New System.Windows.Forms.CheckBox()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowButton2 = New System.Windows.Forms.Button()
        Me.ShowButton3 = New System.Windows.Forms.Button()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SOBRadioButton = New System.Windows.Forms.RadioButton()
        Me.SPRadioButton = New System.Windows.Forms.RadioButton()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowYearlyButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SewingButton = New System.Windows.Forms.Button()
        Me.CencelShowButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShipmentRadioButton = New System.Windows.Forms.RadioButton()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.WithoutBranchCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 71)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(933, 447)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(281, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(625, 157)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "Filter"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Location = New System.Drawing.Point(410, 160)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(36, 17)
        Me.AllRadioButton.TabIndex = 4
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'CompletedRadioButton
        '
        Me.CompletedRadioButton.AutoSize = True
        Me.CompletedRadioButton.Location = New System.Drawing.Point(452, 160)
        Me.CompletedRadioButton.Name = "CompletedRadioButton"
        Me.CompletedRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.CompletedRadioButton.TabIndex = 5
        Me.CompletedRadioButton.Text = "Completed"
        Me.CompletedRadioButton.UseVisualStyleBackColor = True
        '
        'IncompleteRedioButton
        '
        Me.IncompleteRedioButton.AutoSize = True
        Me.IncompleteRedioButton.Location = New System.Drawing.Point(533, 160)
        Me.IncompleteRedioButton.Name = "IncompleteRedioButton"
        Me.IncompleteRedioButton.Size = New System.Drawing.Size(77, 17)
        Me.IncompleteRedioButton.TabIndex = 6
        Me.IncompleteRedioButton.Text = "Incomplete"
        Me.IncompleteRedioButton.UseVisualStyleBackColor = True
        '
        'ExCheckBox
        '
        Me.ExCheckBox.AutoSize = True
        Me.ExCheckBox.Location = New System.Drawing.Point(89, 160)
        Me.ExCheckBox.Name = "ExCheckBox"
        Me.ExCheckBox.Size = New System.Drawing.Size(186, 17)
        Me.ExCheckBox.TabIndex = 8
        Me.ExCheckBox.Text = "Where Ex Date less than or Equal"
        Me.ExCheckBox.UseVisualStyleBackColor = True
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(45, 33)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(80, 20)
        Me.FromDateTimePicker.TabIndex = 9
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(150, 33)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(80, 20)
        Me.ToDateTimePicker.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(636, 23)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Select Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(223, 20)
        Me.GridLookUpEdit1.TabIndex = 14
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Program: "
        '
        'ShowButton2
        '
        Me.ShowButton2.Location = New System.Drawing.Point(423, 10)
        Me.ShowButton2.Name = "ShowButton2"
        Me.ShowButton2.Size = New System.Drawing.Size(66, 44)
        Me.ShowButton2.TabIndex = 16
        Me.ShowButton2.Text = "&Show"
        Me.ShowButton2.UseVisualStyleBackColor = True
        '
        'ShowButton3
        '
        Me.ShowButton3.Location = New System.Drawing.Point(865, 10)
        Me.ShowButton3.Name = "ShowButton3"
        Me.ShowButton3.Size = New System.Drawing.Size(61, 44)
        Me.ShowButton3.TabIndex = 17
        Me.ShowButton3.Text = "&Show"
        Me.ShowButton3.UseVisualStyleBackColor = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(89, 183)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchComboBox.TabIndex = 18
        Me.BranchComboBox.ValueMember = "BranchId"
        Me.BranchComboBox.Visible = False
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Branch"
        Me.Label5.Visible = False
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SOBRadioButton)
        Me.Panel1.Controls.Add(Me.SPRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(769, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 92)
        Me.Panel1.TabIndex = 24
        '
        'SOBRadioButton
        '
        Me.SOBRadioButton.AutoSize = True
        Me.SOBRadioButton.Location = New System.Drawing.Point(7, 49)
        Me.SOBRadioButton.Name = "SOBRadioButton"
        Me.SOBRadioButton.Size = New System.Drawing.Size(215, 17)
        Me.SOBRadioButton.TabIndex = 1
        Me.SOBRadioButton.Text = "Sewing Output Balance (With Shipment)"
        Me.SOBRadioButton.UseVisualStyleBackColor = True
        '
        'SPRadioButton
        '
        Me.SPRadioButton.AutoSize = True
        Me.SPRadioButton.Checked = True
        Me.SPRadioButton.Location = New System.Drawing.Point(7, 18)
        Me.SPRadioButton.Name = "SPRadioButton"
        Me.SPRadioButton.Size = New System.Drawing.Size(124, 17)
        Me.SPRadioButton.TabIndex = 0
        Me.SPRadioButton.TabStop = True
        Me.SPRadioButton.Text = "Shipment Information"
        Me.SPRadioButton.UseVisualStyleBackColor = True
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
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(1444, 52)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(60, 23)
        Me.SummeryButton.TabIndex = 26
        Me.SummeryButton.Text = "&Summery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        Me.SummeryButton.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1105, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "From Year : "
        Me.Label2.Visible = False
        '
        'ShowYearlyButton
        '
        Me.ShowYearlyButton.Location = New System.Drawing.Point(1395, 23)
        Me.ShowYearlyButton.Name = "ShowYearlyButton"
        Me.ShowYearlyButton.Size = New System.Drawing.Size(96, 23)
        Me.ShowYearlyButton.TabIndex = 17
        Me.ShowYearlyButton.Text = "&Show Shipment"
        Me.ShowYearlyButton.UseVisualStyleBackColor = True
        Me.ShowYearlyButton.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox1.Location = New System.Drawing.Point(1166, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1250, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "To Year : "
        Me.Label6.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox2.Location = New System.Drawing.Point(1308, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox2.TabIndex = 27
        Me.ComboBox2.Visible = False
        '
        'SewingButton
        '
        Me.SewingButton.Location = New System.Drawing.Point(1497, 23)
        Me.SewingButton.Name = "SewingButton"
        Me.SewingButton.Size = New System.Drawing.Size(83, 23)
        Me.SewingButton.TabIndex = 17
        Me.SewingButton.Text = "&Show Sewing"
        Me.SewingButton.UseVisualStyleBackColor = True
        Me.SewingButton.Visible = False
        '
        'CencelShowButton
        '
        Me.CencelShowButton.Location = New System.Drawing.Point(1508, 52)
        Me.CencelShowButton.Name = "CencelShowButton"
        Me.CencelShowButton.Size = New System.Drawing.Size(72, 23)
        Me.CencelShowButton.TabIndex = 28
        Me.CencelShowButton.Text = "&Only Cancel"
        Me.CencelShowButton.UseVisualStyleBackColor = True
        Me.CencelShowButton.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1105, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Months / Years Shipment Status:"
        Me.Label7.Visible = False
        '
        'ShipmentRadioButton
        '
        Me.ShipmentRadioButton.AutoSize = True
        Me.ShipmentRadioButton.Checked = True
        Me.ShipmentRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipmentRadioButton.Location = New System.Drawing.Point(12, 10)
        Me.ShipmentRadioButton.Name = "ShipmentRadioButton"
        Me.ShipmentRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.ShipmentRadioButton.TabIndex = 22
        Me.ShipmentRadioButton.TabStop = True
        Me.ShipmentRadioButton.Text = "Shipment Date"
        Me.ShipmentRadioButton.UseVisualStyleBackColor = True
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(236, 33)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(77, 17)
        Me.BuyerCheckBox.TabIndex = 25
        Me.BuyerCheckBox.Text = "Buyerwise:"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(325, 32)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(92, 21)
        Me.BuyerComboBox.TabIndex = 26
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'WithoutBranchCheckBox
        '
        Me.WithoutBranchCheckBox.AutoSize = True
        Me.WithoutBranchCheckBox.Location = New System.Drawing.Point(236, 9)
        Me.WithoutBranchCheckBox.Name = "WithoutBranchCheckBox"
        Me.WithoutBranchCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.WithoutBranchCheckBox.TabIndex = 27
        Me.WithoutBranchCheckBox.Text = "Without Branch"
        Me.WithoutBranchCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 44)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "&Show Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmOrderShippmentStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 519)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WithoutBranchCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.CencelShowButton)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ShipmentRadioButton)
        Me.Controls.Add(Me.SummeryButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SewingButton)
        Me.Controls.Add(Me.ShowYearlyButton)
        Me.Controls.Add(Me.ShowButton3)
        Me.Controls.Add(Me.ShowButton2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ExCheckBox)
        Me.Controls.Add(Me.IncompleteRedioButton)
        Me.Controls.Add(Me.CompletedRadioButton)
        Me.Controls.Add(Me.AllRadioButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Name = "frmOrderShippmentStatus"
        Me.Text = "Order Shippment Status"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents AllRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CompletedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IncompleteRedioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShowButton2 As System.Windows.Forms.Button
    Friend WithEvents ShowButton3 As System.Windows.Forms.Button
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SOBRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents SummeryButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowYearlyButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SewingButton As System.Windows.Forms.Button
    Friend WithEvents CencelShowButton As Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents ShipmentRadioButton As RadioButton
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents WithoutBranchCheckBox As CheckBox
    Friend WithEvents Button1 As Button
End Class
