<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.WaitLabel = New System.Windows.Forms.Label()
        Me.CerrarButton = New System.Windows.Forms.Button()
        Me.CustomersHomologationButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GeographyHomologationButton = New System.Windows.Forms.Button()
        Me.ProductsHomologationButton = New System.Windows.Forms.Button()
        Me.GeographyButton = New System.Windows.Forms.Button()
        Me.CustomersButton = New System.Windows.Forms.Button()
        Me.ProductsButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaitLabel
        '
        Me.WaitLabel.AutoSize = True
        Me.WaitLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WaitLabel.Font = New System.Drawing.Font("Calibri", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaitLabel.ForeColor = System.Drawing.Color.Red
        Me.WaitLabel.Location = New System.Drawing.Point(18, 717)
        Me.WaitLabel.Name = "WaitLabel"
        Me.WaitLabel.Size = New System.Drawing.Size(756, 45)
        Me.WaitLabel.TabIndex = 6
        Me.WaitLabel.Text = "Un momento, cargando pantalla de productos..."
        Me.WaitLabel.Visible = False
        '
        'CerrarButton
        '
        Me.CerrarButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CerrarButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Button_Close_011
        Me.CerrarButton.Location = New System.Drawing.Point(604, 466)
        Me.CerrarButton.Name = "CerrarButton"
        Me.CerrarButton.Size = New System.Drawing.Size(263, 215)
        Me.CerrarButton.TabIndex = 14
        Me.CerrarButton.UseVisualStyleBackColor = True
        '
        'CustomersHomologationButton
        '
        Me.CustomersHomologationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomersHomologationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CustomersHomologationButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.CustomerHomologationButton
        Me.CustomersHomologationButton.Location = New System.Drawing.Point(305, 466)
        Me.CustomersHomologationButton.Name = "CustomersHomologationButton"
        Me.CustomersHomologationButton.Size = New System.Drawing.Size(293, 215)
        Me.CustomersHomologationButton.TabIndex = 13
        Me.CustomersHomologationButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.DimensionsConfiguration.My.Resources.Resources.Bi_dimensions_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(874, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GeographyHomologationButton
        '
        Me.GeographyHomologationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GeographyHomologationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GeographyHomologationButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Geography_Homologation
        Me.GeographyHomologationButton.Location = New System.Drawing.Point(680, 276)
        Me.GeographyHomologationButton.Name = "GeographyHomologationButton"
        Me.GeographyHomologationButton.Size = New System.Drawing.Size(187, 184)
        Me.GeographyHomologationButton.TabIndex = 11
        Me.GeographyHomologationButton.UseVisualStyleBackColor = True
        '
        'ProductsHomologationButton
        '
        Me.ProductsHomologationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsHomologationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProductsHomologationButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Products_homologation
        Me.ProductsHomologationButton.Location = New System.Drawing.Point(305, 276)
        Me.ProductsHomologationButton.Name = "ProductsHomologationButton"
        Me.ProductsHomologationButton.Size = New System.Drawing.Size(176, 184)
        Me.ProductsHomologationButton.TabIndex = 10
        Me.ProductsHomologationButton.UseVisualStyleBackColor = True
        '
        'GeographyButton
        '
        Me.GeographyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GeographyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GeographyButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Central_America
        Me.GeographyButton.Location = New System.Drawing.Point(487, 276)
        Me.GeographyButton.Name = "GeographyButton"
        Me.GeographyButton.Size = New System.Drawing.Size(187, 184)
        Me.GeographyButton.TabIndex = 9
        Me.GeographyButton.UseVisualStyleBackColor = True
        '
        'CustomersButton
        '
        Me.CustomersButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CustomersButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.CustomersButton
        Me.CustomersButton.Location = New System.Drawing.Point(6, 466)
        Me.CustomersButton.Name = "CustomersButton"
        Me.CustomersButton.Size = New System.Drawing.Size(293, 215)
        Me.CustomersButton.TabIndex = 8
        Me.CustomersButton.UseVisualStyleBackColor = True
        '
        'ProductsButton
        '
        Me.ProductsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProductsButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.productsButton
        Me.ProductsButton.Location = New System.Drawing.Point(6, 276)
        Me.ProductsButton.Name = "ProductsButton"
        Me.ProductsButton.Size = New System.Drawing.Size(293, 184)
        Me.ProductsButton.TabIndex = 7
        Me.ProductsButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 690)
        Me.Controls.Add(Me.CerrarButton)
        Me.Controls.Add(Me.CustomersHomologationButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GeographyHomologationButton)
        Me.Controls.Add(Me.ProductsHomologationButton)
        Me.Controls.Add(Me.GeographyButton)
        Me.Controls.Add(Me.CustomersButton)
        Me.Controls.Add(Me.ProductsButton)
        Me.Controls.Add(Me.WaitLabel)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BI Dimensions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WaitLabel As System.Windows.Forms.Label
    Friend WithEvents ProductsButton As System.Windows.Forms.Button
    Friend WithEvents CustomersButton As System.Windows.Forms.Button
    Friend WithEvents GeographyButton As System.Windows.Forms.Button
    Friend WithEvents ProductsHomologationButton As System.Windows.Forms.Button
    Friend WithEvents GeographyHomologationButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CustomersHomologationButton As System.Windows.Forms.Button
    Friend WithEvents CerrarButton As System.Windows.Forms.Button
End Class
