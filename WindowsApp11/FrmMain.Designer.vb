<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlShield = New System.Windows.Forms.Panel()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.tmrPlay = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotlSyllableToCurr = New System.Windows.Forms.Label()
        Me.lblFront = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblBeatPerCurSyllable = New System.Windows.Forms.Label()
        Me.lblCntSpaces = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblCntSyllable = New System.Windows.Forms.Label()
        Me.lblLyricWidth = New System.Windows.Forms.Label()
        Me.pnlShield.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlShield
        '
        Me.pnlShield.Controls.Add(Me.lblBack)
        Me.pnlShield.Location = New System.Drawing.Point(19, 83)
        Me.pnlShield.Margin = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.pnlShield.Name = "pnlShield"
        Me.pnlShield.Size = New System.Drawing.Size(12, 298)
        Me.pnlShield.TabIndex = 4
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.ForeColor = System.Drawing.Color.Blue
        Me.lblBack.Location = New System.Drawing.Point(3, 0)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(73, 59)
        Me.lblBack.TabIndex = 5
        Me.lblBack.Text = "##"
        '
        'tmrPlay
        '
        Me.tmrPlay.Interval = 1
        '
        'lblTotlSyllableToCurr
        '
        Me.lblTotlSyllableToCurr.AutoSize = True
        Me.lblTotlSyllableToCurr.Location = New System.Drawing.Point(12, 396)
        Me.lblTotlSyllableToCurr.Name = "lblTotlSyllableToCurr"
        Me.lblTotlSyllableToCurr.Size = New System.Drawing.Size(38, 59)
        Me.lblTotlSyllableToCurr.TabIndex = 7
        Me.lblTotlSyllableToCurr.Text = "."
        '
        'lblFront
        '
        Me.lblFront.AutoSize = True
        Me.lblFront.ForeColor = System.Drawing.Color.Red
        Me.lblFront.Location = New System.Drawing.Point(22, 83)
        Me.lblFront.Name = "lblFront"
        Me.lblFront.Size = New System.Drawing.Size(73, 59)
        Me.lblFront.TabIndex = 8
        Me.lblFront.Text = "##"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(12, 9)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(49, 59)
        Me.lblSpeed.TabIndex = 9
        Me.lblSpeed.Text = "0"
        '
        'lblBeatPerCurSyllable
        '
        Me.lblBeatPerCurSyllable.AutoSize = True
        Me.lblBeatPerCurSyllable.Location = New System.Drawing.Point(447, 9)
        Me.lblBeatPerCurSyllable.Name = "lblBeatPerCurSyllable"
        Me.lblBeatPerCurSyllable.Size = New System.Drawing.Size(49, 59)
        Me.lblBeatPerCurSyllable.TabIndex = 10
        Me.lblBeatPerCurSyllable.Text = "0"
        '
        'lblCntSpaces
        '
        Me.lblCntSpaces.AutoSize = True
        Me.lblCntSpaces.Location = New System.Drawing.Point(583, 9)
        Me.lblCntSpaces.Name = "lblCntSpaces"
        Me.lblCntSpaces.Size = New System.Drawing.Size(49, 59)
        Me.lblCntSpaces.TabIndex = 12
        Me.lblCntSpaces.Text = "0"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 486)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(327, 78)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblCntSyllable
        '
        Me.lblCntSyllable.AutoSize = True
        Me.lblCntSyllable.Location = New System.Drawing.Point(735, 9)
        Me.lblCntSyllable.Name = "lblCntSyllable"
        Me.lblCntSyllable.Size = New System.Drawing.Size(49, 59)
        Me.lblCntSyllable.TabIndex = 14
        Me.lblCntSyllable.Text = "0"
        '
        'lblLyricWidth
        '
        Me.lblLyricWidth.AutoSize = True
        Me.lblLyricWidth.Location = New System.Drawing.Point(110, 9)
        Me.lblLyricWidth.Name = "lblLyricWidth"
        Me.lblLyricWidth.Size = New System.Drawing.Size(49, 59)
        Me.lblLyricWidth.TabIndex = 15
        Me.lblLyricWidth.Text = "0"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(25.0!, 59.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1085, 577)
        Me.Controls.Add(Me.lblLyricWidth)
        Me.Controls.Add(Me.lblCntSyllable)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblCntSpaces)
        Me.Controls.Add(Me.lblBeatPerCurSyllable)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblTotlSyllableToCurr)
        Me.Controls.Add(Me.pnlShield)
        Me.Controls.Add(Me.lblFront)
        Me.Font = New System.Drawing.Font("Noto Sans CJK JP Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.Name = "FrmMain"
        Me.Text = "Main"
        Me.pnlShield.ResumeLayout(False)
        Me.pnlShield.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlShield As Panel
    Friend WithEvents tmrPlay As Timer
    Friend WithEvents lblBack As Label
    Friend WithEvents lblTotlSyllableToCurr As Label
    Friend WithEvents lblFront As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblBeatPerCurSyllable As Label
    Friend WithEvents lblCntSpaces As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblCntSyllable As Label
    Friend WithEvents lblLyricWidth As Label
End Class
