<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.BtnSumar = New System.Windows.Forms.Button()
        Me.BtnResta = New System.Windows.Forms.Button()
        Me.BtnMultiplicar = New System.Windows.Forms.Button()
        Me.BtnDividir = New System.Windows.Forms.Button()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumero1.Location = New System.Drawing.Point(35, 19)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(108, 24)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Numero 1:"
        '
        'txtNumero1
        '
        Me.txtNumero1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero1.Location = New System.Drawing.Point(199, 12)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(379, 31)
        Me.txtNumero1.TabIndex = 1
        Me.txtNumero1.Text = "0"
        Me.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSumar
        '
        Me.BtnSumar.BackColor = System.Drawing.SystemColors.GrayText
        Me.BtnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSumar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSumar.Location = New System.Drawing.Point(199, 49)
        Me.BtnSumar.Name = "BtnSumar"
        Me.BtnSumar.Size = New System.Drawing.Size(75, 75)
        Me.BtnSumar.TabIndex = 2
        Me.BtnSumar.Text = "+"
        Me.BtnSumar.UseVisualStyleBackColor = False
        '
        'BtnResta
        '
        Me.BtnResta.BackColor = System.Drawing.SystemColors.GrayText
        Me.BtnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnResta.Location = New System.Drawing.Point(299, 49)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(75, 75)
        Me.BtnResta.TabIndex = 3
        Me.BtnResta.Text = "-"
        Me.BtnResta.UseVisualStyleBackColor = False
        '
        'BtnMultiplicar
        '
        Me.BtnMultiplicar.BackColor = System.Drawing.SystemColors.GrayText
        Me.BtnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiplicar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMultiplicar.Location = New System.Drawing.Point(399, 49)
        Me.BtnMultiplicar.Name = "BtnMultiplicar"
        Me.BtnMultiplicar.Size = New System.Drawing.Size(75, 75)
        Me.BtnMultiplicar.TabIndex = 4
        Me.BtnMultiplicar.Text = "x"
        Me.BtnMultiplicar.UseVisualStyleBackColor = False
        '
        'BtnDividir
        '
        Me.BtnDividir.BackColor = System.Drawing.SystemColors.GrayText
        Me.BtnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDividir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDividir.Location = New System.Drawing.Point(503, 49)
        Me.BtnDividir.Name = "BtnDividir"
        Me.BtnDividir.Size = New System.Drawing.Size(75, 75)
        Me.BtnDividir.TabIndex = 5
        Me.BtnDividir.Text = "/"
        Me.BtnDividir.UseVisualStyleBackColor = False
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumero2.Location = New System.Drawing.Point(35, 137)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(108, 24)
        Me.lblNumero2.TabIndex = 6
        Me.lblNumero2.Text = "Numero 2:"
        '
        'txtNumero2
        '
        Me.txtNumero2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero2.Location = New System.Drawing.Point(199, 130)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(379, 31)
        Me.txtNumero2.TabIndex = 7
        Me.txtNumero2.Text = "0"
        Me.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(371, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
        '
        'lblresultado
        '
        Me.lblresultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblresultado.Location = New System.Drawing.Point(51, 214)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(527, 62)
        Me.lblresultado.TabIndex = 9
        Me.lblresultado.Text = "0"
        Me.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(589, 292)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.BtnDividir)
        Me.Controls.Add(Me.BtnMultiplicar)
        Me.Controls.Add(Me.BtnResta)
        Me.Controls.Add(Me.BtnSumar)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.lblNumero1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero1 As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents BtnSumar As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnDividir As Button
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblresultado As Label
End Class
