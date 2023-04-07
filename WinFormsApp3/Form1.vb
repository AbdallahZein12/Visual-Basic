Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text
        stCountry = stCountry

        If stCountry.ToUpper = "AUSTRALIA" Then
            MsgBox("G' Day Mate!")
            MsgBox("Good on ya")
            MsgBox("No Worries")

        ElseIf stCountry.ToUpper = "FRANCE" Then
            MsgBox("Bonjour")
            MsgBox("Comment allez-vous?")

        ElseIf stCountry.ToUpper = "EGYPT" Then
            MsgBox("اهلا و سهللا")

        Else
            MsgBox("Hello there")
            MsgBox("I hope you are well")

        End If



    End Sub
End Class
