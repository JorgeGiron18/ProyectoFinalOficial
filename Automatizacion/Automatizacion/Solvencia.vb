Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.IO
Imports sigplusnet_vbnet_lcd15_demo
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1
    Dim firmar As New sigplusnet_vbnet_lcd15_demo.Firma
    Dim Correlativo As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If TxtBoxCuenta.Text = "" Then
            MessageBox.Show("Favor Completar El Formulario")
        Else


            'Dim pdfTemplate As String = "C:\Users\Estudiante\Dropbox\REG-PS.505 Solicitud de Solvencias.pdf"
            'Dim newFile As String = "C:\Users\Estudiante\Dropbox\Solvencias\Pendientes\" & TxtBoxCuenta.Text & Correlativo & ".pdf"
            Dim pdfTemplate As String = "C:\Users\Usuario\Downloads\ProyectoFinalOficial-master\REG-PS.505 Solicitud de Solvencias.pdf"
            Dim newFile As String = "C:\Users\Usuario\Downloads\ProyectoFinalOficial-master\Solvencias\" & TxtBoxCuenta.Text & Correlativo & ".pdf"
            Dim pdfReader As New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
                newFile, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields
            Dim pcbContent As PdfContentByte = Nothing
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile("C:\Users\Usuario\Downloads\ProyectoFinalOficial-master\Firma\Firma.bmp")
            Dim sap As PdfSignatureAppearance = pdfStamper.SignatureAppearance
            Dim rect As iTextSharp.text.Rectangle = Nothing
            Dim imagen As iTextSharp.text.Image
            Dim loc As String

            loc = "C:\Users\Usuario\Downloads\ProyectoFinalOficial-master\Firma\Firma.bmp"
            imagen = iTextSharp.text.Image.GetInstance(loc)
            imagen.SetAbsolutePosition(427, 47)
            imagen.ScaleToFit(130, 130)
            pcbContent = pdfStamper.GetUnderContent(1)
            pcbContent.AddImage(imagen)

            ' set form pdfFormFields
            pdfFormFields.SetField("Cuenta", TxtBoxCuenta.Text)
            pdfFormFields.SetField("Carrera", CmboBoxCarrera.Text)
            pdfFormFields.SetField("Nombre", TxtBoxNombreAlumno.Text)
            pdfFormFields.SetField("RazonOtro", RichTextBoxEspecificarRazones.Text)
            pdfFormFields.SetField("Fecha_5", lblFecha.Text)
            pdfFormFields.SetField("Tel", TxtTelefono.Text)
            pdfFormFields.SetField("Email", TxtCorreo.Text)
            pdfFormFields.SetField("Campus", cmbCampus.Text)
            pdfFormFields.SetField("CampusDestino", CcmbCampusDestino.Text)
            pdfFormFields.SetField("Recibo", TxtRecibo.Text)
            'pdfFormFields.SetField("signature5", TextBox1.Text)

            ' The form's checkboxes
            If CheckSyllabusAsignatura.Checked = True Then
                pdfFormFields.SetField("Contenidos", "On")
            End If

            If CheckCertificadoDeEstudio.Checked = True Then
                pdfFormFields.SetField("Certificado", "On")
            End If

            If CheckConstanciaAcademica.Checked = True Then
                pdfFormFields.SetField("Constancia", "On")
            End If

            If CheckGraduacion.Checked = True Then
                pdfFormFields.SetField("Graduacion", "On")
            End If

            If CheckInicioPractica.Checked = True Then
                pdfFormFields.SetField("Practica", "On")
            End If

            If CheckTraslado.Checked = True Then
                pdfFormFields.SetField("Traslado", "On")
            End If

            If CheckAbandonoDeLaUniversidad.Checked = True Then
                pdfFormFields.SetField("Abandono", "On")
            End If

            If CheckCancelacionDelPeriodo.Checked = True Then
                pdfFormFields.SetField("Cancelacion", "On")
            End If

            If CheckRetiroDeLaUniversidad.Checked = True Then
                pdfFormFields.SetField("Retiro", "On")
            End If

            If CheckRetiroPorNormasQueRigenLaVidaEstudiantil.Checked = True Then
                pdfFormFields.SetField("Normas", "On")
            End If

            If CheckOtros_TramitesAcademicos.Checked = True Then
                pdfFormFields.SetField("Otros", "On")
            End If

            If CheckSalud.Checked = True Then
                pdfFormFields.SetField("Salud", "On")
            End If

            If CheckTrabajo.Checked = True Then
                pdfFormFields.SetField("Trabajo", "On")
            End If

            If CheckEconomicos.Checked = True Then
                pdfFormFields.SetField("Economicos", "On")
            End If

            If CheckOtros_Razones.Checked = True Then
                pdfFormFields.SetField("Otros_2", "On")
            End If

            If CheckActivarCuentaParaReintegro.Checked = True Then
                pdfFormFields.SetField("Reintegro", "On")
            End If

            If Becado.Checked = True Then
                pdfFormFields.SetField("Beca Si", "On")
            End If

            If NoBecado.Checked = True Then
                pdfFormFields.SetField("Beca No", "Of")
            End If
            If NoBecado.Checked = True Then
                pdfFormFields.SetField("BecasTexto", "N/A")
            End If


            MessageBox.Show("Datos Guardados Satisfactoriamente")

            ' flatten the form to remove editting options, set it to false
            ' to leave the form open to subsequent manual edits
            pdfStamper.FormFlattening = False

            ' close the pdf
            pdfStamper.Close()


            TxtBoxCuenta.Text = ""
            CmboBoxCarrera.SelectedIndex = -1
            CmboBoxCarrera.SelectedIndex = -1
            TxtBoxNombreAlumno.Text = ""
            TxtTelefono.Text = ""
            TxtCorreo.Text = ""
            TxtRecibo.Text = ""
            CheckSyllabusAsignatura.CheckState = 0
            CheckCertificadoDeEstudio.CheckState = 0
            CheckConstanciaAcademica.CheckState = 0
            CheckGraduacion.CheckState = 0
            CheckInicioPractica.CheckState = 0
            CheckTraslado.CheckState = 0
            CheckAbandonoDeLaUniversidad.CheckState = 0
            CheckCancelacionDelPeriodo.CheckState = 0
            CheckRetiroDeLaUniversidad.CheckState = 0
            CheckRetiroPorNormasQueRigenLaVidaEstudiantil.CheckState = 0
            CheckOtros_TramitesAcademicos.CheckState = 0
            CheckSalud.CheckState = 0
            CheckTrabajo.CheckState = 0
            CheckEconomicos.CheckState = 0
            CheckOtros_Razones.CheckState = 0
            RichTextBoxEspecificarRazones.Text = ""
            RichTextBoxEspecificarRazones.Enabled = False



            Me.Close()

        End If
    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmboBoxCarrera.Text = "Arquitectura"
        cmbCampus.Text = "San Isidro - La Ceiba"
        TabControl1.SelectedTab = TabPage1
        NoBecado.Checked = True

        Dim fecha As Date
        fecha = Now
        lblFecha.Text = Format(fecha, "MM/dd/yyyy")
        Label20.Text = "Favor Firmar el Documento"
        Label20.ForeColor = Color.Orange
        btnGuardar.Enabled = True


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirmar.Click
        Try
            firmar.ShowDialog()
            If firmar.firmado = True Then
                Label20.Text = "El documento ha sido Firmado"
                Label20.ForeColor = Color.LimeGreen
                btnGuardar.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBoxNombreAlumno.TextChanged

        Dim theText As String = TxtBoxNombreAlumno.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtBoxNombreAlumno.SelectionStart
        Dim Change As Integer
        Dim charactersDisallowed As String = "1234567890"


        For x As Integer = 0 To TxtBoxNombreAlumno.Text.Length - 1
            Letter = TxtBoxNombreAlumno.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TxtBoxNombreAlumno.Text = theText
        TxtBoxNombreAlumno.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If TxtBoxCuenta.Text = "" Then
            ErrorProvider1.SetError(TxtBoxCuenta, MessageBox.Show("Campo Obligatorio Vacio!!"))
        Else
            If TxtBoxCuenta.TextLength < 13 Then
                MessageBox.Show("Numero de Cuenta Invalido !!")
            Else
                If CheckSalud.Checked = True And RichTextBoxEspecificarRazones.Text = "" Then
                    btnSiguiente.Enabled = False
                    ErrorProvider2.SetError(RichTextBoxEspecificarRazones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                Else
                    If CheckTrabajo.Checked = True And RichTextBoxEspecificarRazones.Text = "" Then
                        btnSiguiente.Enabled = False
                        ErrorProvider2.SetError(RichTextBoxEspecificarRazones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                    Else
                        If CheckEconomicos.Checked = True And RichTextBoxEspecificarRazones.Text = "" Then
                            btnSiguiente.Enabled = False
                            ErrorProvider2.SetError(RichTextBoxEspecificarRazones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                        Else
                            If CheckOtros_Razones.Checked = True And RichTextBoxEspecificarRazones.Text = "" Then
                                btnSiguiente.Enabled = False
                                ErrorProvider2.SetError(RichTextBoxEspecificarRazones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                            Else
                                TabControl1.SelectedTab = TabPage2
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub TxtCorreo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorreo.TextChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTraslado.CheckedChanged
        If CheckTraslado.Checked = True Then
            CcmbCampusDestino.Enabled = True
            Correlativo = "TL1"
        Else
            CcmbCampusDestino.Text = ""
            CcmbCampusDestino.Enabled = False
            Correlativo = ""
        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSyllabusAsignatura.CheckedChanged
        If CheckSyllabusAsignatura.CheckState = CheckState.Checked Then
            Correlativo = "SOL1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCertificadoDeEstudio.CheckedChanged
        If CheckCertificadoDeEstudio.CheckState = CheckState.Checked Then
            Correlativo = "CE1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckConstanciaAcademica.CheckedChanged
        If CheckConstanciaAcademica.CheckState = CheckState.Checked Then
            Correlativo = "CA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckGraduacion.CheckedChanged
        If CheckGraduacion.CheckState = CheckState.Checked Then
            Correlativo = "GRA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInicioPractica.CheckedChanged
        If CheckInicioPractica.CheckState = CheckState.Checked Then
            Correlativo = "PRA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAbandonoDeLaUniversidad.CheckedChanged
        If CheckAbandonoDeLaUniversidad.CheckState = CheckState.Checked Then
            Correlativo = "RTEM1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCancelacionDelPeriodo.CheckedChanged
        If CheckCancelacionDelPeriodo.CheckState = CheckState.Checked Then
            Correlativo = "CAN1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRetiroDeLaUniversidad.CheckedChanged
        If CheckRetiroDeLaUniversidad.CheckState = CheckState.Checked Then
            Correlativo = "RTOT1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRetiroPorNormasQueRigenLaVidaEstudiantil.CheckedChanged
        If CheckRetiroPorNormasQueRigenLaVidaEstudiantil.CheckState = CheckState.Checked Then
            Correlativo = "RTOT1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckActivarCuentaParaReintegro.CheckedChanged
        If CheckActivarCuentaParaReintegro.CheckState = CheckState.Checked Then
            Correlativo = "RI1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOtros_TramitesAcademicos.CheckedChanged
        If CheckOtros_TramitesAcademicos.CheckState = CheckState.Checked Then
            Correlativo = "SOL1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSalud.CheckedChanged

    End Sub
End Class
