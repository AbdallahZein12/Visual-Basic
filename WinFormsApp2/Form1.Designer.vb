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
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        lblNum1 = New Label()
        lblNum2 = New Label()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(251, 107)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(230, 27)
        txtNum1.TabIndex = 0
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(251, 203)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(230, 27)
        txtNum2.TabIndex = 1
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Location = New Point(143, 114)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(75, 20)
        lblNum1.TabIndex = 2
        lblNum1.Text = "Number 1"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Location = New Point(143, 210)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(75, 20)
        lblNum2.TabIndex = 3
        lblNum2.Text = "Number 2"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(251, 318)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(230, 95)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Claculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(lblNum2)
        Controls.Add(lblNum1)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents btnCalculate As Button
End Class
