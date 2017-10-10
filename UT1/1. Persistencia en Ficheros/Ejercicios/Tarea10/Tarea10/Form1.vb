Imports System
Imports System.IO

Public Class Form1

    Private Sub btnUno_Click(sender As System.Object, e As System.EventArgs) Handles btnUno.Click
        'Obtener el directorio actual
        Dim dirActual As String
        dirActual = Directory.GetCurrentDirectory
        MessageBox.Show("El directorio actual es: " + dirActual)

        'Establecer temporalmente dicho directorio en “c:\temp” 
        Dim dirTempo As String = "C:\temp"

        If Directory.Exists(dirTempo) Then
            MessageBox.Show("El directorio " + dirTempo + " existe.")
        Else
            MessageBox.Show("El directorio " + dirTempo + " NO existe.")
            Directory.CreateDirectory(dirTempo)
        End If
        Directory.SetCurrentDirectory(dirTempo)
        MessageBox.Show("*** CAMBIO DE DIRECTORIO ***")
        MessageBox.Show("El directorio actual es: " + Directory.GetCurrentDirectory)

    End Sub
End Class
