Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class secre
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
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        sentencia = "Insert into ADMINISTRADOR values('" + tx_id.Text + "','" + txt_usuario.Text + "', '" + txt_contra.Text + "', '" + tx_rol.Text + "')"
        mensaje = "Datos ingresados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRADOR ", con)
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim da As New SqlDataAdapter("Select *from ADMINISTRADOR where ID = '" + tx_id.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.GunaDataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class