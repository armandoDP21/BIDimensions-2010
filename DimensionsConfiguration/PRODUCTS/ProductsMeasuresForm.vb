Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.Remoting.Contexts

Public Class ProductsMeasuresForm
    Private _MeasureCalled As Integer
    Private SDMcontext As SalesDataMartContext
    Private Sub MeasuresForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMeasure()
    End Sub
    Private Sub LoadMeasure()
        SDMcontext = New SalesDataMartContext

        Select Case _MeasureCalled
            Case ProductsMeasuresIndex.Brands
                Me.TituloLabel.Text = "Brands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Brands"
                Me.AddButton.Text = "Agregar registro a Brands"
                Me.TotRegistrosLabel.Text = "Total Brands registrados: " & BrandsDML()

            Case ProductsMeasuresIndex.Categories
                Me.TituloLabel.Text = "Categories"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Categories"
                Me.AddButton.Text = "Agregar a Categories"
                Me.TotRegistrosLabel.Text = "Total Categories registrados: " & CategoriesDML()
            Case ProductsMeasuresIndex.Flavors
                Me.TituloLabel.Text = "Flavors"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Flavors"
                Me.AddButton.Text = "Agregar a Flavors"
                Me.TotRegistrosLabel.Text = "Total Flavors registrados: " & FlavorsDML()
            Case ProductsMeasuresIndex.POT_Status
                Me.TituloLabel.Text = "POT_Status"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en POT_Status"
                Me.AddButton.Text = "Agregar a POT_Status"
                Me.TotRegistrosLabel.Text = "Total POT_Status registrados: " & POT_StatusDML()
            Case ProductsMeasuresIndex.Presentations
                Me.TituloLabel.Text = "Presentations"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Presentations"
                Me.AddButton.Text = "Agregar registro a ProductGroups"
                Me.TotRegistrosLabel.Text = "Total ProductGroups registrados: " & PresentationsDML()
            Case ProductsMeasuresIndex.ProductGroups
                Me.TituloLabel.Text = "ProductGroups"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en ProductGroups"
                Me.AddButton.Text = "Agregar registro a ProductGroups"
                Me.TotRegistrosLabel.Text = "Total ProductGroups registrados: " & ProductGroupsDML()
            Case ProductsMeasuresIndex.Sizes
                Me.TituloLabel.Text = "Sizes"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Sizes"
                Me.AddButton.Text = "Agregar registro a Sizes"
                Me.TotRegistrosLabel.Text = "Total Sizes registrados: " & SizesDML()
            Case ProductsMeasuresIndex.Sources
                Me.TituloLabel.Text = "Sources"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Sources"
                Me.AddButton.Text = "Agregar registro a Sources"
                Me.TotRegistrosLabel.Text = "Total Sources registrados: " & SourcesDML()
            Case ProductsMeasuresIndex.SubBrands
                Me.TituloLabel.Text = "SubBrands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en SubBrands"
                Me.AddButton.Text = "Agregar registro a SubBrands"
                Me.TotRegistrosLabel.Text = "Total SubBrands registrados: " & SubBrandsDML()
            Case ProductsMeasuresIndex.SubCategories
                Me.TituloLabel.Text = "SubCategories"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en SubCategories"
                Me.AddButton.Text = "Agregar registro a SubCategories"
                Me.TotRegistrosLabel.Text = "Total SubCategories registrados: " & SubCategoriesDML()
            Case ProductsMeasuresIndex.TypeOfBrands
                Me.TituloLabel.Text = "TypeOfBrands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en TypeOfBrands"
                Me.AddButton.Text = "Agregar registro a TypeOfBrands"
                Me.TotRegistrosLabel.Text = "Total TypeOfBrands registrados: " & TypeOfBrandsDML()
            Case ProductsMeasuresIndex.TypeOfSales
                Me.TituloLabel.Text = "TypeOfSales"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en TypeOfSales"
                Me.AddButton.Text = "Agregar registro a TypeOfSales"
                Me.TotRegistrosLabel.Text = "Total TypeOfSales registrados: " & TypeOfSalesDML()
        End Select


    End Sub
