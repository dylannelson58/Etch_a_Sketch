Option Explicit On
Option Strict On

'Dylan Nelson
'RCET0265 
'Spring 2021
'Etch A Sketch
'https://github.com/dylannelson58/Etch_a_Sketch

Imports System.Math
Imports System.Threading.Thread

Public Class Etch_a_Sketch
    Dim g As Graphics
    Dim mainPen As New Pen(Color.Black)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click


        ColorDialog.ShowDialog()
        Me.mainPen.Color = ColorDialog.Color
        'PenColor(ColorDialog.Color)
    End Sub
    Sub UpdateParms()
        'g.PageUnit = GraphicsUnit.Pixel
        'g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

        'Scale 
        'This will be the width of the scaled graphics object 
        Dim xMax As Single = 360
        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)

        'This will be the height of the scaled graphics object 
        Dim yMax As Single = 100
        'half the height in pixels is to 100 units
        '100 up, 100 down
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 2) / yMax)
        Me.g.ScaleTransform(xScale, yScale) 'apply scale

        'Offset 
        'y=0 to vertical center
        Dim yOffset As Single = CSng(yMax)
        'left edge
        Dim xOffset As Single
        Me.g.TranslateTransform(xOffset, yOffset)

        'Rotation 0
        Dim rotation As Single
        Me.g.RotateTransform(rotation)
    End Sub

    'Function PenColor(newColor As Color) As Color
    '    Static _penColor As Color
    '    Return _penColor
    'End Function
    Sub MouseDraw(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer) ', mainpen.Color As Color)
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        'Dim penColor As Color
        'penColor = Color.Red
        Dim pen As New Pen(Me.mainPen.Color)
        'draws the line
        g.DrawLine(pen, x1, y1, x2, y2)
        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove
        Static oldX As Integer
        Static oldY As Integer
        Static penColor As Color

        'Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {penColor.ToString}"
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.mainPen.Color().ToString}"




        Select Case e.Button
            Case e.Button.Left
                MouseDraw(oldX, oldY, e.X, e.Y)
            Case e.Button.Right

            Case e.Button.Middle
                ColorDialog.ShowDialog()
                Me.mainPen.Color = ColorDialog.Color
                'Case Else
                'MsgBox("Something went wrong")
        End Select
        oldX = e.X
        oldY = e.Y
    End Sub

    Sub DrawWave()
        Dim _start As Point
        Dim _end As Point

        Dim wave As Graphics = DisplayPictureBox.CreateGraphics
        Dim degrees As Integer
        Dim angle As Decimal

        Dim yOffset As Single = CSng(DisplayPictureBox.Height / 2)
        wave.TranslateTransform(0, yOffset)

        _start.X = 0
        _start.Y = 0

        '_end.X = 350
        '_end.Y = -90

        Dim xMax As Single = 360
        Dim yMax As Single = 100

        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 2) / yMax)
        wave.ScaleTransform(xScale, yScale)

        DisplayPictureBox.Refresh()

        mainPen.Color = Color.Red

        'Vi = Vp * sin(360 * f * t + theta) + DC
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Sin((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next

        mainPen.Color = Color.Green
        'plot Cos
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Cos((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        mainPen.Color = Color.Blue
        'plot Tan
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            Try
                _end.Y = CInt(yMax * Tan((PI / 180) * _end.X)) * -1
            Catch

            End Try

            wave.DrawLine(mainPen, _start, _end)

            _start.X = _end.X
            _start.Y = _end.Y
        Next

        wave.Dispose()

        'Me.g.TranslateTransform(0, yOffset * -1)
        'dyStatusLabel.Text = CStr(0)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click
        DrawWave()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Shake()
        DisplayPictureBox.Refresh()
    End Sub

    Sub Shake()
        Dim shakeAmount = 25

        For i = 1 To 10
            Me.Top += shakeAmount
            Me.Left += shakeAmount
            Sleep(50)
            shakeAmount *= -1
        Next

    End Sub


End Class
