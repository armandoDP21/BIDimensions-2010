<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsHomologationMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsHomologationMainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Key3TextBox = New System.Windows.Forms.TextBox()
        Me.Key2TextBox = New System.Windows.Forms.TextBox()
        Me.Key1TextBox = New System.Windows.Forms.TextBox()
        Me.HTypeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSystemId = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlavorButton = New System.Windows.Forms.Button()
        Me.PresentationButton = New System.Windows.Forms.Button()
        Me.ProductGroupButton = New System.Windows.Forms.Button()
        Me.SizeButton = New System.Windows.Forms.Button()
        Me.SourceButton = New System.Windows.Forms.Button()
        Me.SubBrandButton = New System.Windows.Forms.Button()
        Me.SubCategoryButton = New System.Windows.Forms.Button()
        Me.TypeBrandButton = New System.Windows.Forms.Button()
        Me.TypeOFSalesButton = New System.Windows.Forms.Button()
        Me.BrandCategoryButton = New System.Windows.Forms.Button()
        Me.HomEditionUC1 = New DimensionsConfiguration.HomologationEditionUC()
        Me.GridDatos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
        '
        'Key3TextBox
        '
        Me.Key3TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key3TextBox.Location = New System.Drawing.Point(656, 16)
        Me.Key3TextBox.Name = "Key3TextBox"
        Me.Key3TextBox.Size = New System.Drawing.Size(100, 23)
        Me.Key3TextBox.TabIndex = 5
        '
        'Key2TextBox
        '
        Me.Key2TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key2TextBox.Location = New System.Drawing.Point(556, 16)
        Me.Key2TextBox.Name = "Key2TextBox"
        Me.Key2TextBox.Size = New System.Drawing.Size(100, 23)
        Me.Key2TextBox.TabIndex = 4
        '
        'Key1TextBox
        '
        Me.Key1TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.Key1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Key1TextBox.Location = New System.Drawing.Point(456, 16)
        Me.Key1TextBox.Name = "Key1TextBox"
        Me.Key1TextBox.Size = New System.Drawing.Size(100, 23)
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
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "System"
        '
        'cboSystemId
        '
        Me.cboSystemId.FormattingEnabled = True
        Me.cboSystemId.Location = New System.Drawing.Point(82, 14)
        Me.cboSystemId.Name = "cboSystemId"
        Me.cboSystemId.Size = New System.Drawing.Size(298, 23)
        Me.cboSystemId.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 875)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1272, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(121, 17)
        Me.StatusLabel.Text = "ToolStripStatusLabel1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlavorButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PresentationButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductGroupButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SizeButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SourceButton, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.SubBrandButton, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.SubCategoryButton, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TypeBrandButton, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TypeOFSalesButton, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.BrandCategoryButton, 0, 0)
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
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'FlavorButton
        '
        Me.FlavorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlavorButton.Image = CType(resources.GetObject("FlavorButton.Image"), System.Drawing.Image)
        Me.FlavorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FlavorButton.Location = New System.Drawing.Point(3, 84)
        Me.FlavorButton.Name = "FlavorButton"
        Me.FlavorButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.FlavorButton.Size = New System.Drawing.Size(174, 76)
        Me.FlavorButton.TabIndex = 1
        Me.FlavorButton.Text = "Flavor"
        Me.FlavorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FlavorButton.UseVisualStyleBackColor = True
        '
        'PresentationButton
        '
        Me.PresentationButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PresentationButton.Image = CType(resources.GetObject("PresentationButton.Image"), System.Drawing.Image)
        Me.PresentationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PresentationButton.Location = New System.Drawing.Point(3, 166)
        Me.PresentationButton.Name = "PresentationButton"
        Me.PresentationButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.PresentationButton.Size = New System.Drawing.Size(174, 76)
        Me.PresentationButton.TabIndex = 2
        Me.PresentationButton.Text = "Presentation"
        Me.PresentationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PresentationButton.UseVisualStyleBackColor = True
        '
        'ProductGroupButton
        '
        Me.ProductGroupButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductGroupButton.Image = CType(resources.GetObject("ProductGroupButton.Image"), System.Drawing.Image)
        Me.ProductGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductGroupButton.Location = New System.Drawing.Point(3, 248)
        Me.ProductGroupButton.Name = "ProductGroupButton"
        Me.ProductGroupButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.ProductGroupButton.Size = New System.Drawing.Size(174, 76)
        Me.ProductGroupButton.TabIndex = 3
        Me.ProductGroupButton.Text = "Product Group"
        Me.ProductGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductGroupButton.UseVisualStyleBackColor = True
        '
        'SizeButton
        '
        Me.SizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SizeButton.Image = CType(resources.GetObject("SizeButton.Image"), System.Drawing.Image)
        Me.SizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SizeButton.Location = New System.Drawing.Point(3, 330)
        Me.SizeButton.Name = "SizeButton"
        Me.SizeButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.SizeButton.Size = New System.Drawing.Size(174, 76)
        Me.SizeButton.TabIndex = 4
        Me.SizeButton.Text = "Size"
        Me.SizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SizeButton.UseVisualStyleBackColor = True
        '
        'SourceButton
        '
        Me.SourceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceButton.Image = CType(resources.GetObject("SourceButton.Image"), System.Drawing.Image)
        Me.SourceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SourceButton.Location = New System.Drawing.Point(3, 412)
        Me.SourceButton.Name = "SourceButton"
        Me.SourceButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.SourceButton.Size = New System.Drawing.Size(174, 76)
        Me.SourceButton.TabIndex = 5
        Me.SourceButton.Text = "Source"
        Me.SourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SourceButton.UseVisualStyleBackColor = True
        '
        'SubBrandButton
        '
        Me.SubBrandButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubBrandButton.Image = CType(resources.GetObject("SubBrandButton.Image"), System.Drawing.Image)
        Me.SubBrandButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubBrandButton.Location = New System.Drawing.Point(3, 494)
        Me.SubBrandButton.Name = "SubBrandButton"
        Me.SubBrandButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.SubBrandButton.Size = New System.Drawing.Size(174, 76)
        Me.SubBrandButton.TabIndex = 6
        Me.SubBrandButton.Text = "SubBrand"
        Me.SubBrandButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubBrandButton.UseVisualStyleBackColor = True
        '
        'SubCategoryButton
        '
        Me.SubCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategoryButton.Image = CType(resources.GetObject("SubCategoryButton.Image"), System.Drawing.Image)
        Me.SubCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubCategoryButton.Location = New System.Drawing.Point(3, 576)
        Me.SubCategoryButton.Name = "SubCategoryButton"
        Me.SubCategoryButton.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.SubCategoryButton.Size = New System.Drawing.Size(174, 76)
        Me.SubCategoryButton.TabIndex = 7
        Me.SubCategoryButton.Text = "SubCategory"
        Me.SubCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubCategoryButton.UseVisualStyleBackColor = True
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
        'BrandCategoryButton
        '
        Me.BrandCategoryButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrandCategoryButton.AutoSize = True
        Me.BrandCategoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BrandCategoryButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Editdatasetwithdesigner_8449
        Me.BrandCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrandCategoryButton.Location = New System.Drawing.Point(3, 3)
        Me.BrandCategoryButton.Name = "BrandCategoryButton"
        Me.BrandCategoryButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BrandCategoryButton.Size = New System.Drawing.Size(174, 75)
        Me.BrandCategoryButton.TabIndex = 0
        Me.BrandCategoryButton.Text = "Brand &&  Category"
        Me.BrandCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BrandCategoryButton.UseVisualStyleBackColor = True
        '
        'HomEditionUC1
        '
        Me.HomEditionUC1.Dock = System.Windows.Forms.DockStyle.Right
        Me.HomEditionUC1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomEditionUC1.Location = New System.Drawing.Point(762, 50)
        Me.HomEditionUC1.Name = "HomEditionUC1"
        Me.HomEditionUC1.Size = New System.Drawing.Size(510, 825)
        Me.HomEditionUC1.TabIndex = 10
        '
        'GridDatos
        '
        Me.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.Location = New System.Drawing.Point(180, 50)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.Size = New System.Drawing.Size(582, 825)
        Me.GridDatos.TabIndex = 11
        '
        'ProductsHomologationMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 897)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.HomEditionUC1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ProductsHomologationMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Homologation Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend HomologationEditionUC11 As DimensionsConfiguration.HomologationEditionUC1
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    'Friend WithEvents HomologationEditionUC1 As DimensionsConfiguration.HomologationEditionUC1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSystemId As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlavorButton As System.Windows.Forms.Button
    Friend WithEvents PresentationButton As System.Windows.Forms.Button
    Friend WithEvents ProductGroupButton As System.Windows.Forms.Button
    Friend WithEvents SizeButton As System.Windows.Forms.Button
    Friend WithEvents SourceButton As System.Windows.Forms.Button
    Friend WithEvents SubBrandButton As System.Windows.Forms.Button
    Friend WithEvents SubCategoryButton As System.Windows.Forms.Button
    Friend WithEvents TypeBrandButton As System.Windows.Forms.Button
    Friend WithEvents TypeOFSalesButton As System.Windows.Forms.Button
    Friend WithEvents BrandCategoryButton As System.Windows.Forms.Button
    Friend WithEvents HTypeLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HomEditionUC1 As DimensionsConfiguration.HomologationEditionUC
    Friend WithEvents GridDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Key3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Key2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Key1TextBox As System.Windows.Forms.TextBox
End Class
