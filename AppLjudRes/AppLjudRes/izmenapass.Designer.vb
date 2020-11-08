<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class izmenapass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(izmenapass))
        Me.btnIzmenapass = New System.Windows.Forms.Button()
        Me.txtIzmenipass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIzmenapass
        '
        Me.btnIzmenapass.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnIzmenapass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIzmenapass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzmenapass.Location = New System.Drawing.Point(207, 142)
        Me.btnIzmenapass.Name = "btnIzmenapass"
        Me.btnIzmenapass.Size = New System.Drawing.Size(218, 42)
        Me.btnIzmenapass.TabIndex = 0
        Me.btnIzmenapass.Text = "POTVRDI"
        Me.btnIzmenapass.UseVisualStyleBackColor = False
        '
        'txtIzmenipass
        '
        Me.txtIzmenipass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIzmenipass.Location = New System.Drawing.Point(340, 91)
        Me.txtIzmenipass.Name = "txtIzmenipass"
        Me.txtIzmenipass.Size = New System.Drawing.Size(225, 26)
        Me.txtIzmenipass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(77, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Unesite novi password:"
        '
        'izmenapass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIzmenipass)
        Me.Controls.Add(Me.btnIzmenapass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "izmenapass"
        Me.Text = "izmenapass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIzmenapass As System.Windows.Forms.Button
    Friend WithEvents txtIzmenipass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
