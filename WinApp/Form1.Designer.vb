<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStart = New Button()
        Click = New Button()
        btnDataTypes = New Button()
        btnUserInput = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtGender = New TextBox()
        lblGender = New Label()
        btnEnter = New Button()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.Highlight
        btnStart.Location = New Point(218, 288)
        btnStart.Margin = New Padding(3, 4, 3, 4)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(443, 169)
        btnStart.TabIndex = 0
        btnStart.Text = "Press here"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Click
        ' 
        Click.Location = New Point(218, 79)
        Click.Margin = New Padding(3, 4, 3, 4)
        Click.Name = "Click"
        Click.Size = New Size(443, 169)
        Click.TabIndex = 1
        Click.Text = "Click"
        Click.UseVisualStyleBackColor = True
        ' 
        ' btnDataTypes
        ' 
        btnDataTypes.Location = New Point(699, 79)
        btnDataTypes.Margin = New Padding(3, 4, 3, 4)
        btnDataTypes.Name = "btnDataTypes"
        btnDataTypes.Size = New Size(189, 379)
        btnDataTypes.TabIndex = 2
        btnDataTypes.Text = "Data Types"
        btnDataTypes.UseVisualStyleBackColor = True
        ' 
        ' btnUserInput
        ' 
        btnUserInput.Location = New Point(14, 79)
        btnUserInput.Margin = New Padding(3, 4, 3, 4)
        btnUserInput.Name = "btnUserInput"
        btnUserInput.Size = New Size(167, 169)
        btnUserInput.TabIndex = 3
        btnUserInput.Text = "User Input"
        btnUserInput.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(325, 479)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(213, 27)
        txtFirstName.TabIndex = 4
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(233, 483)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(80, 20)
        lblFirstName.TabIndex = 5
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(325, 532)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(213, 27)
        txtLastName.TabIndex = 6
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(233, 543)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(79, 20)
        lblLastName.TabIndex = 7
        lblLastName.Text = "Last Name"
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(662, 479)
        txtGender.Margin = New Padding(3, 4, 3, 4)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(213, 27)
        txtGender.TabIndex = 8
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(585, 483)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(57, 20)
        lblGender.TabIndex = 9
        lblGender.Text = "Gender"
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(662, 532)
        btnEnter.Margin = New Padding(3, 4, 3, 4)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(214, 40)
        btnEnter.TabIndex = 10
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 20
        lstOccupation.Items.AddRange(New Object() {"Doctor ", "Programmer", "Teacher", "Student", "Tailor", "Soldier", "Sailor"})
        lstOccupation.Location = New Point(14, 288)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(150, 144)
        lstOccupation.TabIndex = 11
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(14, 258)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(85, 20)
        lblOccupation.TabIndex = 12
        lblOccupation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(btnEnter)
        Controls.Add(lblGender)
        Controls.Add(txtGender)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnUserInput)
        Controls.Add(btnDataTypes)
        Controls.Add(Click)
        Controls.Add(btnStart)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Click As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents btnUserInput As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
