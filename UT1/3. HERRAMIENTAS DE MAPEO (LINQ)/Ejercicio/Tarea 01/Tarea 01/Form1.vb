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

    Private Sub btnCargar_Click(sender As System.Object, e As System.EventArgs) Handles btnCargar.Click
        Dim xmlCargado = XDocument.Load("Contactos.xml")
        txtTexto.Text = xmlCargado.ToString
    End Sub
    
End Class
