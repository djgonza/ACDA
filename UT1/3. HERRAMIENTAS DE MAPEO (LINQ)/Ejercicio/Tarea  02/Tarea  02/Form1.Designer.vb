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
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnConsulta1 = New System.Windows.Forms.Button()
        Me.btnConsulta2 = New System.Windows.Forms.Button()
        Me.lstConsulta1 = New System.Windows.Forms.ListBox()
        Me.lstConsulta2 = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(13, 13)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(93, 42)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "&Crear XML"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Location = New System.Drawing.Point(13, 62)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(93, 51)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConsulta1
        '
        Me.btnConsulta1.Location = New System.Drawing.Point(112, 15)
        Me.btnConsulta1.Name = "btnConsulta1"
        Me.btnConsulta1.Size = New System.Drawing.Size(124, 42)
        Me.btnConsulta1.TabIndex = 2
        Me.btnConsulta1.Text = "Consulta 01"
        Me.btnConsulta1.UseVisualStyleBackColor = True
        '
        'btnConsulta2
        '
        Me.btnConsulta2.Location = New System.Drawing.Point(242, 15)
        Me.btnConsulta2.Name = "btnConsulta2"
        Me.btnConsulta2.Size = New System.Drawing.Size(124, 42)
        Me.btnConsulta2.TabIndex = 3
        Me.btnConsulta2.Text = "Consulta 02"
        Me.btnConsulta2.UseVisualStyleBackColor = True
        '
        'lstConsulta1
        '
        Me.lstConsulta1.FormattingEnabled = True
        Me.lstConsulta1.Location = New System.Drawing.Point(112, 62)
        Me.lstConsulta1.Name = "lstConsulta1"
        Me.lstConsulta1.Size = New System.Drawing.Size(120, 186)
        Me.lstConsulta1.TabIndex = 4
        '
        'lstConsulta2
        '
        Me.lstConsulta2.FormattingEnabled = True
        Me.lstConsulta2.Location = New System.Drawing.Point(242, 62)
        Me.lstConsulta2.Name = "lstConsulta2"
        Me.lstConsulta2.Size = New System.Drawing.Size(213, 186)
        Me.lstConsulta2.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(15, 120)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 64)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 261)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lstConsulta2)
        Me.Controls.Add(Me.lstConsulta1)
        Me.Controls.Add(Me.btnConsulta2)
        Me.Controls.Add(Me.btnConsulta1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnConsulta1 As System.Windows.Forms.Button
    Friend WithEvents btnConsulta2 As System.Windows.Forms.Button
    Friend WithEvents lstConsulta1 As System.Windows.Forms.ListBox
    Friend WithEvents lstConsulta2 As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
