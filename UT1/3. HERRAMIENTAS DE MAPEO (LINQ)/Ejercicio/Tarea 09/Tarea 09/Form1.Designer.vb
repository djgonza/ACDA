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
        Me.rtbOriginal = New System.Windows.Forms.RichTextBox()
        Me.btnTransformar = New System.Windows.Forms.Button()
        Me.rtbResultado = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbOriginal
        '
        Me.rtbOriginal.Location = New System.Drawing.Point(12, 12)
        Me.rtbOriginal.Name = "rtbOriginal"
        Me.rtbOriginal.Size = New System.Drawing.Size(344, 540)
        Me.rtbOriginal.TabIndex = 0
        Me.rtbOriginal.Text = ""
        '
        'btnTransformar
        '
        Me.btnTransformar.Location = New System.Drawing.Point(362, 209)
        Me.btnTransformar.Name = "btnTransformar"
        Me.btnTransformar.Size = New System.Drawing.Size(75, 67)
        Me.btnTransformar.TabIndex = 2
        Me.btnTransformar.Text = "Transformar -->"
        Me.btnTransformar.UseVisualStyleBackColor = True
        '
        'rtbResultado
        '
        Me.rtbResultado.Location = New System.Drawing.Point(443, 12)
        Me.rtbResultado.Name = "rtbResultado"
        Me.rtbResultado.Size = New System.Drawing.Size(454, 560)
        Me.rtbResultado.TabIndex = 3
        Me.rtbResultado.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 584)
        Me.Controls.Add(Me.rtbResultado)
        Me.Controls.Add(Me.btnTransformar)
        Me.Controls.Add(Me.rtbOriginal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbOriginal As System.Windows.Forms.RichTextBox
    Friend WithEvents btnTransformar As System.Windows.Forms.Button
    Friend WithEvents rtbResultado As System.Windows.Forms.RichTextBox

End Class
