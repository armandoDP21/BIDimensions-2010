Public Class ProductDirtyRecord
    Public Event StatusChanged()
    Private _RecordStatus As Boolean

    'D01_PRODUCT
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
            RaiseStatusChangedEvent()
        End Set
    End Property

    Sub RaiseStatusChangedEvent()
        RaiseEvent StatusChanged()
    End Sub

End Class

