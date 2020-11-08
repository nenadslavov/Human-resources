Imports System.Data.SqlClient
Public Class brisanje
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        opcije.Visible = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cmdNalog As New SqlCommand("DELETE FROM Nalog Where id_radnika = '" & txtBrisanje.Text & "'", connection)
        Dim command As New SqlCommand("DELETE FROM RADNIK Where id_radnika = '" & txtBrisanje.Text & "'", connection)
        Dim cmdPrava As New SqlCommand("DELETE from Prava where id_radnika= '" & txtBrisanje.Text & "'", connection)
        connection.Open()
        If (command.ExecuteNonQuery() = 1 And cmdNalog.ExecuteNonQuery() = 1 And cmdPrava.ExecuteNonQuery() = 1) Then
            MessageBox.Show("Uspesno obrisano!")
        Else
            MessageBox.Show("Greska u brisanju!")
        End If
        Dim command1 As New SqlCommand("select id_radnika, ime, prezime, posao from radnik", connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
        txtBrisanje.Clear()
    End Sub

    Private Sub brisanje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connection.Open()
        Dim command As New SqlCommand("select id_radnika, ime, prezime, posao from radnik", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        opcije.Close()
        prijava.Close()
    End Sub

    Private Sub txtBrisanje_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrisanje.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtBrisanje.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
    End Sub
End Class