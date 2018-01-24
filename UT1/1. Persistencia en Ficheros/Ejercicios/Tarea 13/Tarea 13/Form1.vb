Imports System.Xml
Imports System.IO
Imports System.Text

Public Class frnTarea13

    Private Sub btnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click
        Dim doc As XDocument
        doc = XDocument.Load("libros.xml")

        rtbMostrar.Text = doc.ToString
    End Sub

    Private Sub btnSecuencial_Click(sender As System.Object, e As System.EventArgs) Handles btnSecuencial.Click
        Dim Lector As New XmlTextReader("Libros.xml")

        While Lector.Read()
            Select Case Lector.NodeType
                Case XmlNodeType.Element
                    rtbSolucion.Text += (New String(" ", Lector.Depth * 3) &_ "<{0}>", Lector.Name)
                    If Lector.Name = "Libros" Or Lector.Name = "Editoriales" Then
                        rtbSolucion.Text += vbLf
                    End If

                Case XmlNodeType.Text
                    rtbSolucion.Text += Lector.Value

                Case XmlNodeType.EndElement
                    If Lector.Name = "Libros" Or Lector.Name = "Editoriales" Then
                        rtbSolucion.Text += (New String(" ", Lector.Depth * 3))
                    End If
            End Select
        End While
       
    End Sub

    Private Sub btnDom_Click(sender As System.Object, e As System.EventArgs) Handles btnDom.Click

    End Sub

    Private Sub btnPath_Click(sender As System.Object, e As System.EventArgs) Handles btnPath.Click

    End Sub

    Private Sub btnTransformacion_Click(sender As System.Object, e As System.EventArgs) Handles btnTransformacion.Click

    End Sub
End Class
