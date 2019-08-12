Imports System.Xml

Public Class XmlVersiculo
    Private Sub btnCrearXml_Click(sender As Object, e As EventArgs) Handles btnCrearXml.Click
        If txtBiblia.Text = "" Then
            MessageBox.Show("No ha ingresado el versiculo")
        Else
            Dim Doc As New XmlDocument, biblia As XmlNode
            biblia = Doc.CreateElement("Versiculo")

            Doc.AppendChild(biblia)
            biblia = Doc.CreateElement("Biblia")
            biblia.InnerText = txtBiblia.Text
            Doc.DocumentElement.AppendChild(biblia)
            Doc.Save(Application.StartupPath & "\Versiculo.xml")
            btnCrearXml.Text = "GuardarXML"
        End If
    End Sub

    Private Sub btnCargarXml_Click(sender As Object, e As EventArgs) Handles btnCargarXml.Click
        Dim Doc As New XmlDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer = 0
        Doc.Load(Application.StartupPath & "\Versiculo.xml")
        xmlnode = Doc.GetElementsByTagName("Versiculo")
        txtBiblia.Text = xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
        btnCrearXml.Text = "GuardarXML"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtBiblia.Text = ""
        Me.Close()
    End Sub
End Class