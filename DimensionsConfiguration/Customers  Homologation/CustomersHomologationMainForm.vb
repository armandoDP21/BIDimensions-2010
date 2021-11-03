﻿Public Class CustomersHomologationMainForm
    Private HomologationType As HomologationTypes
    Private SDMcontext As SalesDataMartContext = New SalesDataMartContext
    Private SScontext As SalesStagingContext = New SalesStagingContext
    Private _changinGridView As Boolean
    Private WithEvents HomologationUpdated As HomologationEditionUC

    Private Sub ProductsHomologationMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSystemID()
    End Sub
#Region "metodos"
    Private Sub CargarSystemID()
        Using context As SalesStagingContext = New SalesStagingContext
            Try
                Dim RecordsList = context.AUX_SYSTEM.ToList
                With Me.cboSystemId
                    .DataSource = RecordsList
                    .ValueMember = "SystemId"
                    .DisplayMember = "SystemName"
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ProcesarHomologacion()
        Me.HomEditionUC1.HType = Me.HomologationType

        Select Case Me.HomologationType
            Case HomologationTypes.CustomerCategory
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Brand"
                Me.HTypeLabel.Text = "Category"
                StatusLabel.Text = "Total registros: " & CustomerCategoryDML()
            Case HomologationTypes.Flavor
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Flavor"
                Me.HTypeLabel.Text = "Flavor"
                'StatusLabel.Text = "Total registros: " & FlavorDML()
            Case HomologationTypes.SubCategory
                Me.HomEditionUC1.MeasureTypeLabel.Text = "SubCategory"
                Me.HTypeLabel.Text = "SubCategory"
                'StatusLabel.Text = "Total registros: " & SubCategoryDML()
            Case HomologationTypes.SubBrand
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Sub Brand"
                Me.HTypeLabel.Text = "Sub Brand"
                'StatusLabel.Text = "Total registros: " & SubBrandDML()

            Case HomologationTypes.Source
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Source"
                Me.HTypeLabel.Text = "Source"
                'StatusLabel.Text = "Total registros: " & SourceDML()

            Case HomologationTypes.Size
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Size"
                Me.HTypeLabel.Text = "Size"
                'StatusLabel.Text = "Total registros: " & SizeDML()

            Case HomologationTypes.TypeBrand
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Type of Brand"
                Me.HTypeLabel.Text = "Type of Brand"
                'StatusLabel.Text = "Total registros: " & TypeBrandDML()

            Case HomologationTypes.Presentation
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Presentation"
                Me.HTypeLabel.Text = "Presentation"
                'StatusLabel.Text = "Total registros: " & PresentationDML()
            Case HomologationTypes.ProductGroup
                Me.HomEditionUC1.MeasureTypeLabel.Text = "ProductGroup"
                Me.HTypeLabel.Text = "ProductGroup"
                'StatusLabel.Text = "Total registros: " & ProductGroupDML()
            Case HomologationTypes.TypeOFSales
                Me.HomEditionUC1.MeasureTypeLabel.Text = "Type of Sales"
                Me.HTypeLabel.Text = "Type of Sales"
                'StatusLabel.Text = "Total registros: " & TypeOFSalesDML()

        End Select
    End Sub
