Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class users
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
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
            Me.GunaDataGridView1.Columns("contraseña").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim da As New SqlDataAdapter("Select *from ADMINISTRADOR where ID = '" + tx_id.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Me.GunaDataGridView1.Columns("contraseña").Visible = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class