Imports System
Imports System.IO

Public Class frnTarea06

    Private Sub frnTarea06_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub rbtModificar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtModificar.CheckedChanged
        gpbModificar.Enabled = True
        gpbEliminar.Enabled = False
    End Sub

    Private Sub rbtEliminar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtEliminar.CheckedChanged
        gpbModificar.Enabled = False
        gpbEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

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

        xmlTree.RemoveAll()
        Console.WriteLine(xmlTree)
        rtbAñadido.Text = xmlTree.ToString
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim pos As Integer = cmbMarcas.SelectedIndex
        Dim marca As String = cmbMarcas.Items.Item(pos)

        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("coches.xml")

        'Generar la consulta
        Dim Seleccion = _
            From dato In doc...<coche>
            Where dato.@marca Like marca

    End Sub
End Class
