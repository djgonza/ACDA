Imports System.IO
Public Class frnTarea4a

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try

            Dim fichero As StreamWriter = New StreamWriter(txtRoute.Text)
            fichero.WriteLine("Linea 1")
            fichero.WriteLine("Linea 2")
            fichero.WriteLine("Linea 3")
            fichero.WriteLine("Linea 4")
            fichero.WriteLine("Linea 4+1")

            fichero.Close()
            MessageBox.Show("Fichero creado")

        Catch ex As Exception
            MessageBox.Show("se detecta un error genérico " & ex.Message)
        End Try

    End Sub

End Class