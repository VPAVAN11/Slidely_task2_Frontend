Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' This will handle the "View Submissions" action
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' This will handle the "Create Submission" action
        Dim createSubmissionForm As New CreateSubmissionForm
        createSubmissionForm.ShowDialog
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' This will handle the "Search Submission" action
        Dim searchSubmissionForm As New SearchSubmissionForm()
        searchSubmissionForm.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.A Then
            ABOUTToolStripMenuItem.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.H Then
            HELPToolStripMenuItem.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Button3.PerformClick()
        End If
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Dim aboutForm As New About()
        aboutForm.ShowDialog()
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click
        Dim helpForm As New Help()
        helpForm.ShowDialog()
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
