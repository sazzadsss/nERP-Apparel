<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingPlanningBalanceReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.FabricMaterialTypeDataSet = New KSoft_Apparel.FabricMaterialTypeDataSet()
        Me.FabricMaterialTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricMaterialTypeTableAdapter = New KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter()
        Me.SusStandardDataSet = New KSoft_Apparel.SusStandardDataSet()
        Me.SusStandardMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SusStandardMstTableAdapter = New KSoft_Apparel.SusStandardDataSetTableAdapters.SusStandardMstTableAdapter()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 49)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(801, 355)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricMaterialTypeDataSet
        '
        Me.FabricMaterialTypeDataSet.DataSetName = "FabricMaterialTypeDataSet"
        Me.FabricMaterialTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricMaterialTypeBindingSource
        '
        Me.FabricMaterialTypeBindingSource.DataMember = "FabricMaterialType"
        Me.FabricMaterialTypeBindingSource.DataSource = Me.FabricMaterialTypeDataSet
        '
        'FabricMaterialTypeTableAdapter
        '
        Me.FabricMaterialTypeTableAdapter.ClearBeforeFill = True
        '
        'SusStandardDataSet
        '
        Me.SusStandardDataSet.DataSetName = "SusStandardDataSet"
        Me.SusStandardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SusStandardMstBindingSource
        '
        Me.SusStandardMstBindingSource.DataMember = "SusStandardMst"
        Me.SusStandardMstBindingSource.DataSource = Me.SusStandardDataSet
        '
        'SusStandardMstTableAdapter
        '
        Me.SusStandardMstTableAdapter.ClearBeforeFill = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(14, 0)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyerCheckBox.TabIndex = 31
        Me.BuyerCheckBox.Text = "Buyer :"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.Enabled = False
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(12, 22)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(129, 21)
        Me.BuyerComboBox.TabIndex = 30
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 35)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Show All Running"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSewingPlanningBalanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 403)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmSewingPlanningBalanceReport"
        Me.Text = "Sewing Planning Balance Report"
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents FabricMaterialTypeDataSet As FabricMaterialTypeDataSet
    Friend WithEvents FabricMaterialTypeBindingSource As BindingSource
    Friend WithEvents FabricMaterialTypeTableAdapter As FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter
    Friend WithEvents SusStandardDataSet As SusStandardDataSet
    Friend WithEvents SusStandardMstBindingSource As BindingSource
    Friend WithEvents SusStandardMstTableAdapter As SusStandardDataSetTableAdapters.SusStandardMstTableAdapter
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents Button1 As Button
End Class
