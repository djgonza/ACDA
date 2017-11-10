<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea05
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
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.rtbOriginal = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbAñadido = New System.Windows.Forms.RichTextBox()
        Me.rbtPrincipio = New System.Windows.Forms.RadioButton()
        Me.rbtFinal = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmbMarcas
        '
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Items.AddRange(New Object() {"BMW", "Citroen", "Opel", "Mercedes", "Peugeot", "Renault"})
        Me.cmbMarcas.Location = New System.Drawing.Point(12, 12)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(301, 21)
        Me.cmbMarcas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modelo coche"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(100, 39)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 2
        '
        'txtPotencia
        '
        Me.txtPotencia.Location = New System.Drawing.Point(100, 65)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.Size = New System.Drawing.Size(100, 20)
        Me.txtPotencia.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Potencia coche"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(111, 91)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 40)
        Me.btnAñadir.TabIndex = 5
        Me.btnAñadir.Text = "&Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'rtbOriginal
        '
        Me.rtbOriginal.Location = New System.Drawing.Point(15, 157)
        Me.rtbOriginal.Name = "rtbOriginal"
        Me.rtbOriginal.Size = New System.Drawing.Size(213, 288)
        Me.rtbOriginal.TabIndex = 6
        Me.rtbOriginal.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Original"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Actualizado"
        '
        'rtbAñadido
        '
        Me.rtbAñadido.Location = New System.Drawing.Point(243, 157)
        Me.rtbAñadido.Name = "rtbAñadido"
        Me.rtbAñadido.Size = New System.Drawing.Size(233, 288)
        Me.rtbAñadido.TabIndex = 9
        Me.rtbAñadido.Text = ""
        '
        'rbtPrincipio
        '
        Me.rbtPrincipio.AutoSize = True
        Me.rbtPrincipio.Checked = True
        Me.rbtPrincipio.Location = New System.Drawing.Point(15, 91)
        Me.rbtPrincipio.Name = "rbtPrincipio"
        Me.rbtPrincipio.Size = New System.Drawing.Size(76, 17)
        Me.rbtPrincipio.TabIndex = 11
        Me.rbtPrincipio.TabStop = True
        Me.rbtPrincipio.Text = "Al principio"
        Me.rbtPrincipio.UseVisualStyleBackColor = True
        '
        'rbtFinal
        '
        Me.rbtFinal.AutoSize = True
        Me.rbtFinal.Location = New System.Drawing.Point(15, 114)
        Me.rbtFinal.Name = "rbtFinal"
        Me.rbtFinal.Size = New System.Drawing.Size(56, 17)
        Me.rbtFinal.TabIndex = 12
        Me.rbtFinal.Text = "Al final"
        Me.rbtFinal.UseVisualStyleBackColor = True
        '
        'frnTarea05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 515)
        Me.Controls.Add(Me.rbtFinal)
        Me.Controls.Add(Me.rbtPrincipio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtbAñadido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtbOriginal)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMarcas)
        Me.Name = "frnTarea05"
        Me.Text = "Tarea 05"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtPotencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents rtbOriginal As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtbAñadido As System.Windows.Forms.RichTextBox
    Friend WithEvents rbtPrincipio As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFinal As System.Windows.Forms.RadioButton

End Class
