<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeographyHomologationMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeographyHomologationMainForm))
        Me.CountryButton = New System.Windows.Forms.Button()
        Me.DistrictButton = New System.Windows.Forms.Button()
        Me.Route_RepresentativeButton = New System.Windows.Forms.Button()
        Me.TypeRouteButton = New System.Windows.Forms.Button()
        Me.TypeBrandButton = New System.Windows.Forms.Button()
        Me.BranchButton = New System.Windows.Forms.Button()
        Me.GridDatos = New System.Windows.Forms.DataGridView()
        Me.HomEditionUC1 = New DimensionsConfiguration.HomologationEditionUC()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TypeOFSalesButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Key3TextBox = New System.Windows.Forms.TextBox()
        Me.Key2TextBox = New System.Windows.Forms.TextBox()
        Me.Key1TextBox = New System.Windows.Forms.TextBox()
        Me.HTypeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSystemId = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CountryButton
        '
        Me.CountryButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CountryButton.Image = CType(resources.GetObject("CountryButton.Image"), System.Drawing.Image)
        Me.CountryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CountryButton.Location = New System.Drawing.Point(3, 84)
        Me.CountryButton.Name = "CountryButton"
        Me.CountryButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.CountryButton.Size = New System.Drawing.Size(174, 76)
        Me.CountryButton.TabIndex = 1
        Me.CountryButton.Text = "Country"
        Me.CountryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CountryButton.UseVisualStyleBackColor = True
        '
        'DistrictButton
        '
        Me.DistrictButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistrictButton.Image = CType(resources.GetObject("DistrictButton.Image"), System.Drawing.Image)
        Me.DistrictButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DistrictButton.Location = New System.Drawing.Point(3, 166)
        Me.DistrictButton.Name = "DistrictButton"
        Me.DistrictButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.DistrictButton.Size = New System.Drawing.Size(174, 76)
        Me.DistrictButton.TabIndex = 2
        Me.DistrictButton.Text = "District"
        Me.DistrictButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DistrictButton.UseVisualStyleBackColor = True
        '
        'Route_RepresentativeButton
        '
        Me.Route_RepresentativeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Route_RepresentativeButton.Image = CType(resources.GetObject("Route_RepresentativeButton.Image"), System.Drawing.Image)
        Me.Route_RepresentativeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Route_RepresentativeButton.Location = New System.Drawing.Point(3, 248)
        Me.Route_RepresentativeButton.Name = "Route_RepresentativeButton"
        Me.Route_RepresentativeButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.Route_RepresentativeButton.Size = New System.Drawing.Size(174, 76)
        Me.Route_RepresentativeButton.TabIndex = 3
        Me.Route_RepresentativeButton.Text = "Route Representative"
        Me.Route_RepresentativeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Route_RepresentativeButton.UseVisualStyleBackColor = True
        '
        'TypeRouteButton
        '
        Me.TypeRouteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeRouteButton.Image = CType(resources.GetObject("TypeRouteButton.Image"), System.Drawing.Image)
        Me.TypeRouteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TypeRouteButton.Location = New System.Drawing.Point(3, 330)
        Me.TypeRouteButton.Name = "TypeRouteButton"
        Me.TypeRouteButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.TypeRouteButton.Size = New System.Drawing.Size(174, 76)
        Me.TypeRouteButton.TabIndex = 4
        Me.TypeRouteButton.Text = "Type of Route"
        Me.TypeRouteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TypeRouteButton.UseVisualStyleBackColor = True
        '
        'TypeBrandButton
        '
        Me.TypeBrandButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeBrandButton.Image = CType(resources.GetObject("TypeBrandButton.Image"), System.Drawing.Image)
        Me.TypeBrandButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TypeBrandButton.Location = New System.Drawing.Point(3, 658)
        Me.TypeBrandButton.Name = "TypeBrandButton"
        Me.TypeBrandButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.TypeBrandButton.Size = New System.Drawing.Size(174, 76)
        Me.TypeBrandButton.TabIndex = 8
        Me.TypeBrandButton.Text = "Type of Brand"
        Me.TypeBrandButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TypeBrandButton.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BranchButton.AutoSize = True
        Me.BranchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BranchButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Editdatasetwithdesigner_8449
        Me.BranchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BranchButton.Location = New System.Drawing.Point(3, 3)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BranchButton.Size = New System.Drawing.Size(174, 75)
        Me.BranchButton.TabIndex = 0
        Me.BranchButton.Text = "Branch"
        Me.BranchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'GridDatos
        '
        Me.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.Location = New System.Drawing.Point(180, 50)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.Size = New System.Drawing.Size(582, 825)
        Me.GridDatos.TabIndex = 16
        '
        'HomEditionUC1
        '
        Me.HomEditionUC1.Dock = System.Windows.Forms.DockStyle.Right
        Me.HomEditionUC1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomEditionUC1.Location = New System.Drawing.Point(762, 50)
        Me.HomEditionUC1.Name = "HomEditionUC1"
        Me.HomEditionUC1.Size = New System.Drawing.Size(510, 825)
        Me.HomEditionUC1.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CountryButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Route_RepresentativeButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TypeRouteButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TypeBrandButton, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TypeOFSalesButton, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.BranchButton, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.825815!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.04912!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01563!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(180, 825)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TypeOFSalesButton
        '
        Me.TypeOFSalesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeOFSalesButton.Image = CType(resources.GetObject("TypeOFSalesButton.Image"), System.Drawing.Image)
        Me.TypeOFSalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TypeOFSalesButton.Location = New System.Drawing.Point(3, 740)
        Me.TypeOFSalesButton.Name = "TypeOFSalesButton"
        Me.TypeOFSalesButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.TypeOFSalesButton.Size = New System.Drawing.Size(174, 82)
        Me.TypeOFSalesButton.TabIndex = 9
        Me.TypeOFSalesButton.Text = "Type of Sales "
        Me.TypeOFSalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TypeOFSalesButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(121, 17)
        Me.StatusLabel.Text = "ToolStripStatusLabel1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 875)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1272, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Key3TextBox
        '
        Me.Key3TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key3TextBox.Location = New System.Drawing.Point(656, 16)
        Me.Key3TextBox.Name = "Key3TextBox"
        Me.Key3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Key3TextBox.TabIndex = 5
        '
        'Key2TextBox
        '
        Me.Key2TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key2TextBox.Location = New System.Drawing.Point(556, 16)
        Me.Key2TextBox.Name = "Key2TextBox"
        Me.Key2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Key2TextBox.TabIndex = 4
        '
        'Key1TextBox
        '
        Me.Key1TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key1TextBox.Location = New System.Drawing.Point(456, 16)
        Me.Key1TextBox.Name = "Key1TextBox"
        Me.Key1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Key1TextBox.TabIndex = 3
        '
        'HTypeLabel
        '
        Me.HTypeLabel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.HTypeLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.HTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTypeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HTypeLabel.Location = New System.Drawing.Point(841, 0)
        Me.HTypeLabel.Name = "HTypeLabel"
        Me.HTypeLabel.Size = New System.Drawing.Size(431, 50)
        Me.HTypeLabel.TabIndex = 2
        Me.HTypeLabel.Text = "Brand &&  Category"
        Me.HTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "System"
        '
        'cboSystemId
        '
        Me.cboSystemId.FormattingEnabled = True
        Me.cboSystemId.Location = New System.Drawing.Point(82, 14)
        Me.cboSystemId.Name = "cboSystemId"
        Me.cboSystemId.Size = New System.Drawing.Size(298, 21)
        Me.cboSystemId.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Key3TextBox)
        Me.Panel1.Controls.Add(Me.Key2TextBox)
        Me.Panel1.Controls.Add(Me.Key1TextBox)
        Me.Panel1.Controls.Add(Me.HTypeLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboSystemId)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1272, 50)
        Me.Panel1.TabIndex = 12
        '
        'GeographyHomologationMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 897)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.HomEditionUC1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "GeographyHomologationMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GeographyHomologationMainForm"
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountryButton As System.Windows.Forms.Button
    Friend WithEvents DistrictButton As System.Windows.Forms.Button
    Friend WithEvents Route_RepresentativeButton As System.Windows.Forms.Button
    Friend WithEvents TypeRouteButton As System.Windows.Forms.Button
    Friend WithEvents TypeBrandButton As System.Windows.Forms.Button
    Friend WithEvents BranchButton As System.Windows.Forms.Button
    Friend WithEvents GridDatos As System.Windows.Forms.DataGridView
    Friend WithEvents HomEditionUC1 As DimensionsConfiguration.HomologationEditionUC
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TypeOFSalesButton As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Key3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Key2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Key1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSystemId As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
