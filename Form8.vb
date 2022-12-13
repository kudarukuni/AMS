Public Class Form8
    Private Sub ViewMammalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMammalsToolStripMenuItem.Click
        Dim f2 As New Form3
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click
        Dim f2 As New Form9
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class