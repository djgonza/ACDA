<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea04
    Inherits System.Windows.Forms.Form

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
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rtbSolucion = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(12, 12)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(116, 65)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear XML Actividades"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(13, 84)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 49)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rtbSolucion
        '
        Me.rtbSolucion.Location = New System.Drawing.Point(137, 12)
        Me.rtbSolucion.Name = "rtbSolucion"
        Me.rtbSolucion.Size = New System.Drawing.Size(257, 263)
        Me.rtbSolucion.TabIndex = 2
        Me.rtbSolucion.Text = ""
        '
        'frnTarea04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 285)
        Me.Controls.Add(Me.rtbSolucion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "frnTarea04"
        Me.Text = "Tarea 04"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents rtbSolucion As System.Windows.Forms.RichTextBox

End Class
