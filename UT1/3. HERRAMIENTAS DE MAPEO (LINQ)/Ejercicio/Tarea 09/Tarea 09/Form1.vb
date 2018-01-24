Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim doc As XDocument = XDocument.Load("bailes.xml")
        rtbOriginal.Text = doc.ToString
    End Sub

    Private Sub btnTransformar_Click(sender As System.Object, e As System.EventArgs) Handles btnTransformar.Click
        Dim doc As XDocument = XDocument.Load("bailes.xml")

        Dim docHtml =
            <html>
                <body>
                    <%= From baile In doc.<Bailes>.<baile>
                        Select <div id=<%= baile.@id %>>
                                   <h1>Baile: <%= baile.<nombre>.Value %></h1>
                                   <p>Precio cuota "<%= baile.<precio>.@cuota %>": <%= baile.<precio>.Value %>€</p>
                                   <p>Plazas: <%= baile.<plazas>.Value %></p>
                                   <p>Comienzo: <%= baile.<comienzo>.Value %></p>
                                   <p>Fin: <%= baile.<fin>.Value %></p>
                                   <p>Profesor: <%= baile.<profesor>.Value %></p>
                                   <p>Sala: <%= baile.<sala>.Value %></p>
                                   <hr/>
                               </div> %>
                </body>
            </html>
        docHtml.Save("bailes.html")
        rtbResultado.Text = docHtml.ToString

    End Sub

End Class
