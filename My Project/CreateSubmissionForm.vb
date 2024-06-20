Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Timers

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private timer As New System.Timers.Timer(1000)

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler timer.Elapsed, AddressOf OnTimedEvent
        Me.KeyPreview = True
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            TextBox5.Text = TextBox6.Text ' Transfer elapsed time to TextBox5
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Validate all fields before proceeding
        If Not ValidateFields() Then
            MessageBox.Show("Please fill in all fields before submitting.")
            Return
        End If

        Dim submission As New SubmissionCreate With {
            .Name = TextBox1.Text,
            .Email = TextBox2.Text,
            .Phone = TextBox3.Text,
            .GithubLink = TextBox4.Text,
            .StopwatchTime = TextBox5.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)


        Await SubmitSubmission(submission)
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            RoundedButton1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            RoundedButton2.PerformClick()
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        Me.Invoke(Sub()
                      TextBox6.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
                  End Sub)
    End Sub

    Private Async Function SubmitSubmission(submission As SubmissionCreate) As Task
        Dim client As New HttpClient()
        Dim apiUrl As String = "http://localhost:3000/submit"

        Try
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission successful!")
        Catch ex As Exception
            MessageBox.Show($"Error submitting form: {ex.Message}")
        End Try
    End Function

    Private Function ValidateFields() As Boolean
        ' Check if any field is empty
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then Return False ' Name
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then Return False ' Email
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then Return False ' Phone
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then Return False ' GitHub link
        If String.IsNullOrWhiteSpace(TextBox5.Text) Then Return False ' Stopwatch time

        Return True
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

Public Class SubmissionCreate
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
