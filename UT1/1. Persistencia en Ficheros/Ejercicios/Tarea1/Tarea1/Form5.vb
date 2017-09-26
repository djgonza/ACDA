Imports System.IO
Public Class frnTarea5

    Dim ruta As String = "Socios.txt"

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click

        Dim nombre As String = txtNombre.Text
        Dim dni As String = txtDni.Text
        Dim writer As StreamWriter = New StreamWriter(ruta, True)
        writer.WriteLine(nombre + " - " + dni)
        writer.Close()
        MessageBox.Show("SOCIO AÑADIDO")
    End Sub

    
    Private Sub btnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click
        Try
            Dim Lector As StreamReader = New StreamReader(ruta)

            Do While Lector.Peek() > -1
                MessageBox.Show(Lector.ReadLine())
            Loop
            Lector.Close()
        Catch ex As Exception
            MessageBox.Show("Fichero no existe")
        End Try
    End Sub
End Class