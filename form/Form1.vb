'Adam Shahmizi Bin Suhaimi(20DDT21F2036)
'Irdina Nurina Binti Abdullah (20DDT21F1035) 
'Connie Kawas (20DDT21F2030)
Imports System.Data.SqlClient
Public Class Form1
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=ScienceInventory;User Id=sa;Password=yoongi;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM [Equipment]"

        Try
            connection.Open()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
            Dim dt As DataTable = New DataTable()
            adapter.Fill(dt)

            ' Assuming you have a DataGridView named DataGridViewEquipment to display the data
            DataGridViewEquipment.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=ScienceInventory;User Id=sa;Password=yoongi;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "UPDATE [Equipment] SET Name = @name, Quantity = @quantity, Description = @description WHERE EquipmentID = @equipmentid"

        Try
            connection.Open()
            Dim command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@equipmentid", txtEquipmentId.Text)
            command.Parameters.AddWithValue("@name", txtName.Text)
            command.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            command.Parameters.AddWithValue("@description", txtDescription.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Equipment updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim connectionString As String = "Server=LAPTOP-5SV0KDBC;Database=ScienceInventory;User Id=sa;Password=yoongi;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "DELETE FROM [Equipment] WHERE EquipmentID = @equipmentid"

        Try
            connection.Open()
            Dim command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@equipmentid", txtEquipmentId)

            command.ExecuteNonQuery()
            MessageBox.Show("Equipment deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Loginfrm.Show()
    End Sub

    Private Sub LabItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabItemToolStripMenuItem.Click
        Labfrm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet1.experiment' table. You can move, or remove it, as needed.
        Me.ExperimentTableAdapter.Fill(Me.ScienceInventoryDataSet1.experiment)
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet1.equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.ScienceInventoryDataSet1.equipment)
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet1.chemical' table. You can move, or remove it, as needed.
        Me.ChemicalTableAdapter.Fill(Me.ScienceInventoryDataSet1.chemical)

    End Sub
End Class
