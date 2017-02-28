Public Class Main

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        Editor.TextBox1.Text = reader.ReadToEnd
        reader.Close()
        OpenFileDialog1.Filter = "Hyper Text Markup Language Files (*.html) | *.html"
        OpenFileDialog1.Title = "Open"
        OpenFileDialog1.FileName = ""
        Editor.MdiParent = Me
        Editor.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Arial", 12, FontStyle.Regular)
        e.Graphics.DrawString(Editor.TextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Web.WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        Web.WebBrowser1.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Web.WebBrowser1.Refresh()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editor.ForeColor = My.Settings.EditorFontColor
        Me.ForeColor = My.Settings.MainFontColor
        Me.MenuStrip1.ForeColor = My.Settings.MainFontColor
        ΝέαToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΆνοιγμαToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΑποθήκευσηΩςToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΕκτύπωσηToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΈξοδοςToolStripMenuItem2.ForeColor = My.Settings.MainFontColor
        ΑναίρεσηToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΕπαναφοράToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΕπιλογήΌλωνToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΑντιγραφήToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΑποκοπήToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΚαμίαToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΟριζόντιαToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΚάθετηToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΓλώσσαToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΕλληνικάToolStripMenuItem1.ForeColor = My.Settings.MainFontColor
        ΡυθμίσειςToolStripMenuItem.ForeColor = My.Settings.MainFontColor
        ΑγγλικάToolStripMenuItem1.ForeColor = My.Settings.MainFontColor

        Me.MenuStrip2.ForeColor = My.Settings.MainFontColor
    End Sub
    Private Sub ΝέαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΝέαToolStripMenuItem.Click
        Editor.MdiParent = Me
        Editor.Show()
        ΑποθήκευσηΩςToolStripMenuItem1.Enabled = True
        ΕκτύπωσηToolStripMenuItem1.Enabled = True
        ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ΆνοιγμαToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΆνοιγμαToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ΑποθήκευσηΩςToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΑποθήκευσηΩςToolStripMenuItem1.Click
        Dim SaveDLG As New SaveFileDialog
        SaveDLG.Filter = "Hyper Text Markup Language Files (*.html) | *.html"
        SaveDLG.Title = "Save file As.."

        DialogResult = SaveDLG.ShowDialog

        If DialogResult = Windows.Forms.DialogResult.OK Then
            Dim objWriter As New System.IO.StreamWriter(SaveDLG.FileName)
            objWriter.Write(Editor.TextBox1.Text)
            objWriter.Close()
        End If
    End Sub

    Private Sub ΕκτύπωσηToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΕκτύπωσηToolStripMenuItem1.Click
        PrintDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub ΈξοδοςToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ΈξοδοςToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub ΑναίρεσηToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΑναίρεσηToolStripMenuItem1.Click
        Editor.TextBox1.Undo()
    End Sub

    Private Sub ΕπαναφοράToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΕπαναφοράToolStripMenuItem1.Click
        Editor.TextBox1.Redo()
    End Sub

    Private Sub ΕπιλογήΌλωνToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ΕπιλογήΌλωνToolStripMenuItem.Click
        Editor.TextBox1.SelectAll()
    End Sub

    Private Sub ΑντιγραφήToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΑντιγραφήToolStripMenuItem1.Click
        Editor.TextBox1.Copy()
    End Sub

    Private Sub ΑποκοπήToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΑποκοπήToolStripMenuItem1.Click
        Editor.TextBox1.Cut()
    End Sub

    Private Sub ΕπικόλλησηToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΕπικόλλησηToolStripMenuItem1.Click
        Editor.TextBox1.Paste()
    End Sub

    Private Sub ΆνοιγμαΕργαλειοθήκηςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΆνοιγμαΕργαλειοθήκηςToolStripMenuItem.Click
        Toolbar.Show()
    End Sub

    Private Sub ΠροεπισκόπησηΙστούToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΠροεπισκόπησηΙστούToolStripMenuItem.Click
        Web.MdiParent = Me
        Web.Show()
    End Sub

    Private Sub ΕπεξεργαστήςToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΕπεξεργαστήςToolStripMenuItem1.Click
        Editor.MdiParent = Me
        Editor.Show()
        ΑποθήκευσηΩςToolStripMenuItem1.Enabled = True
        ΕκτύπωσηToolStripMenuItem1.Enabled = True
        ΠροεπισκόπησηΕκτύπωσηςToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ΚαμίαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΚαμίαToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
        ΚαμίαToolStripMenuItem.Checked = True
        ΟριζόντιαToolStripMenuItem.Checked = False
        ΚάθετηToolStripMenuItem1.Checked = False
    End Sub

    Private Sub ΟριζόντιαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΟριζόντιαToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
        ΚαμίαToolStripMenuItem.Checked = False
        ΟριζόντιαToolStripMenuItem.Checked = True
        ΚάθετηToolStripMenuItem1.Checked = False
    End Sub

    Private Sub ΚάθετηToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΚάθετηToolStripMenuItem1.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
        ΚαμίαToolStripMenuItem.Checked = False
        ΟριζόντιαToolStripMenuItem.Checked = False
        ΚάθετηToolStripMenuItem1.Checked = True
    End Sub

    Private Sub ΡυθμίσειςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΡυθμίσειςToolStripMenuItem.Click
        Settings.MdiParent = Me
        Settings.Show()
    End Sub
End Class