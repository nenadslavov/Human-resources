Imports System.Data.SqlClient
Public Class pregled
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        opcije.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim command As New SqlCommand("select * from radnik where ime like N'" & txtPregledime.Text & "%' and prezime like N'" & txtPregledprezime.Text & "%'", connection)

        'Dim adapter As New SqlDataAdapter(Command)
        'Dim table As New DataTable
        'adapter.Fill(table)
        'dgvPregled.DataSource = table

        Dim command1 As New SqlCommand("select * from radnik where ime like N'" & txtPregledime.Text & "%' and prezime like N'" & txtPregledprezime.Text & "%' and kvalif like '" & cmbUkvalif.Text & "%' and posao like N'" & cmbUposao.Text & "%' and id_odeljenja like '" & cmbUodelj.SelectedValue & "%' and Rukovodilac like '" & cmbUruko.SelectedValue & "%'", connection)

        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable
        adapter1.Fill(table1)
        dgvPregled.DataSource = table1
        connection.Close()

    End Sub

    Private Sub pregled_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connection.Open()
        Dim command As New SqlCommand("select * from radnik", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvPregled.DataSource = table
        connection.Close()

        Dim command51 As New SqlCommand("select Id_odeljenja, Ime_od  from dbo.ODELJENJE", connection)
        Dim adapter51 As New SqlDataAdapter(command51)
        Dim table51 As New DataTable()
        adapter51.Fill(table51)
        cmbUodelj.DataSource = table51
        cmbUodelj.DisplayMember = "Ime_od"
        cmbUodelj.ValueMember = "Id_odeljenja"
        cmbUodelj.SelectedIndex = -1

        Dim command1 As New SqlCommand("Select convert(varchar,id_radnika)+'    ' +(ime) + ' '+(Prezime) as Naziv, id_radnika from RADNIK where posao='upravnik' or posao='savetnik' or posao='direktor' ", connection)
        adapter = New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        cmbUruko.DataSource = table1
        cmbUruko.DisplayMember = "Naziv"
        cmbUruko.ValueMember = "id_radnika"
        cmbUruko.SelectedIndex = -1

        Dim command2 As New SqlCommand("select * from kvalifikacija", connection)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        cmbUkvalif.DataSource = table2
        cmbUkvalif.DisplayMember = "nazivkvalifikacije"
        cmbUkvalif.ValueMember = "id_kvalifikacija"
        cmbUkvalif.SelectedIndex = -1

        Dim command3 As New SqlCommand("select * from Posao", connection)
        Dim adapter3 As New SqlDataAdapter(command3)
        Dim table3 As New DataTable()
        adapter3.Fill(table3)
        cmbUposao.DataSource = table3
        cmbUposao.DisplayMember = "nazivposla"
        cmbUposao.ValueMember = "id_Posao"
        cmbUposao.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        opcije.Close()
        prijava.Close()
    End Sub

    Private Sub txtPregledime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPregledime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPregledprezime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPregledprezime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbUruko_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUruko.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbUodelj_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUodelj.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbUposao_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUposao.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbUkvalif_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUkvalif.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPlatamin_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlatamin.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

   
    Private Sub txtPlatamax_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlatamax.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPlatamin_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPlatamin.MouseClick
        txtPlatamin.Text = ""
    End Sub

    Private Sub txtPlatamax_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPlatamax.MouseClick
        txtPlatamax.Text = ""
    End Sub
End Class