
Imports System.Data.SqlClient
Imports System.IO
Public Class Form2


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        PictureBox1.ImageLocation = " "






    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Title = "FOTO"
        OpenFileDialog1.InitialDirectory = "C"
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button1.MouseHover
        Dim conexion As New SqlConnection("Data Source=ISALIBERATO-PC;Initial Catalog=4TOaINFORMATICA;User ID=sa; password=123456789;")
        Dim command As New SqlCommand("ptblproveedor", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ID", TextBox1.Text)
        command.Parameters.AddWithValue("@NombredelProducto", TextBox2.Text)
        command.Parameters.AddWithValue("@Vendedor", TextBox3.Text)
        command.Parameters.AddWithValue("@Telefono", TextBox4.Text)
        command.Parameters.AddWithValue("@Email", TextBox5.Text)
        command.Parameters.AddWithValue("@RNC", TextBox5.Text)
        Dim ms As New MemoryStream()
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@IMAGEN", SqlDbType.Image)
        p.Value = data
        command.Parameters.AddWithValue("@IMAGEN", p.Value)
        Try
            conexion.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            command.Dispose()
            MsgBox("Usuario Registrado Correctamente", vbInformation, "Sistema")
            LIMPIAR()
        End Try
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        PictureBox1.ImageLocation = " "

    End Sub

    

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    
   
End Class