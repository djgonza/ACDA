Imports System.IO
Public Class frnTarea3

    Dim ruta As String = "texto.txt"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ruta = txtRead.Text

        If File.Exists(ruta) Then

            Dim Lector As StreamReader = New StreamReader(ruta)

            If String.IsNullOrEmpty(File.ReadAllText(ruta)) Then
                MessageBox.Show("Documento vacio")
            Else

                For Each line In File.ReadLines(ruta)
                    MessageBox.Show(line)
                Next

            End If

            Lector.Close()
        Else
            MessageBox.Show("No existe el fichero.")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim fichero As StreamWriter
        fichero = New StreamWriter(ruta)
        fichero.Close()
        MessageBox.Show("Fichero creado (texto.txt)")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If File.Exists(ruta) Then
            Dim writer As StreamWriter = New StreamWriter(ruta, True)
            writer.WriteLine("Linea 1")
            writer.Close()
            MessageBox.Show("Linea insertada")
        Else
            MessageBox.Show("Cree primero el fichero")
        End If

    End Sub
End Class