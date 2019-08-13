Imports System.Xml

Public Class DirectionXml
    Private Sub BtnCrearXml_Click(sender As Object, e As EventArgs) Handles btnCrearXml.Click
        If txtDir.Text = "" And txtDir1.Text = "" Then
            MessageBox.Show("No ha ingresado la dirreccion del archivo y la direccion del pdf")
        Else
            Dim Doc As New XmlDocument, direct, direct1 As XmlNode
            direct = Doc.CreateElement("Direccion")

            Doc.AppendChild(direct)
            direct = Doc.CreateElement("Direccion")
            direct.InnerText = txtDir.Text
            Doc.DocumentElement.AppendChild(direct)

            direct1 = Doc.CreateElement("Direccion")
            direct1.InnerText = txtDir1.Text
            Doc.DocumentElement.AppendChild(direct1)

            Doc.Save(Application.StartupPath & "\Direccion.xml")

            Me.Dispose()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub TxtDir_TextChanged(sender As Object, e As EventArgs) Handles txtDir.TextChanged

    End Sub

    Private Sub DirectionXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Doc As New XmlDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer = 0
        Doc.Load(Application.StartupPath & "\Direccion.xml")
        xmlnode = Doc.GetElementsByTagName("Direccion")
        txtDir1.Text = xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
        txtDir.Text = xmlnode(i).ChildNodes.Item(1).InnerText.Trim()
    End Sub
End Class