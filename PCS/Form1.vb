Public Class Form1
    'ints for panels and shit
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    'Start of window movement

    'Dragging top bar up/down for (for top panel)
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    'Dragging top bar left/right for (for top panel)
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    'Dragging top bar up for (for top panel)
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub
    'Dragging top bar up/down for (top logo)
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    'Dragging top bar left/right (top logo)
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    'Dragging top bar up (top logo)
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
    'Dragging top bar (top text)
    Private Sub Label8_MouseUp(sender As Object, e As MouseEventArgs) Handles Label8.MouseUp
        drag = False
    End Sub
    'Dragging top bar left/right (top text)
    Private Sub Label8_MouseMove(sender As Object, e As MouseEventArgs) Handles Label8.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    'Dragging top bar up/down for (top logo)
    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    'End of window movement


    'Exit
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
    'Maximize/normalizing
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    'Minimize too????
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Minimize
    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If MsgBox("In service on call", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        MsgBox("In service free of calls", MsgBoxStyle.YesNo)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label3_Click_2(sender As Object, e As EventArgs) Handles Label3.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        TabControl1.SelectTab(2)
    End Sub
End Class
