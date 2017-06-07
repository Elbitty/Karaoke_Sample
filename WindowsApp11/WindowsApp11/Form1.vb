Public Class Form1

    Dim FullLyric As String = "한 번 더 나에게 질풍 같은 용기를 거친 파도에도 굴하지 않게~"
    Dim Lyric As String
    Dim Beat() As Integer = {0, 2, 2, 4, 2, 1, 5, 2, 1, 3, 2, 2, 1, 5, 2, 1, 3, 2, 2, 1, 3, 2, 2, 1, 4, 6}

    Dim BeatCursor As Integer = 0 '현재 가사가 도달한 위치에 대한 커서
    Dim BPM As Integer = 120 '곡의 BPM

    Dim BeatOverNode As Integer = 4 '마디당 박자
    Dim BeatOverBeat As Integer = 4 '박자당 박자

    Dim Adder As Double = 0

    Dim nextWidth As Integer = -1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        If Panel1.Width > nextWidth Then

            BeatCursor += 1
            If Mid(FullLyric, BeatCursor, 1) = " " Then
                Panel1.Width += (GetCharWidth("$ $", Font) - GetCharWidth("$$", Font))
                Label7.Text += 1
            End If


            If BeatCursor = 1 Then
                Adder = GetCharWidth(Mid(Lyric, 1, 1), Font) - 10
            Else
                Adder = GetCharWidth(Mid(Lyric, 1, BeatCursor + 1), Font) - GetCharWidth(Mid(Lyric, 1, BeatCursor), Font)
            End If

            Label2.Text = Adder
            nextWidth = Panel1.Width + Adder

        Else

            Label3.Text = Mid(Lyric, 1, BeatCursor)
            Label5.Text = Beat(BeatCursor)

            Timer1.Interval = (((60 / BPM) * 1000) / Adder * Beat(BeatCursor) * (BeatOverBeat / BeatOverNode))
            Label2.Text = Timer1.Interval
        End If


        Panel1.Width += 3

        Label8.Text = BeatCursor

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = FullLyric
        Label1.Text = FullLyric
        Lyric = FullLyric.Replace(" ", "")
        Panel1.Width = 10

        Timer1.Interval = ((60 / BPM) * 1000)
    End Sub

    Private Function GetCharWidth(A As String, Fontx As Font) As Double

        Dim textSizeA As Size = TextRenderer.MeasureText(A, Fontx)

        Return (textSizeA.Width)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
End Class
