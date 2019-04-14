Imports Awesomium.Core

Public Class tab
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProjectDaemonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectDaemonToolStripMenuItem.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebControl1.Reload(ignoreCache:=True)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".ml") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                TextBox1.Text = ("http://" + TextBox1.Text)
            End Try
        Else
        End If
        If My.Settings.Searchengine = 1 Then
            WebControl1.Source = New Uri("https://www.google.com/search?q=" + TextBox1.Text)
        End If
        If My.Settings.Searchengine = 2 Then
                WebControl1.Source = New Uri("https://www.bing.com/search?q=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 3 Then
                WebControl1.Source = New Uri("https://search.yahoo.com/search?p=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 4 Then
                WebControl1.Source = New Uri("https://www.ask.com/web?q=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 5 Then
                WebControl1.Source = New Uri(My.Settings.CustomSearch + TextBox1.Text)
            End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".ml") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else : WebControl1.Source = New Uri("https://www.google.com/search?q=" & TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click
        If My.Settings.newtab = 1 Then
            Dim tab As New TabPage
            Dim newtab As New tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab)
            Form1.TabControl1.SelectedTab = tab
        End If
        If My.Settings.newtab = 2 Then
            Dim tab As New TabPage
            Dim newtab As New tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab)
        End If
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If Form1.TabControl1.TabCount = 1 Then
            Dim tab As New TabPage
            Dim newtab As New tab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab)
            Form1.TabControl1.SelectedTab = tab
            Form1.TabControl1.SelectedTab.Dispose()
        Else : Form1.TabControl1.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        Combo.Text = "R"
        PictureBox1.Visible = False
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        Combo.Text = "X"
        PictureBox1.Visible = True
    End Sub

    Private Sub Combo_Click(sender As Object, e As EventArgs) Handles Combo.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
            PictureBox1.Visible = False
            Parent.Text = "Navigation Stopped"
            Combo.Text = "R"
        End If
        If Not WebControl1.IsNavigating Then
            WebControl1.Reload(ignoreCache:=True)
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".ml") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else
            End If
            If My.Settings.Searchengine = 1 Then
                WebControl1.Source = New Uri("https://www.google.com/search?q=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 2 Then
                WebControl1.Source = New Uri("https://www.bing.com/search?q=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 3 Then
                WebControl1.Source = New Uri("https://search.yahoo.com/search?p=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 4 Then
                WebControl1.Source = New Uri("https://www.ask.com/web?q=" + TextBox1.Text)
            End If
            If My.Settings.Searchengine = 5 Then
                WebControl1.Source = New Uri(My.Settings.CustomSearch + TextBox1.Text)
            End If
        End If
    End Sub
End Class