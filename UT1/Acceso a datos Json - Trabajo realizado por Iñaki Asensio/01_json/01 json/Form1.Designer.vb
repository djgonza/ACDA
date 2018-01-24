<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gruUsuario = New System.Windows.Forms.GroupBox()
        Me.txtUserNum = New System.Windows.Forms.TextBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.txtNat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numUsuariosARecibir = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarJson = New System.Windows.Forms.Button()
        Me.gruUsuario.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUsuariosARecibir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(315, 252)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "email:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(200, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 18)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Ms/Mr/Miss:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(294, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(265, 26)
        Me.txtName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(294, 83)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(265, 26)
        Me.txtEmail.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(294, 115)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(265, 26)
        Me.txtPhone.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "phone:"
        '
        'gruUsuario
        '
        Me.gruUsuario.Controls.Add(Me.txtUserNum)
        Me.gruUsuario.Controls.Add(Me.btnSiguiente)
        Me.gruUsuario.Controls.Add(Me.btnAnterior)
        Me.gruUsuario.Controls.Add(Me.txtGenre)
        Me.gruUsuario.Controls.Add(Me.Label5)
        Me.gruUsuario.Controls.Add(Me.picImagen)
        Me.gruUsuario.Controls.Add(Me.txtNat)
        Me.gruUsuario.Controls.Add(Me.Label4)
        Me.gruUsuario.Controls.Add(Me.txtPhone)
        Me.gruUsuario.Controls.Add(Me.Label3)
        Me.gruUsuario.Controls.Add(Me.txtEmail)
        Me.gruUsuario.Controls.Add(Me.txtName)
        Me.gruUsuario.Controls.Add(Me.lblName)
        Me.gruUsuario.Controls.Add(Me.Label2)
        Me.gruUsuario.Location = New System.Drawing.Point(12, 12)
        Me.gruUsuario.Name = "gruUsuario"
        Me.gruUsuario.Size = New System.Drawing.Size(582, 235)
        Me.gruUsuario.TabIndex = 8
        Me.gruUsuario.TabStop = False
        Me.gruUsuario.Text = "Ficha de Usuario"
        '
        'txtUserNum
        '
        Me.txtUserNum.Enabled = False
        Me.txtUserNum.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserNum.Location = New System.Drawing.Point(403, 179)
        Me.txtUserNum.Name = "txtUserNum"
        Me.txtUserNum.Size = New System.Drawing.Size(58, 26)
        Me.txtUserNum.TabIndex = 15
        Me.txtUserNum.Text = "0"
        Me.txtUserNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(465, 179)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(94, 26)
        Me.btnSiguiente.TabIndex = 14
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(294, 179)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(105, 26)
        Me.btnAnterior.TabIndex = 13
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'txtGenre
        '
        Me.txtGenre.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(294, 51)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(265, 26)
        Me.txtGenre.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "genre:"
        '
        'picImagen
        '
        Me.picImagen.Location = New System.Drawing.Point(17, 19)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(162, 183)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 10
        Me.picImagen.TabStop = False
        '
        'txtNat
        '
        Me.txtNat.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNat.Location = New System.Drawing.Point(294, 147)
        Me.txtNat.Name = "txtNat"
        Me.txtNat.Size = New System.Drawing.Size(265, 26)
        Me.txtNat.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "nat:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(519, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numUsuariosARecibir
        '
        Me.numUsuariosARecibir.Location = New System.Drawing.Point(231, 253)
        Me.numUsuariosARecibir.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numUsuariosARecibir.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUsuariosARecibir.Name = "numUsuariosARecibir"
        Me.numUsuariosARecibir.Size = New System.Drawing.Size(78, 20)
        Me.numUsuariosARecibir.TabIndex = 10
        Me.numUsuariosARecibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numUsuariosARecibir.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Número de Usuarios a recibir:"
        '
        'btnGuardarJson
        '
        Me.btnGuardarJson.Enabled = False
        Me.btnGuardarJson.Location = New System.Drawing.Point(398, 253)
        Me.btnGuardarJson.Name = "btnGuardarJson"
        Me.btnGuardarJson.Size = New System.Drawing.Size(98, 23)
        Me.btnGuardarJson.TabIndex = 17
        Me.btnGuardarJson.Text = "Guardar JSON"
        Me.btnGuardarJson.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 283)
        Me.Controls.Add(Me.btnGuardarJson)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numUsuariosARecibir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gruUsuario)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Ramdon Generator - Json "
        Me.gruUsuario.ResumeLayout(False)
        Me.gruUsuario.PerformLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUsuariosARecibir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gruUsuario As GroupBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents txtNat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUserNum As TextBox
    Friend WithEvents numUsuariosARecibir As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarJson As Button
End Class
