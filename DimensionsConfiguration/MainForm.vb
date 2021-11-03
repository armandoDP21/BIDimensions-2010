Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "BI Dimensions " & My.Application.Info.Version.ToString
    End Sub
#Region "Metodos"
    Private Sub ProductsFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de productos..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New ProductsConfigForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub ProductsHomologationFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de homologación de productos..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New ProductsHomologationMainForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GeographyFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de Geography..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New GeographyConfigForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CustomersFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de Customers..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New CustomersConfigForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CustomersHomologationFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de homologación de Customers..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New CustomersHomologationMainForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GeographyHomologationFormLoad()
        My.Application.DoEvents()
        Me.WaitLabel.Text = "Un momento, cargando pantalla de homologación de Geography..."
        Me.WaitLabel.Visible = True

        Me.Cursor = Cursors.WaitCursor
        With New GeographyHomologationMainForm
            .ShowDialog()
        End With
        My.Application.DoEvents()
        Me.WaitLabel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub


#End Region
#Region "Eventos"

    Private Sub ProductsButton_Click(sender As Object, e As EventArgs) Handles ProductsButton.Click
        ProductsFormLoad()
    End Sub

    Private Sub ProductsHomologationButton_Click(sender As Object, e As EventArgs) Handles ProductsHomologationButton.Click
        ProductsHomologationFormLoad()
    End Sub
    Private Sub CerrarButton_Click(sender As Object, e As EventArgs) Handles CerrarButton.Click
        Me.Close()
    End Sub
    Private Sub GeographyButton_Click(sender As Object, e As EventArgs) Handles GeographyButton.Click
        GeographyFormLoad()

    End Sub
    Private Sub CustomersButton_Click(sender As Object, e As EventArgs) Handles CustomersButton.Click
        CustomersFormLoad()

    End Sub
    Private Sub CustomersHomologationButton_Click(sender As Object, e As EventArgs) Handles CustomersHomologationButton.Click
        CustomersHomologationFormLoad()

    End Sub
    Private Sub GeographyHomologationButton_Click(sender As Object, e As EventArgs) Handles GeographyHomologationButton.Click
        GeographyHomologationFormLoad()

    End Sub
#End Region

End Class
