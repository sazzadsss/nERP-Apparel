<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderColorUpdate
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.PreviousColorComboBox = New System.Windows.Forms.ComboBox
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.ShowButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.PresentColorComboBox = New System.Windows.Forms.ComboBox
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Previous Color"
        '
        'PreviousColorComboBox
        '
        Me.PreviousColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.PreviousColorComboBox.DisplayMember = "FabricColorName"
        Me.PreviousColorComboBox.FormattingEnabled = True
        Me.PreviousColorComboBox.Location = New System.Drawing.Point(113, 88)
        Me.PreviousColorComboBox.Name = "PreviousColorComboBox"
        Me.PreviousColorComboBox.Size = New System.Drawing.Size(189, 21)
        Me.PreviousColorComboBox.TabIndex = 0
        Me.PreviousColorComboBox.ValueMember = "FabricColorId"
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(308, 114)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(33, 23)
        Me.ShowButton.TabIndex = 2
        Me.ShowButton.Text = "//"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Present Color"
        '
        'PresentColorComboBox
        '
        Me.PresentColorComboBox.DataSource = Me.FabricColorBindingSource
        Me.PresentColorComboBox.DisplayMember = "FabricColorName"
        Me.PresentColorComboBox.FormattingEnabled = True
        Me.PresentColorComboBox.Location = New System.Drawing.Point(113, 115)
        Me.PresentColorComboBox.Name = "PresentColorComboBox"
        Me.PresentColorComboBox.Size = New System.Drawing.Size(189, 21)
        Me.PresentColorComboBox.TabIndex = 0
        Me.PresentColorComboBox.ValueMember = "FabricColorId"
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(233, 155)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(108, 25)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(113, 62)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(189, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 3
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(366, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This will allow you to update change order color while the mentioned color alread" & _
            "y use in another area."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Program No"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
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
        'frmOrderColorUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 192)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PresentColorComboBox)
        Me.Controls.Add(Me.PreviousColorComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "frmOrderColorUpdate"
        Me.Text = "Order Color Update"
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PreviousColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PresentColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
End Class
