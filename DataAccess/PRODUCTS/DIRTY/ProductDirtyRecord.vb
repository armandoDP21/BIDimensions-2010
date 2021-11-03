Public Class ProductDirtyRecord
    Public Event StatusChanged()
    Private _RecordStatus As Boolean

    'D01_PRODUCTS
    Private _ProductKey As Integer
    Private _CountryID As String
    Private _ProductID As String
    Private _SAP_ProductCode As String
    Private _Description As String
    Private _UnitsPerCase As System.Nullable(Of Decimal)
    Private _PresentationID As System.Nullable(Of Integer)
    Private _PresentationName As String
    Private _GroupID As System.Nullable(Of Integer)
    Private _GroupName As String
    Private _SourceID As System.Nullable(Of Integer)
    Private _SourceName As String
    Private _CategoryID As System.Nullable(Of Integer)
    Private _CategoryName As String
    Private _SubCategoryID As System.Nullable(Of Integer)
    Private _SubCategoryName As String
    Private _BrandID As System.Nullable(Of Integer)
    Private _BrandName As String
    Private _SubBrandID As System.Nullable(Of Integer)
    Private _SubBrandName As String
    Private _TypeBrandID As System.Nullable(Of Integer)
    Private _TypeBrandName As String
    Private _SizeID As System.Nullable(Of Integer)
    Private _SizeName As String
    Private _FlavorID As System.Nullable(Of Integer)
    Private _FlavorName As String
    Private _Active_Flag As System.Nullable(Of Boolean)
    Private _SystemOnly As System.Nullable(Of Boolean)
    Private _Flag_innovation As System.Nullable(Of Boolean)
    Private _StartDate_innovation As System.Nullable(Of Date)
    Private _EndDate_innovation As System.Nullable(Of Date)
    Private _PricePoint As System.Nullable(Of Decimal)
    Private _POT_StatusID As System.Nullable(Of Integer)
    Private _UnitsForDistribution As System.Nullable(Of Decimal)
    Private _TypeSalesID As System.Nullable(Of Integer)
    Private _TypeSalesName As String

    'M01_PRODUCTS
    Private _Grams As System.Nullable(Of Decimal)
    Private _Standar_Cost As System.Nullable(Of Decimal)

    

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductKey", DbType:="Int NOT NULL")> _
    Public Property ProductKey() As Integer
        Get
            Return Me._ProductKey
        End Get
        Set(value As Integer)
            If ((Me._ProductKey = value) _
                        = False) Then
                Me._ProductKey = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CountryID", DbType:="VarChar(2)")> _
    Public Property CountryID() As String
        Get
            Return Me._CountryID
        End Get
        Set(value As String)
            If (String.Equals(Me._CountryID, value) = False) Then
                Me._CountryID = value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductID", DbType:="VarChar(10)")> _
    Public Property ProductID() As String
        Get
            Return Me._ProductID
        End Get
        Set(value As String)
            If (String.Equals(Me._ProductID, value) = False) Then
                Me._ProductID = value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SAP_ProductCode", DbType:="VarChar(15)")> _
    Public Property SAP_ProductCode() As String
        Get
            Return Me._SAP_ProductCode
        End Get
        Set(value As String)
            If (String.Equals(Me._SAP_ProductCode, value) = False) Then
                Me._SAP_ProductCode = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(100)")> _
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set(value As String)
            If (String.Equals(Me._Description, value) = False) Then
                Me._Description = value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitsPerCase", DbType:="Decimal(5,0)")> _
    Public Property UnitsPerCase() As System.Nullable(Of Decimal)
        Get
            Return Me._UnitsPerCase
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._UnitsPerCase.Equals(value) = False) Then
                Me._UnitsPerCase = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PresentationID", DbType:="Int")> _
    Public Property PresentationID() As System.Nullable(Of Integer)
        Get
            Return Me._PresentationID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._PresentationID.Equals(value) = False) Then
                Me._PresentationID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PresentationName", DbType:="VarChar(50)")> _
    Public Property PresentationName() As String
        Get
            Return Me._PresentationName
        End Get
        Set(value As String)
            If (String.Equals(Me._PresentationName, value) = False) Then
                Me._PresentationName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_GroupID", DbType:="Int")> _
    Public Property GroupID() As System.Nullable(Of Integer)
        Get
            Return Me._GroupID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._GroupID.Equals(value) = False) Then
                Me._GroupID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_GroupName", DbType:="VarChar(50)")> _
    Public Property GroupName() As String
        Get
            Return Me._GroupName
        End Get
        Set(value As String)
            If (String.Equals(Me._GroupName, value) = False) Then
                Me._GroupName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SourceID", DbType:="Int")> _
    Public Property SourceID() As System.Nullable(Of Integer)
        Get
            Return Me._SourceID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._SourceID.Equals(value) = False) Then
                Me._SourceID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SourceName", DbType:="VarChar(50)")> _
    Public Property SourceName() As String
        Get
            Return Me._SourceName
        End Get
        Set(value As String)
            If (String.Equals(Me._SourceName, value) = False) Then
                Me._SourceName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryID", DbType:="Int")> _
    Public Property CategoryID() As System.Nullable(Of Integer)
        Get
            Return Me._CategoryID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._CategoryID.Equals(value) = False) Then
                Me._CategoryID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryName", DbType:="VarChar(50)")> _
    Public Property CategoryName() As String
        Get
            Return Me._CategoryName
        End Get
        Set(value As String)
            If (String.Equals(Me._CategoryName, value) = False) Then
                Me._CategoryName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SubCategoryID", DbType:="Int")> _
    Public Property SubCategoryID() As System.Nullable(Of Integer)
        Get
            Return Me._SubCategoryID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._SubCategoryID.Equals(value) = False) Then
                Me._SubCategoryID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SubCategoryName", DbType:="VarChar(50)")> _
    Public Property SubCategoryName() As String
        Get
            Return Me._SubCategoryName
        End Get
        Set(value As String)
            If (String.Equals(Me._SubCategoryName, value) = False) Then
                Me._SubCategoryName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BrandID", DbType:="Int")> _
    Public Property BrandID() As System.Nullable(Of Integer)
        Get
            Return Me._BrandID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._BrandID.Equals(value) = False) Then
                Me._BrandID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BrandName", DbType:="VarChar(50)")> _
    Public Property BrandName() As String
        Get
            Return Me._BrandName
        End Get
        Set(value As String)
            If (String.Equals(Me._BrandName, value) = False) Then
                Me._BrandName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SubBrandID", DbType:="Int")> _
    Public Property SubBrandID() As System.Nullable(Of Integer)
        Get
            Return Me._SubBrandID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._SubBrandID.Equals(value) = False) Then
                Me._SubBrandID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SubBrandName", DbType:="VarChar(50)")> _
    Public Property SubBrandName() As String
        Get
            Return Me._SubBrandName
        End Get
        Set(value As String)
            If (String.Equals(Me._SubBrandName, value) = False) Then
                Me._SubBrandName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeBrandID", DbType:="Int")> _
    Public Property TypeBrandID() As System.Nullable(Of Integer)
        Get
            Return Me._TypeBrandID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._TypeBrandID.Equals(value) = False) Then
                Me._TypeBrandID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeBrandName", DbType:="VarChar(50)")> _
    Public Property TypeBrandName() As String
        Get
            Return Me._TypeBrandName
        End Get
        Set(value As String)
            If (String.Equals(Me._TypeBrandName, value) = False) Then
                Me._TypeBrandName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SizeID", DbType:="Int")> _
    Public Property SizeID() As System.Nullable(Of Integer)
        Get
            Return Me._SizeID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._SizeID.Equals(value) = False) Then
                Me._SizeID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SizeName", DbType:="VarChar(50)")> _
    Public Property SizeName() As String
        Get
            Return Me._SizeName
        End Get
        Set(value As String)
            If (String.Equals(Me._SizeName, value) = False) Then
                Me._SizeName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FlavorID", DbType:="Int")> _
    Public Property FlavorID() As System.Nullable(Of Integer)
        Get
            Return Me._FlavorID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._FlavorID.Equals(value) = False) Then
                Me._FlavorID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FlavorName", DbType:="VarChar(50)")> _
    Public Property FlavorName() As String
        Get
            Return Me._FlavorName
        End Get
        Set(value As String)
            If (String.Equals(Me._FlavorName, value) = False) Then
                Me._FlavorName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Active_Flag", DbType:="Bit")> _
    Public Property Active_Flag() As System.Nullable(Of Boolean)
        Get
            Return Me._Active_Flag
        End Get
        Set(value As System.Nullable(Of Boolean))
            If (Me._Active_Flag.Equals(value) = False) Then
                Me._Active_Flag = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SystemOnly", DbType:="Bit")> _
    Public Property SystemOnly() As System.Nullable(Of Boolean)
        Get
            Return Me._SystemOnly
        End Get
        Set(value As System.Nullable(Of Boolean))
            If (Me._SystemOnly.Equals(value) = False) Then
                Me._SystemOnly = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Flag_innovation", DbType:="Bit")> _
    Public Property Flag_innovation() As System.Nullable(Of Boolean)
        Get
            Return Me._Flag_innovation
        End Get
        Set(value As System.Nullable(Of Boolean))
            If (Me._Flag_innovation.Equals(value) = False) Then
                Me._Flag_innovation = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartDate_innovation", DbType:="DateTime")> _
    Public Property StartDate_innovation() As System.Nullable(Of Date)
        Get
            Return Me._StartDate_innovation
        End Get
        Set(value As System.Nullable(Of Date))
            If (Me._StartDate_innovation.Equals(value) = False) Then
                Me._StartDate_innovation = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndDate_innovation", DbType:="DateTime")> _
    Public Property EndDate_innovation() As System.Nullable(Of Date)
        Get
            Return Me._EndDate_innovation
        End Get
        Set(value As System.Nullable(Of Date))
            If (Me._EndDate_innovation.Equals(value) = False) Then
                Me._EndDate_innovation = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PricePoint", DbType:="Money")> _
    Public Property PricePoint() As System.Nullable(Of Decimal)
        Get
            Return Me._PricePoint
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._PricePoint.Equals(value) = False) Then
                Me._PricePoint = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_POT_StatusID", DbType:="Int")> _
    Public Property POT_StatusID() As System.Nullable(Of Integer)
        Get
            Return Me._POT_StatusID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._POT_StatusID.Equals(value) = False) Then
                Me._POT_StatusID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitsForDistribution", DbType:="Decimal(5,0)")> _
    Public Property UnitsForDistribution() As System.Nullable(Of Decimal)
        Get
            Return Me._UnitsForDistribution
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._UnitsForDistribution.Equals(value) = False) Then
                Me._UnitsForDistribution = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeSalesID", DbType:="Int")> _
    Public Property TypeSalesID() As System.Nullable(Of Integer)
        Get
            Return Me._TypeSalesID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._TypeSalesID.Equals(value) = False) Then
                Me._TypeSalesID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeSalesName", DbType:="VarChar(50)")> _
    Public Property TypeSalesName() As String
        Get
            Return Me._TypeSalesName
        End Get
        Set(value As String)
            If (String.Equals(Me._TypeSalesName, value) = False) Then
                Me._TypeSalesName = value
                Me.IsDirty = True
            End If
        End Set
    End Property
    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Grams", DbType:="Decimal(8,4)")> _
    Public Property Grams() As System.Nullable(Of Decimal)
        Get
            Return Me._Grams
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._Grams.Equals(value) = False) Then
                Me._Grams = value
                Me.IsDirty = True
            End If
        End Set
    End Property
    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Standar_Cost", DbType:="Money")> _
    Public Property Standar_Cost() As System.Nullable(Of Decimal)
        Get
            Return Me._Standar_Cost
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._Standar_Cost.Equals(value) = False) Then
                Me._Standar_Cost = value
                Me.IsDirty = True
            End If
        End Set
    End Property
    Public Property IsDirty As Boolean
        Get
            Return Me._RecordStatus
        End Get
        Set(value As Boolean)
            Me._RecordStatus = value
        End Set
    End Property

    Sub RaiseStatusChangedEvent()
        RaiseEvent StatusChanged()
    End Sub

    'Private Event IsDirtyChanged As EventHandler(Of MyObjectEventArgs)

    'Private Sub Container_ObjectCreated(ByVal sender As Object, ByVal e As MyObjectEventArgs)
    '    RaiseStatusChangedEvent()

    'End Sub
End Class
'Partial Class MyObjectEventArgs
'    Inherits EventArgs
'    Public Property EventObject As Object

'End Class
