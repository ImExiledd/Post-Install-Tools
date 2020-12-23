Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Public Class installer
    ' set up our webclient
    Dim wc As WebClient = New WebClient

    ' define locations for installers
    Dim discord As String = "https://dl.discordapp.net/apps/win/0.0.309/DiscordSetup.exe"
    Dim steam As String = "https://steamcdn-a.akamaihd.net/client/installer/SteamSetup.exe"
    Dim origin As String = "https://origin-a.akamaihd.net/Origin-Client-Download/origin/live/OriginThinSetup.exe"
    Dim winterm As String = "" 'wip
    Dim opera As String = "https://net.geo.opera.com/opera_gx/stable/windows"
    Dim chrome As String = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B59472513-C537-F136-FB66-5AB737A3B6C0%7D%26lang%3Den%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe"
    Dim firefox As String = "https://cdn.stubdownloader.services.mozilla.com/builds/firefox-stub/en-US/win/3a4dacdd6bd72384d2f08ec429b3136cce11004189376ad3be53b6f72af59dab/Firefox%20Installer.exe"
    Dim epic As String = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi"

    ' mod installer location defs
    Dim bd As String = "https://github.com/rauenzi/BBDInstaller/releases/latest/download/BandagedBD.exe"

    Function downloader(uri)
        Try
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            AddHandler wc.DownloadProgressChanged, AddressOf OnDownloadProgressChangedEventHandler
            wc.DownloadFileAsync(New Uri(uri), Path.GetTempPath)
        Catch ex As Exception

        End Try
    End Function

    Private Sub installer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class