Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer

        For iCount = 1 To 5
            Beep()
            Threading.Thread.Sleep(2000)
        Next
        iCount = 0
        Do While iCount < 5
            iCount = iCount + 1
            MsgBox(iCount)
        Loop
        iCount = 0
        Do
            iCount = iCount + 1
            MsgBox(iCount)
        Loop While iCount < 5
        iCount = 0
        Do Until iCount = 5
            iCount = iCount + 1
            MsgBox(iCount)
        Loop
        iCount = 0
        Do
            iCount = iCount + 1
            MsgBox(iCount)
        Loop Until iCount = 5

        MsgBox("All Done")

    End Sub
End Class
