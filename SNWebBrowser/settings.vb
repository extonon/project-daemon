Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = My.Settings.CustomSearch
        If My.Settings.Searchengine = 1 Then
            RadioButton1.Checked = True
        End If
        If My.Settings.Searchengine = 2 Then
            RadioButton2.Checked = True
        End If
        If My.Settings.Searchengine = 3 Then
            RadioButton3.Checked = True
        End If
        If My.Settings.Searchengine = 4 Then
            RadioButton4.Checked = True
        End If
        If My.Settings.Searchengine = 5 Then
            RadioButton5.Checked = True


            If My.Settings.newtab = 1 Then
                RadioButton6.Checked = True
            End If
            If My.Settings.newtab = 2 Then
                RadioButton7.Checked = True
            End If
        End If
        TextBox1.Text = My.Settings.Homepage

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Contains("http://") Or
                    TextBox2.Text.Contains("https://www.") Or
                    TextBox2.Text.Contains("http://www.") Or
                    TextBox2.Text.Contains("https://www") Then
            My.Settings.Homepage = TextBox1.Text
            MsgBox("Homepage Set")
        Else : MsgBox("Please insert a valid URL")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Homepage = ("https://scaaarnetworks.com")
        MsgBox("Default Homepage Set")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.Searchengine = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.Searchengine = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.Searchengine = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        My.Settings.Searchengine = 4
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        My.Settings.Searchengine = 5
        My.Settings.CustomSearch = TextBox2.Text.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.Searchengine = 5 Then
            If TextBox2.Text.Contains("http://") Or
                    TextBox2.Text.Contains("https://www.") Or
                    TextBox2.Text.Contains("http://www.") Or
                    TextBox2.Text.Contains("https://www") Then
                My.Settings.CustomSearch = TextBox2.Text
                MsgBox("Custom Search Engine Set")
            Else : MsgBox("Please insert a valid URL")
            End If
        ElseIf Not My.Settings.Searchengine = 5 Then
            MsgBox("Please select a Custom Search Engine first")
            My.Settings.Searchengine = 1
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        My.Settings.newtab = 1
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        My.Settings.newtab=2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Homepage = ("https://scaaarnetworks.com")
        TextBox1.Text = My.Settings.Homepage
        My.Settings.Searchengine = 1
        My.Settings.CustomSearch = Nothing
        TextBox2.Text = Nothing
        MsgBox("Default Settings Set")
    End Sub
End Class