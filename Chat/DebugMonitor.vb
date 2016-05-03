Public Class DebugMonitor
    Private Sub DebugMonitor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Pause Then
            FrmMainChat.Button1.Enabled = True
            DebugGeneral.Items.Add("INITIATE BUTTON ENABLED")
            DebugGeneral.Items.Add("!!!WARNING!!! PRESSING THIS WILL WIPE LOGS")
        End If
    End Sub
End Class