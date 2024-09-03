<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSampleStatusUpdate
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
        Dim StatusRemarksLabel As System.Windows.Forms.Label
        Dim SampleExDeliveryDateLabel As System.Windows.Forms.Label
        Dim SampleDeliveryQuantityLabel As System.Windows.Forms.Label
        Dim SampleStatusLabel As System.Windows.Forms.Label
        Dim FileReceiveDateLabel As System.Windows.Forms.Label
        Dim AccReceiveDateLabel As System.Windows.Forms.Label
        Dim FabricReceiveDateLabel As System.Windows.Forms.Label
        Dim FileReceiveDetailsLabel As System.Windows.Forms.Label
        Dim AccReceiveDetailsLabel As System.Windows.Forms.Label
        Dim SampleCuttingStartDateLabel As System.Windows.Forms.Label
        Dim SampleCuttingEndDateLabel As System.Windows.Forms.Label
        Dim SamplePrintSendDateLabel As System.Windows.Forms.Label
        Dim SamplePrintReceiveDateLabel As System.Windows.Forms.Label
        Dim SamplePrintSendQtyLabel As System.Windows.Forms.Label
        Dim SamplePrintReceiveQtyLabel As System.Windows.Forms.Label
        Dim SampleEmbSendDateLabel As System.Windows.Forms.Label
        Dim SampleEmbSendQtyLabel As System.Windows.Forms.Label
        Dim SampleEmbReceiveQtyLabel As System.Windows.Forms.Label
        Dim SampleSewingStartDateLabel As System.Windows.Forms.Label
        Dim SampleSewingEndDateLabel As System.Windows.Forms.Label
        Dim SamplePreparedByLabel As System.Windows.Forms.Label
        Dim SampleEmbReceiveDateLabel As System.Windows.Forms.Label
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestNoAndStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByRqButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SampleEmbReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleRequestFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet()
        Me.SamplePreparedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SampleSewingEndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SampleSewingStartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleEmbReceiveQtySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SampleEmbSendQtySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SampleEmbSendDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SamplePrintReceiveQtySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SamplePrintSendQtySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SamplePrintReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SamplePrintSendDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleCuttingEndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleCuttingStartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DelDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleExDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleDeliveryQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.StatusRemarksTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.FileReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FabricReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AccReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FileReceiveDetailsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.AccReceiveDetailsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.SampleRequestFinalTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager()
        Me.SampleStatusTextEdit = New DevExpress.XtraEditors.MemoEdit()
        StatusRemarksLabel = New System.Windows.Forms.Label()
        SampleExDeliveryDateLabel = New System.Windows.Forms.Label()
        SampleDeliveryQuantityLabel = New System.Windows.Forms.Label()
        SampleStatusLabel = New System.Windows.Forms.Label()
        FileReceiveDateLabel = New System.Windows.Forms.Label()
        AccReceiveDateLabel = New System.Windows.Forms.Label()
        FabricReceiveDateLabel = New System.Windows.Forms.Label()
        FileReceiveDetailsLabel = New System.Windows.Forms.Label()
        AccReceiveDetailsLabel = New System.Windows.Forms.Label()
        SampleCuttingStartDateLabel = New System.Windows.Forms.Label()
        SampleCuttingEndDateLabel = New System.Windows.Forms.Label()
        SamplePrintSendDateLabel = New System.Windows.Forms.Label()
        SamplePrintReceiveDateLabel = New System.Windows.Forms.Label()
        SamplePrintSendQtyLabel = New System.Windows.Forms.Label()
        SamplePrintReceiveQtyLabel = New System.Windows.Forms.Label()
        SampleEmbSendDateLabel = New System.Windows.Forms.Label()
        SampleEmbSendQtyLabel = New System.Windows.Forms.Label()
        SampleEmbReceiveQtyLabel = New System.Windows.Forms.Label()
        SampleSewingStartDateLabel = New System.Windows.Forms.Label()
        SampleSewingEndDateLabel = New System.Windows.Forms.Label()
        SamplePreparedByLabel = New System.Windows.Forms.Label()
        SampleEmbReceiveDateLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SampleEmbReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleEmbReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePreparedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSewingEndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSewingEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSewingStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSewingStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleEmbReceiveQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleEmbSendQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleEmbSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleEmbSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintReceiveQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintSendQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleCuttingEndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleCuttingEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleCuttingStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleCuttingStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleExDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleExDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleDeliveryQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusRemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileReceiveDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccReceiveDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusRemarksLabel
        '
        StatusRemarksLabel.AutoSize = True
        StatusRemarksLabel.Location = New System.Drawing.Point(914, 142)
        StatusRemarksLabel.Name = "StatusRemarksLabel"
        StatusRemarksLabel.Size = New System.Drawing.Size(92, 13)
        StatusRemarksLabel.TabIndex = 27
        StatusRemarksLabel.Text = "Comments Status:"
        '
        'SampleExDeliveryDateLabel
        '
        SampleExDeliveryDateLabel.AutoSize = True
        SampleExDeliveryDateLabel.Location = New System.Drawing.Point(914, 17)
        SampleExDeliveryDateLabel.Name = "SampleExDeliveryDateLabel"
        SampleExDeliveryDateLabel.Size = New System.Drawing.Size(127, 13)
        SampleExDeliveryDateLabel.TabIndex = 25
        SampleExDeliveryDateLabel.Text = "Sample Ex Delivery Date:"
        '
        'SampleDeliveryQuantityLabel
        '
        SampleDeliveryQuantityLabel.AutoSize = True
        SampleDeliveryQuantityLabel.Location = New System.Drawing.Point(913, 45)
        SampleDeliveryQuantityLabel.Name = "SampleDeliveryQuantityLabel"
        SampleDeliveryQuantityLabel.Size = New System.Drawing.Size(132, 13)
        SampleDeliveryQuantityLabel.TabIndex = 23
        SampleDeliveryQuantityLabel.Text = "S. Del. Quantity And Date:"
        '
        'SampleStatusLabel
        '
        SampleStatusLabel.AutoSize = True
        SampleStatusLabel.Location = New System.Drawing.Point(914, 96)
        SampleStatusLabel.Name = "SampleStatusLabel"
        SampleStatusLabel.Size = New System.Drawing.Size(78, 13)
        SampleStatusLabel.TabIndex = 21
        SampleStatusLabel.Text = "Sample Status:"
        '
        'FileReceiveDateLabel
        '
        FileReceiveDateLabel.AutoSize = True
        FileReceiveDateLabel.Location = New System.Drawing.Point(25, 18)
        FileReceiveDateLabel.Name = "FileReceiveDateLabel"
        FileReceiveDateLabel.Size = New System.Drawing.Size(95, 13)
        FileReceiveDateLabel.TabIndex = 15
        FileReceiveDateLabel.Text = "File Receive Date:"
        '
        'AccReceiveDateLabel
        '
        AccReceiveDateLabel.AutoSize = True
        AccReceiveDateLabel.Location = New System.Drawing.Point(25, 97)
        AccReceiveDateLabel.Name = "AccReceiveDateLabel"
        AccReceiveDateLabel.Size = New System.Drawing.Size(98, 13)
        AccReceiveDateLabel.TabIndex = 19
        AccReceiveDateLabel.Text = "Acc Receive Date:"
        '
        'FabricReceiveDateLabel
        '
        FabricReceiveDateLabel.AutoSize = True
        FabricReceiveDateLabel.Location = New System.Drawing.Point(26, 170)
        FabricReceiveDateLabel.Name = "FabricReceiveDateLabel"
        FabricReceiveDateLabel.Size = New System.Drawing.Size(108, 13)
        FabricReceiveDateLabel.TabIndex = 17
        FabricReceiveDateLabel.Text = "Fabric Receive Date:"
        '
        'FileReceiveDetailsLabel
        '
        FileReceiveDetailsLabel.AutoSize = True
        FileReceiveDetailsLabel.Location = New System.Drawing.Point(26, 45)
        FileReceiveDetailsLabel.Name = "FileReceiveDetailsLabel"
        FileReceiveDetailsLabel.Size = New System.Drawing.Size(104, 13)
        FileReceiveDetailsLabel.TabIndex = 28
        FileReceiveDetailsLabel.Text = "File Receive Details:"
        '
        'AccReceiveDetailsLabel
        '
        AccReceiveDetailsLabel.AutoSize = True
        AccReceiveDetailsLabel.Location = New System.Drawing.Point(26, 122)
        AccReceiveDetailsLabel.Name = "AccReceiveDetailsLabel"
        AccReceiveDetailsLabel.Size = New System.Drawing.Size(107, 13)
        AccReceiveDetailsLabel.TabIndex = 29
        AccReceiveDetailsLabel.Text = "Acc Receive Details:"
        '
        'SampleCuttingStartDateLabel
        '
        SampleCuttingStartDateLabel.AutoSize = True
        SampleCuttingStartDateLabel.Location = New System.Drawing.Point(396, 18)
        SampleCuttingStartDateLabel.Name = "SampleCuttingStartDateLabel"
        SampleCuttingStartDateLabel.Size = New System.Drawing.Size(132, 13)
        SampleCuttingStartDateLabel.TabIndex = 30
        SampleCuttingStartDateLabel.Text = "Sample Cutting Start Date:"
        '
        'SampleCuttingEndDateLabel
        '
        SampleCuttingEndDateLabel.AutoSize = True
        SampleCuttingEndDateLabel.Location = New System.Drawing.Point(396, 45)
        SampleCuttingEndDateLabel.Name = "SampleCuttingEndDateLabel"
        SampleCuttingEndDateLabel.Size = New System.Drawing.Size(129, 13)
        SampleCuttingEndDateLabel.TabIndex = 31
        SampleCuttingEndDateLabel.Text = "Sample Cutting End Date:"
        '
        'SamplePrintSendDateLabel
        '
        SamplePrintSendDateLabel.AutoSize = True
        SamplePrintSendDateLabel.Location = New System.Drawing.Point(396, 71)
        SamplePrintSendDateLabel.Name = "SamplePrintSendDateLabel"
        SamplePrintSendDateLabel.Size = New System.Drawing.Size(123, 13)
        SamplePrintSendDateLabel.TabIndex = 32
        SamplePrintSendDateLabel.Text = "Sample Print Send Date:"
        '
        'SamplePrintReceiveDateLabel
        '
        SamplePrintReceiveDateLabel.AutoSize = True
        SamplePrintReceiveDateLabel.Location = New System.Drawing.Point(396, 122)
        SamplePrintReceiveDateLabel.Name = "SamplePrintReceiveDateLabel"
        SamplePrintReceiveDateLabel.Size = New System.Drawing.Size(138, 13)
        SamplePrintReceiveDateLabel.TabIndex = 33
        SamplePrintReceiveDateLabel.Text = "Sample Print Receive Date:"
        '
        'SamplePrintSendQtyLabel
        '
        SamplePrintSendQtyLabel.AutoSize = True
        SamplePrintSendQtyLabel.Location = New System.Drawing.Point(396, 96)
        SamplePrintSendQtyLabel.Name = "SamplePrintSendQtyLabel"
        SamplePrintSendQtyLabel.Size = New System.Drawing.Size(116, 13)
        SamplePrintSendQtyLabel.TabIndex = 34
        SamplePrintSendQtyLabel.Text = "Sample Print Send Qty:"
        '
        'SamplePrintReceiveQtyLabel
        '
        SamplePrintReceiveQtyLabel.AutoSize = True
        SamplePrintReceiveQtyLabel.Location = New System.Drawing.Point(396, 148)
        SamplePrintReceiveQtyLabel.Name = "SamplePrintReceiveQtyLabel"
        SamplePrintReceiveQtyLabel.Size = New System.Drawing.Size(131, 13)
        SamplePrintReceiveQtyLabel.TabIndex = 35
        SamplePrintReceiveQtyLabel.Text = "Sample Print Receive Qty:"
        '
        'SampleEmbSendDateLabel
        '
        SampleEmbSendDateLabel.AutoSize = True
        SampleEmbSendDateLabel.Location = New System.Drawing.Point(645, 17)
        SampleEmbSendDateLabel.Name = "SampleEmbSendDateLabel"
        SampleEmbSendDateLabel.Size = New System.Drawing.Size(123, 13)
        SampleEmbSendDateLabel.TabIndex = 36
        SampleEmbSendDateLabel.Text = "Sample Emb Send Date:"
        '
        'SampleEmbSendQtyLabel
        '
        SampleEmbSendQtyLabel.AutoSize = True
        SampleEmbSendQtyLabel.Location = New System.Drawing.Point(645, 43)
        SampleEmbSendQtyLabel.Name = "SampleEmbSendQtyLabel"
        SampleEmbSendQtyLabel.Size = New System.Drawing.Size(116, 13)
        SampleEmbSendQtyLabel.TabIndex = 37
        SampleEmbSendQtyLabel.Text = "Sample Emb Send Qty:"
        '
        'SampleEmbReceiveQtyLabel
        '
        SampleEmbReceiveQtyLabel.AutoSize = True
        SampleEmbReceiveQtyLabel.Location = New System.Drawing.Point(645, 97)
        SampleEmbReceiveQtyLabel.Name = "SampleEmbReceiveQtyLabel"
        SampleEmbReceiveQtyLabel.Size = New System.Drawing.Size(131, 13)
        SampleEmbReceiveQtyLabel.TabIndex = 38
        SampleEmbReceiveQtyLabel.Text = "Sample Emb Receive Qty:"
        '
        'SampleSewingStartDateLabel
        '
        SampleSewingStartDateLabel.AutoSize = True
        SampleSewingStartDateLabel.Location = New System.Drawing.Point(645, 123)
        SampleSewingStartDateLabel.Name = "SampleSewingStartDateLabel"
        SampleSewingStartDateLabel.Size = New System.Drawing.Size(134, 13)
        SampleSewingStartDateLabel.TabIndex = 39
        SampleSewingStartDateLabel.Text = "Sample Sewing Start Date:"
        '
        'SampleSewingEndDateLabel
        '
        SampleSewingEndDateLabel.AutoSize = True
        SampleSewingEndDateLabel.Location = New System.Drawing.Point(645, 149)
        SampleSewingEndDateLabel.Name = "SampleSewingEndDateLabel"
        SampleSewingEndDateLabel.Size = New System.Drawing.Size(131, 13)
        SampleSewingEndDateLabel.TabIndex = 40
        SampleSewingEndDateLabel.Text = "Sample Sewing End Date:"
        '
        'SamplePreparedByLabel
        '
        SamplePreparedByLabel.AutoSize = True
        SamplePreparedByLabel.Location = New System.Drawing.Point(914, 71)
        SamplePreparedByLabel.Name = "SamplePreparedByLabel"
        SamplePreparedByLabel.Size = New System.Drawing.Size(106, 13)
        SamplePreparedByLabel.TabIndex = 41
        SamplePreparedByLabel.Text = "Sample Prepared By:"
        '
        'SampleEmbReceiveDateLabel
        '
        SampleEmbReceiveDateLabel.AutoSize = True
        SampleEmbReceiveDateLabel.Location = New System.Drawing.Point(645, 71)
        SampleEmbReceiveDateLabel.Name = "SampleEmbReceiveDateLabel"
        SampleEmbReceiveDateLabel.Size = New System.Drawing.Size(138, 13)
        SampleEmbReceiveDateLabel.TabIndex = 43
        SampleEmbReceiveDateLabel.Text = "Sample Emb Receive Date:"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.ShowByRqButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1311, 36)
        Me.FlowLayoutPanel3.TabIndex = 1
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Sample Program No"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(127, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequestNoAndStyleNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView2
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "RequestNo"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(290, 20)
        Me.GridLookUpEdit1.TabIndex = 57
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleRequestLookupDataSet
        '
        Me.SampleRequestLookupDataSet.DataSetName = "SampleRequestLookupDataSet"
        Me.SampleRequestLookupDataSet.EnforceConstraints = False
        Me.SampleRequestLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequestNoAndStyleNo, Me.colRequestDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRequestNoAndStyleNo
        '
        Me.colRequestNoAndStyleNo.Caption = "Request No::Booking No::Style No::Buyer"
        Me.colRequestNoAndStyleNo.FieldName = "RequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Name = "colRequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Visible = True
        Me.colRequestNoAndStyleNo.VisibleIndex = 0
        '
        'colRequestDate
        '
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.Visible = True
        Me.colRequestDate.VisibleIndex = 1
        '
        'ShowByRqButton
        '
        Me.ShowByRqButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.ShowByRqButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowByRqButton.Location = New System.Drawing.Point(423, 5)
        Me.ShowByRqButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.ShowByRqButton.Name = "ShowByRqButton"
        Me.ShowByRqButton.Size = New System.Drawing.Size(95, 24)
        Me.ShowByRqButton.TabIndex = 2
        Me.ShowByRqButton.Tag = "NR"
        Me.ShowByRqButton.Text = "Show"
        Me.ShowByRqButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(SampleEmbReceiveDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleEmbReceiveDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SamplePreparedByLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SamplePreparedByTextEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleSewingEndDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleSewingEndDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveButton)
        Me.SplitContainer1.Panel2.Controls.Add(SampleSewingStartDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleSewingStartDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleEmbReceiveQtyLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleEmbReceiveQtySpinEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleEmbSendQtyLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleEmbSendQtySpinEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleEmbSendDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleEmbSendDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SamplePrintReceiveQtyLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SamplePrintReceiveQtySpinEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SamplePrintSendQtyLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SamplePrintSendQtySpinEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SamplePrintReceiveDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SamplePrintReceiveDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SamplePrintSendDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SamplePrintSendDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleCuttingEndDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleCuttingEndDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleCuttingStartDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleCuttingStartDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(AccReceiveDetailsLabel)
        Me.SplitContainer1.Panel2.Controls.Add(FileReceiveDetailsLabel)
        Me.SplitContainer1.Panel2.Controls.Add(StatusRemarksLabel)
        Me.SplitContainer1.Panel2.Controls.Add(SampleExDeliveryDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleExDeliveryDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleDeliveryQuantityLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleDeliveryQuantitySpinEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusRemarksTextEdit)
        Me.SplitContainer1.Panel2.Controls.Add(SampleStatusLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FileReceiveDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(FileReceiveDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(AccReceiveDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FabricReceiveDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AccReceiveDateDateEdit)
        Me.SplitContainer1.Panel2.Controls.Add(FabricReceiveDateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FileReceiveDetailsTextEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AccReceiveDetailsTextEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SampleStatusTextEdit)
        Me.SplitContainer1.Size = New System.Drawing.Size(1311, 650)
        Me.SplitContainer1.SplitterDistance = 442
        Me.SplitContainer1.TabIndex = 52
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1311, 442)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'SampleEmbReceiveDateDateEdit
        '
        Me.SampleEmbReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleEmbReceiveDate", True))
        Me.SampleEmbReceiveDateDateEdit.EditValue = Nothing
        Me.SampleEmbReceiveDateDateEdit.Location = New System.Drawing.Point(783, 68)
        Me.SampleEmbReceiveDateDateEdit.Name = "SampleEmbReceiveDateDateEdit"
        Me.SampleEmbReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbReceiveDateDateEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleEmbReceiveDateDateEdit.TabIndex = 44
        '
        'SampleRequestFinalBindingSource
        '
        Me.SampleRequestFinalBindingSource.DataMember = "SampleRequestFinal"
        Me.SampleRequestFinalBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SamplePreparedByTextEdit
        '
        Me.SamplePreparedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SamplePreparedBy", True))
        Me.SamplePreparedByTextEdit.Location = New System.Drawing.Point(1047, 68)
        Me.SamplePreparedByTextEdit.Name = "SamplePreparedByTextEdit"
        Me.SamplePreparedByTextEdit.Size = New System.Drawing.Size(224, 20)
        Me.SamplePreparedByTextEdit.TabIndex = 42
        '
        'SampleSewingEndDateDateEdit
        '
        Me.SampleSewingEndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleSewingEndDate", True))
        Me.SampleSewingEndDateDateEdit.EditValue = Nothing
        Me.SampleSewingEndDateDateEdit.Location = New System.Drawing.Point(783, 147)
        Me.SampleSewingEndDateDateEdit.Name = "SampleSewingEndDateDateEdit"
        Me.SampleSewingEndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleSewingEndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleSewingEndDateDateEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleSewingEndDateDateEdit.TabIndex = 41
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.EditNew
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(1153, 12)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(10, 5, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(118, 23)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "&Edit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SampleSewingStartDateDateEdit
        '
        Me.SampleSewingStartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleSewingStartDate", True))
        Me.SampleSewingStartDateDateEdit.EditValue = Nothing
        Me.SampleSewingStartDateDateEdit.Location = New System.Drawing.Point(783, 121)
        Me.SampleSewingStartDateDateEdit.Name = "SampleSewingStartDateDateEdit"
        Me.SampleSewingStartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleSewingStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleSewingStartDateDateEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleSewingStartDateDateEdit.TabIndex = 40
        '
        'SampleEmbReceiveQtySpinEdit
        '
        Me.SampleEmbReceiveQtySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleEmbReceiveQty", True))
        Me.SampleEmbReceiveQtySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SampleEmbReceiveQtySpinEdit.Location = New System.Drawing.Point(783, 95)
        Me.SampleEmbReceiveQtySpinEdit.Name = "SampleEmbReceiveQtySpinEdit"
        Me.SampleEmbReceiveQtySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbReceiveQtySpinEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleEmbReceiveQtySpinEdit.TabIndex = 39
        '
        'SampleEmbSendQtySpinEdit
        '
        Me.SampleEmbSendQtySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleEmbSendQty", True))
        Me.SampleEmbSendQtySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SampleEmbSendQtySpinEdit.Location = New System.Drawing.Point(783, 41)
        Me.SampleEmbSendQtySpinEdit.Name = "SampleEmbSendQtySpinEdit"
        Me.SampleEmbSendQtySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbSendQtySpinEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleEmbSendQtySpinEdit.TabIndex = 38
        '
        'SampleEmbSendDateDateEdit
        '
        Me.SampleEmbSendDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleEmbSendDate", True))
        Me.SampleEmbSendDateDateEdit.EditValue = Nothing
        Me.SampleEmbSendDateDateEdit.Location = New System.Drawing.Point(783, 15)
        Me.SampleEmbSendDateDateEdit.Name = "SampleEmbSendDateDateEdit"
        Me.SampleEmbSendDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbSendDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleEmbSendDateDateEdit.Size = New System.Drawing.Size(119, 20)
        Me.SampleEmbSendDateDateEdit.TabIndex = 37
        '
        'SamplePrintReceiveQtySpinEdit
        '
        Me.SamplePrintReceiveQtySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SamplePrintReceiveQty", True))
        Me.SamplePrintReceiveQtySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SamplePrintReceiveQtySpinEdit.Location = New System.Drawing.Point(533, 145)
        Me.SamplePrintReceiveQtySpinEdit.Name = "SamplePrintReceiveQtySpinEdit"
        Me.SamplePrintReceiveQtySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintReceiveQtySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.SamplePrintReceiveQtySpinEdit.TabIndex = 36
        '
        'SamplePrintSendQtySpinEdit
        '
        Me.SamplePrintSendQtySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SamplePrintSendQty", True))
        Me.SamplePrintSendQtySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SamplePrintSendQtySpinEdit.Location = New System.Drawing.Point(533, 93)
        Me.SamplePrintSendQtySpinEdit.Name = "SamplePrintSendQtySpinEdit"
        Me.SamplePrintSendQtySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintSendQtySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.SamplePrintSendQtySpinEdit.TabIndex = 35
        '
        'SamplePrintReceiveDateDateEdit
        '
        Me.SamplePrintReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "samplePrintReceiveDate", True))
        Me.SamplePrintReceiveDateDateEdit.EditValue = Nothing
        Me.SamplePrintReceiveDateDateEdit.Location = New System.Drawing.Point(533, 119)
        Me.SamplePrintReceiveDateDateEdit.Name = "SamplePrintReceiveDateDateEdit"
        Me.SamplePrintReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintReceiveDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.SamplePrintReceiveDateDateEdit.TabIndex = 34
        '
        'SamplePrintSendDateDateEdit
        '
        Me.SamplePrintSendDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SamplePrintSendDate", True))
        Me.SamplePrintSendDateDateEdit.EditValue = Nothing
        Me.SamplePrintSendDateDateEdit.Location = New System.Drawing.Point(533, 68)
        Me.SamplePrintSendDateDateEdit.Name = "SamplePrintSendDateDateEdit"
        Me.SamplePrintSendDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintSendDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SamplePrintSendDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.SamplePrintSendDateDateEdit.TabIndex = 33
        '
        'SampleCuttingEndDateDateEdit
        '
        Me.SampleCuttingEndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleCuttingEndDate", True))
        Me.SampleCuttingEndDateDateEdit.EditValue = Nothing
        Me.SampleCuttingEndDateDateEdit.Location = New System.Drawing.Point(533, 42)
        Me.SampleCuttingEndDateDateEdit.Name = "SampleCuttingEndDateDateEdit"
        Me.SampleCuttingEndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleCuttingEndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleCuttingEndDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.SampleCuttingEndDateDateEdit.TabIndex = 32
        '
        'SampleCuttingStartDateDateEdit
        '
        Me.SampleCuttingStartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleCuttingStartDate", True))
        Me.SampleCuttingStartDateDateEdit.EditValue = Nothing
        Me.SampleCuttingStartDateDateEdit.Location = New System.Drawing.Point(533, 15)
        Me.SampleCuttingStartDateDateEdit.Name = "SampleCuttingStartDateDateEdit"
        Me.SampleCuttingStartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleCuttingStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleCuttingStartDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.SampleCuttingStartDateDateEdit.TabIndex = 31
        '
        'DelDateEdit
        '
        Me.DelDateEdit.EditValue = Nothing
        Me.DelDateEdit.Location = New System.Drawing.Point(1153, 42)
        Me.DelDateEdit.Name = "DelDateEdit"
        Me.DelDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DelDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DelDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DelDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DelDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.DelDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DelDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.DelDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DelDateEdit.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.DelDateEdit.Properties.ReadOnly = True
        Me.DelDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.DelDateEdit.TabIndex = 26
        '
        'SampleExDeliveryDateDateEdit
        '
        Me.SampleExDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleExDeliveryDate", True))
        Me.SampleExDeliveryDateDateEdit.EditValue = Nothing
        Me.SampleExDeliveryDateDateEdit.Location = New System.Drawing.Point(1047, 14)
        Me.SampleExDeliveryDateDateEdit.Name = "SampleExDeliveryDateDateEdit"
        Me.SampleExDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleExDeliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleExDeliveryDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.SampleExDeliveryDateDateEdit.TabIndex = 26
        '
        'SampleDeliveryQuantitySpinEdit
        '
        Me.SampleDeliveryQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SampleDeliveryQuantitySpinEdit.Location = New System.Drawing.Point(1047, 42)
        Me.SampleDeliveryQuantitySpinEdit.Name = "SampleDeliveryQuantitySpinEdit"
        Me.SampleDeliveryQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SampleDeliveryQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SampleDeliveryQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleDeliveryQuantitySpinEdit.Properties.ReadOnly = True
        Me.SampleDeliveryQuantitySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.SampleDeliveryQuantitySpinEdit.TabIndex = 24
        '
        'StatusRemarksTextEdit
        '
        Me.StatusRemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "StatusRemarks", True))
        Me.StatusRemarksTextEdit.Location = New System.Drawing.Point(1047, 139)
        Me.StatusRemarksTextEdit.Name = "StatusRemarksTextEdit"
        Me.StatusRemarksTextEdit.Size = New System.Drawing.Size(224, 48)
        Me.StatusRemarksTextEdit.TabIndex = 28
        '
        'FileReceiveDateDateEdit
        '
        Me.FileReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "FileReceiveDate", True))
        Me.FileReceiveDateDateEdit.EditValue = Nothing
        Me.FileReceiveDateDateEdit.Location = New System.Drawing.Point(139, 15)
        Me.FileReceiveDateDateEdit.Name = "FileReceiveDateDateEdit"
        Me.FileReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FileReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FileReceiveDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FileReceiveDateDateEdit.TabIndex = 16
        '
        'FabricReceiveDateDateEdit
        '
        Me.FabricReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "FabricReceiveDate", True))
        Me.FabricReceiveDateDateEdit.EditValue = Nothing
        Me.FabricReceiveDateDateEdit.Location = New System.Drawing.Point(139, 167)
        Me.FabricReceiveDateDateEdit.Name = "FabricReceiveDateDateEdit"
        Me.FabricReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricReceiveDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FabricReceiveDateDateEdit.TabIndex = 18
        '
        'AccReceiveDateDateEdit
        '
        Me.AccReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "AccReceiveDate", True))
        Me.AccReceiveDateDateEdit.EditValue = Nothing
        Me.AccReceiveDateDateEdit.Location = New System.Drawing.Point(139, 93)
        Me.AccReceiveDateDateEdit.Name = "AccReceiveDateDateEdit"
        Me.AccReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccReceiveDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.AccReceiveDateDateEdit.TabIndex = 20
        '
        'FileReceiveDetailsTextEdit
        '
        Me.FileReceiveDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "FileReceiveDetails", True))
        Me.FileReceiveDetailsTextEdit.Location = New System.Drawing.Point(139, 41)
        Me.FileReceiveDetailsTextEdit.Name = "FileReceiveDetailsTextEdit"
        Me.FileReceiveDetailsTextEdit.Size = New System.Drawing.Size(251, 48)
        Me.FileReceiveDetailsTextEdit.TabIndex = 29
        '
        'AccReceiveDetailsTextEdit
        '
        Me.AccReceiveDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "AccReceiveDetails", True))
        Me.AccReceiveDetailsTextEdit.Location = New System.Drawing.Point(139, 119)
        Me.AccReceiveDetailsTextEdit.Name = "AccReceiveDetailsTextEdit"
        Me.AccReceiveDetailsTextEdit.Size = New System.Drawing.Size(251, 42)
        Me.AccReceiveDetailsTextEdit.TabIndex = 30
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestFinalTableAdapter
        '
        Me.SampleRequestFinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricTableAdapter = Nothing
        Me.TableAdapterManager.SamplePrintColorTableAdapter = Nothing
        Me.TableAdapterManager.SampleRequestFinalDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SampleRequestFinalTableAdapter = Me.SampleRequestFinalTableAdapter
        Me.TableAdapterManager.SampleRequireQuantityTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationSampleTableAdapter = Nothing
        '
        'SampleStatusTextEdit
        '
        Me.SampleStatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleStatus", True))
        Me.SampleStatusTextEdit.Location = New System.Drawing.Point(1047, 93)
        Me.SampleStatusTextEdit.Name = "SampleStatusTextEdit"
        Me.SampleStatusTextEdit.Size = New System.Drawing.Size(224, 43)
        Me.SampleStatusTextEdit.TabIndex = 22
        '
        'frmSampleStatusUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 686)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Name = "frmSampleStatusUpdate"
        Me.Text = "Sample Status Update"
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SampleEmbReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleEmbReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePreparedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSewingEndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSewingEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSewingStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSewingStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleEmbReceiveQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleEmbSendQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleEmbSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleEmbSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintReceiveQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintSendQtySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleCuttingEndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleCuttingEndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleCuttingStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleCuttingStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleExDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleExDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleDeliveryQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusRemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileReceiveDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccReceiveDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SampleRequestFinalBindingSource As BindingSource
    Friend WithEvents SampleRequestDataSet As SampleRequestDataSet
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents SaveButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SampleExDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleDeliveryQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents StatusRemarksTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents FileReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FabricReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AccReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SampleRequestFinalTableAdapter As SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleRequestLookupDataSet As SampleRequestLookupDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents ShowByRqButton As Button
    Friend WithEvents colRequestNoAndStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SamplePreparedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleSewingEndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleSewingStartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleEmbReceiveQtySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SampleEmbSendQtySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SampleEmbSendDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SamplePrintReceiveQtySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SamplePrintSendQtySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SamplePrintReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SamplePrintSendDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleCuttingEndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleCuttingStartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TableAdapterManager As SampleRequestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileReceiveDetailsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AccReceiveDetailsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SampleEmbReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DelDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SampleStatusTextEdit As DevExpress.XtraEditors.MemoEdit
End Class
