<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        RoundedButton1 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        RoundedButton3 = New RoundedButton()
        RoundedButton4 = New RoundedButton()
        RoundedButton5 = New RoundedButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(157, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 35)
        Label1.TabIndex = 0
        Label1.Text = " Slidely Task 2 - View Submissions"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(67, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(69, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 30)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        Label3.UseCompatibleTextRendering = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(67, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 23)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 4
        Label5.Text = "Github Link " & vbCrLf & "for Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(67, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 40)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch" & vbCrLf & "    Time"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(213, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(445, 27)
        TextBox1.TabIndex = 6
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(213, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(445, 27)
        TextBox2.TabIndex = 7
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(213, 193)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(445, 27)
        TextBox3.TabIndex = 8
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(213, 242)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(445, 27)
        TextBox4.TabIndex = 9
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Location = New Point(213, 299)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(445, 27)
        TextBox5.TabIndex = 10
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(122))
        RoundedButton1.BorderRadius = 20
        RoundedButton1.Location = New Point(28, 390)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(193, 41)
        RoundedButton1.TabIndex = 11
        RoundedButton1.Text = "PREVIOUS (CTRL + P) "
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = Color.LightSkyBlue
        RoundedButton2.BorderRadius = 20
        RoundedButton2.Location = New Point(484, 390)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(185, 41)
        RoundedButton2.TabIndex = 12
        RoundedButton2.Text = "NEXT (CTRL + N) "
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        RoundedButton3.BorderRadius = 20
        RoundedButton3.Location = New Point(260, 390)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(181, 41)
        RoundedButton3.TabIndex = 13
        RoundedButton3.Text = "DELETE (CTRL + D) "
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        RoundedButton4.BorderRadius = 20
        RoundedButton4.Location = New Point(39, 465)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(285, 41)
        RoundedButton4.TabIndex = 14
        RoundedButton4.Text = "EDIT (CTRL + E) "
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton5
        ' 
        RoundedButton5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        RoundedButton5.BorderRadius = 20
        RoundedButton5.Location = New Point(369, 465)
        RoundedButton5.Name = "RoundedButton5"
        RoundedButton5.Size = New Size(300, 41)
        RoundedButton5.TabIndex = 15
        RoundedButton5.Text = "SAVE (CTRL + S) "
        RoundedButton5.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(711, 534)
        Controls.Add(RoundedButton5)
        Controls.Add(RoundedButton4)
        Controls.Add(RoundedButton3)
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
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton4 As RoundedButton
    Friend WithEvents RoundedButton5 As RoundedButton
End Class
