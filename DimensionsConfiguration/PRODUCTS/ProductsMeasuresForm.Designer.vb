<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsMeasuresForm
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
        Me.TotRegistrosLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CerrarButton = New System.Windows.Forms.Button()
        Me.GridDatos = New System.Windows.Forms.DataGridView()
        Me.TituloLabel = New System.Windows.Forms.Label()
        Me.MeasureNameTextBox = New System.Windows.Forms.TextBox()
        Me.MeasureNameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotRegistrosLabel
        '
        Me.TotRegistrosLabel.AutoSize = True
        Me.TotRegistrosLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotRegistrosLabel.Location = New System.Drawing.Point(12, 10)
        Me.TotRegistrosLabel.Name = "TotRegistrosLabel"
        Me.TotRegistrosLabel.Size = New System.Drawing.Size(91, 15)
        Me.TotRegistrosLabel.TabIndex = 1
        Me.TotRegistrosLabel.Text = "Total registros: "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Revise la lista antes de registra una nueva entrada para confirmar que no existe." & _
    ""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CerrarButton)
        Me.Panel1.Controls.Add(Me.TotRegistrosLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 683)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 36)
        Me.Panel1.TabIndex = 2
        '
        'CerrarButton
        '
        Me.CerrarButton.Location = New System.Drawing.Point(723, 7)
        Me.CerrarButton.Name = "CerrarButton"
        Me.CerrarButton.Size = New System.Drawing.Size(75, 23)
        Me.CerrarButton.TabIndex = 0
        Me.CerrarButton.Text = "Cerrar"
        Me.CerrarButton.UseVisualStyleBackColor = True
        '
        'GridDatos
        '
        Me.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDatos.Location = New System.Drawing.Point(12, 79)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.RowTemplate.Height = 24
        Me.GridDatos.Size = New System.Drawing.Size(504, 582)
        Me.GridDatos.TabIndex = 4
        '
        'TituloLabel
        '
        Me.TituloLabel.AutoSize = True
        Me.TituloLabel.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLabel.ForeColor = System.Drawing.Color.Navy
        Me.TituloLabel.Location = New System.Drawing.Point(12, 9)
        Me.TituloLabel.Name = "TituloLabel"
        Me.TituloLabel.Size = New System.Drawing.Size(110, 35)
        Me.TituloLabel.TabIndex = 7
        Me.TituloLabel.Text = "Label1"
        '
        'MeasureNameTextBox
        '
        Me.MeasureNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeasureNameTextBox.BackColor = System.Drawing.Color.Beige
        Me.MeasureNameTextBox.Enabled = False
        Me.MeasureNameTextBox.Location = New System.Drawing.Point(25, 85)
        Me.MeasureNameTextBox.MaxLength = 50
        Me.MeasureNameTextBox.Name = "MeasureNameTextBox"
        Me.MeasureNameTextBox.Size = New System.Drawing.Size(257, 20)
        Me.MeasureNameTextBox.TabIndex = 9
        '
        'MeasureNameLabel
        '
        Me.MeasureNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeasureNameLabel.AutoSize = True
        Me.MeasureNameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeasureNameLabel.Location = New System.Drawing.Point(25, 58)
        Me.MeasureNameLabel.Name = "MeasureNameLabel"
        Me.MeasureNameLabel.Size = New System.Drawing.Size(43, 14)
        Me.MeasureNameLabel.TabIndex = 8
        Me.MeasureNameLabel.Text = "Ingrese"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.CancelarButton)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.GuardarButton)
        Me.Panel2.Controls.Add(Me.MeasureNameLabel)
        Me.Panel2.Controls.Add(Me.MeasureNameTextBox)
        Me.Panel2.Location = New System.Drawing.Point(522, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 582)
        Me.Panel2.TabIndex = 11
        '
        'CancelarButton
        '
        Me.CancelarButton.Enabled = False
        Me.CancelarButton.Location = New System.Drawing.Point(124, 148)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(93, 31)
        Me.CancelarButton.TabIndex = 12
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.DimensionsConfiguration.My.Resources.Resources.PencilAngled_32xLG_color
        Me.PictureBox1.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.NewRow_291
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(25, 111)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(192, 31)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "*"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'GuardarButton
        '
        Me.GuardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuardarButton.Enabled = False
        Me.GuardarButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.SaveFileDialogControl_703_32
        Me.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarButton.Location = New System.Drawing.Point(25, 148)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(93, 31)
        Me.GuardarButton.TabIndex = 10
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MeasuresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 719)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TituloLabel)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MeasuresForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Measures"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotRegistrosLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CerrarButton As System.Windows.Forms.Button
    Friend WithEvents GridDatos As System.Windows.Forms.DataGridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents TituloLabel As System.Windows.Forms.Label
    Friend WithEvents MeasureNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MeasureNameLabel As System.Windows.Forms.Label
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    '
    '    'MeasuresForm
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(284, 262)
    '    Me.Name = "MeasuresForm"
    '    Me.Text = "MeasuresForm"
    '    Me.ResumeLayout(False)

    'End Sub
End Class
