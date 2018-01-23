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
End Class
