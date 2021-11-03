
Imports System.Globalization

Public Class GeographyEditForm
    Public Event RecordUpdated()

    Private WithEvents GeographyEditIsDirty As GeographyDirtyRecord
    Private ThisRecordtKey As Long
    Private MeasureCalled As Integer
    Dim culture As CultureInfo

#Region "Form Methods"
    Private Sub ProductEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarToolTip()
    End Sub

    Public Property GeographyKey() As Long
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
        Dim context As New SalesDataMartContext
        GeographyEditIsDirty = New GeographyDirtyRecord

        Dim _D05geography = (From geography In context.D05_GEOGRAPHY
          Where
              geography.GeographicKey = ThisRecordtKey
            Select geography).SingleOrDefault

        With _D05geography
            CountryIDLabel.Text = .CountryID
            CountryNameLabel.Text = .CountryName
            Me.cboBranchID.SelectedValue = .BranchID
            Me.cboDistrictID.SelectedValue = .DistrictID
            Me.cboMUID.SelectedValue = .MUID
            Me.cboRSRId.SelectedValue = .RSRId
            'Me.cboTypeRouteID.SelectedValue = .TypeRouteID
            Me.cboZoneID.SelectedValue = .ZoneID
            If Not IsNothing(.RouteID) Then
                Me.RouteIDText.Text = .RouteID
            End If
            Me.FlagActiveCB.Checked = .Flag_Active
            Me.SystemOnlyCB.Checked = .SystemOnly
        End With


        With GeographyEditIsDirty
            '.Active_Flag = _D05geography.Flag_Active

            .BranchID = _D05geography.BranchID
            .BranchName = Me.cboBranchID.Text
            .CountryID = _D05geography.CountryID
            .CountryName = _D05geography.CountryName
            .DistrictID = _D05geography.DistrictID

            .DistrictName = cboRSRId.Text
            .MUID = _D05geography.MUID
            .Market_Unit = _D05geography.Market_Unit
            .RSRId = _D05geography.RSRId
            .RSRName = Me.cboRSRId.Text

            .TypeRouteID = _D05geography.TypeRouteID
            .TypeRouteName = Me.cboTypeRouteID.Text
            .ZoneID = _D05geography.ZoneID
            .ZoneName = Me.cboZoneID.Text
            .Flag_Active = _D05geography.Flag_Active

            .RouteID = _D05geography.RouteID
        End With
        GeographyEditIsDirty.IsDirty = False
    End Sub
#End Region

