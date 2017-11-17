Imports System.IO

Public Class frnTarea08

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim ruta As String = txtRuta.Text

        Dim doc As XDocument = <?xml version='1.0'?>
                               <!-- Este documento XML representa el arbol de archivos de la ruta -->
                               <Archivos>
                               </Archivos>

        If Not Directory.Exists(ruta) Then
            MessageBox.Show("Directorio no existe")
            Exit Sub
        End If

        Dim infoReader As System.IO.FileInfo

        For Each archivo As String In Directory.GetFiles(ruta)
            infoReader = My.Computer.FileSystem.GetFileInfo(archivo)
            Dim nuevo As XElement = _
                                    <Archivo isReadonly=<%= infoReader.IsReadOnly %>>
                                        <Nombre><%= Path.GetFileName(archivo) %></Nombre>
                                        <Extensión><%= Path.GetExtension(archivo) %></Extensión>
                                        <NombreCompleto><%= Path.GetFullPath(archivo) %></NombreCompleto>
                                        <Carpeta><%= Path.GetFileName(archivo) %></Carpeta>
                                        <Tamaño><%= File.ReadAllBytes(archivo).Length.ToString %></Tamaño>
                                    </Archivo>

            doc.Root.Add(nuevo)
        Next

        rtbMostrar.Text = doc.ToString
        doc.Save("Archivos.xml")
        Console.WriteLine(File.ReadAllText("Archivos.xml"))
    End Sub
   
End Class
