'Adam Shahmizi Bin Suhaimi(20DDT21F2036)
'Irdina Nurina Binti Abdullah (20DDT21F1035) 
'Connie Kawas (20DDT21F2030)
Public Class Labfrm
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Loginfrm.Show()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub Labfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet.Experiment' table. You can move, or remove it, as needed.
        Me.ExperimentTableAdapter.Fill(Me.ScienceInventoryDataSet.Experiment)
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet.Chemical' table. You can move, or remove it, as needed.
        Me.ChemicalTableAdapter.Fill(Me.ScienceInventoryDataSet.Chemical)
        'TODO: This line of code loads data into the 'ScienceInventoryDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.ScienceInventoryDataSet.Equipment)

    End Sub
End Class