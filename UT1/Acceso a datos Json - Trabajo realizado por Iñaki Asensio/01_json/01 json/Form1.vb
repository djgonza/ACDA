Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq

Imports Newtonsoft.Json
Imports System.Text

Public Class frmPrincipal
    Private num As Integer
    Private usuario As Integer
    Private usuarios() As Array
    'URL ejemplo: https://randomuser.me/api/?results=50&inc=gender,name,nat,picture,email,phone

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        'Ajustar el numero de usurios
        num = numUsuariosARecibir.Value
        ReDim Preserve usuarios(num - 1)

        ' Declarar he instanciar el cliente web y la URL como string
        Dim client As New WebClient()
        Dim url As String = "https://randomuser.me/api/?results=" & CStr(num) &
                                "&inc=gender,name,nat,picture,email,phone"

        ' Obtener la URL, leear los datos y almacenarlos como un string
        Dim data As Stream = client.OpenRead(url)
        Dim reader As New StreamReader(data)
        Dim jsonString As String = reader.ReadToEnd()

        ' Con el string generamos un objeto JObject
        Dim jsonObject As JObject = JObject.Parse(jsonString)
        ' Generar un array con el token results, que el el que contiene los usuarios en el Array
        Dim users() As Object = jsonObject.SelectToken("results").ToArray

        'Declarar las variables para mas adelante recoger los datos 
        Dim gender As String, title As String, first As String, last As String, email As String, phone As String, nat As String, picture As String

        Dim i As Integer = 0        ' Indice para almacenar los datos en el Array
        For Each user In users      ' Recorrer el array para coger los datos recibidos del json y almacenarlo en el array usuarios

            gender = user.SelectToken("gender").ToString

            Dim jName As JObject = JObject.Parse(user.SelectToken("name").ToString)
            title = jName.SelectToken("title").ToString()
            first = jName.SelectToken("first").ToString()
            last = jName.SelectToken("last").ToString()

            email = user.SelectToken("email").ToString
            phone = user.SelectToken("phone").ToString

            Dim jPicture As JObject = JObject.Parse(user.SelectToken("picture").ToString)
            picture = jPicture.SelectToken("large").ToString()

            nat = user.SelectToken("nat").ToString

            ' Almacenar los datos recogidos en el array usuarios
            usuarios(i) = {title, first, last, gender, email, phone, nat, picture}
            i += 1

        Next

        ' Visualizar el grupo con los campos de texto
        gruUsuario.Visible = True
        ' cargar el primer usuario
        visualizarUsuario(0)
        ' Habilitar botón para guardar
        btnGuardarJson.Enabled = True
        ' Cerrar el Stream y StreamReader 
        data.Close()
        reader.Close()

    End Sub

    Sub visualizarUsuario(ByVal i As Integer)

        'Actulizar los datos del so campos con el nuevo usuario a mostrar
        txtUserNum.Text = CStr(i + 1)
        lblName.Text = usuarios(i)(0)
        txtName.Text = usuarios(i)(1) & " " & usuarios(i)(2)
        txtGenre.Text = usuarios(i)(3)
        txtEmail.Text = usuarios(i)(4)
        txtPhone.Text = usuarios(i)(5)
        txtNat.Text = usuarios(i)(6)
        picImagen.ImageLocation = usuarios(i)(7)

        'Desactivar los botón anterior cuando es el primer usuario y siguiente cuando es el último 
        btnAnterior.Enabled = If(i = 0, False, True)
        btnSiguiente.Enabled = If(i = num - 1, False, True)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gruUsuario.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click, btnSiguiente.Click

        ' Pasar al anterior usuario o al siguiente en función del botón pulsado
        Dim botones() As Button = {btnAnterior, btnSiguiente}
        Dim b As Integer = Array.IndexOf(botones, sender)
        usuario += If(b = 0, -1, 1)
        visualizarUsuario(usuario)

    End Sub

    Private Sub btnGuardarJson_Click(sender As Object, e As EventArgs) Handles btnGuardarJson.Click

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        Dim newJSON As String = Nothing
        sfd.Filter = "Ficheros JSON (*.json)|*.json"

        If sfd.ShowDialog() = DialogResult.OK Then
            newJSON = sfd.FileName

            ' Dar formato al archivo Json
            Dim sb As New StringBuilder()
            Dim sw As New StringWriter(sb)
            Using writer As JsonWriter = New JsonTextWriter(sw)
                writer.Formatting = Formatting.Indented
                writer.WriteStartObject()
                writer.WritePropertyName("Usuarios")
                writer.WriteStartArray()

                For i = 0 To usuarios.Length - 1
                    writer.WriteStartObject()
                    writer.WritePropertyName("Título")
                    writer.WriteValue(usuarios(i)(0))
                    writer.WritePropertyName("Nombre")
                    writer.WriteValue(usuarios(i)(1))
                    writer.WritePropertyName("Apellido")
                    writer.WriteValue(usuarios(i)(2))
                    writer.WritePropertyName("Género")
                    writer.WriteValue(usuarios(i)(3))
                    writer.WritePropertyName("Mail")
                    writer.WriteValue(usuarios(i)(4))
                    writer.WritePropertyName("Teléfono")
                    writer.WriteValue(usuarios(i)(5))
                    writer.WritePropertyName("Nacionalidad")
                    writer.WriteValue(usuarios(i)(6))
                    writer.WritePropertyName("Foto")
                    writer.WriteValue(usuarios(i)(7))
                    writer.WriteEndObject()
                Next

                writer.WriteEnd()
                writer.WriteEndObject()
            End Using

            ' Guardar el archivo
            Try
                Dim nsw As New StreamWriter(newJSON)
                nsw.Write(sw)
                nsw.Close()
                smsInfo("Archivo JSON guardado correctamente")
            Catch ex As Exception
                smsError("Error al guardar el archivo JSON")
            End Try

        End If

    End Sub

    Public Sub smsAdvertencia(ByVal mensaje)
        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub smsInfo(ByVal mensaje)
        MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub smsError(ByVal mensaje)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


End Class
