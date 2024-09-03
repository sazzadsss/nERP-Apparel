<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingTableQCReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.Label4 = New System.Windows.Forms.Label
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.ShowButton = New System.Windows.Forms.Button
        Me.MonthlyButton = New System.Windows.Forms.Button
        Me.LineButton = New System.Windows.Forms.Button
        Me.LineComboBox = New System.Windows.Forms.ComboBox
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 79)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(976, 377)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(165, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(291, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Production Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(165, 42)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(94, 21)
        Me.BranchComboBox.TabIndex = 6
        Me.BranchComboBox.ValueMember = "BranchId"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Branch :"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(291, 42)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(98, 23)
        Me.ShowButton.TabIndex = 8
        Me.ShowButton.Text = "&Daily"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'MonthlyButton
        '
        Me.MonthlyButton.Location = New System.Drawing.Point(395, 42)
        Me.MonthlyButton.Name = "MonthlyButton"
        Me.MonthlyButton.Size = New System.Drawing.Size(118, 23)
        Me.MonthlyButton.TabIndex = 10
        Me.MonthlyButton.Text = "&Monthly [ Linewise ]"
        Me.MonthlyButton.UseVisualStyleBackColor = True
        '
        'LineButton
        '
        Me.LineButton.Location = New System.Drawing.Point(631, 42)
        Me.LineButton.Name = "LineButton"
        Me.LineButton.Size = New System.Drawing.Size(75, 23)
        Me.LineButton.TabIndex = 11
        Me.LineButton.Text = "&Line"
        Me.LineButton.UseVisualStyleBackColor = True
        '
        'LineComboBox
        '
        Me.LineComboBox.DataSource = Me.LineBindingSource
        Me.LineComboBox.DisplayMember = "Line"
        Me.LineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LineComboBox.FormattingEnabled = True
        Me.LineComboBox.Location = New System.Drawing.Point(528, 42)
        Me.LineComboBox.Name = "LineComboBox"
        Me.LineComboBox.Size = New System.Drawing.Size(97, 21)
        Me.LineComboBox.TabIndex = 12
        Me.LineComboBox.ValueMember = "LineId"
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'frmSewingTableQCReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 456)
        Me.Controls.Add(Me.LineComboBox)
        Me.Controls.Add(Me.LineButton)
        Me.Controls.Add(Me.MonthlyButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmSewingTableQCReport"
        Me.Text = "Sewing Table QC Report"
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents MonthlyButton As System.Windows.Forms.Button
    Friend WithEvents LineButton As System.Windows.Forms.Button
    Friend WithEvents LineComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
End Class
