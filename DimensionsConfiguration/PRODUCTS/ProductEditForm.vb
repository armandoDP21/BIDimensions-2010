Imports System.Globalization

'Imports System.ComponentModel
'Imports System.Runtime.CompilerServices
Public Class ProductEditForm
    Public Event RecordUpdated()


    'Private WithEvents M01_ProductBindingSource As New BindingSource
    Private WithEvents ProductEditIsDirty As ProductDirtyRecord
    Private ThisRecordtKey As Long
    Private MeasureCalled As Integer
    Dim culture As CultureInfo

#Region "Form Methods"
    <STAThread()> _
    Private Sub ProductEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarToolTip()
    End Sub

    Public Property ProductKey() As Long
        Get
            Return ThisRecordtKey
        End Get
        Set(value As Long)
            ThisRecordtKey = value
            Me.Text = "Modo: Edición " & value.ToString
            DisplayRecordValues()
        End Set
    End Property
    Private Sub DisplayRecordValues()
        Me.lblFechaActual.Text = Now.ToString
        Dim context As New SalesDataMartContext
        ProductEditIsDirty = New ProductDirtyRecord
        Dim _D01_PRODUCTS = context.D01_PRODUCTS.SingleOrDefault(Function(o) o.ProductKey = ThisRecordtKey)
        Dim _M01_PRODUCTS = context.M01_Products.SingleOrDefault(Function(o) o.ProductKey = ThisRecordtKey)

        With _D01_PRODUCTS

            ProductIDLabel.Text = .ProductID.ToString
            If String.IsNullOrEmpty(.SAP_ProductCode) Then
                SAP_ProductCodeText.Text = "SAP Product Code pendiente"
            Else
                SAP_ProductCodeText.Text = .SAP_ProductCode
            End If
            DescriptionLabel.Text = .Description

            If Not IsNothing(.CategoryID) Then
                Me.cboCategoryID.SelectedValue = .CategoryID
            Else
                .CategoryID = 1
                Me.cboCategoryID.SelectedValue = .TypeSalesID
            End If

            If Not IsNothing(.FlavorID) Then
                Me.cboFlavorID.SelectedValue = .FlavorID
            Else
                .FlavorID = 1
                Me.cboFlavorID.SelectedValue = .FlavorID
            End If

            If Not IsNothing(.GroupID) Then
                If .GroupID = 0 Then .GroupID = 1
                Me.cboGroupID.SelectedValue = .GroupID
            Else
                .GroupID = 1
                Me.cboGroupID.SelectedValue = .GroupID
            End If

            If Not IsNothing(.PresentationID) Then
                Me.cboPresentationID.SelectedValue = .PresentationID
            Else
                .PresentationID = 1
                Me.cboPresentationID.SelectedValue = .PresentationID
            End If


            If Not IsNothing(.SizeID) Then
                Me.cboSizeID.SelectedValue = .SizeID
            Else
                .SizeID = 1
                Me.cboSizeID.SelectedValue = .SizeID
            End If

            If Not IsNothing(.SourceID) Then
                Me.cboSourceID.SelectedValue = .SourceID
            Else
                .SizeID = 1
                Me.cboSourceID.SelectedValue = .SourceID
            End If

            If Not IsNothing(.SubBrandID) Then
                Me.cboSubBrandID.SelectedValue = .SubBrandID
            Else
                .SizeID = 1
                Me.cboSubBrandID.SelectedValue = .SubBrandID
            End If

            If Not IsNothing(.SubCategoryID) Then
                Me.cboSubCategoryID.SelectedValue = .SubCategoryID
            Else
                .SizeID = 1
                Me.cboSubCategoryID.SelectedValue = .SubCategoryID
            End If


            If Not IsNothing(.TypeBrandID) Then
                Me.cboTypeBrandID.SelectedValue = .TypeBrandID
            Else
                .SizeID = 1
                Me.cboTypeBrandID.SelectedValue = .TypeBrandID
            End If

            If Not IsNothing(.TypeSalesID) Then
                Me.cboTypeSalesID.SelectedValue = .TypeSalesID
            Else
                .TypeSalesID = 1
                Me.cboTypeSalesID.SelectedValue = .TypeSalesID
            End If
            If Not IsNothing(.BrandID) Then
                Me.cboBrandID.SelectedValue = .BrandID
            Else
                .TypeSalesID = 1
                Me.cboBrandID.SelectedValue = .BrandID
            End If


            If Not IsNothing(.PricePoint) Then
                Me.PricePointText.Text = .PricePoint
            End If
            If Not IsNothing(.UnitsPerCase) Then
                Me.UnitsPerCaseText.Text = .UnitsPerCase
            End If
            If Not IsNothing(.UnitsForDistribution) Then
                Me.UnitsForDistributionText.Text = .UnitsForDistribution
            End If
            Me.ActiveFlagCB.Checked = .Active_Flag
            Me.PricePointText.Text = .PricePoint
        End With
        With _M01_PRODUCTS
            If Not IsNothing(.Grams) Then
                Me.GramsText.Text = .Grams
            End If
            If Not IsNothing(.Standar_Cost) Then
                Me.Standar_CostText.Text = .Standar_Cost
            End If
        End With



        With ProductEditIsDirty
            'FRom _D01_PRODUCTS
            .Active_Flag = _D01_PRODUCTS.Active_Flag
            .BrandID = _D01_PRODUCTS.BrandID
            .BrandName = getBrandsName(_D01_PRODUCTS.BrandID)
            .CategoryID = _D01_PRODUCTS.CategoryID
            .CategoryName = getCategoryName(_D01_PRODUCTS.CategoryID)
            .CountryID = _D01_PRODUCTS.CountryID
            .Description = _D01_PRODUCTS.Description
            .EndDate_innovation = _D01_PRODUCTS.EndDate_innovation
            .Flag_innovation = _D01_PRODUCTS.Flag_innovation
            .FlavorID = _D01_PRODUCTS.FlavorID
            .FlavorName = getFlavorName(_D01_PRODUCTS.FlavorID)
            .GroupID = _D01_PRODUCTS.GroupID
            .GroupName = getProductGroupName(_D01_PRODUCTS.GroupID)
            .POT_StatusID = _D01_PRODUCTS.POT_StatusID
            .PresentationID = _D01_PRODUCTS.PresentationID
            .PresentationName = getPresentationName(_D01_PRODUCTS.PresentationID)
            .PricePoint = _D01_PRODUCTS.PricePoint
            .ProductID = _D01_PRODUCTS.ProductID
            .ProductKey = _D01_PRODUCTS.ProductKey
            .SAP_ProductCode = _D01_PRODUCTS.SAP_ProductCode
            .SizeID = _D01_PRODUCTS.SizeID
            .SizeName = Me.cboSizeID.Text
            .SourceID = _D01_PRODUCTS.SourceID
            .SourceName = getSourceName(_D01_PRODUCTS.SourceID)
            .StartDate_innovation = _D01_PRODUCTS.StartDate_innovation
            .SubBrandID = _D01_PRODUCTS.SubBrandID
            .SubBrandName = getSubBrandName(_D01_PRODUCTS.SubBrandID)
            .SubCategoryID = _D01_PRODUCTS.SubCategoryID
            .SubCategoryName = getSubCategoryName(_D01_PRODUCTS.SubCategoryID)
            .SystemOnly = _D01_PRODUCTS.SystemOnly
            .TypeBrandID = _D01_PRODUCTS.TypeBrandID
            .TypeBrandName = gettypeOfBrandName(_D01_PRODUCTS.TypeBrandID)
            .TypeSalesID = _D01_PRODUCTS.TypeSalesID
            .TypeSalesName = getTypeOfSalesName(_D01_PRODUCTS.TypeSalesID)


            If Not IsDBNull(_D01_PRODUCTS.UnitsForDistribution) Then
                .UnitsForDistribution = _D01_PRODUCTS.UnitsForDistribution
            End If
            If Not IsDBNull(_D01_PRODUCTS.UnitsPerCase) Then
                .UnitsPerCase = _D01_PRODUCTS.UnitsPerCase
            End If

            'From _M01_PRODUCTS
            If Not IsDBNull(_M01_PRODUCTS.Grams) Then
                .Grams = _M01_PRODUCTS.Grams
            End If
            If Not IsDBNull(_M01_PRODUCTS.Standar_Cost) Then
                .Standar_Cost = _M01_PRODUCTS.Standar_Cost
            End If
        End With
        ProductEditIsDirty.IsDirty = False
    End Sub
