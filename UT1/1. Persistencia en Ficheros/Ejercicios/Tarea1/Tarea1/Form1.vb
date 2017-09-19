Imports System.IO
Public Class frnTarea1

    Dim ruta As String = "Tarea1.txt"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fichero As StreamWriter
        fichero = New StreamWriter(ruta)

        fichero.WriteLine("Linea 1")
        fichero.WriteLine("Linea 2")
        fichero.WriteLine("Linea 3")
        fichero.WriteLine("Linea 4")
        fichero.WriteLine("Linea 4+1")

        fichero.Close()
        MessageBox.Show("Fichero creado")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Try
            Dim Lector As StreamReader = New StreamReader(ruta)

            Dim linea As String
            linea = Lector.ReadLine()
            MessageBox.Show(linea)
            linea = Lector.ReadLine()
            MessageBox.Show(linea)

            Dim texto As String
            texto = Lector.ReadToEnd()
            MessageBox.Show(texto)

            Lector.Close()
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("El fichero no existe")
        End Try

        

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim fichero As StreamWriter
        fichero = New StreamWriter(ruta, True)

        Dim linea As String
        linea = InputBox("Inserte una linea")
        fichero.WriteLine(linea)
        MessageBox.Show("Linea añadida")

        fichero.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        File.Delete(ruta)
        MessageBox.Show("Archivo eliminado")

    End Sub
End Class
