<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuariosAdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCaegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeHorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeEntradaYSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DsregistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerRegistroDeCuentasCreadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip6.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsregistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENIDO AL SISTEMA DE CONTROL DE ASISTENCIA"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip6)
        Me.Panel1.Controls.Add(Me.MenuStrip4)
        Me.Panel1.Controls.Add(Me.MenuStrip3)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 530)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 425)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip6
        '
        Me.MenuStrip6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip6.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.MenuStrip6.Location = New System.Drawing.Point(0, 84)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip6.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip6.TabIndex = 5
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(106, 24)
        Me.ToolStripMenuItem6.Text = "Cerrar sesion"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 56)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip4.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip4.TabIndex = 3
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.CrearUsuariosAdministradorToolStripMenuItem, Me.VerRegistroDeCuentasCreadasToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(116, 24)
        Me.ToolStripMenuItem4.Text = "Administrador"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(286, 24)
        Me.ToolStripMenuItem7.Text = "Corregir Marca"
        '
        'CrearUsuariosAdministradorToolStripMenuItem
        '
        Me.CrearUsuariosAdministradorToolStripMenuItem.Name = "CrearUsuariosAdministradorToolStripMenuItem"
        Me.CrearUsuariosAdministradorToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.CrearUsuariosAdministradorToolStripMenuItem.Text = "Crear Usuarios Administrador"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip3.TabIndex = 2
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarEmpleadoToolStripMenuItem, Me.EditarCargoToolStripMenuItem, Me.EditarDepartamentoToolStripMenuItem, Me.HorarioToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(127, 24)
        Me.ToolStripMenuItem3.Text = "Editar y agregar"
        '
        'EditarEmpleadoToolStripMenuItem
        '
        Me.EditarEmpleadoToolStripMenuItem.Name = "EditarEmpleadoToolStripMenuItem"
        Me.EditarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.EditarEmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'EditarCargoToolStripMenuItem
        '
        Me.EditarCargoToolStripMenuItem.Name = "EditarCargoToolStripMenuItem"
        Me.EditarCargoToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.EditarCargoToolStripMenuItem.Text = "Cargo"
        '
        'EditarDepartamentoToolStripMenuItem
        '
        Me.EditarDepartamentoToolStripMenuItem.Name = "EditarDepartamentoToolStripMenuItem"
        Me.EditarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.EditarDepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'HorarioToolStripMenuItem
        '
        Me.HorarioToolStripMenuItem.Name = "HorarioToolStripMenuItem"
        Me.HorarioToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.HorarioToolStripMenuItem.Text = "Horario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeDepartamentosToolStripMenuItem, Me.ReporteDeCaegoToolStripMenuItem, Me.ReporteDeAsistenciaToolStripMenuItem, Me.ReporteDeHorariosToolStripMenuItem, Me.ReportesDeEntradaYSalidaToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 24)
        Me.ToolStripMenuItem1.Text = "Reportes"
        '
        'ReporteDeDepartamentosToolStripMenuItem
        '
        Me.ReporteDeDepartamentosToolStripMenuItem.Name = "ReporteDeDepartamentosToolStripMenuItem"
        Me.ReporteDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(269, 24)
        Me.ReporteDeDepartamentosToolStripMenuItem.Text = "Reporte de departamentos"
        '
        'ReporteDeCaegoToolStripMenuItem
        '
        Me.ReporteDeCaegoToolStripMenuItem.Name = "ReporteDeCaegoToolStripMenuItem"
        Me.ReporteDeCaegoToolStripMenuItem.Size = New System.Drawing.Size(269, 24)
        Me.ReporteDeCaegoToolStripMenuItem.Text = "Reporte de cargos"
        '
        'ReporteDeAsistenciaToolStripMenuItem
        '
        Me.ReporteDeAsistenciaToolStripMenuItem.Name = "ReporteDeAsistenciaToolStripMenuItem"
        Me.ReporteDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(269, 24)
        Me.ReporteDeAsistenciaToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'ReporteDeHorariosToolStripMenuItem
        '
        Me.ReporteDeHorariosToolStripMenuItem.Name = "ReporteDeHorariosToolStripMenuItem"
        Me.ReporteDeHorariosToolStripMenuItem.Size = New System.Drawing.Size(269, 24)
        Me.ReporteDeHorariosToolStripMenuItem.Text = "Reporte de Horarios"
        '
        'ReportesDeEntradaYSalidaToolStripMenuItem
        '
        Me.ReportesDeEntradaYSalidaToolStripMenuItem.Name = "ReportesDeEntradaYSalidaToolStripMenuItem"
        Me.ReportesDeEntradaYSalidaToolStripMenuItem.Size = New System.Drawing.Size(269, 24)
        Me.ReportesDeEntradaYSalidaToolStripMenuItem.Text = "Reportes de Entrada y Salida"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Magenta
        Me.Panel2.Location = New System.Drawing.Point(146, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 527)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(172, 41)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(753, 458)
        Me.Panel3.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(753, 458)
        Me.DataGridView1.TabIndex = 0
        '
        'VerRegistroDeCuentasCreadasToolStripMenuItem
        '
        Me.VerRegistroDeCuentasCreadasToolStripMenuItem.Name = "VerRegistroDeCuentasCreadasToolStripMenuItem"
        Me.VerRegistroDeCuentasCreadasToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.VerRegistroDeCuentasCreadasToolStripMenuItem.Text = "Ver registro de Cuentas creadas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sistemadecontrolEyS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsregistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents EditarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCaegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DsregistroBindingSource As BindingSource

    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents HorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeHorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReportesDeEntradaYSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuariosAdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerRegistroDeCuentasCreadasToolStripMenuItem As ToolStripMenuItem
End Class
