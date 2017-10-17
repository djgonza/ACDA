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
        MessageBox.Show("*** CAMBIO DE DIRECTORIO ***")

        If Not Directory.Exists(dirTempo) Then
            MessageBox.Show("El directorio " + dirTempo + " NO existe.")
            Directory.CreateDirectory(dirTempo)
            MessageBox.Show("Directorio creado")
        End If

        Directory.SetCurrentDirectory(dirTempo)
        MessageBox.Show("El directorio actual es: " + Directory.GetCurrentDirectory)

        MessageBox.Show("RESTABLECEMOS DIRECTORIO")
        Directory.SetCurrentDirectory(dirActual)
        MessageBox.Show("El directorio actual es: " + Directory.GetCurrentDirectory)

    End Sub

    Private Sub btnDos_Click(sender As System.Object, e As System.EventArgs) Handles btnDos.Click
        MessageBox.Show("Las unidades del sistema son: ")

        For Each unidad As String In Directory.GetLogicalDrives
            MessageBox.Show(unidad)
        Next

    End Sub


    Private Sub btnTres_Click(sender As System.Object, e As System.EventArgs) Handles btnTres.Click
        Dim ruta As String
        ruta = InputBox("INTRODUZCA UNA RUTA: ")

        MessageBox.Show("-- Ficheros de lectura en la ruta --")
        For Each fil As String In Directory.GetFiles(ruta)
            Dim attributes = File.GetAttributes(fil)
            If ((attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly) And Path.GetExtension(fil) = ".docx" Then
                MessageBox.Show(fil)
            End If
        Next

    End Sub

    Private Sub btnCuatro_Click(sender As System.Object, e As System.EventArgs) Handles btnCuatro.Click

        Dim ruta As String = "C:\"

        MessageBox.Show("-- Ficheros ocultos de C: --")
        For Each fil As String In Directory.GetFiles(ruta)
            Dim attributes = File.GetAttributes(fil)
            If ((attributes And FileAttributes.Hidden) = FileAttributes.Hidden) Then
                MessageBox.Show(fil)
            End If
        Next

    End Sub


    Private Sub btnCinco_Click(sender As System.Object, e As System.EventArgs) Handles btnCinco.Click

        Dim ruta As String
        ruta = InputBox("INTRODUZCA UNA RUTA: ")

        If ruta = "" Then
            ruta = "C:\AD\UT2\Pruebas"
        End If

        Directory.CreateDirectory(ruta)

        MessageBox.Show("Directorio " + ruta + " creado")

    End Sub


    Private Sub btnSeis_Click(sender As System.Object, e As System.EventArgs) Handles btnSeis.Click
        Dim ruta As String
        ruta = InputBox("INTRODUZCA UNA RUTA: ")

        If ruta = "" Then
            ruta = "C:\AD\UT2\Pruebas"
        End If

        MessageBox.Show("Los archivos txt de " + ruta + " son:")
        For Each fil As String In Directory.GetFiles(ruta)

            If Path.GetExtension(fil) = ".txt" Then
                MessageBox.Show(fil)
            End If

        Next

    End Sub

    Private Sub btnSiete_Click(sender As System.Object, e As System.EventArgs) Handles btnSiete.Click
        Dim ruta As String
        ruta = "C:\AD\UT2\Pruebas"

        For Each fil As String In Directory.GetFiles(ruta)
            File.SetLastAccessTime(fil, Date.Now)
        Next

        MessageBox.Show("Cambio realizado.")

    End Sub


    Private Sub btnOcho_Click(sender As System.Object, e As System.EventArgs) Handles btnOcho.Click

        If Directory.GetLogicalDrives.Contains("F:\") Then
            MessageBox.Show("El directorio F:\ EXISTE")
            MessageBox.Show("Lista de directorios: ")
            For Each direc As String In Directory.GetDirectories("F:\")
                MessageBox.Show(direc)
            Next
        Else
            MessageBox.Show("El directorio F:\ no EXISTE")
        End If
    End Sub

    Private Sub btnNueve_Click(sender As System.Object, e As System.EventArgs) Handles btnNueve.Click
        If Directory.GetLogicalDrives.Contains("F:\") Then
            MessageBox.Show("El directorio F:\ EXISTE")
            MessageBox.Show("Lista de archivos txt: ")
            For Each direc As String In Directory.GetDirectories("F:\")
                mostrarFicheros(direc)
            Next
        Else
            MessageBox.Show("El directorio F:\ no EXISTE")
        End If
    End Sub

    Public Sub mostrarFicheros(ruta As String)
        For Each dir As String In Directory.GetDirectories(ruta)
            mostrarFicheros(dir)
        Next

        For Each file As String In Directory.GetFiles(ruta)
            If Path.GetExtension(file) = ".txt" Then
                MessageBox.Show(file)
            End If

        Next
    End Sub


    Private Sub btnDiez_Click(sender As System.Object, e As System.EventArgs) Handles btnDiez.Click
        If Directory.GetLogicalDrives.Contains("F:\") Then
            'MessageBox.Show("El directorio F:\ EXISTE")
            For Each direc As String In Directory.GetDirectories("F:\")
                mostrarInfo(direc)
            Next
        Else
            MessageBox.Show("El directorio F:\ no EXISTE")
        End If
    End Sub

    Public Sub mostrarInfo(ruta As String)
        For Each dir As String In Directory.GetDirectories(ruta)
            MessageBox.Show("Nombre: " + dir + vbLf + "Fecha creación: " + Directory.GetCreationTime(dir))
            mostrarInfo(dir)
        Next

        For Each fil As String In Directory.GetFiles(ruta)
            MessageBox.Show("Nombre: " + fil + vbLf + "Fecha creación: " + File.GetCreationTime(fil))
        Next
    End Sub


    Private Sub btnOnce_Click(sender As System.Object, e As System.EventArgs) Handles btnOnce.Click
        Dim fichero As String
        fichero = InputBox("INTRODUZCA UN FICHERO: ")

        If File.Exists(fichero) Then
            Dim extAnti As String
            extAnti = Path.GetExtension(fichero)
            MessageBox.Show("Antigua extension: " + extAnti)
            MessageBox.Show("Fichero con antigua extensión: " + fichero)

            Dim ext As String
            ext = InputBox("INTRODUZCA UNA EXTENSIÓN")

            MessageBox.Show("Nueva extension: " + ext)
            MessageBox.Show("Fichero con nueva extensión: " + Path.ChangeExtension(fichero, ext))

        Else
            MessageBox.Show("Fichero no existe")
        End If
    End Sub

    Private Sub btnDoce_Click(sender As System.Object, e As System.EventArgs) Handles btnDoce.Click
        Dim fileName As String = "myfile.ext"
        Dim path1 As String = "mydir"
        Dim path2 As String = "\mydir"
        Dim fullPath As String

        MessageBox.Show("** GetFullPath **")
        fullPath = Path.GetFullPath(path1)
        MessageBox.Show("path1 => " + path1 + vbLf + "fullpath => " + fullPath)

        fullPath = Path.GetFullPath(fileName)
        MessageBox.Show("fileName => " + fileName + vbLf + "fullpath => " + fullPath)

        fullPath = Path.GetFullPath(path2)
        MessageBox.Show("path2 => " + path2 + vbLf + "fullpath => " + fullPath)

        MessageBox.Show("** Ejemplo Combine **")
        Dim path3 As String = "c:\temp"
        Dim path4 As String = "subdir\file.txt"
        MessageBox.Show("La combinación den path3 => " + path3 + " y path4 => " + path4 + vbLf + "Combinación => " + Path.Combine(path3, path4))

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
