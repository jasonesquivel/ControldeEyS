<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rptdepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptdepartamentos))
        Me.dtdepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsregistro = New ControldeEyS.dsregistro()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroEyRpruebaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroEyRpruebaDataSet = New ControldeEyS.registroEyRpruebaDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ControldeEyS.registroEyRpruebaDataSetTableAdapters.EmpleadoTableAdapter()
        Me.DepartamentoTableAdapter = New ControldeEyS.registroEyRpruebaDataSetTableAdapters.DepartamentoTableAdapter()
        Me.DepartamentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dtdepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroEyRpruebaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroEyRpruebaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtdepartamentosBindingSource
        '
        Me.dtdepartamentosBindingSource.DataMember = "dtdepartamentos"
        Me.dtdepartamentosBindingSource.DataSource = Me.dsregistro
        '
        'dsregistro
        '
        Me.dsregistro.DataSetName = "dsregistro"
        Me.dsregistro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(619, 212)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 280)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(295, 521)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 48)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 384)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv.Location = New System.Drawing.Point(3, 18)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(472, 363)
        Me.dgv.TabIndex = 0
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.RegistroEyRpruebaDataSetBindingSource
        '
        'RegistroEyRpruebaDataSetBindingSource
        '
        Me.RegistroEyRpruebaDataSetBindingSource.DataSource = Me.RegistroEyRpruebaDataSet
        Me.RegistroEyRpruebaDataSetBindingSource.Position = 0
        '
        'RegistroEyRpruebaDataSet
        '
        Me.RegistroEyRpruebaDataSet.DataSetName = "registroEyRpruebaDataSet"
        Me.RegistroEyRpruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.RegistroEyRpruebaDataSetBindingSource
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoBindingSource1
        '
        Me.DepartamentoBindingSource1.DataMember = "Departamento"
        Me.DepartamentoBindingSource1.DataSource = Me.RegistroEyRpruebaDataSetBindingSource
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Location = New System.Drawing.Point(-163, 112)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 10)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-163, -4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 116)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(366, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(648, 157)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 34)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'rptdepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(778, 582)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "rptdepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar departamentos"
        CType(Me.dtdepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroEyRpruebaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroEyRpruebaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtdepartamentosBindingSource As BindingSource
    Friend WithEvents dsregistro As dsregistro
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents RegistroEyRpruebaDataSetBindingSource As BindingSource
    Friend WithEvents RegistroEyRpruebaDataSet As registroEyRpruebaDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As registroEyRpruebaDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As registroEyRpruebaDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents DepartamentoBindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
End Class
