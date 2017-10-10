Imports System
Imports System.IO

Public Class Form1

    Private Sub btnConFile_Click(sender As System.Object, e As System.EventArgs) Handles btnConFile.Click
        Dim fil As String = TextBox1.Text

        If File.Exists(fil) Then

            MessageBox.Show("El fichero se encuentra en la ruta: " + Path.GetDirectoryName(fil))
            'MessageBox.Show("El fichero se encuentra en la ruta: " + fil.Substring(0, fil.LastIndexOf("\") + 1))
            MessageBox.Show("La extensión del fichero introducida es: " + Path.GetExtension(fil))
            MessageBox.Show("La fecha de última edicion del documento es: " + File.GetLastWriteTime(fil))
            MessageBox.Show("La longitud en bytes del fichero es: " + File.ReadAllBytes(fil).Length.ToString + " bytes.")

        Else
            MessageBox.Show("El fichero introducido no existe")
        End If

    End Sub

    Private Sub btnConFileInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnConFileInfo.Click

        Dim fil As String = TextBox1.Text
        Dim filOne As FileInfo = New FileInfo(fil)

        If filOne.Exists() Then

            MessageBox.Show("El fichero se encuentra en la ruta: " + filOne.DirectoryName)
            MessageBox.Show("La extensión del fichero introducida es: " + filOne.Extension)
            MessageBox.Show("La fecha de última edicion del documento es: " + filOne.LastWriteTime)
            MessageBox.Show("La longitud en bytes del fichero es: " + filOne.Length.ToString + " bytes.")

        Else
            MessageBox.Show("El fichero introducido no existe")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
