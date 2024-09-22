Public Class Form1
    Private random As New Random()
    Private moveDirection As Integer = 5 ' Pixels to move per timer tick
    Private timer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up a timer for moving PictureBox2
        timer.Interval = 50 ' Adjust this value to change speed
        AddHandler timer.Tick, AddressOf MoveTextBox2
        timer.Start()
    End Sub

    Private Sub MoveTextBox2(sender As Object, e As EventArgs)
        ' Move PictureBox2 horizontally
        PictureBox2.Left += moveDirection

        ' Make PictureBox2 disappear when it reaches the right edge
        If PictureBox2.Left >= Me.ClientSize.Width Then
            PictureBox2.Visible = False
            timer.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox3.Click
        ChangeLabel1Text()
    End Sub

    Private Sub ChangeLabel1Text()
        Dim messages() As String = {
            "Hello there!",
            "look its a plane!",
            "Hits a bird!"
        }

        Dim randomIndex As Integer = random.Next(0, messages.Length)
        Label1.Text = messages(randomIndex)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class