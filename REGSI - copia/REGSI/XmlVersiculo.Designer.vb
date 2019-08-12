<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XmlVersiculo
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
        Me.btnCrearXml = New System.Windows.Forms.Button()
        Me.btnCargarXml = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtBiblia = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnCrearXml
        '
        Me.btnCrearXml.Location = New System.Drawing.Point(296, 109)
        Me.btnCrearXml.Name = "btnCrearXml"
        Me.btnCrearXml.Size = New System.Drawing.Size(123, 58)
        Me.btnCrearXml.TabIndex = 0
        Me.btnCrearXml.Text = "CrearXML"
        Me.btnCrearXml.UseVisualStyleBackColor = True
        '
        'btnCargarXml
        '
        Me.btnCargarXml.Location = New System.Drawing.Point(296, 196)
        Me.btnCargarXml.Name = "btnCargarXml"
        Me.btnCargarXml.Size = New System.Drawing.Size(123, 58)
        Me.btnCargarXml.TabIndex = 1
        Me.btnCargarXml.Text = "Cargar"
        Me.btnCargarXml.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(466, 148)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(123, 58)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtBiblia
        '
        Me.txtBiblia.Location = New System.Drawing.Point(272, 7)
        Me.txtBiblia.Name = "txtBiblia"
        Me.txtBiblia.Size = New System.Drawing.Size(283, 96)
        Me.txtBiblia.TabIndex = 4
        Me.txtBiblia.Text = ""
        '
        'XmlVersiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBiblia)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCargarXml)
        Me.Controls.Add(Me.btnCrearXml)
        Me.Name = "XmlVersiculo"
        Me.Text = "XmlVersiculo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCrearXml As Button
    Friend WithEvents btnCargarXml As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtBiblia As RichTextBox
End Class
