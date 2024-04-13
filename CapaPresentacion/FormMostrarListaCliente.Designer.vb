<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMostrarListaCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.dataListaCliente = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        CType(Me.dataListaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Nombre", "NDocumento"})
        Me.cboBuscar.Location = New System.Drawing.Point(17, 85)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(132, 21)
        Me.cboBuscar.TabIndex = 28
        Me.cboBuscar.Text = "Nombre"
        '
        'dataListaCliente
        '
        Me.dataListaCliente.AllowUserToAddRows = False
        Me.dataListaCliente.AllowUserToDeleteRows = False
        Me.dataListaCliente.AllowUserToOrderColumns = True
        Me.dataListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListaCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListaCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListaCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListaCliente.ColumnHeadersHeight = 25
        Me.dataListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListaCliente.EnableHeadersVisualStyles = False
        Me.dataListaCliente.GridColor = System.Drawing.Color.White
        Me.dataListaCliente.Location = New System.Drawing.Point(9, 123)
        Me.dataListaCliente.MultiSelect = False
        Me.dataListaCliente.Name = "dataListaCliente"
        Me.dataListaCliente.ReadOnly = True
        Me.dataListaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListaCliente.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dataListaCliente.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListaCliente.Size = New System.Drawing.Size(669, 108)
        Me.dataListaCliente.TabIndex = 27
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(163, 84)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(387, 25)
        Me.txtBuscar.TabIndex = 26
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(256, 163)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(140, 13)
        Me.inexistente.TabIndex = 29
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos No Existen en la Lista"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(575, 87)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(49, 20)
        Me.txtflag.TabIndex = 30
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'FormMostrarListaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 268)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.cboBuscar)
        Me.Controls.Add(Me.dataListaCliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "FormMostrarListaCliente"
        Me.Text = "Lista de Clientes"
        CType(Me.dataListaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboBuscar As ComboBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtflag As TextBox
    Friend WithEvents dataListaCliente As DataGridView
End Class
