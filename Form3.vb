Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim mysqlconn As MySqlConnection
    Dim COMMAND, COMMAND1 As MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim Query As String
        mysqlconn.Open()
        Query = "SELECT * FROM mammals WHERE type='" & TextBox1.Text & "'"
        COMMAND = New MySqlCommand(Query, mysqlconn)
        myAdapter.SelectCommand = COMMAND
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "SELECT * FROM mammals"
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        myAdapter.SelectCommand = COMMAND1
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=127.0.0.1; user=root; database=animals"
        Dim Query1 As String

        mysqlconn.Open()
        Query1 = "SELECT * FROM mammals"
        COMMAND1 = New MySqlCommand(Query1, mysqlconn)
        myAdapter.SelectCommand = COMMAND1
        myAdapter.Fill(myData)
        DataGridView1.DataSource = myData
        mysqlconn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub
End Class