Public Class Form1
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tab As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        TabControl1.TabPages.Add(tab)
    End Sub
End Class
