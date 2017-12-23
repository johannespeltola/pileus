Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Public SelectServer As String
    Public IPServer As String
    Public CaVPN As String
    Public KeyVPN As String
    Public CertVPN As String
    Public tnew As Integer
    Dim ipConfig(10) As String
    Dim Folder As IO.FileInfo
    Dim nOsname As String
    Dim proto As String
    Dim serverf As String
    Dim servers As String
    Dim nOs As Integer
    Dim pingurl As String
    Dim c As Integer = 0
    Dim iplist As String = Application.StartupPath & "\data\servers.dat"
    Dim servinf As String = Application.StartupPath & "\data\servinf.dat"
    Dim clientcrt As String = Application.StartupPath & "\data\client.crt"
    Dim clientkey As String = Application.StartupPath & "\data\client.key"
    Dim cacrt As String = Application.StartupPath & "\data\ca.crt"
    Dim tlsauth As String = Application.StartupPath & "\data\tls-auth.key"
    Private ConfigPathname As String = Application.StartupPath & "\data\settings.dat"
    Private configport As String = Application.StartupPath & "\data\port.dat"

    Private Function GetyourIP()

        If (File.Exists(iplist)) Then
            File.Delete(iplist)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/servers.txt", Application.StartupPath & "\data\servers.dat")
        Dim sR As StreamReader = New StreamReader(Application.StartupPath & "\data\servers.dat")

        Dim line As String

        'Server IP 1 - Respective server name

        nOs = 1
        nOsname = " Canada (Montreal) - " & nOs
        line = sR.ReadLine()
        ipConfig(nOs) = line
        ComboBox1.Items.Add(nOsname)
        nOs = nOs + 1

        'Server IP 2 - Respective server name

        nOs = 2
        nOsname = " France (Strasbourg) - " & nOs
        line = sR.ReadLine()
        ipConfig(nOs) = line
        ComboBox1.Items.Add(nOsname)
        nOs = nOs + 1

        'Server IP 3 - Respective server name

        nOs = 3
        nOsname = " Poland (Warsaw) - " & nOs
        line = sR.ReadLine()
        ipConfig(nOs) = line
        ComboBox1.Items.Add(nOsname)
        nOs = nOs + 1

        'Server IP 4 - Respective server name

        nOs = 4
        nOsname = " Italy (Arezzo) - " & nOs
        line = sR.ReadLine() 
        ipConfig(nOs) = line
        ComboBox1.Items.Add(nOsname)
        nOs = nOs + 1


        'Server IP 5 - Respective server name

        nOs = 5
        nOsname = " Germany (Frankfurt) - " & nOs
        line = sR.ReadLine()
        ipConfig(nOs) = line
        ComboBox1.Items.Add(nOsname)
        nOs = nOs + 1

    End Function
    Private Function SysCheck()
        Try
            Dim web As New Net.WebClient
            Dim source As String = web.DownloadString("https://omerta.io/pileus-updater.txt")
            If source.Contains("pileus1.3") Then

            Else
                MsgBox("You are using an old version of the Pileus VPN client!
Please update!")
            End If
        Catch ex As Exception
            MsgBox("Can't Check for Update: Check your Internet Connection", , "Error")
        End Try

        Try
            If My.Computer.Network.Ping("85.134.92.150") Then

            Else
                MsgBox("Cannot connect to Omerta.io main database!
Check your connection or come back later.")
            End If
        Catch ex As Exception
            MsgBox("Please check your Internet Connection", , "Error")
        End Try
    End Function
    Public Sub myConnection()
        Try
            System.Diagnostics.Process.Start("https://go.oclaserver.com/afu.php?zoneid=1290553")
        Catch
            'Code to handle the error.
        End Try

        'Downloading of keys and certificates

        If (File.Exists(clientcrt)) Then
            File.Delete(clientcrt)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/client.crt", Application.StartupPath & "\data\client.crt")

        If (File.Exists(clientkey)) Then
            File.Delete(clientkey)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/client.key", Application.StartupPath & "\data\client.key")

        If (File.Exists(cacrt)) Then
            File.Delete(cacrt)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/ca.crt", Application.StartupPath & "\data\ca.crt")

        If (File.Exists(tlsauth)) Then
            File.Delete(tlsauth)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/tls-auth.key", Application.StartupPath & "\data\tls-auth.key")

        proto = "udp"

        serverf = "--client --dev tun --remote " & IPServer & " --proto udp --port 1194 --nobind --cert data\client.crt --key data\client.key --ca data\ca.crt --resolv-retry infinite --persist-key --persist-tun --auth SHA256 --cipher AES-128-CBC --tun-mtu 1500 --remote-cert-tls server --tls-auth data\tls-auth.key 1 --verb 3 --log data\logfile.tmp --status data\status.dat"

        SelectServer = serverf

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Call GetyourIP()
        Call SysCheck()
        Try
            Dim Filenum As Integer = FreeFile()
            FileOpen(Filenum, Application.StartupPath & "\data\logfile.tmp", OpenMode.Output)
            FileClose()
        Catch ex As Exception

        End Try
        loadsettings()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        IPServer = ipConfig(Microsoft.VisualBasic.Right(ComboBox1.Text, 2))
    End Sub

    Private Sub ButtonBlue1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBlue1.Click
        loadsettings()
        tnew = 0
        Try
            If Setting.ChromeCheckbox2.Checked = False Then
                Setting.TextBox5.Enabled = True
                If Setting.TextBox5.Text = "" Then
                    pingurl = " -t"
                Else
                    pingurl = " -t -n " + Setting.TextBox5.Text
                End If
            ElseIf Setting.ChromeCheckbox2.Checked = True Then
                Setting.TextBox5.Enabled = False
                pingurl = " -t"
            End If
        Catch ex As Exception

        End Try
        If ButtonBlue1.Text = "Connect" Then
            If ComboBox1.Text = "" Then
                MessageBox.Show("Please select your server!")
            Else
                Try
                    Dim Filenum As Integer = FreeFile()
                    FileOpen(Filenum, Application.StartupPath & "\data\logfile.tmp", OpenMode.Output)
                    FileClose()
                Catch ex As Exception

                End Try
                Label2.Text = "Connecting"
                NotifyIcon1.Icon = My.Resources.connectingn
                Label2.ForeColor = Color.FromArgb(239, 105, 0)
                ButtonBlue1.Text = "Connecting"
                NotifyIcon1.ShowBalloonTip(3000, "Pileus VPN Beta", "Status: Connecting", ToolTipIcon.Info)
                myConnection()
                If Setting.ChromeCheckbox3.Checked = True Then
                    Shell("cmd /c ping " + Setting.TextBox4.Text + pingurl, AppWinStyle.Hide)
                End If
                Shell(Application.StartupPath & "\bin\openvpn " & SelectServer, AppWinStyle.Hide)
                TimerLog.Start()
            End If
        ElseIf ButtonBlue1.Text = "Disconnect" Then
            NotifyIcon1.Icon = My.Resources.newidle
            c = 0
            Dim g As String
            g = "taskkill /f /im openvpn.exe"
            Shell("cmd /c" & g, vbHide)
            g = "taskkill /f /im ping.exe"
            Shell("cmd /c" & g, vbHide)
            TimerLog.Stop()
            Label2.ForeColor = Color.FromArgb(253, 106, 72)
            Label2.Text = "Disconnected"
            ButtonBlue1.Text = "Connect"
            Try
                Dim Filenum As Integer = FreeFile()
                FileOpen(Filenum, Application.StartupPath & "\data\logfile.tmp", OpenMode.Output)
                FileClose()
            Catch ex As Exception

            End Try
            Try
                System.Diagnostics.Process.Start("https://go.oclaserver.com/afu.php?zoneid=1290553")
            Catch
                'Code to handle the error.
            End Try
        ElseIf ButtonBlue1.Text = "Connecting" Then
            If MsgBox("Do You want to Disconnect Pileus VPN", MsgBoxStyle.YesNo, "Pileus VPN") = vbYes Then
                NotifyIcon1.Icon = My.Resources.newidle
                c = 0
                Dim g As String
                g = "taskkill /f /im openvpn.exe"
                Shell("cmd /c" & g, vbHide)
                g = "taskkill /f /im ping.exe"
                Shell("cmd /c" & g, vbHide)
                TimerLog.Stop()
                Label2.ForeColor = Color.FromArgb(253, 106, 72)
                Label2.Text = "Disconnected"
                ButtonBlue1.Text = "Connect"
                Try
                    Dim Filenum As Integer = FreeFile()
                    FileOpen(Filenum, Application.StartupPath & "\data\logfile.tmp", OpenMode.Output)
                    FileClose()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim g As String
        g = "taskkill /f /im openvpn.exe"
        Shell("cmd /c" & g, vbHide)
        g = "taskkill /f /im ping.exe"
        Shell("cmd /c" & g, vbHide)
        TimerLog.Stop()
        loadsettings()
        Label2.Text = "Re-Connecting"
        Label2.ForeColor = Color.FromArgb(253, 52, 52)
        ButtonBlue1.Text = "Connecting"
        NotifyIcon1.ShowBalloonTip(3000, "Pileus VPN Beta", "Status: Connecting", ToolTipIcon.Info)
        myConnection()
        If Setting.ChromeCheckbox3.Checked = True Then
            Shell("cmd /c ping " + Setting.TextBox4.Text + " " + Setting.pingurl, AppWinStyle.Hide)
        End If
        Shell(Application.StartupPath & "\bin\openvpn " & SelectServer, AppWinStyle.Hide)
        TimerLog.Start()
    End Sub
    Private Sub TimerLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLog.Tick
        If tnew = 0 Then
            log_view.RichTextBox1.Text = ""
        End If
        Try
            Logs.Text = ""
            Dim textline(10000) As String
            Dim TestfileX As String = Application.StartupPath & "\data\logfile.tmp"
            Dim log_ctr As Integer
            Dim last_log As Integer
            FileOpen(1, TestfileX, OpenMode.Input, OpenAccess.Read, OpenShare.LockRead)
            Do Until EOF(1)
                textline(log_ctr) = LineInput(1)
                log_ctr = log_ctr + 1
                If last_log <> log_ctr Then
                    For n = last_log To log_ctr - 1
                        If tnew = 0 Then
                            log_view.RichTextBox1.Text = log_view.RichTextBox1.Text & textline(n) & vbCrLf
                        End If
                        If InStrRev(textline(n), "OpenVPN") > 0 Then
                            Logs.SelectedText = Logs.SelectedText & "Connecting to Network......." & vbCrLf
                        ElseIf InStrRev(textline(n), "this configuration to call") > 0 Then
                            Logs.SelectedText = Logs.SelectedText & "Bypassing Firewall......" & vbCrLf & "Accessing Server....please wait" & vbCrLf
                        ElseIf InStrRev(textline(n), "Peer Connection Initiated with 0.0.0.0:0") > 0 Then
                            Logs.SelectedText = Logs.SelectedText & "Initiating Server...." & vbCrLf
                        ElseIf InStrRev(textline(n), "TAP-WIN32 device") > 0 Then
                            Logs.SelectedText = Logs.SelectedText & "Peer Connection Initiated with 0.0.0.0:0:1194" & vbCrLf
                        ElseIf InStrRev(textline(n), "Successful ARP Flush on interface") > 0 Then
                            Logs.SelectedText = Logs.SelectedText & "Please wait........" & vbCrLf
                        ElseIf InStrRev(textline(n), "Initialization Sequence Completed") > 0 Then
                            Logs.SelectedText = "Initialization Sequence Completed" & vbCrLf
                            If c = 0 Then
                                NotifyIcon1.Icon = My.Resources.connected
                                NotifyIcon1.ShowBalloonTip(3000, "Pileus VPN Beta", "Status: Pileus VPN Connected Successfully", ToolTipIcon.Info)
                                Me.WindowState = FormWindowState.Minimized
                                Me.Hide()
                                c = 1
                                If Setting.ChromeCheckbox7.Checked = True Then
                                    Process.Start(Setting.TextBox6.Text)
                                End If
                                tnew = 1
                            End If
                            Label2.Text = "Connected"
                            ButtonBlue1.Text = "Disconnect"
                            Label2.ForeColor = Color.Green
                            Logs.SelectedText = Logs.SelectedText & "Your Connected, Enjoy Your Browsing" & vbCrLf & "//Thanks for Using\\"

                        ElseIf InStrRev(textline(n), "AUTH: Received AUTH_FAILED control message") > 0 Then
                            Logs.SelectedText = "Authentication Failed" & vbCrLf
                            Label2.Text = "AUTH FAILED"
                            Label2.ForeColor = Color.Red
                            Dim g As String
                            g = "taskkill /f /im openvpn.exe"
                            Shell("cmd /c" & g, vbHide)
                            g = "taskkill /f /im ping.exe"
                            Shell("cmd /c" & g, vbHide)
                            ButtonBlue1.Text = "Connect"
                            TimerLog.Stop()
                            NotifyIcon1.ShowBalloonTip(3000, "Pileus VPN Beta", "Status: Authentication Failed", ToolTipIcon.Info)

                        ElseIf InStrRev(textline(n), "Inactivity timeout (--ping-restart), restarting") > 0 Then
                            Dim g As String
                            g = "taskkill /f /im openvpn.exe"
                            Shell("cmd /c" & g, vbHide)
                            g = "taskkill /f /im ping.exe"
                            Shell("cmd /c" & g, vbHide)
                            ButtonBlue1.Text = "Connect"
                            Label2.Text = "Disconnected"
                            Logs.Text = "======Inactivity timeout======" & vbNewLine & "Unable to connect..." & vbCrLf & "Please Try to connect again" & vbCrLf & vbCrLf & "=======Try Again======"
                            TimerLog.Stop()
                            NotifyIcon1.ShowBalloonTip(3000, "Pileus VPN Beta", "Status: Force Reconnect", ToolTipIcon.Info)
                            Label2.Text = "Trying to Force Reconnect"
                            Label2.ForeColor = Color.Red
                            Timer1.Enabled = True
                            tnew = 0
                        ElseIf InStrRev(textline(n), "Exiting") > 0 Then
                            Dim g As String
                            g = "taskkill /f /im openvpn.exe"
                            Shell("cmd /c" & g, vbHide)
                            g = "taskkill /f /im ping.exe"
                            Shell("cmd /c" & g, vbHide)
                            ButtonBlue1.Text = "Connect"
                            Label2.Text = "Disconnected"
                            Logs.Text = "Unable to connect..." & vbCrLf & "Please Try to connect again"
                            TimerLog.Enabled = False
                        End If
                    Next
                    last_log = log_ctr
                End If
            Loop
        Catch ex As Exception

        End Try
        Try
            FileClose(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonBlue3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChromeRadioButton1.Checked = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        myConnection()
        Shell("cmd ipconfig/flushdns ipconfig/registerdns", AppWinStyle.Hide)
        Shell(Application.StartupPath & "\bin\openvpn.exe " & SelectServer, AppWinStyle.Hide)
        TimerLog.Start()
        Label2.Text = "Force Reconnect"
        Label2.ForeColor = Color.Orange
        Timer1.Enabled = False
    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        Try
            log_view.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonBlue2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBlue2.Click
        Setting.Show()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles NotifyIcon1.DoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub loadsettings()
        Try
            If New FileInfo(ConfigPathname).Exists Then
                Dim xoption As New _Set
                Dim xoptionRow As _Set.OptionsRow
                xoption.ReadXml(ConfigPathname, System.Data.XmlReadMode.IgnoreSchema)
                If xoption.Options.Rows.Count > 0 Then
                    xoptionRow = xoption.Options.Rows.Item(0)
                    If Not xoptionRow.IsReconnectNull() Then
                        Setting.ChromeCheckbox4.Checked = xoptionRow.Reconnect
                    End If
                    If Not xoptionRow.IsStartupNull() Then
                        Setting.ChromeCheckbox6.Checked = xoptionRow.Startup
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
        Setting.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            Dim g As String
            g = "taskkill /f /im openvpn.exe"
            Shell("cmd /c" & g, vbHide)
            g = "taskkill /f /im ping.exe"
            Shell("cmd /c" & g, vbHide)
        Catch ex As Exception

        End Try
        Setting.Close()
        Me.Close()
        End
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        Try
            If ButtonBlue1.Text = "Disconnect" Then
                NotifyIcon1.Icon = My.Resources.newidle
                c = 0
                Dim g As String
                g = "taskkill /f /im openvpn.exe"
                Shell("cmd /c" & g, vbHide)
                g = "taskkill /f /im ping.exe"
                Shell("cmd /c" & g, vbHide)
                TimerLog.Stop()
                Label2.ForeColor = Color.FromArgb(253, 106, 72)
                Label2.Text = "Disconnected"
                ButtonBlue1.Text = "Connect"
                Try
                    Dim Filenum As Integer = FreeFile()
                    FileOpen(Filenum, Application.StartupPath & "\data\logfile.tmp", OpenMode.Output)
                    FileClose()
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If (File.Exists(clientcrt)) Then
            File.Delete(clientcrt)
        End If
        If (File.Exists(clientkey)) Then
            File.Delete(clientkey)
        End If
        If (File.Exists(cacrt)) Then
            File.Delete(cacrt)
        End If
        If (File.Exists(tlsauth)) Then
            File.Delete(tlsauth)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            System.Diagnostics.Process.Start("https://omerta.io")
        Catch
            'Code to handle the error.
        End Try
    End Sub
End Class

