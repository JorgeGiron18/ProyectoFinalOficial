﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DirectionXml
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirectionXml))
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtDir1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.PictureBox()
        Me.btnCrearXml = New System.Windows.Forms.PictureBox()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCrearXml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDir.Location = New System.Drawing.Point(23, 49)
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(354, 32)
        Me.txtDir.TabIndex = 0
        '
        'txtDir1
        '
        Me.txtDir1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtDir1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDir1.Location = New System.Drawing.Point(23, 128)
        Me.txtDir1.Multiline = True
        Me.txtDir1.Name = "txtDir1"
        Me.txtDir1.Size = New System.Drawing.Size(354, 30)
        Me.txtDir1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Direccion de la Plantilla PDF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Direccion de las Solicitudes:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = Global.REGSI.My.Resources.Resources.ACEPTAR
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(62, 190)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 50)
        Me.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.TabStop = False
        '
        'btnCrearXml
        '
        Me.btnCrearXml.BackgroundImage = Global.REGSI.My.Resources.Resources.CREARXML
        Me.btnCrearXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearXml.Image = Global.REGSI.My.Resources.Resources.ACEPTAR
        Me.btnCrearXml.Location = New System.Drawing.Point(235, 190)
        Me.btnCrearXml.Name = "btnCrearXml"
        Me.btnCrearXml.Size = New System.Drawing.Size(100, 50)
        Me.btnCrearXml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCrearXml.TabIndex = 2
        Me.btnCrearXml.TabStop = False
        '
        'DirectionXml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 265)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCrearXml)
        Me.Controls.Add(Me.txtDir1)
        Me.Controls.Add(Me.txtDir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DirectionXml"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DirectionXml"
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCrearXml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtDir1 As TextBox
    Friend WithEvents btnCrearXml As PictureBox
    Friend WithEvents btnAceptar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
