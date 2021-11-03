Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.Data.Entity.Infrastructure
Imports System.ComponentModel
Imports System.Threading


Public Class ProductsConfigForm
    Private context As SalesDataMartContext
    Private modoBusqueda As Integer
    Private _D01_recordset As DbQuery(Of D01_PRODUCTS)
    Private _M01_recordset As DbQuery(Of M01_Products)

    Private EdicionForm As New ProductEditForm
    Private AsignadoACboPaises As Boolean
    Private WithEvents RecordIsUpdated As ProductEditForm

    Private WithEvents BGW As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWColorearD01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWColorearM01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private Property _changinGridView As Boolean
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler EdicionForm.RecordUpdated, AddressOf Updated_EventHandler

        BGW.RunWorkerAsync()
        My.Application.DoEvents()
        LoadDataCombos()
    End Sub
#Region "Procedures"
    Private Sub CargarDatos()
        context = New SalesDataMartContext
        Me.Cursor = Cursors.WaitCursor
        StatusLabel.Text = "Un momento, cargando datos"

        With Me.PB
            '.ProgressBar.Style = ProgressBarStyle.Marquee
            '.ProgressBar.MarqueeAnimationSpeed = 130
            .Visible = True
            .ProgressBar.Show()
            .Style = ProgressBarStyle.Marquee
            .MarqueeAnimationSpeed = 100
            .ProgressBar.MarqueeAnimationSpeed = 100
            '.ProgressBar.Value = 1
            '.Value = 1

        End With
        My.Application.DoEvents()
        InitilizeGridDatos()
        Select Case InfoCache.TipoQuery
            Case TipoQueryEnum.DataSetOfNonRelated
                ConfigurarGridOfD01()
                _D01_recordset = From products In context.D01_PRODUCTS
                Where
                    products.BrandID = 1 Or
                    products.CategoryID = 1 Or
                    products.FlavorID = 1 Or
                    products.GroupID = 1 Or
                    products.POT_StatusID = 1 Or
                    products.PresentationID = 1 Or
                    products.SizeID = 1 Or
                    products.SourceID = 1 Or
                    products.SubBrandID = 1 Or
                    products.SubCategoryID = 1 Or
                    products.TypeBrandID = 1 Or
                    products.TypeSalesID = 1
                Select products

            Case TipoQueryEnum.DataSetOfAll
                ConfigurarGridOfM01()
                _M01_recordset = From products In context.M01_Products
            Case Else
        End Select

        'Dim sql = _productAll.ToString()
        'System.Diagnostics.Trace.WriteLine(_productAll.ToString())

        If My.Settings.CboPaises.Length > 0 Then
            InfoCache.CountryId = GetIdCountry()
            AsignadoACboPaises = True
            AignarCountryACombo()
            AsignadoACboPaises = False
        Else
            InfoCache.CountryId = "GT"
        End If
        Try
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredByCountryOfD01()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearD01.RunWorkerAsync()

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredByCountryOfM01()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearM01.RunWorkerAsync()

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "ProductKey")
        StatusLabel.Text = "Listo"
        Me.Cursor = Cursors.Default
        With Me.PB
            .Style = ProgressBarStyle.Blocks
            .MarqueeAnimationSpeed = 0
        End With

        CodeSearchTextBox.Enabled = True
        EditButton.Enabled = True
        cboPaises.Enabled = True
        cboTipoBusqueda.Enabled = True

        My.Application.DoEvents()

    End Sub

    Private Sub RecordEdit()
        With EdicionForm
            .ProductKey = CLng(Me.PrimaryKeyText.Text)
            .ShowDialog()

        End With


    End Sub


    Private Sub AignarCountryACombo()

        Select Case InfoCache.CountryId
            Case "GT"
                cboPaises.SelectedItem = "Guatemala"
            Case "HN"
                cboPaises.SelectedItem = "Honduras"
            Case "SV"
                cboPaises.SelectedItem = "El Salvador"
            Case "CR"
                cboPaises.SelectedItem = "Costa Rica"
            Case "PA"
                cboPaises.SelectedItem = "Panamá"
            Case "DO"
                cboPaises.SelectedItem = "Dominican Republic"
        End Select

    End Sub
    Private Sub FitrarPais()
        My.Settings.CboPaises = Me.cboPaises.SelectedItem
        My.Settings.Save()
        Me.Cursor = Cursors.WaitCursor
        StatusLabel.Text = "Un momento, cargando datos"
        My.Application.DoEvents()
        InfoCache.CountryId = GetIdCountry()

        My.Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        Select Case InfoCache.TipoQuery
            Case TipoQueryEnum.DataSetOfNonRelated
                Dim Filtrados = GetFilteredByCountryOfD01()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                BGWColorearD01.RunWorkerAsync()

            Case TipoQueryEnum.DataSetOfAll
                Dim Filtrados = GetFilteredByCountryOfM01()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                BGWColorearM01.RunWorkerAsync()
        End Select
        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "ProductKey")
        Me.PaisLabel.Text = cboPaises.SelectedItem.ToString()
        Me.Cursor = Cursors.Default
        StatusLabel.Text = "Listo"
        My.Application.DoEvents()

    End Sub
    Private Function GetIdCountry() As String

        Select Case My.Settings.CboPaises
            Case "Guatemala"
                Return "GT"
            Case "Honduras"
                Return "HN"
            Case "El Salvador"
                Return "SV"
            Case "Costa Rica"
                Return "CR"
            Case "Panamá"
                Return "PA"
            Case "Dominican Republic"
                Return "DO"
            Case Else
                Return ""
        End Select
    End Function

    Private Sub EditarMeasure()
        Dim MeasureCalled As Integer
        Select Case CboMeasures.SelectedItem.ToString()
            Case "Brand"
                MeasureCalled = ProductsMeasuresIndex.Brands

            Case "Category"
                MeasureCalled = ProductsMeasuresIndex.Categories

            Case "Flavor"
                MeasureCalled = ProductsMeasuresIndex.Flavors

            Case "Presentation"
                MeasureCalled = ProductsMeasuresIndex.Presentations

            Case "ProductGroup"
                MeasureCalled = ProductsMeasuresIndex.ProductGroups
            Case "Size"
                MeasureCalled = ProductsMeasuresIndex.Sizes

            Case "Source"
                MeasureCalled = ProductsMeasuresIndex.Sources

            Case "SubBrand"
                MeasureCalled = ProductsMeasuresIndex.SubBrands

            Case "SubCategory"
                MeasureCalled = ProductsMeasuresIndex.SubCategories

            Case "TypeBrand"
                MeasureCalled = ProductsMeasuresIndex.TypeOfBrands

            Case "TypeOFSales"
                MeasureCalled = ProductsMeasuresIndex.TypeOfSales

            Case "POT_StatusID"
                MeasureCalled = ProductsMeasuresIndex.POT_Status

        End Select
        With New ProductsMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Function GetFilteredByCountryOfD01() As IQueryable(Of D01_PRODUCTS)
        Try
            Return _D01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function GetFilteredByCountryOfM01() As IQueryable(Of M01_Products)
        Try
            Return _M01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub FiltrarRecordset()
        My.Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        If CodeSearchTextBox.Text.Length > 0 Then
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredD01_Product()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearD01.RunWorkerAsync()

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredM01_Product()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearM01.RunWorkerAsync()
            End Select
        Else
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredByCountryOfD01()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearD01.RunWorkerAsync()

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredByCountryOfM01()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearM01.RunWorkerAsync()
            End Select
        End If
        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "ProductKey")
        My.Application.DoEvents()

        StatusLabel.Text = "Listo"
        Me.Cursor = Cursors.Default
    End Sub
    Private Function GetFilteredM01_Product() As IQueryable(Of M01_Products)
        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByProductID
                Return _M01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.ProductID.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByProductSAPID
                Return _M01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.SAP_ProductCode.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByProductName
                Return _M01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.Description.StartsWith(CodeSearchTextBox.Text.Trim))
            Case Else
                Return GetFilteredByCountryOfD01()
        End Select

    End Function
    Private Function GetFilteredD01_Product() As IQueryable(Of D01_PRODUCTS)
        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByProductID
                Return _D01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.ProductID.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByProductSAPID
                Return _D01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.SAP_ProductCode.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByProductName
                Return _D01_recordset.Where(Function(o) o.CountryID = InfoCache.CountryId And o.Description.StartsWith(CodeSearchTextBox.Text.Trim))
            Case Else
                Return GetFilteredByCountryOfD01()
        End Select

    End Function

