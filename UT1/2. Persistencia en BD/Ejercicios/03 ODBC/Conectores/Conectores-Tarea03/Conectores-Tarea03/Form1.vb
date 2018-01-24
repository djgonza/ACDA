Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEjercicio6.authors' Puede moverla o quitarla según sea necesario.
        Me.AuthorsTableAdapter2.Fill(Me.DsEjercicio6.authors)
        'TODO: esta línea de código carga datos en la tabla 'DsEjercicio4.Employees' Puede moverla o quitarla según sea necesario.
        Me.EmployeesTableAdapter1.Fill(Me.DsEjercicio4.Employees)
        'TODO: esta línea de código carga datos en la tabla 'DsAuthorsEjercicio3.authors' Puede moverla o quitarla según sea necesario.
        Me.AuthorsTableAdapter1.Fill(Me.DsAuthorsEjercicio3.authors)
        'TODO: esta línea de código carga datos en la tabla 'DsEmployeesNS.Employees' Puede moverla o quitarla según sea necesario.
        Me.EmployeesTableAdapter.Fill(Me.DsEmployeesNS.Employees)
        'TODO: esta línea de código carga datos en la tabla 'DsAuthors.authors' Puede moverla o quitarla según sea necesario.
        Me.AuthorsTableAdapter.Fill(Me.DsAuthors.authors)

    End Sub
    
End Class
