Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        If Directory.Exists("c:/" + dir) Then
            MessageBox.Show("El directorio existe")
        Else
            MessageBox.Show("El directorio no existe")
        End If


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        Dim di As DirectoryInfo = New DirectoryInfo("c:/" + dir)

        If di.Exists Then
            MessageBox.Show("El directorio existe")
        Else
            MessageBox.Show("El directorio no existe")
        End If

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        If Directory.Exists("c:/" + dir) Then
            MessageBox.Show(Directory.EnumerateDirectories("c:/" + dir).ToArray.Length)
        Else
            MessageBox.Show("El directorio no existe")
        End If

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        Dim dirActual As DirectoryInfo = New DirectoryInfo("c:/" + dir)
        If dirActual.Exists() Then
            MessageBox.Show(dirActual.EnumerateDirectories().ToArray.Length)
        Else
            MessageBox.Show("El directorio no existe")
        End If

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        Dim ext As String = InputBox("Introduce la extension")
        Dim totalArchivos As Integer = 0
        Dim path As String = "c:/" + dir
        If Directory.Exists(path) Then

            contarArchivos(path, ext)

            For Each dirActual As String In Directory.EnumerateDirectories("c:/" + dir).ToArray

                contarArchivos(dirActual, ext)

            Next

        Else
            MessageBox.Show("El directorio no existe")
        End If

    End Sub

    Private Sub contarArchivos(path, ext)

        Dim total As Integer = 0

        For Each archivo As String In Directory.GetFiles(path)
            If archivo.Split(".")(1) = ext Then
                total += 1
            End If
        Next

        MessageBox.Show("El directorio " + path + " contiene " + total.ToString + " archivos con la extension " + ext)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        Dim dir As String = InputBox("Introduce nombre de directorio")
        Dim ext As String = InputBox("Introduce la extension")
        Dim totalArchivos As Integer = 0
        Dim path As String = "c:/" + dir
        Dim dirBuscado As DirectoryInfo = New DirectoryInfo(path)
        If dirBuscado.Exists() Then

            contarArchivosConInfo(dirBuscado, ext)

            For Each dirActual As DirectoryInfo In dirBuscado.EnumerateDirectories()

                contarArchivosConInfo(dirActual, ext)

            Next

        Else
            MessageBox.Show("El directorio no existe")
        End If

    End Sub

    Private Sub contarArchivosConInfo(dirInfo, ext)

        Dim total As Integer = 0
        For Each archivo As FileInfo In dirInfo.GetFiles()
            If archivo.FullName.Split(".")(1) = ext Then
                total += 1
            End If
        Next

        MessageBox.Show("El directorio " + dirInfo.ToString + " contiene " + total.ToString + " archivos con la extension " + ext)

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Dispose()
    End Sub
End Class
