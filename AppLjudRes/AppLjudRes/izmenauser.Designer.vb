<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class izmenauser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(izmenauser))
        Me.btnUserizmena = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIzmenauser = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnUserizmena
        '
        Me.btnUserizmena.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUserizmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserizmena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserizmena.Location = New System.Drawing.Point(207, 142)
        Me.btnUserizmena.Name = "btnUserizmena"
        Me.btnUserizmena.Size = New System.Drawing.Size(218, 42)
        Me.btnUserizmena.TabIndex = 0
        Me.btnUserizmena.Text = "POTVRDI"
        Me.btnUserizmena.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unesite novi username:"
        '
        'txtIzmenauser
        '
        Me.txtIzmenauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIzmenauser.Location = New System.Drawing.Point(340, 91)
        Me.txtIzmenauser.Name = "txtIzmenauser"
        Me.txtIzmenauser.Size = New System.Drawing.Size(225, 26)
        Me.txtIzmenauser.TabIndex = 2
        '
        'izmenauser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 294)
        Me.Controls.Add(Me.txtIzmenauser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUserizmena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "izmenauser"
        Me.Text = "izmenauser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUserizmena As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIzmenauser As System.Windows.Forms.TextBox
End Class
