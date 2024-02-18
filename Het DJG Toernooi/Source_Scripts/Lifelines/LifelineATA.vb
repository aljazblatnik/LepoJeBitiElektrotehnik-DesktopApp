Public Class LifelineATA
    Dim snd As New SOUND
    Dim act As Integer = 0
    Dim amountA As Integer
    Dim amountB As Integer
    Dim amountC As Integer
    Dim amountD As Integer
    Dim perA As String
    Dim perB As String
    Dim perC As String
    Dim perD As String
    Dim amountTotal As Integer


    Public Sub LifelineUse1()
        If act = 0 Then
            My.Computer.Audio.Play(My.Resources.ata_start, AudioPlayMode.Background)
            Question.useMusic = False
            HostScreen.lblVoteUsed.ForeColor = Color.Cyan
            act = 1
            blankSub()
        ElseIf act = 1 Then
            My.Computer.Audio.Play(My.Resources.ata_vote, AudioPlayMode.Background)
            act = 2
            TVControlPnl.tmrRandomizer.Start()
            TVControlPnl.grpATA.Visible = True
            Dim random As New Random()
            If Game.level < 5 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 60)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 60)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 60)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 60)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                End If
            ElseIf Game.level >= 5 And Game.level <= 9 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 50)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 50)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 50)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 50)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                End If
            ElseIf Game.level >= 10 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 55)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 55)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 55)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 55)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                End If
            End If

            If ControlPanel.txtA.Text = "" Then
                amountA = 0
            End If
            If ControlPanel.txtB.Text = "" Then
                amountB = 0
            End If
            If ControlPanel.txtC.Text = "" Then
                amountC = 0
            End If
            If ControlPanel.txtD.Text = "" Then
                amountD = 0
            End If

            ControlPanel.lblATA_A.Text = amountA
            ControlPanel.lblATA_B.Text = amountB
            ControlPanel.lblATA_C.Text = amountC
            ControlPanel.lblATA_D.Text = amountD

            amountTotal = amountA + amountB + amountC + amountD
            perA = Fix((amountA / amountTotal * 100) + 0.5)
            perB = Fix((amountB / amountTotal * 100) + 0.5)
            perC = Fix((amountC / amountTotal * 100) + 0.5)
            perD = Fix((amountD / amountTotal * 100) + 0.5)

            blankSub()
        ElseIf act = 2 Then
            TVControlPnl.tmrRandomizer.Stop()
            My.Computer.Audio.Play(My.Resources.ata_end, AudioPlayMode.Background)
            TVControlPnl.lblATA_A.Text = "A: " + perA + "%"
            TVControlPnl.lblATA_B.Text = "B: " + perB + "%"
            TVControlPnl.lblATA_C.Text = "C: " + perC + "%"
            TVControlPnl.lblATA_D.Text = "D: " + perD + "%"
            HostScreen.txtATAa.Text = "A= " + perA + "%"
            HostScreen.txtATAb.Text = "B= " + perB + "%"
            HostScreen.txtATAc.Text = "C= " + perC + "%"
            HostScreen.txtATAd.Text = "D= " + perD + "%"
            GuestScreen.txtATAa.Text = "A= " + perA + "%"
            GuestScreen.txtATAb.Text = "B= " + perB + "%"
            GuestScreen.txtATAc.Text = "C= " + perC + "%"
            GuestScreen.txtATAd.Text = "D= " + perD + "%"

            ControlPanel.tmrResume.Start()
            ControlPanel.btnVote.Enabled = False
            ControlPanel.chkVote.Checked = False
            act = 0
            blankSub()
        End If


        'Dim ff As New Lifeline5050
        'Dim sw As New LifelineSwitch
        'Dim po As New LifelinePO
        'If ControlPanel.doublell = 1 Then
        '    ff.LifelineUse1()
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_1_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_1_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_1_used
        '    ControlPanel.intSound += 1

        '    With ControlPanel.snd
        '        .Name = "SOUND" & ControlPanel.intSound
        '        .Play(27, False, 500)
        '    End With
        'ElseIf ControlPanel.doublell = 2 Then
        '    sw.LifelineUse1()
        '    ControlPanel.btnSwitch.Enabled = True
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_2_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_2_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_2_used
        'ElseIf ControlPanel.doublell = 3 Then
        '    po.LifelineUse1()
        '    ControlPanel.btnPlusOne.Enabled = True
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_3_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_3_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_3_used
        'End If
    End Sub

    Public Sub LifelineUseAB()
        If act = 0 Then
            If ControlPanel.AWstatusSend.BackColor = Color.Gold Then
                ControlPanel.AWbtnSend_Click(Me, EventArgs.Empty)
            End If
            ControlPanel.lbMusicLeft.Text = "30"
            ControlPanel.timerMusic.Start()
            TVControlPnl.pbQRcode.BringToFront()
            TVControlPnl.pbQRcode.Visible = True
            My.Computer.Audio.Play(My.Resources.ata_start, AudioPlayMode.Background)
            Question.useMusic = False
            HostScreen.lblVoteUsed.ForeColor = Color.Cyan
            act = 1
            blankSub()
        ElseIf act = 1 Then
            My.Computer.Audio.Play(My.Resources.ata_vote, AudioPlayMode.Background)
            act = 2
            ControlPanel.lbMusicLeft.Text = "30"
            ControlPanel.timerMusic.Start()
            TVControlPnl.tmrRandomizer.Start()
            'TVControlPnl.grpATA.Visible = True
            TVControlPnl.pbQRcode.Visible = False
            TVControlPnl.pbQRcode.SendToBack()
            Dim random As New Random()
            If Game.level < 3 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 60)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 60)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 60)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 60)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                End If
            ElseIf Game.level = 3 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 50)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 50)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 50)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 50)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                End If
            ElseIf Game.level >= 4 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 55)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 55)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 55)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 55)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                End If
            End If

            If ControlPanel.txtA.Text = "" Then
                amountA = 1
            End If
            If ControlPanel.txtB.Text = "" Then
                amountB = 1
            End If
            If ControlPanel.txtC.Text = "" Then
                amountC = 1
            End If
            If ControlPanel.txtD.Text = "" Then
                amountD = 1
            End If

            amountTotal = amountA + amountB + amountC + amountD
            perA = Fix((amountA / amountTotal * 100) + 0.5)
            perB = Fix((amountB / amountTotal * 100) + 0.5)
            perC = Fix((amountC / amountTotal * 100) + 0.5)
            perD = Fix((amountD / amountTotal * 100) + 0.5)

            blankSub()
        ElseIf act = 2 Then
            Dim previousAttempt As Integer = 0
            If (ControlPanel.AWstatusGet.BackColor = Color.Green) Then
                previousAttempt = 1
            End If
            ControlPanel.AWbtnGet_Click(Me, EventArgs.Empty)
            TVControlPnl.tmrRandomizer.Stop()
            My.Computer.Audio.Play(My.Resources.ata_end, AudioPlayMode.Background)
            ControlPanel.lbMusicLeft.Text = "30"
            ControlPanel.timerMusic.Stop()
            If (ControlPanel.AWstatusGet.BackColor = Color.Green Or previousAttempt = 1) Then
                TVControlPnl.AWpbA.Value = ControlPanel.AWA
                TVControlPnl.AWpbB.Value = ControlPanel.AWB
                TVControlPnl.AWpbC.Value = ControlPanel.AWC
                TVControlPnl.AWpbD.Value = ControlPanel.AWD
                TVControlPnl.AWlabelA.Text = ControlPanel.AWA.ToString() + "%"
                TVControlPnl.AWlabelB.Text = ControlPanel.AWB.ToString() + "%"
                TVControlPnl.AWlabelC.Text = ControlPanel.AWC.ToString() + "%"
                TVControlPnl.AWlabelD.Text = ControlPanel.AWD.ToString() + "%"
                HostScreen.AWHostA.Text = "A: " + ControlPanel.AWA.ToString() + "%"
                HostScreen.AWHostB.Text = "B: " + ControlPanel.AWB.ToString() + "%"
                HostScreen.AWHostC.Text = "C: " + ControlPanel.AWC.ToString() + "%"
                HostScreen.AWHostD.Text = "D: " + ControlPanel.AWD.ToString() + "%"
                HostScreen.AWHostCount.Text = "N = " + ControlPanel.AWABCD.ToString()
                GuestScreen.AWGuestA.Text = "A: " + ControlPanel.AWA.ToString() + "%"
                GuestScreen.AWGuestB.Text = "B: " + ControlPanel.AWB.ToString() + "%"
                GuestScreen.AWGuestC.Text = "C: " + ControlPanel.AWC.ToString() + "%"
                GuestScreen.AWGuestD.Text = "D: " + ControlPanel.AWD.ToString() + "%"
            Else
                ControlPanel.AWlbA.Text = perA + "%"
                ControlPanel.AWlbB.Text = perB + "%"
                ControlPanel.AWlbC.Text = perC + "%"
                ControlPanel.AWlbD.Text = perD + "%"
                TVControlPnl.AWpbA.Value = perA
                TVControlPnl.AWpbB.Value = perB
                TVControlPnl.AWpbC.Value = perC
                TVControlPnl.AWpbD.Value = perD
                TVControlPnl.AWlabelA.Text = perA + "%"
                TVControlPnl.AWlabelB.Text = perB + "%"
                TVControlPnl.AWlabelC.Text = perC + "%"
                TVControlPnl.AWlabelD.Text = perD + "%"
                HostScreen.AWHostA.Text = "A: " + perA + "%"
                HostScreen.AWHostB.Text = "B: " + perB + "%"
                HostScreen.AWHostC.Text = "C: " + perC + "%"
                HostScreen.AWHostD.Text = "D: " + perD + "%"
                HostScreen.AWHostCount.Text = "N = SIM."
                GuestScreen.AWGuestA.Text = "A: " + perA + "%"
                GuestScreen.AWGuestB.Text = "B: " + perB + "%"
                GuestScreen.AWGuestC.Text = "C: " + perC + "%"
                GuestScreen.AWGuestD.Text = "D: " + perD + "%"
            End If
            TVControlPnl.AWTVpanel.Visible = True
            HostScreen.AWHostPanel.Visible = True
            GuestScreen.AWGuestPanel.Visible = True
            HostScreen.picAW.Image = My.Resources.lifeline_4_used
            GuestScreen.picAW.Image = My.Resources.lifeline_4_used
            TVControlPnl.picAW.Image = My.Resources.lifeline_4_used

            ControlPanel.tmrResume.Start()
            ControlPanel.btnAW.Enabled = False
            ControlPanel.chkAW.Checked = False
            ControlPanel.chkShowResults.Checked = True
            act = 0
            blankSub()
        End If
    End Sub

    Public Sub blankSub()

    End Sub

End Class
