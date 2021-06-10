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
            MsgBox("失敗，答案是 " & ans & vbCrLf & "你最後輸入的數字是 " & ansq_if)
        Else
            ansq_if = InputBox("輸入一個1~100的數字")
            If IsNumeric(ansq_if) Then
                If ansq_if >= 1 And ansq_if <= 100 Then
                    ansq = ansq_if
                    If ans = ansq Then
                        chance += 1
                        MsgBox("答對，答案是 " & ans)
                        Exit Sub
                    ElseIf ansq > ans Then
                        chance += 1
                        If (3 - chance) = 0 Then
                            GoTo Startmy
                        Else
                            MsgBox("你輸入的數字太高了，應介於 " & lower & "~" & ansq & vbCrLf & "還剩下 " & (3 - chance) & " 次機會")

                            GoTo Startmy
                        End If
                    ElseIf ansq < ans Then
                        chance += 1

                        If (3 - chance) = 0 Then
                            GoTo Startmy
                        Else
                            MsgBox("你輸入的數字太低了，應介於" & ansq & "~" & higher & vbCrLf & "還剩下 " & (3 - chance) & " 次機會")

                            GoTo Startmy
                        End If
                    End If
                Else
                    MsgBox("請輸入1~100的數字")
                    GoTo Startmy
                End If
            ElseIf ansq_if.Length = 0 Then
                ' Nothing
                MsgBox("您選擇了離開遊戲?!")
            Else
                MsgBox("您選擇了離開遊戲")
            End If
        End If


    End Sub
End Class
