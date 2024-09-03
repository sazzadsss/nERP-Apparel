<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAComments
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.RemarksTextBox = New System.Windows.Forms.TextBox
        Me.SewingAttendanceCommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingAttendanceDataSet = New KSoft_Apparel.SewingAttendanceDataSet
        Me.SewingAttendanceCommentsTableAdapter = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceCommentsTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager
        CType(Me.SewingAttendanceCommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(304, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Save and Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewingAttendanceCommentsBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(12, 12)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(423, 82)
        Me.RemarksTextBox.TabIndex = 4
        '
        'SewingAttendanceCommentsBindingSource
        '
        Me.SewingAttendanceCommentsBindingSource.DataMember = "SewingAttendanceComments"
        Me.SewingAttendanceCommentsBindingSource.DataSource = Me.SewingAttendanceDataSet
        '
        'SewingAttendanceDataSet
        '
        Me.SewingAttendanceDataSet.DataSetName = "SewingAttendanceDataSet"
        Me.SewingAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingAttendanceCommentsTableAdapter
        '
        Me.SewingAttendanceCommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingAttendanceCommentsTableAdapter = Me.SewingAttendanceCommentsTableAdapter
        Me.TableAdapterManager.SewingAttendanceTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineUsageTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmSAComments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 139)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSAComments"
        Me.Text = "SA Comments"
        CType(Me.SewingAttendanceCommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SewingAttendanceDataSet As KSoft_Apparel.SewingAttendanceDataSet
    Friend WithEvents SewingAttendanceCommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingAttendanceCommentsTableAdapter As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceCommentsTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
End Class
