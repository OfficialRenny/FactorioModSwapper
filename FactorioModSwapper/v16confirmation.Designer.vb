<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class v16confirmation
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
        Me.v16back = New System.Windows.Forms.Button()
        Me.v16continue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'v16back
        '
        Me.v16back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v16back.Location = New System.Drawing.Point(180, 54)
        Me.v16back.Name = "v16back"
        Me.v16back.Size = New System.Drawing.Size(75, 23)
        Me.v16back.TabIndex = 8
        Me.v16back.Text = "Back"
        Me.v16back.UseVisualStyleBackColor = True
        '
        'v16continue
        '
        Me.v16continue.Location = New System.Drawing.Point(15, 54)
        Me.v16continue.Name = "v16continue"
        Me.v16continue.Size = New System.Drawing.Size(75, 23)
        Me.v16continue.TabIndex = 7
        Me.v16continue.Text = "Continue"
        Me.v16continue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Restoring mods will delete your currently installed mods, make sure you have made" & _
    " a backup!"
        '
        'v16confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 92)
        Me.Controls.Add(Me.v16back)
        Me.Controls.Add(Me.v16continue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "v16confirmation"
        Me.Text = "Please Confirm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents v16back As System.Windows.Forms.Button
    Friend WithEvents v16continue As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
