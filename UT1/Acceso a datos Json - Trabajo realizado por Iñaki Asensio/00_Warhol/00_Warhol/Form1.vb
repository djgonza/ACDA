Imports System.IO

Public Class frmWarhol

    Private Sub btnSelecionarImagen_Click(sender As Object, e As EventArgs) Handles btnSelecionarImagen.Click

        ' Abrir un dialogo para seleccionar la imagen
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.InitialDirectory = ".\"
        ofd.Filter = "todo (*.*)|*.*|png files (*.png)|*.png|jpg files (*.jpg)|*.jpg"

        ' Si se selecciona una imagen y se pulsa aceptar...
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                ' Crear un Bitmap con la imagen
                Dim filePath As String = Path.GetFullPath(ofd.FileName)
                Dim imagen As Image = Image.FromFile(filePath)
                Dim bm As Bitmap = New Bitmap(imagen)
                txtBarraEstado.Text = "Imagen Selecionada: " & ofd.FileName

                ' Pasar la imagen al picbox y obtener el ancho y largo
                picOriginal.Image = imagen
                txtAncho.Text = bm.Width
                txtAlto.Text = bm.Height
                btnGenerarWarhol.Enabled = True
                mnuGenerarWarhol.Enabled = True

                'Ajustar la barra de progreso
                pbGenerar.Maximum = bm.Width * bm.Height * 3
                pbGenerar.Value = 0

            Catch ex As Exception
                smsError("Error al cargar la imagen")
            Finally

            End Try
        End If

    End Sub

    Private Sub btnGenerarWarhol_Click(sender As Object, e As EventArgs) Handles btnGenerarWarhol.Click

        ' Obtener la imagen del picbox y su ancho y alto
        txtBarraEstado.Text = "Generando la imagen Warhol..."
        Dim bm As Bitmap = New Bitmap(picOriginal.Image)
        Dim ancho As Integer = bm.Width
        Dim alto As Integer = bm.Height

        ' Crear un nuevo bitmap con el triple de ancho y el triple de alto
        Dim wbm As Bitmap = New Bitmap(ancho * 3, alto * 3)
        txtAnchoWH.Text = ancho * 3
        txtAltoWH.Text = alto * 3

        ' Recorrer cada pixel de la imagen original
        For x = 0 To bm.Width - 1
            For y = 0 To bm.Height - 1

                ' Obtener el color del pixel
                Dim col As Color = bm.GetPixel(x, y)

                'Obtener los colores (R,G,B) del color
                Dim rojo As Integer = col.R
                Dim verde As Integer = col.G
                Dim azul As Integer = col.B
                Dim colMedia = (rojo + verde + azul) / 3 ' Obtener la media de los tres
                Dim colNuevo = New Color()
                'Generar el tono del pixel, para luego coger un color u otro
                Dim tono As Integer
                If colMedia < 85 Then
                    tono = 0
                ElseIf colMedia < 170 Then
                    tono = 1
                Else
                    tono = 2
                End If

                ' Recorrer la imagen tres veces * tres, para pintar las 9 partes de la nueva imagen
                Dim xx As Integer = x
                Dim c As Integer = 0
                For i = 0 To 2
                    Dim yy As Integer = y
                    For j = 0 To 2
                        wbm.SetPixel(xx, yy, colores(c)(tono))
                        yy += alto
                        c += 1
                    Next
                    xx += ancho
                    pbGenerar.Value += 1
                Next

            Next
        Next

        'Habilitar botones y menu
        btnGuardar.Enabled = True
        mnuGuardarComo.Enabled = True
        btnGenerarWarhol.Enabled = False
        mnuGenerarWarhol.Enabled = False

        ' Cargar en el picbox la imagen generada y mostrar un mensaje en la barra de estado
        picWarhol.Image = wbm
        txtBarraEstado.Text = "Imagen Warhol generada, recuerde guardarla si le gusta"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Declarar un dialogo para guardar la imagen
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.InitialDirectory = ".\"
        sfd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png"

        ' Si se da un fichero para guardar y se pulsa en aceptar...
        If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                ' Recogermos la imagen del picbox y la guardamos
                Dim imagen As Image = picWarhol.Image
                Dim fichero As String = sfd.FileName
                imagen.Save(fichero)
                txtBarraEstado.Text = "Imagen Warhol Guardada como: " & fichero

            Catch ex As Exception
                smsError("Error al guardar la imagen.")
            End Try
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        btnSelecionarImagen.PerformClick()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        btnSalir.PerformClick()
    End Sub

    Private Sub GenerarWarholToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGenerarWarhol.Click
        btnGenerarWarhol.PerformClick()
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        btnGuardar.PerformClick()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
