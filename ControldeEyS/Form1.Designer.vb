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
        Me.DsregistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarAArchivoLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EniviarPorCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearRespaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldoLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldoEnBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCaegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeHorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DsregistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip6.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
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
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip6)
        Me.Panel1.Controls.Add(Me.MenuStrip4)
        Me.Panel1.Controls.Add(Me.MenuStrip3)
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 519)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 407)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
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
        Me.MenuStrip6.Location = New System.Drawing.Point(0, 112)
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
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 84)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip4.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip4.TabIndex = 3
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(116, 24)
        Me.ToolStripMenuItem4.Text = "Administrador"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(136, 24)
        Me.ToolStripMenuItem7.Text = "Corregir "
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(315, 24)
        Me.ToolStripMenuItem8.Text = "Hora de entrada trabajador"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(315, 24)
        Me.ToolStripMenuItem9.Text = "Hora de salida trabajador"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(315, 24)
        Me.ToolStripMenuItem10.Text = "Hora de entrada y salida trabajador"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 56)
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
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(151, 28)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarArchivosToolStripMenuItem, Me.CrearRespaldoToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(77, 24)
        Me.ToolStripMenuItem2.Text = "Archivos"
        '
        'ExportarArchivosToolStripMenuItem
        '
        Me.ExportarArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAArchivoLocalToolStripMenuItem, Me.EniviarPorCorreoToolStripMenuItem})
        Me.ExportarArchivosToolStripMenuItem.Name = "ExportarArchivosToolStripMenuItem"
        Me.ExportarArchivosToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.ExportarArchivosToolStripMenuItem.Text = "Exportar archivo"
        '
        'ExportarAArchivoLocalToolStripMenuItem
        '
        Me.ExportarAArchivoLocalToolStripMenuItem.Name = "ExportarAArchivoLocalToolStripMenuItem"
        Me.ExportarAArchivoLocalToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ExportarAArchivoLocalToolStripMenuItem.Text = "Exportar a archivo local"
        '
        'EniviarPorCorreoToolStripMenuItem
        '
        Me.EniviarPorCorreoToolStripMenuItem.Name = "EniviarPorCorreoToolStripMenuItem"
        Me.EniviarPorCorreoToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.EniviarPorCorreoToolStripMenuItem.Text = "eniviar por Correo"
        '
        'CrearRespaldoToolStripMenuItem
        '
        Me.CrearRespaldoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RespaldoLocalToolStripMenuItem, Me.RespaldoEnBaseDeDatosToolStripMenuItem})
        Me.CrearRespaldoToolStripMenuItem.Name = "CrearRespaldoToolStripMenuItem"
        Me.CrearRespaldoToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.CrearRespaldoToolStripMenuItem.Text = "Crear respaldo"
        '
        'RespaldoLocalToolStripMenuItem
        '
        Me.RespaldoLocalToolStripMenuItem.Name = "RespaldoLocalToolStripMenuItem"
        Me.RespaldoLocalToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.RespaldoLocalToolStripMenuItem.Text = "Respaldo local"
        '
        'RespaldoEnBaseDeDatosToolStripMenuItem
        '
        Me.RespaldoEnBaseDeDatosToolStripMenuItem.Name = "RespaldoEnBaseDeDatosToolStripMenuItem"
        Me.RespaldoEnBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.RespaldoEnBaseDeDatosToolStripMenuItem.Text = "Respaldo en base de datos"
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
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeDepartamentosToolStripMenuItem, Me.ReporteDeCaegoToolStripMenuItem, Me.ReporteDeAsistenciaToolStripMenuItem, Me.ReporteDeHorariosToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 24)
        Me.ToolStripMenuItem1.Text = "Reportes"
        '
        'ReporteDeDepartamentosToolStripMenuItem
        '
        Me.ReporteDeDepartamentosToolStripMenuItem.Name = "ReporteDeDepartamentosToolStripMenuItem"
        Me.ReporteDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.ReporteDeDepartamentosToolStripMenuItem.Text = "Reporte de departamentos"
        '
        'ReporteDeCaegoToolStripMenuItem
        '
        Me.ReporteDeCaegoToolStripMenuItem.Name = "ReporteDeCaegoToolStripMenuItem"
        Me.ReporteDeCaegoToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.ReporteDeCaegoToolStripMenuItem.Text = "Reporte de cargos"
        '
        'ReporteDeAsistenciaToolStripMenuItem
        '
        Me.ReporteDeAsistenciaToolStripMenuItem.Name = "ReporteDeAsistenciaToolStripMenuItem"
        Me.ReporteDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.ReporteDeAsistenciaToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'ReporteDeHorariosToolStripMenuItem
        '
        Me.ReporteDeHorariosToolStripMenuItem.Name = "ReporteDeHorariosToolStripMenuItem"
        Me.ReporteDeHorariosToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.ReporteDeHorariosToolStripMenuItem.Text = "Reporte de Horarios"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Magenta
        Me.Panel2.Location = New System.Drawing.Point(146, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 519)
        Me.Panel2.TabIndex = 6
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(157, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(948, 491)
        Me.ReportViewer1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1104, 517)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sistemadecontrolEyS"
        CType(Me.DsregistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarAArchivoLocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EniviarPorCorreoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearRespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoLocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoEnBaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCaegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DsregistroBindingSource As BindingSource

    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents HorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteDeHorariosToolStripMenuItem As ToolStripMenuItem
End Class
