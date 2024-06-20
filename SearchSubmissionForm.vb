Imports System.Net.Http
Imports Newtonsoft.Json
Imports MyApp.Models
Imports System.Text.RegularExpressions

Public Class SearchSubmissionForm
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(TextBoxEmail.Text) Then
            MessageBox.Show("Please enter an email to search.")
            Return
        End If

        If Not IsValidEmail(TextBoxEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        Await SearchSubmissionByEmail(TextBoxEmail.Text)
    End Sub

    Private Async Function SearchSubmissionByEmail(email As String) As Task
        Using client As New HttpClient()
            Dim apiUrl As String = $"http://localhost:3000/search?email={email}"

            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                    DisplaySubmissions(submissions)
                Else
                    MessageBox.Show("No submissions found with the given email.")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error searching submissions: {ex.Message}")
            End Try
        End Using
    End Function

    Private Sub DisplaySubmissions(submissions As List(Of Submission))
        ' Clear previous results
        ListViewResults.Items.Clear()

        For Each submission In submissions
            Dim item As New ListViewItem(submission.Id)
            item.SubItems.Add(submission.Name)
            item.SubItems.Add(submission.Email)
            item.SubItems.Add(submission.Phone)
            item.SubItems.Add(submission.GithubLink)
            item.SubItems.Add(submission.StopwatchTime)
            ListViewResults.Items.Add(item)
        Next
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub SearchSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to True to capture key events
        Me.KeyPreview = True

        ' Initialize ListView columns
        ListViewResults.View = View.Details
        ListViewResults.Columns.Add("ID", 50, HorizontalAlignment.Left)
        ListViewResults.Columns.Add("Name", 100, HorizontalAlignment.Left)
        ListViewResults.Columns.Add("Email", 150, HorizontalAlignment.Left)
        ListViewResults.Columns.Add("Phone", 100, HorizontalAlignment.Left)
        ListViewResults.Columns.Add("GitHub", 150, HorizontalAlignment.Left)
        ListViewResults.Columns.Add("Stopwatch Time", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub SearchSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub ListViewResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewResults.SelectedIndexChanged

    End Sub
End Class
