Public Class HomologationDisplayUC
    Private _HomologationType As HomologationTypes

    Public WriteOnly Property HType As HomologationTypes
        Set(value As HomologationTypes)
            _HomologationType = value
            CargarDatos()
        End Set
    End Property

    Private Sub CargarDatos()

        Select Case _HomologationType
            Case HomologationTypes.BrandCategory
                Me.TotRegistrosLabel.Text = "Total Brands registrados: " & BrandCategoryDML()

            Case HomologationTypes.Flavor
            Case HomologationTypes.Presentation
            Case HomologationTypes.ProductGroup
            Case HomologationTypes.Size
            Case HomologationTypes.Source
            Case HomologationTypes.SubBrand
            Case HomologationTypes.SubCategory
            Case HomologationTypes.TypeBrand
            Case HomologationTypes.TypeOFSales

        End Select
    End Sub
    Private Function BrandCategoryDML() As Integer
        Using context As BIDimensionsContext = New BIDimensionsContext
            Try
                Dim RecordsList = (From M01B In context.M01_Brand
                                  Join HOMB In context.HOM_Brand On M01B.BrandID Equals HOMB.BrandID
                                  Join M01C In context.M01_Category On HOMB.CategoryID Equals M01C.CategoryID
                                  Select {M01B.BrandID, M01B.BrandName, M01C.CategoryID, M01C.CategoryName, HOMB.BrandID, HOMB.CategoryID, HOMB.BrandSourceName})

                Me.GridDatos.DataSource = RecordsList.ToList

                'Return RecordsList.ToList.Count
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try
        End Using

        'select 
        'M01B.BrandID,M01B.BrandName,
        'M01C.CategoryID,M01C.CategoryName,
        'HOMB.BrandID,HOMB.CategoryID , HOMB.BrandSourceName
        'from 
        'dbo.HOM_Brand inner join M01_Brand 
        'on HOM_Brand.BrandID =  M01_Brand.BrandID
        'inner Join M01_Category 
        'on HOM_Brand.CategoryID =M01_Category.CategoryID

        'var entryPoint = (from ep in dbContext.tbl_EntryPoint
        '         join e in dbContext.tbl_Entry on ep.EID equals e.EID
        '         join t in dbContext.tbl_Title on e.TID equals t.TID
        '         where e.OwnerID == user.UID
        '         select new {
        '             UID = e.OwnerID,
        '             TID = e.TID,
        '             Title = t.Title,
        'EID = e.EID
        '         }).Take(10);



    End Function
    Private Function FlavorsDML() As Integer
        Using context As BIDimensionsContext = New BIDimensionsContext

            Try
                Dim RecordsList = From RecordsTable In context.M01_Flavor Select RecordsTable Order By RecordsTable.FlavorName
                Me.GridDatos.DataSource = RecordsList.ToList
                Return RecordsList.ToList.Count.ToString

            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try
        End Using
    End Function

End Class
