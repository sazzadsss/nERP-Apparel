<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentDeliveryChallanPrint
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
        Me.ChallanGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DeliveryChallanLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryChallanLookUpDataSet = New KSoft_Apparel.DeliveryChallanLookUpDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Apparel.DepartmentDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeliveryChallanLookUpTableAdapter = New KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter()
        Me.DepartmentTableAdapter = New KSoft_Apparel.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.ShowByDeptButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgramAllocationButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.ShowButton3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPGAndStyleAndPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanGridLookUpEdit
        '
        Me.ChallanGridLookUpEdit.Location = New System.Drawing.Point(83, 27)
        Me.ChallanGridLookUpEdit.Name = "ChallanGridLookUpEdit"
        Me.ChallanGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanGridLookUpEdit.Properties.DataSource = Me.DeliveryChallanLookUpBindingSource
        Me.ChallanGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Properties.NullText = ""
        Me.ChallanGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.ChallanGridLookUpEdit.Properties.ValueMember = "DeliveryId"
        Me.ChallanGridLookUpEdit.Size = New System.Drawing.Size(144, 20)
        Me.ChallanGridLookUpEdit.TabIndex = 51
        '
        'DeliveryChallanLookUpBindingSource
        '
        Me.DeliveryChallanLookUpBindingSource.DataMember = "DeliveryChallanLookUp"
        Me.DeliveryChallanLookUpBindingSource.DataSource = Me.DeliveryChallanLookUpDataSet
        '
        'DeliveryChallanLookUpDataSet
        '
        Me.DeliveryChallanLookUpDataSet.DataSetName = "DeliveryChallanLookUpDataSet"
        Me.DeliveryChallanLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 0
        '
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 98)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1198, 412)
        Me.CrystalReportViewer1.TabIndex = 50
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(233, 10)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 53)
        Me.ShowButton.TabIndex = 49
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Challan No :"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(1072, 11)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(61, 21)
        Me.DepartmentComboBox.TabIndex = 52
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        Me.DepartmentComboBox.Visible = False
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1004, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Department"
        Me.Label1.Visible = False
        '
        'DeliveryChallanLookUpTableAdapter
        '
        Me.DeliveryChallanLookUpTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'ShowByDeptButton
        '
        Me.ShowByDeptButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowByDeptButton.Location = New System.Drawing.Point(1139, 11)
        Me.ShowByDeptButton.Name = "ShowByDeptButton"
        Me.ShowByDeptButton.Size = New System.Drawing.Size(48, 23)
        Me.ShowByDeptButton.TabIndex = 49
        Me.ShowByDeptButton.Text = "Show"
        Me.ShowByDeptButton.UseVisualStyleBackColor = True
        Me.ShowByDeptButton.Visible = False
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(322, 10)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(83, 53)
        Me.PrintButton.TabIndex = 49
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(643, 10)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(57, 59)
        Me.SimpleButton1.TabIndex = 58
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "Show"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(539, 49)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 57
        Me.ToDateTimePicker.TabStop = False
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(539, 10)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.FromDateTimePicker.TabIndex = 55
        Me.FromDateTimePicker.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Challan List Date From :"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(706, 10)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(57, 59)
        Me.SimpleButton2.TabIndex = 59
        Me.SimpleButton2.TabStop = False
        Me.SimpleButton2.Text = "Details"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(769, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Select Program No :"
        '
        'ProgramAllocationButton
        '
        Me.ProgramAllocationButton.Location = New System.Drawing.Point(1114, 8)
        Me.ProgramAllocationButton.Name = "ProgramAllocationButton"
        Me.ProgramAllocationButton.Size = New System.Drawing.Size(75, 20)
        Me.ProgramAllocationButton.TabIndex = 61
        Me.ProgramAllocationButton.Text = "Show"
        Me.ProgramAllocationButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(892, 8)
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
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(216, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 60
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
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'ShowButton3
        '
        Me.ShowButton3.Location = New System.Drawing.Point(1114, 50)
        Me.ShowButton3.Name = "ShowButton3"
        Me.ShowButton3.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton3.TabIndex = 65
        Me.ShowButton3.Text = "&Show By PO"
        Me.ShowButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(769, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Program :: Style :: PO :: Color :: Destination"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(769, 52)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderPOLookupAllBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "PGAndStyleAndPOAndColorAndDes"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView1
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderDetailsId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(339, 20)
        Me.GridLookUpEdit1.TabIndex = 63
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPGAndStyleAndPOAndColorAndDes})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPGAndStyleAndPOAndColorAndDes
        '
        Me.colPGAndStyleAndPOAndColorAndDes.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.Name = "colPGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.OptionsColumn.ReadOnly = True
        Me.colPGAndStyleAndPOAndColorAndDes.Visible = True
        Me.colPGAndStyleAndPOAndColorAndDes.VisibleIndex = 0
        '
        'frmShipmentDeliveryChallanPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 512)
        Me.Controls.Add(Me.ShowButton3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgramAllocationButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChallanGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowByDeptButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmShipmentDeliveryChallanPrint"
        Me.Text = "Shipment/Export Delivery Challan Print:"
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChallanGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeliveryChallanLookUpDataSet As KSoft_Apparel.DeliveryChallanLookUpDataSet
    Friend WithEvents DeliveryChallanLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryChallanLookUpTableAdapter As KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DepartmentDataSet As KSoft_Apparel.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Apparel.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents ShowByDeptButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgramAllocationButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderPOLookupNewDataSet As OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupAllBindingSource As BindingSource
    Friend WithEvents OrderPOLookupAllTableAdapter As OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents ShowButton3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPGAndStyleAndPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
End Class
