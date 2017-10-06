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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnConFile = New System.Windows.Forms.Button()
        Me.btnConFileInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnConFile
        '
        Me.btnConFile.Location = New System.Drawing.Point(95, 39)
        Me.btnConFile.Name = "btnConFile"
        Me.btnConFile.Size = New System.Drawing.Size(75, 23)
        Me.btnConFile.TabIndex = 1
        Me.btnConFile.Text = "Con File"
        Me.btnConFile.UseVisualStyleBackColor = True
        '
        'btnConFileInfo
        '
        Me.btnConFileInfo.Location = New System.Drawing.Point(95, 68)
        Me.btnConFileInfo.Name = "btnConFileInfo"
        Me.btnConFileInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnConFileInfo.TabIndex = 2
        Me.btnConFileInfo.Text = "Con FileInfo"
        Me.btnConFileInfo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnConFileInfo)
        Me.Controls.Add(Me.btnConFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConFile As System.Windows.Forms.Button
    Friend WithEvents btnConFileInfo As System.Windows.Forms.Button

End Class
