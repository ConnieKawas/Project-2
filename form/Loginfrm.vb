'Adam Shahmizi Bin Suhaimi(20DDT21F2036)
'Irdina Nurina Binti Abdullah (20DDT21F1035) 
'Connie Kawas (20DDT21F2030)
Imports System.Data.SqlClient
Public Class Loginfrm
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=ScienceInventory;User Id=sa;Password=yoongi;"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM login WHERE username=@username And password=@password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)
            connection.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Form1.Show()
            Else
                MsgBox("Unauthorized User")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class