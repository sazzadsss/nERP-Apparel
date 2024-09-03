<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingTransfer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PgNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FromOrderDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderP0LookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupDataSet = New KSoft_Apparel.OrderPOLookupDataSet
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOandColor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDestinationCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOAndColorAndDes1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PgNo1GridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToOrderDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderP0Lookup1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOandColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.SewingProductionDataGridView = New System.Windows.Forms.DataGridView
        Me.IsChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SewingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.OrderDetailsId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SewingLayoutId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SewingLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutLookupDataSet = New KSoft_Apparel.SewingLayoutLookupDataSet
        Me.InputQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OutputQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RejectQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SewingProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingProductionDataSet = New KSoft_Apparel.SewingProductionDataSet
        Me.SewingLayoutTableAdapter = New KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter
        Me.SewingProductionTableAdapter = New KSoft_Apparel.SewingProductionDataSetTableAdapters.SewingProductionTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderPOTableAdapter = New KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter
        Me.OrderP0Lookup1TableAdapter = New KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderP0Lookup1TableAdapter
        CType(Me.PgNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromOrderDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PgNo1GridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToOrderDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderP0Lookup1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingProductionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PgNoGridLookUpEdit
        '
        Me.PgNoGridLookUpEdit.Location = New System.Drawing.Point(110, 34)
        Me.PgNoGridLookUpEdit.Name = "PgNoGridLookUpEdit"
        Me.PgNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PgNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.PgNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.PgNoGridLookUpEdit.Properties.NullText = ""
        Me.PgNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.PgNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.PgNoGridLookUpEdit.Size = New System.Drawing.Size(126, 20)
        Me.PgNoGridLookUpEdit.TabIndex = 0
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId2, Me.colProgramNo2, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId2
        '
        Me.colOrderId2.FieldName = "OrderId"
        Me.colOrderId2.Name = "colOrderId2"
        Me.colOrderId2.OptionsColumn.ReadOnly = True
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        Me.colProgramNo2.Visible = True
        Me.colProgramNo2.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'FromOrderDetailsIdGridLookUpEdit
        '
        Me.FromOrderDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(110, 60)
        Me.FromOrderDetailsIdGridLookUpEdit.Name = "FromOrderDetailsIdGridLookUpEdit"
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.DataSource = Me.OrderP0LookupBindingSource
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.DisplayMember = "POAndColorAndDes"
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.ValueMember = "OrderDetailsId"
        Me.FromOrderDetailsIdGridLookUpEdit.Properties.View = Me.GridView1
        Me.FromOrderDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(278, 20)
        Me.FromOrderDetailsIdGridLookUpEdit.TabIndex = 0
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId1, Me.colProgramNo1, Me.colFabricColorName1, Me.colDetails1, Me.colPOandColor1, Me.colOrderId1, Me.colFabricColorId1, Me.colDestinationCode1, Me.colPOAndColorAndDes1, Me.colPO1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId1
        '
        Me.colOrderDetailsId1.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId1.Name = "colOrderDetailsId1"
        Me.colOrderDetailsId1.OptionsColumn.ReadOnly = True
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.OptionsColumn.ReadOnly = True
        '
        'colPOandColor1
        '
        Me.colPOandColor1.FieldName = "POandColor"
        Me.colPOandColor1.Name = "colPOandColor1"
        Me.colPOandColor1.OptionsColumn.ReadOnly = True
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        Me.colOrderId1.OptionsColumn.ReadOnly = True
        '
        'colFabricColorId1
        '
        Me.colFabricColorId1.FieldName = "FabricColorId"
        Me.colFabricColorId1.Name = "colFabricColorId1"
        Me.colFabricColorId1.OptionsColumn.ReadOnly = True
        '
        'colDestinationCode1
        '
        Me.colDestinationCode1.FieldName = "DestinationCode"
        Me.colDestinationCode1.Name = "colDestinationCode1"
        Me.colDestinationCode1.OptionsColumn.ReadOnly = True
        '
        'colPOAndColorAndDes1
        '
        Me.colPOAndColorAndDes1.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes1.Name = "colPOAndColorAndDes1"
        Me.colPOAndColorAndDes1.OptionsColumn.ReadOnly = True
        Me.colPOAndColorAndDes1.Visible = True
        Me.colPOAndColorAndDes1.VisibleIndex = 0
        '
        'colPO1
        '
        Me.colPO1.FieldName = "PO"
        Me.colPO1.Name = "colPO1"
        '
        'PgNo1GridLookUpEdit
        '
        Me.PgNo1GridLookUpEdit.Location = New System.Drawing.Point(111, 29)
        Me.PgNo1GridLookUpEdit.Name = "PgNo1GridLookUpEdit"
        Me.PgNo1GridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PgNo1GridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.PgNo1GridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.PgNo1GridLookUpEdit.Properties.NullText = ""
        Me.PgNo1GridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.PgNo1GridLookUpEdit.Properties.View = Me.GridView2
        Me.PgNo1GridLookUpEdit.Size = New System.Drawing.Size(134, 20)
        Me.PgNo1GridLookUpEdit.TabIndex = 0
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId3, Me.colProgramNo3, Me.colIsPrint1, Me.colUserId1, Me.colIsMultiPart1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colOrderId3
        '
        Me.colOrderId3.FieldName = "OrderId"
        Me.colOrderId3.Name = "colOrderId3"
        Me.colOrderId3.OptionsColumn.ReadOnly = True
        '
        'colProgramNo3
        '
        Me.colProgramNo3.FieldName = "ProgramNo"
        Me.colProgramNo3.Name = "colProgramNo3"
        Me.colProgramNo3.Visible = True
        Me.colProgramNo3.VisibleIndex = 0
        '
        'colIsPrint1
        '
        Me.colIsPrint1.FieldName = "IsPrint"
        Me.colIsPrint1.Name = "colIsPrint1"
        '
        'colUserId1
        '
        Me.colUserId1.FieldName = "UserId"
        Me.colUserId1.Name = "colUserId1"
        '
        'colIsMultiPart1
        '
        Me.colIsMultiPart1.FieldName = "IsMultiPart"
        Me.colIsMultiPart1.Name = "colIsMultiPart1"
        '
        'ToOrderDetailsIdGridLookUpEdit
        '
        Me.ToOrderDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(111, 55)
        Me.ToOrderDetailsIdGridLookUpEdit.Name = "ToOrderDetailsIdGridLookUpEdit"
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.DataSource = Me.OrderP0Lookup1BindingSource
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.DisplayMember = "POAndColorAndDes"
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.ValueMember = "OrderDetailsId"
        Me.ToOrderDetailsIdGridLookUpEdit.Properties.View = Me.GridView3
        Me.ToOrderDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(292, 20)
        Me.ToOrderDetailsIdGridLookUpEdit.TabIndex = 0
        '
        'OrderP0Lookup1BindingSource
        '
        Me.OrderP0Lookup1BindingSource.DataMember = "OrderP0Lookup1"
        Me.OrderP0Lookup1BindingSource.DataSource = Me.OrderPOLookupDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId, Me.colProgramNo, Me.colFabricColorName, Me.colDetails, Me.colPOandColor, Me.colOrderId, Me.colFabricColorId, Me.colDestinationCode, Me.colPOAndColorAndDes, Me.colPO})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        '
        'colPOandColor
        '
        Me.colPOandColor.FieldName = "POandColor"
        Me.colPOandColor.Name = "colPOandColor"
        Me.colPOandColor.OptionsColumn.ReadOnly = True
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colFabricColorId
        '
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.OptionsColumn.ReadOnly = True
        '
        'colPOAndColorAndDes
        '
        Me.colPOAndColorAndDes.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes.Name = "colPOAndColorAndDes"
        Me.colPOAndColorAndDes.OptionsColumn.ReadOnly = True
        Me.colPOAndColorAndDes.Visible = True
        Me.colPOAndColorAndDes.VisibleIndex = 0
        '
        'colPO
        '
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.FromOrderDetailsIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.PgNoGridLookUpEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 102)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FROM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program No"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ToOrderDetailsIdGridLookUpEdit)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PgNo1GridLookUpEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(560, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Order Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Program No"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Transfer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
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
        'SewingProductionDataGridView
        '
        Me.SewingProductionDataGridView.AllowUserToAddRows = False
        Me.SewingProductionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingProductionDataGridView.AutoGenerateColumns = False
        Me.SewingProductionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingProductionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingProductionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsChecked, Me.SewingDateDataGridViewTextBoxColumn, Me.BranchId, Me.OrderDetailsId, Me.SewingLayoutId, Me.InputQuantityDataGridViewTextBoxColumn, Me.OutputQuantityDataGridViewTextBoxColumn, Me.RejectQuantityDataGridViewTextBoxColumn, Me.Remarks})
        Me.SewingProductionDataGridView.DataSource = Me.SewingProductionBindingSource
        Me.SewingProductionDataGridView.Location = New System.Drawing.Point(-1, 142)
        Me.SewingProductionDataGridView.Name = "SewingProductionDataGridView"
        Me.SewingProductionDataGridView.Size = New System.Drawing.Size(1029, 293)
        Me.SewingProductionDataGridView.TabIndex = 4
        '
        'IsChecked
        '
        Me.IsChecked.DataPropertyName = "IsChecked"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.NullValue = False
        Me.IsChecked.DefaultCellStyle = DataGridViewCellStyle1
        Me.IsChecked.HeaderText = "Select"
        Me.IsChecked.Name = "IsChecked"
        Me.IsChecked.Width = 50
        '
        'SewingDateDataGridViewTextBoxColumn
        '
        Me.SewingDateDataGridViewTextBoxColumn.DataPropertyName = "SewingDate"
        Me.SewingDateDataGridViewTextBoxColumn.HeaderText = "Sewing Date"
        Me.SewingDateDataGridViewTextBoxColumn.Name = "SewingDateDataGridViewTextBoxColumn"
        '
        'BranchId
        '
        Me.BranchId.DataPropertyName = "BranchId"
        Me.BranchId.DataSource = Me.BranchBindingSource
        Me.BranchId.DisplayMember = "BranchCode"
        Me.BranchId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BranchId.HeaderText = "Branch"
        Me.BranchId.Name = "BranchId"
        Me.BranchId.ReadOnly = True
        Me.BranchId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BranchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BranchId.ValueMember = "BranchId"
        Me.BranchId.Width = 50
        '
        'OrderDetailsId
        '
        Me.OrderDetailsId.DataPropertyName = "OrderDetailsId"
        Me.OrderDetailsId.DataSource = Me.OrderP0LookupBindingSource
        Me.OrderDetailsId.DisplayMember = "POAndColorAndDes"
        Me.OrderDetailsId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.OrderDetailsId.HeaderText = "PO/Color/Des"
        Me.OrderDetailsId.Name = "OrderDetailsId"
        Me.OrderDetailsId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OrderDetailsId.ValueMember = "OrderDetailsId"
        Me.OrderDetailsId.Width = 250
        '
        'SewingLayoutId
        '
        Me.SewingLayoutId.DataPropertyName = "SewingLayoutId"
        Me.SewingLayoutId.DataSource = Me.SewingLayoutBindingSource
        Me.SewingLayoutId.DisplayMember = "SewingLayoutNo"
        Me.SewingLayoutId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SewingLayoutId.HeaderText = "Layout No"
        Me.SewingLayoutId.Name = "SewingLayoutId"
        Me.SewingLayoutId.ReadOnly = True
        Me.SewingLayoutId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewingLayoutId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SewingLayoutId.ValueMember = "LayoutId"
        Me.SewingLayoutId.Width = 75
        '
        'SewingLayoutBindingSource
        '
        Me.SewingLayoutBindingSource.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource.DataSource = Me.SewingLayoutLookupDataSet
        '
        'SewingLayoutLookupDataSet
        '
        Me.SewingLayoutLookupDataSet.DataSetName = "SewingLayoutLookupDataSet"
        Me.SewingLayoutLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InputQuantityDataGridViewTextBoxColumn
        '
        Me.InputQuantityDataGridViewTextBoxColumn.DataPropertyName = "InputQuantity"
        Me.InputQuantityDataGridViewTextBoxColumn.HeaderText = "Input Quantity"
        Me.InputQuantityDataGridViewTextBoxColumn.Name = "InputQuantityDataGridViewTextBoxColumn"
        Me.InputQuantityDataGridViewTextBoxColumn.Width = 80
        '
        'OutputQuantityDataGridViewTextBoxColumn
        '
        Me.OutputQuantityDataGridViewTextBoxColumn.DataPropertyName = "OutputQuantity"
        Me.OutputQuantityDataGridViewTextBoxColumn.HeaderText = "Output Quantity"
        Me.OutputQuantityDataGridViewTextBoxColumn.Name = "OutputQuantityDataGridViewTextBoxColumn"
        '
        'RejectQuantityDataGridViewTextBoxColumn
        '
        Me.RejectQuantityDataGridViewTextBoxColumn.DataPropertyName = "RejectQuantity"
        Me.RejectQuantityDataGridViewTextBoxColumn.HeaderText = "Reject Quantity"
        Me.RejectQuantityDataGridViewTextBoxColumn.Name = "RejectQuantityDataGridViewTextBoxColumn"
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'SewingProductionBindingSource
        '
        Me.SewingProductionBindingSource.DataMember = "SewingProduction"
        Me.SewingProductionBindingSource.DataSource = Me.SewingProductionDataSet
        '
        'SewingProductionDataSet
        '
        Me.SewingProductionDataSet.DataSetName = "SewingProductionDataSet"
        Me.SewingProductionDataSet.EnforceConstraints = False
        Me.SewingProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingLayoutTableAdapter
        '
        Me.SewingLayoutTableAdapter.ClearBeforeFill = True
        '
        'SewingProductionTableAdapter
        '
        Me.SewingProductionTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderPOTableAdapter
        '
        Me.OrderPOTableAdapter.ClearBeforeFill = True
        '
        'OrderP0Lookup1TableAdapter
        '
        Me.OrderP0Lookup1TableAdapter.ClearBeforeFill = True
        '
        'frmSewingTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 436)
        Me.Controls.Add(Me.SewingProductionDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSewingTransfer"
        Me.Text = "Sewing Transfer"
        CType(Me.PgNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromOrderDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PgNo1GridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToOrderDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderP0Lookup1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingProductionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PgNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FromOrderDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PgNo1GridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToOrderDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents SewingProductionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SewingProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingProductionDataSet As KSoft_Apparel.SewingProductionDataSet
    Friend WithEvents SewingProductionTableAdapter As KSoft_Apparel.SewingProductionDataSetTableAdapters.SewingProductionTableAdapter
    Friend WithEvents OrderPOLookupDataSet As KSoft_Apparel.OrderPOLookupDataSet
    Friend WithEvents OrderP0LookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOTableAdapter As KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter
    Friend WithEvents SewingLayoutLookupDataSet As KSoft_Apparel.SewingLayoutLookupDataSet
    Friend WithEvents SewingLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutTableAdapter As KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderP0Lookup1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderP0Lookup1TableAdapter As KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderP0Lookup1TableAdapter
    Friend WithEvents colOrderDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOandColor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOAndColorAndDes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOandColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colOrderId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsChecked As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SewingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents OrderDetailsId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SewingLayoutId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InputQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutputQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RejectQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
