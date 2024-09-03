<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentReport
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
        Me.ShowButton3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPGAndStyleAndPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowButton2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CommercialInvoiceLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CommercialInvoiceLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommercialInvoiceLookUpDataSet = New KSoft_Apparel.CommercialInvoiceLookUpDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCommercialInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DeliveryChallanLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryChallanLookUpDataSet = New KSoft_Apparel.DeliveryChallanLookUpDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialInvoiceLookUpTableAdapter = New KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter()
        Me.DeliveryChallanLookUpTableAdapter = New KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter()
        Me.ChallanShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CommercialShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgramAllocationButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowButton3
        '
        Me.ShowButton3.Location = New System.Drawing.Point(685, 41)
        Me.ShowButton3.Name = "ShowButton3"
        Me.ShowButton3.Size = New System.Drawing.Size(90, 23)
        Me.ShowButton3.TabIndex = 29
        Me.ShowButton3.Text = "&Show By PO"
        Me.ShowButton3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Program :: Style :: PO :: Color :: Destination"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(240, 43)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderPOLookupAllBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "PGAndStyleAndPOAndColorAndDes"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderDetailsId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(439, 20)
        Me.GridLookUpEdit1.TabIndex = 27
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPGAndStyleAndPOAndColorAndDes})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPGAndStyleAndPOAndColorAndDes
        '
        Me.colPGAndStyleAndPOAndColorAndDes.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.Name = "colPGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.OptionsColumn.ReadOnly = True
        Me.colPGAndStyleAndPOAndColorAndDes.Visible = True
        Me.colPGAndStyleAndPOAndColorAndDes.VisibleIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 105)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1218, 360)
        Me.CrystalReportViewer1.TabIndex = 32
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton2
        '
        Me.ShowButton2.Location = New System.Drawing.Point(465, 14)
        Me.ShowButton2.Name = "ShowButton2"
        Me.ShowButton2.Size = New System.Drawing.Size(150, 23)
        Me.ShowButton2.TabIndex = 37
        Me.ShowButton2.Text = "&Show By Shipment Date"
        Me.ShowButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "From"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(240, 15)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(104, 20)
        Me.ToDateTimePicker.TabIndex = 34
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(90, 16)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.FromDateTimePicker.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "&Show By Challan Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(818, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Commercial Invoice :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(818, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Challan No :"
        '
        'CommercialInvoiceLookUpEdit
        '
        Me.CommercialInvoiceLookUpEdit.Location = New System.Drawing.Point(929, 16)
        Me.CommercialInvoiceLookUpEdit.Name = "CommercialInvoiceLookUpEdit"
        Me.CommercialInvoiceLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.CommercialInvoiceLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommercialInvoiceLookUpEdit.Properties.DataSource = Me.CommercialInvoiceLookUpBindingSource
        Me.CommercialInvoiceLookUpEdit.Properties.DisplayMember = "CommercialInvoiceNo"
        Me.CommercialInvoiceLookUpEdit.Properties.ImmediatePopup = True
        Me.CommercialInvoiceLookUpEdit.Properties.NullText = ""
        Me.CommercialInvoiceLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CommercialInvoiceLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CommercialInvoiceLookUpEdit.Properties.ValueMember = "CommercialInvoiceMainId"
        Me.CommercialInvoiceLookUpEdit.Properties.View = Me.GridView1
        Me.CommercialInvoiceLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.CommercialInvoiceLookUpEdit.TabIndex = 42
        '
        'CommercialInvoiceLookUpBindingSource
        '
        Me.CommercialInvoiceLookUpBindingSource.DataMember = "CommercialInvoiceLookUp"
        Me.CommercialInvoiceLookUpBindingSource.DataSource = Me.CommercialInvoiceLookUpDataSet
        '
        'CommercialInvoiceLookUpDataSet
        '
        Me.CommercialInvoiceLookUpDataSet.DataSetName = "CommercialInvoiceLookUpDataSet"
        Me.CommercialInvoiceLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommercialInvoiceNo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCommercialInvoiceNo
        '
        Me.colCommercialInvoiceNo.FieldName = "CommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Name = "colCommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Visible = True
        Me.colCommercialInvoiceNo.VisibleIndex = 0
        '
        'ChallanNoGridLookUpEdit
        '
        Me.ChallanNoGridLookUpEdit.Location = New System.Drawing.Point(929, 43)
        Me.ChallanNoGridLookUpEdit.Name = "ChallanNoGridLookUpEdit"
        Me.ChallanNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ChallanNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanNoGridLookUpEdit.Properties.DataSource = Me.DeliveryChallanLookUpBindingSource
        Me.ChallanNoGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanNoGridLookUpEdit.Properties.NullText = ""
        Me.ChallanNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanNoGridLookUpEdit.Properties.ValueMember = "DeliveryId"
        Me.ChallanNoGridLookUpEdit.Properties.View = Me.GridView2
        Me.ChallanNoGridLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.ChallanNoGridLookUpEdit.TabIndex = 43
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo})
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
        'CommercialInvoiceLookUpTableAdapter
        '
        Me.CommercialInvoiceLookUpTableAdapter.ClearBeforeFill = True
        '
        'DeliveryChallanLookUpTableAdapter
        '
        Me.DeliveryChallanLookUpTableAdapter.ClearBeforeFill = True
        '
        'ChallanShowButton
        '
        Me.ChallanShowButton.Location = New System.Drawing.Point(1115, 40)
        Me.ChallanShowButton.Name = "ChallanShowButton"
        Me.ChallanShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ChallanShowButton.TabIndex = 46
        Me.ChallanShowButton.Text = "&Show"
        '
        'CommercialShowButton
        '
        Me.CommercialShowButton.Location = New System.Drawing.Point(1115, 13)
        Me.CommercialShowButton.Name = "CommercialShowButton"
        Me.CommercialShowButton.Size = New System.Drawing.Size(75, 23)
        Me.CommercialShowButton.TabIndex = 47
        Me.CommercialShowButton.Text = "&Show"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Select Program No"
        '
        'ProgramAllocationButton
        '
        Me.ProgramAllocationButton.Location = New System.Drawing.Point(685, 70)
        Me.ProgramAllocationButton.Name = "ProgramAllocationButton"
        Me.ProgramAllocationButton.Size = New System.Drawing.Size(90, 23)
        Me.ProgramAllocationButton.TabIndex = 49
        Me.ProgramAllocationButton.Text = "Show"
        Me.ProgramAllocationButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(240, 69)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridView3
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(439, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 48
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colDetails})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        'frmShipmentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 464)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgramAllocationButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.CommercialShowButton)
        Me.Controls.Add(Me.ChallanShowButton)
        Me.Controls.Add(Me.ChallanNoGridLookUpEdit)
        Me.Controls.Add(Me.CommercialInvoiceLookUpEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowButton2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowButton3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Name = "frmShipmentReport"
        Me.Text = "Shipment Report"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowButton3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOLookupAllTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colPGAndStyleAndPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CommercialInvoiceLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CommercialInvoiceLookUpDataSet As KSoft_Apparel.CommercialInvoiceLookUpDataSet
    Friend WithEvents CommercialInvoiceLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceLookUpTableAdapter As KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter
    Friend WithEvents colCommercialInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeliveryChallanLookUpDataSet As KSoft_Apparel.DeliveryChallanLookUpDataSet
    Friend WithEvents DeliveryChallanLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryChallanLookUpTableAdapter As KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CommercialShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgramAllocationButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
End Class
