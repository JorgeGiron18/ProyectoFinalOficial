Public NotInheritable Class AcercaDe

    Private Sub AcercaDe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = "Proyecto Final 3er Parcial"
        Me.LabelVersion.Text = "Programación en Enterno de Desarrollo Visual (IF325)"
        Me.LabelCopyright.Text = "UNICAH"

        Me.TextBoxDescription.Text = "Miembros del Grupo: 

Abdiel Misael Banegas Raudales 0205200100009
Kilby Ricardo Salgado Chacon 0201200000472
Jorge David Paz Girón 0201200001069
Lonnie Alexander Marquina Ramos 0101199902885"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelProductName_Click(sender As Object, e As EventArgs) Handles LabelProductName.Click

    End Sub
End Class
