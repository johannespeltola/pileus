<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_view
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
        Me.ChromeThemeContainer1 = New Cyber_VPN.ChromeThemeContainer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ChromeThemeContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChromeThemeContainer1
        '
        Me.ChromeThemeContainer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChromeThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChromeThemeContainer1.Controls.Add(Me.PictureBox2)
        Me.ChromeThemeContainer1.Controls.Add(Me.RichTextBox1)
        Me.ChromeThemeContainer1.Customization = "AAAA/1paWv9ycnL/"
        Me.ChromeThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromeThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeThemeContainer1.Image = Nothing
        Me.ChromeThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ChromeThemeContainer1.Movable = True
        Me.ChromeThemeContainer1.Name = "ChromeThemeContainer1"
        Me.ChromeThemeContainer1.NoRounding = False
        Me.ChromeThemeContainer1.Sizable = False
        Me.ChromeThemeContainer1.Size = New System.Drawing.Size(588, 415)
        Me.ChromeThemeContainer1.SmartBounds = True
        Me.ChromeThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ChromeThemeContainer1.TabIndex = 0
        Me.ChromeThemeContainer1.Text = "    Log Viewer"
        Me.ChromeThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cyber_VPN.My.Resources.Resources.cyber_mini
        Me.PictureBox2.Location = New System.Drawing.Point(2, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 29)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(588, 383)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'log_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 415)
        Me.Controls.Add(Me.ChromeThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "log_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "log_view"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChromeThemeContainer1 As Cyber_VPN.ChromeThemeContainer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
