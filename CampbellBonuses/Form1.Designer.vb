<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.lblID = New System.Windows.Forms.Label()
        Me.Employee_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampbellBonusesDataSet = New CampbellBonuses.CampbellBonusesDataSet()
        Me.IncentivesInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncentivesInformationTableAdapter = New CampbellBonuses.CampbellBonusesDataSetTableAdapters.IncentivesInformationTableAdapter()
        Me.TableAdapterManager = New CampbellBonuses.CampbellBonusesDataSetTableAdapters.TableAdapterManager()
        Me.Employee_InformationTableAdapter = New CampbellBonuses.CampbellBonusesDataSetTableAdapters.Employee_InformationTableAdapter()
        Me.IncentivesInformationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncentivesInformationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtWelcome = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmployeeInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampbellBonusesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPFname = New System.Windows.Forms.TextBox()
        Me.txtPLname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Employee_BonusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_BonusTableAdapter = New CampbellBonuses.CampbellBonusesDataSetTableAdapters.Employee_BonusTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssistantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeBonusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampbellBonusesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncentivesInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncentivesInformationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncentivesInformationBindingNavigator.SuspendLayout()
        CType(Me.EmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampbellBonusesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_BonusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBonusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblID.Location = New System.Drawing.Point(48, 119)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(52, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Assistant "
        '
        'Employee_InformationBindingSource
        '
        Me.Employee_InformationBindingSource.DataMember = "Employee Information"
        Me.Employee_InformationBindingSource.DataSource = Me.CampbellBonusesDataSet
        '
        'CampbellBonusesDataSet
        '
        Me.CampbellBonusesDataSet.DataSetName = "CampbellBonusesDataSet"
        Me.CampbellBonusesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncentivesInformationBindingSource
        '
        Me.IncentivesInformationBindingSource.DataMember = "IncentivesInformation"
        Me.IncentivesInformationBindingSource.DataSource = Me.CampbellBonusesDataSet
        '
        'IncentivesInformationTableAdapter
        '
        Me.IncentivesInformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_BonusTableAdapter = Nothing
        Me.TableAdapterManager.Employee_InformationTableAdapter = Me.Employee_InformationTableAdapter
        Me.TableAdapterManager.IncentivesInformationTableAdapter = Me.IncentivesInformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = CampbellBonuses.CampbellBonusesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Employee_InformationTableAdapter
        '
        Me.Employee_InformationTableAdapter.ClearBeforeFill = True
        '
        'IncentivesInformationBindingNavigator
        '
        Me.IncentivesInformationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IncentivesInformationBindingNavigator.BindingSource = Me.IncentivesInformationBindingSource
        Me.IncentivesInformationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IncentivesInformationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IncentivesInformationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IncentivesInformationBindingNavigatorSaveItem})
        Me.IncentivesInformationBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.IncentivesInformationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IncentivesInformationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IncentivesInformationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IncentivesInformationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IncentivesInformationBindingNavigator.Name = "IncentivesInformationBindingNavigator"
        Me.IncentivesInformationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IncentivesInformationBindingNavigator.Size = New System.Drawing.Size(961, 25)
        Me.IncentivesInformationBindingNavigator.TabIndex = 2
        Me.IncentivesInformationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IncentivesInformationBindingNavigatorSaveItem
        '
        Me.IncentivesInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IncentivesInformationBindingNavigatorSaveItem.Image = CType(resources.GetObject("IncentivesInformationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IncentivesInformationBindingNavigatorSaveItem.Name = "IncentivesInformationBindingNavigatorSaveItem"
        Me.IncentivesInformationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IncentivesInformationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtWelcome
        '
        Me.txtWelcome.AutoSize = True
        Me.txtWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWelcome.Location = New System.Drawing.Point(30, 55)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(262, 42)
        Me.txtWelcome.TabIndex = 4
        Me.txtWelcome.Text = "Bonus Tracker"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_InformationBindingSource, "EID", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'EmployeeInformationBindingSource
        '
        Me.EmployeeInformationBindingSource.DataMember = "Employee Information"
        Me.EmployeeInformationBindingSource.DataSource = Me.CampbellBonusesDataSetBindingSource
        '
        'CampbellBonusesDataSetBindingSource
        '
        Me.CampbellBonusesDataSetBindingSource.DataSource = Me.CampbellBonusesDataSet
        Me.CampbellBonusesDataSetBindingSource.Position = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(63, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bonus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(7, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Patient First Name "
        '
        'txtPFname
        '
        Me.txtPFname.Location = New System.Drawing.Point(106, 143)
        Me.txtPFname.Name = "txtPFname"
        Me.txtPFname.Size = New System.Drawing.Size(112, 20)
        Me.txtPFname.TabIndex = 9
        '
        'txtPLname
        '
        Me.txtPLname.Location = New System.Drawing.Point(106, 169)
        Me.txtPLname.Name = "txtPLname"
        Me.txtPLname.Size = New System.Drawing.Size(112, 20)
        Me.txtPLname.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(7, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Patient Last Name "
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(237, 162)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(237, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(237, 133)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add "
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Employee_BonusBindingSource
        '
        Me.Employee_BonusBindingSource.DataMember = "Employee Bonus"
        Me.Employee_BonusBindingSource.DataSource = Me.CampbellBonusesDataSet
        '
        'Employee_BonusTableAdapter
        '
        Me.Employee_BonusTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(106, 195)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(46, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Patient ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.AssistantToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryByToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'SummaryByToolStripMenuItem
        '
        Me.SummaryByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem})
        Me.SummaryByToolStripMenuItem.Name = "SummaryByToolStripMenuItem"
        Me.SummaryByToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SummaryByToolStripMenuItem.Text = "Summary By"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateRangeToolStripMenuItem, Me.WeekToolStripMenuItem, Me.MonthToolStripMenuItem, Me.DayToolStripMenuItem})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.DateToolStripMenuItem.Text = "Date"
        '
        'DateRangeToolStripMenuItem
        '
        Me.DateRangeToolStripMenuItem.Name = "DateRangeToolStripMenuItem"
        Me.DateRangeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DateRangeToolStripMenuItem.Text = "Custom Range"
        '
        'WeekToolStripMenuItem
        '
        Me.WeekToolStripMenuItem.Name = "WeekToolStripMenuItem"
        Me.WeekToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WeekToolStripMenuItem.Text = "Week"
        '
        'MonthToolStripMenuItem
        '
        Me.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        Me.MonthToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MonthToolStripMenuItem.Text = "Month"
        '
        'DayToolStripMenuItem
        '
        Me.DayToolStripMenuItem.Name = "DayToolStripMenuItem"
        Me.DayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DayToolStripMenuItem.Text = "Day"
        '
        'AssistantToolStripMenuItem
        '
        Me.AssistantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewToolStripMenuItem, Me.EditProfileToolStripMenuItem})
        Me.AssistantToolStripMenuItem.Name = "AssistantToolStripMenuItem"
        Me.AssistantToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AssistantToolStripMenuItem.Text = "Assistant"
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreateNewToolStripMenuItem.Text = "New"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(887, 150)
        Me.DataGridView1.TabIndex = 23
        '
        'EmployeeBonusBindingSource
        '
        Me.EmployeeBonusBindingSource.DataMember = "Employee Bonus"
        Me.EmployeeBonusBindingSource.DataSource = Me.CampbellBonusesDataSetBindingSource
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(237, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "batchSave"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(961, 472)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtPLname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPFname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtWelcome)
        Me.Controls.Add(Me.IncentivesInformationBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblID)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainWindow"
        Me.Text = "&OK"
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampbellBonusesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncentivesInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncentivesInformationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncentivesInformationBindingNavigator.ResumeLayout(False)
        Me.IncentivesInformationBindingNavigator.PerformLayout()
        CType(Me.EmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampbellBonusesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_BonusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBonusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents CampbellBonusesDataSet As CampbellBonusesDataSet
    Friend WithEvents IncentivesInformationBindingSource As BindingSource
    Friend WithEvents IncentivesInformationTableAdapter As CampbellBonusesDataSetTableAdapters.IncentivesInformationTableAdapter
    Friend WithEvents TableAdapterManager As CampbellBonusesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IncentivesInformationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IncentivesInformationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Employee_InformationTableAdapter As CampbellBonusesDataSetTableAdapters.Employee_InformationTableAdapter
    Friend WithEvents txtWelcome As Label
    Friend WithEvents Employee_InformationBindingSource As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPFname As TextBox
    Friend WithEvents txtPLname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Employee_BonusBindingSource As BindingSource
    Friend WithEvents Employee_BonusTableAdapter As CampbellBonusesDataSetTableAdapters.Employee_BonusTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents EmployeeInformationBindingSource As BindingSource
    Friend WithEvents CampbellBonusesDataSetBindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssistantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateRangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeeBonusBindingSource As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
End Class
