<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteComprobanteVenta
    'Inherits System.Windows.Forms.Form
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.txtReporteCodigo = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SistemaVentaRopaTrujilloDataSet = New CapaPresentacion.SistemaVentaRopaTrujilloDataSet()
        Me.spGenerarComprobanteVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spGenerarComprobanteVentaTableAdapter = New CapaPresentacion.SistemaVentaRopaTrujilloDataSetTableAdapters.spGenerarComprobanteVentaTableAdapter()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spGenerarComprobanteVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReporteCodigo
        '
        Me.txtReporteCodigo.Location = New System.Drawing.Point(223, 126)
        Me.txtReporteCodigo.Name = "txtReporteCodigo"
        Me.txtReporteCodigo.Size = New System.Drawing.Size(88, 20)
        Me.txtReporteCodigo.TabIndex = 1
        Me.txtReporteCodigo.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.spGenerarComprobanteVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteComprobanteVente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 429)
        Me.ReportViewer1.TabIndex = 2
        '
        'SistemaVentaRopaTrujilloDataSet
        '
        Me.SistemaVentaRopaTrujilloDataSet.DataSetName = "SistemaVentaRopaTrujilloDataSet"
        Me.SistemaVentaRopaTrujilloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spGenerarComprobanteVentaBindingSource
        '
        Me.spGenerarComprobanteVentaBindingSource.DataMember = "spGenerarComprobanteVenta"
        Me.spGenerarComprobanteVentaBindingSource.DataSource = Me.SistemaVentaRopaTrujilloDataSet
        '
        'spGenerarComprobanteVentaTableAdapter
        '
        Me.spGenerarComprobanteVentaTableAdapter.ClearBeforeFill = True
        '
        'FormReporteComprobanteVenta
        '
        Me.AccessibleName = ""
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(786, 488)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtReporteCodigo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReporteComprobanteVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                              ........................... :: FORMULARIO DE REPORT" &
    "E DE VENTA :: ............................"
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spGenerarComprobanteVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReporteCodigo As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spGenerarComprobanteVentaBindingSource As BindingSource
    Friend WithEvents SistemaVentaRopaTrujilloDataSet As SistemaVentaRopaTrujilloDataSet
    Friend WithEvents spGenerarComprobanteVentaTableAdapter As SistemaVentaRopaTrujilloDataSetTableAdapters.spGenerarComprobanteVentaTableAdapter
End Class
