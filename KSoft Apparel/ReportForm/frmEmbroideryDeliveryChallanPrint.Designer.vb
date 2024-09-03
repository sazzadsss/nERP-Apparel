<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmbroideryDeliveryChallanPrint
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
        Dim OrderIdLabel As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmbDeliveryChallanLookupDataSet = New KSoft_Apparel.EmbDeliveryChallanLookupDataSet()
        Me.EmbDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbDeliveryChallanLookupTableAdapter = New KSoft_Apparel.EmbDeliveryChallanLookupDataSetTableAdapters.EmbDeliveryChallanLookupTableAdapter()
        Me.ChallanLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbOrderLookupTableAdapter = New KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter()
        Me.EmbOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderLookupDataSet = New KSoft_Apparel.EmbOrderLookupDataSet()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        OrderIdLabel = New System.Windows.Forms.Label()
        CType(Me.EmbDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(570, 34)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(148, 13)
        OrderIdLabel.TabIndex = 97
        OrderIdLabel.Text = "Work Order::Program :: Style :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 57)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1229, 419)
        Me.CrystalReportViewer1.TabIndex = 70
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(842, 5)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 94
        Me.ToDateTimePicker.TabStop = False
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(719, 5)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.FromDateTimePicker.TabIndex = 93
        Me.FromDateTimePicker.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(947, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 22)
        Me.Button2.TabIndex = 91
        Me.Button2.Text = "&Show By Work Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(947, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(57, 21)
        Me.SimpleButton1.TabIndex = 90
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "Show"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(813, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Challan List Date From :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 42)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "&Print Inside"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(487, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(81, 42)
        Me.PrintButton.TabIndex = 85
        Me.PrintButton.Text = "&Print Outside"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(315, 5)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 41)
        Me.ShowButton.TabIndex = 86
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-4, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 27)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Embroidery Challan No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmbDeliveryChallanLookupDataSet
        '
        Me.EmbDeliveryChallanLookupDataSet.DataSetName = "EmbDeliveryChallanLookupDataSet"
        Me.EmbDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmbDeliveryChallanLookupBindingSource
        '
        Me.EmbDeliveryChallanLookupBindingSource.DataMember = "EmbDeliveryChallanLookup"
        Me.EmbDeliveryChallanLookupBindingSource.DataSource = Me.EmbDeliveryChallanLookupDataSet
        '
        'EmbDeliveryChallanLookupTableAdapter
        '
        Me.EmbDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'ChallanLookupGridLookUpEdit
        '
        Me.ChallanLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ChallanLookupGridLookUpEdit.Location = New System.Drawing.Point(147, 16)
        Me.ChallanLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ChallanLookupGridLookUpEdit.Name = "ChallanLookupGridLookUpEdit"
        Me.ChallanLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanLookupGridLookUpEdit.Properties.DataSource = Me.EmbDeliveryChallanLookupBindingSource
        Me.ChallanLookupGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ChallanLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanLookupGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.ChallanLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.ChallanLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanLookupGridLookUpEdit.Properties.ValueMember = "EmbDeliveryId"
        Me.ChallanLookupGridLookUpEdit.Size = New System.Drawing.Size(162, 20)
        Me.ChallanLookupGridLookUpEdit.TabIndex = 96
        Me.ChallanLookupGridLookUpEdit.Tag = "NR"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
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
        'EmbOrderLookupTableAdapter
        '
        Me.EmbOrderLookupTableAdapter.ClearBeforeFill = True
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
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(719, 31)
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
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(221, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 98
        '
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colProgramNo})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
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
        Me.Button3.Location = New System.Drawing.Point(1079, 29)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 22)
        Me.Button3.TabIndex = 91
        Me.Button3.Text = "&Show By Program No "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmEmbroideryDeliveryChallanPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 476)
        Me.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.Controls.Add(OrderIdLabel)
        Me.Controls.Add(Me.ChallanLookupGridLookUpEdit)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmEmbroideryDeliveryChallanPrint"
        Me.Text = "Embroidery Delivery Challan Print"
        CType(Me.EmbDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents EmbDeliveryChallanLookupDataSet As EmbDeliveryChallanLookupDataSet
    Friend WithEvents EmbDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents EmbDeliveryChallanLookupTableAdapter As EmbDeliveryChallanLookupDataSetTableAdapters.EmbDeliveryChallanLookupTableAdapter
    Friend WithEvents ChallanLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbOrderLookupTableAdapter As EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter
    Friend WithEvents EmbOrderLookupBindingSource As BindingSource
    Friend WithEvents EmbOrderLookupDataSet As EmbOrderLookupDataSet
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
