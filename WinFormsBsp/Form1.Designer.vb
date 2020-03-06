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
        Me.BtnKlickMich = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnActivate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnKlickMich
        '
        Me.BtnKlickMich.Location = New System.Drawing.Point(105, 77)
        Me.BtnKlickMich.Name = "BtnKlickMich"
        Me.BtnKlickMich.Size = New System.Drawing.Size(177, 74)
        Me.BtnKlickMich.TabIndex = 0
        Me.BtnKlickMich.Text = "Klick Mich"
        Me.BtnKlickMich.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'BtnActivate
        '
        Me.BtnActivate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnActivate.Location = New System.Drawing.Point(416, 66)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(176, 60)
        Me.BtnActivate.TabIndex = 2
        Me.BtnActivate.Text = "Aktivieren/Deaktivieren"
        Me.BtnActivate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Frage DB ab"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(316, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DB-Abfrage aktiv"
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnActivate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnKlickMich)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKlickMich As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnActivate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
