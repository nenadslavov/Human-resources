Imports System.Data.SqlClient
Public Class dodavanje
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        opcije.Visible = True
    End Sub

    Private Sub dodavanje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand("select Id_odeljenja, Ime_od  from dbo.ODELJENJE", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cmbOdelj.DataSource = table
        cmbOdelj.DisplayMember = "Ime_od"
        cmbOdelj.ValueMember = "Id_odeljenja"
        cmbOdelj.SelectedIndex = -1

        Dim command1 As New SqlCommand("Select convert(varchar,id_radnika)+'  -  '+(ime)+ ' ' + (Prezime) as Naziv, id_radnika from RADNIK where posao='upravnik' or posao='savetnik' or posao='direktor' ", connection)
        adapter = New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        cmbRuko.DataSource = table1
        cmbRuko.DisplayMember = "Naziv"
        cmbRuko.ValueMember = "id_radnika"
        cmbRuko.SelectedIndex = -1

        Dim command2 As New SqlCommand("select * from kvalifikacija", connection)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        cmbKvalif.DataSource = table2
        cmbKvalif.DisplayMember = "nazivkvalifikacije"
        cmbKvalif.ValueMember = "id_kvalifikacija"
        cmbKvalif.SelectedIndex = -1

        Dim command3 As New SqlCommand("select * from Posao", connection)
        Dim adapter3 As New SqlDataAdapter(command3)
        Dim table3 As New DataTable()
        adapter3.Fill(table3)
        cmbPosao.DataSource = table3
        cmbPosao.DisplayMember = "nazivposla"
        cmbPosao.ValueMember = "id_Posao"
        cmbPosao.SelectedIndex = -1

        Dim command4 As New SqlCommand("select distinct nazivprava from prava", connection)
        Dim adapter4 As New SqlDataAdapter(command4)
        Dim table4 As New DataTable()
        adapter4.Fill(table4)
        cmbPrava.DataSource = table4
        cmbPrava.DisplayMember = "nazivprava"
        cmbPrava.ValueMember = "nazivprava"
        cmbPrava.Text = ""

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rnd As New Random
        Dim randomPass = Rnd.Next(1000, 9999)
        Dim randomUser = rnd.Next(10, 99)
        Dim command As New SqlCommand("Insert into RADNIK (Ime,Prezime,Posao,Kvalif,Rukovodilac,Dat_zap,Plata,Id_odeljenja,Premija) Values ('" & txtAddime.Text & "', '" & txtAddprezime.Text & "','" & cmbPosao.Text & "','" & cmbKvalif.Text & "','" & cmbRuko.SelectedValue.ToString & "','" & DateTimePicker1.Value.ToString("MM-dd-yyyy") & "','" & txtAddplata.Text.Replace(",", ".") & "', '" & cmbOdelj.SelectedValue & "', '" & txtPremija.Text & "' )", connection)
        Dim cmdNalog As New SqlCommand("insert into nalog (id_radnika, username, password) values((select id_radnika from radnik where ime = '" & txtAddime.Text & "' and prezime= '" & txtAddprezime.Text & "'),'" & txtAddime.Text.ToLower & "'+'" & txtAddprezime.Text.ToLower & "'+'" & randomUser.ToString & "','" & txtAddime.Text.ToLower & "'+ '" & txtAddprezime.Text.Substring(0, 1).ToLower & "'+'" & randomPass.ToString & "')", connection)
        Dim cmdPrava As New SqlCommand("insert into Prava (id_radnika, nazivprava) values((select id_radnika from radnik where ime = '" & txtAddime.Text & "' and prezime= '" & txtAddprezime.Text & "'), '" & cmbPrava.Text & "')", connection)
        connection.Open()
        If (command.ExecuteScalar() = 0 And cmdNalog.ExecuteScalar = 0) Then
            MessageBox.Show("Uspesno dodavanje!")
            txtAddime.Clear()
            txtAddprezime.Clear()
            cmbPosao.Text = ""
            cmbKvalif.Text = ""
            cmbRuko.Text = ""
            txtAddplata.Clear()
            cmbOdelj.Text = ""
            txtPremija.Clear()

        Else
            MessageBox.Show("Greska u dodavanju!")
        End If


            Dim command1 As New SqlCommand("select id_radnika, ime, prezime, posao from radnik", connection)
            Dim adapter As New SqlDataAdapter(command1)
            Dim table As New DataTable()
            adapter.Fill(table)
            brisanje.DataGridView1.DataSource = table
            connection.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        prijava.Close()
        status.Close()
    End Sub

    Private Sub cmbKvalif_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKvalif.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbPosao_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPosao.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbOdelj_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOdelj.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbRuko_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRuko.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbPrava_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPrava.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAddime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAddprezime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddprezime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPremija_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPremija.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAddplata_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddplata.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class