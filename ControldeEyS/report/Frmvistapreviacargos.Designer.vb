<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmvistapreviacargos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmvistapreviacargos))
        Me.dtcargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsregistro = New ControldeEyS.dsregistro()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtempleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dtcargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtempleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtcargoBindingSource
        '
        Me.dtcargoBindingSource.DataMember = "dtcargo"
        Me.dtcargoBindingSource.DataSource = Me.dsregistro
        '
        'dsregistro
        '
        Me.dsregistro.DataSetName = "dsregistro"
        Me.dsregistro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(589, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtempleadosBindingSource
        '
        Me.dtempleadosBindingSource.DataMember = "dtempleados"
        Me.dtempleadosBindingSource.DataSource = Me.dsregistro
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Location = New System.Drawing.Point(-6, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 8)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-6, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 94)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(555, 304)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv.Location = New System.Drawing.Point(2, 15)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(551, 287)
        Me.dgv.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(225, 423)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 38)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(613, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 35)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Frmvistapreviacargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(714, 473)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmvistapreviacargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar cargos"
        CType(Me.dtcargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtempleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtempleadosBindingSource As BindingSource
    Friend WithEvents dsregistro As dsregistro
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dtcargoBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
