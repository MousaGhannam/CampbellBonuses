Imports System.Data.OleDb

Public Class mainWindow
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim addedBonuses As New DataTable


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"
        connString = provider & dataFile

        'For Employee Information
        Dim cnn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        cnn.ConnectionString = connString

        'For Incentives Information
        Dim cnn2 As New OleDb.OleDbConnection
        Dim cmd2 As New OleDb.OleDbCommand
        Dim da2 As New OleDb.OleDbDataAdapter
        cnn2.ConnectionString = connString
        cnn.Open()
        'EmployeeInformation Command
        With cmd
            .Connection = cnn
            .CommandText = "Select * from EmployeeInformation"
        End With
        'For Employee Information
        Dim dt As New DataTable
        da.SelectCommand = cmd
        'it fills the da values into the data table
        da.Fill(dt)
        'dt provides the data source of combobox
        With ComboBox1
            .DataSource = dt
            'specify the what to display
            .DisplayMember = "First_Name"
            'and the value
            .ValueMember = "EID"
        End With
        cnn.Close()

        cnn2.Open()
        'IncentivesInformation Command
        With cmd2
            .Connection = cnn2
            .CommandText = "Select * from IncentivesInformation"
        End With

        'For Incentives Information
        Dim dt2 As New DataTable
        da2.SelectCommand = cmd2
        'it fills the da values into the data table
        da2.Fill(dt2)
        'dt provides the data source of combobox


        With ComboBox2
            .DataSource = dt2
            'specify the what to display
            .DisplayMember = "Procedure"
            'and the value
            .ValueMember = "ID"
        End With
        cnn2.Close()
        'Creating the columns for the datatable
        addedBonuses.Columns.Add("EID", Type.GetType("System.Double"))
        addedBonuses.Columns.Add("IncentiveID", Type.GetType("System.Double"))
        addedBonuses.Columns.Add("ProcedureDate", Type.GetType("System.DateTime"))
        addedBonuses.Columns.Add("PatientFirstName", Type.GetType("System.String"))
        addedBonuses.Columns.Add("PatientLastName", Type.GetType("System.String"))
        addedBonuses.Columns.Add("PatientID", Type.GetType("System.Double"))
        DataGridView1.DataSource = addedBonuses

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"
        connString = provider & dataFile
        Dim thisDate As Date
        thisDate = Today
        myConnection.ConnectionString = connString
        Dim str As String
        str = "insert into EmployeeBonus ([EID], [IncentiveID], [ProcedureDate], [PatientFirstName], [PatientLastName], [PatientID]) values (?, ?, ?, ?, ?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        myConnection.Open()



        With cmd.Parameters
            .AddWithValue("EID", Convert.ToInt32(ComboBox1.SelectedValue))
            .AddWithValue("IncentiveID", Convert.ToInt32(ComboBox2.SelectedValue))
            .AddWithValue("ProcedureDate", thisDate.Date)
            .AddWithValue("PatientFirstName", txtPFname.Text)
            .AddWithValue("PatientLastName", txtPLname.Text)
            .AddWithValue("PatientID", Convert.ToInt32(TextBox1.Text))
        End With


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            'TextBox1.Clear()
            'TextBox2.Clear()
            'TextBox3.Clear()
            'TextBox4.Clear()
            'TextBox5.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rowIndex As New Int64
        rowIndex = DataGridView1.CurrentCell.RowIndex
        addedBonuses.Rows(rowIndex).Delete()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Employee_BonusTableAdapter.Fill(Me.CampbellBonusesDataSet.Employee_Bonus)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addedBonuses.Rows.Add(Convert.ToInt32(ComboBox1.SelectedValue), Convert.ToInt32(ComboBox2.SelectedValue), Today.Date, txtPFname.Text, txtPLname.Text, Convert.ToInt32(TextBox1.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        Dim str As String
        str = "insert into EmployeeBonus ([EID], [IncentiveID], [ProcedureDate], [PatientFirstName], [PatientLastName], [PatientID]) values (?, ?, ?, ?, ?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        myConnection.Open()
        For Each row As DataRow In addedBonuses.Rows
            With cmd.Parameters
                cmd.Parameters.Clear()
                .AddWithValue("EID", row.Item("EID"))
                .AddWithValue("IncentiveID", row("IncentiveID"))
                .AddWithValue("ProcedureDate", row("ProcedureDate"))
                .AddWithValue("PatientFirstName", row("PatientFirstName"))
                .AddWithValue("PatientLastName", row("PatientLastName"))
                .AddWithValue("PatientID", row("PatientID"))
                cmd.ExecuteNonQuery()

            End With
        Next
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

    End Sub
End Class
