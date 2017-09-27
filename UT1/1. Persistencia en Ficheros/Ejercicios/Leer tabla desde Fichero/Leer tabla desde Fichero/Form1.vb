Imports System.IO
Public Class Form1

    Dim registros As String()
    Dim totalLineasLeidas As Integer = 0
    Dim registroMostrado As Integer = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            'Dim books =
            '  From line In File.ReadAllLines("Empleados.txt")
            '  Let parts = line.Split(";")

            Dim Lector As StreamReader = New StreamReader("Empleados.txt")
            Do While Lector.Peek() > -1
                Dim linea As String = Lector.ReadLine()
                totalLineasLeidas += 1
                If totalLineasLeidas > 0 Then
                    cargarRegistro(linea)
                End If

            Loop
            Lector.Close()

            mostrarLinea(registros(0))

        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("Fichero no encontrado")
        End Try
        

    End Sub

    Private Sub cargarRegistro(linea)
        Dim lineaParseada As String() = linea.split(";")
        'For Each registroTemp As String In lineaParseada
        '    MessageBox.Show(registroTemp)
        'Next
        'registros(registros.Length) = lineaParseada
        'TODO: falta convertir registros en un array bidemensional
    End Sub

    Private Sub mostrarLinea(linea)
        lblNumemp.Text = linea(0)
        lblName.Text = linea(1)
        lblAge.Text = linea(2)
        lblOfc.Text = linea(3)
        lblTitle.Text = linea(4)
        lblCtr.Text = linea(5)
        lblBoss.Text = linea(6)
        lblCuota.Text = linea(7)
        lblVentas.Text = linea(8)
    End Sub

    Private Sub btnSgn_Click(sender As System.Object, e As System.EventArgs) Handles btnSgn.Click

        If registroMostrado < totalLineasLeidas Then

            registroMostrado += 1
            mostrarLinea(registros(registroMostrado))

        End If

    End Sub

End Class
