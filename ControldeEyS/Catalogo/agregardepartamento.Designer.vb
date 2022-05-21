<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregardepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregardepartamento))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtiddepagregar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombredepagregar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Texdescripcionagregar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'txtiddepagregar
        '
        Me.txtiddepagregar.Location = New System.Drawing.Point(180, 137)
        Me.txtiddepagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtiddepagregar.Name = "txtiddepagregar"
        Me.txtiddepagregar.Size = New System.Drawing.Size(260, 22)
        Me.txtiddepagregar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "ID "
        '
        'txtnombredepagregar
        '
        Me.txtnombredepagregar.Location = New System.Drawing.Point(180, 182)
        Me.txtnombredepagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombredepagregar.Name = "txtnombredepagregar"
        Me.txtnombredepagregar.Size = New System.Drawing.Size(260, 22)
        Me.txtnombredepagregar.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 191)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Nombre"
        '
        'Texdescripcionagregar
        '
        Me.Texdescripcionagregar.Location = New System.Drawing.Point(180, 239)
        Me.Texdescripcionagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.Texdescripcionagregar.Multiline = True
        Me.Texdescripcionagregar.Name = "Texdescripcionagregar"
        Me.Texdescripcionagregar.Size = New System.Drawing.Size(260, 173)
        Me.Texdescripcionagregar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 235)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Descripcion"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(249, 524)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 524)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'agregardepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(500, 571)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtiddepagregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombredepagregar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Texdescripcionagregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "agregardepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Departamento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtiddepagregar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombredepagregar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Texdescripcionagregar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
