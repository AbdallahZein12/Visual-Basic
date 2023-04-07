Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("Hello world")
        MsgBox("Hello")



    End Sub

    Private Sub Click_Click(sender As Object, e As EventArgs) Handles Click.Click


        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Abdallah"
        stLastName = "Abdelmoneim"

        MsgBox("Hello, " & stFirstName & " " & stLastName)

        stFirstName = "Marvin"
        stLastName = "Drake"

        MsgBox("Hello, " & stFirstName & " " & stLastName)




    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColors As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColors = "Black"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #03/27/2023#

        MsgBox("The car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColors & vbNewLine & bTaxed &
               vbNewLine & iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)


    End Sub

    Private Sub btnUserInput_Click(sender As Object, e As EventArgs) Handles btnUserInput.Click

        Dim stFirstName As String

        stFirstName = InputBox("Please enter your first name")

        MsgBox("Hello " & stFirstName)


    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MsgBox(stFirstName & vbNewLine & stLastName & vbNewLine & stGender & vbNewLine & stOccupation)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")

    End Sub
End Class
