Imports System.Drawing.Font
Imports System.Drawing.FontFamily
Imports System.Drawing.FontConverter
Public Class Settings

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EditorFontColor As New ColorDialog
        EditorFontColor.ShowDialog()
        Editor.TextBox1.ForeColor = EditorFontColor.Color
        Button6.BackColor = EditorFontColor.Color
        My.Settings.EditorFontColor = EditorFontColor.Color
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button6.BackColor = My.Settings.EditorFontColor
        Button11.BackColor = My.Settings.MainFontColor
        Me.PictureBox1.ImageLocation = My.Settings.UserAvatar
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim MainFontColor As New ColorDialog
        MainFontColor.ShowDialog()
        Main.ForeColor = MainFontColor.Color
        Main.MenuStrip1.ForeColor = MainFontColor.Color
        Main.ΝέαToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΆνοιγμαToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΑποθήκευσηΩςToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΕκτύπωσηToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΈξοδοςToolStripMenuItem2.ForeColor = MainFontColor.Color
        Main.ΑναίρεσηToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΕπαναφοράToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΕπιλογήΌλωνToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΑντιγραφήToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΑποκοπήToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΚαμίαToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΟριζόντιαToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΚάθετηToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΓλώσσαToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΕλληνικάToolStripMenuItem1.ForeColor = MainFontColor.Color
        Main.ΡυθμίσειςToolStripMenuItem.ForeColor = MainFontColor.Color
        Main.ΑγγλικάToolStripMenuItem1.ForeColor = MainFontColor.Color
        Button11.BackColor = MainFontColor.Color
        My.Settings.MainFontColor = MainFontColor.Color
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim BrowseUserAvatar As New OpenFileDialog
        BrowseUserAvatar.ShowDialog()
        Me.PictureBox1.ImageLocation = BrowseUserAvatar.FileName
        My.Settings.UserAvatar = BrowseUserAvatar.FileName
        My.Settings.Save()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.PictureBox1.Image = My.Resources.NoImage
        My.Settings.UserAvatar = ""
    End Sub
End Class