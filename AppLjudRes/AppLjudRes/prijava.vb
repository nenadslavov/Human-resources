Imports System.Data.SqlClient
Public Class prijava
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnPrijavise.Click
        Dim command As New SqlCommand("Select * from nalog where username= '" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", connection)
        connection.Open()
        If command.ExecuteScalar = 0 Then
            MessageBox.Show("Progrešan username ili password. Pokušajte ponovo.")
            txtPassword.Clear()

            connection.Close()
        Else
            txtPassword.Clear()
            Me.Visible = True
            opcije.ShowDialog()

        End If
        connection.Close()


    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub prijava_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
