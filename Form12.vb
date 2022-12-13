Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing

Public Class Form12
    Dim mysqlconn As MySqlConnection
    Dim COMMAND, COMMAND1, COMMAND2, COMMAND3 As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox3.Text() = ""
        TextBox4.Text() = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim READER1, READER2 As MySqlDataReader
        Dim Query, Query2, Query3 As String

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Fill In All Fields")
        ElseIf TextBox3.Text = TextBox4.Text = False Then
            MsgBox("Passwords Don't Match")
        Else
            mysqlconn.Open()
            Query = "SELECT * FROM admin WHERE username LIKE '" & TextBox2.Text & "'"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER1 = COMMAND.ExecuteReader
            If READER1.Read = True Then
                MsgBox("User Already Admin")
                mysqlconn.Close()
            Else
                mysqlconn.Close()
                mysqlconn.Open()
                Query2 = "SELECT * FROM user WHERE username LIKE '" & TextBox2.Text & "'"
                COMMAND1 = New MySqlCommand(Query2, mysqlconn)
                READER2 = COMMAND1.ExecuteReader
                If READER2.Read = False Then
                    MsgBox("Username Don't Exit")
                    mysqlconn.Close()
                Else
                    mysqlconn.Close()
                    mysqlconn.Open()
                    Query = "INSERT INTO admin (name, username, password) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', sha1('" & TextBox3.Text & "'))"
                    COMMAND3 = New MySqlCommand(Query, mysqlconn)
                    READER1 = COMMAND3.ExecuteReader
                    mysqlconn.Close()
                    mysqlconn.Open()
                    Query3 = "DELETE FROM user WHERE username='" & TextBox2.Text & "'"
                    COMMAND2 = New MySqlCommand(Query3, mysqlconn)
                    READER1 = COMMAND2.ExecuteReader
                    mysqlconn.Close()
                    MsgBox("User Successfully Promoted!!")
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class