<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesBookingPrint
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.BOMShowButton = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ProgramSearchGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMerchandiser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AccBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMLookUpDataSet = New KSoft_Apparel.AccBOMLookUpDataSet
        Me.AccBookingLookupTableAdapter = New KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
        Me.ToProgramDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.FromProgramDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ShowButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Program No :"
        '
        'BOMShowButton
        '
        Me.BOMShowButton.Location = New System.Drawing.Point(317, 7)
        Me.BOMShowButton.Name = "BOMShowButton"
        Me.BOMShowButton.Size = New System.Drawing.Size(87, 23)
        Me.BOMShowButton.TabIndex = 21
        Me.BOMShowButton.Text = "&Show BOM"
        Me.BOMShowButton.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 38)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1111, 588)
        Me.CrystalReportViewer1.TabIndex = 22
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ProgramSearchGridLookUpEdit
        '
        Me.ProgramSearchGridLookUpEdit.EditValue = ""
        Me.ProgramSearchGridLookUpEdit.Location = New System.Drawing.Point(89, 8)
        Me.ProgramSearchGridLookUpEdit.Name = "ProgramSearchGridLookUpEdit"
        Me.ProgramSearchGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ProgramSearchGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramSearchGridLookUpEdit.Properties.DataSource = Me.AccBookingLookupBindingSource
        Me.ProgramSearchGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramSearchGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramSearchGridLookUpEdit.Properties.NullText = ""
        Me.ProgramSearchGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramSearchGridLookUpEdit.Properties.PopupFormSize = New System.Drawing.Size(250, 0)
        Me.ProgramSearchGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramSearchGridLookUpEdit.Properties.ValueMember = "AccessoriesBookingId"
        Me.ProgramSearchGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramSearchGridLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.ProgramSearchGridLookUpEdit.TabIndex = 23
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMerchandiser, Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colMerchandiser
        '
        Me.colMerchandiser.FieldName = "Merchandiser"
        Me.colMerchandiser.Name = "colMerchandiser"
        Me.colMerchandiser.Visible = True
        Me.colMerchandiser.VisibleIndex = 1
        Me.colMerchandiser.Width = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "&Show BOM AND AWS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        Me.colDetails.Width = 890
        '
        'AccBookingLookupBindingSource
        '
        Me.AccBookingLookupBindingSource.DataMember = "AccBookingLookup"
        Me.AccBookingLookupBindingSource.DataSource = Me.AccBOMLookUpDataSet
        '
        'AccBOMLookUpDataSet
        '
        Me.AccBOMLookUpDataSet.DataSetName = "AccBOMLookUpDataSet"
        Me.AccBOMLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccBookingLookupTableAdapter
        '
        Me.AccBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'ToProgramDateTimePicker
        '
        Me.ToProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToProgramDateTimePicker.Location = New System.Drawing.Point(803, 9)
        Me.ToProgramDateTimePicker.Name = "ToProgramDateTimePicker"
        Me.ToProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.ToProgramDateTimePicker.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(771, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "To :"
        '
        'FromProgramDateTimePicker
        '
        Me.FromProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromProgramDateTimePicker.Location = New System.Drawing.Point(677, 9)
        Me.FromProgramDateTimePicker.Name = "FromProgramDateTimePicker"
        Me.FromProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.FromProgramDateTimePicker.TabIndex = 63
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(897, 7)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(81, 23)
        Me.ShowButton.TabIndex = 62
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(578, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Date Range From:"
        '
        'AccessoriesBookingPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 626)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToProgramDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromProgramDateTimePicker)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgramSearchGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.BOMShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccessoriesBookingPrint"
        Me.Text = "Accessories Booking Print"
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BOMShowButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ProgramSearchGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccBOMLookUpDataSet As KSoft_Apparel.AccBOMLookUpDataSet
    Friend WithEvents AccBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBookingLookupTableAdapter As KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
    Friend WithEvents colMerchandiser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FromProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
