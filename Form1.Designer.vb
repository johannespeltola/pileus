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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerLog = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChromeThemeContainer1 = New Cyber_VPN.ChromeThemeContainer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelBox1 = New Cyber_VPN.PanelBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Logs = New System.Windows.Forms.TextBox()
        Me.ChromeSeparator2 = New Cyber_VPN.ChromeSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChromeSeparator1 = New Cyber_VPN.ChromeSeparator()
        Me.ButtonBlue2 = New Cyber_VPN.ButtonBlue()
        Me.ChromeRadioButton1 = New Cyber_VPN.ChromeRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupDropBox1 = New Cyber_VPN.GroupDropBox()
        Me.ButtonBlue1 = New Cyber_VPN.ButtonBlue()
        Me.GroupPanelBox1 = New Cyber_VPN.GroupPanelBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChromeButton1 = New Cyber_VPN.ChromeButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ChromeThemeContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Pileus VPN Beta"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.ShowToolStripMenuItem, Me.HideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 92)
        Me.ContextMenuStrip1.Text = "Pileus VPN Beta"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TimerLog
        '
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(0, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "@Rainbow"
        Me.Label8.Visible = False
        '
        'ChromeThemeContainer1
        '
        Me.ChromeThemeContainer1.BackColor = System.Drawing.Color.White
        Me.ChromeThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChromeThemeContainer1.Controls.Add(Me.PictureBox2)
        Me.ChromeThemeContainer1.Controls.Add(Me.PanelBox1)
        Me.ChromeThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ChromeThemeContainer1.Customization = "AAAA/1paWv9ycnL/"
        Me.ChromeThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromeThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeThemeContainer1.Image = Nothing
        Me.ChromeThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ChromeThemeContainer1.Movable = True
        Me.ChromeThemeContainer1.Name = "ChromeThemeContainer1"
        Me.ChromeThemeContainer1.NoRounding = False
        Me.ChromeThemeContainer1.Sizable = False
        Me.ChromeThemeContainer1.Size = New System.Drawing.Size(365, 441)
        Me.ChromeThemeContainer1.SmartBounds = True
        Me.ChromeThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ChromeThemeContainer1.TabIndex = 0
        Me.ChromeThemeContainer1.Text = "     Pileus VPN "
        Me.ChromeThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cyber_VPN.My.Resources.Resources.cyber_mini
        Me.PictureBox2.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PanelBox1
        '
        Me.PanelBox1.BackColor = System.Drawing.Color.White
        Me.PanelBox1.Controls.Add(Me.PictureBox3)
        Me.PanelBox1.Controls.Add(Me.Logs)
        Me.PanelBox1.Controls.Add(Me.ChromeSeparator2)
        Me.PanelBox1.Controls.Add(Me.Label6)
        Me.PanelBox1.Controls.Add(Me.ChromeSeparator1)
        Me.PanelBox1.Controls.Add(Me.ButtonBlue2)
        Me.PanelBox1.Controls.Add(Me.ChromeRadioButton1)
        Me.PanelBox1.Controls.Add(Me.Label1)
        Me.PanelBox1.Controls.Add(Me.ComboBox1)
        Me.PanelBox1.Controls.Add(Me.GroupDropBox1)
        Me.PanelBox1.Controls.Add(Me.ButtonBlue1)
        Me.PanelBox1.Controls.Add(Me.GroupPanelBox1)
        Me.PanelBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.PanelBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelBox1.Location = New System.Drawing.Point(0, 101)
        Me.PanelBox1.Name = "PanelBox1"
        Me.PanelBox1.NoRounding = False
        Me.PanelBox1.Size = New System.Drawing.Size(365, 349)
        Me.PanelBox1.TabIndex = 1
        Me.PanelBox1.Text = "PanelBox1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Cyber_VPN.My.Resources.Resources.omerta_logo
        Me.PictureBox3.Location = New System.Drawing.Point(0, 117)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(365, 80)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'Logs
        '
        Me.Logs.Enabled = False
        Me.Logs.Location = New System.Drawing.Point(8, 320)
        Me.Logs.Multiline = True
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(10, 12)
        Me.Logs.TabIndex = 5
        Me.Logs.Visible = False
        '
        'ChromeSeparator2
        '
        Me.ChromeSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChromeSeparator2.Colors = New Cyber_VPN.Bloom(-1) {}
        Me.ChromeSeparator2.Customization = ""
        Me.ChromeSeparator2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ChromeSeparator2.Image = Nothing
        Me.ChromeSeparator2.Location = New System.Drawing.Point(0, 101)
        Me.ChromeSeparator2.Name = "ChromeSeparator2"
        Me.ChromeSeparator2.NoRounding = False
        Me.ChromeSeparator2.Size = New System.Drawing.Size(365, 1)
        Me.ChromeSeparator2.TabIndex = 26
        Me.ChromeSeparator2.Text = "ChromeSeparator2"
        Me.ChromeSeparator2.Transparent = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Protocol:"
        '
        'ChromeSeparator1
        '
        Me.ChromeSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChromeSeparator1.Colors = New Cyber_VPN.Bloom(-1) {}
        Me.ChromeSeparator1.Customization = ""
        Me.ChromeSeparator1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ChromeSeparator1.Image = Nothing
        Me.ChromeSeparator1.Location = New System.Drawing.Point(53, 23)
        Me.ChromeSeparator1.Name = "ChromeSeparator1"
        Me.ChromeSeparator1.NoRounding = False
        Me.ChromeSeparator1.Size = New System.Drawing.Size(200, 1)
        Me.ChromeSeparator1.TabIndex = 16
        Me.ChromeSeparator1.Text = "ChromeSeparator1"
        Me.ChromeSeparator1.Transparent = False
        '
        'ButtonBlue2
        '
        Me.ButtonBlue2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ButtonBlue2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue2.Image = Nothing
        Me.ButtonBlue2.Location = New System.Drawing.Point(257, 72)
        Me.ButtonBlue2.Name = "ButtonBlue2"
        Me.ButtonBlue2.NoRounding = False
        Me.ButtonBlue2.Size = New System.Drawing.Size(101, 23)
        Me.ButtonBlue2.TabIndex = 7
        Me.ButtonBlue2.Text = "Settings"
        '
        'ChromeRadioButton1
        '
        Me.ChromeRadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ChromeRadioButton1.Checked = True
        Me.ChromeRadioButton1.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8="
        Me.ChromeRadioButton1.Field = 16
        Me.ChromeRadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChromeRadioButton1.Image = Nothing
        Me.ChromeRadioButton1.Location = New System.Drawing.Point(67, 79)
        Me.ChromeRadioButton1.Name = "ChromeRadioButton1"
        Me.ChromeRadioButton1.NoRounding = False
        Me.ChromeRadioButton1.Size = New System.Drawing.Size(67, 16)
        Me.ChromeRadioButton1.TabIndex = 5
        Me.ChromeRadioButton1.Text = "UDP"
        Me.ChromeRadioButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Servers:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupDropBox1
        '
        Me.GroupDropBox1.Checked = True
        Me.GroupDropBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GroupDropBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupDropBox1.Location = New System.Drawing.Point(-35, 125)
        Me.GroupDropBox1.MinimumSize = New System.Drawing.Size(5, 30)
        Me.GroupDropBox1.Name = "GroupDropBox1"
        Me.GroupDropBox1.NoRounding = False
        Me.GroupDropBox1.OpenSize = New System.Drawing.Size(5, 30)
        Me.GroupDropBox1.Size = New System.Drawing.Size(5, 30)
        Me.GroupDropBox1.TabIndex = 4
        Me.GroupDropBox1.Text = "GroupDropBox1"
        '
        'ButtonBlue1
        '
        Me.ButtonBlue1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ButtonBlue1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue1.Image = Nothing
        Me.ButtonBlue1.Location = New System.Drawing.Point(257, 35)
        Me.ButtonBlue1.Name = "ButtonBlue1"
        Me.ButtonBlue1.NoRounding = False
        Me.ButtonBlue1.Size = New System.Drawing.Size(101, 23)
        Me.ButtonBlue1.TabIndex = 2
        Me.ButtonBlue1.Text = "Connect"
        '
        'GroupPanelBox1
        '
        Me.GroupPanelBox1.Controls.Add(Me.Label3)
        Me.GroupPanelBox1.Controls.Add(Me.ChromeButton1)
        Me.GroupPanelBox1.Controls.Add(Me.Label2)
        Me.GroupPanelBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GroupPanelBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupPanelBox1.Location = New System.Drawing.Point(4, 217)
        Me.GroupPanelBox1.Name = "GroupPanelBox1"
        Me.GroupPanelBox1.NoRounding = False
        Me.GroupPanelBox1.Size = New System.Drawing.Size(354, 115)
        Me.GroupPanelBox1.TabIndex = 1
        Me.GroupPanelBox1.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Status: "
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(260, 57)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(75, 23)
        Me.ChromeButton1.TabIndex = 1
        Me.ChromeButton1.Text = "View Log"
        Me.ChromeButton1.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(105, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Not Connected!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cyber_VPN.My.Resources.Resources.cyber_vpn2
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 164)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 441)
        Me.Controls.Add(Me.ChromeThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pileus VPN Beta"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ChromeThemeContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBox1.ResumeLayout(False)
        Me.PanelBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelBox1.ResumeLayout(False)
        Me.GroupPanelBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChromeThemeContainer1 As Cyber_VPN.ChromeThemeContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelBox1 As Cyber_VPN.PanelBox
    Friend WithEvents ButtonBlue1 As Cyber_VPN.ButtonBlue
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupPanelBox1 As Cyber_VPN.GroupPanelBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupDropBox1 As Cyber_VPN.GroupDropBox
    Friend WithEvents ChromeRadioButton1 As Cyber_VPN.ChromeRadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChromeButton1 As Cyber_VPN.ChromeButton
    Friend WithEvents ButtonBlue2 As Cyber_VPN.ButtonBlue
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChromeSeparator2 As Cyber_VPN.ChromeSeparator
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TimerLog As System.Windows.Forms.Timer
    Friend WithEvents Logs As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChromeSeparator1 As ChromeSeparator
    Friend WithEvents PictureBox3 As PictureBox
End Class
