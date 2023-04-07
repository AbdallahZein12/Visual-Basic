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
        txtExamScore = New TextBox()
        lblExamScore = New Label()
        btnGrade = New Button()
        SuspendLayout()
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(280, 98)
        txtExamScore.Margin = New Padding(3, 2, 3, 2)
        txtExamScore.MaxLength = 3
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(173, 23)
        txtExamScore.TabIndex = 0
        ' 
        ' lblExamScore
        ' 
        lblExamScore.AutoSize = True
        lblExamScore.Location = New Point(120, 103)
        lblExamScore.Name = "lblExamScore"
        lblExamScore.Size = New Size(92, 15)
        lblExamScore.TabIndex = 1
        lblExamScore.Text = "EnterExamScore"
        ' 
        ' btnGrade
        ' 
        btnGrade.Location = New Point(191, 176)
        btnGrade.Margin = New Padding(3, 2, 3, 2)
        btnGrade.Name = "btnGrade"
        btnGrade.Size = New Size(271, 94)
        btnGrade.TabIndex = 2
        btnGrade.Text = "Grade"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(btnGrade)
        Controls.Add(lblExamScore)
        Controls.Add(txtExamScore)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents lblExamScore As Label
    Friend WithEvents btnGrade As Button
End Class
