Public Class Web
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = WebBrowser1.DocumentTitle & Space(2) & "Preview"
    End Sub

    Private Sub Web_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main.MenuStrip2.Visible = False
    End Sub

    Private Sub Web_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.MenuStrip2.Visible = True
    End Sub
End Class