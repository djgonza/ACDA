<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(348, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Verificar existencia de directorio (con clase Directory)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(348, 28)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Verificar existencia de directorio (con clase DirectoryInfo)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(348, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Contar subdirectorios en un directorio (con clase Directory)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 139)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(348, 28)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Contar subdirectorios en un directorio (con clase DirectoryInfo)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(32, 173)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(348, 28)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Contar archivos con extension en un directorio y sus subdirectorios (con clase Di" & _
    "rectory)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(32, 207)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(348, 28)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Contar archivos con extension en un directorio y sus subdirectorios (con clase Di" & _
    "rectoryInfo)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(32, 329)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(348, 28)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 583)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
