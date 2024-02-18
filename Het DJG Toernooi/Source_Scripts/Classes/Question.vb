Public Class Question

    Public Shared act As Integer
    Public Shared useMusic As Boolean = False

    Dim newQ As New QDatabase

    Public Sub Generate()
        ControlPanel.i = 0

        HostScreen.txtExplain.ForeColor = Color.Black

        PlayCue()
        If act = 5 Then
            HostScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            GuestScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Visible = True
            ControlPanel.btnNewQuestion.Text = "Naprej"
            ControlPanel.btnNewQuestion.Enabled = False
            ControlPanel.btnReveal.Enabled = False
            ControlPanel.GroupBoxQuiz.Enabled = True
            act = 5
        End If
        If act = 4 Then
            HostScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            GuestScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Visible = True
            ControlPanel.btnNewQuestion.Text = "Pokaži D"
            act = 5
        End If
        If act = 3 Then
            HostScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            GuestScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Visible = True
            ControlPanel.btnNewQuestion.Text = "Pokaži C"
            act = 4
        End If
        If act = 2 Then
            HostScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            GuestScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Visible = True
            ControlPanel.btnNewQuestion.Text = "Pokaži B"
            act = 3
        End If
        If act = 1 Then
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picTree.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            ControlPanel.cbWinningPanel.Checked = False
            HostScreen.pnlStrap.Visible = False
            GuestScreen.pnlStrap.Visible = False
            TVControlPnl.pnlQuestion.Visible = True
            ControlPanel.chkShowQuestion.Checked = True
            ControlPanel.btnNewQuestion.Text = "Pokaži A"
            act = 2
        End If
        If act = 0 Then
            act = 1
            newQ.newQuestion()
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.lbl5050Used.ForeColor = Color.Black
            HostScreen.lblSwitchUsed.ForeColor = Color.Black
            HostScreen.lblPlusOneUsed.ForeColor = Color.Black
            HostScreen.lblVoteUsed.ForeColor = Color.Black
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
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            TVControlPnl.txtA.Text = ""
            TVControlPnl.txtB.Text = ""
            TVControlPnl.txtC.Text = ""
            TVControlPnl.txtD.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            TVControlPnl.txtA.Visible = False
            TVControlPnl.txtB.Visible = False
            TVControlPnl.txtC.Visible = False
            TVControlPnl.txtD.Visible = False
            HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
            GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
            HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
            ControlPanel.AWstatusSend.BackColor = Color.Gold
            ControlPanel.AWstatusGet.BackColor = Color.Gold
            ControlPanel.btnNewQuestion.Text = "Pokaži TV"
        End If
    End Sub

    Public Sub PlayCue()
        If useMusic = False Then
            useMusic = True

            If ControlPanel.firstuse = True Or Game.level > 3 Then
                ControlPanel.Timer2.Start()
            End If

            If Game.level = 0 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 1 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 2 Then
                My.Computer.Audio.Play(My.Resources.q8_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 3 Then
                My.Computer.Audio.Play(My.Resources.q14_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 4 Then
                My.Computer.Audio.Play(My.Resources.q15_bed, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Public Sub UndoAnswer(ByVal music As Boolean)
        ControlPanel.HaltSound()
        If music = True Then
            PlayCue()
        End If
        ControlPanel.i = 0
        ControlPanel.txtA.BackColor = Color.Silver
        ControlPanel.txtB.BackColor = Color.Silver
        ControlPanel.txtC.BackColor = Color.Silver
        ControlPanel.txtD.BackColor = Color.Silver

        HostScreen.txtExplain.BackColor = Color.Black
        HostScreen.pnlAnswer.BackColor = Color.Black
        HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.txtA.ForeColor = Color.White
        HostScreen.txtB.ForeColor = Color.White
        HostScreen.txtC.ForeColor = Color.White
        HostScreen.txtD.ForeColor = Color.White

        GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.txtA.ForeColor = Color.White
        GuestScreen.txtB.ForeColor = Color.White
        GuestScreen.txtC.ForeColor = Color.White
        GuestScreen.txtD.ForeColor = Color.White

        TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.txtA.ForeColor = Color.White
        TVControlPnl.txtB.ForeColor = Color.White
        TVControlPnl.txtC.ForeColor = Color.White
        TVControlPnl.txtD.ForeColor = Color.White
    End Sub

    Public Sub StepIN(number As Integer)
        ControlPanel.i = 0
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

        HostScreen.picPO.Image = My.Resources.lifeline_3_used
        GuestScreen.picPO.Image = My.Resources.lifeline_3_used
        ControlPanel.chkPlusOne.Checked = False

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

        ControlPanel.walkaway = False
        ControlPanel.grpLifelines.Enabled = True
        ControlPanel.gbPublicVote.Enabled = True
        ControlPanel.GroupBoxQuizControl.Enabled = True

        ControlPanel.btnNewQuestion.Enabled = True

        act = 1
        If number = 1 Then
            ControlPanel.firstuse = True
            Game.level = 2
            ControlPanel.nmrLevel.Value = 2
            Game.ChangeLevel(2)
            ControlPanel.txtQuestion.Text = "Koliko punc je na FE?"
            ControlPanel.txtA.Text = "2%"
            ControlPanel.txtB.Text = "20%"
            ControlPanel.txtC.Text = "50%"
            ControlPanel.txtD.Text = "Same punce, a večina ne upa priznati"
            ControlPanel.lblAnswer.Text = "B"
            ControlPanel.txtID.Text = "0"
            ControlPanel.txtExplain.Text = "Na multimediji je cca 50% punc"
        ElseIf number = 2 Then
            ControlPanel.firstuse = False
            Game.level = 4
            ControlPanel.nmrLevel.Value = 4
            Game.ChangeLevel(4)
            ControlPanel.txtQuestion.Text = "Povprečno koliko študentov_k FE se letno odloči za Erasmus izmenjavo v tujini?"
            ControlPanel.txtA.Text = "15"
            ControlPanel.txtB.Text = "70"
            ControlPanel.txtC.Text = "40"
            ControlPanel.txtD.Text = "150"
            ControlPanel.lblAnswer.Text = "C"
            ControlPanel.txtID.Text = "0"
            ControlPanel.txtExplain.Text = "Študentje grejo lahko na izmenjavo najprej v 2. letniku študija."
        Else
            newQ.newQuestion()
        End If
        HostScreen.pnlAnswer.BackColor = Color.Black
        HostScreen.lbl5050Used.ForeColor = Color.Black
        HostScreen.lblSwitchUsed.ForeColor = Color.Black
        HostScreen.lblPlusOneUsed.ForeColor = Color.Black
        HostScreen.lblVoteUsed.ForeColor = Color.Black
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
        TVControlPnl.txtA.ForeColor = Color.White
        TVControlPnl.txtB.ForeColor = Color.White
        TVControlPnl.txtC.ForeColor = Color.White
        TVControlPnl.txtD.ForeColor = Color.White
        TVControlPnl.txtA.Text = ""
        TVControlPnl.txtB.Text = ""
        TVControlPnl.txtC.Text = ""
        TVControlPnl.txtD.Text = ""
        HostScreen.txtA.Text = ""
        HostScreen.txtB.Text = ""
        HostScreen.txtC.Text = ""
        HostScreen.txtD.Text = ""
        GuestScreen.txtA.Text = ""
        GuestScreen.txtB.Text = ""
        GuestScreen.txtC.Text = ""
        GuestScreen.txtD.Text = ""
        TVControlPnl.txtA.Visible = False
        TVControlPnl.txtB.Visible = False
        TVControlPnl.txtC.Visible = False
        TVControlPnl.txtD.Visible = False
        HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
        TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
        GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
        HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
        HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
        ControlPanel.AWstatusSend.BackColor = Color.Gold
        ControlPanel.AWstatusGet.BackColor = Color.Gold
        ControlPanel.btnNewQuestion.Text = "Pokaži TV"
    End Sub

End Class
