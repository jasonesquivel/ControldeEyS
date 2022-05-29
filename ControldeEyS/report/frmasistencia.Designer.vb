<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmasistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmasistencia))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistros = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtidregistro = New System.Windows.Forms.TextBox()
        Me.txtidemp = New System.Windows.Forms.TextBox()
        Me.txtmarcaentrada = New System.Windows.Forms.TextBox()
        Me.txtmarcasalida = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Txtdato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(437, 612)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 48)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Imprimir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRegistros)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(868, 374)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'dgvRegistros
        '
        Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvRegistros.Location = New System.Drawing.Point(3, 17)
        Me.dgvRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.RowHeadersWidth = 51
        Me.dgvRegistros.RowTemplate.Height = 24
        Me.dgvRegistros.Size = New System.Drawing.Size(862, 355)
        Me.dgvRegistros.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Location = New System.Drawing.Point(0, 107)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 12)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, -6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1244, 116)
        Me.Panel2.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(977, 256)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 33)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(953, 319)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Marcar entrada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(953, 394)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 47)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Marcar salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidregistro
        '
        Me.txtidregistro.Location = New System.Drawing.Point(221, 624)
        Me.txtidregistro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidregistro.Name = "txtidregistro"
        Me.txtidregistro.Size = New System.Drawing.Size(207, 22)
        Me.txtidregistro.TabIndex = 6
        '
        'txtidemp
        '
        Me.txtidemp.Location = New System.Drawing.Point(16, 624)
        Me.txtidemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidemp.Name = "txtidemp"
        Me.txtidemp.Size = New System.Drawing.Size(196, 22)
        Me.txtidemp.TabIndex = 5
        '
        'txtmarcaentrada
        '
        Me.txtmarcaentrada.Location = New System.Drawing.Point(596, 624)
        Me.txtmarcaentrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmarcaentrada.Name = "txtmarcaentrada"
        Me.txtmarcaentrada.Size = New System.Drawing.Size(241, 22)
        Me.txtmarcaentrada.TabIndex = 7
        '
        'txtmarcasalida
        '
        Me.txtmarcasalida.Location = New System.Drawing.Point(847, 624)
        Me.txtmarcasalida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmarcasalida.Name = "txtmarcasalida"
        Me.txtmarcasalida.Size = New System.Drawing.Size(252, 22)
        Me.txtmarcasalida.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(847, 166)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 33)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Txtdato
        '
        Me.Txtdato.Location = New System.Drawing.Point(221, 171)
        Me.Txtdato.Name = "Txtdato"
        Me.Txtdato.Size = New System.Drawing.Size(559, 22)
        Me.Txtdato.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Ingrese su ID"
        '
        'frmasistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 687)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtdato)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtmarcasalida)
        Me.Controls.Add(Me.txtmarcaentrada)
        Me.Controls.Add(Me.txtidemp)
        Me.Controls.Add(Me.txtidregistro)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmasistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmasistencia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRegistros As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtidregistro As TextBox
    Friend WithEvents txtidemp As TextBox
    Friend WithEvents txtmarcaentrada As TextBox
    Friend WithEvents txtmarcasalida As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Txtdato As TextBox
    Friend WithEvents Label1 As Label
End Class
