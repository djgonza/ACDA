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
        Dim pos As Integer = cmbMarcas.SelectedIndex
        Dim marca As String = cmbMarcas.Items.Item(pos)

        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("coches.xml")

        'crear consulta
        Dim Seleccion = _
            From dato In doc...<coche>
            Where dato.@marca Like marca
            Select dato

        'Eliminamos la seleccion de documento
        Seleccion.Remove()

        'Cargamos el resultado en el rtbResultado
        rtbResultado.Text = doc.ToString

    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim pos As Integer = cmbMarca.SelectedIndex
        Dim marca As String = cmbMarca.Items.Item(pos)
        'MessageBox.Show(marca)

        Dim pos2 As Integer = cmbMarca2.SelectedIndex
        Dim marca2 As String = cmbMarca2.Items.Item(pos2)
        'MessageBox.Show(marca2)

        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("coches.xml")

        'Creamos una variable que recoja la información de los coches
        Dim coches = doc.<coches>.Elements

        'Recorremos dicha variable
        For Each coche In coches
            'Comparamos que el atributo marca sea igual al primer ComboBox
            If coche.@marca = marca Then
                'Cambiamos el atributo a la marca seleccionada en el segundo ComboBox
                coche.SetAttributeValue("marca", marca2)
            End If
        Next

        'Cargamos el resultado en el rtbResultado
        rtbResultado.Text = doc.ToString


    End Sub
End Class
