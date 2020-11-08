<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class status
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(status))
        Me.dgvStatus = New System.Windows.Forms.DataGridView()
        Me.btnStatusback = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IzmenaLozinkeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzmenaKorisnickogImenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStatus
        '
        Me.dgvStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatus.Location = New System.Drawing.Point(12, 72)
        Me.dgvStatus.Name = "dgvStatus"
        Me.dgvStatus.Size = New System.Drawing.Size(681, 88)
        Me.dgvStatus.TabIndex = 0
        '
        'btnStatusback
        '
        Me.btnStatusback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatusback.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStatusback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatusback.Location = New System.Drawing.Point(505, 229)
        Me.btnStatusback.Name = "btnStatusback"
        Me.btnStatusback.Size = New System.Drawing.Size(213, 39)
        Me.btnStatusback.TabIndex = 1
        Me.btnStatusback.Text = "NAZAD"
        Me.btnStatusback.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzmenaLozinkeToolStripMenuItem, Me.IzmenaKorisnickogImenaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(219, 48)
        '
        'IzmenaLozinkeToolStripMenuItem
        '
        Me.IzmenaLozinkeToolStripMenuItem.Name = "IzmenaLozinkeToolStripMenuItem"
        Me.IzmenaLozinkeToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IzmenaLozinkeToolStripMenuItem.Text = "PROMENI LOZINKU"
        '
        'IzmenaKorisnickogImenaToolStripMenuItem
        '
        Me.IzmenaKorisnickogImenaToolStripMenuItem.Name = "IzmenaKorisnickogImenaToolStripMenuItem"
        Me.IzmenaKorisnickogImenaToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IzmenaKorisnickogImenaToolStripMenuItem.Text = "PROMENI KORISNIČKO IME"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-1, 267)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.MaximumSize = New System.Drawing.Size(73, 29)
        Me.Button3.MinimumSize = New System.Drawing.Size(73, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 29)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "IZLAZ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(701, 295)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnStatusback)
        Me.Controls.Add(Me.dgvStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "status"
        Me.Text = "status"
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStatus As System.Windows.Forms.DataGridView
    Friend WithEvents btnStatusback As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IzmenaLozinkeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IzmenaKorisnickogImenaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
