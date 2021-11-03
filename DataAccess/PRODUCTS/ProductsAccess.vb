Imports System.Data.SqlClient
Imports System.Text

Public Class ProductsAccess
    Public Function ProductsNonRelatedSelectData() As ProductsDS

        Dim ProductsData As ProductsDS = New ProductsDS

        'start = Microsoft.VisualBasic.DateAndTime.Timer
        'RaiseEvent Mensaje(Format(Date.Now, "R") & "> Proceso: " & ProcessId)
        'RaiseEvent Mensaje(Format(Date.Now, "R") & "> Iniciado a")
        Try
            'RaiseEvent Mensaje(Format(Date.Now, "R") & "> Abriendo conexión a ODS")

            Using connection As New SqlConnection(InfoCache.ConnectionString)
                'connection.FireInfoMessageEventOnUserErrors = True
                connection.Open()
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(ProductsNonRelatedSelectSqlString(), connection)
                adapter.Fill(ProductsData, "D01_PRODUCTS")

                'RaiseEvent Mensaje(Format(Date.Now, "R") & "> Se registrará " & dataGL.Tables("SAP_GL_INTERFASE").Rows.Count.ToString & " registros...")

            End Using

            'RaiseEvent Mensaje(Format(Date.Now, "R") & "> Copia de registros a ODS terminado.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Return ProductsData.Tables("Ledger_Events")
        Return ProductsData
    End Function
    Public Function ProductsAllSelectSqlString() As String
        Dim StrSql As New StringBuilder

        StrSql.Append("SELECT dbo.M01_Products.ProductKey, dbo.M01_Products.ProductID, dbo.M01_Products.SAP_ProductCode, dbo.M01_Products.Description, dbo.M01_Products.Grams, ").Append(" ")
        StrSql.Append("dbo.M01_Products.Standar_Cost, dbo.M01_Products.PricePoint, dbo.M01_Products.UnitsPerCase, dbo.M01_Presentation.PresentationName,").Append(" ")
        StrSql.Append("dbo.M01_ProductGroup.GroupName, dbo.M01_Source.SourceName, dbo.M01_Category.CategoryName, dbo.M01_SubCategory.SubCategoryName,").Append(" ")
        StrSql.Append("dbo.M01_Brand.BrandName, dbo.M01_SubBrand.SubBrandName, dbo.M01_TypeBrand.TypeBrandName, dbo.M01_Size.SizeName, dbo.M01_Flavor.FlavorName,").Append(" ")
        StrSql.Append("dbo.M01_Products.PresentationID, dbo.M01_Products.GroupID, dbo.M01_Products.SourceID, dbo.M01_Products.CategoryID, dbo.M01_Products.SubCategoryID,").Append(" ")
        StrSql.Append("dbo.M01_Products.BrandID, dbo.M01_Products.SubBrandID, dbo.M01_Products.TypeBrandID, dbo.M01_Products.SizeID, dbo.M01_Products.FlavorID").Append(" ")
        StrSql.Append("FROM  dbo.M01_Products INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_ProductGroup ON dbo.M01_Products.GroupID = dbo.M01_ProductGroup.GroupID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Source ON dbo.M01_Products.SourceID = dbo.M01_Source.SourceID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Category ON dbo.M01_Products.CategoryID = dbo.M01_Category.CategoryID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_SubCategory ON dbo.M01_Products.SubCategoryID = dbo.M01_SubCategory.SubCategoryID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_TypeBrand ON dbo.M01_Products.TypeBrandID = dbo.M01_TypeBrand.TypeBrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_TypeOFSales ON dbo.M01_Products.TypeSalesID = dbo.M01_TypeOFSales.TypeSalesID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Flavor ON dbo.M01_Products.FlavorID = dbo.M01_Flavor.FlavorID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_POT_Status ON dbo.M01_Products.POT_StatusID = dbo.M01_POT_Status.POT_StatusID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Presentation ON dbo.M01_Products.PresentationID = dbo.M01_Presentation.PresentationID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Brand ON dbo.M01_Products.BrandID = dbo.M01_Brand.BrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_SubBrand ON dbo.M01_Products.SubBrandID = dbo.M01_SubBrand.SubBrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Size ON dbo.M01_Products.SizeID = dbo.M01_Size.SizeID").Append(" ")
        StrSql.Append("WHERE (dbo.M01_Products.CountryID = '" & InfoCache.CountryId & "')").Append(" ")
        Return StrSql.ToString
    End Function
    Public Function ProductsNonRelatedSelectSqlString() As String
        Dim StrSql As New StringBuilder

        StrSql.Append("SELECT dbo.M01_Products.ProductKey, dbo.M01_Products.ProductID, dbo.M01_Products.SAP_ProductCode, dbo.M01_Products.Description, dbo.M01_Products.Grams, ").Append(" ")
        StrSql.Append("dbo.M01_Products.Standar_Cost, dbo.M01_Products.PricePoint, dbo.M01_Products.UnitsPerCase, dbo.M01_Presentation.PresentationName,").Append(" ")
        StrSql.Append("dbo.M01_ProductGroup.GroupName, dbo.M01_Source.SourceName, dbo.M01_Category.CategoryName, dbo.M01_SubCategory.SubCategoryName,").Append(" ")
        StrSql.Append("dbo.M01_Brand.BrandName, dbo.M01_SubBrand.SubBrandName, dbo.M01_TypeBrand.TypeBrandName, dbo.M01_Size.SizeName, dbo.M01_Flavor.FlavorName,").Append(" ")
        StrSql.Append("dbo.M01_Products.PresentationID, dbo.M01_Products.GroupID, dbo.M01_Products.SourceID, dbo.M01_Products.CategoryID, dbo.M01_Products.SubCategoryID,").Append(" ")
        StrSql.Append("dbo.M01_Products.BrandID, dbo.M01_Products.SubBrandID, dbo.M01_Products.TypeBrandID, dbo.M01_Products.SizeID, dbo.M01_Products.FlavorID").Append(" ")
        StrSql.Append("FROM  dbo.M01_Products INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_ProductGroup ON dbo.M01_Products.GroupID = dbo.M01_ProductGroup.GroupID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Source ON dbo.M01_Products.SourceID = dbo.M01_Source.SourceID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Category ON dbo.M01_Products.CategoryID = dbo.M01_Category.CategoryID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_SubCategory ON dbo.M01_Products.SubCategoryID = dbo.M01_SubCategory.SubCategoryID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_TypeBrand ON dbo.M01_Products.TypeBrandID = dbo.M01_TypeBrand.TypeBrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_TypeOFSales ON dbo.M01_Products.TypeSalesID = dbo.M01_TypeOFSales.TypeSalesID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Flavor ON dbo.M01_Products.FlavorID = dbo.M01_Flavor.FlavorID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_POT_Status ON dbo.M01_Products.POT_StatusID = dbo.M01_POT_Status.POT_StatusID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Presentation ON dbo.M01_Products.PresentationID = dbo.M01_Presentation.PresentationID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Brand ON dbo.M01_Products.BrandID = dbo.M01_Brand.BrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_SubBrand ON dbo.M01_Products.SubBrandID = dbo.M01_SubBrand.SubBrandID INNER JOIN").Append(" ")
        StrSql.Append("dbo.M01_Size ON dbo.M01_Products.SizeID = dbo.M01_Size.SizeID").Append(" ")

        StrSql.Append("WHERE (dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.GroupID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.SourceID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.CategoryID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.SubCategoryID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.BrandID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.SubBrandID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.TypeBrandID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.SizeID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.FlavorID = 1) OR").Append(" ")
        StrSql.Append("(dbo.M01_Products.CountryID = 'GT') AND (dbo.M01_Products.PresentationID = 1)")
        Return StrSql.ToString

    End Function
    Public Function ProductsMatrixSelectData() As ProductsMatrixes
        Dim ProductsMatrixSData As ProductsMatrixes = New ProductsMatrixes
        Try
            Using connection As New SqlConnection(InfoCache.ConnectionString)
                connection.Open()
                'Dim command As SqlCommand = New SqlCommand()
                'command.Connection = connection
                'command.CommandType = CommandType.Text
                'command.CommandText = M01_BrandSelectSqlString()
                Dim adapterM01_Brand As SqlDataAdapter = New SqlDataAdapter(M01_BrandSelectSqlString(), connection)
                adapterM01_Brand.Fill(ProductsMatrixSData, "M01_Brand")

                'command.CommandText = M01_SubBrandSelectSqlString()
                Dim adapterM01_SubBrand As SqlDataAdapter = New SqlDataAdapter(M01_SubBrandSelectSqlString(), connection)
                adapterM01_SubBrand.Fill(ProductsMatrixSData, "M01_SubBrand")

                'command.CommandText = M01_TypeBrandSelectSqlString()
                Dim adapterM01_TypeBrand As SqlDataAdapter = New SqlDataAdapter(M01_TypeBrandSelectSqlString(), connection)
                adapterM01_TypeBrand.Fill(ProductsMatrixSData, "M01_TypeBrand")

                'command.CommandText = M01_FlavorSelectSqlString()
                Dim adapterM01_Flavor As SqlDataAdapter = New SqlDataAdapter(M01_FlavorSelectSqlString(), connection)
                adapterM01_Flavor.Fill(ProductsMatrixSData, "M01_Flavor")

                'command.CommandText = M01_CategorySelectSqlString()
                Dim adapterM01_Category As SqlDataAdapter = New SqlDataAdapter(M01_CategorySelectSqlString(), connection)
                adapterM01_Category.Fill(ProductsMatrixSData, "M01_Category")

                'command.CommandText = M01_SubCategorySelectSqlString()
                Dim adapterM01_SubCategory As SqlDataAdapter = New SqlDataAdapter(M01_SubCategorySelectSqlString(), connection)
                adapterM01_SubCategory.Fill(ProductsMatrixSData, "M01_SubCategory")

                'command.CommandText = M01_TypeOFSalesSelectSqlString()
                Dim adapterM01_TypeOFSales As SqlDataAdapter = New SqlDataAdapter(M01_TypeOFSalesSelectSqlString(), connection)
                adapterM01_TypeOFSales.Fill(ProductsMatrixSData, "M01_TypeOFSales")

                'command.CommandText = M01_SizeSelectSqlString()
                Dim adapterM01_Size As SqlDataAdapter = New SqlDataAdapter(M01_SizeSelectSqlString(), connection)
                adapterM01_Size.Fill(ProductsMatrixSData, "M01_Size")

                'command.CommandText = M01_PresentationSelectSqlString()
                Dim adapterM01_Presentation As SqlDataAdapter = New SqlDataAdapter(M01_PresentationSelectSqlString(), connection)
                adapterM01_Presentation.Fill(ProductsMatrixSData, "M01_Presentation")

                'command.CommandText = M01_ProductGroupSelectSqlString()
                Dim adapterM01_ProductGroup As SqlDataAdapter = New SqlDataAdapter(M01_ProductGroupSelectSqlString(), connection)
                adapterM01_ProductGroup.Fill(ProductsMatrixSData, "M01_ProductGroup")

                'command.CommandText = M01_SourceSelectSqlString()
                Dim adapterM01_Source As SqlDataAdapter = New SqlDataAdapter(M01_SourceSelectSqlString(), connection)
                adapterM01_Source.Fill(ProductsMatrixSData, "M01_Source")

                'command.CommandText = M01_POT_StatusSelectSqlString()
                Dim adapterM01_POT_Status As SqlDataAdapter = New SqlDataAdapter(M01_POT_StatusSelectSqlString(), connection)
                adapterM01_POT_Status.Fill(ProductsMatrixSData, "M01_POT_Status")
            End Using

        Catch ex As Exception

        End Try
        Return ProductsMatrixSData

    End Function

    Private Function M01_BrandSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT BrandID, BrandName FROM dbo.M01_Brand").Append(" ")
        Return StrSql.ToString

    End Function

    Private Function M01_SubBrandSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT SubBrandID, SubBrandName FROM  dbo.M01_SubBrand").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_TypeBrandSelectSqlString() As Object
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT TypeBrandID, TypeBrandName FROM  dbo.M01_TypeBrand").Append(" ")
        Return StrSql.ToString
    End Function
    Private Function M01_FlavorSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT FlavorID, FlavorName FROM  dbo.M01_Flavor").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_CategorySelectSqlString() As Object
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT CategoryID, CategoryName  FROM  dbo.M01_Category").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_SubCategorySelectSqlString() As Object
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT SubCategoryID, SubCategoryName FROM  dbo.M01_SubCategory").Append(" ")
        Return StrSql.ToString
    End Function
    Private Function M01_TypeOFSalesSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT TypeSalesID, TypeSalesName FROM  dbo.M01_TypeOFSales").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_SizeSelectSqlString() As Object
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT SizeID, SizeName FROM  dbo.M01_Size").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_PresentationSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT PresentationID, PresentationName FROM  dbo.M01_Presentation").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_ProductGroupSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT GroupID, GroupName FROM  dbo.M01_ProductGroup").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_SourceSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT SourceID, SourceName FROM  dbo.M01_Source").Append(" ")
        Return StrSql.ToString
    End Function

    Private Function M01_POT_StatusSelectSqlString() As String
        Dim StrSql As New StringBuilder
        StrSql.Append("SELECT POT_StatusID, POT_StatusName FROM  dbo.M01_POT_Status").Append(" ")
        Return StrSql.ToString
    End Function






End Class
