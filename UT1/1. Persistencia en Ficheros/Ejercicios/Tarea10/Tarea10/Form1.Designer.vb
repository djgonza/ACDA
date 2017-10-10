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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAREA 10"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUno
        '
        Me.btnUno.Location = New System.Drawing.Point(13, 40)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(75, 23)
        Me.btnUno.TabIndex = 1
        Me.btnUno.Text = "Ejercicio01"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Location = New System.Drawing.Point(13, 70)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(75, 23)
        Me.btnDos.TabIndex = 2
        Me.btnDos.Text = "Ejercicio02"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Location = New System.Drawing.Point(13, 100)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(75, 23)
        Me.btnTres.TabIndex = 3
        Me.btnTres.Text = "Ejercicio03"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnCuatro
        '
        Me.btnCuatro.Location = New System.Drawing.Point(12, 129)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(75, 23)
        Me.btnCuatro.TabIndex = 4
        Me.btnCuatro.Text = "Ejercicio04"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Location = New System.Drawing.Point(13, 158)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(75, 23)
        Me.btnCinco.TabIndex = 5
        Me.btnCinco.Text = "Ejercicio05"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Location = New System.Drawing.Point(13, 187)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(75, 23)
        Me.btnSeis.TabIndex = 6
        Me.btnSeis.Text = "Ejercicio06"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSeis)
        Me.Controls.Add(Me.btnCinco)
        Me.Controls.Add(Me.btnCuatro)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnUno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUno As System.Windows.Forms.Button
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents btnTres As System.Windows.Forms.Button
    Friend WithEvents btnCuatro As System.Windows.Forms.Button
    Friend WithEvents btnCinco As System.Windows.Forms.Button
    Friend WithEvents btnSeis As System.Windows.Forms.Button

End Class
