<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingDeliveryChallanPrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SewingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.SewingDeliveryChallanLookupDataSet = New KSoft_Apparel.SewingDeliveryChallanLookupDataSet()
        Me.SewingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter()
        Me.ChallanLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 63)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1074, 480)
        Me.CrystalReportViewer1.TabIndex = 69
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Challan No :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 42)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "&Print Inside"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(340, 8)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 42)
        Me.ShowButton.TabIndex = 71
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1001, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(57, 21)
        Me.SimpleButton1.TabIndex = 77
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "Show"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(896, 9)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 76
        Me.ToDateTimePicker.TabStop = False
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(762, 9)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.FromDateTimePicker.TabIndex = 74
        Me.FromDateTimePicker.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(864, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(640, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Challan List Date From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(640, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Program No:"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(762, 37)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.NullText = ""
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 80
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colIsPrint})
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
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1001, 36)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 22)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SewingDeliveryChallanLookupBindingSource
        '
        Me.SewingDeliveryChallanLookupBindingSource.DataMember = "SewingDeliveryChallanLookup"
        Me.SewingDeliveryChallanLookupBindingSource.DataSource = Me.SewingDeliveryChallanLookupDataSet
        '
        'SewingDeliveryChallanLookupDataSet
        '
        Me.SewingDeliveryChallanLookupDataSet.DataSetName = "SewingDeliveryChallanLookupDataSet"
        Me.SewingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingDeliveryChallanLookupTableAdapter
        '
        Me.SewingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'ChallanLookupGridLookUpEdit
        '
        Me.ChallanLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ChallanLookupGridLookUpEdit.Location = New System.Drawing.Point(83, 16)
        Me.ChallanLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ChallanLookupGridLookUpEdit.Name = "ChallanLookupGridLookUpEdit"
        Me.ChallanLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanLookupGridLookUpEdit.Properties.DataSource = Me.SewingDeliveryChallanLookupBindingSource
        Me.ChallanLookupGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ChallanLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.ChallanLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanLookupGridLookUpEdit.Properties.ValueMember = "SewingDeliveryId"
        Me.ChallanLookupGridLookUpEdit.Properties.View = Me.GridView4
        Me.ChallanLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.ChallanLookupGridLookUpEdit.TabIndex = 81
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(518, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 42)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "&Print Outside"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmSewingDeliveryChallanPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 544)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ChallanLookupGridLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmSewingDeliveryChallanPrint"
        Me.Text = "Sewing Output Delivery Challan"
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ShowButton As Button
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents SewingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents SewingDeliveryChallanLookupDataSet As SewingDeliveryChallanLookupDataSet
    Friend WithEvents SewingDeliveryChallanLookupTableAdapter As SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter
    Friend WithEvents ChallanLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
End Class
