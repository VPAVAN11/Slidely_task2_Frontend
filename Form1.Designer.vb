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
        Button1 = New RoundedButton()
        Button2 = New RoundedButton()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        HELPToolStripMenuItem = New ToolStripMenuItem()
        Button3 = New RoundedButton()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button1.BorderRadius = 20
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(24, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(711, 65)
        Button1.TabIndex = 0
        Button1.Text = "VIEW SUBMISSIONS  (CTRL + V)   "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.LightSkyBlue
        Button2.BorderRadius = 20
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 2
        Button2.Location = New Point(24, 243)
        Button2.Name = "Button2"
        Button2.Size = New Size(711, 62)
        Button2.TabIndex = 1
        Button2.Text = "CREATE NEW SUBMISSIONS  (CTRL + N"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(195, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 35)
        Label1.TabIndex = 4
        Label1.Text = "Slidely Task 2 - Slidely Form App"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label2.Location = New Point(104, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(576, 20)
        Label2.TabIndex = 5
        Label2.Text = "Welcome to Slidely Form App, where your submissions are managed effortlessly!"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ABOUTToolStripMenuItem, HELPToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(757, 28)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ABOUTToolStripMenuItem
        ' 
        ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        ABOUTToolStripMenuItem.Size = New Size(71, 24)
        ABOUTToolStripMenuItem.Text = "ABOUT"
        ' 
        ' HELPToolStripMenuItem
        ' 
        HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        HELPToolStripMenuItem.Size = New Size(57, 24)
        HELPToolStripMenuItem.Text = "HELP"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.BackColor = Color.PaleGreen
        Button3.BorderRadius = 20
        Button3.FlatAppearance.BorderColor = Color.Black
        Button3.FlatAppearance.BorderSize = 2
        Button3.Location = New Point(24, 330)
        Button3.Name = "Button3"
        Button3.Size = New Size(711, 62)
        Button3.TabIndex = 7
        Button3.Text = "SEARCH SUBMISSIONS  (CTRL + S)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(757, 429)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Slidely Form App"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As RoundedButton
    Friend WithEvents Button2 As RoundedButton
    Friend WithEvents Label1 As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As RoundedButton
End Class
