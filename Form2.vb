Public Class Form2
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ViewMammalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMammalsToolStripMenuItem.Click
        Dim f2 As New Form3
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub AddMammalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMammalsToolStripMenuItem.Click
        Dim f2 As New Form4
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub EditMammalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMammalsToolStripMenuItem.Click
        Dim f2 As New Form5
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub DeleteMammalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteMammalsToolStripMenuItem.Click
        Dim f2 As New Form6
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click
        Dim f2 As New Form9
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        Dim f2 As New Form10
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub EditUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUsersToolStripMenuItem.Click
        Dim f2 As New Form11
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub PromoteUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoteUsersToolStripMenuItem.Click
        Dim f2 As New Form12
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub DeleteUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUsersToolStripMenuItem.Click
        Dim f2 As New Form13
        f2.MdiParent = Me
        f2.Show()
    End Sub
End Class