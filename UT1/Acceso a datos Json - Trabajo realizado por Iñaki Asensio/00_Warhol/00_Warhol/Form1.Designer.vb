<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWarhol
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picOriginal = New System.Windows.Forms.PictureBox()
        Me.picWarhol = New System.Windows.Forms.PictureBox()
        Me.btnSelecionarImagen = New System.Windows.Forms.Button()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.btnGenerarWarhol = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAltoWH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAnchoWH = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGenerarWarhol = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbGenerar = New System.Windows.Forms.ProgressBar()
        Me.sbInferior = New System.Windows.Forms.StatusStrip()
        Me.txtBarraEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarhol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.sbInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(11, 631)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(200, 32)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picOriginal
        '
        Me.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOriginal.Location = New System.Drawing.Point(11, 126)
        Me.picOriginal.Name = "picOriginal"
        Me.picOriginal.Size = New System.Drawing.Size(200, 200)
        Me.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOriginal.TabIndex = 1
        Me.picOriginal.TabStop = False
        '
        'picWarhol
        '
        Me.picWarhol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWarhol.Location = New System.Drawing.Point(228, 64)
        Me.picWarhol.Name = "picWarhol"
        Me.picWarhol.Size = New System.Drawing.Size(600, 600)
        Me.picWarhol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarhol.TabIndex = 2
        Me.picWarhol.TabStop = False
        '
        'btnSelecionarImagen
        '
        Me.btnSelecionarImagen.Location = New System.Drawing.Point(11, 64)
        Me.btnSelecionarImagen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelecionarImagen.Name = "btnSelecionarImagen"
        Me.btnSelecionarImagen.Size = New System.Drawing.Size(200, 32)
        Me.btnSelecionarImagen.TabIndex = 3
        Me.btnSelecionarImagen.Text = "Selecionar &Imagen"
        Me.btnSelecionarImagen.UseVisualStyleBackColor = True
        '
        'txtAncho
        '
        Me.txtAncho.Enabled = False
        Me.txtAncho.Location = New System.Drawing.Point(71, 337)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(109, 26)
        Me.txtAncho.TabIndex = 4
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ancho:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "px"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "px"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Alto:"
        '
        'txtAlto
        '
        Me.txtAlto.Enabled = False
        Me.txtAlto.Location = New System.Drawing.Point(71, 369)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(109, 26)
        Me.txtAlto.TabIndex = 7
        Me.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGenerarWarhol
        '
        Me.btnGenerarWarhol.Enabled = False
        Me.btnGenerarWarhol.Location = New System.Drawing.Point(11, 411)
        Me.btnGenerarWarhol.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerarWarhol.Name = "btnGenerarWarhol"
        Me.btnGenerarWarhol.Size = New System.Drawing.Size(200, 32)
        Me.btnGenerarWarhol.TabIndex = 10
        Me.btnGenerarWarhol.Text = "&Generar Warhol"
        Me.btnGenerarWarhol.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(11, 491)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(200, 32)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "&Guardar como..."
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Imagen Original:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Imagen Generada:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(800, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "px"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(626, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Alto:"
        '
        'txtAltoWH
        '
        Me.txtAltoWH.Enabled = False
        Me.txtAltoWH.Location = New System.Drawing.Point(685, 32)
        Me.txtAltoWH.Name = "txtAltoWH"
        Me.txtAltoWH.Size = New System.Drawing.Size(109, 26)
        Me.txtAltoWH.TabIndex = 17
        Me.txtAltoWH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "px"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(390, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Ancho:"
        '
        'txtAnchoWH
        '
        Me.txtAnchoWH.Enabled = False
        Me.txtAnchoWH.Location = New System.Drawing.Point(449, 32)
        Me.txtAnchoWH.Name = "txtAnchoWH"
        Me.txtAnchoWH.Size = New System.Drawing.Size(109, 26)
        Me.txtAnchoWH.TabIndex = 14
        Me.txtAnchoWH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrir, Me.mnuGuardarComo, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'mnuAbrir
        '
        Me.mnuAbrir.Name = "mnuAbrir"
        Me.mnuAbrir.Size = New System.Drawing.Size(159, 22)
        Me.mnuAbrir.Text = "Abrir"
        '
        'mnuGuardarComo
        '
        Me.mnuGuardarComo.Enabled = False
        Me.mnuGuardarComo.Name = "mnuGuardarComo"
        Me.mnuGuardarComo.Size = New System.Drawing.Size(159, 22)
        Me.mnuGuardarComo.Text = "Guardar como..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(159, 22)
        Me.mnuSalir.Text = "Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGenerarWarhol})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'mnuGenerarWarhol
        '
        Me.mnuGenerarWarhol.Enabled = False
        Me.mnuGenerarWarhol.Name = "mnuGenerarWarhol"
        Me.mnuGenerarWarhol.Size = New System.Drawing.Size(156, 22)
        Me.mnuGenerarWarhol.Text = "Generar Warhol"
        '
        'pbGenerar
        '
        Me.pbGenerar.Location = New System.Drawing.Point(11, 451)
        Me.pbGenerar.Name = "pbGenerar"
        Me.pbGenerar.Size = New System.Drawing.Size(200, 23)
        Me.pbGenerar.TabIndex = 21
        '
        'sbInferior
        '
        Me.sbInferior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtBarraEstado})
        Me.sbInferior.Location = New System.Drawing.Point(0, 689)
        Me.sbInferior.Name = "sbInferior"
        Me.sbInferior.Size = New System.Drawing.Size(844, 22)
        Me.sbInferior.TabIndex = 22
        Me.sbInferior.Text = "StatusStrip1"
        '
        'txtBarraEstado
        '
        Me.txtBarraEstado.Name = "txtBarraEstado"
        Me.txtBarraEstado.Size = New System.Drawing.Size(99, 17)
        Me.txtBarraEstado.Text = "Warhol Maker 1.0"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'frmWarhol
        '
        Me.AcceptButton = Me.btnSelecionarImagen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(844, 711)
        Me.Controls.Add(Me.sbInferior)
        Me.Controls.Add(Me.pbGenerar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAltoWH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAnchoWH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnGenerarWarhol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAncho)
        Me.Controls.Add(Me.btnSelecionarImagen)
        Me.Controls.Add(Me.picWarhol)
        Me.Controls.Add(Me.picOriginal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWarhol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warhol Maker"
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarhol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sbInferior.ResumeLayout(False)
        Me.sbInferior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents picOriginal As PictureBox
    Friend WithEvents picWarhol As PictureBox
    Friend WithEvents btnSelecionarImagen As Button
    Friend WithEvents txtAncho As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlto As TextBox
    Friend WithEvents btnGenerarWarhol As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAltoWH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAnchoWH As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuGenerarWarhol As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents pbGenerar As ProgressBar
    Friend WithEvents sbInferior As StatusStrip
    Friend WithEvents txtBarraEstado As ToolStripStatusLabel
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
