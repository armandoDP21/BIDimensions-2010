<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerEditForm))
        Me.CreationDateText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EventualKey_ClientText = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Delivery_AreaText = New System.Windows.Forms.TextBox()
        Me.WeeklyDROPSizeText = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ChainButton = New System.Windows.Forms.Button()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LastSalesDateText = New System.Windows.Forms.TextBox()
        Me.Flag_ActiveCB = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.SAP_CustomerCodeText = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCountryID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboChainID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategoryID = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboKeyAccountID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPayMtID = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.KeyAccountButton = New System.Windows.Forms.Button()
        Me.PayMtIDButton = New System.Windows.Forms.Button()
        GramsLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GramsLabel
        '
        GramsLabel.AutoSize = True
        GramsLabel.Location = New System.Drawing.Point(24, 23)
        GramsLabel.Name = "GramsLabel"
        GramsLabel.Size = New System.Drawing.Size(108, 13)
        GramsLabel.TabIndex = 0
        GramsLabel.Text = " Eventual Key_Client:"
        '
        'CreationDateText
        '
        Me.CreationDateText.Location = New System.Drawing.Point(660, 239)
        Me.CreationDateText.Name = "CreationDateText"
        Me.CreationDateText.Size = New System.Drawing.Size(100, 20)
        Me.CreationDateText.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.EventualKey_ClientText)
        Me.Panel2.Controls.Add(GramsLabel)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Delivery_AreaText)
        Me.Panel2.Location = New System.Drawing.Point(541, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 100)
        Me.Panel2.TabIndex = 88
        '
        'EventualKey_ClientText
        '
        Me.EventualKey_ClientText.Location = New System.Drawing.Point(124, 23)
        Me.EventualKey_ClientText.Name = "EventualKey_ClientText"
        Me.EventualKey_ClientText.Size = New System.Drawing.Size(100, 20)
        Me.EventualKey_ClientText.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Delivery Area:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Delivery_AreaText
        '
        Me.Delivery_AreaText.Location = New System.Drawing.Point(124, 57)
        Me.Delivery_AreaText.Name = "Delivery_AreaText"
        Me.Delivery_AreaText.Size = New System.Drawing.Size(100, 20)
        Me.Delivery_AreaText.TabIndex = 3
        '
        'WeeklyDROPSizeText
        '
        Me.WeeklyDROPSizeText.Location = New System.Drawing.Point(660, 187)
        Me.WeeklyDROPSizeText.Name = "WeeklyDROPSizeText"
        Me.WeeklyDROPSizeText.Size = New System.Drawing.Size(100, 20)
        Me.WeeklyDROPSizeText.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(538, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "WeeklyDROPSize:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(560, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Creation Date:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChainButton
        '
        Me.ChainButton.Image = CType(resources.GetObject("ChainButton.Image"), System.Drawing.Image)
        Me.ChainButton.Location = New System.Drawing.Point(432, 223)
        Me.ChainButton.Name = "ChainButton"
        Me.ChainButton.Size = New System.Drawing.Size(32, 24)
        Me.ChainButton.TabIndex = 51
        Me.ChainButton.TabStop = False
        Me.ChainButton.UseVisualStyleBackColor = True
        '
        'CategoryButton
        '
        Me.CategoryButton.Image = CType(resources.GetObject("CategoryButton.Image"), System.Drawing.Image)
        Me.CategoryButton.Location = New System.Drawing.Point(432, 187)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(32, 24)
        Me.CategoryButton.TabIndex = 47
        Me.CategoryButton.TabStop = False
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(550, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Last Sales Date:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LastSalesDateText
        '
        Me.LastSalesDateText.Location = New System.Drawing.Point(660, 213)
        Me.LastSalesDateText.Name = "LastSalesDateText"
        Me.LastSalesDateText.Size = New System.Drawing.Size(100, 20)
        Me.LastSalesDateText.TabIndex = 85
        '
        'Flag_ActiveCB
        '
        Me.Flag_ActiveCB.AutoSize = True
        Me.Flag_ActiveCB.Location = New System.Drawing.Point(541, 289)
        Me.Flag_ActiveCB.Name = "Flag_ActiveCB"
        Me.Flag_ActiveCB.Size = New System.Drawing.Size(79, 17)
        Me.Flag_ActiveCB.TabIndex = 89
        Me.Flag_ActiveCB.Text = "Active Flag"
        Me.Flag_ActiveCB.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(155, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerIDLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLabel.ForeColor = System.Drawing.Color.Red
        Me.CustomerIDLabel.Location = New System.Drawing.Point(3, 57)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(155, 25)
        Me.CustomerIDLabel.TabIndex = 3
        Me.CustomerIDLabel.Text = "Label4"
        Me.CustomerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(164, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 57)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Código SAP de Cliente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(362, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(559, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerNameLabel.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLabel.Location = New System.Drawing.Point(362, 57)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(559, 25)
        Me.CustomerNameLabel.TabIndex = 0
        Me.CustomerNameLabel.Text = "Label4"
        Me.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SAP_CustomerCodeText
        '
        Me.SAP_CustomerCodeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SAP_CustomerCodeText.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAP_CustomerCodeText.Location = New System.Drawing.Point(164, 60)
        Me.SAP_CustomerCodeText.MaxLength = 15
        Me.SAP_CustomerCodeText.Name = "SAP_CustomerCodeText"
        Me.SAP_CustomerCodeText.Size = New System.Drawing.Size(192, 20)
        Me.SAP_CustomerCodeText.TabIndex = 3
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Country:"
        '
        'cboCountryID
        '
        Me.cboCountryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCountryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCountryID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboCountryID.FormattingEnabled = True
        Me.cboCountryID.Location = New System.Drawing.Point(227, 261)
        Me.cboCountryID.Name = "cboCountryID"
        Me.cboCountryID.Size = New System.Drawing.Size(200, 21)
        Me.cboCountryID.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Chain:"
        '
        'cboChainID
        '
        Me.cboChainID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboChainID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboChainID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboChainID.FormattingEnabled = True
        Me.cboChainID.Location = New System.Drawing.Point(227, 225)
        Me.cboChainID.Name = "cboChainID"
        Me.cboChainID.Size = New System.Drawing.Size(200, 21)
        Me.cboChainID.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Category:"
        '
        'cboCategoryID
        '
        Me.cboCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategoryID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboCategoryID.FormattingEnabled = True
        Me.cboCategoryID.Location = New System.Drawing.Point(227, 189)
        Me.cboCategoryID.Name = "cboCategoryID"
        Me.cboCategoryID.Size = New System.Drawing.Size(200, 21)
        Me.cboCategoryID.TabIndex = 46
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
        Me.Panel1.TabIndex = 90
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89796!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10204!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 564.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomerIDLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomerNameLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SAP_CustomerCodeText, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.51219!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.4878!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 82)
        Me.TableLayoutPanel1.TabIndex = 49
        '
        'cboKeyAccountID
        '
        Me.cboKeyAccountID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKeyAccountID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKeyAccountID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboKeyAccountID.FormattingEnabled = True
        Me.cboKeyAccountID.Location = New System.Drawing.Point(227, 297)
        Me.cboKeyAccountID.Name = "cboKeyAccountID"
        Me.cboKeyAccountID.Size = New System.Drawing.Size(200, 21)
        Me.cboKeyAccountID.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Key Account:"
        '
        'cboPayMtID
        '
        Me.cboPayMtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPayMtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPayMtID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboPayMtID.FormattingEnabled = True
        Me.cboPayMtID.Location = New System.Drawing.Point(227, 333)
        Me.cboPayMtID.Name = "cboPayMtID"
        Me.cboPayMtID.Size = New System.Drawing.Size(200, 21)
        Me.cboPayMtID.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Pay Mt Method:"
        '
        'KeyAccountButton
        '
        Me.KeyAccountButton.Image = CType(resources.GetObject("KeyAccountButton.Image"), System.Drawing.Image)
        Me.KeyAccountButton.Location = New System.Drawing.Point(432, 295)
        Me.KeyAccountButton.Name = "KeyAccountButton"
        Me.KeyAccountButton.Size = New System.Drawing.Size(32, 24)
        Me.KeyAccountButton.TabIndex = 57
        Me.KeyAccountButton.TabStop = False
        Me.KeyAccountButton.UseVisualStyleBackColor = True
        '
        'PayMtIDButton
        '
        Me.PayMtIDButton.Image = CType(resources.GetObject("PayMtIDButton.Image"), System.Drawing.Image)
        Me.PayMtIDButton.Location = New System.Drawing.Point(432, 331)
        Me.PayMtIDButton.Name = "PayMtIDButton"
        Me.PayMtIDButton.Size = New System.Drawing.Size(32, 24)
        Me.PayMtIDButton.TabIndex = 60
        Me.PayMtIDButton.TabStop = False
        Me.PayMtIDButton.UseVisualStyleBackColor = True
        '
        'CustomerEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 624)
        Me.Controls.Add(Me.CreationDateText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WeeklyDROPSizeText)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ChainButton)
        Me.Controls.Add(Me.CategoryButton)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LastSalesDateText)
        Me.Controls.Add(Me.PayMtIDButton)
        Me.Controls.Add(Me.KeyAccountButton)
        Me.Controls.Add(Me.Flag_ActiveCB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboPayMtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboCountryID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboChainID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCategoryID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKeyAccountID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CustomerEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerEditForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreationDateText As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EventualKey_ClientText As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Delivery_AreaText As System.Windows.Forms.TextBox
    Friend WithEvents WeeklyDROPSizeText As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChainButton As System.Windows.Forms.Button
    Friend WithEvents CategoryButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LastSalesDateText As System.Windows.Forms.TextBox
    Friend WithEvents Flag_ActiveCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerIDLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameLabel As System.Windows.Forms.Label
    Friend WithEvents SAP_CustomerCodeText As System.Windows.Forms.TextBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCountryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboChainID As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboKeyAccountID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPayMtID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents KeyAccountButton As System.Windows.Forms.Button
    Friend WithEvents PayMtIDButton As System.Windows.Forms.Button
End Class
