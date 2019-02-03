Public Class Form2

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Public unit As String = "52"
    Public passwd As String = "cookie"


    'Top bar functions

    'Exit out
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
    'Minimize window
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Start Window Bar Movement

    'Window bar movement up/down (panel)
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    'Window bar movement left/right (panel)
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    'Window bar movement up/down (panel)
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    'Window bar movement up/down (logo)
    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    'Window bar movement left/right (logo)
    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    'Window bar movement up/down (logo)
    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        drag = False
    End Sub

    'Window bar movement up/down (text)
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    'Window bar movement left/right (text)
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    'Window bar movement up/down (text)
    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub
    'End of Window Bar Movement


    'Star of hover hints

    'Hint for login
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        Dim but As New ToolTip()
        but.ToolTipTitle = "Login"
        but.UseFading = True
        but.UseAnimation = True
        but.IsBalloon = True
        but.ShowAlways = True
        but.AutoPopDelay = 5000
        but.InitialDelay = 1000
        but.ReshowDelay = 500
        but.SetToolTip(PictureBox4, "Press to log in to FCS.")
    End Sub

    'Hint for clear fiels
    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        Dim but As New ToolTip()
        but.ToolTipTitle = "Clear"
        but.UseFading = True
        but.UseAnimation = True
        but.IsBalloon = True
        but.ShowAlways = True
        but.AutoPopDelay = 5000
        but.InitialDelay = 1000
        but.ReshowDelay = 500
        but.SetToolTip(PictureBox5, "Clear all fields.")
    End Sub
    'End of hover hints

    'Login ensuring all the right things are functioning
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If pass.Text = passwd And department.Text = unit Then
            Me.Hide()
            department.Text = ""
            pass.Text = ""

            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        department.Text = ""
        pass.Text = ""
    End Sub
End Class