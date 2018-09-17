Imports System.Data.OleDb
Public Class Form2

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\Users\mousaghannnam\source\repos\CampbellBonuses\CampbellBonuses\CampbellBonuses.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        Dim str As String
        str = "insert into EmployeeInformation ([First_Name], [Last_Name], [StartDate], [PhoneNumber], [Email]) values (?, ?, ?, ?, ?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        myConnection.Open()



        With cmd.Parameters
            .AddWithValue("First_Name", TextBox1.Text)
            .AddWithValue("Last_Name", TextBox2.Text)
            .AddWithValue("StartDate", Today.Date)
            .AddWithValue("PhoneNumber", TextBox3.Text)
            .AddWithValue("Email", TextBox4.Text)
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

        MsgBox("Thank you, " + TextBox1.Text + ", your profile was succesfully saved. Please exit and reopen the program to access your profile. ")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class