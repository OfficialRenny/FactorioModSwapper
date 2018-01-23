<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactorioModSwitcher
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
        Me.v16backup = New System.Windows.Forms.Button()
        Me.v16restoreConfirm = New System.Windows.Forms.Button()
        Me.v15backup = New System.Windows.Forms.Button()
        Me.v15restoreConfirm = New System.Windows.Forms.Button()
        Me.currentModCheck = New System.Windows.Forms.Label()
        Me.v15ModBackupCheck = New System.Windows.Forms.Label()
        Me.v16ModBackupCheck = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'v16backup
        '
        Me.v16backup.Location = New System.Drawing.Point(12, 12)
        Me.v16backup.Name = "v16backup"
        Me.v16backup.Size = New System.Drawing.Size(113, 45)
        Me.v16backup.TabIndex = 0
        Me.v16backup.Text = "Backup v0.16 Mods"
        Me.v16backup.UseVisualStyleBackColor = True
        '
        'v16restoreConfirm
        '
        Me.v16restoreConfirm.Location = New System.Drawing.Point(12, 90)
        Me.v16restoreConfirm.Name = "v16restoreConfirm"
        Me.v16restoreConfirm.Size = New System.Drawing.Size(113, 45)
        Me.v16restoreConfirm.TabIndex = 1
        Me.v16restoreConfirm.Text = "Restore v0.16 Mods"
        Me.v16restoreConfirm.UseVisualStyleBackColor = True
        '
        'v15backup
        '
        Me.v15backup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v15backup.Location = New System.Drawing.Point(250, 12)
        Me.v15backup.Name = "v15backup"
        Me.v15backup.Size = New System.Drawing.Size(113, 45)
        Me.v15backup.TabIndex = 2
        Me.v15backup.Text = "Backup v0.15 Mods"
        Me.v15backup.UseVisualStyleBackColor = True
        '
        'v15restoreConfirm
        '
        Me.v15restoreConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v15restoreConfirm.Location = New System.Drawing.Point(250, 90)
        Me.v15restoreConfirm.Name = "v15restoreConfirm"
        Me.v15restoreConfirm.Size = New System.Drawing.Size(113, 45)
        Me.v15restoreConfirm.TabIndex = 3
        Me.v15restoreConfirm.Text = "Restore v0.15 Mods"
        Me.v15restoreConfirm.UseVisualStyleBackColor = True
        '
        'currentModCheck
        '
        Me.currentModCheck.AutoSize = True
        Me.currentModCheck.Location = New System.Drawing.Point(12, 148)
        Me.currentModCheck.Name = "currentModCheck"
        Me.currentModCheck.Size = New System.Drawing.Size(169, 13)
        Me.currentModCheck.TabIndex = 4
        Me.currentModCheck.Text = "Checking for current mods folder..."
        '
        'v15ModBackupCheck
        '
        Me.v15ModBackupCheck.AutoSize = True
        Me.v15ModBackupCheck.Location = New System.Drawing.Point(12, 161)
        Me.v15ModBackupCheck.Name = "v15ModBackupCheck"
        Me.v15ModBackupCheck.Size = New System.Drawing.Size(173, 13)
        Me.v15ModBackupCheck.TabIndex = 5
        Me.v15ModBackupCheck.Text = "Checking for v0.15 mod backups..."
        '
        'v16ModBackupCheck
        '
        Me.v16ModBackupCheck.AutoSize = True
        Me.v16ModBackupCheck.Location = New System.Drawing.Point(12, 174)
        Me.v16ModBackupCheck.Name = "v16ModBackupCheck"
        Me.v16ModBackupCheck.Size = New System.Drawing.Size(173, 13)
        Me.v16ModBackupCheck.TabIndex = 6
        Me.v16ModBackupCheck.Text = "Checking for v0.16 mod backups..."
        '
        'FactorioModSwitcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 198)
        Me.Controls.Add(Me.v16ModBackupCheck)
        Me.Controls.Add(Me.v15ModBackupCheck)
        Me.Controls.Add(Me.currentModCheck)
        Me.Controls.Add(Me.v15restoreConfirm)
        Me.Controls.Add(Me.v15backup)
        Me.Controls.Add(Me.v16restoreConfirm)
        Me.Controls.Add(Me.v16backup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FactorioModSwitcher"
        Me.Text = "Factorio Mod Switcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents v16backup As Button
    Friend WithEvents v16restoreConfirm As Button
    Friend WithEvents v15backup As Button
    Friend WithEvents v15restoreConfirm As Button
    Friend WithEvents currentModCheck As Label
    Friend WithEvents v15ModBackupCheck As Label
    Friend WithEvents v16ModBackupCheck As Label
End Class
