﻿Imports MaterialSkin

Public Class FormReporteTrabajador
    Private Sub FormReporteTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaVentaRopaTrujilloDataSet.spVisualizarListaTrabajadores' Puede moverla o quitarla según sea necesario.
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Green500, Primary.Green400, Primary.Lime900, Accent.Green100, TextShade.WHITE)
        Me.spVisualizarListaTrabajadoresTableAdapter.Fill(Me.SistemaVentaRopaTrujilloDataSet.spVisualizarListaTrabajadores)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class