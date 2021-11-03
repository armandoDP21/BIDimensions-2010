<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeographyEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeographyEditForm))
        Me.RouteIDText = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MUIDButton = New System.Windows.Forms.Button()
        Me.DistrictButton = New System.Windows.Forms.Button()
        Me.BranchButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ZoneButton = New System.Windows.Forms.Button()
        Me.TypeRouteButton = New System.Windows.Forms.Button()
        Me.RSRIdButton = New System.Windows.Forms.Button()
        Me.FlagActiveCB = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboZoneID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTypeRouteID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboMUID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDistrictID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBranchID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboRSRId = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CountryIDLabel = New System.Windows.Forms.Label()
        Me.CountryNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SystemOnlyCB = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RouteIDText
        '
        Me.RouteIDText.Location = New System.Drawing.Point(668, 210)
        Me.RouteIDText.Name = "RouteIDText"
        Me.RouteIDText.Size = New System.Drawing.Size(100, 20)
        Me.RouteIDText.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(599, 214)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "RouteID:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MUIDButton
        '
        Me.MUIDButton.Image = CType(resources.GetObject("MUIDButton.Image"), System.Drawing.Image)
        Me.MUIDButton.Location = New System.Drawing.Point(441, 284)
        Me.MUIDButton.Name = "MUIDButton"
        Me.MUIDButton.Size = New System.Drawing.Size(32, 24)
        Me.MUIDButton.TabIndex = 54
        Me.MUIDButton.TabStop = False
        Me.MUIDButton.UseVisualStyleBackColor = True
        '
        'DistrictButton
        '
        Me.DistrictButton.Image = CType(resources.GetObject("DistrictButton.Image"), System.Drawing.Image)
        Me.DistrictButton.Location = New System.Drawing.Point(441, 248)
        Me.DistrictButton.Name = "DistrictButton"
        Me.DistrictButton.Size = New System.Drawing.Size(32, 24)
        Me.DistrictButton.TabIndex = 51
        Me.DistrictButton.TabStop = False
        Me.DistrictButton.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Image = CType(resources.GetObject("BranchButton.Image"), System.Drawing.Image)
        Me.BranchButton.Location = New System.Drawing.Point(441, 212)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(32, 24)
        Me.BranchButton.TabIndex = 47
        Me.BranchButton.TabStop = False
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'ZoneButton
        '
        Me.ZoneButton.Image = CType(resources.GetObject("ZoneButton.Image"), System.Drawing.Image)
        Me.ZoneButton.Location = New System.Drawing.Point(441, 390)
        Me.ZoneButton.Name = "ZoneButton"
        Me.ZoneButton.Size = New System.Drawing.Size(32, 24)
        Me.ZoneButton.TabIndex = 63
        Me.ZoneButton.TabStop = False
        Me.ZoneButton.UseVisualStyleBackColor = True
        '
        'TypeRouteButton
        '
        Me.TypeRouteButton.Image = CType(resources.GetObject("TypeRouteButton.Image"), System.Drawing.Image)
        Me.TypeRouteButton.Location = New System.Drawing.Point(441, 356)
        Me.TypeRouteButton.Name = "TypeRouteButton"
        Me.TypeRouteButton.Size = New System.Drawing.Size(32, 24)
        Me.TypeRouteButton.TabIndex = 60
        Me.TypeRouteButton.TabStop = False
        Me.TypeRouteButton.UseVisualStyleBackColor = True
        '
        'RSRIdButton
        '
        Me.RSRIdButton.Image = CType(resources.GetObject("RSRIdButton.Image"), System.Drawing.Image)
        Me.RSRIdButton.Location = New System.Drawing.Point(441, 320)
        Me.RSRIdButton.Name = "RSRIdButton"
        Me.RSRIdButton.Size = New System.Drawing.Size(32, 24)
        Me.RSRIdButton.TabIndex = 57
        Me.RSRIdButton.TabStop = False
        Me.RSRIdButton.UseVisualStyleBackColor = True
        '
        'FlagActiveCB
        '
        Me.FlagActiveCB.AutoSize = True
        Me.FlagActiveCB.Location = New System.Drawing.Point(668, 246)
        Me.FlagActiveCB.Name = "FlagActiveCB"
        Me.FlagActiveCB.Size = New System.Drawing.Size(79, 17)
        Me.FlagActiveCB.TabIndex = 89
        Me.FlagActiveCB.Text = "Active Flag"
        Me.FlagActiveCB.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 395)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Zone:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboZoneID
        '
        Me.cboZoneID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboZoneID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboZoneID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboZoneID.FormattingEnabled = True
        Me.cboZoneID.Location = New System.Drawing.Point(236, 392)
        Me.cboZoneID.Name = "cboZoneID"
        Me.cboZoneID.Size = New System.Drawing.Size(200, 21)
        Me.cboZoneID.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(151, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 57)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pais"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Type Route:"
        '
        'cboTypeRouteID
        '
        Me.cboTypeRouteID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTypeRouteID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTypeRouteID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboTypeRouteID.FormattingEnabled = True
        Me.cboTypeRouteID.Location = New System.Drawing.Point(236, 358)
        Me.cboTypeRouteID.Name = "cboTypeRouteID"
        Me.cboTypeRouteID.Size = New System.Drawing.Size(200, 21)
        Me.cboTypeRouteID.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "MUID:"
        '
        'cboMUID
        '
        Me.cboMUID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMUID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMUID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboMUID.FormattingEnabled = True
        Me.cboMUID.Location = New System.Drawing.Point(236, 286)
        Me.cboMUID.Name = "cboMUID"
        Me.cboMUID.Size = New System.Drawing.Size(200, 21)
        Me.cboMUID.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "District:"
        '
        'cboDistrictID
        '
        Me.cboDistrictID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDistrictID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDistrictID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboDistrictID.FormattingEnabled = True
        Me.cboDistrictID.Location = New System.Drawing.Point(236, 250)
        Me.cboDistrictID.Name = "cboDistrictID"
        Me.cboDistrictID.Size = New System.Drawing.Size(200, 21)
        Me.cboDistrictID.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Branch:"
        '
        'cboBranchID
        '
        Me.cboBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBranchID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboBranchID.FormattingEnabled = True
        Me.cboBranchID.Location = New System.Drawing.Point(236, 214)
        Me.cboBranchID.Name = "cboBranchID"
        Me.cboBranchID.Size = New System.Drawing.Size(200, 21)
        Me.cboBranchID.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "RSRId:"
        '
        'cboRSRId
        '
        Me.cboRSRId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRSRId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRSRId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboRSRId.FormattingEnabled = True
        Me.cboRSRId.Location = New System.Drawing.Point(236, 322)
        Me.cboRSRId.Name = "cboRSRId"
        Me.cboRSRId.Size = New System.Drawing.Size(200, 21)
        Me.cboRSRId.TabIndex = 56
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80192!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.19808!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CountryIDLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CountryNameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.51219!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.4878!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 82)
        Me.TableLayoutPanel1.TabIndex = 49
        '
        'CountryIDLabel
        '
        Me.CountryIDLabel.AutoSize = True
        Me.CountryIDLabel.BackColor = System.Drawing.Color.White
        Me.CountryIDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CountryIDLabel.Location = New System.Drawing.Point(3, 57)
        Me.CountryIDLabel.Name = "CountryIDLabel"
        Me.CountryIDLabel.Size = New System.Drawing.Size(142, 25)
        Me.CountryIDLabel.TabIndex = 96
        Me.CountryIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryNameLabel
        '
        Me.CountryNameLabel.BackColor = System.Drawing.Color.White
        Me.CountryNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CountryNameLabel.Location = New System.Drawing.Point(151, 57)
        Me.CountryNameLabel.Name = "CountryNameLabel"
        Me.CountryNameLabel.Size = New System.Drawing.Size(470, 25)
        Me.CountryNameLabel.TabIndex = 95
        Me.CountryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 57)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Country ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SystemOnlyCB
        '
        Me.SystemOnlyCB.AutoSize = True
        Me.SystemOnlyCB.Location = New System.Drawing.Point(668, 269)
        Me.SystemOnlyCB.Name = "SystemOnlyCB"
        Me.SystemOnlyCB.Size = New System.Drawing.Size(84, 17)
        Me.SystemOnlyCB.TabIndex = 91
        Me.SystemOnlyCB.Text = "System Only"
        Me.SystemOnlyCB.UseVisualStyleBackColor = True
        '
        'GeographyEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 624)
        Me.Controls.Add(Me.SystemOnlyCB)
        Me.Controls.Add(Me.RouteIDText)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MUIDButton)
        Me.Controls.Add(Me.DistrictButton)
        Me.Controls.Add(Me.BranchButton)
        Me.Controls.Add(Me.ZoneButton)
        Me.Controls.Add(Me.TypeRouteButton)
        Me.Controls.Add(Me.RSRIdButton)
        Me.Controls.Add(Me.FlagActiveCB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboZoneID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboTypeRouteID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboMUID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboDistrictID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboBranchID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRSRId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GeographyEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GeographyEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RouteIDText As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MUIDButton As System.Windows.Forms.Button
    Friend WithEvents DistrictButton As System.Windows.Forms.Button
    Friend WithEvents BranchButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ZoneButton As System.Windows.Forms.Button
    Friend WithEvents TypeRouteButton As System.Windows.Forms.Button
    Friend WithEvents RSRIdButton As System.Windows.Forms.Button
    Friend WithEvents FlagActiveCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboZoneID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboTypeRouteID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMUID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboDistrictID As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboRSRId As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SystemOnlyCB As System.Windows.Forms.CheckBox
    Friend WithEvents CountryNameLabel As System.Windows.Forms.Label
    Friend WithEvents CountryIDLabel As System.Windows.Forms.Label
End Class
