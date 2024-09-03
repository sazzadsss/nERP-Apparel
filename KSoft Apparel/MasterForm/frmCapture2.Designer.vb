<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapture2
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
        Me.btnInfo = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.lstDevices = New System.Windows.Forms.ListBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog
        Me.picCapture = New System.Windows.Forms.PictureBox
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(564, 266)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(55, 23)
        Me.btnInfo.TabIndex = 0
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(503, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(382, 266)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(64, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lstDevices
        '
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.Location = New System.Drawing.Point(382, 23)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(237, 225)
        Me.lstDevices.TabIndex = 4
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(452, 266)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(45, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picCapture
        '
        Me.picCapture.Location = New System.Drawing.Point(22, 12)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(329, 277)
        Me.picCapture.TabIndex = 3
        Me.picCapture.TabStop = False
        '
        'frmCapture2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 301)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.picCapture)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInfo)
        Me.Name = "frmCapture2"
        Me.Text = "frmCapture2"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents picCapture As System.Windows.Forms.PictureBox
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
End Class
