﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteMarcaProducto
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
        Me.spVisualizarListaMarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaVentaRopaTrujilloDataSet = New CapaPresentacion.SistemaVentaRopaTrujilloDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spVisualizarListaMarcasTableAdapter = New CapaPresentacion.SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaMarcasTableAdapter()
        CType(Me.spVisualizarListaMarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spVisualizarListaMarcasBindingSource
        '
        Me.spVisualizarListaMarcasBindingSource.DataMember = "spVisualizarListaMarcas"
        Me.spVisualizarListaMarcasBindingSource.DataSource = Me.SistemaVentaRopaTrujilloDataSet
        '
        'SistemaVentaRopaTrujilloDataSet
        '
        Me.SistemaVentaRopaTrujilloDataSet.DataSetName = "SistemaVentaRopaTrujilloDataSet"
        Me.SistemaVentaRopaTrujilloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.spVisualizarListaMarcasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteMarcaProducto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(565, 417)
        Me.ReportViewer1.TabIndex = 0
        '
        'spVisualizarListaMarcasTableAdapter
        '
        Me.spVisualizarListaMarcasTableAdapter.ClearBeforeFill = True
        '
        'FormReporteMarcaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 477)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReporteMarcaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..... :: FORMULARIO DE REPORTE DE MARCAS DE PRODUCTOS :: ........"
        CType(Me.spVisualizarListaMarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spVisualizarListaMarcasBindingSource As BindingSource
    Friend WithEvents SistemaVentaRopaTrujilloDataSet As SistemaVentaRopaTrujilloDataSet
    Friend WithEvents spVisualizarListaMarcasTableAdapter As SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaMarcasTableAdapter
End Class
