﻿Public Class correct

    Dim controlp As ControlPanel
    Dim options As New Game

    Public Sub correctRun()
        TVControlPnl.tmrFlash.Start()
        LifeLineDouble.chance = 2
        If ControlPanel.answer = "A" Then
            ControlPanel.txtA.BackColor = Color.Green
            HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtA.ForeColor = Color.Black
            GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtA.ForeColor = Color.Black
        End If
        If ControlPanel.answer = "B" Then
            ControlPanel.txtB.BackColor = Color.Green
            HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtB.ForeColor = Color.Black
            GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtB.ForeColor = Color.Black
        End If
        If ControlPanel.answer = "C" Then
            HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtC.ForeColor = Color.Black
            GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtC.ForeColor = Color.Black
            ControlPanel.txtC.BackColor = Color.Green
        End If
        If ControlPanel.answer = "D" Then
            HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtD.ForeColor = Color.Black
            GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtD.ForeColor = Color.Black
            ControlPanel.txtD.BackColor = Color.Green
        End If
        If ControlPanel.walkaway = False Then
            If Game.level = 0 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(12, False, 700)
                End With
            End If
            If Game.level = 1 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(18, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 2 Then
                My.Computer.Audio.Play(My.Resources.q8_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 3 Then
                My.Computer.Audio.Play(My.Resources.q14_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 4 Then
                My.Computer.Audio.Play(My.Resources.q15_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
                HostScreen.txtWinnings.Text = "Rezultat: " + Game.varCorrect
            End If
            'My.Computer.Keyboard.SendKeys("%w", True) 'Win
        End If

        TVControlPnl.grpATA.Visible = False

        Dim trStopDD As Threading.Thread = New Threading.Thread(AddressOf LifeLineDouble.StopCue2)
        trStopDD.Start()

        If Game.level = 5 Then
            Game.level = Game.level + 1
            Game.ChangeLevel(Game.level)
        Else
            Game.level = Game.level + 1
            Game.ChangeLevel(Game.level)
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
            Question.act = 0
        End If
    End Sub

    Public Sub wrongRun()
        If LifeLineDouble.active = True Then
            LifeLineDouble.SecondChance()
            If ControlPanel.answer = "A" Then
                TVControlPnl.txtA.Text = ""
                TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                HostScreen.txtA.Text = ""
                HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                GuestScreen.txtA.Text = ""
                GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                ControlPanel.txtA.Text = ""
                ControlPanel.txtA.BackColor = Color.Silver
            End If
            If ControlPanel.answer = "B" Then
                TVControlPnl.txtB.Text = ""
                TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                HostScreen.txtB.Text = ""
                HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                GuestScreen.txtB.Text = ""
                GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                ControlPanel.txtB.Text = ""
                ControlPanel.txtB.BackColor = Color.Silver
            End If
            If ControlPanel.answer = "C" Then
                TVControlPnl.txtC.Text = ""
                TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                HostScreen.txtC.Text = ""
                HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                GuestScreen.txtC.Text = ""
                GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                ControlPanel.txtC.Text = ""
                ControlPanel.txtC.BackColor = Color.Silver
            End If
            If ControlPanel.answer = "D" Then
                TVControlPnl.txtD.Text = ""
                TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                HostScreen.txtD.Text = ""
                HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                GuestScreen.txtD.Text = ""
                GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                ControlPanel.txtD.Text = ""
                ControlPanel.txtD.BackColor = Color.Silver
            End If
            ControlPanel.Timer2.Stop()
        Else
            LifeLineDouble.chance = 2
            TVControlPnl.tmrFlash.Start()
            Dim trStopDD As Threading.Thread = New Threading.Thread(AddressOf LifeLineDouble.StopCue2)
            trStopDD.Start()
            If ControlPanel.lblAnswer.Text = "A" Then
                HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                HostScreen.txtA.ForeColor = Color.Black
                GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                GuestScreen.txtA.ForeColor = Color.Black
                ControlPanel.txtA.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                HostScreen.txtB.ForeColor = Color.Black
                GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                GuestScreen.txtB.ForeColor = Color.Black
                ControlPanel.txtB.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                HostScreen.txtC.ForeColor = Color.Black
                GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                GuestScreen.txtC.ForeColor = Color.Black
                ControlPanel.txtC.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                HostScreen.txtC.ForeColor = Color.Black
                GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                GuestScreen.txtD.ForeColor = Color.Black
                ControlPanel.txtD.BackColor = Color.Green
            End If
            If ControlPanel.walkaway = False Then
                'My.Computer.Keyboard.SendKeys("%q", True) 'Lose
                If Game.level = 0 Then
                    ControlPanel.intSound += 1

                    With ControlPanel.snd
                        .Name = "SOUND" & ControlPanel.intSound
                        .Play(19, False, 700)
                    End With
                    ControlPanel.Timer1.Start()
                End If
                If Game.level = 1 Then
                    ControlPanel.intSound += 1

                    With ControlPanel.snd
                        .Name = "SOUND" & ControlPanel.intSound
                        .Play(19, False, 700)
                    End With
                    ControlPanel.Timer1.Start()
                End If
                If Game.level = 2 Then
                    My.Computer.Audio.Play(My.Resources.q9_lose, AudioPlayMode.Background)
                    ControlPanel.Timer2.Start()
                End If
                If Game.level = 3 Then
                    My.Computer.Audio.Play(My.Resources.q13_lose, AudioPlayMode.Background)
                    ControlPanel.Timer2.Start()
                End If
                If Game.level = 4 Then
                    My.Computer.Audio.Play(My.Resources.q14_lose, AudioPlayMode.Background)
                    ControlPanel.Timer2.Start()
                End If
                TVControlPnl.lblAmount.Text = "" & Game.varWrong
                HostScreen.txtWinnings.Text = "Rezultat: " + Game.varWrong
            Else
                ControlPanel.Timer2.Start()
                TVControlPnl.lblAmount.Text = "" & Game.varCurrent
            End If
        End If


    End Sub
End Class
