Imports System
Imports System.IO
Imports System.Collections

Public Class v16confirmation
    Dim modPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\mods"
    Dim v16backupVar =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\misc\0.16\mods"
    Dim v15backupVar =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\misc\0.15\mods"

    Private Sub v16back_Click(sender As Object, e As EventArgs) Handles v16back.Click
        Me.Close()
    End Sub

    Public Sub v16continue_Click(sender As Object, e As EventArgs) Handles v16continue.Click
        Directory.Delete(modPath, True)
        My.Computer.FileSystem.CopyDirectory(v16backupVar, modPath, True)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Me.Hide()
    End Sub
End Class