Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '¿ASÍ MEJOR? ;)
        'Cargamos la solucion
        Dim xmlCargado = XDocument.Load("bailes.xml")
        rtbOriginal.Text = xmlCargado.ToString
    End Sub

    Private Sub btnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiar.Click
        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("bailes.xml")

        'Generar la consulta
        Dim Seleccion = _
            From dato In doc...<baile>
            Select <nuevoNodo>
                       <id>
                           <%= dato.@id %>
                       </id>
                       <%= dato.<nombre> %>
                       <%= dato.<plazas> %>
                       <%= dato.<profesor> %>
                   </nuevoNodo>

        'Crear el documento bailes2.xml a partir de la consulta
        Dim doc2 As XDocument = <?xml version="1.0" encoding="UTF-8"?>
                                <Bailes>
                                    <%= Seleccion %>
                                </Bailes>
        doc2.Save("Actividades2.xml")
        Console.WriteLine(File.ReadAllText("Actividades2.xml"))
        MessageBox.Show("Documento Actividades2.xml creado!!!")

        'Cargamos la solucion
        Dim xmlCargado = XDocument.Load("Actividades2.xml")
        rtbResultado.Text = xmlCargado.ToString
    End Sub
End Class
