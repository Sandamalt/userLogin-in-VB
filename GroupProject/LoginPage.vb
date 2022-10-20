Public Class LoginPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MsgBox("Log In , Please wait ...")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear_ALL_textboxes()
    End Sub

    Private Sub clear_ALL_textboxes()
        'thanks to jmcilhinney at vbforums
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

    End Sub

    Private Sub btnRegisterNow_Click(sender As Object, e As EventArgs) Handles btnRegisterNow.Click
        RegisterForm.Show()
    End Sub
End Class