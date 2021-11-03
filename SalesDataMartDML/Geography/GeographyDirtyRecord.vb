Public Class GeographyDirtyRecord
    Public Event StatusChanged()
    Private _RecordStatus As Boolean

    'D05_GEOGRAPHY
    Private _GeographicKey As Integer
    Private _CountryID As String
    Private _CountryName As String
    Private _BranchID As System.Nullable(Of Integer)
    Private _BranchName As String
    Private _ZoneID As System.Nullable(Of Integer)
    Private _ZoneName As String
    Private _MUID As System.Nullable(Of Integer)
    Private _Market_Unit As String
    Private _RouteID As String
    Private _DistrictID As System.Nullable(Of Integer)
    Private _DistrictName As String
    Private _RSRId As System.Nullable(Of Integer)
    Private _RSRName As String
    Private _TypeRouteID As System.Nullable(Of Integer)
    Private _TypeRouteName As String
    Private _Flag_Active As System.Nullable(Of Boolean)
    Private _SystemOnly As System.Nullable(Of Boolean)

    Public Property GeographicKey() As Integer
        Get
            Return Me._GeographicKey
        End Get
        Set(value As Integer)
            If ((Me._GeographicKey = value) _
                        = False) Then


                Me._GeographicKey = value

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

    Public Property CountryName() As String
        Get
            Return Me._CountryName
        End Get
        Set(value As String)
            If (String.Equals(Me._CountryName, value) = False) Then


                Me._CountryName = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property BranchID() As System.Nullable(Of Integer)
        Get
            Return Me._BranchID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._BranchID.Equals(value) = False) Then


                Me._BranchID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property BranchName() As String
        Get
            Return Me._BranchName
        End Get
        Set(value As String)
            If (String.Equals(Me._BranchName, value) = False) Then


                Me._BranchName = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property ZoneID() As System.Nullable(Of Integer)
        Get
            Return Me._ZoneID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._ZoneID.Equals(value) = False) Then


                Me._ZoneID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property ZoneName() As String
        Get
            Return Me._ZoneName
        End Get
        Set(value As String)
            If (String.Equals(Me._ZoneName, value) = False) Then


                Me._ZoneName = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property MUID() As System.Nullable(Of Integer)
        Get
            Return Me._MUID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._MUID.Equals(value) = False) Then


                Me._MUID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property Market_Unit() As String
        Get
            Return Me._Market_Unit
        End Get
        Set(value As String)
            If (String.Equals(Me._Market_Unit, value) = False) Then


                Me._Market_Unit = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property RouteID() As String
        Get
            Return Me._RouteID
        End Get
        Set(value As String)
            If (String.Equals(Me._RouteID, value) = False) Then


                Me._RouteID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property DistrictID() As System.Nullable(Of Integer)
        Get
            Return Me._DistrictID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._DistrictID.Equals(value) = False) Then


                Me._DistrictID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property DistrictName() As String
        Get
            Return Me._DistrictName
        End Get
        Set(value As String)
            If (String.Equals(Me._DistrictName, value) = False) Then


                Me._DistrictName = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property RSRId() As System.Nullable(Of Integer)
        Get
            Return Me._RSRId
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._RSRId.Equals(value) = False) Then


                Me._RSRId = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property RSRName() As String
        Get
            Return Me._RSRName
        End Get
        Set(value As String)
            If (String.Equals(Me._RSRName, value) = False) Then


                Me._RSRName = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property TypeRouteID() As System.Nullable(Of Integer)
        Get
            Return Me._TypeRouteID
        End Get
        Set(value As System.Nullable(Of Integer))
            If (Me._TypeRouteID.Equals(value) = False) Then


                Me._TypeRouteID = value

                Me.IsDirty = True
            End If
        End Set
    End Property

    Public Property TypeRouteName() As String
        Get
            Return Me._TypeRouteName
        End Get
        Set(value As String)
            If (String.Equals(Me._TypeRouteName, value) = False) Then


                Me._TypeRouteName = value

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
