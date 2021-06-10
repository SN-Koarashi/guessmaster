Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RndNum As New Random()
        Dim ans As Integer = RndNum.Next(1, 101)
        Dim ansq, chance, higher, lower As Integer
        Dim ansq_if As String
Startmy:
        higher = ans + RndNum.Next(1, 11)
        lower = ans - RndNum.Next(1, 11)
        If higher > 100 Then
            GoTo Startmy
        ElseIf lower < 1 Then
            GoTo Startmy
        End If
        If chance >= 3 Then
            MsgBox("Game over, answer number is " & ans & vbCrLf & "You last type number is " & ansq_if)
        Else
            ansq_if = InputBox("Type a number between 1 to 100.")
            If IsNumeric(ansq_if) Then
                If ansq_if >= 1 And ansq_if <= 100 Then
                    ansq = ansq_if
                    If ans = ansq Then
                        chance += 1
                        MsgBox("Congratulations!" & vbCrLf & "Answer number is " & ans)
                        Exit Sub
                    ElseIf ansq > ans Then
                        chance += 1
                        If (3 - chance) = 0 Then
                            GoTo Startmy
                        Else
                            MsgBox("Your number too higher, it should be between " & lower & " to " & ansq & vbCrLf & "Left " & (3 - chance) & " chance.")

                            GoTo Startmy
                        End If
                    ElseIf ansq < ans Then
                        chance += 1

                        If (3 - chance) = 0 Then
                            GoTo Startmy
                        Else
                            MsgBox("Your number too lower, it should be between " & ansq & " to " & higher & vbCrLf & "Left " & (3 - chance) & " chance.")

                            GoTo Startmy
                        End If
                    End If
                Else
                    MsgBox("Please type between 1 to 100 number")
                    GoTo Startmy
                End If
            ElseIf ansq_if.Length = 0 Then
                ' Nothing
                MsgBox("Do you want to exit the game?!")
            Else
                MsgBox("Do you want to exit the game!!")
            End If
        End If


    End Sub
End Class
