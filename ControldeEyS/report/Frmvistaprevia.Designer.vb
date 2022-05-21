<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmvistaprevia
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmvistaprevia))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtempleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsregistro = New ControldeEyS.dsregistro()
        CType(Me.dtempleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(689, 521)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 519)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Dsempleado"
        ReportDataSource1.Value = Me.dtempleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControldeEyS.rptEmpleado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 16)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1069, 496)
        Me.ReportViewer1.TabIndex = 5
        '
        'dtempleadosBindingSource
        '
        Me.dtempleadosBindingSource.DataMember = "dtempleados"
        Me.dtempleadosBindingSource.DataSource = Me.dsregistro
        '
        'dsregistro
        '
        Me.dsregistro.DataSetName = "dsregistro"
        Me.dsregistro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Frmvistaprevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1067, 582)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frmvistaprevia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Empleados"
        CType(Me.dtempleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsregistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtempleadosBindingSource As BindingSource
    Friend WithEvents dsregistro As dsregistro
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
