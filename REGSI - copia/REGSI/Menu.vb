Imports WindowsApplication1
Public Class Menu
    Dim Solvencia As New WindowsApplication1.Form1
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Solvencia.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        XmlVersiculo.ShowDialog()

    End Sub
End Class