Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private isEditing As Boolean = False

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        DisplaySubmission()
        Me.KeyPreview = True
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim apiUrl As String = "http://localhost:3000/read"

            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                Else
                    MessageBox.Show($"Error loading submissions: {response.ReasonPhrase}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error loading submissions: {ex.Message}")
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission As Submission = submissions(currentIndex)
            TextBox1.Text = submission.Name
            TextBox2.Text = submission.Email
            TextBox3.Text = submission.Phone
            TextBox4.Text = submission.GithubLink
            TextBox5.Text = submission.StopwatchTime

            ' Set TextBoxes as read-only if not editing
            TextBox1.ReadOnly = Not isEditing
            TextBox2.ReadOnly = Not isEditing
            TextBox3.ReadOnly = Not isEditing
            TextBox4.ReadOnly = Not isEditing
            TextBox5.ReadOnly = Not isEditing

            ' Show/hide buttons based on editing status
            RoundedButton4.Visible = Not isEditing ' Edit button
            RoundedButton5.Visible = isEditing   ' Save button
        Else
            ' Clear the textboxes if there are no submissions to display
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        If submissions IsNot Nothing AndAlso currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        Else
            MessageBox.Show("Already at the first submission.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        Else
            MessageBox.Show("Already at the last submission.")
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            Dim id As String = submission.Id ' Assuming each submission has a unique ID

            Using client As New HttpClient()
                Dim apiUrl As String = $"http://localhost:3000/delete/{id}"

                Try
                    Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully")
                        submissions.RemoveAt(currentIndex)
                        If currentIndex >= submissions.Count Then
                            currentIndex -= 1
                        End If
                        DisplaySubmission()
                    Else
                        MessageBox.Show($"Error deleting submission: {response.ReasonPhrase}")
                    End If
                Catch ex As Exception
                    MessageBox.Show($"Error deleting submission: {ex.Message}")
                End Try
            End Using
        Else
            MessageBox.Show("No submission to delete.")
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            RoundedButton1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            RoundedButton2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            RoundedButton3.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            RoundedButton4.PerformClick() ' Ctrl + E for Edit
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            RoundedButton5.PerformClick() ' Ctrl + S for Save
        End If
    End Sub

    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        ' Enable editing
        isEditing = True
        DisplaySubmission()
    End Sub

    Private Sub RoundedButton5_Click(sender As Object, e As EventArgs) Handles RoundedButton5.Click
        ' Validate and save changes
        If ValidateAndSaveChanges() Then
            ' Disable editing
            isEditing = False
            DisplaySubmission()
        End If
    End Sub

    Private Function ValidateAndSaveChanges() As Boolean
        ' Implement validation logic here
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        ' Update submission in the list (optional step if managing locally)
        Dim updatedSubmission As Submission = submissions(currentIndex)
        updatedSubmission.Name = TextBox1.Text
        updatedSubmission.Email = TextBox2.Text
        updatedSubmission.Phone = TextBox3.Text
        updatedSubmission.GithubLink = TextBox4.Text
        updatedSubmission.StopwatchTime = TextBox5.Text

        ' Send update to server (optional step if managing locally)
        UpdateSubmissionOnServer(updatedSubmission)

        MessageBox.Show("Changes saved successfully.")
        Return True
    End Function

    Private Async Sub UpdateSubmissionOnServer(updatedSubmission As Submission)
        Dim apiUrl As String = $"http://localhost:3000/update/{updatedSubmission.Id}"

        Try
            Using client As New HttpClient()
                Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    ' Handle success
                Else
                    ' Handle failure
                    MessageBox.Show($"Failed to update submission: {response.ReasonPhrase}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating submission: {ex.Message}")
        End Try
    End Sub
End Class

Public Class Submission
    Public Property Id As String
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
