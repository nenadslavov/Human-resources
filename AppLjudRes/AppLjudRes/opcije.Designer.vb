<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcije
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(opcije))
        Me.btnPregled = New System.Windows.Forms.Button()
        Me.btnDodavanje = New System.Windows.Forms.Button()
        Me.btnBrisanje = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnOpcijeBack = New System.Windows.Forms.Button()
        Me.btnIzmena = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPregled
        '
        Me.btnPregled.BackColor = System.Drawing.Color.Transparent
        Me.btnPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPregled.Location = New System.Drawing.Point(-5, 48)
        Me.btnPregled.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPregled.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnPregled.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnPregled.Name = "btnPregled"
        Me.btnPregled.Size = New System.Drawing.Size(183, 33)
        Me.btnPregled.TabIndex = 0
        Me.btnPregled.Text = "PREGLED"
        Me.btnPregled.UseVisualStyleBackColor = False
        '
        'btnDodavanje
        '
        Me.btnDodavanje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDodavanje.BackColor = System.Drawing.Color.Transparent
        Me.btnDodavanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDodavanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDodavanje.Location = New System.Drawing.Point(613, 11)
        Me.btnDodavanje.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDodavanje.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnDodavanje.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnDodavanje.Name = "btnDodavanje"
        Me.btnDodavanje.Size = New System.Drawing.Size(183, 33)
        Me.btnDodavanje.TabIndex = 1
        Me.btnDodavanje.Text = "DODAVANJE"
        Me.btnDodavanje.UseVisualStyleBackColor = False
        '
        'btnBrisanje
        '
        Me.btnBrisanje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrisanje.BackColor = System.Drawing.Color.Transparent
        Me.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrisanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrisanje.Location = New System.Drawing.Point(-5, 390)
        Me.btnBrisanje.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrisanje.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnBrisanje.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnBrisanje.Name = "btnBrisanje"
        Me.btnBrisanje.Size = New System.Drawing.Size(183, 33)
        Me.btnBrisanje.TabIndex = 2
        Me.btnBrisanje.Text = "BRISANJE"
        Me.btnBrisanje.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(8, 53)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(0, 13)
        Me.lblWelcome.TabIndex = 3
        '
        'btnStatus
        '
        Me.btnStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.Location = New System.Drawing.Point(-5, 11)
        Me.btnStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStatus.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnStatus.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(183, 33)
        Me.btnStatus.TabIndex = 4
        Me.btnStatus.Text = "STATUS"
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'btnOpcijeBack
        '
        Me.btnOpcijeBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpcijeBack.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnOpcijeBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpcijeBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcijeBack.ForeColor = System.Drawing.Color.MintCream
        Me.btnOpcijeBack.Location = New System.Drawing.Point(613, 390)
        Me.btnOpcijeBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpcijeBack.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnOpcijeBack.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnOpcijeBack.Name = "btnOpcijeBack"
        Me.btnOpcijeBack.Size = New System.Drawing.Size(183, 33)
        Me.btnOpcijeBack.TabIndex = 5
        Me.btnOpcijeBack.Text = "NAZAD"
        Me.btnOpcijeBack.UseVisualStyleBackColor = False
        '
        'btnIzmena
        '
        Me.btnIzmena.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIzmena.BackColor = System.Drawing.Color.Transparent
        Me.btnIzmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIzmena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzmena.Location = New System.Drawing.Point(613, 48)
        Me.btnIzmena.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIzmena.MaximumSize = New System.Drawing.Size(183, 33)
        Me.btnIzmena.MinimumSize = New System.Drawing.Size(183, 33)
        Me.btnIzmena.Name = "btnIzmena"
        Me.btnIzmena.Size = New System.Drawing.Size(183, 33)
        Me.btnIzmena.TabIndex = 6
        Me.btnIzmena.Text = "IZMENA"
        Me.btnIzmena.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(322, 412)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.MaximumSize = New System.Drawing.Size(155, 26)
        Me.Button1.MinimumSize = New System.Drawing.Size(155, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "IZLAZ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'opcije
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOpcijeBack)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnIzmena)
        Me.Controls.Add(Me.btnBrisanje)
        Me.Controls.Add(Me.btnDodavanje)
        Me.Controls.Add(Me.btnPregled)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "opcije"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPregled As System.Windows.Forms.Button
    Friend WithEvents btnDodavanje As System.Windows.Forms.Button
    Friend WithEvents btnBrisanje As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnOpcijeBack As System.Windows.Forms.Button
    Friend WithEvents btnIzmena As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
