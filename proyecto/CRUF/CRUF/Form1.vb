Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class Form1
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim conexion As conexion = New conexion

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub btinicio_Click(sender As Object, e As EventArgs) Handles btinicio.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txt_usuario.Text
        contraseña = txt_contraseña.Text
        Dim verificar As String = "Update Usuario set Usuario = Usuario where Usuario = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Administrador'"
        If conexion.Verificacion(verificar) Then
            Me.Hide()
            MsgBox("Administrador")
            admin.Show()
        Else
            Dim verificar2 As String = "Update Usuario set Usuario=Usuario where Usuario = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Usuario'"
            If conexion.Verificacion(verificar2) Then
                Me.Hide()
                MsgBox("Usuario")
                users.Show()

            Else

                Dim verificar3 As String = "Update Usuario set Usuario=Usuario where Usuario= '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Secretario'"
                If conexion.Verificacion(verificar3) Then
                    Me.Hide()
                    MsgBox("Secretariado")
                    secre.Show()
                Else
                    MsgBox("La contraseña o usuario son incorrectos intentelo nuevamente")
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                End If
            End If

        End If
    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Close()

    End Sub
End Class
