Imports System
Imports System.IO
Imports System.Collections

Public Class v16confirmation

    Private Sub v16back_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub v16continue_Click(sender As Object, e As EventArgs)
        Directory.Delete(FactorioModSwitcher.modPath, True)
        My.Computer.FileSystem.CopyDirectory(FactorioModSwitcher.v16backupVar, FactorioModSwitcher.modPath, True)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Me.Hide()
    End Sub

    Private Sub v16confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class