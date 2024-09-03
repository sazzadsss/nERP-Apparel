<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashingBatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashingBatch))
        Me.WashingBatchDataSet = New KSoft_Apparel.WashingBatchDataSet()
        Me.WashingBatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingBatchTableAdapter = New KSoft_Apparel.WashingBatchDataSetTableAdapters.WashingBatchTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.WashingBatchDataSetTableAdapters.TableAdapterManager()
        Me.WashingBatchBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.WashingBatchBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WashingBatchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingBatchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashingBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDevelopment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchQuantityPc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowByWashingRequestDetailsButton = New System.Windows.Forms.Button()
        Me.ShowByWashingRequestButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AddBatchButton = New System.Windows.Forms.Button()
        Me.BatchQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BalanceQtyPcsLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AlreadBatchQtyPcsLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.InputQtyPcsLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BalanceQuantityLabel = New System.Windows.Forms.Label()
        Me.AlreadyBatchLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InputQtyLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WRDIDGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashingRequestDetailsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDetailsLookupDataSet = New KSoft_Apparel.WashingRequestDetailsLookupDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoOfBatchNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WRIDGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashingRequestLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDataSet = New KSoft_Apparel.WashingRequestDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashingRequestLookUpTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter()
        Me.WashingRequestDetailsLookupTableAdapter = New KSoft_Apparel.WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupTableAdapter()
        Me.colWashingBatchDate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.WashingBatchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingBatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingBatchBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WashingBatchBindingNavigator.SuspendLayout()
        CType(Me.WashingBatchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WRDIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfBatchNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WashingBatchDataSet
        '
        Me.WashingBatchDataSet.DataSetName = "WashingBatchDataSet"
        Me.WashingBatchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashingBatchBindingSource
        '
        Me.WashingBatchBindingSource.DataMember = "WashingBatch"
        Me.WashingBatchBindingSource.DataSource = Me.WashingBatchDataSet
        '
        'WashingBatchTableAdapter
        '
        Me.WashingBatchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.WashingBatchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WashingBatchTableAdapter = Me.WashingBatchTableAdapter
        '
        'WashingBatchBindingNavigator
        '
        Me.WashingBatchBindingNavigator.AddNewItem = Nothing
        Me.WashingBatchBindingNavigator.BindingSource = Me.WashingBatchBindingSource
        Me.WashingBatchBindingNavigator.CountItem = Nothing
        Me.WashingBatchBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WashingBatchBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.WashingBatchBindingNavigatorSaveItem})
        Me.WashingBatchBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WashingBatchBindingNavigator.MoveFirstItem = Nothing
        Me.WashingBatchBindingNavigator.MoveLastItem = Nothing
        Me.WashingBatchBindingNavigator.MoveNextItem = Nothing
        Me.WashingBatchBindingNavigator.MovePreviousItem = Nothing
        Me.WashingBatchBindingNavigator.Name = "WashingBatchBindingNavigator"
        Me.WashingBatchBindingNavigator.PositionItem = Nothing
        Me.WashingBatchBindingNavigator.Size = New System.Drawing.Size(1276, 25)
        Me.WashingBatchBindingNavigator.TabIndex = 0
        Me.WashingBatchBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'WashingBatchBindingNavigatorSaveItem
        '
        Me.WashingBatchBindingNavigatorSaveItem.Image = CType(resources.GetObject("WashingBatchBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WashingBatchBindingNavigatorSaveItem.Name = "WashingBatchBindingNavigatorSaveItem"
        Me.WashingBatchBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.WashingBatchBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WashingBatchGridControl
        '
        Me.WashingBatchGridControl.DataSource = Me.WashingBatchBindingSource
        Me.WashingBatchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WashingBatchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.WashingBatchGridControl.MainView = Me.GridView1
        Me.WashingBatchGridControl.Name = "WashingBatchGridControl"
        Me.WashingBatchGridControl.Size = New System.Drawing.Size(1276, 428)
        Me.WashingBatchGridControl.TabIndex = 1
        Me.WashingBatchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingBatchId, Me.colWashingBatchNo, Me.colProgramNo, Me.colFabricColorName, Me.colColorReference, Me.colIsDevelopment, Me.colBatchQuantity, Me.colRemarks, Me.colBatchQuantityPc, Me.colWashingBatchDate})
        Me.GridView1.GridControl = Me.WashingBatchGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colWashingBatchId
        '
        Me.colWashingBatchId.FieldName = "WashingBatchId"
        Me.colWashingBatchId.Name = "colWashingBatchId"
        Me.colWashingBatchId.OptionsColumn.ReadOnly = True
        Me.colWashingBatchId.Width = 125
        '
        'colWashingBatchNo
        '
        Me.colWashingBatchNo.FieldName = "WashingBatchNo"
        Me.colWashingBatchNo.Name = "colWashingBatchNo"
        Me.colWashingBatchNo.Visible = True
        Me.colWashingBatchNo.VisibleIndex = 1
        Me.colWashingBatchNo.Width = 116
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Width = 105
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 2
        Me.colFabricColorName.Width = 213
        '
        'colColorReference
        '
        Me.colColorReference.FieldName = "ColorReference"
        Me.colColorReference.Name = "colColorReference"
        Me.colColorReference.Visible = True
        Me.colColorReference.VisibleIndex = 3
        Me.colColorReference.Width = 197
        '
        'colIsDevelopment
        '
        Me.colIsDevelopment.FieldName = "IsDevelopment"
        Me.colIsDevelopment.Name = "colIsDevelopment"
        Me.colIsDevelopment.Visible = True
        Me.colIsDevelopment.VisibleIndex = 0
        Me.colIsDevelopment.Width = 87
        '
        'colBatchQuantity
        '
        Me.colBatchQuantity.Caption = "Batch Quantity_Kg"
        Me.colBatchQuantity.FieldName = "BatchQuantity"
        Me.colBatchQuantity.Name = "colBatchQuantity"
        Me.colBatchQuantity.Visible = True
        Me.colBatchQuantity.VisibleIndex = 5
        Me.colBatchQuantity.Width = 159
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 346
        '
        'colBatchQuantityPc
        '
        Me.colBatchQuantityPc.FieldName = "BatchQuantityPc"
        Me.colBatchQuantityPc.Name = "colBatchQuantityPc"
        Me.colBatchQuantityPc.Visible = True
        Me.colBatchQuantityPc.VisibleIndex = 4
        Me.colBatchQuantityPc.Width = 140
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShowByWashingRequestDetailsButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShowByWashingRequestButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddBatchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BatchQuantityTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WRDIDGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NoOfBatchNumericUpDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WRIDGridLookUpEdit)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WashingBatchGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 581)
        Me.SplitContainer1.SplitterDistance = 149
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(338, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Batch Quantity_Pcs"
        '
        'ShowByWashingRequestDetailsButton
        '
        Me.ShowByWashingRequestDetailsButton.Location = New System.Drawing.Point(425, 54)
        Me.ShowByWashingRequestDetailsButton.Name = "ShowByWashingRequestDetailsButton"
        Me.ShowByWashingRequestDetailsButton.Size = New System.Drawing.Size(66, 23)
        Me.ShowByWashingRequestDetailsButton.TabIndex = 14
        Me.ShowByWashingRequestDetailsButton.Text = "&Show"
        Me.ShowByWashingRequestDetailsButton.UseVisualStyleBackColor = True
        Me.ShowByWashingRequestDetailsButton.Visible = False
        '
        'ShowByWashingRequestButton
        '
        Me.ShowByWashingRequestButton.Location = New System.Drawing.Point(425, 25)
        Me.ShowByWashingRequestButton.Name = "ShowByWashingRequestButton"
        Me.ShowByWashingRequestButton.Size = New System.Drawing.Size(66, 23)
        Me.ShowByWashingRequestButton.TabIndex = 13
        Me.ShowByWashingRequestButton.Text = "&Show"
        Me.ShowByWashingRequestButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Washing Request No"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(22, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "No of Batch"
        '
        'AddBatchButton
        '
        Me.AddBatchButton.Location = New System.Drawing.Point(425, 79)
        Me.AddBatchButton.Name = "AddBatchButton"
        Me.AddBatchButton.Size = New System.Drawing.Size(66, 46)
        Me.AddBatchButton.TabIndex = 10
        Me.AddBatchButton.Text = "Add Batch"
        Me.AddBatchButton.UseVisualStyleBackColor = True
        '
        'BatchQuantityTextBox
        '
        Me.BatchQuantityTextBox.Location = New System.Drawing.Point(147, 81)
        Me.BatchQuantityTextBox.Name = "BatchQuantityTextBox"
        Me.BatchQuantityTextBox.Size = New System.Drawing.Size(78, 20)
        Me.BatchQuantityTextBox.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Batch Quantity_Kg"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BalanceQtyPcsLabel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AlreadBatchQtyPcsLabel)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.InputQtyPcsLabel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BalanceQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.AlreadyBatchLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.InputQtyLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(546, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 114)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summery"
        '
        'BalanceQtyPcsLabel
        '
        Me.BalanceQtyPcsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BalanceQtyPcsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BalanceQtyPcsLabel.Location = New System.Drawing.Point(454, 77)
        Me.BalanceQtyPcsLabel.Name = "BalanceQtyPcsLabel"
        Me.BalanceQtyPcsLabel.Size = New System.Drawing.Size(128, 24)
        Me.BalanceQtyPcsLabel.TabIndex = 12
        Me.BalanceQtyPcsLabel.Text = "0"
        Me.BalanceQtyPcsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(316, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Balance Quantity (Pcs)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlreadBatchQtyPcsLabel
        '
        Me.AlreadBatchQtyPcsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AlreadBatchQtyPcsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AlreadBatchQtyPcsLabel.Location = New System.Drawing.Point(454, 53)
        Me.AlreadBatchQtyPcsLabel.Name = "AlreadBatchQtyPcsLabel"
        Me.AlreadBatchQtyPcsLabel.Size = New System.Drawing.Size(128, 23)
        Me.AlreadBatchQtyPcsLabel.TabIndex = 10
        Me.AlreadBatchQtyPcsLabel.Text = "0"
        Me.AlreadBatchQtyPcsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(316, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 23)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Already Batch (Pcs)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputQtyPcsLabel
        '
        Me.InputQtyPcsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InputQtyPcsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputQtyPcsLabel.Location = New System.Drawing.Point(454, 30)
        Me.InputQtyPcsLabel.Name = "InputQtyPcsLabel"
        Me.InputQtyPcsLabel.Size = New System.Drawing.Size(128, 23)
        Me.InputQtyPcsLabel.TabIndex = 8
        Me.InputQtyPcsLabel.Text = "0"
        Me.InputQtyPcsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(316, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 23)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Input Quantity (Pcs)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(600, 30)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(88, 69)
        Me.RefreshButton.TabIndex = 6
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(166, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "0"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BalanceQuantityLabel
        '
        Me.BalanceQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BalanceQuantityLabel.Location = New System.Drawing.Point(37, 77)
        Me.BalanceQuantityLabel.Name = "BalanceQuantityLabel"
        Me.BalanceQuantityLabel.Size = New System.Drawing.Size(121, 23)
        Me.BalanceQuantityLabel.TabIndex = 4
        Me.BalanceQuantityLabel.Text = "Balance Quantity (Kg)"
        Me.BalanceQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlreadyBatchLabel
        '
        Me.AlreadyBatchLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AlreadyBatchLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AlreadyBatchLabel.Location = New System.Drawing.Point(166, 53)
        Me.AlreadyBatchLabel.Name = "AlreadyBatchLabel"
        Me.AlreadyBatchLabel.Size = New System.Drawing.Size(128, 23)
        Me.AlreadyBatchLabel.TabIndex = 3
        Me.AlreadyBatchLabel.Text = "0"
        Me.AlreadyBatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(37, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Already Batch (Kg)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputQtyLabel
        '
        Me.InputQtyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InputQtyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputQtyLabel.Location = New System.Drawing.Point(166, 30)
        Me.InputQtyLabel.Name = "InputQtyLabel"
        Me.InputQtyLabel.Size = New System.Drawing.Size(128, 23)
        Me.InputQtyLabel.TabIndex = 1
        Me.InputQtyLabel.Text = "0"
        Me.InputQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(37, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Input Quantity (Kg)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WRDIDGridLookUpEdit
        '
        Me.WRDIDGridLookUpEdit.Location = New System.Drawing.Point(147, 55)
        Me.WRDIDGridLookUpEdit.Name = "WRDIDGridLookUpEdit"
        Me.WRDIDGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WRDIDGridLookUpEdit.Properties.DataSource = Me.WashingRequestDetailsLookupBindingSource
        Me.WRDIDGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.WRDIDGridLookUpEdit.Properties.NullText = ""
        Me.WRDIDGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.WRDIDGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WRDIDGridLookUpEdit.Properties.ValueMember = "WashingRequestDetailsId"
        Me.WRDIDGridLookUpEdit.Size = New System.Drawing.Size(272, 20)
        Me.WRDIDGridLookUpEdit.TabIndex = 3
        '
        'WashingRequestDetailsLookupBindingSource
        '
        Me.WashingRequestDetailsLookupBindingSource.DataMember = "WashingRequestDetailsLookup"
        Me.WashingRequestDetailsLookupBindingSource.DataSource = Me.WashingRequestDetailsLookupDataSet
        '
        'WashingRequestDetailsLookupDataSet
        '
        Me.WashingRequestDetailsLookupDataSet.DataSetName = "WashingRequestDetailsLookupDataSet"
        Me.WashingRequestDetailsLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'NoOfBatchNumericUpDown
        '
        Me.NoOfBatchNumericUpDown.Location = New System.Drawing.Point(147, 110)
        Me.NoOfBatchNumericUpDown.Name = "NoOfBatchNumericUpDown"
        Me.NoOfBatchNumericUpDown.Size = New System.Drawing.Size(78, 20)
        Me.NoOfBatchNumericUpDown.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Washing Request Details"
        '
        'WRIDGridLookUpEdit
        '
        Me.WRIDGridLookUpEdit.Location = New System.Drawing.Point(147, 26)
        Me.WRIDGridLookUpEdit.Name = "WRIDGridLookUpEdit"
        Me.WRIDGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WRIDGridLookUpEdit.Properties.DataSource = Me.WashingRequestLookUpBindingSource
        Me.WRIDGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.WRIDGridLookUpEdit.Properties.NullText = ""
        Me.WRIDGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.WRIDGridLookUpEdit.Properties.ValueMember = "WashingRequestId"
        Me.WRIDGridLookUpEdit.Size = New System.Drawing.Size(272, 20)
        Me.WRIDGridLookUpEdit.TabIndex = 0
        '
        'WashingRequestLookUpBindingSource
        '
        Me.WashingRequestLookUpBindingSource.DataMember = "WashingRequestLookUp"
        Me.WashingRequestLookUpBindingSource.DataSource = Me.WashingRequestDataSet
        '
        'WashingRequestDataSet
        '
        Me.WashingRequestDataSet.DataSetName = "WashingRequestDataSet"
        Me.WashingRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'WashingRequestLookUpTableAdapter
        '
        Me.WashingRequestLookUpTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestDetailsLookupTableAdapter
        '
        Me.WashingRequestDetailsLookupTableAdapter.ClearBeforeFill = True
        '
        'colWashingBatchDate
        '
        Me.colWashingBatchDate.FieldName = "WashingBatchDate"
        Me.colWashingBatchDate.Name = "colWashingBatchDate"
        Me.colWashingBatchDate.Visible = True
        Me.colWashingBatchDate.VisibleIndex = 2
        '
        'frmWashingBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 610)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.WashingBatchBindingNavigator)
        Me.Name = "frmWashingBatch"
        Me.Text = "Washing Batch"
        CType(Me.WashingBatchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingBatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingBatchBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WashingBatchBindingNavigator.ResumeLayout(False)
        Me.WashingBatchBindingNavigator.PerformLayout()
        CType(Me.WashingBatchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.WRDIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfBatchNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WashingBatchDataSet As KSoft_Apparel.WashingBatchDataSet
    Friend WithEvents WashingBatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingBatchTableAdapter As KSoft_Apparel.WashingBatchDataSetTableAdapters.WashingBatchTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.WashingBatchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WashingBatchBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingBatchBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingBatchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingBatchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents WRIDGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WRDIDGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NoOfBatchNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BalanceQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents AlreadyBatchLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InputQtyLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddBatchButton As System.Windows.Forms.Button
    Friend WithEvents BatchQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WashingRequestDataSet As KSoft_Apparel.WashingRequestDataSet
    Friend WithEvents WashingRequestLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestLookUpTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter
    Friend WithEvents WashingRequestDetailsLookupDataSet As KSoft_Apparel.WashingRequestDetailsLookupDataSet
    Friend WithEvents WashingRequestDetailsLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestDetailsLookupTableAdapter As KSoft_Apparel.WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupTableAdapter
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByWashingRequestButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ShowByWashingRequestDetailsButton As System.Windows.Forms.Button
    Friend WithEvents BalanceQtyPcsLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AlreadBatchQtyPcsLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents InputQtyPcsLabel As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents colBatchQuantityPc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingBatchDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
