Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEjercicio07.Employees' Puede moverla o quitarla según sea necesario.
        Me.EmployeesTableAdapter.Fill(Me.DsEjercicio07.Employees)

    End Sub
End Class