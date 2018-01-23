<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class v15confirmation
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
        Me.v15back = New System.Windows.Forms.Button()
        Me.v15continue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'v15back
        '
        Me.v15back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v15back.Location = New System.Drawing.Point(180, 54)
        Me.v15back.Name = "v15back"
        Me.v15back.Size = New System.Drawing.Size(75, 23)
        Me.v15back.TabIndex = 5
        Me.v15back.Text = "Back"
        Me.v15back.UseVisualStyleBackColor = True
        '
        'v15continue
        '
        Me.v15continue.Location = New System.Drawing.Point(15, 54)
        Me.v15continue.Name = "v15continue"
        Me.v15continue.Size = New System.Drawing.Size(75, 23)
        Me.v15continue.TabIndex = 4
        Me.v15continue.Text = "Continue"
        Me.v15continue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Restoring mods will delete your currently installed mods, make sure you have made" & _
    " a backup!"
        '
        'v15confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 92)
        Me.Controls.Add(Me.v15back)
        Me.Controls.Add(Me.v15continue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "v15confirmation"
        Me.Text = "Please Confirm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents v15back As Button
    Friend WithEvents v15continue As Button
    Friend WithEvents Label1 As Label
End Class
