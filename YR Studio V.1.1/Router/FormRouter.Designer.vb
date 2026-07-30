<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRouter
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
        btnEnviar = New Button()
        lblResultado = New Label()
        txtOperacion = New TextBox()
        txtRuta = New TextBox()
        cmbTarea = New ComboBox()
        lvMensajes = New ListView()
        Mensaje = New ColumnHeader()
        btnCopiarMensajes = New Button()
        lblProgreso = New Label()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' btnEnviar
        ' 
        btnEnviar.Location = New Point(12, 11)
        btnEnviar.Name = "btnEnviar"
        btnEnviar.Size = New Size(75, 23)
        btnEnviar.TabIndex = 0
        btnEnviar.Text = "Enviar"
        btnEnviar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 131)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(59, 15)
        lblResultado.TabIndex = 0
        lblResultado.Text = "Resultado"
        ' 
        ' txtOperacion
        ' 
        txtOperacion.Location = New Point(113, 12)
        txtOperacion.Name = "txtOperacion"
        txtOperacion.Size = New Size(100, 23)
        txtOperacion.TabIndex = 1
        txtOperacion.Text = "Operacion"
        ' 
        ' txtRuta
        ' 
        txtRuta.Location = New Point(113, 52)
        txtRuta.Name = "txtRuta"
        txtRuta.Size = New Size(100, 23)
        txtRuta.TabIndex = 2
        txtRuta.Text = "D:\RADIO VIRREY DEL PINO\MUSICA\CUMBIAS\AMAR AZUL\aa\01 - Dime Tú.mp3"
        ' 
        ' cmbTarea
        ' 
        cmbTarea.FormattingEnabled = True
        cmbTarea.Location = New Point(92, 91)
        cmbTarea.Name = "cmbTarea"
        cmbTarea.Size = New Size(121, 23)
        cmbTarea.TabIndex = 4
        ' 
        ' lvMensajes
        ' 
        lvMensajes.Columns.AddRange(New ColumnHeader() {Mensaje})
        lvMensajes.FullRowSelect = True
        lvMensajes.GridLines = True
        lvMensajes.Location = New Point(234, 41)
        lvMensajes.Name = "lvMensajes"
        lvMensajes.Size = New Size(404, 348)
        lvMensajes.TabIndex = 5
        lvMensajes.UseCompatibleStateImageBehavior = False
        lvMensajes.View = View.Details
        ' 
        ' Mensaje
        ' 
        Mensaje.Width = 400
        ' 
        ' btnCopiarMensajes
        ' 
        btnCopiarMensajes.Location = New Point(234, 12)
        btnCopiarMensajes.Name = "btnCopiarMensajes"
        btnCopiarMensajes.Size = New Size(109, 23)
        btnCopiarMensajes.TabIndex = 6
        btnCopiarMensajes.Text = "Copiar Mensajes"
        btnCopiarMensajes.UseVisualStyleBackColor = True
        ' 
        ' lblProgreso
        ' 
        lblProgreso.AutoSize = True
        lblProgreso.Location = New Point(12, 370)
        lblProgreso.Name = "lblProgreso"
        lblProgreso.Size = New Size(54, 15)
        lblProgreso.TabIndex = 14
        lblProgreso.Text = "Progreso"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 344)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(100, 23)
        ProgressBar1.TabIndex = 13
        ' 
        ' FormRouter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblProgreso)
        Controls.Add(ProgressBar1)
        Controls.Add(btnCopiarMensajes)
        Controls.Add(lvMensajes)
        Controls.Add(cmbTarea)
        Controls.Add(txtRuta)
        Controls.Add(txtOperacion)
        Controls.Add(lblResultado)
        Controls.Add(btnEnviar)
        Name = "FormRouter"
        Text = "FormRouter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEnviar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtOperacion As TextBox
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents cmbTarea As ComboBox
    Friend WithEvents lvMensajes As ListView
    Friend WithEvents Mensaje As ColumnHeader
    Friend WithEvents btnCopiarMensajes As Button
    Friend WithEvents lblProgreso As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
