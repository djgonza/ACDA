Imports System
Imports System.IO

Public Class frnTarea05

    Private Sub frnTarea05_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim doc As XDocument = <?xml version='1.0'?>
                               <!-- Este documento XML representa el inventario de coches -->
                               <coches>
                                   <coche marca="BMW">
                                       <modelo>520</modelo>
                                       <potencia>125CV</potencia>
                                   </coche>
                                   <coche marca="BMW">
                                       <modelo>525</modelo>
                                       <potencia>135CV</potencia>
                                   </coche>
                                   <coche marca="Citroen">
                                       <modelo>C3</modelo>
                                       <potencia>75CV</potencia>
                                   </coche>
                                   <coche marca="Citroen">
                                       <modelo>C4</modelo>
                                       <potencia>115CV</potencia>
                                   </coche>
                                   <coche marca="Citroen">
                                       <modelo>C5</modelo>
                                       <potencia>135CV</potencia>
                                   </coche>
                               </coches>
        doc.Save("coches.xml")
        Console.WriteLine(File.ReadAllText("coches.xml"))

        'Cargamos la solucion
        Dim xmlCargado = XDocument.Load("coches.xml")
        rtbOriginal.Text = xmlCargado.ToString
    End Sub


    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        Dim marca, modelo, potencia As String
        Dim pos As Integer = cmbMarcas.SelectedIndex

        marca = cmbMarcas.Items.Item(pos)
        modelo = txtModelo.Text
        potencia = txtPotencia.Text

        MessageBox.Show("Marca: " + marca + " - Modelo: " + modelo + " - Potencia: " + potencia)

        Dim nuevo As XElement = _
            <coches>
                <coche marca=<%= marca %>>
                    <modelo><%= modelo %></modelo>
                    <potencia><%= potencia %>CV</potencia>
                </coche>
            </coches>

        Dim xmlTree As XElement = _
            <coches>
                <coche marca="BMW">
                    <modelo>520</modelo>
                    <potencia>125CV</potencia>
                </coche>
                <coche marca="BMW">
                    <modelo>525</modelo>
                    <potencia>135CV</potencia>
                </coche>
                <coche marca="Citroen">
                    <modelo>C3</modelo>
                    <potencia>75CV</potencia>
                </coche>
                <coche marca="Citroen">
                    <modelo>C4</modelo>
                    <potencia>115CV</potencia>
                </coche>
                <coche marca="Citroen">
                    <modelo>C5</modelo>
                    <potencia>135CV</potencia>
                </coche>
            </coches>
        If rbtFinal.Checked Then
            xmlTree.Add(nuevo)
        Else
            xmlTree.AddFirst(nuevo)
        End If

        Console.WriteLine(xmlTree)
        rtbAñadido.Text = xmlTree.ToString
    End Sub
    
End Class
