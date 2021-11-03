Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.Remoting.Contexts

Public Class GeographyMeasuresForm
    Private _MeasureCalled As Integer
    'Private context As SalesDataMartContext = New SalesDataMartContext
    Private context As SalesDataMartContext
    Private Sub MeasuresForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMeasure()
    End Sub
    Private Sub LoadMeasure()
        context = New SalesDataMartContext

        Select Case _MeasureCalled
            Case GeographyMeasuresIndex.Branches
                Me.TituloLabel.Text = "Branches"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Branches"
                Me.AddButton.Text = "Agregar registro a Branches"
                Me.TotRegistrosLabel.Text = "Total Branches registrados: " & BranchesDML()

            Case GeographyMeasuresIndex.Districts
                Me.TituloLabel.Text = "Districts"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Districts"
                Me.AddButton.Text = "Agregar a Districts"
                Me.TotRegistrosLabel.Text = "Total Categories registrados: " & DistrictsDML()
            Case GeographyMeasuresIndex.MUIDs
                Me.TituloLabel.Text = "Market Units"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Market Units"
                Me.AddButton.Text = "Agregar a Market Unist"
                Me.TotRegistrosLabel.Text = "Total Market Units registrados: " & MUIDsDML()
            Case GeographyMeasuresIndex.RSRIds
                Me.TituloLabel.Text = "RSRIds"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en RSRIds"
                Me.AddButton.Text = "Agregar a RSRIds"
                Me.TotRegistrosLabel.Text = "Total RSRIds registrados: " & RSRIdsDML()
            Case GeographyMeasuresIndex.TypeRoutes
                Me.TituloLabel.Text = "Zones"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Zones"
                Me.AddButton.Text = "Agregar registro a Zones"
                Me.TotRegistrosLabel.Text = "Total Zones registrados: " & TypeRoutesDML()
            Case GeographyMeasuresIndex.Zones
                Me.TituloLabel.Text = "Zones"
                Me.MeasureNameLabel.Text = "Nombre de nuevo registro en Zones"
                Me.AddButton.Text = "Agregar registro a Zones"
                Me.TotRegistrosLabel.Text = "Total Zones registrados: " & ZonesDML()
           
        End Select


    End Sub
#Region "Save registro"
    Private Function CreateRegistro() As Boolean
        Try
            Select Case _MeasureCalled
                Case GeographyMeasuresIndex.Branches
                    Dim NewRecord As M05_Branch = New M05_Branch
                    With NewRecord
                        .BranchName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M05_Branch.Add(NewRecord)

                Case GeographyMeasuresIndex.Districts
                    Dim NewRecord As M05_District = New M05_District
                    With NewRecord
                        .DistrictName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M05_District.Add(NewRecord)

                Case GeographyMeasuresIndex.MUIDs
                    Dim NewRecord As M05_Market_Unit = New M05_Market_Unit
                    With NewRecord
                        .Market_Unit = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M05_Market_Unit.Add(NewRecord)

                Case GeographyMeasuresIndex.RSRIds
                    Dim NewRecord As M05_Route_Representative = New M05_Route_Representative
                    With NewRecord
                        .RSRName = Me.MeasureNameTextBox.Text
                    End With
                    context.M05_Route_Representative.Add(NewRecord)

                Case GeographyMeasuresIndex.TypeRoutes
                    Dim NewRecord As M05_TypeRoute = New M05_TypeRoute
                    With NewRecord
                        .TypeRouteName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M05_TypeRoute.Add(NewRecord)

                Case GeographyMeasuresIndex.Zones
                    Dim NewRecord As M05_Zone = New M05_Zone
                    With NewRecord
                        .ZoneName = Me.MeasureNameTextBox.Text
                        .SystemOnly = True
                        .Active_Flag = True
                    End With
                    context.M05_Zone.Add(NewRecord)



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
    Private Function BranchesDML() As Integer
        Try
            Dim RecordsList = context.M05_Branch.ToList.OrderBy(Function(o) o.BranchName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function DistrictsDML() As Integer
        Try
            Dim RecordsList = context.M05_District.ToList.OrderBy(Function(o) o.DistrictName)
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
    Private Function MUIDsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M05_Market_Unit Select RecordsTable Order By RecordsTable.Market_Unit
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function RSRIdsDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M05_Route_Representative Select RecordsTable Order By RecordsTable.RSRName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try


    End Function

    Private Function TypeRoutesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M05_TypeRoute Select RecordsTable Order By RecordsTable.TypeRouteName
            Me.GridDatos.DataSource = RecordsList.ToList
            Return RecordsList.ToList.Count.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    Private Function ZonesDML() As Integer
        Try
            Dim RecordsList = From RecordsTable In context.M05_Zone Select RecordsTable Order By RecordsTable.ZoneName
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
            Case GeographyMeasuresIndex.Branches
                PKName = "BranchID"
                MeasureName = "BranchName"

            Case GeographyMeasuresIndex.Districts
                PKName = "DistrictID"
                MeasureName = "DistrictName"

            Case GeographyMeasuresIndex.MUIDs
                PKName = "MUID"
                MeasureName = "Market_Unit"

            Case GeographyMeasuresIndex.RSRIds
                PKName = "RSRId"
                MeasureName = "RSRName"

            Case GeographyMeasuresIndex.TypeRoutes
                PKName = "TypeRouteID"
                MeasureName = "TypeRouteName"

            Case GeographyMeasuresIndex.Zones
                PKName = "ZoneID"
                MeasureName = "ZoneName"

            

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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.context.SaveChanges()
    End Sub

End Class