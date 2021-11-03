<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMeasureControl
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
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.MeasureNameLabel = New System.Windows.Forms.Label()
        Me.MeasureNameTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RegistradoLabel = New System.Windows.Forms.Label()
        Me.TituloLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GuardarButton
        '
        Me.GuardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuardarButton.Location = New System.Drawing.Point(497, 239)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 0
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'MeasureNameLabel
        '
        Me.MeasureNameLabel.AutoSize = True
        Me.MeasureNameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeasureNameLabel.Location = New System.Drawing.Point(38, 35)
        Me.MeasureNameLabel.Name = "MeasureNameLabel"
        Me.MeasureNameLabel.Size = New System.Drawing.Size(43, 14)
        Me.MeasureNameLabel.TabIndex = 2
        Me.MeasureNameLabel.Text = "Ingrese"
        '
        'MeasureNameTextBox
        '
        Me.MeasureNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeasureNameTextBox.BackColor = System.Drawing.Color.Beige
        Me.MeasureNameTextBox.Location = New System.Drawing.Point(41, 63)
        Me.MeasureNameTextBox.MaxLength = 50
        Me.MeasureNameTextBox.Name = "MeasureNameTextBox"
        Me.MeasureNameTextBox.Size = New System.Drawing.Size(441, 21)
        Me.MeasureNameTextBox.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DimensionsConfiguration.My.Resources.Resources.PencilAngled_32xLG_color
        Me.PictureBox1.Location = New System.Drawing.Point(85, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.RegistradoLabel)
        Me.Panel1.Controls.Add(Me.MeasureNameTextBox)
        Me.Panel1.Controls.Add(Me.MeasureNameLabel)
        Me.Panel1.Location = New System.Drawing.Point(51, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 150)
        Me.Panel1.TabIndex = 5
        '
        'RegistradoLabel
        '
        Me.RegistradoLabel.AutoSize = True
        Me.RegistradoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistradoLabel.ForeColor = System.Drawing.Color.Red
        Me.RegistradoLabel.Location = New System.Drawing.Point(38, 97)
        Me.RegistradoLabel.Name = "RegistradoLabel"
        Me.RegistradoLabel.Size = New System.Drawing.Size(111, 14)
        Me.RegistradoLabel.TabIndex = 4
        Me.RegistradoLabel.Text = "Se agregó registro"
        Me.RegistradoLabel.Visible = False
        '
        'TituloLabel
        '
        Me.TituloLabel.AutoSize = True
        Me.TituloLabel.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLabel.ForeColor = System.Drawing.Color.Navy
        Me.TituloLabel.Location = New System.Drawing.Point(123, 38)
        Me.TituloLabel.Name = "TituloLabel"
        Me.TituloLabel.Size = New System.Drawing.Size(110, 35)
        Me.TituloLabel.TabIndex = 6
        Me.TituloLabel.Text = "Label1"
        '
        'AddMeasureControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.TituloLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GuardarButton)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddMeasureControl"
        Me.Size = New System.Drawing.Size(622, 277)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents MeasureNameLabel As System.Windows.Forms.Label
    Friend WithEvents MeasureNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TituloLabel As System.Windows.Forms.Label
    Friend WithEvents RegistradoLabel As System.Windows.Forms.Label

End Class
