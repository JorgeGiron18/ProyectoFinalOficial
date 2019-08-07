﻿Imports System
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


        If txtCuenta.Text = "" Then
            MessageBox.Show("Favor Completar El Formulario")
        Else


            Dim pdfTemplate As String = "C:\Users\Estudiante\Dropbox\REG-PS.505 Solicitud de Solvencias.pdf"
            Dim newFile As String = "C:\Users\Estudiante\Dropbox\Solvencias\Pendientes\" & txtCuenta.Text & Correlativo & ".pdf"
            '   Dim pdfTemplate As String = "D:\FORMULARIO SOLVENCIA\REG-PS.505 Solicitud de Solvencias.pdf"
            '  Dim newFile As String = "C:\Users\Wasaby\Documents\Datos\Solvencias\" & txtCuenta.Text & Correlativo & ".pdf"
            Dim pdfReader As New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
                newFile, FileMode.Create))
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields
            Dim pcbContent As PdfContentByte = Nothing
            ' Dim img As System.Drawing.Image = System.Drawing.Image.FromFile("C:\Firmas\Firma.bmp")
            Dim sap As PdfSignatureAppearance = pdfStamper.SignatureAppearance
            Dim rect As iTextSharp.text.Rectangle = Nothing
            Dim imagen As iTextSharp.text.Image
            Dim loc As String

            loc = "C:\Firmas\Firma.bmp"
            imagen = iTextSharp.text.Image.GetInstance(loc)
            imagen.SetAbsolutePosition(389, 92)
            imagen.ScaleToFit(130, 130)
            pcbContent = pdfStamper.GetUnderContent(1)
            pcbContent.AddImage(imagen)

            ' set form pdfFormFields
            pdfFormFields.SetField("Cuenta", txtCuenta.Text)
            pdfFormFields.SetField("Carrera", cmbCarrera.Text)
            pdfFormFields.SetField("Nombre", txtNombre.Text)
            pdfFormFields.SetField("RazonOtro", txtEspecificaciones.Text)
            pdfFormFields.SetField("Fecha_5", lblFecha.Text)
            pdfFormFields.SetField("Tel", txtTelefono.Text)
            pdfFormFields.SetField("Email", txtCorreo.Text)
            pdfFormFields.SetField("Campus", cmbCampus.Text)
            pdfFormFields.SetField("CampusDestino", cmbCdestino.Text)
            pdfFormFields.SetField("Recibo", txtNrecibo.Text)
            'pdfFormFields.SetField("signature5", TextBox1.Text)

            ' The form's checkboxes
            If ckbSAsignatura.Checked = True Then
                pdfFormFields.SetField("Contenidos", "On")
            End If

            If chbCertificadoE.Checked = True Then
                pdfFormFields.SetField("Certificado", "On")
            End If

            If chbContaciaA.Checked = True Then
                pdfFormFields.SetField("Constancia", "On")
            End If

            If CheckBox4.Checked = True Then
                pdfFormFields.SetField("Graduacion", "On")
            End If

            If CheckBox5.Checked = True Then
                pdfFormFields.SetField("Practica", "On")
            End If

            If CheckBox6.Checked = True Then
                pdfFormFields.SetField("Traslado", "On")
            End If

            If CheckBox7.Checked = True Then
                pdfFormFields.SetField("Abandono", "On")
            End If

            If CheckBox8.Checked = True Then
                pdfFormFields.SetField("Cancelacion", "On")
            End If

            If CheckBox9.Checked = True Then
                pdfFormFields.SetField("Retiro", "On")
            End If

            If CheckBox10.Checked = True Then
                pdfFormFields.SetField("Normas", "On")
            End If

            If CheckBox11.Checked = True Then
                pdfFormFields.SetField("Otros", "On")
            End If

            If CheckBox12.Checked = True Then
                pdfFormFields.SetField("Salud", "On")
            End If

            If CheckBox13.Checked = True Then
                pdfFormFields.SetField("Trabajo", "On")
            End If

            If CheckBox14.Checked = True Then
                pdfFormFields.SetField("Economicos", "On")
            End If

            If CheckBox15.Checked = True Then
                pdfFormFields.SetField("Otros_2", "On")
            End If

            If CheckBox16.Checked = True Then
                pdfFormFields.SetField("Reintegro", "On")
            End If

            If RadioButton1.Checked = True Then
                pdfFormFields.SetField("Beca Si", "On")
            End If
            If RadioButton2.Checked = True Then
                pdfFormFields.SetField("BecasTexto", "N/A")
            End If


            MessageBox.Show("Datos Guardados Satisfactoriamente")

            ' flatten the form to remove editting options, set it to false
            ' to leave the form open to subsequent manual edits
            pdfStamper.FormFlattening = False

            ' close the pdf
            pdfStamper.Close()


            txtCuenta.Text = ""
            cmbCarrera.SelectedIndex = -1
            cmbCarrera.SelectedIndex = -1
            txtNombre.Text = ""
            txtTelefono.Text = ""
            txtCorreo.Text = ""
            txtNrecibo.Text = ""
            ckbSAsignatura.CheckState = 0
            chbCertificadoE.CheckState = 0
            chbContaciaA.CheckState = 0
            CheckBox4.CheckState = 0
            CheckBox5.CheckState = 0
            CheckBox6.CheckState = 0
            CheckBox7.CheckState = 0
            CheckBox8.CheckState = 0
            CheckBox9.CheckState = 0
            CheckBox10.CheckState = 0
            CheckBox11.CheckState = 0
            CheckBox12.CheckState = 0
            CheckBox13.CheckState = 0
            CheckBox14.CheckState = 0
            CheckBox15.CheckState = 0
            txtEspecificaciones.Text = ""
            txtEspecificaciones.Enabled = False



            Me.Close()

        End If
    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCarrera.Text = "Arquitectura"
        cmbCampus.Text = "San Isidro - La Ceiba"
        TabControl1.SelectedTab = TabPage1
        RadioButton2.Checked = True

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


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

        Dim theText As String = txtNombre.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtNombre.SelectionStart
        Dim Change As Integer
        Dim charactersDisallowed As String = "1234567890"


        For x As Integer = 0 To txtNombre.Text.Length - 1
            Letter = txtNombre.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        txtNombre.Text = theText
        txtNombre.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If txtCuenta.Text = "" Then
            ErrorProvider1.SetError(txtCuenta, MessageBox.Show("Campo Obligatorio Vacio!!"))
        Else
            If txtCuenta.TextLength < 13 Then
                MessageBox.Show("Numero de Cuenta Invalido !!")
            Else
                If CheckBox12.Checked = True And txtEspecificaciones.Text = "" Then
                    btnSiguiente.Enabled = False
                    ErrorProvider2.SetError(txtEspecificaciones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                Else
                    If CheckBox13.Checked = True And txtEspecificaciones.Text = "" Then
                        btnSiguiente.Enabled = False
                        ErrorProvider2.SetError(txtEspecificaciones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                    Else
                        If CheckBox14.Checked = True And txtEspecificaciones.Text = "" Then
                            btnSiguiente.Enabled = False
                            ErrorProvider2.SetError(txtEspecificaciones, MessageBox.Show("Campo Obligatorio Vacio!!"))
                        Else
                            If CheckBox15.Checked = True And txtEspecificaciones.Text = "" Then
                                btnSiguiente.Enabled = False
                                ErrorProvider2.SetError(txtEspecificaciones, MessageBox.Show("Campo Obligatorio Vacio!!"))
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

    Private Sub TxtCorreo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            cmbCdestino.Enabled = True
            Correlativo = "TL1"
        Else
            cmbCdestino.Text = ""
            cmbCdestino.Enabled = False
            Correlativo = ""
        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbSAsignatura.CheckedChanged
        If ckbSAsignatura.CheckState = CheckState.Checked Then
            Correlativo = "SOL1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbCertificadoE.CheckedChanged
        If chbCertificadoE.CheckState = CheckState.Checked Then
            Correlativo = "CE1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbContaciaA.CheckedChanged
        If chbContaciaA.CheckState = CheckState.Checked Then
            Correlativo = "CA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = CheckState.Checked Then
            Correlativo = "GRA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.CheckState = CheckState.Checked Then
            Correlativo = "PRA1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.CheckState = CheckState.Checked Then
            Correlativo = "RTEM1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.CheckState = CheckState.Checked Then
            Correlativo = "CAN1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.CheckState = CheckState.Checked Then
            Correlativo = "RTOT1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.CheckState = CheckState.Checked Then
            Correlativo = "RTOT1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.CheckState = CheckState.Checked Then
            Correlativo = "RI1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.CheckState = CheckState.Checked Then
            Correlativo = "SOL1"
        Else
            Correlativo = ""
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

    End Sub
End Class
