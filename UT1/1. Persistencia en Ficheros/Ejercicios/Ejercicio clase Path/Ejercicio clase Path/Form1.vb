Imports System
Imports System.IO
Public Class Form1

    Private Sub btnPath_Click(sender As System.Object, e As System.EventArgs) Handles btnPath.Click
        Dim dir As String
        dir = txtRuta.Text

        If File.Exists(dir) Then

            MessageBox.Show("El directorio: " + Path.GetDirectoryName(dir))
            MessageBox.Show("El fichero CON extensión: " + Path.GetFileName(dir))
            MessageBox.Show("La extensión del fichero es => " + Path.GetExtension(dir))
            MessageBox.Show("El fichero CON extensión: " + Path.GetFileNameWithoutExtension(dir))
            MessageBox.Show("La unidad es: " + Path.GetPathRoot(dir))

        Else
            MessageBox.Show("El directorio y/o fichero introducido no existe")
        End If
      
    End Sub
End Class
