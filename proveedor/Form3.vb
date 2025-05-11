Imports System.Data.SqlClient
Imports System.IO

Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connetionString As String
        Dim connection As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        connetionString = "Data Source=ISALIBERATO-PC;Initial Catalog=4TOaINFORMATICA;User ID=sa; password=123456789;"
        connection = New SqlConnection(connetionString)
        Try
            connection.Open()
            adapter.SelectCommand = New SqlCommand("exec pbuscarproveedor '" & Me.TextBox1.Text & "'", connection)
            adapter.Fill(ds)
            connection.Close()
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
End Class