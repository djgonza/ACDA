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
        Me.lblNumemp = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblOfc = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCtr = New System.Windows.Forms.Label()
        Me.lblBoss = New System.Windows.Forms.Label()
        Me.lblCuota = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.btnSgn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumemp
        '
        Me.lblNumemp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNumemp.Location = New System.Drawing.Point(31, 33)
        Me.lblNumemp.Name = "lblNumemp"
        Me.lblNumemp.Size = New System.Drawing.Size(100, 13)
        Me.lblNumemp.TabIndex = 0
        Me.lblNumemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Location = New System.Drawing.Point(172, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAge.Location = New System.Drawing.Point(31, 61)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(100, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOfc
        '
        Me.lblOfc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOfc.Location = New System.Drawing.Point(172, 61)
        Me.lblOfc.Name = "lblOfc"
        Me.lblOfc.Size = New System.Drawing.Size(100, 13)
        Me.lblOfc.TabIndex = 0
        Me.lblOfc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitle.Location = New System.Drawing.Point(31, 98)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCtr
        '
        Me.lblCtr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCtr.Location = New System.Drawing.Point(172, 98)
        Me.lblCtr.Name = "lblCtr"
        Me.lblCtr.Size = New System.Drawing.Size(100, 13)
        Me.lblCtr.TabIndex = 0
        Me.lblCtr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBoss
        '
        Me.lblBoss.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBoss.Location = New System.Drawing.Point(31, 133)
        Me.lblBoss.Name = "lblBoss"
        Me.lblBoss.Size = New System.Drawing.Size(100, 13)
        Me.lblBoss.TabIndex = 0
        Me.lblBoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCuota
        '
        Me.lblCuota.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCuota.Location = New System.Drawing.Point(172, 133)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(100, 13)
        Me.lblCuota.TabIndex = 0
        Me.lblCuota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVentas
        '
        Me.lblVentas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblVentas.Location = New System.Drawing.Point(31, 177)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(100, 13)
        Me.lblVentas.TabIndex = 0
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSgn
        '
        Me.btnSgn.Location = New System.Drawing.Point(139, 216)
        Me.btnSgn.Name = "btnSgn"
        Me.btnSgn.Size = New System.Drawing.Size(121, 23)
        Me.btnSgn.TabIndex = 1
        Me.btnSgn.Text = "Sigueinte Registro"
        Me.btnSgn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Registro Anterior"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSgn)
        Me.Controls.Add(Me.lblVentas)
        Me.Controls.Add(Me.lblCuota)
        Me.Controls.Add(Me.lblBoss)
        Me.Controls.Add(Me.lblCtr)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblOfc)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNumemp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNumemp As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblOfc As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCtr As System.Windows.Forms.Label
    Friend WithEvents lblBoss As System.Windows.Forms.Label
    Friend WithEvents lblCuota As System.Windows.Forms.Label
    Friend WithEvents lblVentas As System.Windows.Forms.Label
    Friend WithEvents btnSgn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
