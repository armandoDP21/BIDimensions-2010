<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersConfigForm
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
        Me.PrimaryKeyText = New System.Windows.Forms.TextBox()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.PaisLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RecordCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboMeasures = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBoxClearButton = New System.Windows.Forms.Button()
        Me.NombreRB = New System.Windows.Forms.RadioButton()
        Me.IdSAPRB = New System.Windows.Forms.RadioButton()
        Me.IdLegadoRB = New System.Windows.Forms.RadioButton()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboPayMtID = New System.Windows.Forms.ComboBox()
        Me.cboCategoryID = New System.Windows.Forms.ComboBox()
        Me.cboChainID = New System.Windows.Forms.ComboBox()
        Me.cboKeyAccountID = New System.Windows.Forms.ComboBox()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.cboPaises = New System.Windows.Forms.ComboBox()
        Me.GridDatos = New System.Windows.Forms.DataGridView()
        Me.KeyAccountCB = New System.Windows.Forms.CheckBox()
        Me.PaymentMethodCB = New System.Windows.Forms.CheckBox()
        Me.ChainCB = New System.Windows.Forms.CheckBox()
        Me.CategoryCB = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrimaryKeyText
        '
        Me.PrimaryKeyText.Location = New System.Drawing.Point(1035, 84)
        Me.PrimaryKeyText.Margin = New System.Windows.Forms.Padding(2)
        Me.PrimaryKeyText.Name = "PrimaryKeyText"
        Me.PrimaryKeyText.Size = New System.Drawing.Size(41, 21)
        Me.PrimaryKeyText.TabIndex = 7
        '
        'PB
        '
        Me.PB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(300, 16)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PB.Visible = False
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
        'RecordCountLabel
        '
        Me.RecordCountLabel.AutoSize = False
        Me.RecordCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.RecordCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.RecordCountLabel.Name = "RecordCountLabel"
        Me.RecordCountLabel.Size = New System.Drawing.Size(100, 17)
        Me.RecordCountLabel.Text = "0 registros"
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.RecordCountLabel, Me.PaisLabel, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 735)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 735)
        Me.Panel4.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.CboMeasures)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 492)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 100)
        Me.Panel3.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Medidas:"
        '
        'CboMeasures
        '
        Me.CboMeasures.FormattingEnabled = True
        Me.CboMeasures.Location = New System.Drawing.Point(24, 48)
        Me.CboMeasures.Name = "CboMeasures"
        Me.CboMeasures.Size = New System.Drawing.Size(168, 21)
        Me.CboMeasures.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Moccasin
        Me.Panel2.Controls.Add(Me.SearchTextBoxClearButton)
        Me.Panel2.Controls.Add(Me.NombreRB)
        Me.Panel2.Controls.Add(Me.IdSAPRB)
        Me.Panel2.Controls.Add(Me.IdLegadoRB)
        Me.Panel2.Controls.Add(Me.LoadButton)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.SearchTextBox)
        Me.Panel2.Controls.Add(Me.BuscarLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 301)
        Me.Panel2.TabIndex = 12
        '
        'SearchTextBoxClearButton
        '
        Me.SearchTextBoxClearButton.BackColor = System.Drawing.Color.White
        Me.SearchTextBoxClearButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.BreakpointEnabled_6584_16x1
        Me.SearchTextBoxClearButton.Location = New System.Drawing.Point(232, 120)
        Me.SearchTextBoxClearButton.Name = "SearchTextBoxClearButton"
        Me.SearchTextBoxClearButton.Size = New System.Drawing.Size(29, 21)
        Me.SearchTextBoxClearButton.TabIndex = 6
        Me.SearchTextBoxClearButton.UseVisualStyleBackColor = False
        '
        'NombreRB
        '
        Me.NombreRB.AutoSize = True
        Me.NombreRB.Location = New System.Drawing.Point(66, 76)
        Me.NombreRB.Name = "NombreRB"
        Me.NombreRB.Size = New System.Drawing.Size(116, 17)
        Me.NombreRB.TabIndex = 5
        Me.NombreRB.Text = "Buscar por Nombre"
        Me.NombreRB.UseVisualStyleBackColor = True
        '
        'IdSAPRB
        '
        Me.IdSAPRB.AutoSize = True
        Me.IdSAPRB.Location = New System.Drawing.Point(66, 53)
        Me.IdSAPRB.Name = "IdSAPRB"
        Me.IdSAPRB.Size = New System.Drawing.Size(112, 17)
        Me.IdSAPRB.TabIndex = 5
        Me.IdSAPRB.Text = "Buscar por ID SAP"
        Me.IdSAPRB.UseVisualStyleBackColor = True
        '
        'IdLegadoRB
        '
        Me.IdLegadoRB.AutoSize = True
        Me.IdLegadoRB.Location = New System.Drawing.Point(66, 30)
        Me.IdLegadoRB.Name = "IdLegadoRB"
        Me.IdLegadoRB.Size = New System.Drawing.Size(128, 17)
        Me.IdLegadoRB.TabIndex = 5
        Me.IdLegadoRB.Text = "Buscar por ID legado "
        Me.IdLegadoRB.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.BreakpointEnabled_6584_16x
        Me.LoadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoadButton.Location = New System.Drawing.Point(42, 159)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(225, 43)
        Me.LoadButton.TabIndex = 4
        Me.LoadButton.Text = "Cargar datos"
        Me.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Image = Global.DimensionsConfiguration.My.Resources.Resources.PencilAngled_32xLG_color
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(42, 208)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(225, 43)
        Me.EditButton.TabIndex = 4
        Me.EditButton.Text = "Edición de producto"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Enabled = False
        Me.SearchTextBox.Location = New System.Drawing.Point(64, 120)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(163, 21)
        Me.SearchTextBox.TabIndex = 3
        '
        'BuscarLabel
        '
        Me.BuscarLabel.AutoSize = True
        Me.BuscarLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarLabel.Location = New System.Drawing.Point(12, 120)
        Me.BuscarLabel.Name = "BuscarLabel"
        Me.BuscarLabel.Size = New System.Drawing.Size(46, 14)
        Me.BuscarLabel.TabIndex = 2
        Me.BuscarLabel.Text = "Ninguno"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CategoryCB)
        Me.Panel1.Controls.Add(Me.ChainCB)
        Me.Panel1.Controls.Add(Me.PaymentMethodCB)
        Me.Panel1.Controls.Add(Me.KeyAccountCB)
        Me.Panel1.Controls.Add(Me.cboPayMtID)
        Me.Panel1.Controls.Add(Me.cboCategoryID)
        Me.Panel1.Controls.Add(Me.cboChainID)
        Me.Panel1.Controls.Add(Me.cboKeyAccountID)
        Me.Panel1.Controls.Add(Me.CountryLabel)
        Me.Panel1.Controls.Add(Me.cboPaises)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 191)
        Me.Panel1.TabIndex = 11
        '
        'cboPayMtID
        '
        Me.cboPayMtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPayMtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPayMtID.FormattingEnabled = True
        Me.cboPayMtID.Location = New System.Drawing.Point(114, 81)
        Me.cboPayMtID.Name = "cboPayMtID"
        Me.cboPayMtID.Size = New System.Drawing.Size(134, 21)
        Me.cboPayMtID.TabIndex = 3
        '
        'cboCategoryID
        '
        Me.cboCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategoryID.FormattingEnabled = True
        Me.cboCategoryID.Location = New System.Drawing.Point(114, 139)
        Me.cboCategoryID.Name = "cboCategoryID"
        Me.cboCategoryID.Size = New System.Drawing.Size(134, 21)
        Me.cboCategoryID.TabIndex = 3
        '
        'cboChainID
        '
        Me.cboChainID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboChainID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboChainID.FormattingEnabled = True
        Me.cboChainID.Location = New System.Drawing.Point(114, 110)
        Me.cboChainID.Name = "cboChainID"
        Me.cboChainID.Size = New System.Drawing.Size(134, 21)
        Me.cboChainID.TabIndex = 3
        '
        'cboKeyAccountID
        '
        Me.cboKeyAccountID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKeyAccountID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKeyAccountID.FormattingEnabled = True
        Me.cboKeyAccountID.Location = New System.Drawing.Point(114, 52)
        Me.cboKeyAccountID.Name = "cboKeyAccountID"
        Me.cboKeyAccountID.Size = New System.Drawing.Size(134, 21)
        Me.cboKeyAccountID.TabIndex = 3
        '
        'CountryLabel
        '
        Me.CountryLabel.AutoSize = True
        Me.CountryLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel.Location = New System.Drawing.Point(62, 26)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(48, 14)
        Me.CountryLabel.TabIndex = 1
        Me.CountryLabel.Text = "Country:"
        '
        'cboPaises
        '
        Me.cboPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaises.FormattingEnabled = True
        Me.cboPaises.Location = New System.Drawing.Point(114, 23)
        Me.cboPaises.Name = "cboPaises"
        Me.cboPaises.Size = New System.Drawing.Size(134, 21)
        Me.cboPaises.TabIndex = 0
        '
        'GridDatos
        '
        Me.GridDatos.AllowUserToAddRows = False
        Me.GridDatos.AllowUserToDeleteRows = False
        Me.GridDatos.AllowUserToOrderColumns = True
        Me.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.Location = New System.Drawing.Point(280, 0)
        Me.GridDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDatos.MultiSelect = False
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.ReadOnly = True
        Me.GridDatos.RowTemplate.Height = 24
        Me.GridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDatos.Size = New System.Drawing.Size(1004, 735)
        Me.GridDatos.TabIndex = 12
        '
        'KeyAccountCB
        '
        Me.KeyAccountCB.AutoSize = True
        Me.KeyAccountCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KeyAccountCB.Location = New System.Drawing.Point(16, 54)
        Me.KeyAccountCB.Name = "KeyAccountCB"
        Me.KeyAccountCB.Size = New System.Drawing.Size(90, 17)
        Me.KeyAccountCB.TabIndex = 4
        Me.KeyAccountCB.Text = "Key Account:"
        Me.KeyAccountCB.UseVisualStyleBackColor = True
        '
        'PaymentMethodCB
        '
        Me.PaymentMethodCB.AutoSize = True
        Me.PaymentMethodCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PaymentMethodCB.Location = New System.Drawing.Point(23, 83)
        Me.PaymentMethodCB.Name = "PaymentMethodCB"
        Me.PaymentMethodCB.Size = New System.Drawing.Size(83, 17)
        Me.PaymentMethodCB.TabIndex = 5
        Me.PaymentMethodCB.Text = "PayM Mthd:"
        Me.PaymentMethodCB.UseVisualStyleBackColor = True
        '
        'ChainCB
        '
        Me.ChainCB.AutoSize = True
        Me.ChainCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChainCB.Location = New System.Drawing.Point(49, 112)
        Me.ChainCB.Name = "ChainCB"
        Me.ChainCB.Size = New System.Drawing.Size(57, 17)
        Me.ChainCB.TabIndex = 6
        Me.ChainCB.Text = "Chain:"
        Me.ChainCB.UseVisualStyleBackColor = True
        '
        'CategoryCB
        '
        Me.CategoryCB.AutoSize = True
        Me.CategoryCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CategoryCB.Location = New System.Drawing.Point(31, 141)
        Me.CategoryCB.Name = "CategoryCB"
        Me.CategoryCB.Size = New System.Drawing.Size(75, 17)
        Me.CategoryCB.TabIndex = 7
        Me.CategoryCB.Text = "Category:"
        Me.CategoryCB.UseVisualStyleBackColor = True
        '
        'CustomersConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 757)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PrimaryKeyText)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CustomersConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers Configuration"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrimaryKeyText As System.Windows.Forms.TextBox
    Friend WithEvents PB As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PaisLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RecordCountLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboMeasures As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuscarLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents cboPayMtID As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents cboChainID As System.Windows.Forms.ComboBox
    Friend WithEvents cboKeyAccountID As System.Windows.Forms.ComboBox
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents cboPaises As System.Windows.Forms.ComboBox
    Friend WithEvents GridDatos As System.Windows.Forms.DataGridView
    Friend WithEvents NombreRB As System.Windows.Forms.RadioButton
    Friend WithEvents IdSAPRB As System.Windows.Forms.RadioButton
    Friend WithEvents IdLegadoRB As System.Windows.Forms.RadioButton
    Friend WithEvents SearchTextBoxClearButton As System.Windows.Forms.Button
    Friend WithEvents CategoryCB As System.Windows.Forms.CheckBox
    Friend WithEvents ChainCB As System.Windows.Forms.CheckBox
    Friend WithEvents PaymentMethodCB As System.Windows.Forms.CheckBox
    Friend WithEvents KeyAccountCB As System.Windows.Forms.CheckBox
End Class