#End Region
#Region "Eventos"
    Sub Updated_EventHandler()
        context.Dispose()
        CargarDatos()
    End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        CargarDatos()
    End Sub
    Private Sub GridDatos_DoubleClick(sender As Object, e As EventArgs) Handles GridDatos.DoubleClick
        RecordEdit()
    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        RecordEdit()
    End Sub
    Private Sub cboTipoBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoBusqueda.SelectedIndexChanged
        Select Case cboTipoBusqueda.SelectedItem
            Case "Buscar por ID legado de Producto"
                Me.BuscarLabel.Text = "Ingrese código legado>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByProductID
            Case "Buscar por ID SAP de Producto"
                Me.BuscarLabel.Text = "Ingrese código SAP>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByProductSAPID
            Case "Buscar por Descripción del producto"
                Me.BuscarLabel.Text = "Ingrese texto>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByProductName
        End Select
    End Sub
    Private Sub cboPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaises.SelectedIndexChanged
        If Not AsignadoACboPaises Then
            FitrarPais()
        End If
    End Sub
    Private Sub CboMeasures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMeasures.SelectedIndexChanged
        EditarMeasure()
    End Sub
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        FiltrarRecordset()
    End Sub

    Private Sub cboNivelQuery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivelQuery.SelectedIndexChanged
        Select Case cboNivelQuery.SelectedItem
            Case "Productos no relacionados"
                InfoCache.TipoQuery = TipoQueryEnum.DataSetOfNonRelated
            Case "Todos los productos"
                InfoCache.TipoQuery = TipoQueryEnum.DataSetOfAll
        End Select
    End Sub
