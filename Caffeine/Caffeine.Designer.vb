<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caffeine
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caffeine))
        Me.CaffeineTaskBar = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartStopCaffeineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxStartup = New System.Windows.Forms.CheckBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StartCaffeineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.LinkCttynul = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaffeineTaskBar
        '
        Me.CaffeineTaskBar.ContextMenuStrip = Me.ContextMenuStrip
        Me.CaffeineTaskBar.Icon = CType(resources.GetObject("CaffeineTaskBar.Icon"), System.Drawing.Icon)
        Me.CaffeineTaskBar.Text = "Caffeine"
        Me.CaffeineTaskBar.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.BackColor = System.Drawing.SystemColors.Window
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartStopCaffeineToolStripMenuItem, Me.SettingToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(146, 92)
        '
        'StartStopCaffeineToolStripMenuItem
        '
        Me.StartStopCaffeineToolStripMenuItem.Name = "StartStopCaffeineToolStripMenuItem"
        Me.StartStopCaffeineToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.StartStopCaffeineToolStripMenuItem.Text = "Start Caffeine"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CheckBoxStartup
        '
        Me.CheckBoxStartup.AutoSize = True
        Me.CheckBoxStartup.Location = New System.Drawing.Point(12, 151)
        Me.CheckBoxStartup.Name = "CheckBoxStartup"
        Me.CheckBoxStartup.Size = New System.Drawing.Size(159, 17)
        Me.CheckBoxStartup.TabIndex = 1
        Me.CheckBoxStartup.Text = "Start Caffeine with Windows"
        Me.CheckBoxStartup.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(226, 181)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(100, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save Settings"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Caffeine is a Windows port of original Caffeine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "developed for OSX and Linux dist" &
    "ros."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCaffeineToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.CheckForUpdatesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(338, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'StartCaffeineToolStripMenuItem
        '
        Me.StartCaffeineToolStripMenuItem.Name = "StartCaffeineToolStripMenuItem"
        Me.StartCaffeineToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.StartCaffeineToolStripMenuItem.Text = "Start Caffeine"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'Logo
        '
        Me.Logo.Image = Global.Caffeine.My.Resources.Resources.Caffeine_GUI_Logo
        Me.Logo.Location = New System.Drawing.Point(28, 27)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(278, 64)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Logo.TabIndex = 3
        Me.Logo.TabStop = False
        '
        'LinkCttynul
        '
        Me.LinkCttynul.AutoSize = True
        Me.LinkCttynul.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkCttynul.Location = New System.Drawing.Point(12, 185)
        Me.LinkCttynul.Name = "LinkCttynul"
        Me.LinkCttynul.Size = New System.Drawing.Size(45, 15)
        Me.LinkCttynul.TabIndex = 6
        Me.LinkCttynul.TabStop = True
        Me.LinkCttynul.Text = "cttynul"
        '
        'Caffeine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(338, 216)
        Me.Controls.Add(Me.LinkCttynul)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.CheckBoxStartup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(354, 255)
        Me.MinimumSize = New System.Drawing.Size(354, 255)
        Me.Name = "Caffeine"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caffeine"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CaffeineTaskBar As NotifyIcon
    Shadows WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents StartStopCaffeineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBoxStartup As CheckBox
    Friend WithEvents Save As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents StartCaffeineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkCttynul As LinkLabel
End Class
