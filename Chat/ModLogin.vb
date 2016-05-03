Public Class ModLogin
    Private Sub UserTypeSetAndSave()
        FrmMainChat.Usertype = My.Settings.Usertype
        My.Settings.Save()
        FrmMainChat.LblStatus.Text = My.Settings.Username & " logged in as " & My.Settings.Usertype
        Me.Close()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "Magic16" And PasswordTextBox.Text = "5683" Or UsernameTextBox.Text = "GxSlade" And PasswordTextBox.Text = "Leonard97" Then
            My.Settings.Usertype = "Admin"
            UserTypeSetAndSave()
        ElseIf UsernameTextBox.Text = "04kaia" And PasswordTextBox.Text = "PW14" Then
            My.Settings.Usertype = "VIP"
            UserTypeSetAndSave()
        ElseIf UsernameTextBox.Text = "DeadBraad" And PasswordTextBox.Text = "pokemon14" Then
            My.Settings.Usertype = "OG"
            UserTypeSetAndSave()
        Else
            MsgBox("Incorrect login...", MsgBoxStyle.Exclamation, "MagiCorp uChat Login")
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
