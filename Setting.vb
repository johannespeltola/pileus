Imports System.IO
Imports Microsoft.VisualBasic.Devices

Public Class Setting
    Dim pingcom As String
    Public Shared pingurl As String
    Private ConfigPathname As String = Application.StartupPath & "\data\settings.dat"
    Dim Info As New ComputerInfo

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If New FileInfo(ConfigPathname).Exists Then
            Dim xoption As New _Set
            Dim xoptionRow As _Set.OptionsRow
            xoption.ReadXml(ConfigPathname, System.Data.XmlReadMode.IgnoreSchema)
            If xoption.Options.Rows.Count > 0 Then
                xoptionRow = xoption.Options.Rows.Item(0)
                If Not xoptionRow.IsReconnectNull() Then
                    ChromeCheckbox4.Checked = xoptionRow.Reconnect
                End If
                If Not xoptionRow.IsStartupNull() Then
                    ChromeCheckbox6.Checked = xoptionRow.Startup
                End If
            End If
        End If
        If ChromeCheckbox2.Checked = False Then
            TextBox5.Enabled = True
            If TextBox5.Text = "" Then
                pingurl = " -t"
            Else
                pingurl = " -t -n " + TextBox5.Text
            End If
        ElseIf ChromeCheckbox2.Checked = True Then
            TextBox5.Enabled = False
            pingurl = " -t"
        End If
        If ChromeCheckbox1.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        ElseIf ChromeCheckbox1.Checked = False Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
        If ChromeCheckbox7.Checked = True Then
            TextBox6.Enabled = True
        ElseIf ChromeCheckbox7.Checked = False Then
            TextBox6.Enabled = False
        End If
        ChromeButton5.Visible = False
    End Sub
    Private Sub ChromeCheckbox1_CheckedChanged(ByVal sender As Object) Handles ChromeCheckbox1.CheckedChanged
        If ChromeCheckbox1.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        ElseIf ChromeCheckbox1.Checked = False Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub ChromeCheckbox2_CheckedChanged(ByVal sender As Object) Handles ChromeCheckbox2.CheckedChanged
        If ChromeCheckbox2.Checked = False Then
            TextBox5.Enabled = True
            If TextBox5.Text = "" Then
                pingurl = " -t"
            Else
                pingurl = " -t -n " + TextBox5.Text
            End If
        ElseIf ChromeCheckbox2.Checked = True Then
            TextBox5.Enabled = False
            pingurl = " -t"
        End If
    End Sub

    Private Sub ButtonBlue10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBlue10.Click
        Dim xoption As New _Set
        Dim xoptionRow As _Set.OptionsRow
        xoptionRow = xoption.Options.NewOptionsRow
        xoptionRow.Reconnect = ChromeCheckbox4.Checked
        xoptionRow.Startup = ChromeCheckbox6.Checked
        xoption.Options.AddOptionsRow(xoptionRow)
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        Dim xoption As New _Set
        Dim xoptionRow As _Set.OptionsRow
        xoptionRow = xoption.Options.NewOptionsRow
        xoptionRow.Reconnect = ChromeCheckbox4.Checked
        xoptionRow.Startup = ChromeCheckbox6.Checked
        xoption.Options.AddOptionsRow(xoptionRow)
    End Sub
    Private Sub ChromeCheckbox7_CheckedChanged(ByVal sender As Object) Handles ChromeCheckbox7.CheckedChanged
        If ChromeCheckbox7.Checked = True Then
            TextBox6.Enabled = True
        ElseIf ChromeCheckbox7.Checked = False Then
            TextBox6.Enabled = False
        End If
    End Sub
    Private Sub ChromeCheckbox6_CheckedChanged(ByVal sender As Object) Handles ChromeCheckbox6.CheckedChanged
        If ChromeCheckbox6.Checked = True Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Pileus VPN Beta", Application.ExecutablePath)
        ElseIf ChromeCheckbox6.Checked = False Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("Pileus VPN Beta")
        End If
    End Sub
    Private Sub ButtonBlue9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBlue9.Click
        Shell(Application.StartupPath & "\driver\tap-windows-9.21.2.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub ButtonBlue1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBlue1.Click
        Dim xoption As New _Set
        Dim xoptionRow As _Set.OptionsRow
        xoptionRow = xoption.Options.NewOptionsRow
        xoptionRow.Reconnect = ChromeCheckbox4.Checked
        xoptionRow.Startup = ChromeCheckbox6.Checked
        xoption.Options.AddOptionsRow(xoptionRow)
    End Sub

    Private Sub ChromeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton3.Click
        Try
            Dim web As New Net.WebClient
            Dim source As String = web.DownloadString("https://omerta.io/pileus-updater.txt")
            If source.Contains("pileus2.0") Then
                Label22.Text = "You have the Latest Version...."
            Else
                Label22.Text = "New Version Available...."
                ChromeButton5.Visible = True
                ChromeButton3.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Can't Check for Update: Check your Internet Connection", , "Error")
        End Try
    End Sub

    Private Sub ChromeButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton4.Click
        If ChromeButton4.Text = "Edit" Then
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            ChromeButton4.Text = "OK"
        ElseIf ChromeButton4.Text = "OK" Then
            TextBox3.Enabled = False
            TextBox7.Enabled = False
            ChromeButton4.Text = "Edit"
            Try
                Dim xoption As New _Set
                Dim xoptionRow As _Set.OptionsRow
                xoptionRow = xoption.Options.NewOptionsRow
                xoptionRow.Reconnect = ChromeCheckbox4.Checked
                xoptionRow.Startup = ChromeCheckbox6.Checked
                xoption.Options.AddOptionsRow(xoptionRow)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub TextBox8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim news As String = Application.StartupPath & "\data\news.txt"
        If (File.Exists(news)) Then
            File.Delete(news)
        End If

        My.Computer.Network.DownloadFile("https://omerta.io/news.txt", Application.StartupPath & "\data\news.txt")

        Dim newsReader As String
        newsReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\data\news.txt")
        TextBox8.Text = newsReader
    End Sub
    Private Sub ChromeButton5_Click(sender As Object, e As EventArgs) Handles ChromeButton5.Click
        Try
            System.Diagnostics.Process.Start("https://omerta.io/pileus/download")
        Catch
            'Code to handle the error.
        End Try
    End Sub
End Class