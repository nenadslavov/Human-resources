Imports System.Data.SqlClient
Public Class opcije

    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub opcije_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim command As New SqlCommand("select nazivprava from prava p inner join radnik r on p.id_radnika=r.id_radnika inner join nalog n on r.id_radnika = n.id_radnika where username='" & prijava.txtUsername.Text & "'  ", connection)
        Dim command As New SqlCommand("select nazivprava from prava where id_radnika=(select id_radnika from nalog where username='" & prijava.txtUsername.Text & "') ", connection)
        connection.Open()
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If (table.Rows(0)(0).ToString() = "nivo1") Then
            btnPregled.Enabled = False
            btnDodavanje.Enabled = False
            btnBrisanje.Enabled = False
            btnIzmena.Enabled = False
        ElseIf (table.Rows(0)(0).ToString() = "nivo2") Then
            btnBrisanje.Enabled = False
        End If
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnPregled.Click
        prijava.Visible = False
        Me.Visible = False
        pregled.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnDodavanje.Click
        Me.Visible = False
        prijava.Visible = False
        dodavanje.Visible = True

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnBrisanje.Click
        Me.Visible = False
        prijava.Visible = False
        brisanje.Visible = True
    End Sub

    Private Sub btnStatus_Click(sender As System.Object, e As System.EventArgs) Handles btnStatus.Click
        Me.Visible = False
        prijava.Visible = False
        status.ShowDialog()
    End Sub

    Private Sub btnOpcijeBack_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcijeBack.Click
        Me.Visible = False
        prijava.Visible = True
    End Sub

    Private Sub btnIzmena_Click(sender As System.Object, e As System.EventArgs) Handles btnIzmena.Click
        Me.Visible = False
        prijava.Visible = False
        izmena.Visible = True
    End Sub

    Private Sub btnStatus_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnStatus.MouseEnter
        btnStatus.BackColor = Color.AntiqueWhite




    End Sub

    Private Sub btnStatus_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnStatus.MouseLeave
        btnStatus.BackColor = Color.Transparent
    End Sub

    Private Sub btnPregled_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnPregled.MouseEnter
        btnPregled.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnPregled_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnPregled.MouseLeave
        btnPregled.BackColor = Color.Transparent
    End Sub

    Private Sub btnBrisanje_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnBrisanje.MouseEnter
        btnBrisanje.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnBrisanje_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnBrisanje.MouseLeave
        btnBrisanje.BackColor = Color.Transparent
    End Sub

    Private Sub btnDodavanje_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnDodavanje.MouseEnter
        btnDodavanje.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnDodavanje_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnDodavanje.MouseLeave
        btnDodavanje.BackColor = Color.Transparent
    End Sub

    Private Sub btnIzmena_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnIzmena.MouseEnter
        btnIzmena.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnIzmena_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnIzmena.MouseLeave
        btnIzmena.BackColor = Color.Transparent

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        prijava.Close()
    End Sub
End Class