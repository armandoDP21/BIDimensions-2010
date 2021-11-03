<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomologationDisplayUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.HTypeLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotRegistrosLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HTypeLabel
        '
        Me.HTypeLabel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.HTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTypeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HTypeLabel.Location = New System.Drawing.Point(401, 0)
        Me.HTypeLabel.Name = "HTypeLabel"
        Me.HTypeLabel.Size = New System.Drawing.Size(431, 42)
        Me.HTypeLabel.TabIndex = 0
        Me.HTypeLabel.Text = "Brand &&  Category"
        Me.HTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.TotRegistrosLabel)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 738)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 46)
        Me.Panel1.TabIndex = 1
        '
        'TotRegistrosLabel
        '
        Me.TotRegistrosLabel.AutoSize = True
        Me.TotRegistrosLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotRegistrosLabel.Location = New System.Drawing.Point(34, 16)
        Me.TotRegistrosLabel.Name = "TotRegistrosLabel"
        Me.TotRegistrosLabel.Size = New System.Drawing.Size(91, 15)
        Me.TotRegistrosLabel.TabIndex = 2
        Me.TotRegistrosLabel.Text = "Total registros: "
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(712, 7)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(107, 33)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Guardar"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'HomologationDisplayUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HTypeLabel)
        Me.Name = "HomologationDisplayUC"
        Me.Size = New System.Drawing.Size(832, 784)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents TotRegistrosLabel As System.Windows.Forms.Label

End Class
