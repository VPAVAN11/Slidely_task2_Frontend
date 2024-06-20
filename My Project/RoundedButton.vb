Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedButton
    Inherits Button

    Private _borderRadius As Integer = 20 ' Default roundness

    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate() ' Redraw the button when the property changes
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        SetRoundedRegion()
    End Sub

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Draw button with rounded corners
        Dim rectF As New RectangleF(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundedRect(rectF, _borderRadius)

        Me.Region = New Region(path)

        ' Optionally, draw border
        Using pen As New Pen(Me.ForeColor, 1)
            pevent.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Sub SetRoundedRegion()
        Dim rectF As New RectangleF(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundedRect(rectF, _borderRadius)
        Me.Region = New Region(path)
    End Sub

    Private Function GetRoundedRect(rect As RectangleF, radius As Integer) As GraphicsPath
        Dim diameter As Single = radius * 2
        Dim sizeF As New SizeF(diameter, diameter)
        Dim arc As New RectangleF(rect.Location, sizeF)
        Dim path As New GraphicsPath()

        ' top left arc
        path.AddArc(arc, 180, 90)

        ' top right arc
        arc.X = rect.Right - diameter
        path.AddArc(arc, 270, 90)

        ' bottom right arc
        arc.Y = rect.Bottom - diameter
        path.AddArc(arc, 0, 90)

        ' bottom left arc
        arc.X = rect.Left
        path.AddArc(arc, 90, 90)

        path.CloseFigure()
        Return path
    End Function
End Class
