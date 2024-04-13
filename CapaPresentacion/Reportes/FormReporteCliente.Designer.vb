<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCliente
    ' Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spVisualizarListaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaVentaRopaTrujilloDataSet = New CapaPresentacion.SistemaVentaRopaTrujilloDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spVisualizarListaClienteTableAdapter = New CapaPresentacion.SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaClienteTableAdapter()
        CType(Me.spVisualizarListaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spVisualizarListaClienteBindingSource
        '
        Me.spVisualizarListaClienteBindingSource.DataMember = "spVisualizarListaCliente"
        Me.spVisualizarListaClienteBindingSource.DataSource = Me.SistemaVentaRopaTrujilloDataSet
        '
        'SistemaVentaRopaTrujilloDataSet
        '
        Me.SistemaVentaRopaTrujilloDataSet.DataSetName = "SistemaVentaRopaTrujilloDataSet"
        Me.SistemaVentaRopaTrujilloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.spVisualizarListaClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(823, 414)
        Me.ReportViewer1.TabIndex = 0
        '
        'spVisualizarListaClienteTableAdapter
        '
        Me.spVisualizarListaClienteTableAdapter.ClearBeforeFill = True
        '
        'FormReporteCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 480)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReporteCliente"
        Me.Text = "                                       .................... :: FORMULARIO DE REPO" &
    "RTE DE CLIENTE :: .........................."
        CType(Me.spVisualizarListaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spVisualizarListaClienteBindingSource As BindingSource
    Friend WithEvents SistemaVentaRopaTrujilloDataSet As SistemaVentaRopaTrujilloDataSet
    Friend WithEvents spVisualizarListaClienteTableAdapter As SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaClienteTableAdapter
End Class
