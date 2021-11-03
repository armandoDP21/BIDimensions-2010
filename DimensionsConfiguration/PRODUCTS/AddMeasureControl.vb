Public Class AddMeasureControl
    Private _MeasureCalled As Integer
    Public Event SaveClicked()

    Private Sub PrepareRegistro()
        Select Case _MeasureCalled
            Case ProductsMeasuresIndex.Brands
                Me.TituloLabel.Text = "Brands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Brands"
            Case ProductsMeasuresIndex.Categories
                Me.TituloLabel.Text = "Categories"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Categories"
            Case ProductsMeasuresIndex.Flavors
                Me.TituloLabel.Text = "Flavors"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Flavors"
            Case ProductsMeasuresIndex.POT_Status
                Me.TituloLabel.Text = "POT_Status"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en POT_Status"
            Case ProductsMeasuresIndex.Presentations
                Me.TituloLabel.Text = "ProductGroups"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Presentations"
            Case ProductsMeasuresIndex.ProductGroups
                Me.TituloLabel.Text = "ProductGroups"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en ProductGroups"
            Case ProductsMeasuresIndex.Sizes
                Me.TituloLabel.Text = "Sizes"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Sizes"
            Case ProductsMeasuresIndex.Sources
                Me.TituloLabel.Text = "Sources"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Sources"
            Case ProductsMeasuresIndex.SubBrands
                Me.TituloLabel.Text = "SubBrands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en SubBrands"
            Case ProductsMeasuresIndex.SubCategories
                Me.TituloLabel.Text = "SubCategories"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en SubCategories"
            Case ProductsMeasuresIndex.TypeOfBrands
                Me.TituloLabel.Text = "TypeOfBrands"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en TypeOfBrands"
            Case ProductsMeasuresIndex.TypeOfSales
                Me.TituloLabel.Text = "TypeOfSales"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en TypeOfSales"
        End Select
    End Sub
    Private Function CreateRegistro() As Boolean

        Using context As BIDimensionsContext = New BIDimensionsContext
            Try

                Select Case _MeasureCalled
                    Case ProductsMeasuresIndex.Brands
                        Dim NewBrand As M01_Brand = New M01_Brand
                        With NewBrand
                            .BrandName = Me.MeasureNameTextBox.Text
                            .SystemOnly = True
                            .Active_Flag = True
                        End With
                        context.M01_Brand.Add(NewBrand)
                    Case ProductsMeasuresIndex.Categories

                    Case ProductsMeasuresIndex.Flavors

                    Case ProductsMeasuresIndex.POT_Status

                    Case ProductsMeasuresIndex.Presentations
                    Case ProductsMeasuresIndex.ProductGroups
                    Case ProductsMeasuresIndex.Sizes
                    Case ProductsMeasuresIndex.Sources
                    Case ProductsMeasuresIndex.SubBrands
                    Case ProductsMeasuresIndex.SubCategories
                    Case ProductsMeasuresIndex.TypeOfBrands
                    Case ProductsMeasuresIndex.TypeOfSales
                End Select
                context.SaveChanges()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Using

    End Function

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If CreateRegistro() Then
        End If
    End Sub

End Class