#End Region
#Region "Carga datos"
    Private Function CustomerCategoryDML() As Integer
        InitilizeGridDatos()
       
        Try
            Dim RecordsList = (From measure In SDMcontext.M02_Category
            Join homologation In SScontext.HOM_CustomerCategory On measure.CategoryID Equals homologation.CategoryID
            Where homologation.SystemID = InfoCache.SystemId
            Order By measure.CategoryName
            Select measure.CategoryName, homologation.CategorySourceCode, homologation.CategorySourceName, homologation.CategoryID)
            ConfigurarGridOtherMeasures()
            Me.GridDatos.DataSource = RecordsList.ToList
            Me.Key1TextBox.DataBindings.Clear()
            Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "CategorySourceCode")

            Return RecordsList.ToList.Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
    'Private Function FlavorDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        Dim RecordsList = (From measure In context.M01_Flavor
    '        Join homologation In SScontext.HOM_Flavor On measure.FlavorID Equals homologation.FlavorID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.FlavorName
    '        Select measure.FlavorName, homologation.FlavorSourceCode, homologation.FlavorSourceName, homologation.FlavorID)
    '        ConfigurarGridOtherMeasures()
    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "FlavorSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function SubCategoryDML() As String
    '    InitilizeGridDatos()
    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_SubCategory
    '        Join homologation In SScontext.HOM_SubCategory On measure.SubCategoryID Equals homologation.SubCategoryID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.SubCategoryName
    '        Select measure.SubCategoryName, homologation.SubCategorySourceCode, homologation.SubCategorySourceName, homologation.SubCategoryID)
    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "SubCategorySourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function SubBrandDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_SubBrand
    '        Join homologation In SScontext.HOM_SubBrand On measure.SubBrandID Equals homologation.SubBrandID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.SubBrandName
    '        Select measure.SubBrandName, homologation.SubBrandSourceCode, homologation.SubBrandSourceName, homologation.SubBrandID)
    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "SubBrandSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function SourceDML() As String
    '    InitilizeGridDatos()
    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_Source
    '        Join homologation In SScontext.HOM_Source On measure.SourceID Equals homologation.SourceID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.SourceName
    '        Select measure.SourceName, SourceSourceName = homologation.SourceName, homologation.SourceCode, homologation.SourceID)

    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "SourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    '    Return 0
    'End Function
    'Private Function SizeDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_Size
    '        Join homologation In SScontext.HOM_Size On measure.SizeID Equals homologation.SizeID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.SizeName
    '        Select measure.SizeName, homologation.SizeSourceName, homologation.SizeSourceCode, homologation.SizeID)

    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "SizeSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function TypeBrandDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_TypeBrand
    '        Join homologation In SScontext.HOM_TypeBrand On measure.TypeBrandID Equals homologation.TypeBrandID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.TypeBrandName
    '        Select measure.TypeBrandName, homologation.TypeBrandSourceName, homologation.TypeBrandSourceCode, homologation.TypeBrandID)

    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "TypeBrandSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function PresentationDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_Presentation
    '        Join homologation In SScontext.HOM_Presentation On measure.PresentationID Equals homologation.PresentationID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.PresentationName
    '        Select measure.PresentationName, homologation.PresentSourceName, homologation.PresentSourceCode, homologation.PresentationID)

    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "PresentSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function ProductGroupDML() As String
    '    InitilizeGridDatos()

    '    Try
    '        ConfigurarGridOtherMeasures()
    '        Dim RecordsList = (From measure In context.M01_ProductGroup
    '        Join homologation In SScontext.HOM_ProductGroup On measure.GroupID Equals homologation.ProductGroupID
    '        Where homologation.SystemID = InfoCache.SystemId
    '        Order By measure.GroupName
    '        Select measure.GroupName, homologation.PGroupSourceName, homologation.PGroupSourceCode, homologation.ProductGroupID)

    '        Me.GridDatos.DataSource = RecordsList.ToList
    '        Me.Key1TextBox.DataBindings.Clear()
    '        Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "PGroupSourceCode")

    '        Return RecordsList.ToList.Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    'Private Function TypeOFSalesDML() As String
    '    InitilizeGridDatos()

    '    MsgBox("en proceso")
    '    'Try
    '    '    ConfigurarGridOtherMeasures()
    '    '    Dim RecordsList = (From measure In context.M01_TypeOFSales
    '    '    Join homologation In SScontext.HOM_Typeo On measure.GroupID Equals homologation.TypeOFSalesID
    '    '    Where homologation.SystemID = InfoCache.SystemId
    '    '    Order By measure.GroupName
    '    '    Select measure.GroupName, homologation.PGroupSourceName, homologation.PGroupSourceCode, homologation.TypeOFSalesID)

    '    '    Me.GridDatos.DataSource = RecordsList.ToList
    '    '    Me.Key1TextBox.DataBindings.Clear()
    '    '    Key1TextBox.DataBindings.Add("Text", GridDatos.DataSource, "FlavorTypeOFSalesCode")

    '    '    Return RecordsList.ToList.Count
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    '    Return 0
    '    'End Try
    '    Return 0
    'End Function



