Imports System
Imports System.IO
Imports System.Collections

Public Class v15confirmation

    Private Sub v15back_Click(sender As Object, e As EventArgs) Handles v15back.Click
        Me.Close()
    End Sub

    Public Sub v15continue_Click(sender As Object, e As EventArgs) Handles v15continue.Click
        If Directory.Exists(FactorioModSwitcher.modPath) Then
            Directory.Delete(FactorioModSwitcher.modPath, True)
            Directory.CreateDirectory(FactorioModSwitcher.modPath)
            My.Computer.FileSystem.CopyDirectory(FactorioModSwitcher.v15backupVar, FactorioModSwitcher.modPath, True)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Me.Hide()
        Else
            Directory.CreateDirectory(FactorioModSwitcher.modPath)
            My.Computer.FileSystem.CopyDirectory(FactorioModSwitcher.v15backupVar, FactorioModSwitcher.modPath, True)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Me.Hide()
        End If
    End Sub

    Private Sub v15confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class