Imports System
Imports System.IO
Imports System.Collections

Public Class v15confirmation
    Dim modPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\mods"
    Dim v16backupVar =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\misc\0.16\mods"
    Dim v15backupVar =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
            "\Factorio\misc\0.15\mods"

    Private Sub v15back_Click(sender As Object, e As EventArgs) Handles v15back.Click
        Me.Close()
    End Sub

    Public Sub v15continue_Click(sender As Object, e As EventArgs) Handles v15continue.Click
        Directory.Delete(modPath, True)
        My.Computer.FileSystem.CopyDirectory(v16backupVar, modPath, True)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Me.Hide()
    End Sub
End Class