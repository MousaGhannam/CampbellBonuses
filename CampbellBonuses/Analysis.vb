Imports System.Data.OleDb
Public Class Analysis
    Dim myConnection As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim table As DataTable
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim searchSummery As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection = New OleDbConnection

        'Set the connection string for the connection
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"

        Dim Reader As OleDbDataReader
        ' Dim Reader2 As OleDbDataReader
        Dim IncenID As New Int32
        ' Dim IncenName As New String
        Try
            myConnection.Open()
            'Declare query string
            Dim Query As String
            Query = "Select IncentivesInformation.Procedure, COUNT(*) From IncentivesInformation INNER JOIN EmployeeBonus ON IncentivesInformation.[ID] = EmployeeBonus.[IncentiveID] Where [ProcedureDate] >= @StartDate AND [ProcedureDate] <= @EndDate AND [EID] = @AssistantID Group By IncentivesInformation.Procedure"

            'Create command object
            cmd = New OleDbCommand(Query, myConnection)

            'Using DateTimePicker1.Value returns a date with the exact time, but returning the "Value.Date. returns just the date. 
            cmd.Parameters.AddWithValue("@StartDate", DateTimePicker1.Value.Date)
            cmd.Parameters.AddWithValue("@EndDate", DateTimePicker2.Value.Date)
            cmd.Parameters.AddWithValue("@AssistantID", ComboBox1.SelectedValue)

            'Create OleDbDataReader Object by calling ExecuteReader method of OleDbCommand object
            Reader = cmd.ExecuteReader
            'Reader2 = cmd2.ExecuteReader
            While Reader.Read
                Chart1.Series("Amt of Bonus").Points.AddXY(Reader.GetString(0), Reader.GetInt32(1))
            End While
            Reader.Close()
            'Chart1.Series("Amt of Bonus").Points.AddXY(Reader.GetInt32("EID"), Reader.GetInt32("IncentiveID").
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            myConnection.Dispose()
        End Try

    End Sub

    Private Sub Analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adapter = New OleDbDataAdapter
        table = New DataTable
        cmd = New OleDbCommand
        myConnection = New OleDbConnection

        'Set the connection string for the connection
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"

        With cmd
            .CommandText = "Select * from EmployeeInformation"
            .Connection = myConnection

        End With
        adapter.SelectCommand = cmd
        adapter.Fill(table)

        With ComboBox1
            .DataSource = table
            'specify the what to display
            .DisplayMember = "First_Name"
            'and the value
            .ValueMember = "EID"
        End With
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class