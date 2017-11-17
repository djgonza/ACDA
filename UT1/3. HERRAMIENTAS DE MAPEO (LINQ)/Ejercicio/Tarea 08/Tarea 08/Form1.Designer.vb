<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea08
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.rtbMostrar = New System.Windows.Forms.RichTextBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta elegida:"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(15, 44)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(121, 48)
        Me.btnCrear.TabIndex = 2
        Me.btnCrear.Text = "&Crear el documento"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'rtbMostrar
        '
        Me.rtbMostrar.Location = New System.Drawing.Point(142, 44)
        Me.rtbMostrar.Name = "rtbMostrar"
        Me.rtbMostrar.Size = New System.Drawing.Size(536, 344)
        Me.rtbMostrar.TabIndex = 4
        Me.rtbMostrar.Text = ""
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(88, 6)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(100, 20)
        Me.txtRuta.TabIndex = 5
        '
        'frnTarea08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 400)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.rtbMostrar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnTarea08"
        Me.Text = "Tarea 08"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents rtbMostrar As System.Windows.Forms.RichTextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox

End Class
