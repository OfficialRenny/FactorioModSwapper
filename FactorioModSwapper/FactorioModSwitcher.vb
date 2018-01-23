Imports System
Imports System.IO
Imports System.Collections

Public Class FactorioModSwitcher
    Public modPath =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
        "\Factorio\mods\"
    Public v16backupVar =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
        "\Factorio\misc\0.16\mods\"
    Public v15backupVar =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
        "\Factorio\misc\0.15\mods\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checks your %appdata%\Factorio\mods\ Folder
        If Directory.Exists(modPath) Then
            If Directory.GetFiles(modPath).Count > 0 Then
                currentModCheck.Text = "Mods folder detected and contains mods!"
                currentModCheck.ForeColor = Color.Green
            Else
                currentModCheck.Text = "Mod folder exists, but does not contain any files."
                currentModCheck.ForeColor = Color.Orange
            End If
        Else
            currentModCheck.Text = "Mods folder does not exist. Restoring your mods may fix that."
            currentModCheck.ForeColor = Color.Red
        End If
        'Checks your %appdata%\Factorio\misc\0.15 folder for /mods/ and contents
        If Directory.Exists(v15backupVar) Then
            If Directory.GetFiles(v15backupVar).Count > 0 Then
                v15ModBackupCheck.Text = "0.15 backup folder detected and contains mods!"
                v15ModBackupCheck.ForeColor = Color.Green
            Else
                'Shouldn't really get this message unless you manually clear the backup folders and leave the /mods/ folder.
                v15ModBackupCheck.Text = "0.15 backup folder exists, but does not contain any files."
                v15ModBackupCheck.ForeColor = Color.Orange
            End If
        Else
            v15ModBackupCheck.Text = "0.15 backup folder does not exist. Backing up your mods may fix that."
            v15ModBackupCheck.ForeColor = Color.Red
        End If
        'Checks your %appdata%\Factorio\misc\0.16 for /mods/ and contents.
        If Directory.Exists(v16backupVar) Then
            If Directory.GetFiles(v16backupVar).Count > 0 Then
                v16ModBackupCheck.Text = "0.16 backup folder detected and contains mods!"
                v16ModBackupCheck.ForeColor = Color.Green
            Else
                'Shouldn't really get this message unless you manually clear the backup folders and leave the /mods/ folder.
                v16ModBackupCheck.Text = "0.16 backup folder exists, but does not contain any files."
                v16ModBackupCheck.ForeColor = Color.Orange
            End If
        Else
            v16ModBackupCheck.Text = "0.16 backup folder does not exist. Backing up your mods may fix that."
            v16ModBackupCheck.ForeColor = Color.Red
        End If
    End Sub

    Private Sub v16backup_Click(sender As Object, e As EventArgs) Handles v16backup.Click
        If Directory.Exists(modPath) Then
            My.Computer.FileSystem.CopyDirectory(modPath, v16backupVar, True)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Else
            MsgBox("Your Factorio\mods\ folder is non-existent.")
        End If
    End Sub

    Private Sub v15backup_Click(sender As Object, e As EventArgs) Handles v15backup.Click
        If Directory.Exists(modPath) Then
            My.Computer.FileSystem.CopyDirectory(modPath, v15backupVar, True)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Else
            MsgBox("Your Factorio\mods\ folder is non-existent.")
        End If
    End Sub

    Private Sub v16restoreConfirm_Click(sender As Object, e As EventArgs) Handles v16restoreConfirm.Click
        v16confirmation.Show()
    End Sub

    Private Sub v15restoreConfirm_Click(sender As Object, e As EventArgs) Handles v15restoreConfirm.Click
        v15confirmation.Show()
    End Sub

    Private Sub currentModCheck_Click(sender As Object, e As EventArgs) Handles currentModCheck.Click

    End Sub

    Private Sub v15ModBackupCheck_Click(sender As Object, e As EventArgs) Handles v15ModBackupCheck.Click

    End Sub

    Private Sub v16ModBackupCheck_Click(sender As Object, e As EventArgs) Handles v16ModBackupCheck.Click

    End Sub
End Class
