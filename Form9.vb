Imports MySql.Data.MySqlClient
Public Class Form9
    Dim mysqlconn As MySqlConnection
    Dim COMMAND1, COMMAND2 As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "SELECT * FROM user"
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        myAdapter.SelectCommand = COMMAND1
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "SELECT * FROM user"
        COMMAND2 = New MySqlCommand(Query1, mysqlconn)
        myAdapter.SelectCommand = COMMAND2
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub
End Class