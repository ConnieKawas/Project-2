<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Labfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Labfrm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScienceInventoryDataSet = New form.ScienceInventoryDataSet()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentTableAdapter = New form.ScienceInventoryDataSetTableAdapters.EquipmentTableAdapter()
        Me.EquipmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChemicalTableAdapter = New form.ScienceInventoryDataSetTableAdapters.ChemicalTableAdapter()
        Me.ChemicalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemicalFormulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperimentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExperimentTableAdapter = New form.ScienceInventoryDataSetTableAdapters.ExperimentTableAdapter()
        Me.ExperimentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemicalUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStartedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ScienceInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExperimentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EquipmentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EquipmentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(533, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChemicalIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.ChemicalFormulaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ChemicalBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(772, 98)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(533, 236)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExperimentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn2, Me.DescriptionDataGridViewTextBoxColumn1, Me.EquipmentUsedDataGridViewTextBoxColumn, Me.ChemicalUsedDataGridViewTextBoxColumn, Me.DateStartedDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ExperimentBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(304, 340)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.Size = New System.Drawing.Size(722, 236)
        Me.DataGridView3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(461, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(835, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Science Laboratory Inventory Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.LabItemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1818, 33)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'LabItemToolStripMenuItem
        '
        Me.LabItemToolStripMenuItem.Name = "LabItemToolStripMenuItem"
        Me.LabItemToolStripMenuItem.Size = New System.Drawing.Size(91, 29)
        Me.LabItemToolStripMenuItem.Text = "LabItem"
        '
        'ScienceInventoryDataSet
        '
        Me.ScienceInventoryDataSet.DataSetName = "ScienceInventoryDataSet"
        Me.ScienceInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        Me.EquipmentBindingSource.DataSource = Me.ScienceInventoryDataSet
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'EquipmentIDDataGridViewTextBoxColumn
        '
        Me.EquipmentIDDataGridViewTextBoxColumn.DataPropertyName = "EquipmentID"
        Me.EquipmentIDDataGridViewTextBoxColumn.HeaderText = "EquipmentID"
        Me.EquipmentIDDataGridViewTextBoxColumn.Name = "EquipmentIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'ChemicalBindingSource
        '
        Me.ChemicalBindingSource.DataMember = "Chemical"
        Me.ChemicalBindingSource.DataSource = Me.ScienceInventoryDataSet
        '
        'ChemicalTableAdapter
        '
        Me.ChemicalTableAdapter.ClearBeforeFill = True
        '
        'ChemicalIDDataGridViewTextBoxColumn
        '
        Me.ChemicalIDDataGridViewTextBoxColumn.DataPropertyName = "ChemicalID"
        Me.ChemicalIDDataGridViewTextBoxColumn.HeaderText = "ChemicalID"
        Me.ChemicalIDDataGridViewTextBoxColumn.Name = "ChemicalIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        '
        'ChemicalFormulaDataGridViewTextBoxColumn
        '
        Me.ChemicalFormulaDataGridViewTextBoxColumn.DataPropertyName = "ChemicalFormula"
        Me.ChemicalFormulaDataGridViewTextBoxColumn.HeaderText = "ChemicalFormula"
        Me.ChemicalFormulaDataGridViewTextBoxColumn.Name = "ChemicalFormulaDataGridViewTextBoxColumn"
        '
        'ExperimentBindingSource
        '
        Me.ExperimentBindingSource.DataMember = "Experiment"
        Me.ExperimentBindingSource.DataSource = Me.ScienceInventoryDataSet
        '
        'ExperimentTableAdapter
        '
        Me.ExperimentTableAdapter.ClearBeforeFill = True
        '
        'ExperimentIDDataGridViewTextBoxColumn
        '
        Me.ExperimentIDDataGridViewTextBoxColumn.DataPropertyName = "ExperimentID"
        Me.ExperimentIDDataGridViewTextBoxColumn.HeaderText = "ExperimentID"
        Me.ExperimentIDDataGridViewTextBoxColumn.Name = "ExperimentIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn2
        '
        Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        '
        'EquipmentUsedDataGridViewTextBoxColumn
        '
        Me.EquipmentUsedDataGridViewTextBoxColumn.DataPropertyName = "EquipmentUsed"
        Me.EquipmentUsedDataGridViewTextBoxColumn.HeaderText = "EquipmentUsed"
        Me.EquipmentUsedDataGridViewTextBoxColumn.Name = "EquipmentUsedDataGridViewTextBoxColumn"
        '
        'ChemicalUsedDataGridViewTextBoxColumn
        '
        Me.ChemicalUsedDataGridViewTextBoxColumn.DataPropertyName = "ChemicalUsed"
        Me.ChemicalUsedDataGridViewTextBoxColumn.HeaderText = "ChemicalUsed"
        Me.ChemicalUsedDataGridViewTextBoxColumn.Name = "ChemicalUsedDataGridViewTextBoxColumn"
        '
        'DateStartedDataGridViewTextBoxColumn
        '
        Me.DateStartedDataGridViewTextBoxColumn.DataPropertyName = "DateStarted"
        Me.DateStartedDataGridViewTextBoxColumn.HeaderText = "DateStarted"
        Me.DateStartedDataGridViewTextBoxColumn.Name = "DateStartedDataGridViewTextBoxColumn"
        '
        'Labfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1818, 630)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Labfrm"
        Me.Text = "Labfrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ScienceInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExperimentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScienceInventoryDataSet As ScienceInventoryDataSet
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents EquipmentTableAdapter As ScienceInventoryDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents EquipmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChemicalBindingSource As BindingSource
    Friend WithEvents ChemicalTableAdapter As ScienceInventoryDataSetTableAdapters.ChemicalTableAdapter
    Friend WithEvents ChemicalIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ChemicalFormulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperimentBindingSource As BindingSource
    Friend WithEvents ExperimentTableAdapter As ScienceInventoryDataSetTableAdapters.ExperimentTableAdapter
    Friend WithEvents ExperimentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChemicalUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateStartedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
