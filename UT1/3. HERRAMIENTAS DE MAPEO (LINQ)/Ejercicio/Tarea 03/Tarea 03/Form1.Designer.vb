<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea03
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
        Me.rtbSolucion = New System.Windows.Forms.RichTextBox()
        Me.lstSeleccion = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(13, 13)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(143, 62)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "&Crear Documento Bailes2.xml"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'rtbSolucion
        '
        Me.rtbSolucion.Location = New System.Drawing.Point(162, 13)
        Me.rtbSolucion.Name = "rtbSolucion"
        Me.rtbSolucion.Size = New System.Drawing.Size(257, 263)
        Me.rtbSolucion.TabIndex = 1
        Me.rtbSolucion.Text = ""
        '
        'lstSeleccion
        '
        Me.lstSeleccion.FormattingEnabled = True
        Me.lstSeleccion.Location = New System.Drawing.Point(13, 90)
        Me.lstSeleccion.Name = "lstSeleccion"
        Me.lstSeleccion.Size = New System.Drawing.Size(143, 186)
        Me.lstSeleccion.TabIndex = 2
        Me.lstSeleccion.Visible = False
        '
        'frnTarea03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 296)
        Me.Controls.Add(Me.lstSeleccion)
        Me.Controls.Add(Me.rtbSolucion)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "frnTarea03"
        Me.Text = "Tarea 03"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents rtbSolucion As System.Windows.Forms.RichTextBox
    Friend WithEvents lstSeleccion As System.Windows.Forms.ListBox

End Class