#Region "Form Data Events & methods"
    Private Function UpdateProductInfo() As Boolean
        Using context = New SalesDataMartContext
            Dim _M05geography = (From geography In context.M05_Geography
            Where
            geography.GeographicKey = ThisRecordtKey
            Select geography).SingleOrDefault

            With _M05geography
                '.GeographicKey
                '.CountryID
                .Active_Flag = GeographyEditIsDirty.Flag_Active
                .BranchID = GeographyEditIsDirty.BranchID
                .DistrictID = GeographyEditIsDirty.DistrictID
                .MUID = GeographyEditIsDirty.MUID
                .RouteID = GeographyEditIsDirty.RouteID
                .RSRId = GeographyEditIsDirty.RSRId
                '.SystemOnly = GeographyEditIsDirty.SystemOnly
                .TypeRouteID = GeographyEditIsDirty.TypeRouteID
                .ZoneID = GeographyEditIsDirty.ZoneID

            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Using context = New SalesDataMartContext
            Dim _D01geography = (From geography In context.D05_GEOGRAPHY
            Where
            geography.GeographicKey = ThisRecordtKey
            Select geography).SingleOrDefault
            With _D01geography
                '.GeographicKey
                '.CountryID = GeographyEditIsDirty.CountryID
                '.CountryName = GeographyEditIsDirty.CountryName
                '.SystemOnly

                .Flag_Active = GeographyEditIsDirty.Flag_Active
                .BranchID = GeographyEditIsDirty.BranchID
                .BranchName = GeographyEditIsDirty.BranchName
                .DistrictID = GeographyEditIsDirty.DistrictID
                .DistrictName = GeographyEditIsDirty.DistrictName
                .Market_Unit = GeographyEditIsDirty.Market_Unit
                .MUID = GeographyEditIsDirty.MUID
                .RouteID = GeographyEditIsDirty.RouteID
                .RSRId = GeographyEditIsDirty.RSRId
                .RSRName = GeographyEditIsDirty.RSRName
                .TypeRouteID = GeographyEditIsDirty.TypeRouteID
                .TypeRouteName = GeographyEditIsDirty.TypeRouteName
                .ZoneID = GeographyEditIsDirty.ZoneID
                .ZoneName = GeographyEditIsDirty.ZoneName
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

    Sub GeographyEditIsDirty_EventHandler() Handles GeographyEditIsDirty.StatusChanged
        Me.SaveButton.Enabled = GeographyEditIsDirty.IsDirty
    End Sub


    Private Sub ActiveFlagCB_CheckedChanged(sender As Object, e As EventArgs) Handles FlagActiveCB.CheckedChanged
        With GeographyEditIsDirty
            .Flag_Active = FlagActiveCB.CheckState
            .IsDirty = True
        End With
    End Sub

    Private Sub cboBranchID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBranchID.SelectionChangeCommitted
        With GeographyEditIsDirty
            .BranchName = cboBranchID.Text
            .BranchID = cboBranchID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboRSRId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRSRId.SelectionChangeCommitted
        With GeographyEditIsDirty
            .RSRName = cboRSRId.Text
            .RSRId = cboRSRId.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboMUID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMUID.SelectionChangeCommitted
        With GeographyEditIsDirty
            .Market_Unit = cboMUID.Text
            .MUID = cboMUID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboDistrictID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDistrictID.SelectionChangeCommitted
        With GeographyEditIsDirty
            .DistrictName = cboDistrictID.Text
            .DistrictID = cboDistrictID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    
    Private Sub cboZoneID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboZoneID.SelectionChangeCommitted
        With GeographyEditIsDirty
            .ZoneName = cboZoneID.Text
            .ZoneID = cboZoneID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboTypeRouteID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTypeRouteID.SelectionChangeCommitted
        With GeographyEditIsDirty
            .TypeRouteName = cboTypeRouteID.Text
            .TypeRouteID = cboTypeRouteID.SelectedValue
            .IsDirty = True
        End With
    End Sub
   
  


    Private Sub RouteIDText_TextChanged(sender As Object, e As EventArgs)
        With GeographyEditIsDirty
            .RouteID = RouteIDText.Text
            .IsDirty = True
        End With
    End Sub
#End Region

#Region "Measures Buttons"
    Private Sub PresentationButton_Click(sender As Object, e As EventArgs) Handles BranchButton.Click
        MeasureCalled = GeographyMeasuresIndex.Branches
        LoadMeasureForm()
    End Sub

    Private Sub GroupButton_Click(sender As Object, e As EventArgs) Handles DistrictButton.Click
        MeasureCalled = GeographyMeasuresIndex.Districts
        LoadMeasureForm()
    End Sub
    Private Sub SourceButton_Click(sender As Object, e As EventArgs) Handles MUIDButton.Click
        MeasureCalled = GeographyMeasuresIndex.MUIDs
        LoadMeasureForm()
    End Sub
    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles RSRIdButton.Click
        MeasureCalled = GeographyMeasuresIndex.RSRIds
        LoadMeasureForm()
    End Sub
    Private Sub SubCategoryButton_Click(sender As Object, e As EventArgs) Handles TypeRouteButton.Click
        MeasureCalled = GeographyMeasuresIndex.TypeRoutes
        LoadMeasureForm()
    End Sub

    Private Sub TypeOfSalesButton_Click(sender As Object, e As EventArgs) Handles ZoneButton.Click
        MeasureCalled = GeographyMeasuresIndex.Zones
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
        With New GeographyMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Sub ActivarToolTip()
        Me.ToolTip1.UseAnimation = True
        Me.ToolTip1.SetToolTip(BranchButton, "Agregar Branch")
        Me.ToolTip1.SetToolTip(DistrictButton, "Agregar District")
        Me.ToolTip1.SetToolTip(MUIDButton, "Agregar Market Unit ")
        Me.ToolTip1.SetToolTip(RSRIdButton, "Agregar RSRI")
        Me.ToolTip1.SetToolTip(TypeRouteButton, "Agregar Type of Route")
        Me.ToolTip1.SetToolTip(ZoneButton, "Agregar Zone")
      
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

#End Region
End Class