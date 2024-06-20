<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchSubmissionForm
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
        TextBoxEmail = New TextBox()
        btnSearch = New Button()
        ListViewResults = New ListView()
        SuspendLayout()
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxEmail.Location = New Point(16, 18)
        TextBoxEmail.Margin = New Padding(4, 5, 4, 5)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.PlaceholderText = "Enter Email id "
        TextBoxEmail.Size = New Size(727, 27)
        TextBoxEmail.TabIndex = 0
        TextBoxEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.Location = New Point(96, 65)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(549, 35)
        btnSearch.TabIndex = 1
        btnSearch.Text = "SEARCH (CTRL +S)"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' ListViewResults
        ' 
        ListViewResults.BackColor = SystemColors.Info
        ListViewResults.Location = New Point(16, 124)
        ListViewResults.Margin = New Padding(4, 5, 4, 5)
        ListViewResults.Name = "ListViewResults"
        ListViewResults.Size = New Size(721, 264)
        ListViewResults.TabIndex = 2
        ListViewResults.UseCompatibleStateImageBehavior = False
        ListViewResults.View = View.Details
        ' 
        ' SearchSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(761, 410)
        Controls.Add(ListViewResults)
        Controls.Add(btnSearch)
        Controls.Add(TextBoxEmail)
        Margin = New Padding(4, 5, 4, 5)
        Name = "SearchSubmissionForm"
        Text = "Search Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents ListViewResults As ListView ' Changed ListBox to ListView
End Class
