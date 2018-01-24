Imports System
Imports System.IO

Public Class frnTarea05

    Private Sub frnTarea05_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        Dim xmlCargado = XDocument.Load("coches.xml")
       
        If rbtFinal.Checked Then
            xmlCargado.Root.Add(nuevo)
        Else
            xmlCargado.Root.AddFirst(nuevo)
        End If

        Console.WriteLine(xmlCargado)
        rtbAñadido.Text = xmlCargado.ToString
        'xmlCargado.Save("coches.xml")
    End Sub
    
End Class
