Imports System.IO

Public Class Form1
    Dim vagas(1, 9) As Boolean ' 2 andares, 10 vagas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To vagas.GetLength(0)
            cbAndar.Items.Add("Andar " & i)
        Next

        For i As Integer = 1 To vagas.GetLength(1)
            cbVaga.Items.Add("Vaga " & i)
        Next

        cbAndar.SelectedIndex = 0
        cbVaga.SelectedIndex = 0

        AtualizarGrid()
    End Sub

    Sub AtualizarGrid()
        dgvVagas.Columns.Clear()
        dgvVagas.Rows.Clear()

        For j As Integer = 0 To vagas.GetLength(1) - 1
            dgvVagas.Columns.Add("V" & (j + 1), "Vaga " & (j + 1))
        Next

        For i As Integer = 0 To vagas.GetLength(0) - 1
            Dim row(vagas.GetLength(1) - 1) As String
            For j As Integer = 0 To vagas.GetLength(1) - 1
                row(j) = If(vagas(i, j), "Ocupada", "Livre")
            Next
            dgvVagas.Rows.Add(row)
            dgvVagas.Rows(i).HeaderCell.Value = "Andar " & (i + 1)
        Next

        dgvVagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvVagas.RowHeadersWidth = 85
        dgvVagas.BorderStyle = BorderStyle.None
        dgvVagas.EnableHeadersVisualStyles = False
        dgvVagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvVagas.ScrollBars = ScrollBars.Both

    End Sub

    Private Sub btnOcupar_Click(sender As Object, e As EventArgs) Handles btnOcupar.Click
        Dim andar As Integer = cbAndar.SelectedIndex
        Dim vaga As Integer = cbVaga.SelectedIndex

        If vagas(andar, vaga) Then
            MessageBox.Show("Já está ocupada.")
        Else
            vagas(andar, vaga) = True
            AtualizarGrid()
        End If
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        Dim andar As Integer = cbAndar.SelectedIndex
        Dim vaga As Integer = cbVaga.SelectedIndex

        If Not vagas(andar, vaga) Then
            MessageBox.Show("Já está livre.")
        Else
            vagas(andar, vaga) = False
            AtualizarGrid()
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim caminho As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vagas.txt"
        Using sw As New StreamWriter(caminho)
            For i As Integer = 0 To vagas.GetLength(0) - 1
                Dim linha As String = ""
                For j As Integer = 0 To vagas.GetLength(1) - 1
                    linha &= If(vagas(i, j), "1", "0")
                Next
                sw.WriteLine(linha)
            Next
        End Using
        MessageBox.Show("Arquivo salvo em: " & caminho)
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        Dim caminho As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vagas.txt"
        If File.Exists(caminho) Then
            Dim linhas() As String = File.ReadAllLines(caminho)
            For i As Integer = 0 To linhas.Length - 1
                For j As Integer = 0 To linhas(i).Length - 1
                    vagas(i, j) = (linhas(i)(j) = "1")
                Next
            Next
            AtualizarGrid()
        Else
            MessageBox.Show("Arquivo não encontrado.")
        End If



    End Sub



End Class
