Public Class CustomerDirtyRecord
    Public Event StatusChanged()
    Private _RecordStatus As Boolean

    'D02_CUSTOMER
    Private _CustomerKey As Integer
    Private _CountryID As String
    Private _CustomerID As String
    Private _SAP_CustomerCode As String
    Private _Customer_Name As String
    Private _KeyAccountID As System.Nullable(Of Integer)
    Private _KeyAccounName As String
    Private _PayMtID As System.Nullable(Of Integer)
    Private _PayMtMthodName As String
    Private _ChainID As System.Nullable(Of Integer)
    Private _ChainName As String
    Private _CategoryID As System.Nullable(Of Integer)
    Private _CategoryName As String
    Private _WeeklyDROPSize As System.Nullable(Of Decimal)
    Private _LastSalesDate As System.Nullable(Of Date)
    Private _CreationDate As System.Nullable(Of Date)
    Private _Flag_Active As System.Nullable(Of Boolean)
    Private _SystemOnly As System.Nullable(Of Boolean)
    Private _EventualKey_Client As String
    Private _Delivery_Area As String

    Public Property CustomerKey() As Integer
        Get
            Return Me._CustomerKey
        End Get
        Set(value As Integer)
            If ((Me._CustomerKey = value) _
                        = False) Then
                Me._CustomerKey = value
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
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property CustomerID() As String
        Get
            Return Me._CustomerID
        End Get
        Set(value As String)
            If (String.Equals(Me._CustomerID, value) = False) Then
                Me._CustomerID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property SAP_CustomerCode() As String
        Get
            Return Me._SAP_CustomerCode
        End Get
        Set(value As String)
            If (String.Equals(Me._SAP_CustomerCode, value) = False) Then
                Me._SAP_CustomerCode = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property Customer_Name() As String
        Get
            Return Me._Customer_Name
        End Get
        Set(value As String)
            If (String.Equals(Me._Customer_Name, value) = False) Then
                Me._Customer_Name = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property KeyAccountID() As System.Nullable(Of Integer)
        Get
            Return Me._KeyAccountID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._KeyAccountID.Equals(value) = False) Then
                Me._KeyAccountID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property KeyAccounName() As String
        Get
            Return Me._KeyAccounName
        End Get
        Set(value As String)
            If (String.Equals(Me._KeyAccounName, value) = False) Then
                Me._KeyAccounName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property PayMtID() As System.Nullable(Of Integer)
        Get
            Return Me._PayMtID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._PayMtID.Equals(value) = False) Then
                Me._PayMtID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property PayMtMthodName() As String
        Get
            Return Me._PayMtMthodName
        End Get
        Set(value As String)
            If (String.Equals(Me._PayMtMthodName, value) = False) Then
                Me._PayMtMthodName = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property ChainID() As System.Nullable(Of Integer)
        Get
            Return Me._ChainID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._ChainID.Equals(value) = False) Then
                Me._ChainID = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property ChainName() As String
        Get
            Return Me._ChainName
        End Get
        Set(value As String)
            If (String.Equals(Me._ChainName, value) = False) Then
                Me._ChainName = value
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

    Public Property WeeklyDROPSize() As System.Nullable(Of Decimal)
        Get
            Return Me._WeeklyDROPSize
        End Get
        Set(value As System.Nullable(Of Decimal))
            If (Me._WeeklyDROPSize.Equals(value) = False) Then
                Me._WeeklyDROPSize = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property LastSalesDate() As System.Nullable(Of Date)
        Get
            Return Me._LastSalesDate
        End Get
        Set(value As System.Nullable(Of Date))
            If (Me._LastSalesDate.Equals(value) = False) Then
                Me._LastSalesDate = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property CreationDate() As System.Nullable(Of Date)
        Get
            Return Me._CreationDate
        End Get
        Set(value As System.Nullable(Of Date))
            If (Me._CreationDate.Equals(value) = False) Then
                Me._CreationDate = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property Flag_Active() As System.Nullable(Of Boolean)
        Get
            Return Me._Flag_Active
        End Get
        Set(value As System.Nullable(Of Boolean))
            If (Me._Flag_Active.Equals(value) = False) Then
                Me._Flag_Active = value
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

    Public Property EventualKey_Client() As String
        Get
            Return Me._EventualKey_Client
        End Get
        Set(value As String)
            If (String.Equals(Me._EventualKey_Client, value) = False) Then
                Me._EventualKey_Client = value
                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property Delivery_Area() As String
        Get
            Return Me._Delivery_Area
        End Get
        Set(value As String)
            If (String.Equals(Me._Delivery_Area, value) = False) Then
                Me._Delivery_Area = value
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
