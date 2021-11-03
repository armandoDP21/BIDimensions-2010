Imports System.Globalization
Public Class CustomerEditForm
    Public Event RecordUpdated()
    Private WithEvents CustomerDirtyRecord As CustomerDirtyRecord
    Private ThisRecordtKey As Long
    Private MeasureCalled As Integer
    Dim culture As CultureInfo

#Region "Form Methods"

    Private Sub CustomerEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ActivarToolTip()
    End Sub
    Public Property customerkey() As Long
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
        CustomerDirtyRecord = New CustomerDirtyRecord
        Dim _D02customer = (From customers In context.D02_CUSTOMERS
          Where
              customers.CustomerKey = ThisRecordtKey
                Select customers).SingleOrDefault

        With _D02customer

            CustomerIDLabel.Text = .customerid.ToString
            If String.IsNullOrEmpty(.SAP_CustomerCode) Then
                SAP_CustomerCodeText.Text = "SAP Customer Code pendiente"
            Else
                SAP_CustomerCodeText.Text = .SAP_CustomerCode
            End If
            CustomerNameLabel.Text = .Customer_Name

            Me.cboCategoryID.SelectedValue = .CategoryID
            Me.cboChainID.SelectedValue = .ChainID
            Me.cboCountryID.SelectedValue = .CountryID
            Me.cboKeyAccountID.SelectedValue = .KeyAccountID
            Me.cboPayMtID.SelectedValue = .PayMtID

            If Not IsNothing(.WeeklyDROPSize) Then
                Me.WeeklyDROPSizeText.Text = .WeeklyDROPSize
            End If
            If Not IsNothing(.LastSalesDate) Then
                Me.LastSalesDateText.Text = .LastSalesDate
            End If
            If Not IsNothing(.CreationDate) Then
                Me.CreationDateText.Text = .CreationDate
            End If
            If Not IsNothing(.EventualKey_Client) Then
                Me.EventualKey_ClientText.Text = .EventualKey_Client
            End If
            If Not IsNothing(.Delivery_Area) Then
                Me.Delivery_AreaText.Text = .Delivery_Area
            End If

            Me.Flag_ActiveCB.Checked = .Flag_Active

        End With
        With CustomerDirtyRecord
            .Flag_Active = _D02customer.Flag_Active
            .CategoryID = _D02customer.CategoryID
            .CategoryName = cboCategoryID.Text
            .CountryID = _D02customer.CountryID
            .Customer_Name = _D02customer.Customer_Name
            .CategoryID = _D02customer.CategoryID
            .CategoryName = Me.cboCategoryID.Text
            .ChainID = _D02customer.ChainID
            .ChainName = Me.cboChainID.Text
            .CountryID = _D02customer.CountryID
            .WeeklyDROPSize = _D02customer.WeeklyDROPSize
            .customerid = _D02customer.CustomerID
            .customerkey = _D02customer.CustomerKey
            .SAP_CustomerCode = _D02customer.SAP_CustomerCode
            .KeyAccountID = _D02customer.KeyAccountID
            .KeyAccounName = Me.cboKeyAccountID.Text
            .PayMtID = _D02customer.PayMtID
            .PayMtMthodName = Me.cboPayMtID.Text
            .SystemOnly = _D02customer.SystemOnly

            '.WeeklyDROPSize = _D02customer.WeeklyDROPSize
            '.BrandName = Me.cboWeeklyDROPSize.Text
            '.EndDate_innovation = _D02customer.EndDate_innovation
            '.Flag_innovation = _D02customer.Flag_innovation
            '.POT_StatusID = _D02customer.POT_StatusID
            '.CountryName = Me.CountryID.Text
            '.StartDate_innovation = _D02customer.StartDate_innovation
            '.WeeklyDROPSize = _D02customer.WeeklyDROPSize
            '.SubBrandName = Me.cboWeeklyDROPSize.Text
            '.SubCategoryID = _D02customer.SubCategoryID
            '.SubCategoryName = Me.cboSubCategoryID.Text
            '.WeeklyDROPSize = _D02customer.WeeklyDROPSize
            '.TypeBrandName = Me.cboWeeklyDROPSize.Text
            '.TypeSalesID = _D02customer.TypeSalesID
            '.TypeSalesName = Me.cboTypeSalesID.Text


            If Not IsDBNull(_D02customer.Delivery_Area) Then
                .Delivery_Area = _D02customer.Delivery_Area
            End If
            If Not IsDBNull(_D02customer.LastSalesDate) Then
                .LastSalesDate = _D02customer.LastSalesDate
            End If
            If Not IsDBNull(_D02customer.CreationDate) Then
                .CreationDate = _D02customer.CreationDate
            End If
            If Not IsDBNull(_D02customer.EventualKey_Client) Then
                .EventualKey_Client = _D02customer.EventualKey_Client
            End If


        End With
        CustomerDirtyRecord.IsDirty = False
    End Sub
