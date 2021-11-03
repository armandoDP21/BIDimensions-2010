Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.Data.Entity.Infrastructure
Imports System.ComponentModel
Imports System.Threading
Imports System.Text

Public Class CustomersConfigForm
    Private context As SalesDataMartContext
    Private modoBusqueda As Integer
    Private _Customers_NonRelated As DbQuery(Of D02_CUSTOMERS)
    Private _Customers_All As DbQuery(Of D02_CUSTOMERS)
    Dim CategoriesList As DbQuery(Of M02_Category)

    Private EdicionForm As New CustomerEditForm
    Private AsignadoACboPaises As Boolean
    Private WithEvents RecordIsUpdated As CustomerEditForm
    Private WithEvents BGW As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWColorearD01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWColorearM01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWMeasures As System.ComponentModel.BackgroundWorker = New BackgroundWorker()

    Private Property _changinGridView As Boolean
    Private SelectedCategoryID As Integer
    Private SelectedChainID As Integer
    Private SelectedKeyAccountID As Integer
    Private SelectedPayMtID As Integer
    Private SelectedCountryID As String
    Private IncluirBusqueda As Boolean
    Private SearchByIdLegado As Boolean
    Private SearchByIdSAP As Boolean
    Private SearchByNombre As Boolean

    Private Sub CustomersConfigForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BGWMeasures.RunWorkerAsync()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler EdicionForm.RecordUpdated, AddressOf Updated_EventHandler
        IncluirBusqueda = False
        SearchByIdLegado = False
        SearchByIdSAP = False
        SearchByNombre = False
        BGW.RunWorkerAsync()
        My.Application.DoEvents()
        LoadDataCombos()
        'LoadMeasuresCombos()
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
        'CreatePredicate()
        Dim c As String = Predicate()
        _Customers_NonRelated = From customers In context.D02_CUSTOMERS
      Where (c)
        '_Customers_NonRelated = From customers In context.D02_CUSTOMERS
        'Where
        '    customers.CategoryID = SelectedCategoryID And
        '    customers.ChainID = SelectedChainID And
        '    customers.KeyAccountID = SelectedKeyAccountID And
        '    customers.PayMtID = SelectedPayMtID And
        '    customers.CountryID = SelectedCountryID
        'Select customers


        Me.GridDatos.DataSource = _Customers_NonRelated.ToList

        Me.RecordCountLabel.Text = _Customers_NonRelated.Count & " registros"
        BGWColorearD01.RunWorkerAsync()




        Dim sql = _Customers_NonRelated.ToString()
        'System.Diagnostics.Trace.WriteLine(_CustomerAll.ToString())

        'If My.Settings.CboPaises.Length > 0 Then
        '    InfoCache.CountryId = GetIdCountry()
        '    AsignadoACboPaises = True
        '    AignarCountryACombo()
        '    AsignadoACboPaises = False
        'Else
        InfoCache.CountryId = "GT"
        'End If
        'Select Case InfoCache.TipoQuery
        '    Case TipoQueryEnum.DataSetOfNonRelated
        '    Case TipoQueryEnum.DataSetOfAll
        '        Dim Filtrados = GetFilteredByCountryOfAll()
        '        Me.GridDatos.DataSource = Filtrados.ToList
        '        Me.RecordCountLabel.Text = Filtrados.Count & " registros"
        '        BGWColorearM01.RunWorkerAsync()

        'End Select




        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "CustomerKey")
        StatusLabel.Text = "Listo"
        Me.Cursor = Cursors.Default
        With Me.PB
            .Style = ProgressBarStyle.Blocks
            .MarqueeAnimationSpeed = 0
        End With

        SearchTextBox.Enabled = True
        EditButton.Enabled = True
        'cboPaises.Enabled = True
        'cboTipoBusqueda.Enabled = True

        My.Application.DoEvents()

    End Sub

    Private Sub RecordEdit()
        With EdicionForm
            .customerkey = CLng(Me.PrimaryKeyText.Text)
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
        End Select

    End Sub
    'Private Sub FitrarPais()
    '    My.Settings.CboPaises = Me.cboPaises.SelectedItem
    '    My.Settings.Save()
    '    Me.Cursor = Cursors.WaitCursor
    '    StatusLabel.Text = "Un momento, cargando datos"
    '    My.Application.DoEvents()
    '    InfoCache.CountryId = GetIdCountry()

    '    My.Application.DoEvents()
    '    Me.Cursor = Cursors.WaitCursor
    '    Select Case InfoCache.TipoQuery
    '        Case TipoQueryEnum.DataSetOfNonRelated
    '            Dim Filtrados = GetFilteredByCountryOfNonRelated()
    '            Me.GridDatos.DataSource = Filtrados.ToList
    '            Me.RecordCountLabel.Text = Filtrados.Count & " registros"
    '            BGWColorearD01.RunWorkerAsync()

    '        Case TipoQueryEnum.DataSetOfAll
    '            Dim Filtrados = GetFilteredByCountryOfAll()
    '            Me.GridDatos.DataSource = Filtrados.ToList
    '            Me.RecordCountLabel.Text = Filtrados.Count & " registros"
    '            BGWColorearM01.RunWorkerAsync()
    '    End Select
    '    Me.PrimaryKeyText.DataBindings.Clear()
    '    PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "CustomerKey")
    '    Me.PaisLabel.Text = cboPaises.SelectedItem.ToString()
    '    Me.Cursor = Cursors.Default
    '    StatusLabel.Text = "Listo"
    '    My.Application.DoEvents()

    'End Sub
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
            Case Else
                Return ""
        End Select
    End Function

    Private Sub EditarMeasure()
        Dim MeasureCalled As Integer
        Select Case CboMeasures.SelectedItem.ToString()
            Case "Categories"
                MeasureCalled = CustomersMeasuresIndex.Categories

            Case "Chains"
                MeasureCalled = CustomersMeasuresIndex.Chains


            Case "KeyAccounts"
                MeasureCalled = CustomersMeasuresIndex.KeyAccounts

            Case "PayMethods"
                MeasureCalled = CustomersMeasuresIndex.PayMethods
            Case "Size"

        End Select
        With New CustomersMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Function GetFilteredByCountryOfNonRelated() As IQueryable(Of D02_CUSTOMERS)
        Try
            Return _Customers_NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function GetFilteredByCountryOfAll() As IQueryable(Of D02_CUSTOMERS)
        Try
            Return _Customers_All.Where(Function(o) o.CountryID = InfoCache.CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub FiltrarRecordset()
        My.Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        If SearchTextBox.Text.Length > 0 Then
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredNonRelated()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearD01.RunWorkerAsync()

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredAll()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearM01.RunWorkerAsync()
            End Select
        Else
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredByCountryOfNonRelated()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearD01.RunWorkerAsync()

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredByCountryOfAll()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
                    BGWColorearM01.RunWorkerAsync()
            End Select
        End If
        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "CustomerKey")
        My.Application.DoEvents()

        StatusLabel.Text = "Listo"
        Me.Cursor = Cursors.Default
    End Sub
    Private Function GetFilteredAll() As IQueryable(Of D02_CUSTOMERS)
        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByCustomerID
                Return _Customers_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.CustomerID.StartsWith(SearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByCustomerSAPID
                Return _Customers_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.SAP_CustomerCode.StartsWith(SearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByCustomerName
                Return _Customers_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.Customer_Name.StartsWith(SearchTextBox.Text.Trim))
            Case Else
                Return GetFilteredByCountryOfNonRelated()
        End Select

    End Function
    Private Function GetFilteredNonRelated() As IQueryable(Of D02_CUSTOMERS)
        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByCustomerID
                Return _Customers_NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.CustomerID.StartsWith(SearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByCustomerSAPID
                Return _Customers_NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.SAP_CustomerCode.StartsWith(SearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByCustomerName
                Return _Customers_NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.Customer_Name.StartsWith(SearchTextBox.Text.Trim))
            Case Else
                Return GetFilteredByCountryOfNonRelated()
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

    Private Sub GridDatos_DoubleClick(sender As Object, e As EventArgs)
        RecordEdit()
    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        RecordEdit()
    End Sub
    Private Sub CboMeasures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMeasures.SelectedIndexChanged
        EditarMeasure()
    End Sub
    Private Sub FindButton_Click(sender As Object, e As EventArgs)
        FiltrarRecordset()
    End Sub
    Private Sub cboPaises_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPaises.SelectionChangeCommitted
        SelectedCountryID = GetIdCountry()
    End Sub
    Private Sub cboCategoryID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoryID.SelectionChangeCommitted
        SelectedCategoryID = cboCategoryID.SelectedValue
    End Sub

    Private Sub cboPayMtID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPayMtID.SelectionChangeCommitted
        SelectedPayMtID = cboPayMtID.SelectedValue
    End Sub
    Private Sub cboChainID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboChainID.SelectionChangeCommitted
        SelectedChainID = cboChainID.SelectedValue
    End Sub
    Private Sub cboKeyAccountID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboKeyAccountID.SelectionChangeCommitted
        SelectedKeyAccountID = cboKeyAccountID.SelectedValue
    End Sub
    Private Sub IdLegadoRB_CheckedChanged(sender As Object, e As EventArgs) Handles IdLegadoRB.CheckedChanged
        Me.BuscarLabel.Text = "Ingrese código legado>"
        SearchTextBox.Enabled = True
        IncluirBusqueda = True
        SearchByIdLegado = IdLegadoRB.Checked
    End Sub
    Private Sub IdSAPRB_CheckedChanged(sender As Object, e As EventArgs) Handles IdSAPRB.CheckedChanged
        Me.BuscarLabel.Text = "Ingrese código SAP>"
        SearchTextBox.Enabled = True
        SearchByIdLegado =
        IncluirBusqueda = True
        SearchByIdSAP = IdSAPRB.Checked

    End Sub
    Private Sub NombreRB_CheckedChanged(sender As Object, e As EventArgs) Handles NombreRB.CheckedChanged
        Me.BuscarLabel.Text = "Ingrese Nombre>"
        SearchTextBox.Enabled = True
        IncluirBusqueda = True
        SearchByNombre = NombreRB.Checked
    End Sub
    Private Sub NingunoRB_CheckedChanged(sender As Object, e As EventArgs)
        Me.BuscarLabel.Text = "Ninguno"
        SearchTextBox.Enabled = False
        IncluirBusqueda = False
        SearchByIdLegado = False
        SearchByIdSAP = False
        SearchByNombre = False
    End Sub
    Private Sub SearchTextBoxClearButton_Click(sender As Object, e As EventArgs) Handles SearchTextBoxClearButton.Click
        Me.SearchTextBox.Clear()
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
            .Text = "Elija un país..."
        End With

        'With cboNivelQuery
        '    .Items.Clear()
        '    .Items.Add("Customers no relacionados")
        '    .Items.Add("Todos los Customers")
        '    .Text = "Elija un nivel de consulta..."
        'End With
        With CboMeasures
            .Items.Clear()
            .Items.Add("Categories")
            .Items.Add("Chains")
            .Items.Add("KeyAccounts")
            .Items.Add("PayMethods")
            .Text = "Elija medida para edición..."
        End With
        'With cboTipoBusqueda
        '    .Items.Clear()
        '    .Items.Add("Buscar por ID legado de Cliente")
        '    .Items.Add("Buscar por ID SAP de Cliente")
        '    .Items.Add("Buscar por Descripción del Cliente")
        '    .Text = "Elija dónde buscar..."

        'End With
    End Sub
#End Region
#Region "Load Measures"
    Private Sub BGW_DoWork(ByVal sender As Object, ByVal e As EventArgs) Handles BGW.DoWork
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)
        LoadMeasures()
    End Sub
    Private Sub BGWMeasures_DoWork(ByVal sender As Object, ByVal e As EventArgs) Handles BGWMeasures.DoWork
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)
        LoadMeasuresCombos()
    End Sub
    Public Sub OnCloseNow() Handles BGWMeasures.RunWorkerCompleted
        BindMeasuresCombos()
    End Sub
    Private Sub LoadMeasuresCombos()

        Try
            Using MeasuresContext = New SalesDataMartContext
                'CategoriesList = From categories In MeasuresContext.M02_Category Select categories Order By categories.CategoryName

                CategoriesList = context.M02_Category.OrderBy(Function(M02_Category) M02_Category.CategoryName)
        
               
                ''With Me.cboCategoryID
                ''    .Items.Insert(0, "*")
                ''    .SelectedValue = 0
                ''End With

                Dim ChainList = From Chains In MeasuresContext.M02_Chain Select Chains Order By Chains.ChainName
                'With Me.cboChainID
                '    .DataSource = ChainList.ToList
                '    .ValueMember = "ChainID"
                '    .DisplayMember = "ChainName"

                'End With

                'Dim KeyAccountList = From KeyAccount In MeasuresContext.M02_KeyAccount Select KeyAccount Order By KeyAccount.KeyAccounName
                'With Me.cboKeyAccountID
                '    .DataSource = KeyAccountList.ToList
                '    .ValueMember = "KeyAccountID"
                '    .DisplayMember = "KeyAccounName"

                'End With

                'Dim PayMtList = From PayMt In MeasuresContext.M02_PayMtMthod Select PayMt Order By PayMt.PayMtMthodName
                'With Me.cboPayMtID
                '    .DataSource = PayMtList.ToList
                '    .ValueMember = "PayMtID"
                '    .DisplayMember = "PayMtMthodName"
                'End With

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindMeasuresCombos()
        With Me.cboCategoryID
            .DataSource = CategoriesList
            .ValueMember = "CategoryID"
            .DisplayMember = "CategoryName"
        End With
    End Sub
    Private Sub LoadMeasures()

        Try
            Using MeasuresContext = New SalesDataMartContext

                Dim CategoriesList = From categories In MeasuresContext.M02_Category Select categories Order By categories.CategoryName
                With EdicionForm.cboCategoryID
                    .DataSource = CategoriesList.ToList
                    .ValueMember = "CategoryID"
                    .DisplayMember = "CategoryName"
                End With

                Dim ChainList = From Chains In MeasuresContext.M02_Chain Select Chains Order By Chains.ChainName
                With EdicionForm.cboChainID
                    .DataSource = ChainList.ToList
                    .ValueMember = "ChainID"
                    .DisplayMember = "ChainName"
                End With


                Dim KeyAccountList = From KeyAccount In MeasuresContext.M02_KeyAccount Select KeyAccount Order By KeyAccount.KeyAccounName
                With EdicionForm.cboKeyAccountID
                    .DataSource = KeyAccountList.ToList
                    .ValueMember = "KeyAccountID"
                    .DisplayMember = "KeyAccounName"
                End With


                Dim PayMtList = From PayMt In MeasuresContext.M02_PayMtMthod Select PayMt Order By PayMt.PayMtMthodName
                With EdicionForm.cboPayMtID
                    .DataSource = PayMtList.ToList
                    .ValueMember = "PayMtID"
                    .DisplayMember = "PayMtMthodName"
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
        ConfigurarGrid()
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
            If Me.GridDatos.Rows(i).Cells("CategoryId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("CategoryName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("ChainID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("ChainName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("PayMtID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("PayMtMthodName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("KeyAccountID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("KeyAccounName").Style.BackColor = Color.SandyBrown
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

    Private Sub ConfigurarGrid()
        'CustomerKey()
        'CountryID()
        'CustomerID()
        'SAP_CustomerCode()
        'Customer_Name()
        'CategoryName()
        'ChainName()
        'KeyAccounName()
        'PayMtMthodName()
        'Delivery_Area()

        'EventualKey_Client()
        'WeeklyDROPSize()
        'LastSalesDate()
        'CreationDate()
        'Flag_Active()
        'SystemOnly() ---------------NO
        'CategoryID()
        'ChainID()
        'KeyAccountID()
        'PayMtID()

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim CustomerKeyColumn As New DataGridViewTextBoxColumn()
        Dim CountryIDColumn As New DataGridViewTextBoxColumn()
        Dim CustomerIDColumn As New DataGridViewTextBoxColumn()
        Dim SAP_CustomerCodeColumn As New DataGridViewTextBoxColumn()
        Dim Customer_NameColumn As New DataGridViewTextBoxColumn()
        Dim CategoryNameColumn As New DataGridViewTextBoxColumn()
        Dim ChainNameColumn As New DataGridViewTextBoxColumn()
        Dim KeyAccounNameColumn As New DataGridViewTextBoxColumn()
        Dim PayMtMthodNameColumn As New DataGridViewTextBoxColumn()
        Dim Delivery_AreaColumn As New DataGridViewTextBoxColumn()

        Dim EventualKey_ClientColumn As New DataGridViewTextBoxColumn()
        Dim WeeklyDROPSizeColumn As New DataGridViewTextBoxColumn()
        Dim LastSalesDateColumn As New DataGridViewTextBoxColumn()
        Dim CreationDateColumn As New DataGridViewTextBoxColumn()
        Dim Flag_ActiveColumn As New DataGridViewTextBoxColumn()
        Dim CategoryIdColumn As New DataGridViewTextBoxColumn()
        Dim ChainIDColumn As New DataGridViewTextBoxColumn()
        Dim KeyAccountIDColumn As New DataGridViewTextBoxColumn()
        Dim PayMtIDColumn As New DataGridViewTextBoxColumn()

        '..................................................................................
        With CustomerKeyColumn
            .HeaderText = "Customer Key"
            .Name = "CustomerKey"
            .DataPropertyName = "CustomerKey"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With CountryIDColumn
            .HeaderText = "Country ID"
            .Name = "CountryID"
            .DataPropertyName = "CountryID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With


        With CustomerIDColumn
            .HeaderText = "Customer ID Legado"
            .Name = "CustomerID"
            .DataPropertyName = "CustomerID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With SAP_CustomerCodeColumn
            .HeaderText = "SAP Customer Code"
            .Name = "SAP_CustomerCode"
            .DataPropertyName = "SAP_CustomerCode"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With Customer_NameColumn
            .HeaderText = "Name"
            .Name = "Customer_Name"
            .DataPropertyName = "Customer_Name"
            .Width = CInt(TotalGridWidth * 0.18)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With CategoryNameColumn
            .HeaderText = "Category"
            .Name = "CategoryName"
            .DataPropertyName = "CategoryName"
            .Width = CInt(TotalGridWidth * 0.1)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With


        With ChainNameColumn
            .HeaderText = "Chain"
            .Name = "ChainName"
            .DataPropertyName = "ChainName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With KeyAccounNameColumn
            .HeaderText = "Key Account"
            .Name = "KeyAccounName"
            .DataPropertyName = "KeyAccounName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With PayMtMthodNameColumn
            .HeaderText = "Pay MtMthod"
            .Name = "PayMtMthodName"
            .DataPropertyName = "PayMtMthodName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        'boldStyle.Font = New System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold)

        With Delivery_AreaColumn
            .HeaderText = "Delivery Area"
            .Name = "Delivery_Area"
            .DataPropertyName = "Delivery_Area"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            '.DefaultCellStyle. = FontStyle.Bold
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With EventualKey_ClientColumn
            .HeaderText = "Eventual Key"
            .Name = "EventualKey_Client"
            .DataPropertyName = "EventualKey_Client"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With WeeklyDROPSizeColumn
            .HeaderText = "Weekly DROP Size"
            .Name = "WeeklyDROPSize"
            .DataPropertyName = "WeeklyDROPSize"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With LastSalesDateColumn
            .HeaderText = "Last Sales Date"
            .Name = "LastSalesDate"
            .DataPropertyName = "LastSalesDate"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With CreationDateColumn
            .HeaderText = "Creation Date"
            .Name = "CreationDate"
            .DataPropertyName = "CreationDate"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With Flag_ActiveColumn
            .HeaderText = "Active"
            .Name = "Flag_Active"
            .DataPropertyName = "Flag_Active"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With CategoryIdColumn
            .HeaderText = "CategoryId"
            .Name = "CategoryId"
            .DataPropertyName = "CategoryId"
            .Visible = False
        End With
        With ChainIDColumn
            .HeaderText = "ChainID"
            .Name = "ChainID"
            .DataPropertyName = "ChainID"
            .Visible = False
        End With

        With PayMtIDColumn
            .HeaderText = "PayMtID"
            .Name = "PayMtID"
            .DataPropertyName = "PayMtID"
            .Visible = False
        End With
        With KeyAccountIDColumn
            .HeaderText = "TypeBrand"
            .Name = "KeyAccountID"
            .DataPropertyName = "KeyAccountID"
            .Visible = False
        End With


        With Me.GridDatos
            '.Columns.Add(CustomerKeyColumn)
            .Columns.Add(CountryIDColumn)
            .Columns.Add(CustomerIDColumn)
            .Columns.Add(SAP_CustomerCodeColumn)
            .Columns.Add(Customer_NameColumn)
            .Columns.Add(CategoryNameColumn)
            .Columns.Add(ChainNameColumn)
            .Columns.Add(KeyAccounNameColumn)
            .Columns.Add(PayMtMthodNameColumn)
            .Columns.Add(Delivery_AreaColumn)
            .Columns.Add(EventualKey_ClientColumn)
            .Columns.Add(WeeklyDROPSizeColumn)
            .Columns.Add(LastSalesDateColumn)
            .Columns.Add(CreationDateColumn)
            .Columns.Add(Flag_ActiveColumn)
            .Columns.Add(CategoryIdColumn)
            .Columns.Add(ChainIDColumn)
            .Columns.Add(KeyAccountIDColumn)
            .Columns.Add(PayMtIDColumn)


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

#End Region

    Private Function Predicate() As String
        'Dim Predicate As expresion
        Dim PredicateText As New StringBuilder


        'Dim Conditions As New Dictionary(Of String, Integer)

        If SelectedCategoryID > 0 Then
            PredicateText.Append("CategoryID").Append("=").Append(SelectedCategoryID.ToString).Append(" AND ")
            'Conditions.Add("CategoryID=", SelectedCategoryID)
            ''Dim condition1 = CreateCondition(Of D02_CUSTOMERS, System.Int32)(context.D02_CUSTOMERS, "CategoryID", Condition.Compare.Equal, SelectedCategoryID)

        End If
        If SelectedChainID > 0 Then
            PredicateText.Append("ChainID").Append("=").Append(SelectedChainID.ToString).Append(" AND ")
        End If

        If SelectedKeyAccountID > 0 Then
            PredicateText.Append("KeyAccountID").Append("=").Append(SelectedKeyAccountID.ToString).Append(" AND ")

        End If
        If SelectedPayMtID > 0 Then
            PredicateText.Append("PayMtID").Append("=").Append(SelectedPayMtID.ToString).Append(" AND ")

        End If
        If SearchTextBox.TextLength > 0 Then
            Select Case True
                Case SearchByIdLegado
                    PredicateText.Append("CustomerID").Append("=").Append(SelectedPayMtID.ToString).Append(" AND ")

                Case SearchByIdSAP
                    PredicateText.Append("SAP_CustomerCode").Append("=").Append(SelectedPayMtID.ToString).Append(" AND ")

                Case SearchByNombre
                    PredicateText.Append("Customer_Name").Append("=").Append(SelectedPayMtID.ToString).Append(" AND ")

            End Select
        End If
        Dim ReturnText As String = PredicateText.ToString
        ReturnText = ReturnText.Remove(ReturnText.Length - 5)
        Return ReturnText
    End Function
    '  Private Function GetCondition(Of customers)() As Condition(Of customers)


    '      Dim p1 As PredicateDescription = PredicateBuilder.Make(GetType(Product), "UnitPrice", _
    'FilterOperator.IsGreaterThanOrEqualTo, 24)
    '      Dim p2 As PredicateDescription = PredicateBuilder.Make(GetType(Product), "Discontinued", _
    '        FilterOperator.IsEqualTo, True)
    '  End Function





End Class