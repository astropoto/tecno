Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class admin
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String
    Sub ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from  usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        sentencia = "Insert into usuario values('" + txt_usuario.Text + "', '" + txt_contra.Text + "', '" + tx_rol.Text + "')"
        mensaje = "Datos ingresados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub



    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete  usuario where Usuario = '" + txt_usuario.Text + "'"
        mensaje = "datos eliminados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from  usuario ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim da As New SqlDataAdapter("select * from  ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






End Class