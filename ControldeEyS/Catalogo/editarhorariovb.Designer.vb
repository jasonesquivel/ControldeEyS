<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarhorariovb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editarhorariovb))
        Me.txtshoradealidaedit = New System.Windows.Forms.MaskedTextBox()
        Me.txthoradeentradaedit = New System.Windows.Forms.MaskedTextBox()
        Me.Txtidhorario = New System.Windows.Forms.TextBox()
        Me.txtentrada = New System.Windows.Forms.TextBox()
        Me.Txtsalida = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Texdescripcionedit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtshoradealidaedit
        '
        Me.txtshoradealidaedit.Location = New System.Drawing.Point(789, 265)
        Me.txtshoradealidaedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtshoradealidaedit.Mask = "00:00:00"
        Me.txtshoradealidaedit.Name = "txtshoradealidaedit"
        Me.txtshoradealidaedit.Size = New System.Drawing.Size(132, 22)
        Me.txtshoradealidaedit.TabIndex = 4
        '
        'txthoradeentradaedit
        '
        Me.txthoradeentradaedit.Location = New System.Drawing.Point(789, 213)
        Me.txthoradeentradaedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txthoradeentradaedit.Mask = "00:00:00"
        Me.txthoradeentradaedit.Name = "txthoradeentradaedit"
        Me.txthoradeentradaedit.Size = New System.Drawing.Size(132, 22)
        Me.txthoradeentradaedit.TabIndex = 3
        '
        'Txtidhorario
        '
        Me.Txtidhorario.Location = New System.Drawing.Point(476, 124)
        Me.Txtidhorario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtidhorario.Name = "Txtidhorario"
        Me.Txtidhorario.Size = New System.Drawing.Size(260, 22)
        Me.Txtidhorario.TabIndex = 1
        Me.Txtidhorario.Visible = False
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(255, 208)
        Me.txtentrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.ReadOnly = True
        Me.txtentrada.Size = New System.Drawing.Size(260, 22)
        Me.txtentrada.TabIndex = 9
        '
        'Txtsalida
        '
        Me.Txtsalida.Location = New System.Drawing.Point(255, 265)
        Me.Txtsalida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtsalida.Name = "Txtsalida"
        Me.Txtsalida.ReadOnly = True
        Me.Txtsalida.Size = New System.Drawing.Size(260, 22)
        Me.Txtsalida.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(652, 268)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Hora de salida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(652, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Hora de entrada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 268)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Hora de salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 217)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Hora de entrada"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(863, 545)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'Texdescripcionedit
        '
        Me.Texdescripcionedit.Location = New System.Drawing.Point(789, 326)
        Me.Texdescripcionedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Texdescripcionedit.Multiline = True
        Me.Texdescripcionedit.Name = "Texdescripcionedit"
        Me.Texdescripcionedit.Size = New System.Drawing.Size(260, 173)
        Me.Texdescripcionedit.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 326)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Descripcion"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1036, 545)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(690, 545)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(255, 326)
        Me.Txtdescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtdescripcion.Multiline = True
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(260, 169)
        Me.Txtdescripcion.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 326)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "ID "
        Me.Label1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 16)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Datos originales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(841, 174)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Datos editados"
        '
        'editarhorariovb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1160, 604)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtshoradealidaedit)
        Me.Controls.Add(Me.txthoradeentradaedit)
        Me.Controls.Add(Me.Txtidhorario)
        Me.Controls.Add(Me.txtentrada)
        Me.Controls.Add(Me.Txtsalida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Texdescripcionedit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "editarhorariovb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar horario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtshoradealidaedit As MaskedTextBox
    Friend WithEvents txthoradeentradaedit As MaskedTextBox
    Friend WithEvents Txtidhorario As TextBox
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents Txtsalida As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Texdescripcionedit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtdescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
