Imports MySql.Data.MySqlClient

Public Class Form11
    Dim mysqlconn As MySqlConnection
    Dim COMMAND, COMMAND1 As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Fill In All Fields")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
            Dim READER As MySqlDataReader
            Dim Query As String

            mysqlconn.Open()
            Query = "SELECT * FROM user WHERE username LIKE '" & TextBox2.Text & "'"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = Command.ExecuteReader
            If READER.Read = False Then
                MsgBox("Username Does Not Exists")
                mysqlconn.Close()
            Else
                mysqlconn.Close()
                mysqlconn.Open()
                Query = "UPDATE user SET name='" & TextBox1.Text & "', username='" & TextBox1.Text & "', password=sha1('" & TextBox1.Text & "') WHERE username LIKE '" & TextBox2.Text & "'"
                COMMAND = New MySqlCommand(Query, mysqlconn)
                READER = Command.ExecuteReader
                mysqlconn.Close()
                MsgBox("User Successfully Updated")
            End If
        End If
    End Sub

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
End Class