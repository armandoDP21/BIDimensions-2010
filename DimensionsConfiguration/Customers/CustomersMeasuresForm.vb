Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.Remoting.Contexts
Public Class CustomersMeasuresForm
    Private _MeasureCalled As Integer
    'Private context As SalesDataMartContext = New SalesDataMartContext
    Private context As SalesDataMartContext
    Private Sub MeasuresForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMeasure()
    End Sub
    Private Sub LoadMeasure()
        context = New SalesDataMartContext

        Select Case _MeasureCalled
            Case CustomersMeasuresIndex.Categories
                Me.TituloLabel.Text = "Categories"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Categories"
                Me.AddButton.Text = "Agregar registro a Categories"
                Me.TotRegistrosLabel.Text = "Total Categories registrados: " & CategoriesDML()

            Case CustomersMeasuresIndex.Chains
                Me.TituloLabel.Text = "Chains"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Chains"
                Me.AddButton.Text = "Agregar a Chains"
                Me.TotRegistrosLabel.Text = "Total Chains registrados: " & ChainsDML()
            Case CustomersMeasuresIndex.KeyAccounts
                Me.TituloLabel.Text = "KeyAccounts"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en KeyAccounts"
                Me.AddButton.Text = "Agregar a KeyAccounts"
                Me.TotRegistrosLabel.Text = "Total KeyAccounts registrados: " & KeyAccountsDML()
            Case CustomersMeasuresIndex.PayMethods
                Me.TituloLabel.Text = "PayMethods"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en PayMethods"
                Me.AddButton.Text = "Agregar a PayMethods"
                Me.TotRegistrosLabel.Text = "Total PayMethods registrados: " & PayMethodsDML()

        End Select


    End Sub
#Region "Save registro"
    Private Function CreateRegistro() As Boolean
        Try
            Select Case _MeasureCalled

                Case CustomersMeasuresIndex.Categories
                    Dim NewRecord As M02_Category = New M02_Category
                    With NewRecord
                        .CategoryName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M02_Category.Add(NewRecord)
                Case CustomersMeasuresIndex.Chains
                    Dim NewRecord As M02_Chain = New M02_Chain
                    With NewRecord
                        .ChainName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M02_Chain.Add(NewRecord)

                Case CustomersMeasuresIndex.KeyAccounts
                    Dim NewRecord As M02_KeyAccount = New M02_KeyAccount
                    With NewRecord
                        .KeyAccounName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M02_KeyAccount.Add(NewRecord)

                Case CustomersMeasuresIndex.PayMethods
                    Dim NewRecord As M02_PayMtMthod = New M02_PayMtMthod
                    With NewRecord
                        .PayMtMthodName = Me.MeasureNameTextBox.Text
                    End With
                    context.M02_PayMtMthod.Add(NewRecord)


            End Select
            context.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
#End Region
#Region "metodos"
    Private Sub SaveRecord()
        If CreateRegistro() Then
            EnableListContext()
            context.Dispose()
            LoadMeasure()
        End If
    End Sub
    Private Sub DisbleListContext()
        GuardarButton.Enabled = True
        CancelarButton.Enabled = True
        Me.GridDatos.Enabled = False
        Me.AddButton.Enabled = False
        Me.CerrarButton.Enabled = False
        MeasureNameTextBox.Enabled = True
        MeasureNameTextBox.Focus()
    End Sub
    Private Sub EnableListContext()
        GuardarButton.Enabled = False
        CancelarButton.Enabled = False
        Me.GridDatos.Enabled = True
        Me.AddButton.Enabled = True
        Me.CerrarButton.Enabled = True
        Me.MeasureNameTextBox.Text = String.Empty
        Me.MeasureNameTextBox.Enabled = False
    End Sub
