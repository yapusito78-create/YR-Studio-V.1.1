<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnalizadorIntermedio
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
        btnAnalizar = New Button()
        lblResultado = New Label()
        txtRuta = New TextBox()
        ProgressBar1 = New ProgressBar()
        lblProgreso = New Label()
        SuspendLayout()
        ' 
        ' btnAnalizar
        ' 
        btnAnalizar.Location = New Point(12, 41)
        btnAnalizar.Name = "btnAnalizar"
        btnAnalizar.Size = New Size(75, 23)
        btnAnalizar.TabIndex = 8
        btnAnalizar.Text = "Analizar"
        btnAnalizar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 67)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(59, 15)
        lblResultado.TabIndex = 7
        lblResultado.Text = "Resultado"
        ' 
        ' txtRuta
        ' 
        txtRuta.Location = New Point(12, 12)
        txtRuta.Name = "txtRuta"
        txtRuta.Size = New Size(100, 23)
        txtRuta.TabIndex = 6
        txtRuta.Text = "D:\RADIO VIRREY DEL PINO\MUSICA\CUMBIAS\AMAR AZUL\aa\01 - Dime Tú.mp3"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 85)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(100, 23)
        ProgressBar1.TabIndex = 9
        ' 
        ' lblProgreso
        ' 
        lblProgreso.AutoSize = True
        lblProgreso.Location = New Point(12, 111)
        lblProgreso.Name = "lblProgreso"
        lblProgreso.Size = New Size(54, 15)
        lblProgreso.TabIndex = 10
        lblProgreso.Text = "Progreso"
        ' 
        ' FormAnalizadorIntermedio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblProgreso)
        Controls.Add(ProgressBar1)
        Controls.Add(btnAnalizar)
        Controls.Add(lblResultado)
        Controls.Add(txtRuta)
        Name = "FormAnalizadorIntermedio"
        Text = "FormAnalizadorIntermedio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAnalizar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProgreso As Label
End Class
