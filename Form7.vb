Imports MySql.Data.MySqlClient

Public Class Form7
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim errorCounter As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Fill In All Fields")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"

            Dim READER As MySqlDataReader
            mysqlconn.Open()
            Dim Query = "SELECT * FROM admin WHERE username = '" & TextBox5.Text & "' AND password = sha1('" & TextBox6.Text & "')"
            COMMAND = New MySqlCommand(Query, mysqlconn)
            READER = Command.ExecuteReader
            errorCounter += 0

            If READER.Read = True Then
                MsgBox("Welcome " + TextBox5.Text)
                Form2.Show()
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
End Class