#End Region
#Region "Load pickLists"
    Private Sub LoadDataCombos()
        With cboPaises
            .Items.Clear()
            .Items.Add("Guatemala")
            .Items.Add("Honduras")
            .Items.Add("El Salvador")
            .Items.Add("Costa Rica")
            .Items.Add("Panamá")
            .Items.Add("Dominican Republic")
            .Text = "Elija un país..."
        End With

        With cboNivelQuery
            .Items.Clear()
            .Items.Add("Productos no relacionados")
            .Items.Add("Todos los productos")
            .Text = "Elija un nivel de consulta..."
        End With
        With CboMeasures
            .Items.Clear()
            .Items.Add("Brand")
            .Items.Add("Category")
            .Items.Add("Flavor")
            .Items.Add("Presentation")
            .Items.Add("POT_StatusID")
            .Items.Add("ProductGroup")
            .Items.Add("Size")
            .Items.Add("Source")
            .Items.Add("SubBrand")
            .Items.Add("SubCategory")
            .Items.Add("TypeBrand")
            .Items.Add("TypeOFSales")
            .Text = "Elija medida para edición..."
        End With
        With cboTipoBusqueda
            .Items.Clear()
            .Items.Add("Buscar por ID legado de Producto")
            .Items.Add("Buscar por ID SAP de Producto")
            .Items.Add("Buscar por Descripción del producto")
            .Text = "Elija dónde buscar..."

        End With
    End Sub
