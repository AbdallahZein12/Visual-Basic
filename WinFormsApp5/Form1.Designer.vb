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
        txtTemp = New TextBox()
        btnCheck = New Button()
        SuspendLayout()
        ' 
        ' txtTemp
        ' 
        txtTemp.Location = New Point(236, 126)
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New Size(284, 23)
        txtTemp.TabIndex = 0
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(262, 243)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(222, 132)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCheck)
        Controls.Add(txtTemp)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTemp As TextBox
    Friend WithEvents btnCheck As Button
End Class
