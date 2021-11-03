Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.Data.Entity.Infrastructure
Imports System.ComponentModel
Imports System.Threading

Public Class GeographyConfigForm
    Private context As SalesDataMartContext
    Private modoBusqueda As Integer
    Private _Geography__NonRelated As DbQuery(Of D05_GEOGRAPHY)
    Private _Geography_All As DbQuery(Of D05_GEOGRAPHY)

    Private EdicionForm As New GeographyEditForm
    Private AsignadoACboPaises As Boolean
    Private WithEvents RecordIsUpdated As ProductEditForm

    Private WithEvents BGW As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    Private WithEvents BGWColorearD01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
    'Private WithEvents BGWColorearM01 As System.ComponentModel.BackgroundWorker = New BackgroundWorker()
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
        Select Case InfoCache.TipoQuery
            Case TipoQueryEnum.DataSetOfNonRelated

                _Geography__NonRelated = From geography In context.D05_GEOGRAPHY
                Where
                    geography.BranchID = 1 Or
                    geography.DistrictID = 1 Or
                    geography.MUID = 1 Or
                    geography.RSRId = 1 Or
                    geography.TypeRouteID = 1 Or
                    geography.ZoneID = 1
                Select geography

            Case TipoQueryEnum.DataSetOfAll
                _Geography_All = From geography In context.D05_GEOGRAPHY
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
        Select Case InfoCache.TipoQuery
            Case TipoQueryEnum.DataSetOfNonRelated
                Dim Filtrados = GetFilteredByCountryOfNonRelated()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"
            Case TipoQueryEnum.DataSetOfAll
                Dim Filtrados = GetFilteredByCountryOfAll()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"
        End Select
        BGWColorearD01.RunWorkerAsync()




        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "GeographicKey")
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
            .GeographyKey = CLng(Me.PrimaryKeyText.Text)
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
                Dim Filtrados = GetFilteredByCountryOfNonRelated()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"

            Case TipoQueryEnum.DataSetOfAll
                Dim Filtrados = GetFilteredByCountryOfAll()
                Me.GridDatos.DataSource = Filtrados.ToList
                Me.RecordCountLabel.Text = Filtrados.Count & " registros"
        End Select
        BGWColorearD01.RunWorkerAsync()
        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "GeographicKey")
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
            Case Else
                Return ""
        End Select
    End Function

    Private Sub EditarMeasure()



        Dim MeasureCalled As Integer
        Select Case CboMeasures.SelectedItem.ToString()
            Case "Brand"
                MeasureCalled = GeographyMeasuresIndex.Branches

            Case "Category"
                MeasureCalled = GeographyMeasuresIndex.Districts

            Case "Flavor"
                MeasureCalled = GeographyMeasuresIndex.MUIDs

            Case "Presentation"
                MeasureCalled = GeographyMeasuresIndex.RSRIds

            Case "ProductGroup"
                MeasureCalled = GeographyMeasuresIndex.TypeRoutes
            Case "Size"
                MeasureCalled = GeographyMeasuresIndex.Zones


        End Select
        With New GeographyMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Function GetFilteredByCountryOfNonRelated() As IQueryable(Of D05_GEOGRAPHY)
        Try
            Return _Geography__NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function GetFilteredByCountryOfAll() As IQueryable(Of D05_GEOGRAPHY)
        Try
            Return _Geography_All.Where(Function(o) o.CountryID = InfoCache.CountryId)
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
                    Dim Filtrados = GetFilteredNonRelated()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredAll()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
            End Select
            BGWColorearD01.RunWorkerAsync()
        Else
            Select Case InfoCache.TipoQuery
                Case TipoQueryEnum.DataSetOfNonRelated
                    Dim Filtrados = GetFilteredByCountryOfNonRelated()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"

                Case TipoQueryEnum.DataSetOfAll
                    Dim Filtrados = GetFilteredByCountryOfAll()
                    Me.GridDatos.DataSource = Filtrados.ToList
                    Me.RecordCountLabel.Text = Filtrados.Count & " registros"
            End Select
            BGWColorearD01.RunWorkerAsync()
        End If
        Me.PrimaryKeyText.DataBindings.Clear()
        PrimaryKeyText.DataBindings.Add("Text", GridDatos.DataSource, "GeographicKey")
        My.Application.DoEvents()

        StatusLabel.Text = "Listo"
        Me.Cursor = Cursors.Default
    End Sub
    Private Function GetFilteredAll() As IQueryable(Of D05_GEOGRAPHY)
        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByBranchName
                Return _Geography_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.BranchName.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByZoneName
                Return _Geography_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.ZoneName.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByTypeRoute
                Return _Geography_All.Where(Function(o) o.CountryID = InfoCache.CountryId And o.TypeRouteName.StartsWith(CodeSearchTextBox.Text.Trim))
            Case Else
                Return GetFilteredByCountryOfNonRelated()
        End Select

    End Function
    Private Function GetFilteredNonRelated() As IQueryable(Of D05_GEOGRAPHY)


        Select Case InfoCache.TipoFiltro
            Case TipoFiltroEnum.ByBranchName
                Return _Geography__NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.BranchName.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByZoneName
                Return _Geography__NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.ZoneName.StartsWith(CodeSearchTextBox.Text.Trim))
            Case TipoFiltroEnum.ByTypeRoute
                Return _Geography__NonRelated.Where(Function(o) o.CountryID = InfoCache.CountryId And o.TypeRouteName.StartsWith(CodeSearchTextBox.Text.Trim))
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
    Private Sub GridDatos_DoubleClick(sender As Object, e As EventArgs) Handles GridDatos.DoubleClick
        RecordEdit()
    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        RecordEdit()
    End Sub
    Private Sub cboTipoBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoBusqueda.SelectedIndexChanged
      

        Select Case cboTipoBusqueda.SelectedItem
            Case "Buscar por Branch"
                Me.BuscarLabel.Text = "Ingrese Branch>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByBranchName
            Case "Buscar por Zona"
                Me.BuscarLabel.Text = "Ingrese Zona>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByZoneName
            Case "Buscar por Tipo de Ruta"
                Me.BuscarLabel.Text = "Ingrese Tipo de Ruta>"
                InfoCache.TipoFiltro = TipoFiltroEnum.ByTypeRoute
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
            Case "Geography no relacionados"
                InfoCache.TipoQuery = TipoQueryEnum.DataSetOfNonRelated
            Case "Todos los Geography"
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
            .Text = "Elija un país..."
        End With

        With cboNivelQuery
            .Items.Clear()
            .Items.Add("Geography no relacionados")
            .Items.Add("Todos los Geography")
            .Text = "Elija un nivel de consulta..."
        End With



        With CboMeasures
            .Items.Clear()
            .Items.Add("Branches")
            .Items.Add("Districts")
            .Items.Add("MUIDs")
            .Items.Add("RSRIds")
            .Items.Add("TypeRoutes")
            .Items.Add("Zones")

            .Text = "Elija medida para edición..."
        End With
        With cboTipoBusqueda
            .Items.Clear()
            .Items.Add("Buscar por Branch")
            .Items.Add("Buscar por Zona")
            .Items.Add("Buscar por Tipo de Ruta")
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
    End Sub
    Public Sub OnCloseNow() Handles BGW.RunWorkerCompleted
        'this could be your custom method
        'Me.Close()
    End Sub
    Private Sub LoadMeasures()
        
        Try
            Using MeasuresContext = New SalesDataMartContext
                Dim BranchList = From branchs In MeasuresContext.M05_Branch Select branchs
                With EdicionForm.cboBranchID
                    .DataSource = BranchList.ToList
                    .ValueMember = "BranchID"
                    .DisplayMember = "BranchName"
                End With

                Dim DistrictsList = From districts In MeasuresContext.M05_District Select districts
                With EdicionForm.cboDistrictID
                    .DataSource = DistrictsList.ToList
                    .ValueMember = "DistrictID"
                    .DisplayMember = "DistrictName"
                End With


                Dim MUList = From MUs In MeasuresContext.M05_Market_Unit Select MUs
                With EdicionForm.cboMUID
                    .DataSource = MUList.ToList
                    .ValueMember = "MUID"
                    .DisplayMember = "Market_Unit"
                End With

                Dim RSRIList = From RSRIs In MeasuresContext.M05_Route_Representative Select RSRIs
                With EdicionForm.cboRSRId
                    .DataSource = RSRIList.ToList
                    .ValueMember = "RSRID"
                    .DisplayMember = "RSRName"
                End With

                Dim TypeRList = From TypeR In MeasuresContext.M05_TypeRoute Select TypeR
                With EdicionForm.cboTypeRouteID
                    .DataSource = RSRIList.ToList
                    .ValueMember = "TypeRouteID"
                    .DisplayMember = "TypeRouteName"
                End With


                Dim ZonesList = From Zones In MeasuresContext.M05_Zone Select Zones
                With EdicionForm.cboZoneID
                    .DataSource = ZonesList.ToList
                    .ValueMember = "ZoneID"
                    .DisplayMember = "ZoneName"
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
            If Me.GridDatos.Rows(i).Cells("BranchID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("BranchName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("DistrictID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("DistrictName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("MUID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("Market_Unit").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("RSRId").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("RSRName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("TypeRouteID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("TypeRouteName").Style.BackColor = Color.SandyBrown
            End If
            If Me.GridDatos.Rows(i).Cells("ZoneID").Value = 1 Then
                Me.GridDatos.Rows(i).Cells("ZoneName").Style.BackColor = Color.SandyBrown
            End If
           
        Next
    End Sub

   
#End Region
#Region "Grids"

    Private Sub ConfigurarGrid()

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim GeographicKeyColumn As New DataGridViewTextBoxColumn()
        Dim CountryIDColumn As New DataGridViewTextBoxColumn()
        Dim CountryNameColumn As New DataGridViewTextBoxColumn()
        Dim BranchNameColumn As New DataGridViewTextBoxColumn()
        Dim DistrictNameColumn As New DataGridViewTextBoxColumn()
        Dim Market_UnitColumn As New DataGridViewTextBoxColumn()
        Dim RouteIDColumn As New DataGridViewTextBoxColumn()
        Dim RSRNameColumn As New DataGridViewTextBoxColumn()
        Dim TypeRouteNameColumn As New DataGridViewTextBoxColumn()
        Dim ZoneNameColumn As New DataGridViewTextBoxColumn()
        Dim Flag_ActiveColumn As New DataGridViewTextBoxColumn()
        Dim SystemOnlyColumn As New DataGridViewTextBoxColumn()
        '..................................................................................
        Dim BranchIDColumn As New DataGridViewTextBoxColumn()
        Dim DistrictIDColumn As New DataGridViewTextBoxColumn()
        Dim MUIDColumn As New DataGridViewTextBoxColumn()
        Dim RSRIdColumn As New DataGridViewTextBoxColumn()
        Dim TypeRouteIDColumn As New DataGridViewTextBoxColumn()
        Dim ZoneIDColumn As New DataGridViewTextBoxColumn()



        With GeographicKeyColumn
            .HeaderText = "GeographicKey"
            .Name = "GeographicKey"
            .DataPropertyName = "GeographicKey"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
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


        With CountryNameColumn
            .HeaderText = "Country Name"
            .Name = "CountryName"
            .DataPropertyName = "CountryName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With BranchNameColumn
            .HeaderText = "Branch"
            .Name = "BranchName"
            .DataPropertyName = "BranchName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With DistrictNameColumn
            .HeaderText = "District"
            .Name = "DistrictName"
            .DataPropertyName = "DistrictName"
            .Width = CInt(TotalGridWidth * 0.18)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With Market_UnitColumn
            .HeaderText = "Market Unit"
            .Name = "Market_Unit"
            .DataPropertyName = "Market_Unit"
            .Width = CInt(TotalGridWidth * 0.1)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With


        With RouteIDColumn
            .HeaderText = "Route ID"
            .Name = "RouteID"
            .DataPropertyName = "RouteID"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With

        With RSRNameColumn
            .HeaderText = "RSR Name"
            .Name = "RSRName"
            .DataPropertyName = "RSRName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With TypeRouteNameColumn
            .HeaderText = "Type Route"
            .Name = "TypeRouteName"
            .DataPropertyName = "TypeRouteName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        'boldStyle.Font = New System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold)

        With ZoneNameColumn
            .HeaderText = "Zone"
            .Name = "ZoneName"
            .DataPropertyName = "ZoneName"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            '.DefaultCellStyle. = FontStyle.Bold
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
        With SystemOnlyColumn
            .HeaderText = "SystemOnly"
            .Name = "SystemOnly"
            .DataPropertyName = "SystemOnly"
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Cyan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True
        End With
        With BranchIDColumn
            .HeaderText = "BranchID"
            .Name = "BranchID"
            .DataPropertyName = "BranchID"
            .Visible = False
        End With
        With DistrictIDColumn
            .HeaderText = "DistrictID"
            .Name = "DistrictID"
            .DataPropertyName = "DistrictID"
            .Visible = False
        End With
        With MUIDColumn
            .HeaderText = "MUID"
            .Name = "MUID"
            .DataPropertyName = "MUID"
            .Visible = False
        End With
        With RSRIdColumn
            .HeaderText = "RSRId"
            .Name = "RSRId"
            .DataPropertyName = "RSRId"
            .Visible = False
        End With
        With TypeRouteIDColumn
            .HeaderText = "TypeRouteID"
            .Name = "TypeRouteID"
            .DataPropertyName = "TypeRouteID"
            .Visible = False
        End With
        With ZoneIDColumn
            .HeaderText = "ZoneID"
            .Name = "ZoneID"
            .DataPropertyName = "ZoneID"
            .Visible = False
        End With

        With Me.GridDatos
            '.Columns.Add(GeographicKeyColumn)
            .Columns.Add(CountryIDColumn)
            .Columns.Add(CountryNameColumn)
            .Columns.Add(BranchNameColumn)
            .Columns.Add(DistrictNameColumn)
            .Columns.Add(Market_UnitColumn)
            .Columns.Add(RouteIDColumn)
            .Columns.Add(RSRNameColumn)
            .Columns.Add(TypeRouteNameColumn)
            .Columns.Add(ZoneNameColumn)
            .Columns.Add(Flag_ActiveColumn)
            .Columns.Add(SystemOnlyColumn)
            .Columns.Add(BranchIDColumn)
            .Columns.Add(DistrictIDColumn)
            .Columns.Add(MUIDColumn)
            .Columns.Add(RSRIdColumn)
            .Columns.Add(TypeRouteIDColumn)
            .Columns.Add(ZoneIDColumn)

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

End Class