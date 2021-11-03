<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductEditForm
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
        Me.components = New System.ComponentModel.Container()
        Dim GramsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductEditForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.SAP_ProductCodeText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.cboCategoryID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPresentationID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGroupID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSourceID = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSubCategoryID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboBrandID = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboSubBrandID = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTypeBrandID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboSizeID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboFlavorID = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboTypeSalesID = New System.Windows.Forms.ComboBox()
        Me.Standar_CostText = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PricePointText = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UnitsPerCaseText = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboPOT_StatusID = New System.Windows.Forms.ComboBox()
        Me.ActiveFlagCB = New System.Windows.Forms.CheckBox()
        Me.BrandButton = New System.Windows.Forms.Button()
        Me.SubBrandButton = New System.Windows.Forms.Button()
        Me.TypeOfbrandButton = New System.Windows.Forms.Button()
        Me.SizeButton = New System.Windows.Forms.Button()
        Me.FlavorButton = New System.Windows.Forms.Button()
        Me.POT_StatusButton = New System.Windows.Forms.Button()
        Me.PresentationButton = New System.Windows.Forms.Button()
        Me.GroupButton = New System.Windows.Forms.Button()
        Me.SourceButton = New System.Windows.Forms.Button()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.SubCategoryButton = New System.Windows.Forms.Button()
        Me.TypeOfSalesButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GramsText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UnitsForDistributionText = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        GramsLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GramsLabel
        '
        GramsLabel.AutoSize = True
        GramsLabel.Location = New System.Drawing.Point(63, 23)
        GramsLabel.Name = "GramsLabel"
        GramsLabel.Size = New System.Drawing.Size(52, 17)
        GramsLabel.TabIndex = 0
        GramsLabel.Text = "Grams:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(389, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(532, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(176, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 57)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Código SAP de producto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductIDLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDLabel.ForeColor = System.Drawing.Color.Red
        Me.ProductIDLabel.Location = New System.Drawing.Point(3, 57)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.Size = New System.Drawing.Size(167, 25)
        Me.ProductIDLabel.TabIndex = 3
        Me.ProductIDLabel.Text = "Label4"
        Me.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89796!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10204!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 537.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductIDLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DescriptionLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SAP_ProductCodeText, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.51219!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.4878!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 82)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(389, 57)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(532, 25)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = "Label4"
        Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SAP_ProductCodeText
        '
        Me.SAP_ProductCodeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SAP_ProductCodeText.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAP_ProductCodeText.Location = New System.Drawing.Point(176, 60)
        Me.SAP_ProductCodeText.MaxLength = 15
        Me.SAP_ProductCodeText.Name = "SAP_ProductCodeText"
        Me.SAP_ProductCodeText.Size = New System.Drawing.Size(207, 23)
        Me.SAP_ProductCodeText.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 587)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 37)
        Me.Panel1.TabIndex = 44
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(806, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(106, 32)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Cerrar"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Enabled = False
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(678, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 32)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Guardar"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'cboCategoryID
        '
        Me.cboCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategoryID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboCategoryID.FormattingEnabled = True
        Me.cboCategoryID.Location = New System.Drawing.Point(198, 232)
        Me.cboCategoryID.Name = "cboCategoryID"
        Me.cboCategoryID.Size = New System.Drawing.Size(200, 24)
        Me.cboCategoryID.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Presentation:"
        '
        'cboPresentationID
        '
        Me.cboPresentationID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPresentationID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPresentationID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboPresentationID.FormattingEnabled = True
        Me.cboPresentationID.Location = New System.Drawing.Point(198, 124)
        Me.cboPresentationID.Name = "cboPresentationID"
        Me.cboPresentationID.Size = New System.Drawing.Size(200, 24)
        Me.cboPresentationID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Group:"
        '
        'cboGroupID
        '
        Me.cboGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGroupID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboGroupID.FormattingEnabled = True
        Me.cboGroupID.Location = New System.Drawing.Point(198, 160)
        Me.cboGroupID.Name = "cboGroupID"
        Me.cboGroupID.Size = New System.Drawing.Size(200, 24)
        Me.cboGroupID.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Source:"
        '
        'cboSourceID
        '
        Me.cboSourceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSourceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSourceID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboSourceID.FormattingEnabled = True
        Me.cboSourceID.Location = New System.Drawing.Point(198, 196)
        Me.cboSourceID.Name = "cboSourceID"
        Me.cboSourceID.Size = New System.Drawing.Size(200, 24)
        Me.cboSourceID.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "SubCategory:"
        '
        'cboSubCategoryID
        '
        Me.cboSubCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubCategoryID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboSubCategoryID.FormattingEnabled = True
        Me.cboSubCategoryID.Location = New System.Drawing.Point(198, 268)
        Me.cboSubCategoryID.Name = "cboSubCategoryID"
        Me.cboSubCategoryID.Size = New System.Drawing.Size(200, 24)
        Me.cboSubCategoryID.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(530, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Brand:"
        '
        'cboBrandID
        '
        Me.cboBrandID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBrandID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBrandID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboBrandID.FormattingEnabled = True
        Me.cboBrandID.Location = New System.Drawing.Point(590, 124)
        Me.cboBrandID.Name = "cboBrandID"
        Me.cboBrandID.Size = New System.Drawing.Size(200, 24)
        Me.cboBrandID.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(512, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "SubBrand:"
        '
        'cboSubBrandID
        '
        Me.cboSubBrandID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubBrandID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubBrandID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboSubBrandID.FormattingEnabled = True
        Me.cboSubBrandID.Location = New System.Drawing.Point(590, 160)
        Me.cboSubBrandID.Name = "cboSubBrandID"
        Me.cboSubBrandID.Size = New System.Drawing.Size(200, 24)
        Me.cboSubBrandID.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(506, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "TypeBrand:"
        '
        'cboTypeBrandID
        '
        Me.cboTypeBrandID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTypeBrandID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTypeBrandID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboTypeBrandID.FormattingEnabled = True
        Me.cboTypeBrandID.Location = New System.Drawing.Point(590, 196)
        Me.cboTypeBrandID.Name = "cboTypeBrandID"
        Me.cboTypeBrandID.Size = New System.Drawing.Size(200, 24)
        Me.cboTypeBrandID.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(539, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Size:"
        '
        'cboSizeID
        '
        Me.cboSizeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSizeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSizeID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboSizeID.FormattingEnabled = True
        Me.cboSizeID.Location = New System.Drawing.Point(590, 232)
        Me.cboSizeID.Name = "cboSizeID"
        Me.cboSizeID.Size = New System.Drawing.Size(200, 24)
        Me.cboSizeID.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(528, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Flavor:"
        '
        'cboFlavorID
        '
        Me.cboFlavorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFlavorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFlavorID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboFlavorID.FormattingEnabled = True
        Me.cboFlavorID.Location = New System.Drawing.Point(590, 268)
        Me.cboFlavorID.Name = "cboFlavorID"
        Me.cboFlavorID.Size = New System.Drawing.Size(200, 24)
        Me.cboFlavorID.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(113, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "TypeSales:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboTypeSalesID
        '
        Me.cboTypeSalesID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTypeSalesID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTypeSalesID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboTypeSalesID.FormattingEnabled = True
        Me.cboTypeSalesID.Location = New System.Drawing.Point(198, 302)
        Me.cboTypeSalesID.Name = "cboTypeSalesID"
        Me.cboTypeSalesID.Size = New System.Drawing.Size(200, 24)
        Me.cboTypeSalesID.TabIndex = 16
        '
        'Standar_CostText
        '
        Me.Standar_CostText.Location = New System.Drawing.Point(124, 57)
        Me.Standar_CostText.Name = "Standar_CostText"
        Me.Standar_CostText.Size = New System.Drawing.Size(100, 23)
        Me.Standar_CostText.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Standard Cost:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PricePointText
        '
        Me.PricePointText.Location = New System.Drawing.Point(198, 358)
        Me.PricePointText.Name = "PricePointText"
        Me.PricePointText.Size = New System.Drawing.Size(100, 23)
        Me.PricePointText.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(129, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Price Point:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UnitsPerCaseText
        '
        Me.UnitsPerCaseText.Location = New System.Drawing.Point(198, 384)
        Me.UnitsPerCaseText.Name = "UnitsPerCaseText"
        Me.UnitsPerCaseText.Size = New System.Drawing.Size(100, 23)
        Me.UnitsPerCaseText.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(106, 388)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Units Per Case:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(501, 306)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 17)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "POT_Status:"
        '
        'cboPOT_StatusID
        '
        Me.cboPOT_StatusID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPOT_StatusID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPOT_StatusID.BackColor = System.Drawing.SystemColors.Window
        Me.cboPOT_StatusID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboPOT_StatusID.FormattingEnabled = True
        Me.cboPOT_StatusID.Location = New System.Drawing.Point(590, 302)
        Me.cboPOT_StatusID.Name = "cboPOT_StatusID"
        Me.cboPOT_StatusID.Size = New System.Drawing.Size(200, 24)
        Me.cboPOT_StatusID.TabIndex = 34
        '
        'ActiveFlagCB
        '
        Me.ActiveFlagCB.AutoSize = True
        Me.ActiveFlagCB.Location = New System.Drawing.Point(79, 460)
        Me.ActiveFlagCB.Name = "ActiveFlagCB"
        Me.ActiveFlagCB.Size = New System.Drawing.Size(95, 21)
        Me.ActiveFlagCB.TabIndex = 43
        Me.ActiveFlagCB.Text = "Active Flag"
        Me.ActiveFlagCB.UseVisualStyleBackColor = True
        '
        'BrandButton
        '
        Me.BrandButton.Image = CType(resources.GetObject("BrandButton.Image"), System.Drawing.Image)
        Me.BrandButton.Location = New System.Drawing.Point(794, 122)
        Me.BrandButton.Name = "BrandButton"
        Me.BrandButton.Size = New System.Drawing.Size(32, 24)
        Me.BrandButton.TabIndex = 20
        Me.BrandButton.TabStop = False
        Me.BrandButton.UseVisualStyleBackColor = True
        '
        'SubBrandButton
        '
        Me.SubBrandButton.Image = CType(resources.GetObject("SubBrandButton.Image"), System.Drawing.Image)
        Me.SubBrandButton.Location = New System.Drawing.Point(794, 158)
        Me.SubBrandButton.Name = "SubBrandButton"
        Me.SubBrandButton.Size = New System.Drawing.Size(32, 24)
        Me.SubBrandButton.TabIndex = 23
        Me.SubBrandButton.TabStop = False
        Me.SubBrandButton.UseVisualStyleBackColor = True
        '
        'TypeOfbrandButton
        '
        Me.TypeOfbrandButton.Image = CType(resources.GetObject("TypeOfbrandButton.Image"), System.Drawing.Image)
        Me.TypeOfbrandButton.Location = New System.Drawing.Point(794, 194)
        Me.TypeOfbrandButton.Name = "TypeOfbrandButton"
        Me.TypeOfbrandButton.Size = New System.Drawing.Size(32, 24)
        Me.TypeOfbrandButton.TabIndex = 26
        Me.TypeOfbrandButton.TabStop = False
        Me.TypeOfbrandButton.UseVisualStyleBackColor = True
        '
        'SizeButton
        '
        Me.SizeButton.Image = CType(resources.GetObject("SizeButton.Image"), System.Drawing.Image)
        Me.SizeButton.Location = New System.Drawing.Point(794, 230)
        Me.SizeButton.Name = "SizeButton"
        Me.SizeButton.Size = New System.Drawing.Size(32, 24)
        Me.SizeButton.TabIndex = 29
        Me.SizeButton.TabStop = False
        Me.SizeButton.UseVisualStyleBackColor = True
        '
        'FlavorButton
        '
        Me.FlavorButton.Image = CType(resources.GetObject("FlavorButton.Image"), System.Drawing.Image)
        Me.FlavorButton.Location = New System.Drawing.Point(794, 266)
        Me.FlavorButton.Name = "FlavorButton"
        Me.FlavorButton.Size = New System.Drawing.Size(32, 24)
        Me.FlavorButton.TabIndex = 32
        Me.FlavorButton.TabStop = False
        Me.FlavorButton.UseVisualStyleBackColor = True
        '
        'POT_StatusButton
        '
        Me.POT_StatusButton.Image = CType(resources.GetObject("POT_StatusButton.Image"), System.Drawing.Image)
        Me.POT_StatusButton.Location = New System.Drawing.Point(794, 300)
        Me.POT_StatusButton.Name = "POT_StatusButton"
        Me.POT_StatusButton.Size = New System.Drawing.Size(32, 24)
        Me.POT_StatusButton.TabIndex = 35
        Me.POT_StatusButton.TabStop = False
        Me.POT_StatusButton.UseVisualStyleBackColor = True
        '
        'PresentationButton
        '
        Me.PresentationButton.Image = CType(resources.GetObject("PresentationButton.Image"), System.Drawing.Image)
        Me.PresentationButton.Location = New System.Drawing.Point(403, 122)
        Me.PresentationButton.Name = "PresentationButton"
        Me.PresentationButton.Size = New System.Drawing.Size(32, 24)
        Me.PresentationButton.TabIndex = 2
        Me.PresentationButton.TabStop = False
        Me.PresentationButton.UseVisualStyleBackColor = True
        '
        'GroupButton
        '
        Me.GroupButton.Image = CType(resources.GetObject("GroupButton.Image"), System.Drawing.Image)
        Me.GroupButton.Location = New System.Drawing.Point(403, 158)
        Me.GroupButton.Name = "GroupButton"
        Me.GroupButton.Size = New System.Drawing.Size(32, 24)
        Me.GroupButton.TabIndex = 5
        Me.GroupButton.TabStop = False
        Me.GroupButton.UseVisualStyleBackColor = True
        '
        'SourceButton
        '
        Me.SourceButton.Image = CType(resources.GetObject("SourceButton.Image"), System.Drawing.Image)
        Me.SourceButton.Location = New System.Drawing.Point(403, 194)
        Me.SourceButton.Name = "SourceButton"
        Me.SourceButton.Size = New System.Drawing.Size(32, 24)
        Me.SourceButton.TabIndex = 8
        Me.SourceButton.TabStop = False
        Me.SourceButton.UseVisualStyleBackColor = True
        '
        'CategoryButton
        '
        Me.CategoryButton.Image = CType(resources.GetObject("CategoryButton.Image"), System.Drawing.Image)
        Me.CategoryButton.Location = New System.Drawing.Point(403, 230)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(32, 24)
        Me.CategoryButton.TabIndex = 11
        Me.CategoryButton.TabStop = False
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'SubCategoryButton
        '
        Me.SubCategoryButton.Image = CType(resources.GetObject("SubCategoryButton.Image"), System.Drawing.Image)
        Me.SubCategoryButton.Location = New System.Drawing.Point(403, 266)
        Me.SubCategoryButton.Name = "SubCategoryButton"
        Me.SubCategoryButton.Size = New System.Drawing.Size(32, 24)
        Me.SubCategoryButton.TabIndex = 14
        Me.SubCategoryButton.TabStop = False
        Me.SubCategoryButton.UseVisualStyleBackColor = True
        '
        'TypeOfSalesButton
        '
        Me.TypeOfSalesButton.Image = CType(resources.GetObject("TypeOfSalesButton.Image"), System.Drawing.Image)
        Me.TypeOfSalesButton.Location = New System.Drawing.Point(403, 300)
        Me.TypeOfSalesButton.Name = "TypeOfSalesButton"
        Me.TypeOfSalesButton.Size = New System.Drawing.Size(32, 24)
        Me.TypeOfSalesButton.TabIndex = 17
        Me.TypeOfSalesButton.TabStop = False
        Me.TypeOfSalesButton.UseVisualStyleBackColor = True
        '
        'GramsText
        '
        Me.GramsText.Location = New System.Drawing.Point(124, 23)
        Me.GramsText.Name = "GramsText"
        Me.GramsText.Size = New System.Drawing.Size(100, 23)
        Me.GramsText.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GramsText)
        Me.Panel2.Controls.Add(GramsLabel)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Standar_CostText)
        Me.Panel2.Location = New System.Drawing.Point(517, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 100)
        Me.Panel2.TabIndex = 42
        '
        'UnitsForDistributionText
        '
        Me.UnitsForDistributionText.Location = New System.Drawing.Point(198, 410)
        Me.UnitsForDistributionText.Name = "UnitsForDistributionText"
        Me.UnitsForDistributionText.Size = New System.Drawing.Size(100, 23)
        Me.UnitsForDistributionText.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(76, 414)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 17)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Units For Distribution:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Location = New System.Drawing.Point(520, 464)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(0, 17)
        Me.lblFechaActual.TabIndex = 45
        '
        'ProductEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 624)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.UnitsForDistributionText)
        Me.Controls.Add(Me.PricePointText)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TypeOfSalesButton)
        Me.Controls.Add(Me.UnitsPerCaseText)
        Me.Controls.Add(Me.SubCategoryButton)
        Me.Controls.Add(Me.CategoryButton)
        Me.Controls.Add(Me.SourceButton)
        Me.Controls.Add(Me.GroupButton)
        Me.Controls.Add(Me.PresentationButton)
        Me.Controls.Add(Me.POT_StatusButton)
        Me.Controls.Add(Me.FlavorButton)
        Me.Controls.Add(Me.SizeButton)
        Me.Controls.Add(Me.TypeOfbrandButton)
        Me.Controls.Add(Me.SubBrandButton)
        Me.Controls.Add(Me.BrandButton)
        Me.Controls.Add(Me.ActiveFlagCB)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboPOT_StatusID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboTypeSalesID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboFlavorID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboSizeID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboTypeBrandID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboSubBrandID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboBrandID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboSubCategoryID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSourceID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboGroupID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPresentationID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCategoryID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ProductEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProductIDLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents cboCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPresentationID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboGroupID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboSourceID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSubCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboBrandID As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboSubBrandID As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTypeBrandID As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboSizeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboFlavorID As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboTypeSalesID As System.Windows.Forms.ComboBox
    Friend WithEvents Standar_CostText As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PricePointText As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UnitsPerCaseText As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboPOT_StatusID As System.Windows.Forms.ComboBox
    Friend WithEvents ActiveFlagCB As System.Windows.Forms.CheckBox
    Friend WithEvents BrandButton As System.Windows.Forms.Button
    Friend WithEvents SubBrandButton As System.Windows.Forms.Button
    Friend WithEvents TypeOfbrandButton As System.Windows.Forms.Button
    Friend WithEvents SizeButton As System.Windows.Forms.Button
    Friend WithEvents FlavorButton As System.Windows.Forms.Button
    Friend WithEvents POT_StatusButton As System.Windows.Forms.Button
    Friend WithEvents PresentationButton As System.Windows.Forms.Button
    Friend WithEvents GroupButton As System.Windows.Forms.Button
    Friend WithEvents SourceButton As System.Windows.Forms.Button
    Friend WithEvents CategoryButton As System.Windows.Forms.Button
    Friend WithEvents SubCategoryButton As System.Windows.Forms.Button
    Friend WithEvents TypeOfSalesButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GramsText As System.Windows.Forms.TextBox
    Friend WithEvents SAP_ProductCodeText As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UnitsForDistributionText As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblFechaActual As System.Windows.Forms.Label
End Class
