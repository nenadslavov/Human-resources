Imports System.Data.SqlClient
Public Class status
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub status_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        opcije.Visible = False

        Dim command As New SqlCommand("select * from radnik r inner join nalog n on r.id_radnika = n.id_radnika where username='" & prijava.txtUsername.Text & "'", connection)
        connection.Open()
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStatus.DataSource = table
        connection.Close()
    End Sub


    Private Sub btnStatusback_Click(sender As System.Object, e As System.EventArgs) Handles btnStatusback.Click
        Me.Close()
        opcije.Visible = True
    End Sub


    Private Sub IzmenaLozinkeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IzmenaLozinkeToolStripMenuItem.Click
        Me.Visible = False
        izmenapass.ShowDialog()

    End Sub

    Private Sub IzmenaKorisnickogImenaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IzmenaKorisnickogImenaToolStripMenuItem.Click
        Me.Visible = False
        izmenauser.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        opcije.Close()
        prijava.Close()
    End Sub
End Class