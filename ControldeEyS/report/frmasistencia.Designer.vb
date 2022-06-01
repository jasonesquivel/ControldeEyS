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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvRegistros)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 188)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(552, 304)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'dgvRegistros
        '
        Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvRegistros.Location = New System.Drawing.Point(2, 15)
        Me.dgvRegistros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.RowHeadersWidth = 51
        Me.dgvRegistros.RowTemplate.Height = 24
        Me.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistros.Size = New System.Drawing.Size(548, 287)
        Me.dgvRegistros.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Location = New System.Drawing.Point(0, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 10)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, -5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 94)
        Me.Panel2.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(293, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(714, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(714, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Marcar entrada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(714, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Marcar salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidregistro
        '
        Me.txtidregistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtidregistro.Location = New System.Drawing.Point(166, 507)
        Me.txtidregistro.Name = "txtidregistro"
        Me.txtidregistro.Size = New System.Drawing.Size(156, 20)
        Me.txtidregistro.TabIndex = 6
        '
        'txtidemp
        '
        Me.txtidemp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtidemp.Location = New System.Drawing.Point(12, 507)
        Me.txtidemp.Name = "txtidemp"
        Me.txtidemp.Size = New System.Drawing.Size(148, 20)
        Me.txtidemp.TabIndex = 5
        '
        'txtmarcaentrada
        '
        Me.txtmarcaentrada.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtmarcaentrada.Location = New System.Drawing.Point(447, 507)
        Me.txtmarcaentrada.Name = "txtmarcaentrada"
        Me.txtmarcaentrada.Size = New System.Drawing.Size(182, 20)
        Me.txtmarcaentrada.TabIndex = 7
        '
        'txtmarcasalida
        '
        Me.txtmarcasalida.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtmarcasalida.Location = New System.Drawing.Point(635, 507)
        Me.txtmarcasalida.Name = "txtmarcasalida"
        Me.txtmarcasalida.Size = New System.Drawing.Size(190, 20)
        Me.txtmarcasalida.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(635, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 27)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Txtdato
        '
        Me.Txtdato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtdato.Location = New System.Drawing.Point(166, 139)
        Me.Txtdato.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtdato.Name = "Txtdato"
        Me.Txtdato.Size = New System.Drawing.Size(420, 20)
        Me.Txtdato.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Ingrese su ID"
        '
        'frmasistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtdato)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtmarcasalida)
        Me.Controls.Add(Me.txtmarcaentrada)
        Me.Controls.Add(Me.txtidemp)
        Me.Controls.Add(Me.txtidregistro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmasistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
