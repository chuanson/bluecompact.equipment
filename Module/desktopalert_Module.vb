Imports System.ComponentModel
Imports System
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Module DesktopAlert_Module

    ' ฟังก์ชันแสดงแจ้งเตือน
    Private _RunningAlertId As Long = 0

    Public Sub SuccessAlert(ByVal message As String)
        Dim s As String = message.Trim()
        _RunningAlertId += 1

        Dim Color As eDesktopAlertColor = eDesktopAlertColor.Default
        Dim Position As eAlertPosition = eAlertPosition.BottomRight
        Dim Duration As Integer = 4
        DesktopAlert.Show(s, ChrW(&HF14A).ToString(), eSymbolSet.Awesome, System.Drawing.Color.Empty, Color, Position, Duration, _RunningAlertId, AddressOf AlertClicked)
    End Sub

    Private Sub AlertClicked(ByVal alertId As Long)

    End Sub
End Module
