Public Class Form1
    Dim modsPanelShown As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modsPanel.Hide()
        logBtn.Enabled = False
        installBtn.Enabled = False
        wipBox.Enabled = False
    End Sub

    Private Sub confirmBox_CheckedChanged(sender As Object, e As EventArgs) Handles confirmBox.CheckedChanged
        If confirmBox.Checked = True Then
            installBtn.Enabled = True
        Else
            installBtn.Enabled = False
        End If
    End Sub

    Private Sub modsBtn_Click(sender As Object, e As EventArgs) Handles modsBtn.Click
        If modsPanelShown = False Then
            modsPanel.Show()
            modsBtn.Text = "Hide Modifications Panel"
            modsPanelShown = True
        ElseIf modsPanelShown = True Then
            modsPanel.Hide()
            modsBtn.Text = "Show Modifications Panel"
            modsPanelShown = False
        End If
    End Sub
End Class
