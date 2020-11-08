Imports System.Data.SqlClient
Public Class izmenauser
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub btnUserizmena_Click(sender As System.Object, e As System.EventArgs) Handles btnUserizmena.Click
        Dim command As New SqlCommand("update nalog set username='" & txtIzmenauser.Text & "'  where username='" & prijava.txtUsername.Text & "' ", connection)
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Uspesno ste promenili korisničko ime!")
        Else : MessageBox.Show("Niste promenili korisničko ime!")
        End If
        Dim command1 As New SqlCommand("select * from radnik r inner join nalog n on r.id_radnika = n.id_radnika where username='" & txtIzmenauser.Text & "'", connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        status.dgvStatus.DataSource = table
        connection.Close()
        Me.Close()
        status.Visible = True

    End Sub
End Class