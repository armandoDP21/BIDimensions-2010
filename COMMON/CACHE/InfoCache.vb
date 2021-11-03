Option Strict On
Option Explicit On

Imports System.Linq.Expressions

Namespace BI.Datamart.Common
    'Public Enum Compare
    '    [Or] = ExpressionType.Or
    '    [And] = ExpressionType.And
    '    [Xor] = ExpressionType.ExclusiveOr
    '    [Not] = ExpressionType.Not
    '    Equal = ExpressionType.Equal
    '    [Like] = ExpressionType.TypeIs + 1
    '    NotEqual = ExpressionType.NotEqual
    '    [OrElse] = ExpressionType.OrElse
    '    [AndAlso] = ExpressionType.AndAlso
    '    LessThan = ExpressionType.LessThan
    '    GreaterThan = ExpressionType.GreaterThan
    '    LessThanOrEqual = ExpressionType.LessThanOrEqual
    '    GreaterThanOrEqual = ExpressionType.GreaterThanOrEqual
    'End Enum
    Public Enum TipoFiltroEnum
        ByProductID
        ByProductSAPID
        ByProductName
        ByCustomerID
        ByCustomerSAPID
        ByCustomerName
        ByBranchName
        ByZoneName
        ByTypeRoute
    End Enum
    Public Enum TipoQueryEnum
        DataSetOfNonRelated
        DataSetOfAll
    End Enum
    Public Enum HomologationTypes
        BrandCategory
        Flavor
        ProductGroup
        Presentation
        Size
        Source
        SubBrand
        SubCategory
        TypeBrand
        TypeOFSales
        Branch
        Country
        District
        Route_Representative
        TypeRoute
        Zone
        CustomerCategory
        Chain
        KeyAccount
        PayMethod
    End Enum
    Public Enum StatusEnum
        CleanRecord = 0
        DirtyRecord = 1
        NewRecord = 2
        DeletedRecord = 3
        PurgedRecord = 4
    End Enum
    Public Enum Paises
        Guatemala = 2
        Honduras = 3
        Panama = 4
        ElSalvador = 5
        CostaRica = 6
        Quaker = 7

    End Enum
    Public Enum ProductsMeasuresIndex
        Presentations = 1
        ProductGroups = 2
        Sources = 3
        Categories = 4
        SubCategories = 5
        Brands = 6
        SubBrands = 7
        TypeOfBrands = 8
        Sizes = 9
        Flavors = 10
        TypeOfSales = 11
        POT_Status = 12
    End Enum
    Public Enum CustomersMeasuresIndex
        Categories
        Chains
        KeyAccounts
        PayMethods
    End Enum
    Public Enum GeographyMeasuresIndex
        Branches
        Districts
        MUIDs
        RSRIds
        TypeRoutes
        Zones
    End Enum

    Public Enum ClasePolizas
        CarteraAR
        Ventas
        CostoVentas
    End Enum
    Public Class Constantes
        Public Const MargenGrid As Integer = 28
        Public Const FormatoMoneda As String = "#,0.00;(#,0.00)"
        Public Const FormatoMoneda4Dec As String = "#,0.0000;(#,0.0000)"
        Public Const FormatoFecha As String = "dd MMM yyyy"
        Public Const FormatoP100UnDecimal As String = "0.0"
        Public Const FilesGlobalDirectory As String = "C:\LCostos"

    End Class

    Public Class InfoCache

#Region " ConnectionString "
        Private Shared fieldConnectionString As String = String.Empty
        Public Shared Property ConnectionString() As String
            Get
                Return fieldConnectionString
            End Get
            Set(ByVal Value As String)
                fieldConnectionString = Value
            End Set
        End Property
        Private Shared _SystemId As Integer
        Public Shared Property SystemId() As Integer
            Get
                Return _SystemId
            End Get
            Set(ByVal Value As Integer)
                _SystemId = Value
            End Set
        End Property
        'Private Shared GlobalMeasuresDb As DataContext
        'Public Shared Property MeasuresDataContext() As DataContext
        '    Get
        '        Return GlobalMeasuresDb
        '    End Get
        '    Set(ByVal Value As DataContext)
        '        GlobalMeasuresDb = DataContext(Value)
        '    End Set
        'End Property
        Private Shared _dataContext As DataContext
        Public Shared Property MeasuresDataContext(Value1 As DataContext) As DataContext
            Get
                Return _dataContext
            End Get
            Set(value As DataContext)
                _dataContext = Value1
            End Set
        End Property
#End Region

#Region "Variables User"
        Private Shared UserId As String
        Public Shared Property GPID() As String
            Get
                Return UserId
            End Get
            Set(ByVal value As String)
                UserId = value
            End Set
        End Property
        Private Shared PolizaTipo As String
        Public Shared Property TipoPoliza() As String
            Get
                Return PolizaTipo
            End Get
            Set(ByVal value As String)
                PolizaTipo = value
            End Set
        End Property
        Private Shared _TipoQuery As Integer
        Public Shared Property TipoQuery() As Integer
            Get
                Return _TipoQuery
            End Get
            Set(ByVal value As Integer)
                _TipoQuery = value
            End Set
        End Property
        Private Shared _TipoFiltro As Integer
        Public Shared Property TipoFiltro() As Integer
            Get
                Return _TipoFiltro
            End Get
            Set(ByVal value As Integer)
                _TipoFiltro = value
            End Set
        End Property
#End Region

#Region " Errores DDL "
        Private Shared UpdateErrorMessage As String
        Private Shared ValoresDuplicados As String
        Public Shared Property UpdateError() As String
            Get
                Return UpdateErrorMessage

            End Get
            Set(ByVal value As String)
                UpdateErrorMessage = value
            End Set
        End Property
        Public Shared Property Duplicados() As String
            Get
                Return ValoresDuplicados
            End Get
            Set(ByVal value As String)
                ValoresDuplicados = value
            End Set
        End Property
#End Region
#Region "Variables Geografia"
        Private Shared Country_Id As String
        Public Shared Property CountryId() As String
            Get
                Return Country_Id
            End Get
            Set(ByVal value As String)
                Country_Id = value
            End Set
        End Property
#End Region
#Region "Global DataSets"
        'Private Shared ProductsDataSet As ProductsDS
        'Public Shared Property Productos() As ProductsDS
        '    Get
        '        Return ProductsDataSet
        '    End Get
        '    Set(ByVal Value As ProductsDS)
        '        ProductsDataSet = Value
        '    End Set
        'End Property
#End Region




    End Class



End Namespace

