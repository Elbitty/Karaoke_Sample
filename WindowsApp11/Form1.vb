﻿Public Class Form1

    Dim FullLyric As String = "한 번 더 나에게 질풍 같은 용기를 거친 파도에도 굴하지 않게~" '전체 가사
    Dim Lyric As String '스페이스를 제외한 가사
    Dim Beat() As Integer = {0, 2, 2, 4, 2, 1, 5, 2, 1, 3, 2, 2, 1, 5, 2, 1, 3, 2, 2, 1, 3, 2, 2, 1, 4, 6} '0번 index는 쓰이지 않음.

    Dim BeatCursor As Integer = 0 '현재 가사가 도달한 위치를 지시하는 커서
    Dim BPM As Integer = 120 '곡의 BPM

    Dim BeatOverNode As Integer = 4 '마디당 박자
    Dim BeatOverBeat As Integer = 4 '박자당 박자

    Dim Adder As Double = 0 '이번 음절의 Width

    Dim nextWidth As Integer = -1 '다음번 음절을 포함한 Width 변수

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Panel1.Width > nextWidth Then

            BeatCursor += 1
            If Mid(FullLyric, BeatCursor, 1) = " " Then '스페이스 스킵용
                Panel1.Width += (GetCharWidth("$ $", Font) - GetCharWidth("$$", Font)) '더미 텍스트를 스페이스 양쪽에 넣어 스페이스 1개당 차지하는 Width를 구한다.

                Label7.Text += 1 '디버깅용
            End If

            If BeatCursor = 1 Then
                Adder = GetCharWidth(Mid(Lyric, 1, 1), Font) - 10
            Else
                Adder = GetCharWidth(Mid(Lyric, 1, BeatCursor + 1), Font) - GetCharWidth(Mid(Lyric, 1, BeatCursor), Font)
            End If

            Label2.Text = Adder '디버깅용

            nextWidth = Panel1.Width + Adder

        Else

            Label3.Text = Mid(Lyric, 1, BeatCursor)
            Label5.Text = Beat(BeatCursor)

            Timer1.Interval = (((60 / BPM) * 1000) / Adder * Beat(BeatCursor) * (BeatOverBeat / BeatOverNode))
            'Interval로 음절당 빠르기를 조절한다. Width로 조절하는 것도 가능하나, 윈폼의 한계상 에일리어싱 발생함.

            Label2.Text = Timer1.Interval '디버깅용
        End If

        Panel1.Width += 3

        Label8.Text = BeatCursor '디버깅용

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = FullLyric '뒷쪽 레이블
        Label1.Text = FullLyric '앞쪽 레이블

        Lyric = FullLyric.Replace(" ", "") '스페이스는 음절에 해당하지 않으므로 박자 판정을 위하여 제거한다. TODO: 특문 역시 제거가 필요함.

        Timer1.Interval = ((60 / BPM) * 1000)
    End Sub

    Private Function GetCharWidth(A As String, Fontx As Font) As Double '가변폭 폰트에서 한 폰트에 해당하는 Width 값을 구한다.

        Dim textSizeA As Size = TextRenderer.MeasureText(A, Fontx)
        Return (textSizeA.Width)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
End Class
