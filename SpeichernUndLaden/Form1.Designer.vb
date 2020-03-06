<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnLogging = New System.Windows.Forms.Button()
        Me.TbxInput = New System.Windows.Forms.TextBox()
        Me.BtnSaveText = New System.Windows.Forms.Button()
        Me.LbxLogging = New System.Windows.Forms.ListBox()
        Me.BtnLoadLogs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLogging
        '
        Me.BtnLogging.Location = New System.Drawing.Point(12, 12)
        Me.BtnLogging.Name = "BtnLogging"
        Me.BtnLogging.Size = New System.Drawing.Size(380, 23)
        Me.BtnLogging.TabIndex = 0
        Me.BtnLogging.Text = "Logge diesen ButtonKlick"
        Me.BtnLogging.UseVisualStyleBackColor = True
        '
        'TbxInput
        '
        Me.TbxInput.Location = New System.Drawing.Point(12, 41)
        Me.TbxInput.Name = "TbxInput"
        Me.TbxInput.Size = New System.Drawing.Size(380, 20)
        Me.TbxInput.TabIndex = 1
        '
        'BtnSaveText
        '
        Me.BtnSaveText.Location = New System.Drawing.Point(12, 67)
        Me.BtnSaveText.Name = "BtnSaveText"
        Me.BtnSaveText.Size = New System.Drawing.Size(380, 23)
        Me.BtnSaveText.TabIndex = 2
        Me.BtnSaveText.Text = "Speichere Textbox-Inhalt"
        Me.BtnSaveText.UseVisualStyleBackColor = True
        '
        'LbxLogging
        '
        Me.LbxLogging.FormattingEnabled = True
        Me.LbxLogging.Location = New System.Drawing.Point(12, 96)
        Me.LbxLogging.Name = "LbxLogging"
        Me.LbxLogging.Size = New System.Drawing.Size(380, 147)
        Me.LbxLogging.TabIndex = 3
        '
        'BtnLoadLogs
        '
        Me.BtnLoadLogs.Location = New System.Drawing.Point(12, 249)
        Me.BtnLoadLogs.Name = "BtnLoadLogs"
        Me.BtnLoadLogs.Size = New System.Drawing.Size(380, 23)
        Me.BtnLoadLogs.TabIndex = 4
        Me.BtnLoadLogs.Text = "Lade Log-Daten"
        Me.BtnLoadLogs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 490)
        Me.Controls.Add(Me.BtnLoadLogs)
        Me.Controls.Add(Me.LbxLogging)
        Me.Controls.Add(Me.BtnSaveText)
        Me.Controls.Add(Me.TbxInput)
        Me.Controls.Add(Me.BtnLogging)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogging As Button
    Friend WithEvents TbxInput As TextBox
    Friend WithEvents BtnSaveText As Button
    Friend WithEvents LbxLogging As ListBox
    Friend WithEvents BtnLoadLogs As Button
End Class
