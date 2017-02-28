Public Class Editor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<html>"

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim savefile As New SaveFileDialog
        savefile.FileName = ""
        savefile.Filter = "Hyper Text Markup Language Files (*.html) | *.html"
        savefile.Title = "Save"
        savefile.ShowDialog()
        Try
            Dim Write As New System.IO.StreamWriter(savefile.FileName)
            Write.Write(TextBox1.Text)
            Write.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</html>"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<head>"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</head>"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<title>"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</title>"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<body>"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</body>"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<table border="""">"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<table>"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<tr>"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</tr>"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<td>"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</td>"
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<p>"
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</p>"
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<br>"
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<b>"
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</b>"
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<i>"
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</i>"
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<u>"
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</u>"
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<strike>"
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</strike>"
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<sup>"
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</sup>"
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<sub>"
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</sub>"
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<ol>"
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</ol>"
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<ul>"
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</ul>"
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<li>"
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</li>"
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<dd>"
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</dd>"
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h1>"
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h1>"
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h2>"
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h2>"
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h3>"
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h3>"
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h4>"
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h4>"
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h5>"
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h5>"
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<h6>"
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</h6>"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<img src="""">"
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<a href="""">"
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</a>"
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<a mailto="""">"
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "</a>"
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Undo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Redo()

    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Copy()
    End Sub

    Private Sub PastToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.SelectAll()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenFile As New OpenFileDialog
        OpenFile.FileName = ""
        OpenFile.Filter = "Hyper Text Markup Language Files (*.html) | *.html"
        OpenFile.Title = "Open"
        OpenFile.ShowDialog()
        Try
            Dim Read As New System.IO.StreamReader(OpenFile.FileName)
            TextBox1.Text = Read.ReadToEnd
            Read.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newwindow As New Editor
        newwindow.Show()
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Web.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Web.WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<embed height= width= src=>"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & "<iframe width= height= src= frameborder= allowfullscreen></iframe>"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("color=")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("face=")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("size=")
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FontDialog1.ShowDialog()
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("</font>")
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("background=")
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("bgcolor=")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("Debug\ColorCop.exe")
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("<a name="""">")
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & ("<a href=""#"">")
    End Sub

    Private Sub Editor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main.ΑποθήκευσηΩςToolStripMenuItem1.Enabled = False
        Main.ΕκτύπωσηToolStripMenuItem1.Enabled = False
        Main.ΠροπισκόπησηΕκτύπωσηςToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.ΑποθήκευσηΩςToolStripMenuItem1.Enabled = True
        Main.ΕκτύπωσηToolStripMenuItem1.Enabled = True
        Main.ΠροπισκόπησηΕκτύπωσηςToolStripMenuItem.Enabled = True
        Me.TextBox1.ForeColor = My.Settings.EditorFontColor
    End Sub
End Class
