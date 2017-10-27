Imports System
Imports System.IO

Public Class Form1


    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim doc As XDocument = <?xml version="1.0" encoding="utf-8"?>
                               <Contactos>
                                   <Contacto>
                                       <Nombre>Juan</Nombre>
                                       <EMail>juan@gmail.com</EMail>
                                       <Telefono Móvil="666666666" Trabajo="911111111"/>
                                   </Contacto>
                                   <Contacto>
                                       <Nombre>Luis</Nombre>
                                       <EMail>luis@gmail.com</EMail>
                                       <Telefono Móvil="666777777"/>
                                   </Contacto>
                                   <Contacto>
                                       <Nombre>María</Nombre>
                                       <EMail>maria@gmail.com</EMail>
                                       <Telefono Móvil="666888888" Personal="91222222"/>
                                   </Contacto>
                                   <Contacto>
                                       <Nombre>Lola</Nombre>
                                       <EMail>lola@gmail.com</EMail>
                                       <Telefono Móvil="666888888" Personal="91222222"/>
                                   </Contacto>
                               </Contactos>
        doc.Save("Contactos.xml")
        Console.WriteLine(File.ReadAllText("Contactos.xml"))
        lblMensaje.Text = "Documento Creado"
    End Sub

    Private Sub btnConsulta1_Click(sender As System.Object, e As System.EventArgs) Handles btnConsulta1.Click
        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("Contactos.xml")

        'Limpiar la lista
        lstConsulta1.Items.Clear()

        'crear consulta
        Dim Seleccion = _
            From datos In doc...<Contacto>
            Select datos.<Nombre>.Value

        'ejecutar consulta
        For Each s In Seleccion
            lstConsulta1.Items.Add(s)
        Next

    End Sub

    Private Sub btnConsulta2_Click(sender As System.Object, e As System.EventArgs) Handles btnConsulta2.Click
        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("Contactos.xml")

        'Limpiar la lista
        lstConsulta2.Items.Clear()

        'crear consulta
        Dim Seleccion = _
            From datos In doc...<Contacto>
            Where datos.<Nombre>.Value Like "L*"
            Select datos.<Nombre>.Value, datos.<Telefono>.@Móvil

        'ejecutar consulta
        For Each s In Seleccion
            Dim nombre As String = s.Nombre
            Dim telefono As String = s.Móvil
            lstConsulta2.Items.Add(nombre + " - " + telefono)
        Next

    End Sub
End Class
