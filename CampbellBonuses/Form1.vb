Imports System.Data.OleDb

Public Class mainWindow
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub IncentivesInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IncentivesInformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IncentivesInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CampbellBonusesDataSet)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\Administrator\Documents\CampbellBonuses.accdb"
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

    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\Administrator\Documents\CampbellBonuses.accdb"
        connString = provider & dataFile
        Dim thisDate As Date
        thisDate = Today
        myConnection.ConnectionString = connString
        Dim str As String
        str = "insert into EmployeeBonus ([EID], [IncentiveID], [PatientFirstName], [PatientLastName], [PatientID]) values (?, ?, ?, ?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        myConnection.Open()


        cmd.Parameters.Add(New OleDbParameter("EID", Convert.ToInt32(ComboBox1.ValueMember)))
        cmd.Parameters.Add(New OleDbParameter("IncentiveID", Convert.ToInt32(ComboBox2.ValueMember)))
        ' cmd.Parameters.Add(New OleDbParameter("ProcedureDate", OleDbType.Date)).Value = DateTime.Today
        cmd.Parameters.Add(New OleDbParameter("PatientFirstName", CType(txtPFname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PatientLastName", CType(txtPLname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PatientID", Convert.ToInt32(TextBox1.Text)))
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
        ' Try
        ' BindingNavigatorAddNewItem.PerformClick()
        'MsgBox("Deleted succesfully.")
        'ComboBox1.Visible = True
        'TextBox1.Visible = False
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPFname.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPLname.TextChanged

    End Sub

    Private Sub Employee_BonusDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) 
        Try
            Me.Employee_BonusTableAdapter.Fill(Me.CampbellBonusesDataSet.Employee_Bonus)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub IncentivesInformationBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles IncentivesInformationBindingSource.CurrentChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
