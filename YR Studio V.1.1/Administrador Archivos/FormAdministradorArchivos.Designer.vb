<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministradorArchivos
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
        txtRuta = New TextBox()
        btnValidar = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtRuta
        ' 
        txtRuta.Location = New Point(12, 12)
        txtRuta.Name = "txtRuta"
        txtRuta.Size = New Size(100, 23)
        txtRuta.TabIndex = 0
        txtRuta.Text = "Ruta"
        ' 
        ' btnValidar
        ' 
        btnValidar.Location = New Point(12, 41)
        btnValidar.Name = "btnValidar"
        btnValidar.Size = New Size(100, 23)
        btnValidar.TabIndex = 1
        btnValidar.Text = "Validar"
        btnValidar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 67)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(59, 15)
        lblResultado.TabIndex = 2
        lblResultado.Text = "Resultado"
        ' 
        ' FormAdministradorArchivos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnValidar)
        Controls.Add(txtRuta)
        Name = "FormAdministradorArchivos"
        Text = "FormAdministradorArchivos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRuta As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents lblResultado As Label
End Class
