Imports System.Runtime.InteropServices 'APIs
Imports Microsoft.Win32

Public Class Caffeine

    <FlagsAttribute()>
    Public Enum EXECUTION_STATE As UInteger
        ES_AWAYMODE_REQUIRED = &H40
        ES_CONTINUOUS = &H80000000UI
        ES_DISPLAY_REQUIRED = &H2
        ES_SYSTEM_REQUIRED = &H1
        ' Legacy flag, should not be used.
        ' ES_USER_PRESENT = 0x00000004
    End Enum

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetThreadExecutionState(ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE
    End Function

    <DllImport("user32", EntryPoint:="SystemParametersInfo", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    End Function

    Private Const SPI_SETSCREENSAVETIMEOUT As Int32 = 15

    'Implementazione metodi ausiliari
    Public Sub KeepMonitorActive()
        SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED + EXECUTION_STATE.ES_CONTINUOUS)
    End Sub

    Public Sub RestoreMonitorSettings()
        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
    End Sub

    Private Sub Caffeine_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub Caffeine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Hide()
        CaffeineTaskBar.Visible = True

        'If My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName, Application.ExecutablePath) Is Nothing Then
        'MsgBox("Debug")
        'End If

    End Sub

    Private Sub Caffeine_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub Caffeine_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result = MessageBox.Show("Are you sure you want to close Caffeine? If you want to keep it running click resize!", "Close Caffeine", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.No) Then
            'Close Application
            RestoreMonitorSettings()
            e.Cancel = True
        End If

    End Sub

    Private Sub StartStopCaffeineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartStopCaffeineToolStripMenuItem.Click
        If StartStopCaffeineToolStripMenuItem.Text = "Start Caffeine" And StartCaffeineToolStripMenuItem.Text = "Start Caffeine" Then
            KeepMonitorActive()
            StartStopCaffeineToolStripMenuItem.Text = "Stop Caffeine"
            StartCaffeineToolStripMenuItem.Text = "Stop Caffeine"

        ElseIf StartStopCaffeineToolStripMenuItem.Text = "Stop Caffeine" And StartCaffeineToolStripMenuItem.Text = "Stop Caffeine" Then
            RestoreMonitorSettings()
            StartStopCaffeineToolStripMenuItem.Text = "Start Caffeine"
            StartCaffeineToolStripMenuItem.Text = "Start Caffeine"
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            If CheckBoxStartup.Checked = True Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            ElseIf CheckBoxStartup.Checked = False Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            End If

        Catch PermissionEx As AccessViolationException

        End Try
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CheckBoxStartup_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxStartup.CheckedChanged
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            'Ok
        Else
            CheckBoxStartup.CheckState = CheckState.Indeterminate
            MsgBox("You need to run Caffeine as Administrator to change this setting", 16, "Error")
        End If
    End Sub

    Private Sub CaffeineTaskBar_DoubleClick(sender As Object, e As MouseEventArgs) Handles CaffeineTaskBar.DoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub StartCaffeineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartCaffeineToolStripMenuItem.Click
        If StartStopCaffeineToolStripMenuItem.Text = "Start Caffeine" And StartCaffeineToolStripMenuItem.Text = "Start Caffeine" Then
            KeepMonitorActive()
            StartStopCaffeineToolStripMenuItem.Text = "Stop Caffeine"
            StartCaffeineToolStripMenuItem.Text = "Stop Caffeine"

        ElseIf StartStopCaffeineToolStripMenuItem.Text = "Stop Caffeine" And StartCaffeineToolStripMenuItem.Text = "Stop Caffeine" Then
            RestoreMonitorSettings()
            StartStopCaffeineToolStripMenuItem.Text = "Start Caffeine"
            StartCaffeineToolStripMenuItem.Text = "Start Caffeine"
        End If
    End Sub

    Private Sub LinkCttynul_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCttynul.LinkClicked
        Dim url As String = "https://github.com/cttynul"
        Process.Start(url)
    End Sub
End Class
