<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsConfigForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsConfigForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RecordCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PaisLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cboNivelQuery = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboPaises = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboTipoBusqueda = New System.Windows.Forms.ToolStripComboBox()
        Me.BuscarLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodeSearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FindButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CboMeasures = New System.Windows.Forms.ToolStripComboBox()
        Me.GridDatos = New System.Windows.Forms.DataGridView()
        Me.PrimaryKeyText = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.RecordCountLabel, Me.PaisLabel, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 735)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1214, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = False
        Me.StatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(260, 17)
        Me.StatusLabel.Text = "Un momento, cargando datos"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RecordCountLabel
        '
        Me.RecordCountLabel.AutoSize = False
        Me.RecordCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.RecordCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.RecordCountLabel.Name = "RecordCountLabel"
        Me.RecordCountLabel.Size = New System.Drawing.Size(100, 17)
        Me.RecordCountLabel.Text = "0 registros"
        '
        'PaisLabel
        '
        Me.PaisLabel.AutoSize = False
        Me.PaisLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.PaisLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.PaisLabel.Name = "PaisLabel"
        Me.PaisLabel.Size = New System.Drawing.Size(120, 17)
        Me.PaisLabel.Text = "Guatemala"
        '
        'PB
        '
        Me.PB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(300, 16)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PB.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cboNivelQuery, Me.ToolStripSeparator1, Me.LoadButton, Me.ToolStripSeparator2, Me.cboPaises, Me.ToolStripSeparator4, Me.cboTipoBusqueda, Me.BuscarLabel, Me.CodeSearchTextBox, Me.FindButton, Me.ToolStripSeparator5, Me.EditButton, Me.ToolStripSeparator3, Me.CboMeasures})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1214, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cboNivelQuery
        '
        Me.cboNivelQuery.DropDownWidth = 200
        Me.cboNivelQuery.Name = "cboNivelQuery"
        Me.cboNivelQuery.Size = New System.Drawing.Size(151, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'LoadButton
        '
        Me.LoadButton.Image = CType(resources.GetObject("LoadButton.Image"), System.Drawing.Image)
        Me.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(94, 22)
        Me.LoadButton.Text = "Cargar datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cboPaises
        '
        Me.cboPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaises.DropDownWidth = 190
        Me.cboPaises.Enabled = False
        Me.cboPaises.Name = "cboPaises"
        Me.cboPaises.Size = New System.Drawing.Size(121, 25)
        Me.cboPaises.Text = Global.DimensionsConfiguration.My.MySettings.Default.CboPaises
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cboTipoBusqueda
        '
        Me.cboTipoBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoBusqueda.DropDownWidth = 200
        Me.cboTipoBusqueda.Enabled = False
        Me.cboTipoBusqueda.Name = "cboTipoBusqueda"
        Me.cboTipoBusqueda.Size = New System.Drawing.Size(151, 25)
        '
        'BuscarLabel
        '
        Me.BuscarLabel.Name = "BuscarLabel"
        Me.BuscarLabel.Size = New System.Drawing.Size(93, 22)
        Me.BuscarLabel.Text = "Ingrese codigo>"
        '
        'CodeSearchTextBox
        '
        Me.CodeSearchTextBox.BackColor = System.Drawing.Color.Lavender
        Me.CodeSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodeSearchTextBox.Enabled = False
        Me.CodeSearchTextBox.Name = "CodeSearchTextBox"
        Me.CodeSearchTextBox.Size = New System.Drawing.Size(180, 25)
        '
        'FindButton
        '
        Me.FindButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.Find_5650_32
        Me.FindButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(23, 22)
        Me.FindButton.ToolTipText = "Iniciar búsqueda"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(134, 22)
        Me.EditButton.Text = "Edición de producto"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CboMeasures
        '
        Me.CboMeasures.DropDownWidth = 190
        Me.CboMeasures.Name = "CboMeasures"
        Me.CboMeasures.Size = New System.Drawing.Size(160, 25)
        '
        'GridDatos
        '
        Me.GridDatos.AllowUserToAddRows = False
        Me.GridDatos.AllowUserToDeleteRows = False
        Me.GridDatos.AllowUserToOrderColumns = True
        Me.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.Location = New System.Drawing.Point(0, 25)
        Me.GridDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDatos.MultiSelect = False
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.ReadOnly = True
        Me.GridDatos.RowTemplate.Height = 24
        Me.GridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDatos.Size = New System.Drawing.Size(1214, 710)
        Me.GridDatos.TabIndex = 2
        '
        'PrimaryKeyText
        '
        Me.PrimaryKeyText.Location = New System.Drawing.Point(1120, 36)
        Me.PrimaryKeyText.Margin = New System.Windows.Forms.Padding(2)
        Me.PrimaryKeyText.Name = "PrimaryKeyText"
        Me.PrimaryKeyText.Size = New System.Drawing.Size(41, 21)
        Me.PrimaryKeyText.TabIndex = 3
        '
        'ProductsConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 757)
        Me.Controls.Add(Me.PrimaryKeyText)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProductsConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Configuration"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GridDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cboPaises As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboNivelQuery As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LoadButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrimaryKeyText As System.Windows.Forms.TextBox
    Friend WithEvents BuscarLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodeSearchTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboTipoBusqueda As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CboMeasures As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents RecordCountLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PaisLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PB As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents FindButton As System.Windows.Forms.ToolStripButton

End Class