#End Region
#Region "Load Measures"
    Private Sub BGW_DoWork(ByVal sender As Object, ByVal e As EventArgs) Handles BGW.DoWork
        ' Do not access the form's BackgroundWorker reference directly.
        ' Instead, use the reference provided by the sender parameter.
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)
        LoadMeasures()
        ' Start the time-consuming operation. This can be a member method as well.
        Thread.Sleep(2000)
    End Sub
    Public Sub OnCloseNow() Handles BGW.RunWorkerCompleted
        'this could be your custom method
        'Me.Close()
    End Sub
    Private Sub LoadMeasures()

        Try
            Using MeasuresContext = New SalesDataMartContext
                Dim PresentationList = From presentations In MeasuresContext.M01_Presentation Select presentations
                With EdicionForm.cboPresentationID
                    .DataSource = PresentationList.ToList
                    .ValueMember = "PresentationID"
                    .DisplayMember = "PresentationName"
                End With

                Dim ProductGroupsList = From productGroups In MeasuresContext.M01_ProductGroup Select productGroups
                With EdicionForm.cboGroupID
                    .DataSource = ProductGroupsList.ToList
                    .ValueMember = "GroupID"
                    .DisplayMember = "GroupName"
                End With

                Dim SourcesList = From sources In MeasuresContext.M01_Source Select sources
                With EdicionForm.cboSourceID
                    .DataSource = SourcesList.ToList
                    .ValueMember = "SourceID"
                    .DisplayMember = "SourceName"
                End With

                Dim CategoriesList = From categories In MeasuresContext.M01_Category Select categories
                With EdicionForm.cboCategoryID
                    .DataSource = CategoriesList.ToList
                    .ValueMember = "CategoryID"
                    .DisplayMember = "CategoryName"
                End With

                Dim SubCategoriesList = From subCategories In MeasuresContext.M01_SubCategory Select subCategories
                With EdicionForm.cboSubCategoryID
                    .DataSource = SubCategoriesList.ToList
                    .ValueMember = "SubCategoryID"
                    .DisplayMember = "SubCategoryName"
                End With

                Dim BrandsList = From brands In MeasuresContext.M01_Brand Select brands
                With EdicionForm.cboBrandID
                    .DataSource = BrandsList.ToList
                    .ValueMember = "BrandID"
                    .DisplayMember = "BrandName"
                End With

                Dim SubBrandsList = From subBrands In MeasuresContext.M01_SubBrand Select subBrands
                With EdicionForm.cboSubBrandID
                    .DataSource = SubBrandsList.ToList
                    .ValueMember = "SubBrandID"
                    .DisplayMember = "SubBrandName"
                End With

                Dim TypeOfBrandsList = From typeOfBrands In MeasuresContext.M01_TypeBrand Select typeOfBrands
                With EdicionForm.cboTypeBrandID()
                    .DataSource = TypeOfBrandsList.ToList
                    .ValueMember = "TypeBrandID"
                    .DisplayMember = "TypeBrandName"
                End With

                Dim SizesList = From sizes In MeasuresContext.M01_Size Select sizes
                With EdicionForm.cboSizeID
                    .DataSource = SizesList.ToList
                    .ValueMember = "SizeID"
                    .DisplayMember = "SizeName"
                End With

                Dim FlavorsList = From flavors In MeasuresContext.M01_Flavor Select flavors
                With EdicionForm.cboFlavorID
                    .DataSource = FlavorsList.ToList
                    .ValueMember = "FlavorID"
                    .DisplayMember = "FlavorName"
                End With


                Dim TypeOfSalesList = From typeOfSales In MeasuresContext.M01_TypeOFSales Select typeOfSales
                With EdicionForm.cboTypeSalesID
                    .DataSource = TypeOfSalesList.ToList
                    .ValueMember = "TypeSalesID"
                    .DisplayMember = "TypeSalesName"
                End With

                Dim POT_StatusList = From POT_Status In MeasuresContext.M01_POT_Status Select POT_Status

                With EdicionForm.cboPOT_StatusID
                    .DataSource = POT_StatusList.ToList
                    .ValueMember = "POT_StatusID"
                    .DisplayMember = "POT_StatusName"
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub
#Region "Colorear Grids"
    Private Sub BGWColorearD01_DoWork(ByVal sender As Object, ByVal e As EventArgs) Handles BGWColorearD01.DoWork
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)
        MarcarD01()

    End Sub
    Public Sub BGWColorearD01_OnCloseNow() Handles BGWColorearD01.RunWorkerCompleted
        'this could be your custom method
        'Me.Close()
    End Sub
    Private Sub MarcarD01()
        For i As Integer = 0 To Me.GridDatos.Rows.Count - 1
            If Me.GridDatos.Rows(i).Cells("PresentationId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("PresentationName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("GroupId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("GroupName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("SourceId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("SourceName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("CategoryId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("CategoryName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("SubCategoryId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("SubCategoryName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("BrandId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("BrandName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("SubBrandId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("SubBrandName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("TypeBrandId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("TypeBrandName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("SizeId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("SizeName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("FlavorId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("FlavorName").Style.BackColor = Color.SandyBrown
            End If

            If Me.GridDatos.Rows(i).Cells("TypeSalesId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("TypeSalesName").Style.BackColor = Color.SandyBrown
            End If
        Next
    End Sub

    Private Sub BGWColorearM01_DoWork(ByVal sender As Object, ByVal e As EventArgs) Handles BGWColorearM01.DoWork
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)
        MarcarM01()

    End Sub
    Private Sub MarcarM01()
        For i As Integer = 0 To Me.GridDatos.Rows.Count - 1
            If Me.GridDatos.Rows(i).Cells("Grams").Value = 0 Or Me.GridDatos.Rows(i).Cells("Grams").Value = Nothing Then
                Me.GridDatos.Rows(i).Cells("Grams").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("Standar_Cost").Value = 0 Or Me.GridDatos.Rows(i).Cells("Standar_Cost").Value = Nothing Then
                Me.GridDatos.Rows(i).Cells("Standar_Cost").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("PricePoint").Value = 0 Or Me.GridDatos.Rows(i).Cells("PricePoint").Value = Nothing Then
                Me.GridDatos.Rows(i).Cells("PricePoint").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("UnitsPerCase").Value = 0 Or Me.GridDatos.Rows(i).Cells("UnitsPerCase").Value = Nothing Then
                Me.GridDatos.Rows(i).Cells("UnitsPerCase").Style.BackColor = Color.SandyBrown
            End If
        Next
    End Sub
#End Region

#Region "Grids"

    Private Sub ConfigurarGridOfD01()
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim CountryIDColumn As New DataGridViewTextBoxColumn()
        Dim ProductKeyColumn As New DataGridViewTextBoxColumn()
        Dim ProductIDColumn As New DataGridViewTextBoxColumn()
        Dim SAP_ProductCodeColumn As New DataGridViewTextBoxColumn()
        Dim DescriptionColumn As New DataGridViewTextBoxColumn()
        Dim GramsColumn As New DataGridViewTextBoxColumn()
        Dim Standar_CostColumn As New DataGridViewTextBoxColumn()
        Dim PricePointColumn As New DataGridViewTextBoxColumn()
        Dim UnitsPerCaseColumn As New DataGridViewTextBoxColumn()
        Dim PresentationNameColumn As New DataGridViewTextBoxColumn()
        Dim GroupNameColumn As New DataGridViewTextBoxColumn()
        Dim SourceNameColumn As New DataGridViewTextBoxColumn()
        Dim CategoryNameColumn As New DataGridViewTextBoxColumn()
        Dim SubCategoryNameColumn As New DataGridViewTextBoxColumn()
        Dim BrandNameColumn As New DataGridViewTextBoxColumn()
        Dim SubBrandNameColumn As New DataGridViewTextBoxColumn()
        Dim TypeBrandNameColumn As New DataGridViewTextBoxColumn()
        Dim SizeNameColumn As New DataGridViewTextBoxColumn()
        Dim FlavorNameColumn As New DataGridViewTextBoxColumn()
        Dim TypeSalesNameColumn As New DataGridViewTextBoxColumn()
        '..................................................................................
        Dim PresentationIdColumn As New DataGridViewTextBoxColumn()
        Dim GroupIdColumn As New DataGridViewTextBoxColumn()
        Dim SourceIdColumn As New DataGridViewTextBoxColumn()
        Dim CategoryIdColumn As New DataGridViewTextBoxColumn()
        Dim SubCategoryIdColumn As New DataGridViewTextBoxColumn()
        Dim BrandIdColumn As New DataGridViewTextBoxColumn()
        Dim SubBrandIdColumn As New DataGridViewTextBoxColumn()
        Dim TypeBrandIdColumn As New DataGridViewTextBoxColumn()
        Dim SizeIdColumn As New DataGridViewTextBoxColumn()
        Dim FlavorIdColumn As New DataGridViewTextBoxColumn()
        Dim TypeSalesIdColumn As New DataGridViewTextBoxColumn()
        '..................................................................................

        With PresentationIdColumn
            .HeaderText = "PresentationId"
            .Name = "PresentationId"
            .DataPropertyName = "PresentationId"
            .Visible = False
        End With
        With GroupIdColumn
            .HeaderText = "GroupId"
            .Name = "GroupId"
            .DataPropertyName = "GroupId"
            .Visible = False
        End With
        With SourceIdColumn
            .HeaderText = "SourceId"
            .Name = "SourceId"
            .DataPropertyName = "SourceId"
            .Visible = False
        End With
        With CategoryIdColumn
            .HeaderText = "CategoryId"
            .Name = "CategoryId"
            .DataPropertyName = "CategoryId"
            .Visible = False
        End With
        With SubCategoryIdColumn
            .HeaderText = "SubCategoryId"
            .Name = "SubCategoryId"
            .DataPropertyName = "SubCategoryId"
            .Visible = False
        End With
        With BrandIdColumn
            .HeaderText = "BrandId"
            .Name = "BrandId"
            .DataPropertyName = "BrandId"
            .Visible = False
        End With
        With SubBrandIdColumn
            .HeaderText = "SubBrandId"
            .Name = "SubBrandId"
            .DataPropertyName = "SubBrandId"
            .Visible = False
        End With
        With TypeBrandIdColumn
            .HeaderText = "TypeBrandId"
            .Name = "TypeBrandId"
            .DataPropertyName = "TypeBrandId"
            .Visible = False
        End With
        With SizeIdColumn
            .HeaderText = "SizeId"
            .Name = "SizeId"
            .DataPropertyName = "SizeId"
            .Visible = False
        End With
        With FlavorIdColumn
            .HeaderText = "FlavorId"
            .Name = "FlavorId"
            .DataPropertyName = "FlavorId"
            .Visible = False
        End With
        With TypeSalesIdColumn
            .HeaderText = "TypeSalesId"
            .Name = "TypeSalesId"
            .DataPropertyName = "TypeSalesId"
            .Visible = False
        End With


        With CountryIDColumn
            .HeaderText = "CountryID"
            .Name = "CountryID"
            .DataPropertyName = "CountryID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With ProductKeyColumn
            .HeaderText = "ProductKey"
            .Name = "ProductKey"
            .DataPropertyName = "ProductKey"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With ProductIDColumn
            .HeaderText = "Product ID Legado"
            .Name = "ProductID"
            .DataPropertyName = "ProductID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SAP_ProductCodeColumn
            .HeaderText = "SAP Product Code"
            .Name = "SAP_ProductCode"
            .DataPropertyName = "SAP_ProductCode"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With DescriptionColumn
            .HeaderText = "Description"
            .Name = "Description"
            .DataPropertyName = "Description"
            .Width = CInt(TotalGridWidth * 0.18)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With GramsColumn
            .HeaderText = "Grams"
            .Name = "Grams"
            .DataPropertyName = "Grams"
            .Width = CInt(TotalGridWidth * 0.1)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With


        With Standar_CostColumn
            .HeaderText = "Standard_Cost"
            .Name = "Standar_Cost"
            .DataPropertyName = "Standar_Cost"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With PricePointColumn
            .HeaderText = "PricePoint"
            .Name = "PricePoint"
            .DataPropertyName = "PricePoint"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With UnitsPerCaseColumn
            .HeaderText = "UnitsPerCase"
            .Name = "UnitsPerCase"
            .DataPropertyName = "UnitsPerCase"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        'boldStyle.Font = New System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold)

        With PresentationNameColumn
            .HeaderText = "Presentation"
            .Name = "PresentationName"
            .DataPropertyName = "PresentationName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            '.DefaultCellStyle. = FontStyle.Bold
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With GroupNameColumn
            .HeaderText = "Group"
            .Name = "GroupName"
            .DataPropertyName = "GroupName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SourceNameColumn
            .HeaderText = "Source"
            .Name = "SourceName"
            .DataPropertyName = "SourceName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With CategoryNameColumn
            .HeaderText = "Category"
            .Name = "CategoryName"
            .DataPropertyName = "CategoryName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SubCategoryNameColumn
            .HeaderText = "SubCategory"
            .Name = "SubCategoryName"
            .DataPropertyName = "SubCategoryName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With BrandNameColumn
            .HeaderText = "Brand"
            .Name = "BrandName"
            .DataPropertyName = "BrandName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With SubBrandNameColumn
            .HeaderText = "SubBrand"
            .Name = "SubBrandName"
            .DataPropertyName = "SubBrandName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With TypeBrandNameColumn
            .HeaderText = "TypeBrand"
            .Name = "TypeBrandName"
            .DataPropertyName = "TypeBrandName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SizeNameColumn
            .HeaderText = "Size"
            .Name = "SizeName"
            .DataPropertyName = "SizeName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With FlavorNameColumn
            .HeaderText = "Flavor"
            .Name = "FlavorName"
            .DataPropertyName = "FlavorName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With TypeSalesNameColumn
            .HeaderText = "TypeSales"
            .Name = "TypeSalesName"
            .DataPropertyName = "TypeSalesName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With Me.GridDatos
            '.Columns.Add(ProductKeyColumn)
            .Columns.Add(CountryIDColumn)
            .Columns.Add(ProductIDColumn)
            .Columns.Add(SAP_ProductCodeColumn)
            .Columns.Add(DescriptionColumn)
            '.Columns.Add(GramsColumn)
            '.Columns.Add(Standar_CostColumn)
            '.Columns.Add(PricePointColumn)
            '.Columns.Add(UnitsPerCaseColumn)
            .Columns.Add(PresentationNameColumn)
            .Columns.Add(GroupNameColumn)
            .Columns.Add(SourceNameColumn)
            .Columns.Add(CategoryNameColumn)
            .Columns.Add(SubCategoryNameColumn)
            .Columns.Add(BrandNameColumn)
            .Columns.Add(SubBrandNameColumn)
            .Columns.Add(TypeBrandNameColumn)
            .Columns.Add(SizeNameColumn)
            .Columns.Add(FlavorNameColumn)
            .Columns.Add(TypeSalesNameColumn)

            .Columns.Add(PresentationIdColumn)
            .Columns.Add(GroupIdColumn)
            .Columns.Add(SourceIdColumn)
            .Columns.Add(CategoryIdColumn)
            .Columns.Add(SubCategoryIdColumn)
            .Columns.Add(BrandIdColumn)
            .Columns.Add(SubBrandIdColumn)
            .Columns.Add(TypeBrandIdColumn)
            .Columns.Add(SizeIdColumn)
            .Columns.Add(FlavorIdColumn)

            .Columns.Add(TypeSalesIdColumn)

            .AllowUserToOrderColumns = True
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.ColumnHeader
            .MultiSelect = False
            .RowHeadersWidth = CInt(TotalGridWidth * 0.02)
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle
            .ReadOnly = True
            .RowsDefaultCellStyle.BackColor = Color.Ivory
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

    End Sub
    Private Sub ConfigurarGridOfM01()
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim CountryIDColumn As New DataGridViewTextBoxColumn()
        Dim ProductKeyColumn As New DataGridViewTextBoxColumn()
        Dim ProductIDColumn As New DataGridViewTextBoxColumn()
        Dim SAP_ProductCodeColumn As New DataGridViewTextBoxColumn()
        Dim DescriptionColumn As New DataGridViewTextBoxColumn()
        Dim GramsColumn As New DataGridViewTextBoxColumn()
        Dim Standar_CostColumn As New DataGridViewTextBoxColumn()
        Dim PricePointColumn As New DataGridViewTextBoxColumn()
        Dim UnitsPerCaseColumn As New DataGridViewTextBoxColumn()
        '..................................................................................



        With CountryIDColumn
            .HeaderText = "CountryID"
            .Name = "CountryID"
            .DataPropertyName = "CountryID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With ProductKeyColumn
            .HeaderText = "ProductKey"
            .Name = "ProductKey"
            .DataPropertyName = "ProductKey"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With ProductIDColumn
            .HeaderText = "Product ID Legado"
            .Name = "ProductID"
            .DataPropertyName = "ProductID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SAP_ProductCodeColumn
            .HeaderText = "SAP ProductCode"
            .Name = "SAP_ProductCode"
            .DataPropertyName = "SAP_ProductCode"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With DescriptionColumn
            .HeaderText = "Description"
            .Name = "Description"
            .DataPropertyName = "Description"
            .Width = CInt(TotalGridWidth * 0.18)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With GramsColumn
            .HeaderText = "Grams"
            .Name = "Grams"
            .DataPropertyName = "Grams"
            .Width = CInt(TotalGridWidth * 0.1)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With


        With Standar_CostColumn
            .HeaderText = "Standard Cost"
            .Name = "Standar_Cost"
            .DataPropertyName = "Standar_Cost"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With PricePointColumn
            .HeaderText = "Price Point"
            .Name = "PricePoint"
            .DataPropertyName = "PricePoint"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With UnitsPerCaseColumn
            .HeaderText = "Units Per Case"
            .Name = "UnitsPerCase"
            .DataPropertyName = "UnitsPerCase"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        'boldStyle.Font = New System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold)

        With Me.GridDatos
            '.Columns.Add(ProductKeyColumn)
            .Columns.Add(CountryIDColumn)
            .Columns.Add(ProductIDColumn)
            .Columns.Add(SAP_ProductCodeColumn)
            .Columns.Add(DescriptionColumn)
            .Columns.Add(GramsColumn)
            .Columns.Add(Standar_CostColumn)
            .Columns.Add(PricePointColumn)
            .Columns.Add(UnitsPerCaseColumn)

            .AllowUserToOrderColumns = True
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.ColumnHeader
            .MultiSelect = False
            .RowHeadersWidth = CInt(TotalGridWidth * 0.02)
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle
            .ReadOnly = True
            .RowsDefaultCellStyle.BackColor = Color.Ivory
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
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
#End Region
End Class

