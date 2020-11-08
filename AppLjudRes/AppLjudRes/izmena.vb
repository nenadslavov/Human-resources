Imports System.Data.SqlClient
Public Class izmena

    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub izmena_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connection.Open()
        Dim command As New SqlCommand("select * from radnik", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
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

    Private Sub btnUnazad_Click(sender As System.Object, e As System.EventArgs) Handles btnUnazad.Click
        Me.Visible = False
        opcije.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtUime.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
        txtUprezime.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString()
        cmbUposao.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value.ToString()
        cmbUkvalif.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value.ToString()
        cmbUruko.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value.ToString()
        txtUpremija.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value.ToString()
        txtUplata.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value.ToString()
        cmbUodelj.SelectedValue = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value.ToString()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        opcije.Close()
        prijava.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim command As New SqlCommand("UPDATE RADNIK SET ime='" & txtUime.Text & "',prezime='" & txtUprezime.Text & "',posao='" & cmbUposao.Text & "',kvalif='" & cmbUkvalif.Text & "',rukovodilac='" & cmbUruko.Text & "',premija='" & txtUpremija.Text & "',plata='" & txtUplata.Text & "',id_odeljenja='" & cmbUodelj.SelectedValue & "' Where id_radnika= '" & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value & "'", connection)
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Izmena podataka je uspesno obavljena!")
        Else
            MessageBox.Show("Greska prilikom izmene podataka!")
        End If

        Dim command1 As New SqlCommand("select * from radnik", connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub

    Private Sub txtUplata_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUplata.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUpremija_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUpremija.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "1234567890.,"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUprezime_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUprezime.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = "qwertzuiopšđžasdfghjklčćyxcvbnm-"
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

    Private Sub cmbUposao_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUposao.KeyPress
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

    Private Sub cmbUruko_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUruko.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim tast As String = ""
            If Not tast.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class