
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button1.MouseHover
        Dim conexion As New SqlConnection("Data Source=LAPTOP-AGARCIA\SQLEXPRESS;Initial Catalog=4toAInformatica;User ID=sa; password=123456789;")
        Dim command As New SqlCommand("pProductos", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ID", TextBox1.Text)
        command.Parameters.AddWithValue("@NombredelProducto", TextBox2.Text)
        command.Parameters.AddWithValue("@Vendedor", Textbox3.Text)
        command.Parameters.AddWithValue("@Telefono", TextBox4.Text)
        command.Parameters.AddWithValue("@Email", TextBox5.Text)
        command.Parameters.AddWithValue("@RNC", TextBox5.Text)
        Dim ms As New MemoryStream()
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@IMAGE", SqlDbType.Image)
        p.Value = data
        command.Parameters.AddWithValue("@IMAGE", p.Value)
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
        Throw New NotImplementedException
    End Sub

    

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox1.MouseHover

    End Sub





    Private Sub ToolStrip1_ItemClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        ToolTip.SetToolTip(Button1, "escribe el id nombre del proveedor ")

    End Sub

    Private Sub ToolStrip1_ItemClicked_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub
End Class