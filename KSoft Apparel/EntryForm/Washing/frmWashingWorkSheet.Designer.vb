<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashingWorkSheet
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
        Dim WashingRequestNoLabel As System.Windows.Forms.Label
        Dim WashingRequestDateLabel As System.Windows.Forms.Label
        Dim StyleIdLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim WashTypeIdLabel As System.Windows.Forms.Label
        Dim WashingDeliveryDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim RefSampleLabel As System.Windows.Forms.Label
        Dim RequestTypeLabel As System.Windows.Forms.Label
        Dim AmndNoLabel As System.Windows.Forms.Label
        Dim AmndDateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ApprovedDateLabel As System.Windows.Forms.Label
        Dim ApprovedByLabel As System.Windows.Forms.Label
        Dim FileNameAndNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashingWorkSheet))
        Dim Label1 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.WashingRequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDataSet = New KSoft_Apparel.WashingRequestDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FileNameAndNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApprovedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApprovedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProgramNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AmndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmndNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ProgramNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WashingRequestNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequestTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet()
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashingRequestDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RefSampleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashingDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GetColorButton = New System.Windows.Forms.Button()
        Me.WashingRequestDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.WashingRequestDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingRequestDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashingRequestId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetSizeButton = New System.Windows.Forms.Button()
        Me.WashingRequestSizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.WashingRequestSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingRequestSizeDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashingRequestDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashingRequestTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.WashingRequestDataSetTableAdapters.TableAdapterManager()
        Me.WashingRequestDetailsTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestDetailsTableAdapter()
        Me.WashingRequestSizeDetailsTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestSizeDetailsTableAdapter()
        Me.WashingRequestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.WashingRequestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.WashingRequestNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashingRequestLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingRequestNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashingRequestLookUpTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        WashingRequestNoLabel = New System.Windows.Forms.Label()
        WashingRequestDateLabel = New System.Windows.Forms.Label()
        StyleIdLabel = New System.Windows.Forms.Label()
        BuyerIdLabel = New System.Windows.Forms.Label()
        WashTypeIdLabel = New System.Windows.Forms.Label()
        WashingDeliveryDateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        RefSampleLabel = New System.Windows.Forms.Label()
        RequestTypeLabel = New System.Windows.Forms.Label()
        AmndNoLabel = New System.Windows.Forms.Label()
        AmndDateLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ApprovedDateLabel = New System.Windows.Forms.Label()
        ApprovedByLabel = New System.Windows.Forms.Label()
        FileNameAndNumberLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FileNameAndNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmndNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefSampleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.WashingRequestDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WashingRequestBindingNavigator.SuspendLayout()
        CType(Me.WashingRequestNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WashingRequestNoLabel
        '
        WashingRequestNoLabel.AutoSize = True
        WashingRequestNoLabel.Location = New System.Drawing.Point(19, 25)
        WashingRequestNoLabel.Name = "WashingRequestNoLabel"
        WashingRequestNoLabel.Size = New System.Drawing.Size(112, 13)
        WashingRequestNoLabel.TabIndex = 2
        WashingRequestNoLabel.Text = "Washing Request No:"
        '
        'WashingRequestDateLabel
        '
        WashingRequestDateLabel.AutoSize = True
        WashingRequestDateLabel.Location = New System.Drawing.Point(19, 51)
        WashingRequestDateLabel.Name = "WashingRequestDateLabel"
        WashingRequestDateLabel.Size = New System.Drawing.Size(121, 13)
        WashingRequestDateLabel.TabIndex = 4
        WashingRequestDateLabel.Text = "Washing Request Date:"
        '
        'StyleIdLabel
        '
        StyleIdLabel.AutoSize = True
        StyleIdLabel.Location = New System.Drawing.Point(321, 102)
        StyleIdLabel.Name = "StyleIdLabel"
        StyleIdLabel.Size = New System.Drawing.Size(50, 13)
        StyleIdLabel.TabIndex = 6
        StyleIdLabel.Text = "Style No:"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(322, 128)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(40, 13)
        BuyerIdLabel.TabIndex = 8
        BuyerIdLabel.Text = "Buyer :"
        '
        'WashTypeIdLabel
        '
        WashTypeIdLabel.AutoSize = True
        WashTypeIdLabel.Location = New System.Drawing.Point(19, 103)
        WashTypeIdLabel.Name = "WashTypeIdLabel"
        WashTypeIdLabel.Size = New System.Drawing.Size(65, 13)
        WashTypeIdLabel.TabIndex = 10
        WashTypeIdLabel.Text = "Wash Type:"
        '
        'WashingDeliveryDateLabel
        '
        WashingDeliveryDateLabel.AutoSize = True
        WashingDeliveryDateLabel.Location = New System.Drawing.Point(19, 77)
        WashingDeliveryDateLabel.Name = "WashingDeliveryDateLabel"
        WashingDeliveryDateLabel.Size = New System.Drawing.Size(119, 13)
        WashingDeliveryDateLabel.TabIndex = 16
        WashingDeliveryDateLabel.Text = "Washing Delivery Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(19, 156)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 20
        RemarksLabel.Text = "Remarks:"
        '
        'RefSampleLabel
        '
        RefSampleLabel.AutoSize = True
        RefSampleLabel.Location = New System.Drawing.Point(321, 25)
        RefSampleLabel.Name = "RefSampleLabel"
        RefSampleLabel.Size = New System.Drawing.Size(65, 13)
        RefSampleLabel.TabIndex = 22
        RefSampleLabel.Text = "Ref Sample:"
        '
        'RequestTypeLabel
        '
        RequestTypeLabel.AutoSize = True
        RequestTypeLabel.Location = New System.Drawing.Point(321, 52)
        RequestTypeLabel.Name = "RequestTypeLabel"
        RequestTypeLabel.Size = New System.Drawing.Size(77, 13)
        RequestTypeLabel.TabIndex = 24
        RequestTypeLabel.Text = "Request Type:"
        '
        'AmndNoLabel
        '
        AmndNoLabel.AutoSize = True
        AmndNoLabel.Location = New System.Drawing.Point(593, 27)
        AmndNoLabel.Name = "AmndNoLabel"
        AmndNoLabel.Size = New System.Drawing.Size(54, 13)
        AmndNoLabel.TabIndex = 27
        AmndNoLabel.Text = "Amnd No:"
        '
        'AmndDateLabel
        '
        AmndDateLabel.AutoSize = True
        AmndDateLabel.Location = New System.Drawing.Point(593, 53)
        AmndDateLabel.Name = "AmndDateLabel"
        AmndDateLabel.Size = New System.Drawing.Size(63, 13)
        AmndDateLabel.TabIndex = 28
        AmndDateLabel.Text = "Amnd Date:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(19, 129)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 30
        StatusLabel.Text = "Status:"
        '
        'ApprovedDateLabel
        '
        ApprovedDateLabel.AutoSize = True
        ApprovedDateLabel.Location = New System.Drawing.Point(593, 79)
        ApprovedDateLabel.Name = "ApprovedDateLabel"
        ApprovedDateLabel.Size = New System.Drawing.Size(82, 13)
        ApprovedDateLabel.TabIndex = 31
        ApprovedDateLabel.Text = "Approved Date:"
        '
        'ApprovedByLabel
        '
        ApprovedByLabel.AutoSize = True
        ApprovedByLabel.Location = New System.Drawing.Point(593, 103)
        ApprovedByLabel.Name = "ApprovedByLabel"
        ApprovedByLabel.Size = New System.Drawing.Size(71, 13)
        ApprovedByLabel.TabIndex = 32
        ApprovedByLabel.Text = "Approved By:"
        '
        'FileNameAndNumberLabel
        '
        FileNameAndNumberLabel.AutoSize = True
        FileNameAndNumberLabel.Location = New System.Drawing.Point(594, 129)
        FileNameAndNumberLabel.Name = "FileNameAndNumberLabel"
        FileNameAndNumberLabel.Size = New System.Drawing.Size(119, 13)
        FileNameAndNumberLabel.TabIndex = 33
        FileNameAndNumberLabel.Text = "File Name And Number:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1156, 582)
        Me.SplitContainer1.SplitterDistance = 239
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicturePictureEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(891, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 194)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Picture"
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(17, 23)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Size = New System.Drawing.Size(165, 155)
        Me.PicturePictureEdit.TabIndex = 19
        '
        'WashingRequestBindingSource
        '
        Me.WashingRequestBindingSource.DataMember = "WashingRequest"
        Me.WashingRequestBindingSource.DataSource = Me.WashingRequestDataSet
        '
        'WashingRequestDataSet
        '
        Me.WashingRequestDataSet.DataSetName = "WashingRequestDataSet"
        Me.WashingRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.UnitPriceTextEdit)
        Me.GroupBox1.Controls.Add(FileNameAndNumberLabel)
        Me.GroupBox1.Controls.Add(Me.FileNameAndNumberTextEdit)
        Me.GroupBox1.Controls.Add(ApprovedByLabel)
        Me.GroupBox1.Controls.Add(Me.ApprovedByTextEdit)
        Me.GroupBox1.Controls.Add(ApprovedDateLabel)
        Me.GroupBox1.Controls.Add(Me.ApprovedDateDateEdit)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextEdit)
        Me.GroupBox1.Controls.Add(Me.ProgramNoLinkLabel)
        Me.GroupBox1.Controls.Add(AmndDateLabel)
        Me.GroupBox1.Controls.Add(Me.AmndDateDateEdit)
        Me.GroupBox1.Controls.Add(AmndNoLabel)
        Me.GroupBox1.Controls.Add(Me.AmndNoSpinEdit)
        Me.GroupBox1.Controls.Add(Me.ProgramNoTextEdit)
        Me.GroupBox1.Controls.Add(WashingRequestNoLabel)
        Me.GroupBox1.Controls.Add(Me.WashingRequestNoTextEdit)
        Me.GroupBox1.Controls.Add(Me.RequestTypeTextEdit)
        Me.GroupBox1.Controls.Add(WashingRequestDateLabel)
        Me.GroupBox1.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(RequestTypeLabel)
        Me.GroupBox1.Controls.Add(WashTypeIdLabel)
        Me.GroupBox1.Controls.Add(Me.WashingRequestDateDateEdit)
        Me.GroupBox1.Controls.Add(Me.RefSampleTextEdit)
        Me.GroupBox1.Controls.Add(StyleIdLabel)
        Me.GroupBox1.Controls.Add(RefSampleLabel)
        Me.GroupBox1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.RemarksTextEdit)
        Me.GroupBox1.Controls.Add(BuyerIdLabel)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.WashingDeliveryDateDateEdit)
        Me.GroupBox1.Controls.Add(WashingDeliveryDateLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 194)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Information"
        '
        'FileNameAndNumberTextEdit
        '
        Me.FileNameAndNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "FileNameAndNumber", True))
        Me.FileNameAndNumberTextEdit.Location = New System.Drawing.Point(719, 126)
        Me.FileNameAndNumberTextEdit.Name = "FileNameAndNumberTextEdit"
        Me.FileNameAndNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.FileNameAndNumberTextEdit.TabIndex = 34
        '
        'ApprovedByTextEdit
        '
        Me.ApprovedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "ApprovedBy", True))
        Me.ApprovedByTextEdit.Location = New System.Drawing.Point(719, 100)
        Me.ApprovedByTextEdit.Name = "ApprovedByTextEdit"
        Me.ApprovedByTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ApprovedByTextEdit.TabIndex = 33
        '
        'ApprovedDateDateEdit
        '
        Me.ApprovedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "ApprovedDate", True))
        Me.ApprovedDateDateEdit.EditValue = Nothing
        Me.ApprovedDateDateEdit.Location = New System.Drawing.Point(719, 74)
        Me.ApprovedDateDateEdit.Name = "ApprovedDateDateEdit"
        Me.ApprovedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApprovedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ApprovedDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ApprovedDateDateEdit.TabIndex = 32
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "Status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(147, 125)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Size = New System.Drawing.Size(157, 20)
        Me.StatusTextEdit.TabIndex = 31
        '
        'ProgramNoLinkLabel
        '
        Me.ProgramNoLinkLabel.AutoSize = True
        Me.ProgramNoLinkLabel.Location = New System.Drawing.Point(320, 77)
        Me.ProgramNoLinkLabel.Name = "ProgramNoLinkLabel"
        Me.ProgramNoLinkLabel.Size = New System.Drawing.Size(69, 13)
        Me.ProgramNoLinkLabel.TabIndex = 30
        Me.ProgramNoLinkLabel.TabStop = True
        Me.ProgramNoLinkLabel.Text = "Program No :"
        '
        'AmndDateDateEdit
        '
        Me.AmndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "AmndDate", True))
        Me.AmndDateDateEdit.EditValue = Nothing
        Me.AmndDateDateEdit.Location = New System.Drawing.Point(719, 48)
        Me.AmndDateDateEdit.Name = "AmndDateDateEdit"
        Me.AmndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmndDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.AmndDateDateEdit.TabIndex = 29
        '
        'AmndNoSpinEdit
        '
        Me.AmndNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "AmndNo", True))
        Me.AmndNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmndNoSpinEdit.Location = New System.Drawing.Point(719, 22)
        Me.AmndNoSpinEdit.Name = "AmndNoSpinEdit"
        Me.AmndNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmndNoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.AmndNoSpinEdit.TabIndex = 28
        '
        'ProgramNoTextEdit
        '
        Me.ProgramNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "ProgramNo", True))
        Me.ProgramNoTextEdit.Location = New System.Drawing.Point(409, 74)
        Me.ProgramNoTextEdit.Name = "ProgramNoTextEdit"
        Me.ProgramNoTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.ProgramNoTextEdit.TabIndex = 27
        '
        'WashingRequestNoTextEdit
        '
        Me.WashingRequestNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "WashingRequestNo", True))
        Me.WashingRequestNoTextEdit.Location = New System.Drawing.Point(147, 22)
        Me.WashingRequestNoTextEdit.Name = "WashingRequestNoTextEdit"
        Me.WashingRequestNoTextEdit.Size = New System.Drawing.Size(157, 20)
        Me.WashingRequestNoTextEdit.TabIndex = 3
        '
        'RequestTypeTextEdit
        '
        Me.RequestTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "RequestType", True))
        Me.RequestTypeTextEdit.Location = New System.Drawing.Point(409, 49)
        Me.RequestTypeTextEdit.Name = "RequestTypeTextEdit"
        Me.RequestTypeTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.RequestTypeTextEdit.TabIndex = 25
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(147, 100)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.WashTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.WashTypeIdGridLookUpEdit.Properties.PopupView = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(157, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 11
        '
        'WashTypeMstBindingSource
        '
        Me.WashTypeMstBindingSource.DataMember = "WashTypeMst"
        Me.WashTypeMstBindingSource.DataSource = Me.WashTypeDataSet
        '
        'WashTypeDataSet
        '
        Me.WashTypeDataSet.DataSetName = "WashTypeDataSet"
        Me.WashTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashTypeIdGridLookUpEditView
        '
        Me.WashTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashType})
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colWashType
        '
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.Visible = True
        Me.colWashType.VisibleIndex = 0
        '
        'WashingRequestDateDateEdit
        '
        Me.WashingRequestDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "WashingRequestDate", True))
        Me.WashingRequestDateDateEdit.EditValue = Nothing
        Me.WashingRequestDateDateEdit.Location = New System.Drawing.Point(147, 48)
        Me.WashingRequestDateDateEdit.Name = "WashingRequestDateDateEdit"
        Me.WashingRequestDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashingRequestDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.WashingRequestDateDateEdit.Size = New System.Drawing.Size(157, 20)
        Me.WashingRequestDateDateEdit.TabIndex = 5
        '
        'RefSampleTextEdit
        '
        Me.RefSampleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "RefSample", True))
        Me.RefSampleTextEdit.Location = New System.Drawing.Point(409, 24)
        Me.RefSampleTextEdit.Name = "RefSampleTextEdit"
        Me.RefSampleTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.RefSampleTextEdit.TabIndex = 23
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(409, 100)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(166, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 7
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
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName})
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(147, 151)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(428, 20)
        Me.RemarksTextEdit.TabIndex = 21
        '
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(409, 126)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.PopupView = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(166, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 9
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
        'BuyerIdGridLookUpEditView
        '
        Me.BuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.BuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerIdGridLookUpEditView.Name = "BuyerIdGridLookUpEditView"
        Me.BuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'WashingDeliveryDateDateEdit
        '
        Me.WashingDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "WashingDeliveryDate", True))
        Me.WashingDeliveryDateDateEdit.EditValue = Nothing
        Me.WashingDeliveryDateDateEdit.Location = New System.Drawing.Point(147, 74)
        Me.WashingDeliveryDateDateEdit.Name = "WashingDeliveryDateDateEdit"
        Me.WashingDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashingDeliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.WashingDeliveryDateDateEdit.Size = New System.Drawing.Size(157, 20)
        Me.WashingDeliveryDateDateEdit.TabIndex = 17
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GetColorButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.WashingRequestDetailsGridControl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.GetSizeButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.WashingRequestSizeDetailsGridControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(1156, 339)
        Me.SplitContainer2.SplitterDistance = 869
        Me.SplitContainer2.TabIndex = 1
        '
        'GetColorButton
        '
        Me.GetColorButton.Location = New System.Drawing.Point(16, 4)
        Me.GetColorButton.Name = "GetColorButton"
        Me.GetColorButton.Size = New System.Drawing.Size(75, 23)
        Me.GetColorButton.TabIndex = 1
        Me.GetColorButton.Text = "Get Color"
        Me.GetColorButton.UseVisualStyleBackColor = True
        '
        'WashingRequestDetailsGridControl
        '
        Me.WashingRequestDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WashingRequestDetailsGridControl.DataSource = Me.WashingRequestDetailsBindingSource
        Me.WashingRequestDetailsGridControl.Location = New System.Drawing.Point(0, 31)
        Me.WashingRequestDetailsGridControl.MainView = Me.GridView1
        Me.WashingRequestDetailsGridControl.Name = "WashingRequestDetailsGridControl"
        Me.WashingRequestDetailsGridControl.Size = New System.Drawing.Size(865, 308)
        Me.WashingRequestDetailsGridControl.TabIndex = 0
        Me.WashingRequestDetailsGridControl.UseEmbeddedNavigator = True
        Me.WashingRequestDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'WashingRequestDetailsBindingSource
        '
        Me.WashingRequestDetailsBindingSource.DataMember = "FK_WashingRequestDetails_WashingRequest"
        Me.WashingRequestDetailsBindingSource.DataSource = Me.WashingRequestBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingRequestDetailsId, Me.colWashingRequestId, Me.colFabricColorName, Me.colColorReference, Me.colOrderQuantity, Me.colRemarks})
        Me.GridView1.GridControl = Me.WashingRequestDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsDetail.EnableDetailToolTip = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colWashingRequestDetailsId
        '
        Me.colWashingRequestDetailsId.FieldName = "WashingRequestDetailsId"
        Me.colWashingRequestDetailsId.Name = "colWashingRequestDetailsId"
        Me.colWashingRequestDetailsId.OptionsColumn.ReadOnly = True
        '
        'colWashingRequestId
        '
        Me.colWashingRequestId.FieldName = "WashingRequestId"
        Me.colWashingRequestId.Name = "colWashingRequestId"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        Me.colFabricColorName.Width = 228
        '
        'colColorReference
        '
        Me.colColorReference.FieldName = "ColorReference"
        Me.colColorReference.Name = "colColorReference"
        Me.colColorReference.Visible = True
        Me.colColorReference.VisibleIndex = 1
        Me.colColorReference.Width = 127
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 2
        Me.colOrderQuantity.Width = 125
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 367
        '
        'GetSizeButton
        '
        Me.GetSizeButton.Location = New System.Drawing.Point(18, 4)
        Me.GetSizeButton.Name = "GetSizeButton"
        Me.GetSizeButton.Size = New System.Drawing.Size(75, 23)
        Me.GetSizeButton.TabIndex = 2
        Me.GetSizeButton.Text = "Get Size"
        Me.GetSizeButton.UseVisualStyleBackColor = True
        '
        'WashingRequestSizeDetailsGridControl
        '
        Me.WashingRequestSizeDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WashingRequestSizeDetailsGridControl.DataSource = Me.WashingRequestSizeDetailsBindingSource
        Me.WashingRequestSizeDetailsGridControl.Location = New System.Drawing.Point(3, 31)
        Me.WashingRequestSizeDetailsGridControl.MainView = Me.GridView2
        Me.WashingRequestSizeDetailsGridControl.Name = "WashingRequestSizeDetailsGridControl"
        Me.WashingRequestSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeLookUpEdit})
        Me.WashingRequestSizeDetailsGridControl.Size = New System.Drawing.Size(280, 308)
        Me.WashingRequestSizeDetailsGridControl.TabIndex = 0
        Me.WashingRequestSizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.WashingRequestSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'WashingRequestSizeDetailsBindingSource
        '
        Me.WashingRequestSizeDetailsBindingSource.DataMember = "FK_WashingRequestSizeDetails_WashingRequestDetails"
        Me.WashingRequestSizeDetailsBindingSource.DataSource = Me.WashingRequestDetailsBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingRequestSizeDetailsId, Me.colWashingRequestDetailsId1, Me.colSizeId, Me.colOrderQuantity1})
        Me.GridView2.GridControl = Me.WashingRequestSizeDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colWashingRequestSizeDetailsId
        '
        Me.colWashingRequestSizeDetailsId.FieldName = "WashingRequestSizeDetailsId"
        Me.colWashingRequestSizeDetailsId.Name = "colWashingRequestSizeDetailsId"
        Me.colWashingRequestSizeDetailsId.OptionsColumn.ReadOnly = True
        '
        'colWashingRequestDetailsId1
        '
        Me.colWashingRequestDetailsId1.FieldName = "WashingRequestDetailsId"
        Me.colWashingRequestDetailsId1.Name = "colWashingRequestDetailsId1"
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 90
        '
        'SizeLookUpEdit
        '
        Me.SizeLookUpEdit.AutoHeight = False
        Me.SizeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookUpEdit.ImmediatePopup = True
        Me.SizeLookUpEdit.Name = "SizeLookUpEdit"
        Me.SizeLookUpEdit.NullText = ""
        Me.SizeLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SizeLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.SizeLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeLookUpEdit.ValueMember = "SizeId"
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode1
        '
        Me.colSizeCode1.FieldName = "SizeCode"
        Me.colSizeCode1.Name = "colSizeCode1"
        Me.colSizeCode1.Visible = True
        Me.colSizeCode1.VisibleIndex = 0
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.VisibleIndex = 1
        Me.colOrderQuantity1.Width = 172
        '
        'WashingRequestTableAdapter
        '
        Me.WashingRequestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.WashingRequestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WashingRequestDetailsTableAdapter = Me.WashingRequestDetailsTableAdapter
        Me.TableAdapterManager.WashingRequestSizeDetailsTableAdapter = Me.WashingRequestSizeDetailsTableAdapter
        Me.TableAdapterManager.WashingRequestTableAdapter = Me.WashingRequestTableAdapter
        '
        'WashingRequestDetailsTableAdapter
        '
        Me.WashingRequestDetailsTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestSizeDetailsTableAdapter
        '
        Me.WashingRequestSizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestBindingNavigator
        '
        Me.WashingRequestBindingNavigator.AddNewItem = Nothing
        Me.WashingRequestBindingNavigator.BindingSource = Me.WashingRequestBindingSource
        Me.WashingRequestBindingNavigator.CountItem = Nothing
        Me.WashingRequestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WashingRequestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WashingRequestBindingNavigatorSaveItem, Me.ShowToolStripButton, Me.PrintToolStripButton})
        Me.WashingRequestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WashingRequestBindingNavigator.MoveFirstItem = Nothing
        Me.WashingRequestBindingNavigator.MoveLastItem = Nothing
        Me.WashingRequestBindingNavigator.MoveNextItem = Nothing
        Me.WashingRequestBindingNavigator.MovePreviousItem = Nothing
        Me.WashingRequestBindingNavigator.Name = "WashingRequestBindingNavigator"
        Me.WashingRequestBindingNavigator.PositionItem = Nothing
        Me.WashingRequestBindingNavigator.Size = New System.Drawing.Size(1156, 25)
        Me.WashingRequestBindingNavigator.TabIndex = 1
        Me.WashingRequestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'WashingRequestBindingNavigatorSaveItem
        '
        Me.WashingRequestBindingNavigatorSaveItem.Image = CType(resources.GetObject("WashingRequestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WashingRequestBindingNavigatorSaveItem.Name = "WashingRequestBindingNavigatorSaveItem"
        Me.WashingRequestBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.WashingRequestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShowToolStripButton
        '
        Me.ShowToolStripButton.Image = CType(resources.GetObject("ShowToolStripButton.Image"), System.Drawing.Image)
        Me.ShowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowToolStripButton.Margin = New System.Windows.Forms.Padding(300, 1, 0, 2)
        Me.ShowToolStripButton.Name = "ShowToolStripButton"
        Me.ShowToolStripButton.Size = New System.Drawing.Size(56, 22)
        Me.ShowToolStripButton.Text = "Show"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestNoLookUpEdit
        '
        Me.WashingRequestNoLookUpEdit.Location = New System.Drawing.Point(229, 2)
        Me.WashingRequestNoLookUpEdit.Name = "WashingRequestNoLookUpEdit"
        Me.WashingRequestNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashingRequestNoLookUpEdit.Properties.DataSource = Me.WashingRequestLookUpBindingSource
        Me.WashingRequestNoLookUpEdit.Properties.DisplayMember = "Details"
        Me.WashingRequestNoLookUpEdit.Properties.ImmediatePopup = True
        Me.WashingRequestNoLookUpEdit.Properties.NullText = ""
        Me.WashingRequestNoLookUpEdit.Properties.PopupView = Me.GridView4
        Me.WashingRequestNoLookUpEdit.Properties.ValueMember = "WashingRequestId"
        Me.WashingRequestNoLookUpEdit.Size = New System.Drawing.Size(279, 20)
        Me.WashingRequestNoLookUpEdit.TabIndex = 17
        '
        'WashingRequestLookUpBindingSource
        '
        Me.WashingRequestLookUpBindingSource.DataMember = "WashingRequestLookUp"
        Me.WashingRequestLookUpBindingSource.DataSource = Me.WashingRequestDataSet
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingRequestNo})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colWashingRequestNo
        '
        Me.colWashingRequestNo.FieldName = "WashingRequestNo"
        Me.colWashingRequestNo.Name = "colWashingRequestNo"
        Me.colWashingRequestNo.Visible = True
        Me.colWashingRequestNo.VisibleIndex = 0
        '
        'WashingRequestLookUpTableAdapter
        '
        Me.WashingRequestLookUpTableAdapter.ClearBeforeFill = True
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'UnitPriceTextEdit
        '
        Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.WashingRequestBindingSource, "Price", True))
        Me.UnitPriceTextEdit.Location = New System.Drawing.Point(719, 153)
        Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
        Me.UnitPriceTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.UnitPriceTextEdit.TabIndex = 35
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(594, 156)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 36
        Label1.Text = "Average Unit Price"
        '
        'frmWashingWorkSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 607)
        Me.Controls.Add(Me.WashingRequestNoLookUpEdit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.WashingRequestBindingNavigator)
        Me.Name = "frmWashingWorkSheet"
        Me.Text = "Washing Work Sheet"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FileNameAndNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmndNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefSampleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.WashingRequestDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WashingRequestBindingNavigator.ResumeLayout(False)
        Me.WashingRequestBindingNavigator.PerformLayout()
        CType(Me.WashingRequestNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents WashingRequestDataSet As KSoft_Apparel.WashingRequestDataSet
    Friend WithEvents WashingRequestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.WashingRequestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WashingRequestBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingRequestBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingRequestNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashingRequestDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashingDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefSampleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequestTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashingRequestDetailsTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestDetailsTableAdapter
    Friend WithEvents WashingRequestDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents WashingRequestDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingRequestDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingRequestId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestSizeDetailsTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestSizeDetailsTableAdapter
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents ProgramNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingRequestNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestLookUpTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingRequestSizeDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingRequestDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetColorButton As System.Windows.Forms.Button
    Friend WithEvents AmndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmndNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GetSizeButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ApprovedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApprovedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FileNameAndNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit
End Class
