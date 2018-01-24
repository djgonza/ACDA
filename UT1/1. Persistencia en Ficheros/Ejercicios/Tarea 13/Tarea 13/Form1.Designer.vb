<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea13
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
        Me.rtbMostrar = New System.Windows.Forms.RichTextBox()
        Me.rtbSolucion = New System.Windows.Forms.RichTextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnSecuencial = New System.Windows.Forms.Button()
        Me.btnDom = New System.Windows.Forms.Button()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.btnTransformacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbMostrar
        '
        Me.rtbMostrar.Location = New System.Drawing.Point(13, 13)
        Me.rtbMostrar.Name = "rtbMostrar"
        Me.rtbMostrar.Size = New System.Drawing.Size(367, 508)
        Me.rtbMostrar.TabIndex = 0
        Me.rtbMostrar.Text = ""
        '
        'rtbSolucion
        '
        Me.rtbSolucion.Location = New System.Drawing.Point(496, 12)
        Me.rtbSolucion.Name = "rtbSolucion"
        Me.rtbSolucion.Size = New System.Drawing.Size(367, 508)
        Me.rtbSolucion.TabIndex = 1
        Me.rtbSolucion.Text = ""
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(130, 527)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(97, 41)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar contenido"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnSecuencial
        '
        Me.btnSecuencial.Location = New System.Drawing.Point(386, 42)
        Me.btnSecuencial.Name = "btnSecuencial"
        Me.btnSecuencial.Size = New System.Drawing.Size(104, 42)
        Me.btnSecuencial.TabIndex = 3
        Me.btnSecuencial.Text = "Lectura Secuencial"
        Me.btnSecuencial.UseVisualStyleBackColor = True
        '
        'btnDom
        '
        Me.btnDom.Location = New System.Drawing.Point(386, 90)
        Me.btnDom.Name = "btnDom"
        Me.btnDom.Size = New System.Drawing.Size(104, 42)
        Me.btnDom.TabIndex = 4
        Me.btnDom.Text = "Modificar datos con DOM"
        Me.btnDom.UseVisualStyleBackColor = True
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(386, 138)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(104, 42)
        Me.btnPath.TabIndex = 5
        Me.btnPath.Text = "Uso Xpath"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'btnTransformacion
        '
        Me.btnTransformacion.Location = New System.Drawing.Point(386, 186)
        Me.btnTransformacion.Name = "btnTransformacion"
        Me.btnTransformacion.Size = New System.Drawing.Size(104, 42)
        Me.btnTransformacion.TabIndex = 6
        Me.btnTransformacion.Text = "Transformación"
        Me.btnTransformacion.UseVisualStyleBackColor = True
        '
        'frnTarea13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 580)
        Me.Controls.Add(Me.btnTransformacion)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.btnDom)
        Me.Controls.Add(Me.btnSecuencial)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.rtbSolucion)
        Me.Controls.Add(Me.rtbMostrar)
        Me.Name = "frnTarea13"
        Me.Text = "Tarea 13"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbMostrar As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbSolucion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents btnSecuencial As System.Windows.Forms.Button
    Friend WithEvents btnDom As System.Windows.Forms.Button
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents btnTransformacion As System.Windows.Forms.Button

End Class