#End Region
#Region "Eventos"
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DisbleListContext()
    End Sub
    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        SaveRecord()
    End Sub
    Private Sub CerrarButton_Click(sender As Object, e As EventArgs) Handles CerrarButton.Click
        'Me.context.Dispose()
        Me.Close()
    End Sub
    Private Sub MeasureNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MeasureNameTextBox.TextChanged
        If Me.Text.Length = 0 Then
            Me.GuardarButton.Enabled = False
        Else
            Me.GuardarButton.Enabled = True
        End If
    End Sub
    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        EnableListContext()

    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.ActiveControl.GetType() = GetType(TextBox) Or Me.ActiveControl.GetType() = GetType(ComboBox) Then
                SendKeys.Send("{TAB}")
                e.Handled = True
            End If
        End If
    End Sub
#End Region
#Region "Carga measures"
    Private Function ChainsDML() As Integer
        Try
            Dim RecordsList = context.M02_Chain.ToList.OrderBy(Function(o) o.ChainName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function CategoriesDML() As Integer
        Try
            Dim RecordsList = context.M02_Category.ToList.OrderBy(Function(o) o.CategoryName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
    Private Function KeyAccountsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M02_KeyAccount Select RecordsTable Order By RecordsTable.KeyAccounName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function PayMethodsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M02_PayMtMthod Select RecordsTable Order By RecordsTable.PayMtMthodName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

  

#End Region

    Public Sub New(MeasureCalled As Integer)
        InitializeComponent()
        _MeasureCalled = MeasureCalled
        ConfigurarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        Dim PKName As String = String.Empty
        Dim MeasureName As String = String.Empty

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        Dim TotalGridWidth As Integer = Me.GridDatos.Width - 16

        Dim MeasurePKColumn As New DataGridViewTextBoxColumn()
        Dim MeasureNameColumn As New DataGridViewTextBoxColumn()
        Dim Active_FlagColumn As New DataGridViewTextBoxColumn()
        Dim SystemOnlyColumn As New DataGridViewTextBoxColumn()
        'Dim context As New SalesDataMartContext

        Select Case _MeasureCalled
            Case CustomersMeasuresIndex.Chains
                PKName = "ChainID"
                MeasureName = "ChainName"

            Case CustomersMeasuresIndex.Categories
                PKName = "CategoryID"
                MeasureName = "CategoryName"

            Case CustomersMeasuresIndex.KeyAccounts
                PKName = "KeyAccountID"
                MeasureName = "KeyAccounName"

            Case CustomersMeasuresIndex.PayMethods
                PKName = "PayMtID"
                MeasureName = "PayMtMthodName"

        End Select


        With MeasurePKColumn
            .HeaderText = PKName
            .Name = PKName
            .DataPropertyName = PKName
            .Width = CInt(TotalGridWidth * 0.12)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With
        With MeasureNameColumn
            .HeaderText = MeasureName
            .Name = MeasureName
            .DataPropertyName = MeasureName
            .Width = CInt(TotalGridWidth * 0.7)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = False
        End With

        With Active_FlagColumn
            .HeaderText = "Active_Flag"
            .Name = "Active_Flag"
            .DataPropertyName = "Active_Flag"
            .Width = CInt(TotalGridWidth * 0.11)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With
        With SystemOnlyColumn
            .HeaderText = "SystemOnly"
            .Name = "SystemOnly"
            .DataPropertyName = "SystemOnly"
            .Width = CInt(TotalGridWidth * 0.11)
            .DefaultCellStyle.SelectionBackColor = Color.Red
            .ReadOnly = True
        End With



        With Me.GridDatos
            '.Columns.Add(MeasurePKColumn)
            .Columns.Add(MeasureNameColumn)
            .Columns.Add(Active_FlagColumn)
            .Columns.Add(SystemOnlyColumn)

            .AllowUserToOrderColumns = True
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.ColumnHeader

            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken

            .RowHeadersWidth = CInt(TotalGridWidth * 0.02)
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle = columnHeaderStyle
            .ReadOnly = False
            .RowsDefaultCellStyle.BackColor = Color.Ivory
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False

            '.SelectionMode = DataGridViewSelectionMode.FullRowSelec
        End With

    End Sub

End Class