#End Region

#Region "Form Data Events & methods"
    Private Function UpdateCustomerInfo() As Boolean
        Using context = New SalesDataMartContext
            Dim _D02customer = (From customers In context.M02_CUSTOMERS
            Where
            customers.customerkey = ThisRecordtKey
            Select customers).SingleOrDefault


            With _D02customer
                .Flag_Active = CustomerDirtyRecord.WeeklyDROPSize
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                .CategoryID = CustomerDirtyRecord.CategoryID

                '.CountryID = 
                '.CustomerName = 
                '.EndDate_innovation
                '.Flag_innovation

                .CategoryID = CustomerDirtyRecord.CategoryID
                .CreationDate = CustomerDirtyRecord.CreationDate
                .ChainID = CustomerDirtyRecord.ChainID
                .CountryID = CustomerDirtyRecord.CountryID
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize

                '.customerid
                '.customerkey

                .SAP_CustomerCode = CustomerDirtyRecord.SAP_CustomerCode
                .KeyAccountID = CustomerDirtyRecord.KeyAccountID
                .PayMtID = CustomerDirtyRecord.PayMtID
                .EventualKey_Client = CustomerDirtyRecord.EventualKey_Client
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                .Delivery_Area = CustomerDirtyRecord.Delivery_Area
                .LastSalesDate = CustomerDirtyRecord.LastSalesDate

                '.POT_StatusID = CustomerDirtyRecord.POT_StatusID
                '.StartDate_innovation = CustomerDirtyRecord.StartDate_innovation
                '.WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                '.SubCategoryID = CustomerDirtyRecord.SubCategoryID
                '.SystemOnly
                '.TypeSalesID = CustomerDirtyRecord.TypeSalesID

            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Using context = New SalesDataMartContext
            Dim _M02customer = (From customers In context.D02_CUSTOMERS
            Where
            customers.CustomerKey = ThisRecordtKey
            Select customers).SingleOrDefault

            With _M02customer
                .Flag_Active = CustomerDirtyRecord.Flag_Active
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                .CategoryID = CustomerDirtyRecord.CategoryID
                .CategoryName = CustomerDirtyRecord.CategoryName
                '.CountryID = CustomerDirtyRecord.CountryID
                '.CustomerName = CustomerDirtyRecord.CustomerName
                '.BrandName = CustomerDirtyRecord.BrandName
                '.EndDate_innovation = CustomerDirtyRecord.EndDate_innovation
                '.Flag_innovation = CustomerDirtyRecord.Flag_innovation
                .CategoryID = CustomerDirtyRecord.CategoryID
                .CategoryName = CustomerDirtyRecord.CategoryName
                .ChainID = CustomerDirtyRecord.ChainID
                .ChainName = CustomerDirtyRecord.ChainName
                '.POT_StatusID = CustomerDirtyRecord.POT_StatusID
                .CountryID = CustomerDirtyRecord.CountryID
                '.CountryName = CustomerDirtyRecord.CountryName
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                '.customerid = CustomerDirtyRecord.customerid
                '.customerkey = CustomerDirtyRecord.customerkey
                .SAP_CustomerCode = CustomerDirtyRecord.SAP_CustomerCode
                .KeyAccountID = CustomerDirtyRecord.KeyAccountID
                .KeyAccounName = CustomerDirtyRecord.KeyAccounName
                .PayMtID = CustomerDirtyRecord.PayMtID
                .PayMtMthodName = CustomerDirtyRecord.PayMtMthodName
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                .SystemOnly = CustomerDirtyRecord.SystemOnly
                .WeeklyDROPSize = CustomerDirtyRecord.WeeklyDROPSize
                .Delivery_Area = CustomerDirtyRecord.Delivery_Area
                .LastSalesDate = CustomerDirtyRecord.LastSalesDate
                '.StartDate_innovation = CustomerDirtyRecord.StartDate_innovation
                '.SubBrandName = CustomerDirtyRecord.SubBrandName
                '.SubCategoryID = CustomerDirtyRecord.SubCategoryID
                '.SubCategoryName = CustomerDirtyRecord.SubCategoryName
                '.TypeBrandName = CustomerDirtyRecord.TypeBrandName
                '.TypeSalesID = CustomerDirtyRecord.TypeSalesID
                '.TypeSalesName = CustomerDirtyRecord.TypeSalesName
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

    Sub CustomerDirtyRecord_EventHandler() Handles CustomerDirtyRecord.StatusChanged
        Me.SaveButton.Enabled = CustomerDirtyRecord.IsDirty
    End Sub
    Private Sub SAP_CustomerCodeText_TextChanged(sender As Object, e As EventArgs) Handles SAP_CustomerCodeText.TextChanged
        With CustomerDirtyRecord
            .SAP_CustomerCode = SAP_CustomerCodeText.Text
            .IsDirty = True
        End With
    End Sub

    Private Sub Flag_ActiveCB_CheckedChanged(sender As Object, e As EventArgs) Handles Flag_ActiveCB.CheckedChanged
        With CustomerDirtyRecord
            .Flag_Active = Flag_ActiveCB.CheckState
            .IsDirty = True
        End With
    End Sub

    Private Sub cboCategoryID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoryID.SelectionChangeCommitted
        With CustomerDirtyRecord
            .CategoryName = cboCategoryID.Text
            .CategoryID = cboCategoryID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboChainID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboChainID.SelectionChangeCommitted
        With CustomerDirtyRecord
            .ChainName = cboChainID.Text
            .ChainID = cboChainID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboKeyAccountID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboKeyAccountID.SelectionChangeCommitted
        With CustomerDirtyRecord
            .KeyAccounName = cboKeyAccountID.Text
            .KeyAccountID = cboKeyAccountID.SelectedValue
            .IsDirty = True
        End With
    End Sub
    Private Sub cboPayMtID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPayMtID.SelectionChangeCommitted
        With CustomerDirtyRecord
            .PayMtMthodName = cboPayMtID.Text
            .PayMtID = cboPayMtID.SelectedValue
            .IsDirty = True
        End With
    End Sub



    Private Sub EventualKey_ClientText_TextChanged(sender As Object, e As EventArgs) Handles EventualKey_ClientText.TextChanged
        With CustomerDirtyRecord
            .EventualKey_Client = EventualKey_ClientText.Text
            .IsDirty = True
        End With
    End Sub
    Private Sub WeeklyDROPSizeText_TextChanged(sender As Object, e As EventArgs) Handles WeeklyDROPSizeText.TextChanged
        With CustomerDirtyRecord
            .WeeklyDROPSize = WeeklyDROPSizeText.Text
            .IsDirty = True
        End With
    End Sub
    Private Sub LastSalesDateText_TextChanged(sender As Object, e As EventArgs) Handles LastSalesDateText.TextChanged
        With CustomerDirtyRecord
            .LastSalesDate = LastSalesDateText.Text
            .IsDirty = True
        End With
    End Sub
    Private Sub CreationDateText_TextChanged(sender As Object, e As EventArgs) Handles CreationDateText.TextChanged
        With CustomerDirtyRecord
            .CreationDate = CreationDateText.Text
            .IsDirty = True
        End With
    End Sub
    Private Sub Delivery_AreaText_TextChanged(sender As Object, e As EventArgs) Handles Delivery_AreaText.TextChanged
        With CustomerDirtyRecord
            .Delivery_Area = Delivery_AreaText.Text
            .IsDirty = True
        End With
    End Sub
