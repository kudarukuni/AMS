<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SystemUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MammalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMammalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BirdsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReptilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmphibiansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemUsersToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SystemUsersToolStripMenuItem
        '
        Me.SystemUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewUsersToolStripMenuItem})
        Me.SystemUsersToolStripMenuItem.Name = "SystemUsersToolStripMenuItem"
        Me.SystemUsersToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.SystemUsersToolStripMenuItem.Text = "System Users"
        '
        'ViewUsersToolStripMenuItem
        '
        Me.ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        Me.ViewUsersToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ViewUsersToolStripMenuItem.Text = "View Users"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MammalsToolStripMenuItem, Me.BirdsToolStripMenuItem, Me.FishToolStripMenuItem, Me.ReptilesToolStripMenuItem, Me.AmphibiansToolStripMenuItem})
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'MammalsToolStripMenuItem
        '
        Me.MammalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMammalsToolStripMenuItem})
        Me.MammalsToolStripMenuItem.Name = "MammalsToolStripMenuItem"
        Me.MammalsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.MammalsToolStripMenuItem.Text = "Mammals"
        '
        'ViewMammalsToolStripMenuItem
        '
        Me.ViewMammalsToolStripMenuItem.Name = "ViewMammalsToolStripMenuItem"
        Me.ViewMammalsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ViewMammalsToolStripMenuItem.Text = "View Mammals"
        '
        'BirdsToolStripMenuItem
        '
        Me.BirdsToolStripMenuItem.Name = "BirdsToolStripMenuItem"
        Me.BirdsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BirdsToolStripMenuItem.Text = "Birds"
        '
        'FishToolStripMenuItem
        '
        Me.FishToolStripMenuItem.Name = "FishToolStripMenuItem"
        Me.FishToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FishToolStripMenuItem.Text = "Fish"
        '
        'ReptilesToolStripMenuItem
        '
        Me.ReptilesToolStripMenuItem.Name = "ReptilesToolStripMenuItem"
        Me.ReptilesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ReptilesToolStripMenuItem.Text = "Reptiles"
        '
        'AmphibiansToolStripMenuItem
        '
        Me.AmphibiansToolStripMenuItem.Name = "AmphibiansToolStripMenuItem"
        Me.AmphibiansToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AmphibiansToolStripMenuItem.Text = "Amphibians"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(880, 463)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animals - User Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SystemUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MammalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMammalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BirdsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReptilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmphibiansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
End Class