#Region "Save registro"
    Private Function CreateRegistro() As Boolean
        Try
            Select Case _MeasureCalled
                Case ProductsMeasuresIndex.Brands
                    Dim NewRecord As M01_Brand = New M01_Brand
                    With NewRecord
                        .BrandName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Brand.Add(NewRecord)

                Case ProductsMeasuresIndex.Categories
                    Dim NewRecord As M01_Category = New M01_Category
                    With NewRecord
                        .CategoryName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Category.Add(NewRecord)
                Case ProductsMeasuresIndex.Flavors
                    Dim NewRecord As M01_Flavor = New M01_Flavor
                    With NewRecord
                        .FlavorName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Flavor.Add(NewRecord)
                Case ProductsMeasuresIndex.POT_Status
                    Dim NewRecord As M01_POT_Status = New M01_POT_Status
                    With NewRecord
                        .POT_StatusName = Me.MeasureNameTextBox.Text
                    End With
                    SDMcontext.M01_POT_Status.Add(NewRecord)
                Case ProductsMeasuresIndex.Presentations
                    Dim NewRecord As M01_Presentation = New M01_Presentation
                    With NewRecord
                        .PresentationName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Presentation.Add(NewRecord)

                Case ProductsMeasuresIndex.ProductGroups
                    Dim NewRecord As M01_ProductGroup = New M01_ProductGroup
                    With NewRecord
                        .GroupName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_ProductGroup.Add(NewRecord)

                Case ProductsMeasuresIndex.Sizes
                    Dim NewRecord As M01_Size = New M01_Size
                    With NewRecord
                        .SizeName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Size.Add(NewRecord)

                Case ProductsMeasuresIndex.Sources
                    Dim NewRecord As M01_Source = New M01_Source
                    With NewRecord
                        .SourceName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_Source.Add(NewRecord)

                Case ProductsMeasuresIndex.SubBrands
                    Dim NewRecord As M01_SubBrand = New M01_SubBrand
                    With NewRecord
                        .SubBrandName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_SubBrand.Add(NewRecord)

                Case ProductsMeasuresIndex.SubCategories
                    Dim NewRecord As M01_SubCategory = New M01_SubCategory
                    With NewRecord
                        .SubCategoryName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_SubCategory.Add(NewRecord)

                Case ProductsMeasuresIndex.TypeOfBrands
                    Dim NewRecord As M01_TypeBrand = New M01_TypeBrand
                    With NewRecord
                        .TypeBrandName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_TypeBrand.Add(NewRecord)

                Case ProductsMeasuresIndex.TypeOfSales
                    Dim NewRecord As M01_TypeOFSales = New M01_TypeOFSales
                    With NewRecord
                        .TypeSalesName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    SDMcontext.M01_TypeOFSales.Add(NewRecord)

            End Select
            SDMcontext.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Private Sub UpdateProductsConfigForm()

        Try
            Using MeasuresContext = New SalesDataMartContext
                Select Case _MeasureCalled
                    Case ProductsMeasuresIndex.Brands
                        Dim BrandsList = From brands In MeasuresContext.M01_Brand Select brands
                    Case ProductsMeasuresIndex.Categories
                        Dim CategoriesList = From categories In MeasuresContext.M01_Category Select categories
                    Case ProductsMeasuresIndex.Flavors
                        Dim FlavorsList = From flavors In MeasuresContext.M01_Flavor Select flavors

                    Case ProductsMeasuresIndex.POT_Status
                        Dim POT_StatusList = From POT_Status In MeasuresContext.M01_POT_Status Select POT_Status
                    Case ProductsMeasuresIndex.Presentations
                        Dim PresentationList = From presentations In MeasuresContext.M01_Presentation Select presentations
                    Case ProductsMeasuresIndex.ProductGroups
                        Dim ProductGroupsList = From productGroups In MeasuresContext.M01_ProductGroup Select productGroups
                    Case ProductsMeasuresIndex.Sizes
                        Dim SizesList = From sizes In MeasuresContext.M01_Size Select sizes
                    Case ProductsMeasuresIndex.Sources
                        Dim SourcesList = From sources In MeasuresContext.M01_Source Select sources
                    Case ProductsMeasuresIndex.SubBrands
                        Dim SubBrandsList = From subBrands In MeasuresContext.M01_SubBrand Select subBrands
                    Case ProductsMeasuresIndex.SubCategories
                        Dim SubCategoriesList = From subCategories In MeasuresContext.M01_SubCategory Select subCategories
                    Case ProductsMeasuresIndex.TypeOfBrands
                        Dim TypeOfBrandsList = From typeOfBrands In MeasuresContext.M01_TypeBrand Select typeOfBrands
                    Case ProductsMeasuresIndex.TypeOfSales
                        Dim TypeOfSalesList = From typeOfSales In MeasuresContext.M01_TypeOFSales Select typeOfSales
                End Select
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "metodos"
    Private Sub SaveRecord()
        If CreateRegistro() Then
            EnableListContext()
            SDMcontext.Dispose()
            LoadMeasure()
        End If
    End Sub
    Private Sub DisbleListContext()
        GuardarButton.Enabled = True
        CancelarButton.Enabled = True
        Me.GridDatos.Enabled = False
        Me.AddButton.Enabled = False
        Me.CerrarButton.Enabled = False
        MeasureNameTextBox.Enabled = True
        MeasureNameTextBox.Focus()
    End Sub
    Private Sub EnableListContext()
        GuardarButton.Enabled = False
        CancelarButton.Enabled = False
        Me.GridDatos.Enabled = True
        Me.AddButton.Enabled = True
        Me.CerrarButton.Enabled = True
        Me.MeasureNameTextBox.Text = String.Empty
        Me.MeasureNameTextBox.Enabled = False
    End Sub
