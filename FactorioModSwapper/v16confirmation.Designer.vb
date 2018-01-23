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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.v16continue = New System.Windows.Forms.Button()
        Me.v16back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restoring mods will delete your currently installed mods, make sure you have made" &
    " a backup!"
        '
        'v16continue
        '
        Me.v16continue.Location = New System.Drawing.Point(12, 123)
        Me.v16continue.Name = "v16continue"
        Me.v16continue.Size = New System.Drawing.Size(75, 23)
        Me.v16continue.TabIndex = 1
        Me.v16continue.Text = "Continue"
        Me.v16continue.UseVisualStyleBackColor = True
        '
        'v16back
        '
        Me.v16back.Location = New System.Drawing.Point(180, 123)
        Me.v16back.Name = "v16back"
        Me.v16back.Size = New System.Drawing.Size(75, 23)
        Me.v16back.TabIndex = 2
        Me.v16back.Text = "Back"
        Me.v16back.UseVisualStyleBackColor = True
        '
        'v16confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 158)
        Me.Controls.Add(Me.v16back)
        Me.Controls.Add(Me.v16continue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "v16confirmation"
        Me.Text = "Please Confirm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents v16continue As Button
    Friend WithEvents v16back As Button
End Class
