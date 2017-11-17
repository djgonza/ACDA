<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTarea06
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
        Me.rbtModificar = New System.Windows.Forms.RadioButton()
        Me.rbtEliminar = New System.Windows.Forms.RadioButton()
        Me.rtbOriginal = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpbModificar = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbResultado = New System.Windows.Forms.RichTextBox()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.gpbEliminar = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMarca2 = New System.Windows.Forms.ComboBox()
        Me.gpbModificar.SuspendLayout()
        Me.gpbEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtModificar
        '
        Me.rbtModificar.AutoSize = True
        Me.rbtModificar.Checked = True
        Me.rbtModificar.Location = New System.Drawing.Point(13, 13)
        Me.rbtModificar.Name = "rbtModificar"
        Me.rbtModificar.Size = New System.Drawing.Size(68, 17)
        Me.rbtModificar.TabIndex = 0
        Me.rbtModificar.TabStop = True
        Me.rbtModificar.Text = "Modificar"
        Me.rbtModificar.UseVisualStyleBackColor = True
        '
        'rbtEliminar
        '
        Me.rbtEliminar.AutoSize = True
        Me.rbtEliminar.Location = New System.Drawing.Point(12, 36)
        Me.rbtEliminar.Name = "rbtEliminar"
        Me.rbtEliminar.Size = New System.Drawing.Size(61, 17)
        Me.rbtEliminar.TabIndex = 1
        Me.rbtEliminar.Text = "Eliminar"
        Me.rbtEliminar.UseVisualStyleBackColor = True
        '
        'rtbOriginal
        '
        Me.rtbOriginal.Location = New System.Drawing.Point(12, 83)
        Me.rtbOriginal.Name = "rtbOriginal"
        Me.rtbOriginal.Size = New System.Drawing.Size(213, 381)
        Me.rtbOriginal.TabIndex = 7
        Me.rtbOriginal.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Original"
        '
        'gpbModificar
        '
        Me.gpbModificar.Controls.Add(Me.Label2)
        Me.gpbModificar.Controls.Add(Me.cmbMarca2)
        Me.gpbModificar.Controls.Add(Me.Label1)
        Me.gpbModificar.Controls.Add(Me.cmbMarca)
        Me.gpbModificar.Controls.Add(Me.btnModificar)
        Me.gpbModificar.Location = New System.Drawing.Point(231, 83)
        Me.gpbModificar.Name = "gpbModificar"
        Me.gpbModificar.Size = New System.Drawing.Size(221, 198)
        Me.gpbModificar.TabIndex = 10
        Me.gpbModificar.TabStop = False
        Me.gpbModificar.Text = "Modificar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "¿Qué marca quiere modificar?"
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"BMW", "Citroen", "Opel", "Mercedes", "Peugeot", "Renault"})
        Me.cmbMarca.Location = New System.Drawing.Point(6, 39)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(209, 21)
        Me.cmbMarca.TabIndex = 17
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(6, 118)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(209, 74)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Resultado"
        '
        'rtbResultado
        '
        Me.rtbResultado.Location = New System.Drawing.Point(458, 83)
        Me.rtbResultado.Name = "rtbResultado"
        Me.rtbResultado.Size = New System.Drawing.Size(233, 381)
        Me.rtbResultado.TabIndex = 11
        Me.rtbResultado.Text = ""
        '
        'cmbMarcas
        '
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Items.AddRange(New Object() {"BMW", "Citroen", "Opel", "Mercedes", "Peugeot", "Renault"})
        Me.cmbMarcas.Location = New System.Drawing.Point(6, 35)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(209, 21)
        Me.cmbMarcas.TabIndex = 13
        '
        'gpbEliminar
        '
        Me.gpbEliminar.Controls.Add(Me.Label5)
        Me.gpbEliminar.Controls.Add(Me.btnEliminar)
        Me.gpbEliminar.Controls.Add(Me.cmbMarcas)
        Me.gpbEliminar.Location = New System.Drawing.Point(231, 287)
        Me.gpbEliminar.Name = "gpbEliminar"
        Me.gpbEliminar.Size = New System.Drawing.Size(221, 163)
        Me.gpbEliminar.TabIndex = 13
        Me.gpbEliminar.TabStop = False
        Me.gpbEliminar.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "¿Qué vehículo quieres eliminar?"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(6, 83)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(209, 74)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "¿A cual la quieres cambiar?"
        '
        'cmbMarca2
        '
        Me.cmbMarca2.FormattingEnabled = True
        Me.cmbMarca2.Items.AddRange(New Object() {"BMW", "Citroen", "Opel", "Mercedes", "Peugeot", "Renault"})
        Me.cmbMarca2.Location = New System.Drawing.Point(9, 91)
        Me.cmbMarca2.Name = "cmbMarca2"
        Me.cmbMarca2.Size = New System.Drawing.Size(209, 21)
        Me.cmbMarca2.TabIndex = 19
        '
        'frnTarea06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 476)
        Me.Controls.Add(Me.gpbEliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtbResultado)
        Me.Controls.Add(Me.gpbModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtbOriginal)
        Me.Controls.Add(Me.rbtEliminar)
        Me.Controls.Add(Me.rbtModificar)
        Me.Name = "frnTarea06"
        Me.Text = "Tarea 06"
        Me.gpbModificar.ResumeLayout(False)
        Me.gpbModificar.PerformLayout()
        Me.gpbEliminar.ResumeLayout(False)
        Me.gpbEliminar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents rtbOriginal As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpbModificar As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtbResultado As System.Windows.Forms.RichTextBox
    Friend WithEvents gpbEliminar As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMarca2 As System.Windows.Forms.ComboBox

End Class
