﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteTrabajador
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
        Me.spVisualizarListaTrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaVentaRopaTrujilloDataSet = New CapaPresentacion.SistemaVentaRopaTrujilloDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spVisualizarListaTrabajadoresTableAdapter = New CapaPresentacion.SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaTrabajadoresTableAdapter()
        CType(Me.spVisualizarListaTrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spVisualizarListaTrabajadoresBindingSource
        '
        Me.spVisualizarListaTrabajadoresBindingSource.DataMember = "spVisualizarListaTrabajadores"
        Me.spVisualizarListaTrabajadoresBindingSource.DataSource = Me.SistemaVentaRopaTrujilloDataSet
        '
        'SistemaVentaRopaTrujilloDataSet
        '
        Me.SistemaVentaRopaTrujilloDataSet.DataSetName = "SistemaVentaRopaTrujilloDataSet"
        Me.SistemaVentaRopaTrujilloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.spVisualizarListaTrabajadoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteTrabajador.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(838, 381)
        Me.ReportViewer1.TabIndex = 0
        '
        'spVisualizarListaTrabajadoresTableAdapter
        '
        Me.spVisualizarListaTrabajadoresTableAdapter.ClearBeforeFill = True
        '
        'FormReporteTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 442)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReporteTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                         ............................. :: FORMULARIO DE REPORTE D" &
    "E TRABAJADORES :: ........................"
        CType(Me.spVisualizarListaTrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaVentaRopaTrujilloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spVisualizarListaTrabajadoresBindingSource As BindingSource
    Friend WithEvents SistemaVentaRopaTrujilloDataSet As SistemaVentaRopaTrujilloDataSet
    Friend WithEvents spVisualizarListaTrabajadoresTableAdapter As SistemaVentaRopaTrujilloDataSetTableAdapters.spVisualizarListaTrabajadoresTableAdapter
End Class
