<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reciept
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Location = New System.Drawing.Point(-11, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 23)
        Me.Panel2.TabIndex = 7
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(616, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(21, 22)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "---"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(637, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(21, 22)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "X"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Reciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reciept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
