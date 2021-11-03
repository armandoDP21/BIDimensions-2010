Public Class HomologationEditionUC
    Public Event RecordUpdated()
    Private _HomologationType As HomologationTypes
    Public WriteOnly Property HType As HomologationTypes
        Set(value As HomologationTypes)
            _HomologationType = value
            ConfigUC()
            FillCombo()
        End Set
    End Property

#Region "Update data"
    Private Sub UpdateRecord()
        Select Case _HomologationType
            Case HomologationTypes.BrandCategory
                BrandAndCategoryUpdate()
            Case HomologationTypes.Flavor
                FlavorUpdate()
            Case HomologationTypes.Presentation
                PresentationUpdate()
            Case HomologationTypes.ProductGroup
                ProductGroupUpdate()
            Case HomologationTypes.Size
                SizeUpdate()
            Case HomologationTypes.Source
                SourceUpdate()
            Case HomologationTypes.SubBrand
                SubBrandUpdate()
            Case HomologationTypes.SubCategory
                SubCategoryUpdate()
            Case HomologationTypes.TypeBrand
                TypeBrandUpdate()
            Case HomologationTypes.TypeOFSales
                TypeOFSalesUpdate()
            Case Else

        End Select
        'raisevent 

    End Sub

    Private Sub BrandAndCategoryUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboCategories.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub FlavorUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Flavor Where
            record.SystemID = InfoCache.SystemId And
            record.FlavorSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .FlavorID = Me.cboNames.SelectedValue
                .FlavorSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PresentationUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Presentation Where
            record.SystemID = InfoCache.SystemId And
            record.PresentSourceName = Me.SourceCodeLabel.Text And
            record.PresentSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .PresentationID = Me.cboNames.SelectedValue
                .PresentSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using

    End Sub

    Private Sub ProductGroupUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SizeUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SourceUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SubBrandUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SubCategoryUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub TypeBrandUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub TypeOFSalesUpdate()
        Using context = New SalesStagingContext
            Dim RecordToSave = (From record In context.HOM_Brand Where
            record.SystemID = InfoCache.SystemId And
            record.BrandSourceCode = Me.BrandSourceCodeLabel.Text And
            record.UnionSourceCode = Me.SourceCodeLabel.Text
            Select record).SingleOrDefault

            With RecordToSave
                .CategoryID = Me.cboNames.SelectedValue
                .BrandSourceName = Me.cboNames.Text
            End With
            Try
                context.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

#End Region
#Region "Fill Combos & Update UI"
    Private Sub FillCombo()
        Select Case _HomologationType
            Case HomologationTypes.BrandCategory
                BrandAndCategoryFillCombos()
            Case HomologationTypes.Flavor
                FlavorFillCombo()
            Case HomologationTypes.Presentation
                PresentationFillCombo()
            Case HomologationTypes.ProductGroup
                ProductGroupFillCombo()
            Case HomologationTypes.Size
                SizeCombo()
            Case HomologationTypes.Source
                SourceFillCombo()
            Case HomologationTypes.SubBrand
                SubBrandFillCombo()
            Case HomologationTypes.SubCategory
                SubCategoryFillCombo()
            Case HomologationTypes.TypeBrand
                TypeBrandFillCombo()
            Case HomologationTypes.TypeOFSales
                TypeOFSalesFillCombo()
            Case Else
                'FlavorFillCombo()
        End Select

    End Sub
    Private Sub BrandAndCategoryFillCombos()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_Brand.ToList.OrderBy(Function(o) o.BrandName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "BrandName"
                .ValueMember = "BrandID"
            End With

            Dim CatList = context.M01_Category.ToList.OrderBy(Function(o) o.CategoryName)
            With Me.cboCategories
                .DataSource = CatList.ToList
                .DisplayMember = "CategoryName"
                .ValueMember = "CategoryID"
            End With
        End Using
    End Sub
    Private Sub FlavorFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_Flavor.ToList.OrderBy(Function(o) o.FlavorName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "FlavorName"
                .ValueMember = "FlavorID"
            End With

        End Using
    End Sub
    Private Sub PresentationFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_Presentation.ToList.OrderBy(Function(o) o.PresentationName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "PresentationName"
                .ValueMember = "PresentationID"
            End With


        End Using
    End Sub
    Private Sub ProductGroupFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_ProductGroup.ToList.OrderBy(Function(o) o.GroupName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "GroupName"
                .ValueMember = "GroupID"
            End With


        End Using
    End Sub
    Private Sub SizeCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_Size.ToList.OrderBy(Function(o) o.SizeName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "SizeName"
                .ValueMember = "SizeID"
            End With
        End Using
    End Sub
    Private Sub SourceFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_Source.ToList.OrderBy(Function(o) o.SourceName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "SourceName"
                .ValueMember = "SourceID"
            End With
        End Using
    End Sub
    Private Sub SubBrandFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_SubBrand.ToList.OrderBy(Function(o) o.SubBrandName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "SubBrandName"
                .ValueMember = "SubBrandID"
            End With
        End Using
    End Sub
    Private Sub SubCategoryFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_SubCategory.ToList.OrderBy(Function(o) o.SubCategoryName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "SubCategoryName"
                .ValueMember = "SubCategoryID"
            End With
        End Using
    End Sub
    Private Sub TypeBrandFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_TypeBrand.ToList.OrderBy(Function(o) o.TypeBrandName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "TypeBrandName"
                .ValueMember = "TypeBrandID"
            End With
        End Using
    End Sub
    Private Sub TypeOFSalesFillCombo()
        Using context As SalesDataMartContext = New SalesDataMartContext
            Dim RecordsList = context.M01_TypeOFSales.ToList.OrderBy(Function(o) o.TypeSalesName)
            With Me.cboNames
                .DataSource = RecordsList.ToList
                .DisplayMember = "TypeOFSalesName"
                .ValueMember = "TypeSalesID"
            End With
        End Using
    End Sub
    Private Sub ConfigUC()
        If Me._HomologationType = HomologationTypes.BrandCategory Then
            Me.Label3.Visible = True
            Me.RightPanel.Visible = True
            Me.SaveButton.Left = 413
        Else
            Me.Label3.Visible = False
            Me.RightPanel.Visible = False
            Me.SaveButton.Left = 207
        End If
    End Sub
    Public Sub ActivateControl()
        Me.cboNames.Enabled = True
        Me.LeftPanel.Enabled = True
        Me.RightPanel.Enabled = True
        Me.SaveButton.Enabled = True
        If _HomologationType = HomologationTypes.BrandCategory Then
            Me.cboCategories.Enabled = True
        Else
            Me.cboCategories.Enabled = False
        End If
        Me.SaveButton.Focus()
    End Sub
    Public Sub DeActivateControl()
        Me.LeftPanel.Enabled = False
        Me.RightPanel.Enabled = False
        Me.SaveButton.Enabled = False
    End Sub
#End Region

#Region "Events"
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        UpdateRecord()
        RaiseEvent RecordUpdated()
    End Sub
    'Private Sub HOMEditionUC_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
    '    DeActivateControl()
    'End Sub
#End Region
End Class