#End Region

#Region "Form Data Events & methods"
    Private Function UpdateProductInfo() As Boolean
        Using context = New SalesDataMartContext
            Dim _M01producto = (From products In context.M01_Products
            Where
            products.ProductKey = ThisRecordtKey
            Select products).SingleOrDefault


            With _M01producto
                .Active_Flag = ProductEditIsDirty.Active_Flag
                .BrandID = ProductEditIsDirty.BrandID
                .CategoryID = ProductEditIsDirty.CategoryID

                '.CountryID = 
                '.Description = 
                '.EndDate_innovation
                '.Flag_innovation

                .FlavorID = ProductEditIsDirty.FlavorID
                .Grams = ProductEditIsDirty.Grams
                .GroupID = ProductEditIsDirty.GroupID
                .POT_StatusID = ProductEditIsDirty.POT_StatusID
                .PresentationID = ProductEditIsDirty.PresentationID
                .PricePoint = ProductEditIsDirty.PricePoint

                '.ProductID
                '.ProductKey

                .SAP_ProductCode = ProductEditIsDirty.SAP_ProductCode
                .SizeID = ProductEditIsDirty.SizeID
                .SourceID = ProductEditIsDirty.SourceID
                .Standar_Cost = ProductEditIsDirty.Standar_Cost
                .StartDate_innovation = ProductEditIsDirty.StartDate_innovation
                .SubBrandID = ProductEditIsDirty.SubBrandID
                .SubCategoryID = ProductEditIsDirty.SubCategoryID
                '.SystemOnly
                .TypeBrandID = ProductEditIsDirty.TypeBrandID
                .TypeSalesID = ProductEditIsDirty.TypeSalesID
                .UnitsForDistribution = ProductEditIsDirty.UnitsForDistribution
                .UnitsPerCase = ProductEditIsDirty.UnitsPerCase
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Using context = New SalesDataMartContext
            Dim _D01producto = (From products In context.D01_PRODUCTS
            Where
            products.ProductKey = ThisRecordtKey
            Select products).SingleOrDefault

            '    Dim _D01producto = (From a In context.GetTable(Of D01_PRODUCT)() Where a.ProductKey.Equals(ThisRecordProductKey) Select a).Single


            With _D01producto
                .Active_Flag = ProductEditIsDirty.Active_Flag
                .BrandID = ProductEditIsDirty.BrandID
                .BrandName = ProductEditIsDirty.BrandName
                .CategoryID = ProductEditIsDirty.CategoryID
                .CategoryName = ProductEditIsDirty.CategoryName
                '.CountryID = ProductEditIsDirty.CountryID
                '.Description = ProductEditIsDirty.Description
                .EndDate_innovation = ProductEditIsDirty.EndDate_innovation
                .Flag_innovation = ProductEditIsDirty.Flag_innovation
                .FlavorID = ProductEditIsDirty.FlavorID
                .FlavorName = ProductEditIsDirty.FlavorName
                .GroupID = ProductEditIsDirty.GroupID
                .GroupName = ProductEditIsDirty.GroupName
                .POT_StatusID = ProductEditIsDirty.POT_StatusID
                .PresentationID = ProductEditIsDirty.PresentationID
                .PresentationName = ProductEditIsDirty.PresentationName
                .PricePoint = ProductEditIsDirty.PricePoint
                '.ProductID = ProductEditIsDirty.ProductID
                '.ProductKey = ProductEditIsDirty.ProductKey
                .SAP_ProductCode = ProductEditIsDirty.SAP_ProductCode
                .SizeID = ProductEditIsDirty.SizeID
                .SizeName = ProductEditIsDirty.SizeName
                .SourceID = ProductEditIsDirty.SourceID
                .SourceName = ProductEditIsDirty.SourceName
                .StartDate_innovation = ProductEditIsDirty.StartDate_innovation
                .SubBrandID = ProductEditIsDirty.SubBrandID
                .SubBrandName = ProductEditIsDirty.SubBrandName
                .SubCategoryID = ProductEditIsDirty.SubCategoryID
                .SubCategoryName = ProductEditIsDirty.SubCategoryName
                .SystemOnly = ProductEditIsDirty.SystemOnly
                .TypeBrandID = ProductEditIsDirty.TypeBrandID
                .TypeBrandName = ProductEditIsDirty.TypeBrandName
                .TypeSalesID = ProductEditIsDirty.TypeSalesID
                .TypeSalesName = ProductEditIsDirty.TypeSalesName
                .UnitsForDistribution = ProductEditIsDirty.UnitsForDistribution
                .UnitsPerCase = ProductEditIsDirty.UnitsPerCase
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        RaiseEvent RecordUpdated()

        Return True



    End Function

    Sub ProductEditIsDirty_EventHandler() Handles ProductEditIsDirty.StatusChanged
        Me.SaveButton.Enabled = ProductEditIsDirty.IsDirty
    End Sub
    Private Sub SAP_ProductCodeText_TextChanged(sender As Object, e As EventArgs) Handles SAP_ProductCodeText.TextChanged
        With ProductEditIsDirty
            .SAP_ProductCode = SAP_ProductCodeText.Text
            .IsDirty = True
        End With
    End Sub

    Private Sub ActiveFlagCB_CheckedChanged(sender As Object, e As EventArgs) Handles ActiveFlagCB.CheckedChanged
        With ProductEditIsDirty
            .Active_Flag = ActiveFlagCB.CheckState
            .IsDirty = True
        End With
    End Sub

    Private Sub cboPresentationID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPresentationID.SelectionChangeCommitted
        With ProductEditIsDirty
            .PresentationID = cboPresentationID.SelectedValue
            .PresentationName = getPresentationName(cboPresentationID.SelectedValue)
            .IsDirty = True
        End With
    End Sub

    Private Sub cboGroupID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboGroupID.SelectionChangeCommitted
        With ProductEditIsDirty
            .GroupID = cboGroupID.SelectedValue
            .GroupName = getProductGroupName(cboGroupID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboFlavorID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFlavorID.SelectionChangeCommitted
        With ProductEditIsDirty
            .FlavorID = cboFlavorID.SelectedValue
            .FlavorName = getFlavorName(cboFlavorID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboSizeID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSizeID.SelectionChangeCommitted
        With ProductEditIsDirty
            .SizeID = cboSizeID.SelectedValue
            .SizeName = getSizeName(cboSizeID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboTypeBrandID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTypeBrandID.SelectionChangeCommitted
        With ProductEditIsDirty
            .TypeBrandID = cboTypeBrandID.SelectedValue
            .TypeBrandName = gettypeOfBrandName(cboTypeBrandID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboSubBrandID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSubBrandID.SelectionChangeCommitted
        With ProductEditIsDirty
            .SubBrandID = cboSubBrandID.SelectedValue
            .SubBrandName = getSubBrandName(cboSubBrandID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboPOT_StatusID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPOT_StatusID.SelectionChangeCommitted
        With ProductEditIsDirty
            .POT_StatusID = cboPOT_StatusID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboTypeSalesID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTypeSalesID.SelectionChangeCommitted
        With ProductEditIsDirty
            .TypeSalesID = cboTypeSalesID.SelectedValue
            .TypeSalesName = getTypeOfSalesName(cboTypeSalesID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboSubCategoryID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSubCategoryID.SelectionChangeCommitted
        With ProductEditIsDirty
            .SubCategoryID = cboSubCategoryID.SelectedValue
            .SubCategoryName = getSubCategoryName(cboSubCategoryID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboCategoryID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoryID.SelectionChangeCommitted
        With ProductEditIsDirty
            .CategoryID = cboCategoryID.SelectedValue
            .CategoryName = getCategoryName(cboCategoryID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboSourceID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSourceID.SelectionChangeCommitted
        With ProductEditIsDirty
            .SourceID = cboSourceID.SelectedValue
            .SourceName = getSourceName(cboSourceID.SelectedValue)
            .IsDirty = True
        End With
    End Sub
    Private Sub cboBrandID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBrandID.SelectionChangeCommitted
        With ProductEditIsDirty
            .BrandID = cboBrandID.SelectedValue
            .BrandName = getBrandsName(cboBrandID.SelectedValue)
            .IsDirty = True
        End With
    End Sub

    Private Sub GramsText_TextChanged(sender As Object, e As EventArgs) Handles GramsText.TextChanged
        With ProductEditIsDirty
            If GramsText.Text.Length > 0 Then
                Dim retVal As Decimal = 0
                If Decimal.TryParse(GramsText.Text, retVal) Then
                    .Grams = retVal
                    .IsDirty = True
                    GramsText.BackColor = Color.White
                Else
                    GramsText.BackColor = Color.Red
                End If

            Else
                GramsText.BackColor = Color.Beige
            End If
        End With
    End Sub

    Private Sub UnitsPerCaseText_TextChanged(sender As Object, e As EventArgs) Handles UnitsPerCaseText.TextChanged
        With ProductEditIsDirty
            If UnitsPerCaseText.Text.Length > 0 Then
                Dim retVal As Decimal = 0
                If Decimal.TryParse(UnitsPerCaseText.Text, retVal) Then
                    .UnitsPerCase = retVal
                    .IsDirty = True
                    UnitsPerCaseText.BackColor = Color.White
                Else
                    UnitsPerCaseText.BackColor = Color.Red
                End If

            Else
                UnitsPerCaseText.BackColor = Color.Beige
            End If
            'If UnitsPerCaseText.Text.Length > 0 Then
            '    .UnitsPerCase = CDec(UnitsPerCaseText.Text)
            '    .IsDirty = True
            'End If
        End With
    End Sub

    Private Sub Standar_CostText_TextChanged(sender As Object, e As EventArgs) Handles Standar_CostText.TextChanged
        With ProductEditIsDirty
            If Standar_CostText.Text.Length > 0 Then
                Dim retVal As Decimal = 0
                If Decimal.TryParse(Standar_CostText.Text, retVal) Then
                    .Standar_Cost = retVal
                    .IsDirty = True
                    Standar_CostText.BackColor = Color.White
                Else
                    Standar_CostText.BackColor = Color.Red
                End If

            Else
                Standar_CostText.BackColor = Color.Beige
            End If


            'If Standar_CostText.Text.Length > 0 Then
            '    .Standar_Cost = CDec(Standar_CostText.Text)
            '    .IsDirty = True
            'End If
        End With
    End Sub

    Private Sub PricePointText_TextChanged(sender As Object, e As EventArgs) Handles PricePointText.TextChanged
        With ProductEditIsDirty
            If PricePointText.Text.Length > 0 Then
                Dim retVal As Decimal = 0
                If Decimal.TryParse(PricePointText.Text, retVal) Then
                    .PricePoint = retVal
                    .IsDirty = True
                    PricePointText.BackColor = Color.White
                Else
                    PricePointText.BackColor = Color.Red
                End If

            Else
                PricePointText.BackColor = Color.Beige
            End If

            'If PricePointText.Text.Length > 0 Then
            '    .PricePoint = PricePointText.Text
            '    .IsDirty = True
            'End If
        End With
    End Sub

    Private Sub UnitsForDistributionText_TextChanged(sender As Object, e As EventArgs) Handles UnitsForDistributionText.TextChanged
        With ProductEditIsDirty
            If UnitsForDistributionText.Text.Length > 0 Then
                Dim retVal As Decimal = 0
                If Decimal.TryParse(UnitsForDistributionText.Text, retVal) Then
                    .UnitsForDistribution = retVal
                    .IsDirty = True
                    UnitsForDistributionText.BackColor = Color.White
                Else
                    UnitsForDistributionText.BackColor = Color.Red
                End If

            Else
                UnitsForDistributionText.BackColor = Color.Beige
            End If
        End With
    End Sub
#End Region

#Region "Measures Buttons"
    Private Sub BrandButton_Click(sender As Object, e As EventArgs) Handles BrandButton.Click
        MeasureCalled = ProductsMeasuresIndex.Brands
        LoadMeasureForm()
    End Sub
    Private Sub TypeOfSalesButton_Click(sender As Object, e As EventArgs) Handles TypeOfSalesButton.Click
        MeasureCalled = ProductsMeasuresIndex.TypeOfSales
        LoadMeasureForm()
    End Sub
    Private Sub GroupButton_Click(sender As Object, e As EventArgs) Handles GroupButton.Click
        MeasureCalled = ProductsMeasuresIndex.ProductGroups
        LoadMeasureForm()
    End Sub
    Private Sub SourceButton_Click(sender As Object, e As EventArgs) Handles SourceButton.Click
        MeasureCalled = ProductsMeasuresIndex.Sources
        LoadMeasureForm()
    End Sub
    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        MeasureCalled = ProductsMeasuresIndex.Categories
        LoadMeasureForm()
    End Sub
    Private Sub SubCategoryButton_Click(sender As Object, e As EventArgs) Handles SubCategoryButton.Click
        MeasureCalled = ProductsMeasuresIndex.SubCategories
        LoadMeasureForm()
    End Sub
    Private Sub PresentationButton_Click(sender As Object, e As EventArgs) Handles PresentationButton.Click
        MeasureCalled = ProductsMeasuresIndex.Presentations
        LoadMeasureForm()
    End Sub
    Private Sub SubBrandButton_Click(sender As Object, e As EventArgs) Handles SubBrandButton.Click
        MeasureCalled = ProductsMeasuresIndex.SubBrands
        LoadMeasureForm()
    End Sub
    Private Sub TypeOfbrandButton_Click(sender As Object, e As EventArgs) Handles TypeOfbrandButton.Click
        MeasureCalled = ProductsMeasuresIndex.TypeOfBrands
        LoadMeasureForm()
    End Sub
    Private Sub SizeButton_Click(sender As Object, e As EventArgs) Handles SizeButton.Click
        MeasureCalled = ProductsMeasuresIndex.Sizes
        LoadMeasureForm()
    End Sub
    Private Sub FlavorButton_Click(sender As Object, e As EventArgs) Handles FlavorButton.Click
        MeasureCalled = ProductsMeasuresIndex.Flavors
        LoadMeasureForm()
    End Sub
    Private Sub POT_StatusButton_Click(sender As Object, e As EventArgs) Handles POT_StatusButton.Click
        MeasureCalled = ProductsMeasuresIndex.POT_Status
        LoadMeasureForm()
    End Sub

#End Region
#Region "Events"
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        UpdateProductInfo()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Hide()
    End Sub
    Private Sub ProductEditForm_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Me.ActiveControl.GetType() = GetType(TextBox) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub ProductEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Asc(e.KeyCode) = 49 Then
            If Me.ActiveControl.GetType() = GetType(ComboBox) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End If
    End Sub

#End Region
#Region "Metodos"


    Private Sub LoadMeasureForm()
        With New ProductsMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Sub ActivarToolTip()
        Me.ToolTip1.UseAnimation = True
        Me.ToolTip1.SetToolTip(PresentationButton, "Agregar Presentation")
        Me.ToolTip1.SetToolTip(GroupButton, "Agregar Grupo")
        Me.ToolTip1.SetToolTip(SourceButton, "Agregar Source ")
        Me.ToolTip1.SetToolTip(CategoryButton, "Agregar Categoría")
        Me.ToolTip1.SetToolTip(SubCategoryButton, "Agregar Sub-Categoría")
        Me.ToolTip1.SetToolTip(TypeOfSalesButton, "Agregar Type of Sales")
        Me.ToolTip1.SetToolTip(BrandButton, "Agregar Marca")
        Me.ToolTip1.SetToolTip(SubBrandButton, "Agregar Sub-Marca")
        Me.ToolTip1.SetToolTip(TypeOfbrandButton, "Agregar Tipo de Marca")
        Me.ToolTip1.SetToolTip(SizeButton, "Agregar Tamaño")
        Me.ToolTip1.SetToolTip(FlavorButton, "Agregar Sabor")
        Me.ToolTip1.SetToolTip(POT_StatusButton, "Agregar POT Status")
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

#End Region

#Region "GetMeasuresNames"
    Private Function getPresentationName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Presentation.SingleOrDefault(Function(o) o.PresentationID = inKey)
            LocalString = mName.PresentationName
        End Using
        Return LocalString
    End Function
    Private Function getProductGroupName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_ProductGroup.SingleOrDefault(Function(o) o.GroupID = inKey)
            LocalString = mName.GroupName
        End Using
        Return LocalString
    End Function
    Private Function getSourceName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Source.SingleOrDefault(Function(o) o.SourceID = inKey)
            LocalString = mName.SourceName
        End Using
        Return LocalString
    End Function
    Private Function getCategoryName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Category.SingleOrDefault(Function(o) o.CategoryID = inKey)
            LocalString = mName.CategoryName
        End Using
        Return LocalString
    End Function
    Private Function getSubCategoryName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_SubCategory.SingleOrDefault(Function(o) o.SubCategoryID = inKey)
            LocalString = mName.SubCategoryName
        End Using
        Return LocalString
    End Function
    Private Function getBrandsName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Brand.SingleOrDefault(Function(o) o.BrandID = inKey)
            LocalString = mName.BrandName

        End Using
        Return LocalString
    End Function
    Private Function getSubBrandName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_SubBrand.SingleOrDefault(Function(o) o.SubBrandID = inKey)
            LocalString = mName.SubBrandName

        End Using
        Return LocalString
    End Function
    Private Function getSizeName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Size.SingleOrDefault(Function(o) o.SizeID = inKey)
            LocalString = mName.SizeName
        End Using
        Return LocalString
    End Function
    Private Function gettypeOfBrandName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_TypeBrand.SingleOrDefault(Function(o) o.TypeBrandID = inKey)
            LocalString = mName.TypeBrandName
        End Using
        Return LocalString
    End Function
    Private Function getFlavorName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_Flavor.SingleOrDefault(Function(o) o.FlavorID = inKey)
            LocalString = mName.FlavorName
        End Using
        Return LocalString
    End Function
    Private Function getTypeOfSalesName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_TypeOFSales.SingleOrDefault(Function(o) o.TypeSalesID = inKey)
            LocalString = mName.TypeSalesName
        End Using
        Return LocalString
    End Function
    Private Function getPOT_StatusName(ByVal inKey As Integer) As String
        Dim LocalString As String = String.Empty
        Using context = New SalesDataMartContext
            Dim mName = context.M01_POT_Status.SingleOrDefault(Function(o) o.POT_StatusID = inKey)
            LocalString = mName.POT_StatusName

        End Using
        Return LocalString
    End Function

#End Region
End Class