<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomologationEditionUC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNames = New System.Windows.Forms.ComboBox()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.M01NameLabel = New System.Windows.Forms.Label()
        Me.HOMNameLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MeasureTypeLabel = New System.Windows.Forms.Label()
        Me.PKLabel = New System.Windows.Forms.Label()
        Me.SystemIDLabel = New System.Windows.Forms.Label()
        Me.SourceCodeLabel = New System.Windows.Forms.Label()
        Me.BrandSourceCodeLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LeftPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(33, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actual:"
        '
        'cboNames
        '
        Me.cboNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNames.FormattingEnabled = True
        Me.cboNames.Location = New System.Drawing.Point(15, 105)
        Me.cboNames.Name = "cboNames"
        Me.cboNames.Size = New System.Drawing.Size(168, 21)
        Me.cboNames.TabIndex = 1
        '
        'cboCategories
        '
        Me.cboCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(15, 105)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(168, 21)
        Me.cboCategories.TabIndex = 2
        '
        'M01NameLabel
        '
        Me.M01NameLabel.AutoSize = True
        Me.M01NameLabel.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M01NameLabel.Location = New System.Drawing.Point(76, 18)
        Me.M01NameLabel.Name = "M01NameLabel"
        Me.M01NameLabel.Size = New System.Drawing.Size(43, 27)
        Me.M01NameLabel.TabIndex = 3
        Me.M01NameLabel.Text = "{   }"
        '
        'HOMNameLabel
        '
        Me.HOMNameLabel.BackColor = System.Drawing.Color.White
        Me.HOMNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HOMNameLabel.Location = New System.Drawing.Point(15, 22)
        Me.HOMNameLabel.Name = "HOMNameLabel"
        Me.HOMNameLabel.Size = New System.Drawing.Size(168, 25)
        Me.HOMNameLabel.TabIndex = 4
        Me.HOMNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CategoryLabel
        '
        Me.CategoryLabel.BackColor = System.Drawing.Color.White
        Me.CategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CategoryLabel.Location = New System.Drawing.Point(15, 22)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(168, 25)
        Me.CategoryLabel.TabIndex = 4
        Me.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftPanel
        '
        Me.LeftPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeftPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LeftPanel.Controls.Add(Me.cboNames)
        Me.LeftPanel.Controls.Add(Me.HOMNameLabel)
        Me.LeftPanel.Enabled = False
        Me.LeftPanel.Location = New System.Drawing.Point(82, 86)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(200, 138)
        Me.LeftPanel.TabIndex = 6
        '
        'RightPanel
        '
        Me.RightPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RightPanel.BackColor = System.Drawing.Color.Lavender
        Me.RightPanel.Controls.Add(Me.CategoryLabel)
        Me.RightPanel.Controls.Add(Me.cboCategories)
        Me.RightPanel.Enabled = False
        Me.RightPanel.Location = New System.Drawing.Point(288, 87)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(200, 138)
        Me.RightPanel.TabIndex = 7
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(207, 230)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Guardar"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cambiar a:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(286, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Category"
        '
        'MeasureTypeLabel
        '
        Me.MeasureTypeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeasureTypeLabel.AutoSize = True
        Me.MeasureTypeLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeasureTypeLabel.ForeColor = System.Drawing.Color.Navy
        Me.MeasureTypeLabel.Location = New System.Drawing.Point(81, 69)
        Me.MeasureTypeLabel.Name = "MeasureTypeLabel"
        Me.MeasureTypeLabel.Size = New System.Drawing.Size(50, 14)
        Me.MeasureTypeLabel.TabIndex = 0
        Me.MeasureTypeLabel.Text = "Measure"
        '
        'PKLabel
        '
        Me.PKLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PKLabel.AutoSize = True
        Me.PKLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.PKLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PKLabel.ForeColor = System.Drawing.Color.Navy
        Me.PKLabel.Location = New System.Drawing.Point(421, 323)
        Me.PKLabel.Name = "PKLabel"
        Me.PKLabel.Size = New System.Drawing.Size(25, 14)
        Me.PKLabel.TabIndex = 0
        Me.PKLabel.Text = "aaa"
        Me.PKLabel.Visible = False
        '
        'SystemIDLabel
        '
        Me.SystemIDLabel.AutoSize = True
        Me.SystemIDLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.SystemIDLabel.Location = New System.Drawing.Point(300, 323)
        Me.SystemIDLabel.Name = "SystemIDLabel"
        Me.SystemIDLabel.Size = New System.Drawing.Size(25, 13)
        Me.SystemIDLabel.TabIndex = 9
        Me.SystemIDLabel.Text = "aaa"
        Me.SystemIDLabel.Visible = False
        '
        'SourceCodeLabel
        '
        Me.SourceCodeLabel.AutoSize = True
        Me.SourceCodeLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.SourceCodeLabel.Location = New System.Drawing.Point(345, 323)
        Me.SourceCodeLabel.Name = "SourceCodeLabel"
        Me.SourceCodeLabel.Size = New System.Drawing.Size(25, 13)
        Me.SourceCodeLabel.TabIndex = 10
        Me.SourceCodeLabel.Text = "aaa"
        Me.SourceCodeLabel.Visible = False
        '
        'BrandSourceCodeLabel
        '
        Me.BrandSourceCodeLabel.AutoSize = True
        Me.BrandSourceCodeLabel.BackColor = System.Drawing.Color.Red
        Me.BrandSourceCodeLabel.ForeColor = System.Drawing.Color.White
        Me.BrandSourceCodeLabel.Location = New System.Drawing.Point(390, 323)
        Me.BrandSourceCodeLabel.Name = "BrandSourceCodeLabel"
        Me.BrandSourceCodeLabel.Size = New System.Drawing.Size(25, 13)
        Me.BrandSourceCodeLabel.TabIndex = 11
        Me.BrandSourceCodeLabel.Text = "aaa"
        Me.BrandSourceCodeLabel.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.DimensionsConfiguration.My.Resources.Resources.PencilAngled_32xLG_color
        Me.PictureBox2.Location = New System.Drawing.Point(24, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'HomologationEditionUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BrandSourceCodeLabel)
        Me.Controls.Add(Me.SourceCodeLabel)
        Me.Controls.Add(Me.SystemIDLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.M01NameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MeasureTypeLabel)
        Me.Controls.Add(Me.PKLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "HomologationEditionUC"
        Me.Size = New System.Drawing.Size(512, 643)
        Me.LeftPanel.ResumeLayout(False)
        Me.RightPanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboNames As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategories As System.Windows.Forms.ComboBox
    Friend WithEvents M01NameLabel As System.Windows.Forms.Label
    Friend WithEvents HOMNameLabel As System.Windows.Forms.Label
    Friend WithEvents CategoryLabel As System.Windows.Forms.Label
    Friend WithEvents LeftPanel As System.Windows.Forms.Panel
    Friend WithEvents RightPanel As System.Windows.Forms.Panel
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MeasureTypeLabel As System.Windows.Forms.Label
    Friend WithEvents PKLabel As System.Windows.Forms.Label
    Friend WithEvents SystemIDLabel As System.Windows.Forms.Label
    Friend WithEvents SourceCodeLabel As System.Windows.Forms.Label
    Friend WithEvents BrandSourceCodeLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