#End Region
#Region "Events"
    Sub HomologationUpdated_EventHandler() Handles HomEditionUC1.RecordUpdated
        ProcesarHomologacion()
    End Sub
    Private Sub UpdateMeasuresFields()
        If Not _changinGridView Then
            With Me.HomEditionUC1
                .M01NameLabel.Text = Me.GridDatos.SelectedRows(0).Cells(0).Value
                .HOMNameLabel.Text = Me.GridDatos.SelectedRows(0).Cells(1).Value
                .SystemIDLabel.Text = InfoCache.SystemId
                .SourceCodeLabel.Text = Key1TextBox.Text
                If Me.HomologationType = HomologationTypes.CustomerCategory Then
                    .cboNames.SelectedValue = Me.GridDatos.SelectedRows(0).Cells(4).Value
                    .CategoryLabel.Text = Me.GridDatos.SelectedRows(0).Cells(3).Value
                    .cboCategories.SelectedValue = Me.GridDatos.SelectedRows(0).Cells(4).Value
                    .BrandSourceCodeLabel.Text = Me.Key2TextBox.Text
                Else
                    .cboNames.SelectedValue = Me.GridDatos.SelectedRows(0).Cells(4).Value
                End If

            End With
        End If

    End Sub
    Private Sub GridDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridDatos.CellContentClick
        If e.ColumnIndex = 2 Or e.ColumnIndex = 5 Then
            Me.HomEditionUC1.ActivateControl()
        End If
    End Sub
    Private Sub GridDatos_SelectionChanged(sender As Object, e As EventArgs) Handles GridDatos.SelectionChanged
        UpdateMeasuresFields()
    End Sub
    Private Sub cboSystemId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSystemId.SelectionChangeCommitted
        InfoCache.SystemId = cboSystemId.SelectedValue

    End Sub
    Private Sub CustomerCategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        Me.HomologationType = HomologationTypes.CustomerCategory
        ProcesarHomologacion()
    End Sub
    Private Sub TypeOFSalesButton_Click(sender As Object, e As EventArgs) Handles TypeOFSalesButton.Click
        Me.HomologationType = HomologationTypes.TypeOFSales
        ProcesarHomologacion()
    End Sub

    Private Sub TypeBrandButton_Click(sender As Object, e As EventArgs) Handles TypeBrandButton.Click
        Me.HomologationType = HomologationTypes.TypeBrand
        ProcesarHomologacion()
    End Sub



#End Region

