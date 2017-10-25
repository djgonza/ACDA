Imports System.IO
Imports System

Public Class frnVisor

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frnVisor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim unidades() As String = Directory.GetLogicalDrives()

        For i As Integer = 0 To unidades.Length - 1
            Dim nombre As String = unidades(i)
            cmbUnidades.Items.Add(nombre)
        Next
    End Sub


    Private Sub cmbUnidades_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbUnidades.SelectedIndexChanged
        Dim pos As Integer = cmbUnidades.SelectedIndex
        Dim unidad As String = cmbUnidades.Items(pos)
        Dim carpetas() As String
        Try
            carpetas = Directory.GetDirectories(unidad)

            For i As Integer = 0 To carpetas.Length - 1
                Dim nombre As String = carpetas(i)
                lbCarpetas.Items.Add(nombre)
            Next

        Catch ex As IOException
            MessageBox.Show("Unidad no disponible")
            cmbUnidades.Focus()
        End Try
       
    End Sub


    Private Sub lbCarpetas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbCarpetas.SelectedIndexChanged
        Dim pos As Integer = lbCarpetas.SelectedIndex
        Dim dir As String = lbCarpetas.Items(pos)
        Try
            lbArchivos.Items.Clear()
            For Each file As String In Directory.GetFiles(dir)
                If Path.GetExtension(file) = ".txt" Then
                    lbArchivos.Items.Add(file)
                End If
            Next
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("No tiene permisos para acceder al directorio")
        End Try
    End Sub


    Private Sub lbArchivos_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbArchivos.SelectedIndexChanged
        Dim pos As Integer = lbArchivos.SelectedIndex
        Dim fichero As String = lbArchivos.Items(pos)
        Dim texto As String = File.ReadAllText(fichero)
        rtTexto.Text = texto
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim texto As String = rtTexto.Text

        Dim pos As Integer = lbArchivos.SelectedIndex
        Dim fichero As String = lbArchivos.Items(pos)

        File.WriteAllText(fichero, texto)
        MessageBox.Show("Guardado con éxito")
        rtTexto.Text = ""
    End Sub
End Class
