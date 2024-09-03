<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTime
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
        Me.LoadDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.UnloadDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.LoadDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnloadDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnloadDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadDateEdit
        '
        Me.LoadDateEdit.EditValue = Nothing
        Me.LoadDateEdit.Location = New System.Drawing.Point(105, 22)
        Me.LoadDateEdit.Name = "LoadDateEdit"
        Me.LoadDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LoadDateEdit.Properties.DisplayFormat.FormatString = "g"
        Me.LoadDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LoadDateEdit.Properties.EditFormat.FormatString = "g"
        Me.LoadDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LoadDateEdit.Properties.Mask.EditMask = "g"
        Me.LoadDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LoadDateEdit.Size = New System.Drawing.Size(161, 20)
        Me.LoadDateEdit.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Load Time"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Un Load Time"
        '
        'UnloadDateEdit
        '
        Me.UnloadDateEdit.EditValue = Nothing
        Me.UnloadDateEdit.Location = New System.Drawing.Point(105, 48)
        Me.UnloadDateEdit.Name = "UnloadDateEdit"
        Me.UnloadDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnloadDateEdit.Properties.DisplayFormat.FormatString = "g"
        Me.UnloadDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.UnloadDateEdit.Properties.EditFormat.FormatString = "g"
        Me.UnloadDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.UnloadDateEdit.Properties.Mask.EditMask = "g"
        Me.UnloadDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.UnloadDateEdit.Size = New System.Drawing.Size(161, 20)
        Me.UnloadDateEdit.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(299, 126)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnloadDateEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LoadDateEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDateTime"
        Me.Text = "Load And Unload Time"
        CType(Me.LoadDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnloadDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnloadDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UnloadDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
