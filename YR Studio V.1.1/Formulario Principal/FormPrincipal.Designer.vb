<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAnalizadorBasico = New Button()
        btRouter = New Button()
        btAnalizadorCompleto = New Button()
        btnAdministradorArchivos = New Button()
        btnAnalizadorIntermedio = New Button()
        SuspendLayout()
        ' 
        ' btnAnalizadorBasico
        ' 
        btnAnalizadorBasico.Location = New Point(12, 41)
        btnAnalizadorBasico.Name = "btnAnalizadorBasico"
        btnAnalizadorBasico.Size = New Size(142, 23)
        btnAnalizadorBasico.TabIndex = 0
        btnAnalizadorBasico.Text = "Analizador Básico"
        btnAnalizadorBasico.UseVisualStyleBackColor = True
        ' 
        ' btRouter
        ' 
        btRouter.Location = New Point(12, 12)
        btRouter.Name = "btRouter"
        btRouter.Size = New Size(142, 23)
        btRouter.TabIndex = 1
        btRouter.Text = "Router"
        btRouter.UseVisualStyleBackColor = True
        ' 
        ' btAnalizadorCompleto
        ' 
        btAnalizadorCompleto.Location = New Point(12, 141)
        btAnalizadorCompleto.Name = "btAnalizadorCompleto"
        btAnalizadorCompleto.Size = New Size(142, 23)
        btAnalizadorCompleto.TabIndex = 2
        btAnalizadorCompleto.Text = "Analizador Profundo"
        btAnalizadorCompleto.UseVisualStyleBackColor = True
        ' 
        ' btnAdministradorArchivos
        ' 
        btnAdministradorArchivos.Location = New Point(12, 170)
        btnAdministradorArchivos.Name = "btnAdministradorArchivos"
        btnAdministradorArchivos.Size = New Size(142, 23)
        btnAdministradorArchivos.TabIndex = 3
        btnAdministradorArchivos.Text = "Administrador Archivos"
        btnAdministradorArchivos.UseVisualStyleBackColor = True
        ' 
        ' btnAnalizadorIntermedio
        ' 
        btnAnalizadorIntermedio.Location = New Point(12, 70)
        btnAnalizadorIntermedio.Name = "btnAnalizadorIntermedio"
        btnAnalizadorIntermedio.Size = New Size(142, 23)
        btnAnalizadorIntermedio.TabIndex = 4
        btnAnalizadorIntermedio.Text = "Analizador Intermedio"
        btnAnalizadorIntermedio.UseVisualStyleBackColor = True
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAnalizadorIntermedio)
        Controls.Add(btnAdministradorArchivos)
        Controls.Add(btAnalizadorCompleto)
        Controls.Add(btRouter)
        Controls.Add(btnAnalizadorBasico)
        Name = "FormPrincipal"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAnalizadorBasico As Button
    Friend WithEvents btRouter As Button
    Friend WithEvents btAnalizadorCompleto As Button
    Friend WithEvents btnAdministradorArchivos As Button
    Friend WithEvents btnAnalizadorIntermedio As Button

End Class
