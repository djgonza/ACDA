Imports System
Imports System.IO

Public Class frnTarea03

    Private Sub frnTarea03_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim doc As XDocument = <?xml version="1.0" encoding="UTF-8"?>
                               <Bailes>
                                   <baile id="1">
                                       <nombre>Tango</nombre>
                                       <precio cuota="mensual">37</precio>
                                       <plazas>16</plazas>
                                       <comienzo>2012-09-01</comienzo>
                                       <fin>2012-12-01</fin>
                                       <profesor>Juan Diego</profesor>
                                       <sala>A1</sala>
                                   </baile>
                                   <baile id="2">
                                       <nombre>Cha-cha-cha</nombre>
                                       <precio cuota="trimestral">90</precio>
                                       <plazas>12</plazas>
                                       <comienzo>2012-02-01</comienzo>
                                       <fin>2012-11-01</fin>
                                       <profesor>Maitetxu</profesor>
                                       <sala>A1</sala>
                                   </baile>
                                   <baile id="3">
                                       <nombre>Rock</nombre>
                                       <precio cuota="mensual">43</precio>
                                       <plazas>15</plazas>
                                       <comienzo>2012-01-01</comienzo>
                                       <fin>2012-06-01</fin>
                                       <profesor>Saioa</profesor>
                                       <sala>A1</sala>
                                   </baile>
                                   <baile id="4">
                                       <nombre>Bachata</nombre>
                                       <precio cuota="mensual">25</precio>
                                       <plazas>18</plazas>
                                       <comienzo>2012-09-01</comienzo>
                                       <fin>2012-12-01</fin>
                                       <profesor>Paco</profesor>
                                       <sala>A3</sala>
                                   </baile>
                                   <baile id="5">
                                       <nombre>Salsa</nombre>
                                       <precio cuota="trimestral">75</precio>
                                       <plazas>22</plazas>
                                       <comienzo>2012-02-01</comienzo>
                                       <fin>2012-08-01</fin>
                                       <profesor>Marieta</profesor>
                                       <sala>A3</sala>
                                   </baile>
                                   <baile id="6">
                                       <nombre>Pasodoble</nombre>
                                       <precio cuota="anual">180</precio>
                                       <plazas>12</plazas>
                                       <comienzo>2012-01-01</comienzo>
                                       <fin>2013-01-01</fin>
                                       <profesor>Fatima</profesor>
                                       <sala>A3</sala>
                                   </baile>
                               </Bailes>
        doc.Save("bailes.xml")
        Console.WriteLine(File.ReadAllText("bailes.xml"))
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        'obtener origen de datos
        Dim doc As XDocument = XDocument.Load("bailes.xml")

        'Generar la consulta
        Dim Seleccion = _
            From dato In doc...<baile>
            Where dato.<plazas>.Value > 15
            Select dato

        'ejecutar consulta. Para comprobar si la consulta lo hace biiieeeeeen
        For Each s In Seleccion
            lstSeleccion.Items.Add(s)
        Next

        'Crear el documento bailes2.xml a partir de la consulta
        Dim doc2 As XDocument = <?xml version="1.0" encoding="UTF-8"?>
                                <Bailes>
                                    <%= Seleccion %>
                                </Bailes>
        doc2.Save("bailes2.xml")
        Console.WriteLine(File.ReadAllText("bailes2.xml"))
        MessageBox.Show("Documento bailes2.xml creado!!!")

        'Cargamos la solucion
        Dim xmlCargado = XDocument.Load("bailes2.xml")
        rtbSolucion.Text = xmlCargado.ToString
    End Sub
End Class
