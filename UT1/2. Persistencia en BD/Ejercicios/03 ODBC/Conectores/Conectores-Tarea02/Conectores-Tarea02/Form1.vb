Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet5.Autores' Puede moverla o quitarla según sea necesario.
        Me.AutoresTableAdapter.Fill(Me.DataSet5.Autores)
        'TODO: esta línea de código carga datos en la tabla 'DATOSDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter1.Fill(Me.DATOSDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DataSet3.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSet3.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.illinois' Puede moverla o quitarla según sea necesario.
        Me.IllinoisTableAdapter.Fill(Me.DataSet1.illinois)

    End Sub
End Class
