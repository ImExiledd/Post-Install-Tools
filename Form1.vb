Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Set up base install variables
    Dim installDiscord As Boolean = False
    Dim installSteam As Boolean = False
    Dim installOrigin As Boolean = False
    Dim installWinTerm As Boolean = False
    Dim installOpera As Boolean = False
    Dim installChrome As Boolean = False
    Dim installFirefox As Boolean = False
    Dim installEpic As Boolean = False

    ' Set up variables for application modifications etc
    Dim installBD As Boolean = False

    ' main app code
    Dim modsPanelShown As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modsPanel.Hide()
        logBtn.Enabled = False
        installBtn.Enabled = False
        wipBox.Enabled = False
        installer.Show()
        installBoxWinTerm.Enabled = False
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

    Private Sub installBtn_Click(sender As Object, e As EventArgs) Handles installBtn.Click

        ' Here we run a series of If statements checking for CheckBoxChecked to define our vars.
        If installBoxDiscord.Checked = True Then
            installDiscord = True
        End If
        If installBoxSteam.Checked = True Then
            installDiscord = True
        End If
        If installBoxOrigin.Checked = True Then
            installOrigin = True
        End If
        If installBoxWinTerm.Checked = True Then
            installWinTerm = True
        End If
        If installBoxOpera.Checked = True Then
            installOpera = True
        End If
        If installBoxChrome.Checked = True Then
            installChrome = True
        End If
        If installBoxFirefox.Checked = True Then
            installFirefox = True
        End If
        If installBoxEpic.Checked = True Then
            installEpic = True
        End If
        ' check mods true/false
        If installModBoxBD.Checked = True Then
            installBD = True
        End If

        ' download installers for the users defined applications to install


    End Sub
End Class
