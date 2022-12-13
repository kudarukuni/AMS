Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Public Class Form1
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim errorCounter As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Fill In All Fields")
        ElseIf TextBox3.Text = TextBox4.Text = False Then
            MsgBox("Passwords Don't Match")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
            Dim READER As MySqlDataReader
            Dim Query As String

            mysqlconn.Open()
            Query = "SELECT * FROM user WHERE username LIKE '" & TextBox2.Text & "'"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = COMMAND.ExecuteReader
            If READER.Read = True Then
                MsgBox("Username Already Exists")
                mysqlconn.Close()
            Else
                mysqlconn.Close()
                mysqlconn.Open()
                Query = "INSERT INTO user (name, username, password) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', sha1('" & TextBox3.Text & "'))"
                COMMAND = New MySqlCommand(Query, mysqlconn)
                READER = COMMAND.ExecuteReader
                mysqlconn.Close()
                MsgBox("Successfully Registered")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Fill In All Fields")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"

            Dim READER As MySqlDataReader
            mysqlconn.Open()
            Dim Query = "SELECT * FROM user WHERE username = '" & TextBox5.Text & "'AND password = sha1('" & TextBox6.Text & "')"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = Command.ExecuteReader
            errorCounter += 0

            If READER.Read = True Then
                MsgBox("Welcome " + TextBox5.Text)
                Form8.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Password or Username")
                errorCounter = errorCounter + 1
                If errorCounter = 3 Then
                    MessageBox.Show("Authentication failed!", "Login Message")
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()
    End Sub
End Class