#Region "Configuraciones Grid"

    Private Sub ConfigurarGridOtherMeasures()

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim MeasureNameColumn As New DataGridViewTextBoxColumn()
        Dim HomologationNameColumn As New DataGridViewTextBoxColumn()
        Dim HOMSourceCodeColumn As New DataGridViewTextBoxColumn()
        Dim LinkColumn As New DataGridViewLinkColumn()
        Dim HOMIdColumn As New DataGridViewLinkColumn()

        Dim M01Name As String = String.Empty
        Dim HOMName As String = String.Empty
        Dim HOMSourceCode As String = String.Empty
        Dim HOMId As String = String.Empty

        Select Case HomologationType
            Case HomologationTypes.CustomerCategory
                M01Name = "CategoryName"
                HOMName = "CategorySourceName"
                HOMSourceCode = "CategorySourceCode"
                HOMId = "CategoryID"
            Case HomologationTypes.Presentation
                M01Name = "PresentationName"
                HOMName = "PresentSourceName"
                HOMSourceCode = "PresentSourceCode"
                HOMId = "PresentationID"
            Case HomologationTypes.ProductGroup
                M01Name = "GroupName"
                HOMName = "PGroupSourceName"
                HOMSourceCode = "PGroupSourceCode"
                HOMId = "ProductGroupID"
            Case HomologationTypes.Size
                M01Name = "SizeName"
                HOMName = "SizeSourceName"
                HOMSourceCode = "SizeSourceCode"
                HOMId = "SizeID"
            Case HomologationTypes.Source
                M01Name = "SourceName"
                HOMName = "SourceSourceName"
                HOMSourceCode = "SourceCode"
                HOMId = "SourceID"
            Case HomologationTypes.SubBrand
                M01Name = "SubBrandName"
                HOMName = "SubBrandSourceName"
                HOMSourceCode = "SubBrandSourceCode"
                HOMId = "SubBrandID"
            Case HomologationTypes.SubCategory
                M01Name = "SubCategoryName"
                HOMName = "SubCategorySourceName"
                HOMSourceCode = "SubCategorySourceCode"
                HOMId = "SubCategoryID"

            Case HomologationTypes.TypeBrand
                M01Name = "TypeBrandName"
                HOMName = "TypeBrandSourceName"
                HOMSourceCode = "TypeBrandSourceCode"
                HOMId = "TypeBrandID"
            Case HomologationTypes.TypeOFSales
                M01Name = ""
                HOMName = ""
                HOMSourceCode = ""
                HOMId = "TypeOFSalesID"

        End Select
        With MeasureNameColumn
            .HeaderText = M01Name
            .Name = M01Name
            .DataPropertyName = M01Name
            .Width = CInt(TotalGridWidth * 0.4)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With
        With HomologationNameColumn
            .HeaderText = "Homologado a:"
            .Name = HOMName
            .DataPropertyName = HOMName
            .Width = CInt(TotalGridWidth * 0.4)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = False
        End With
        With LinkColumn
            .HeaderText = "Modificar"
            .Name = "Editar"
            .Text = "Editar"
            .UseColumnTextForLinkValue = True
            .Width = CInt(TotalGridWidth * 0.2)
        End With
        With HOMSourceCodeColumn
            .HeaderText = HOMSourceCode
            .Name = HOMSourceCode
            .DataPropertyName = HOMSourceCode

            .ReadOnly = True
            .Visible = False

        End With
        With HOMIdColumn
            .HeaderText = HOMId
            .Name = HOMId
            .DataPropertyName = HOMId
            .ReadOnly = True
            .Visible = False
        End With
        'With M01CategoryIDColumn
        '    .HeaderText = "CategoryID"
        '    .Name = "CategoryID"
        '    .DataPropertyName = "CategoryID"
        '    .Width = CInt(TotalGridWidth * 0.3)
        '    .DefaultCellStyle.SelectionBackColor = Color.Red
        '    .ReadOnly = True
        '    .Visible = False
        'End With


        With Me.GridDatos
            '.Columns.Clear()
            '.DataSource = Nothing

            .Columns.Add(MeasureNameColumn)
            .Columns.Add(HomologationNameColumn)
            .Columns.Add(LinkColumn)
            .Columns.Add(HOMSourceCodeColumn)
            .Columns.Add(HOMIdColumn)
            .AllowUserToOrderColumns = True
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.ColumnHeader

            .RowHeadersWidth = CInt(TotalGridWidth * 0.02)
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle
            .ReadOnly = False
            .RowsDefaultCellStyle.BackColor = Color.Ivory
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        '.Columns.Add(M01CategoryNameColumn)
        '.Columns.Add(M01CategoryIDColumn)



    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        'ConfigurarGrid()
    End Sub
    Private Sub InitilizeGridDatos()
        _changinGridView = True
        With Me.GridDatos
            .CancelEdit()
            .Columns.Clear()
            .DataSource = Nothing
            .Refresh()
        End With
        _changinGridView = False
    End Sub

    Private Sub PayMethodButton_Click(sender As Object, e As EventArgs) Handles PayMethodButton.Click

    End Sub
    Private Sub keyAccountButton_Click(sender As Object, e As EventArgs) Handles keyAccountButton.Click

    End Sub
    Private Sub ChainButton_Click(sender As Object, e As EventArgs) Handles ChainButton.Click

    End Sub

End Class