#End Region

#Region "Measures Buttons"
    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        MeasureCalled = CustomersMeasuresIndex.Categories
        LoadMeasureForm()
    End Sub

    Private Sub ChainIButton_Click(sender As Object, e As EventArgs) Handles ChainButton.Click
        MeasureCalled = CustomersMeasuresIndex.Chains
        LoadMeasureForm()
    End Sub
    Private Sub KeyAccountButton_Click(sender As Object, e As EventArgs) Handles KeyAccountButton.Click
        MeasureCalled = CustomersMeasuresIndex.KeyAccounts
        LoadMeasureForm()
    End Sub
    Private Sub PayMtButton_Click(sender As Object, e As EventArgs) Handles PayMtIDButton.Click
        MeasureCalled = CustomersMeasuresIndex.PayMethods
        LoadMeasureForm()
    End Sub

#End Region
#Region "Events"
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        UpdateCustomerInfo()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Hide()
    End Sub
    Private Sub CustomerEditForm_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Me.ActiveControl.GetType() = GetType(TextBox) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub CustomerEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        With New customersMeasuresForm(MeasureCalled)
            .ShowDialog()
        End With
    End Sub
    Private Sub ActivarToolTip()
        Me.ToolTip1.UseAnimation = True
        Me.ToolTip1.SetToolTip(CategoryButton, "Agregar Categoría")
        Me.ToolTip1.SetToolTip(ChainButton, "Agregar Chain")
        Me.ToolTip1.SetToolTip(KeyAccountButton, "Agregar Key Account")
        Me.ToolTip1.SetToolTip(PayMtIDButton, "Agregar Pay Method")
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

#End Region




End Class