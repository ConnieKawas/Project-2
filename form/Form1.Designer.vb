<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtChemicalQuantity = New System.Windows.Forms.TextBox()
        Me.txtNamechemical = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCheUse = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExpUse = New System.Windows.Forms.TextBox()
        Me.txtExperiementDes = New System.Windows.Forms.TextBox()
        Me.txtExperimentName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExperiment = New System.Windows.Forms.TextBox()
        Me.txtChemicalformula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtChemicalid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEquipmentId = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScienceInventoryDataSet1 = New form.ScienceInventoryDataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChemicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChemicalTableAdapter = New form.ScienceInventoryDataSet1TableAdapters.chemicalTableAdapter()
        Me.EquipmentTableAdapter = New form.ScienceInventoryDataSet1TableAdapters.equipmentTableAdapter()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ChemicalTableAdapter1 = New form.ScienceInventoryDataSet1TableAdapters.chemicalTableAdapter()
        Me.DataGridViewEquipment = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScienceInventoryDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExperimentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExperimentTableAdapter = New form.ScienceInventoryDataSet1TableAdapters.experimentTableAdapter()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScienceInventoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChemicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScienceInventoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExperimentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtChemicalQuantity
        '
        Me.txtChemicalQuantity.Location = New System.Drawing.Point(217, 163)
        Me.txtChemicalQuantity.Name = "txtChemicalQuantity"
        Me.txtChemicalQuantity.Size = New System.Drawing.Size(149, 28)
        Me.txtChemicalQuantity.TabIndex = 5
        '
        'txtNamechemical
        '
        Me.txtNamechemical.Location = New System.Drawing.Point(217, 108)
        Me.txtNamechemical.Name = "txtNamechemical"
        Me.txtNamechemical.Size = New System.Drawing.Size(149, 28)
        Me.txtNamechemical.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox3.Controls.Add(Me.txtCheUse)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtExpUse)
        Me.GroupBox3.Controls.Add(Me.txtExperiementDes)
        Me.GroupBox3.Controls.Add(Me.txtExperimentName)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtExperiment)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1168, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 375)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Experiment"
        '
        'txtCheUse
        '
        Me.txtCheUse.Location = New System.Drawing.Point(192, 247)
        Me.txtCheUse.Name = "txtCheUse"
        Me.txtCheUse.Size = New System.Drawing.Size(149, 28)
        Me.txtCheUse.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 22)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "DateStarted"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ChemicalUse"
        '
        'txtExpUse
        '
        Me.txtExpUse.Location = New System.Drawing.Point(192, 199)
        Me.txtExpUse.Name = "txtExpUse"
        Me.txtExpUse.Size = New System.Drawing.Size(149, 28)
        Me.txtExpUse.TabIndex = 6
        '
        'txtExperiementDes
        '
        Me.txtExperiementDes.Location = New System.Drawing.Point(192, 149)
        Me.txtExperiementDes.Name = "txtExperiementDes"
        Me.txtExperiementDes.Size = New System.Drawing.Size(149, 28)
        Me.txtExperiementDes.TabIndex = 5
        '
        'txtExperimentName
        '
        Me.txtExperimentName.Location = New System.Drawing.Point(192, 102)
        Me.txtExperimentName.Name = "txtExperimentName"
        Me.txtExperimentName.Size = New System.Drawing.Size(149, 28)
        Me.txtExperimentName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EquipmentUse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 22)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Description"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 22)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ExperimentID"
        '
        'txtExperiment
        '
        Me.txtExperiment.Location = New System.Drawing.Point(192, 53)
        Me.txtExperiment.Name = "txtExperiment"
        Me.txtExperiment.Size = New System.Drawing.Size(149, 28)
        Me.txtExperiment.TabIndex = 2
        '
        'txtChemicalformula
        '
        Me.txtChemicalformula.Location = New System.Drawing.Point(217, 215)
        Me.txtChemicalformula.Name = "txtChemicalformula"
        Me.txtChemicalformula.Size = New System.Drawing.Size(149, 28)
        Me.txtChemicalformula.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Chemical Formula"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Controls.Add(Me.txtChemicalformula)
        Me.GroupBox2.Controls.Add(Me.txtChemicalQuantity)
        Me.GroupBox2.Controls.Add(Me.txtNamechemical)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtChemicalid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(635, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 388)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chemical"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ChemicalID"
        '
        'txtChemicalid
        '
        Me.txtChemicalid.Location = New System.Drawing.Point(217, 56)
        Me.txtChemicalid.Name = "txtChemicalid"
        Me.txtChemicalid.Size = New System.Drawing.Size(149, 28)
        Me.txtChemicalid.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, -90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(684, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Science Laboratory Inventory Management System"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Teal
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(223, 570)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(84, 54)
        Me.BtnDelete.TabIndex = 18
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Teal
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(344, 570)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(88, 54)
        Me.BtnUpdate.TabIndex = 17
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.Teal
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Location = New System.Drawing.Point(472, 570)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 54)
        Me.BtnView.TabIndex = 16
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.txtEquipmentId)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 388)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment"
        '
        'txtEquipmentId
        '
        Me.txtEquipmentId.Location = New System.Drawing.Point(192, 59)
        Me.txtEquipmentId.Name = "txtEquipmentId"
        Me.txtEquipmentId.Size = New System.Drawing.Size(149, 28)
        Me.txtEquipmentId.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(192, 245)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(149, 28)
        Me.txtDescription.TabIndex = 6
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(192, 166)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(149, 28)
        Me.txtQuantity.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(192, 102)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(149, 28)
        Me.txtName.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 22)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EquipmentID"
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "equipment"
        Me.EquipmentBindingSource.DataSource = Me.ScienceInventoryDataSet1
        '
        'ScienceInventoryDataSet1
        '
        Me.ScienceInventoryDataSet1.DataSetName = "ScienceInventoryDataSet1"
        Me.ScienceInventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.LabItemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1756, 33)
        Me.MenuStrip1.TabIndex = 24
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
        'ChemicalBindingSource
        '
        Me.ChemicalBindingSource.DataMember = "chemical"
        Me.ChemicalBindingSource.DataSource = Me.ScienceInventoryDataSet1
        '
        'ChemicalTableAdapter
        '
        Me.ChemicalTableAdapter.ClearBeforeFill = True
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.Location = New System.Drawing.Point(1334, 359)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'ChemicalTableAdapter1
        '
        Me.ChemicalTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewEquipment
        '
        Me.DataGridViewEquipment.AutoGenerateColumns = False
        Me.DataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEquipment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridViewEquipment.DataSource = Me.EquipmentBindingSource1
        Me.DataGridViewEquipment.Location = New System.Drawing.Point(598, 478)
        Me.DataGridViewEquipment.Name = "DataGridViewEquipment"
        Me.DataGridViewEquipment.RowTemplate.Height = 28
        Me.DataGridViewEquipment.Size = New System.Drawing.Size(677, 216)
        Me.DataGridViewEquipment.TabIndex = 25
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'EquipmentBindingSource1
        '
        Me.EquipmentBindingSource1.DataMember = "equipment"
        Me.EquipmentBindingSource1.DataSource = Me.ScienceInventoryDataSet1BindingSource
        '
        'ScienceInventoryDataSet1BindingSource
        '
        Me.ScienceInventoryDataSet1BindingSource.DataSource = Me.ScienceInventoryDataSet1
        Me.ScienceInventoryDataSet1BindingSource.Position = 0
        '
        'ExperimentBindingSource
        '
        Me.ExperimentBindingSource.DataMember = "experiment"
        Me.ExperimentBindingSource.DataSource = Me.ScienceInventoryDataSet1BindingSource
        '
        'ExperimentTableAdapter
        '
        Me.ExperimentTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1756, 722)
        Me.Controls.Add(Me.DataGridViewEquipment)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScienceInventoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChemicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScienceInventoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExperimentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChemicalQuantity As TextBox
    Friend WithEvents txtNamechemical As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCheUse As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExpUse As TextBox
    Friend WithEvents txtExperiementDes As TextBox
    Friend WithEvents txtExperimentName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExperiment As TextBox
    Friend WithEvents txtChemicalformula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtChemicalid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScienceInventoryDataSet1 As ScienceInventoryDataSet1
    Friend WithEvents ChemicalBindingSource As BindingSource
    Friend WithEvents ChemicalTableAdapter As ScienceInventoryDataSet1TableAdapters.chemicalTableAdapter
    Friend WithEvents EquipmentBindingSource As BindingSource
    Friend WithEvents EquipmentTableAdapter As ScienceInventoryDataSet1TableAdapters.equipmentTableAdapter
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ChemicalTableAdapter1 As ScienceInventoryDataSet1TableAdapters.chemicalTableAdapter
    Friend WithEvents txtEquipmentId As TextBox
    Friend WithEvents DataGridViewEquipment As DataGridView
    Friend WithEvents ScienceInventoryDataSet1BindingSource As BindingSource
    Friend WithEvents ExperimentBindingSource As BindingSource
    Friend WithEvents ExperimentTableAdapter As ScienceInventoryDataSet1TableAdapters.experimentTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentBindingSource1 As BindingSource
End Class
