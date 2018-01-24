Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cn As New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= |DataDirectory|\MUSICA.accdb"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch oledbex As OleDbException
            MessageBox.Show(oledbex.ToString, "Error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cn As New OdbcConnection
        cn.ConnectionString = "Dsn=ParaDatosUsuario"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch odbcex As OdbcException
            MessageBox.Show(odbcex.ToString, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim cn As New OdbcConnection
        cn.ConnectionString = "FileDsn=ParaMusicaArchivo.dsn"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch odbcex As OdbcException
            MessageBox.Show(odbcex.ToString, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim cn As New OdbcConnection
        cn.ConnectionString = "DRIVER=Microsoft Access Driver (*.mdb, *.accdb); DBQ=C:\Bases\Musica\MUSICA.accdb"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch odbcex As OdbcException
            MessageBox.Show(odbcex.ToString, "Error")
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim cn As New OdbcConnection
        cn.ConnectionString = "FileDsn=ParaIllinois.dsn"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch odbcex As OdbcException
            MessageBox.Show(odbcex.ToString, "Error")
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim cn As New OleDbConnection
        cn.ConnectionString = "Provider=sqloledb;Data Source=A06SERVIDOR1\SQLEXPRESS; Initial Catalog=Northwind ;User Id=alumnoserver;Password=alumnoserver;"
        Try
            cn.Open()
            MessageBox.Show(cn.ConnectionString, "Conexión abierta")
            cn.Close()
            MessageBox.Show("Conexión cerrada", "Éxito")
        Catch oledbex As OleDbException
            MessageBox.Show(oledbex.ToString, "Error")
        End Try
    End Sub
End Class
