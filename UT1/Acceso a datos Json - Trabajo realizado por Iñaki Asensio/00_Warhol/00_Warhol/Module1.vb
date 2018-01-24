Module Module1

    'WARHOL'S COLORS
    Public colorAmarillo As Color = Color.FromArgb(255, 255, 10)
    Public colorVerde As Color = Color.FromArgb(145, 190, 10)
    Public colorAzulMarino As Color = Color.FromArgb(40, 30, 130)
    Public colorAzul As Color = Color.FromArgb(0, 135, 235)
    Public colorFucsia As Color = Color.FromArgb(230, 5, 125)
    Public colorRosa As Color = Color.FromArgb(245, 145, 195)
    Public colorNaranja As Color = Color.FromArgb(240, 130, 10)
    Public colorMorado As Color = Color.FromArgb(120, 35, 155)
    Public colorAmarilloClaro As Color = Color.FromArgb(255, 250, 165)
    Public colorVerdeMarino As Color = Color.FromArgb(35, 110, 105)

    Public col1() As Color = {colorAzulMarino, colorAmarillo, colorVerde}
    Public col2() As Color = {colorMorado, colorNaranja, colorAzul}
    Public col3() As Color = {colorFucsia, colorVerdeMarino, Color.White}
    Public col4() As Color = {colorFucsia, colorAzul, colorAmarillo}
    Public col5() As Color = {Color.Black, Color.Red, Color.White}
    Public col6() As Color = {Color.Red, colorAmarillo, colorVerde}
    Public col7() As Color = {Color.Red, colorAzulMarino, colorRosa}
    Public col8() As Color = {colorNaranja, colorVerde, colorAmarilloClaro}
    Public col9() As Color = {colorAzulMarino, colorFucsia, colorNaranja}

    Public colores() As Array = {col1, col2, col3, col4, col5, col6, col7, col8, col9}


    Public Sub smsAdvertencia(ByVal mensaje)
        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub smsInfo(ByVal mensaje)
        MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub smsError(ByVal mensaje)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function confirmar(pregunta As String) As Boolean
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show(pregunta, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = Windows.Forms.DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
