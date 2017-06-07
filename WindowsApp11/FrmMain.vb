Public Class FrmMain

    Dim FullLyric As String = "한 번 더 나에게 질풍 같은 용기를 거친 파도에도 굴하지 않게~" '전체 가사
    Dim Lyric As String '스페이스를 제외한 가사
    Dim Beat() As Byte = {0, 2, 2, 4, 2, 1, 5, 2, 1, 3, 2, 2, 1, 5, 2, 1, 3, 2, 2, 1, 3, 2, 2, 1, 4, 6} '편의를 위하여 0번 index는 쓰이지 않음.

    Dim BeatCursor As Integer = 0 '현재 가사가 도달한 위치를 지시하는 커서.
    Dim BPM As Integer = 240 '곡의 BPM. 윈폼의 한계 상 Timer가 지연되어 정확히 작동하지는 않는다. 따라서 곡의 BPM보다 어느 정도 큰 값을 주어야 함.

    Dim BeatOverBeat As Byte = 4 '박자당 박자
    Dim BeatOverNode As Byte = 4 '마디당 박자

    Dim BeatMin As Byte = 2 '전체 배속이다. BeatMin 수치는 어떻던 관계 없이 BPM * BeatMin이 일정하면 됨.

    Dim Adder As Double = 0 '이번 음절의 Width

    Dim nextWidth As Integer = -1 '다음번 음절을 포함한 Width 변수.

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrPlay.Tick

        If pnlShield.Width > nextWidth Then

            BeatCursor += 1
            If Mid(FullLyric, BeatCursor, 1) = " " Then '스페이스를 스킵하기 위함.
                pnlShield.Width += (GetCharWidth("$ $", Font) - GetCharWidth("$$", Font)) '더미 텍스트를 스페이스 양쪽에 넣어 스페이스 1개당 차지하는 Width를 구한다.

                lblCntSpaces.Text += 1 '디버깅용
            End If

            If BeatCursor = 1 Then
                Adder = GetCharWidth(Mid(Lyric, 1, 1), Font) - 10
            Else
                Adder = GetCharWidth(Mid(Lyric, 1, BeatCursor + 1), Font) - GetCharWidth(Mid(Lyric, 1, BeatCursor), Font)
            End If

            lblSpeed.Text = Adder '디버깅용

            nextWidth = pnlShield.Width + Adder

        Else

            lblTotlSyllableToCurr.Text = Mid(Lyric, 1, BeatCursor)
            lblBeatPerCurSyllable.Text = Beat(BeatCursor)

            tmrPlay.Interval = (((60 / BPM) * 1000) / Adder * Beat(BeatCursor) * (BeatOverBeat / BeatOverNode))
            'Interval로 음절당 빠르기를 조절한다. pnlShield의 Width로 음절의 빠르기를 조절하는 것 역시 가능하나, 윈폼의 한계 상 에일리어싱 발생함.

            lblSpeed.Text = tmrPlay.Interval '디버깅용

        End If
        pnlShield.Width += BeatMin

        lblCntSyllable.Text = BeatCursor '디버깅용

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFront.Text = FullLyric '뒷쪽 레이블
        lblBack.Text = FullLyric '앞쪽 레이블
        pnlShield.Width = 0
        Lyric = FullLyric.Replace(" ", "") '스페이스는 음절에 해당하지 않으므로 박자 판정을 위하여 제거한다. TODO: 특문 역시 제거가 필요함.

        tmrPlay.Interval = ((60 / BPM) * 1000)
    End Sub

    Private Function GetCharWidth(A As String, Fontx As Font) As Double '가변폭 폰트에서 한 폰트에 해당하는 Width 값을 구한다.

        Dim textSizeA As Size = TextRenderer.MeasureText(A, Fontx)
        Return (textSizeA.Width)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrPlay.Enabled = True
    End Sub
End Class
