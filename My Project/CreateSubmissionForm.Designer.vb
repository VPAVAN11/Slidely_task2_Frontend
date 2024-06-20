<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RoundedButton2 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        RoundedButton2.BackColor = Color.LightSkyBlue
        RoundedButton2.BorderRadius = 20
        RoundedButton2.Location = New Point(44, 456)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(651, 41)
        RoundedButton2.TabIndex = 25
        RoundedButton2.Text = "SUBMIT (CTRL + S) "
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        RoundedButton1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        RoundedButton1.BorderRadius = 20
        RoundedButton1.Location = New Point(26, 381)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(383, 41)
        RoundedButton1.TabIndex = 24
        RoundedButton1.Text = "TOGGLE STOPWATCH (CTRL + T) "
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Location = New Point(210, 290)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(436, 27)
        TextBox5.TabIndex = 23
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(210, 233)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(436, 27)
        TextBox4.TabIndex = 22
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(210, 184)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(436, 27)
        TextBox3.TabIndex = 21
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(210, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(436, 27)
        TextBox2.TabIndex = 20
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(210, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(436, 27)
        TextBox1.TabIndex = 19
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 293)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 40)
        Label6.TabIndex = 18
        Label6.Text = "Stopwatch" & vbCrLf & "    Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(64, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 17
        Label5.Text = "Github Link " & vbCrLf & "for Task 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(64, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 23)
        Label4.TabIndex = 16
        Label4.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(66, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 30)
        Label3.TabIndex = 15
        Label3.Text = "Email"
        Label3.UseCompatibleTextRendering = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(64, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 14
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(162, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 35)
        Label1.TabIndex = 13
        Label1.Text = "  Slidely Task 2 -  Create Submissions"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox6.Location = New Point(433, 388)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(226, 27)
        TextBox6.TabIndex = 26
        TextBox6.Text = "00:00:00"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(740, 533)
        Controls.Add(TextBox6)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
