Public Class User

    Public Shared a As Integer = 0
    Public Shared f As Integer = 0
    Shared snd As New SOUND

    Public Shared Sub NewUser()
        If a = 0 Then
            ControlPanel.firstuse = True
            Game.level = 0
            ControlPanel.nmrLevel.Value = 0
            Game.SetValues()
            ControlPanel.walkaway = False

            ControlPanel.txtQuestion.Text = ""
            ControlPanel.txtA.Text = ""
            ControlPanel.txtB.Text = ""
            ControlPanel.txtC.Text = ""
            ControlPanel.txtD.Text = ""

            HostScreen.lblVoteUsed.ForeColor = Color.Black
            HostScreen.txtATAa.ForeColor = Color.White
            HostScreen.txtATAb.ForeColor = Color.White
            HostScreen.txtATAc.ForeColor = Color.White
            HostScreen.txtATAd.ForeColor = Color.White
            GuestScreen.txtATAa.ForeColor = Color.White
            GuestScreen.txtATAb.ForeColor = Color.White
            GuestScreen.txtATAc.ForeColor = Color.White
            GuestScreen.txtATAd.ForeColor = Color.White
            HostScreen.txtATAa.Text = ""
            HostScreen.txtATAb.Text = ""
            HostScreen.txtATAc.Text = ""
            HostScreen.txtATAd.Text = ""
            GuestScreen.txtATAa.Text = ""
            GuestScreen.txtATAb.Text = ""
            GuestScreen.txtATAc.Text = ""
            GuestScreen.txtATAd.Text = ""

            HostScreen.txtQuestion.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            GuestScreen.txtQuestion.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""

            HostScreen.txtWinnings.Text = ""

            TVControlPnl.picPO.Visible = True
            TVControlPnl.picPO.Image = My.Resources.lifeline_3_used
            HostScreen.picPO.Image = My.Resources.lifeline_3_used
            GuestScreen.picPO.Image = My.Resources.lifeline_3_used
            'ControlPanel.chkPlusOne.Checked = True

            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.lbl5050Used.ForeColor = Color.Black
            HostScreen.lblSwitchUsed.ForeColor = Color.Black
            HostScreen.lblPlusOneUsed.ForeColor = Color.Black
            HostScreen.txtExplain.ForeColor = Color.Black

            ControlPanel.txtA.BackColor = Color.Silver
            ControlPanel.txtB.BackColor = Color.Silver
            ControlPanel.txtC.BackColor = Color.Silver
            ControlPanel.txtD.BackColor = Color.Silver
            HostScreen.txtA.ForeColor = Color.White
            HostScreen.txtB.ForeColor = Color.White
            HostScreen.txtC.ForeColor = Color.White
            HostScreen.txtD.ForeColor = Color.White
            HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.txtA.ForeColor = Color.White
            GuestScreen.txtB.ForeColor = Color.White
            GuestScreen.txtC.ForeColor = Color.White
            GuestScreen.txtD.ForeColor = Color.White
            GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.lblWalkedAway.ForeColor = Color.Black

            TVControlPnl.pnlStrap.Visible = False
            ControlPanel.cbWinningPanel.Checked = False

            TVControlPnl.AWTVpanel.Visible = False
            HostScreen.AWHostPanel.Visible = False
            GuestScreen.AWGuestPanel.Visible = False
            ControlPanel.chkAW.Checked = True
            TVControlPnl.pnlFFFWinner.Visible = False
            TVControlPnl.pnlFFFWinner.SendToBack()
            ControlPanel.cbContestant.Checked = False

            ControlPanel.AWstatusSend.BackColor = Color.Gold
            ControlPanel.AWstatusGet.BackColor = Color.Gold
            ControlPanel.AWbtnGet.Enabled = False
            ControlPanel.AWlbA.Text = "NaN"
            ControlPanel.AWlbB.Text = "NaN"
            ControlPanel.AWlbC.Text = "NaN"
            ControlPanel.AWlbD.Text = "NaN"
            ControlPanel.AWlbCount.Text = "NaN"

            TVControlPnl.picAW.Image = My.Resources.lifeline_4
            HostScreen.picAW.Image = My.Resources.lifeline_4
            GuestScreen.picAW.Image = My.Resources.lifeline_4

            Game.ChangeMode(0)

            Question.act = 0
            My.Computer.Audio.Play(My.Resources.hello_long, AudioPlayMode.Background)
            ControlPanel.walkaway = False
            ControlPanel.Button2.Text = "Lights down"
            ControlPanel.Button2.BackColor = Color.Indigo
            ControlPanel.Button2.ForeColor = Color.White
            f = 0

            ' Izberi tekmovalca
            a = 1
            ControlPanel.btnContestantMusic.Enabled = True
        ElseIf a = 1 Then
            ControlPanel.intSound += 1
            'My.Computer.Keyboard.SendKeys("%l", True) 'Lights down key
            With snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(6, False, 1000)
            End With
            ControlPanel.Timer1.Start()
            ControlPanel.Button2.Text = "Nova igra"
            ControlPanel.Button2.BackColor = Color.ForestGreen
            ControlPanel.Button2.ForeColor = Color.Black
            ControlPanel.Button2.Enabled = True
            ControlPanel.btnNewQuestion.Enabled = True
            ControlPanel.grpLifelines.Enabled = True
            ControlPanel.gbPublicVote.Enabled = True
            ControlPanel.GroupBoxQuizControl.Enabled = True

            ControlPanel.btnContestantMusic.Text = "Zberi prijave"
            ControlPanel.btnContestantMusic.Enabled = True
            ControlPanel.btnSelectContestant.Enabled = False
            a = 0
        End If
    End Sub
    Public Shared Sub GetContestants()
        If f = 0 Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.fastest_finger_read_question, AudioPlayMode.Background)
            ControlPanel.lbMusicLeft.Text = "30"
            ControlPanel.timerMusic.Start()
            ControlPanel.btnContestantMusic.Text = "Zberi prijave"
            TVControlPnl.pbQRcode.BringToFront()
            TVControlPnl.pbQRcode.Visible = True
            HostScreen.lblConestant.Visible = False
            HostScreen.lblContestantText.Visible = False
            f = 1
        ElseIf f = 1 Then
            ControlPanel.intSound += 1
            With snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(43, False, 1000)
            End With
            ControlPanel.lbMusicLeft.Text = "20"
            ControlPanel.timerMusic.Start()
            My.Computer.Audio.Stop()
            ControlPanel.btnContestantMusic.Text = "Prikaži"
            f = 2
        ElseIf (f = 2 Or f = 4) Then
            ControlPanel.intSound += 1
            With snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(35, False, 1000)
            End With
            ControlPanel.timerMusic.Stop()
            My.Computer.Audio.Stop()
            ControlPanel.btnSelectContestant.Text = "Povabi"
            ControlPanel.btnSelectContestant.Enabled = True
            TVControlPnl.pbQRcode.Visible = False
            TVControlPnl.pbQRcode.SendToBack()
            TVControlPnl.lblFFFWinnerName.Text = ControlPanel.tbContestant.Text
            TVControlPnl.pnlFFFWinner.Visible = True
            TVControlPnl.pnlFFFWinner.BringToFront()
            ControlPanel.cbContestant.Checked = True
            ControlPanel.btnContestantMusic.Enabled = False
            HostScreen.lblContestantText.Text = ControlPanel.tbContestant.Text
            HostScreen.lblConestant.Visible = True
            HostScreen.lblContestantText.Visible = True
            f = 3
        End If
    End Sub

    Public Shared Sub SelectContestants()
        If f = 3 Then
            My.Computer.Audio.Play(My.Resources.fastest_finger_read_answer_order, AudioPlayMode.Background)
            ControlPanel.btnSelectContestant.Text = "Reset"
            ControlPanel.btnContestantMusic.Enabled = True
            f = 4
        ElseIf f = 4 Then
            My.Computer.Audio.Stop()
            TVControlPnl.pnlFFFWinner.Visible = False
            TVControlPnl.pnlFFFWinner.SendToBack()
            ControlPanel.cbContestant.Checked = False
            ControlPanel.btnContestantMusic.Text = "Pokaži QR"
            ControlPanel.btnContestantMusic.Enabled = True
            f = 0
        End If
    End Sub

End Class