#End Region
#Region "Eventos"
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DisbleListContext()
    End Sub
    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        SaveRecord()
    End Sub
    Private Sub CerrarButton_Click(sender As Object, e As EventArgs) Handles CerrarButton.Click
        'Me.SDMcontext.Dispose()
        Me.Close()
    End Sub
    Private Sub MeasureNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MeasureNameTextBox.TextChanged
        If Me.Text.Length = 0 Then
            Me.GuardarButton.Enabled = False
        Else
            Me.GuardarButton.Enabled = True
        End If
    End Sub
    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        EnableListContext()

    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.ActiveControl.GetType() = GetType(TextBox) Or Me.ActiveControl.GetType() = GetType(ComboBox) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End If
    End Sub
#End Region
#Region "Carga measures"
    Private Function BrandsDML() As Integer
        Try
            Dim RecordsList = SDMcontext.M01_Brand.ToList.OrderBy(Function(o) o.BrandName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function CategoriesDML() As Integer
        Try
            Dim RecordsList = SDMcontext.M01_Category.ToList.OrderBy(Function(o) o.CategoryName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
    Private Function FlavorsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_Flavor Select RecordsTable Order By RecordsTable.FlavorName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function POT_StatusDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_POT_Status Select RecordsTable Order By RecordsTable.POT_StatusName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try


    End Function

    Private Function PresentationsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_Presentation Select RecordsTable Order By RecordsTable.PresentationName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function ProductGroupsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_ProductGroup Select RecordsTable Order By RecordsTable.GroupName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function SizesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_Size Select RecordsTable Order By RecordsTable.SizeName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
    Private Function SourcesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_Source Select RecordsTable Order By RecordsTable.SourceName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function SubBrandsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_SubBrand Select RecordsTable Order By RecordsTable.SubBrandName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function SubCategoriesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_SubCategory Select RecordsTable Order By RecordsTable.SubCategoryName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function TypeOfBrandsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_TypeBrand Select RecordsTable Order By RecordsTable.TypeBrandName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function TypeOfSalesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In SDMcontext.M01_TypeOFSales Select RecordsTable Order By RecordsTable.TypeSalesName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

#End Region

    Public Sub New(MeasureCalled As Integer)
        InitializeComponent()
        _MeasureCalled = MeasureCalled
        ConfigurarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        Dim PKName As String = String.Empty
        Dim MeasureName As String = String.Empty

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim MeasurePKColumn As New DataGridViewTextBoxColumn()
        Dim MeasureNameColumn As New DataGridViewTextBoxColumn()
        Dim Active_FlagColumn As New DataGridViewTextBoxColumn()
        Dim SystemOnlyColumn As New DataGridViewTextBoxColumn()
        'Dim SDMcontext As New SalesDataMartContext

        Select Case _MeasureCalled
            Case ProductsMeasuresIndex.Brands
                PKName = "BrandID"
                MeasureName = "BrandName"

            Case ProductsMeasuresIndex.Categories
                PKName = "CategoryID"
                MeasureName = "CategoryName"

            Case ProductsMeasuresIndex.Flavors
                PKName = "FlavorID"
                MeasureName = "FlavorName"

            Case ProductsMeasuresIndex.POT_Status
                PKName = "POT_StatusID"
                MeasureName = "POT_StatusName"

            Case ProductsMeasuresIndex.Presentations
                PKName = "PresentationID"
                MeasureName = "PresentationName"

            Case ProductsMeasuresIndex.ProductGroups
                PKName = "GroupID"
                MeasureName = "GroupName"

            Case ProductsMeasuresIndex.Sizes
                PKName = "SizeID"
                MeasureName = "SizeName"

            Case ProductsMeasuresIndex.Sources
                PKName = "SourceID"
                MeasureName = "SourceName"

            Case ProductsMeasuresIndex.SubBrands
                PKName = "SubBrandID"
                MeasureName = "SubBrandName"

            Case ProductsMeasuresIndex.SubCategories
                PKName = "SubCategoryID"
                MeasureName = "SubCategoryName"

            Case ProductsMeasuresIndex.TypeOfBrands
                PKName = "TypeBrandID"
                MeasureName = "TypeBrandName"

            Case ProductsMeasuresIndex.TypeOfSales
                PKName = "TypeSalesID"
                MeasureName = "TypeSalesName"

        End Select


        With MeasurePKColumn
            .HeaderText = PKName
            .Name = PKName
            .DataPropertyName = PKName
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With
        With MeasureNameColumn
            .HeaderText = MeasureName
            .Name = MeasureName
            .DataPropertyName = MeasureName
            .Width = CInt(TotalGridWidth * 0.7)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = False
        End With

        With Active_FlagColumn
            .HeaderText = "Active_Flag"
            .Name = "Active_Flag"
            .DataPropertyName = "Active_Flag"
            .Width = CInt(TotalGridWidth * 0.11)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With
        With SystemOnlyColumn
            .HeaderText = "SystemOnly"
            .Name = "SystemOnly"
            .DataPropertyName = "SystemOnly"
            .Width = CInt(TotalGridWidth * 0.11)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With



        With Me.GridDatos
            '.Columns.Add(MeasurePKColumn)
            .Columns.Add(MeasureNameColumn)
            .Columns.Add(Active_FlagColumn)
            .Columns.Add(SystemOnlyColumn)

            .AllowUserToOrderColumns = True
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.ColumnHeader

            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken

            .RowHeadersWidth = CInt(TotalGridWidth * 0.02)
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle
            .ReadOnly = False
            .RowsDefaultCellStyle.BackColor = Color.Ivory
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False

            '.SelectionMode = DataGridViewSelectionMode.FullRowSelec
        End With

    End Sub


    'Private Sub saveNewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveNewBtn.Click 'Create new EntityObject to receive the new data 
    '    'Dim newPersonName As New PersonName() 
    '    '       newPersonName.firstName = firstNameTxt.Text
    '    '        newPersonName.lastName = lastNameTxt.Text
    '    '        Persist the new entity 
    '    'personNameContext.AddToPersonName(newPer­sonName) 
    '    '        personNameContext.SaveChanges()
    '    '        Point current pointer to the new entity 
    '    '        personNameItem = newPersonName
    '    '        REFRESHING THE ENTITY CONTECT DOES NOT WORK '
    '    'personNameContext.Refresh(RefreshMo­de.StoreWins, personNameCollection) 
    '    '        Creating new entity SDMcontext works 
    '    '        personNameContext = New PersonNameEntities
    '    '        After creating a new entity SDMcontext, you need to rebind it 
    '    '        dgvPersonName.DataSource = personNameContext.PersonName
    '    '        YOU DO NOT ACTUALLY NEED TO REDRAW THE GUI '
    '    '        dvgPersonName.Refresh()
    'End Sub
    'Private Sub DisableGrid(ByVal grid As DataGridView)
    '    With  Me.GridDatos
    '        .Enabled = False
    '        .ForeColor = Color.Gray
    '        For Each col As DataGridViewColumn In .Columns
    '            col.HeaderCell.Style.ForeColor = Color.Gray
    '        Next
    '    End With
    'End Sub

    'Private Property Brands() As DbSet(Of M01_Brand)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SDMcontext.SaveChanges()
    End Sub



End Class