﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.v15backup.Location = New System.Drawing.Point(161, 12)
        Me.v15backup.Name = "v15backup"
        Me.v15backup.Size = New System.Drawing.Size(113, 45)
        Me.v15backup.TabIndex = 2
        Me.v15backup.Text = "Backup v0.15 Mods"
        Me.v15backup.UseVisualStyleBackColor = True
        '
        'v15restoreConfirm
        '
        Me.v15restoreConfirm.Location = New System.Drawing.Point(161, 90)
        Me.v15restoreConfirm.Name = "v15restoreConfirm"
        Me.v15restoreConfirm.Size = New System.Drawing.Size(113, 45)
        Me.v15restoreConfirm.TabIndex = 3
        Me.v15restoreConfirm.Text = "Restore v0.15 Mods"
        Me.v15restoreConfirm.UseVisualStyleBackColor = True
        '
        'FactorioModSwitcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 216)
        Me.Controls.Add(Me.v15restoreConfirm)
        Me.Controls.Add(Me.v15backup)
        Me.Controls.Add(Me.v16restoreConfirm)
        Me.Controls.Add(Me.v16backup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FactorioModSwitcher"
        Me.Text = "Factorio Mod Switcher"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents v16backup As Button
    Friend WithEvents v16restoreConfirm As Button
    Friend WithEvents v15backup As Button
    Friend WithEvents v15restoreConfirm As Button
End Class