Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Media
Imports System.IO
Imports System.Text
Imports System.Net

Public Class ControlPanel
    Dim debug As Boolean = False

    Public Shared intSound As Integer = 0
    Public Shared snd As New SOUND
    Public Shared walkaway As Boolean = False
    Public Shared doublell As Integer = 0
    Public Shared firstuse As Boolean = True

    Public Shared AWA = 0
    Public Shared AWB = 0
    Public Shared AWC = 0
    Public Shared AWD = 0
    Public Shared AWABCD = 0

    Dim btnLightsDownFA As Boolean = True

    Public Sub HaltSound()
        For X = 0 To intSound
            snd.Kill("SOUND" & X)
        Next
    End Sub

    Public Sub blanksub()

    End Sub

    Public Shared Function GetHostMessages() As List(Of String)
        Using cmd As New SqlCommand("SELECT Message FROM settings_HostMessages", Data.connectionString)
            Dim messages As New List(Of String)
            cmd.CommandType = CommandType.Text
            Data.connectionString.Open()
            Using sdr As SqlDataReader = cmd.ExecuteReader()
                While sdr.Read()
                    messages.Add(sdr.GetString(0))
                End While
            End Using
            Data.connectionString.Close()
            Return messages
        End Using
    End Function

    Private Sub nmrLevel_ValueChanged(sender As Object, e As EventArgs) Handles nmrLevel.ValueChanged
        Game.ChangeLevel(nmrLevel.Value)
    End Sub

    Private Sub btnNewQuestion_Click(sender As Object, e As EventArgs) Handles btnNewQuestion.Click
        Dim q As New Question
        q.Generate()
    End Sub

    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drpNextHostMessage.Items.AddRange(GetHostMessages().ToArray())
        'Me.Show()
    End Sub

    Public Shared answer As String
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Me.btnReveal.Enabled = True
        Dim q As New Question
        q.UndoAnswer(False)
        answer = "A"
        HostScreen.txtExplain.ForeColor = Color.White
        txtA.BackColor = Color.Yellow
        HostScreen.pnlA.BackgroundImage = My.Resources.Final_Answer_Fill_l
        HostScreen.txtA.ForeColor = Color.Black
        TVControlPnl.picA.BackgroundImage = My.Resources.Final_Answer_Fill_l
        TVControlPnl.txtA.ForeColor = Color.Black
        GuestScreen.pnlA.BackgroundImage = My.Resources.Final_Answer_Fill_l
        GuestScreen.txtA.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            If walkaway = False Then
                If Game.level = 2 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(13, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 3 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(16, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 4 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(17, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
            Else

            End If
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Me.btnReveal.Enabled = True
        Dim q As New Question
        q.UndoAnswer(False)
        answer = "B"
        HostScreen.txtExplain.ForeColor = Color.White
        txtB.BackColor = Color.Yellow
        HostScreen.pnlB.BackgroundImage = My.Resources.Final_Answer_Fill_r
        HostScreen.txtB.ForeColor = Color.Black
        TVControlPnl.picB.BackgroundImage = My.Resources.Final_Answer_Fill_r
        TVControlPnl.txtB.ForeColor = Color.Black
        GuestScreen.pnlB.BackgroundImage = My.Resources.Final_Answer_Fill_r
        GuestScreen.txtB.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            If walkaway = False Then
                If Game.level = 2 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(13, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 3 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(16, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 4 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(17, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
            Else
            End If
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Me.btnReveal.Enabled = True
        Dim q As New Question
        q.UndoAnswer(False)
        answer = "C"
        HostScreen.txtExplain.ForeColor = Color.White
        txtC.BackColor = Color.Yellow
        HostScreen.pnlC.BackgroundImage = My.Resources.Final_Answer_Fill_l
        HostScreen.txtC.ForeColor = Color.Black
        TVControlPnl.picC.BackgroundImage = My.Resources.Final_Answer_Fill_l
        TVControlPnl.txtC.ForeColor = Color.Black
        GuestScreen.pnlC.BackgroundImage = My.Resources.Final_Answer_Fill_l
        GuestScreen.txtC.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            If walkaway = False Then
                If Game.level = 2 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(13, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 3 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(16, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 4 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(17, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
            Else
            End If
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Me.btnReveal.Enabled = True
        Dim q As New Question
        q.UndoAnswer(False)
        answer = "D"
        HostScreen.txtExplain.ForeColor = Color.White
        txtD.BackColor = Color.Yellow
        HostScreen.pnlD.BackgroundImage = My.Resources.Final_Answer_Fill_r
        HostScreen.txtD.ForeColor = Color.Black
        TVControlPnl.picD.BackgroundImage = My.Resources.Final_Answer_Fill_r
        TVControlPnl.txtD.ForeColor = Color.Black
        GuestScreen.pnlD.BackgroundImage = My.Resources.Final_Answer_Fill_r
        GuestScreen.txtD.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            If walkaway = False Then
                If Game.level = 2 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(13, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 3 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(16, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
                If Game.level = 4 Then
                    intSound += 1

                    With snd
                        .Name = "SOUND" & intSound
                        .Play(17, False, 1000)
                    End With
                    Question.useMusic = False
                    Timer1.Start()
                    blanksub()
                End If
            Else
            End If
        End If
    End Sub

    Dim subAnswer As New correct
    Public Shared i As Integer = 0

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        btnLightsDown.Enabled = True
        btnNewQuestion.Enabled = True
        If i = 0 Then
            HostScreen.txtExplain.ForeColor = Color.White
            HostScreen.AWHostPanel.Visible = False
            GuestScreen.AWGuestPanel.Visible = False
            TVControlPnl.AWTVpanel.Visible = False
            chkShowResults.Checked = False
            If HostScreen.pnlAnswer.BackColor = Color.Lime Then
                If walkaway = False Then
                    TVControlPnl.tmrStrap.Start()
                End If
                subAnswer.correctRun()
            End If
            If HostScreen.pnlAnswer.BackColor = Color.Red Or HostScreen.pnlAnswer.BackColor = Color.LightGray Then
                subAnswer.wrongRun()
            End If
            i = 1
        ElseIf i = 1 Then
            chkShowQuestion.Checked = False
            TVControlPnl.txtA.BackColor = Color.Transparent
            TVControlPnl.txtB.BackColor = Color.Transparent
            TVControlPnl.txtC.BackColor = Color.Transparent
            TVControlPnl.txtD.BackColor = Color.Transparent
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.pnlQuestion.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            cbWinningPanel.Checked = False
            TVControlPnl.tmrFlash.Stop()
            i = 2
        ElseIf i = 2 Then
            HostScreen.pnlStrap.Visible = False
            GuestScreen.pnlStrap.Visible = False
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.txtQuestion.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.txtQuestion.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            i = 0
        End If
        btnReveal.Enabled = False
        GroupBoxQuiz.Enabled = False
    End Sub

    Private Sub btnSndOpening_Click(sender As Object, e As EventArgs) Handles btnSndOpening.Click
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(0, False, 1000)
        End With
    End Sub

    Private Sub btnCommercial_Click(sender As Object, e As EventArgs) Handles btnCommercial.Click
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(3, False, 1000)
        End With
        Timer1.Start()
    End Sub

    Private Sub btnClosing_Click(sender As Object, e As EventArgs) Handles btnClosing.Click
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(1, False, 1000)
        End With
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStopPC.Click
        My.Computer.Audio.Stop()
        HaltSound()
    End Sub



    Private Sub btnLightsDown_Click(sender As Object, e As EventArgs) Handles btnLightsDown.Click
        TVControlPnl.picTree.Visible = False
        TVControlPnl.pnlStrap.Visible = False
        cbWinningPanel.Checked = False
        If firstuse = True Then
            firstuse = False
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(5, False, 1000)
            End With
        Else
            If Game.level = 0 Then
                intSound += 1

                With snd
                    .Name = "SOUND" & intSound
                    .Play(5, False, 1000)
                End With
            End If
            If Game.level = 1 Then
                intSound += 1

                With snd
                    .Name = "SOUND" & intSound
                    .Play(5, False, 1000)
                End With
            End If
            If Game.level = 2 Then
                intSound += 1

                With snd
                    .Name = "SOUND" & intSound
                    .Play(6, False, 1000)
                End With
            End If
            If Game.level = 3 Then
                intSound += 1

                With snd
                    .Name = "SOUND" & intSound
                    .Play(8, False, 1000)
                End With
            End If
            If Game.level = 4 Then
                intSound += 1

                With snd
                    .Name = "SOUND" & intSound
                    .Play(8, False, 1000)
                End With
            End If
        End If
        Timer1.Start()
        HostScreen.lblExplainRules.ForeColor = Color.Black
    End Sub

    Private Sub btnWalk_Click(sender As Object, e As EventArgs) Handles btnWalk.Click
        User.a = 0
        User.f = 0
        btnContestantMusic.Enabled = True
        HostScreen.txtExplain.ForeColor = Color.White
        Timer1.Start()
        HostScreen.pnlAnswer.BackColor = Color.LightGray
        walkaway = True
        HostScreen.txtWinnings.Text = "Dobitek: " + Game.varCurrent
        TVControlPnl.grpATA.Visible = False
        If Game.level = 0 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(3, False, 1000)
            End With
        End If
        If Game.level = 1 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(3, False, 1000)
            End With
        End If
        If Game.level = 2 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(3, False, 1000)
            End With
        End If
        If Game.level = 3 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(4, False, 1000)
            End With
        End If
        If Game.level = 4 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(4, False, 1000)
            End With
        End If

        HostScreen.lblWalkedAway.ForeColor = Color.White
        TVControlPnl.lblAmount.Text = "" & Game.varCurrent
        TVControlPnl.pnlQuestion.Visible = False
    End Sub

    Dim ff As New Lifeline5050
    Private Sub btn5050_Click(sender As Object, e As EventArgs)
        ff.LifelineUse1()
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(27, False, 500)
        End With
    End Sub

    Dim switch As New LifelineSwitch
    Private Sub btnSwitch_Click(sender As Object, e As EventArgs)
        switch.LifelineUse1()
    End Sub

    Dim po As New LifelinePO
    Private Sub btnPlusOne_Click(sender As Object, e As EventArgs) Handles btnPlusOne.Click
        po.LifelineUse1()
    End Sub

    Private Sub chk5050_CheckedChanged(sender As Object, e As EventArgs)
        If chk5050.Checked = True Then
            btn5050.Enabled = True
        End If
        If chk5050.Checked = False Then
            btn5050.Enabled = False
        End If
    End Sub

    Private Sub chkPlusOne_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlusOne.CheckedChanged
        If chkPlusOne.Checked = True Then
            btnPlusOne.Enabled = True
            HostScreen.picPO.Image = My.Resources.lifeline_3
            GuestScreen.picPO.Image = My.Resources.lifeline_3
            TVControlPnl.picPO.Image = My.Resources.lifeline_3
        End If
        If chkPlusOne.Checked = False Then
            btnPlusOne.Enabled = False
            HostScreen.picPO.Image = My.Resources.lifeline_3_used
            GuestScreen.picPO.Image = My.Resources.lifeline_3_used
            TVControlPnl.picPO.Image = My.Resources.lifeline_3_used
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User.NewUser()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If lblAnswer.Text = "A" Then
            HostScreen.txtA.BackColor = Color.Green
            GuestScreen.txtA.BackColor = Color.Green
            txtA.BackColor = Color.Green
        End If
        If lblAnswer.Text = "B" Then
            HostScreen.txtB.BackColor = Color.Green
            GuestScreen.txtB.BackColor = Color.Green
            txtB.BackColor = Color.Green
        End If
        If lblAnswer.Text = "C" Then
            HostScreen.txtC.BackColor = Color.Green
            GuestScreen.txtC.BackColor = Color.Green
            txtC.BackColor = Color.Green
        End If
        If lblAnswer.Text = "D" Then
            HostScreen.txtD.BackColor = Color.Green
            GuestScreen.txtD.BackColor = Color.Green
            txtD.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        User.a = 0
        User.f = 0
        btnContestantMusic.Enabled = True
        'TVControlPnl.pnlStrap.Visible = True
        'cbWinningPanel.Checked = True
        TVControlPnl.pnlQuestion.Visible = False
        TVControlPnl.AWTVpanel.Visible = False
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(28, False, 1000)
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Stop()
        Timer1.Stop()
        Question.useMusic = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorrectAnswer.CheckedChanged
        If chkCorrectAnswer.Checked = True Then
            Panel1.Visible = True
        End If
        If chkCorrectAnswer.Checked = False Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        HaltSound()
        Timer2.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        HaltSound()
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        HostScreen.lblTime.Text = HostScreen.lblTime.Text - 1
        GuestScreen.lblTime.Text = GuestScreen.lblTime.Text - 1
        TVControlPnl.lblTime.Text = TVControlPnl.lblTime.Text - 1
        lblTime.Text = lblTime.Text - 1
        If lblTime.Text = 0 Then
            HostScreen.lblTime.Visible = False
            GuestScreen.lblTime.Visible = False
            lblTime.Visible = False
            tmrTime.Stop()
            LifelinePO.plusone = 0
            tmrResume.Start()
            chkPlusOne.Checked = False
            HostScreen.picPO.Image = My.Resources.lifeline_3_used
            GuestScreen.picPO.Image = My.Resources.lifeline_3_used
            TVControlPnl.picPO.Image = My.Resources.lifeline_3_used
            btnPlusOne.Enabled = False
        End If
    End Sub

    Private Sub tmrResume_Tick(sender As Object, e As EventArgs) Handles tmrResume.Tick
        Dim q As New Question
        q.PlayCue()
        TVControlPnl.lblTime.Visible = True
        TVControlPnl.lblTime.Text = "30"
        lblTime.Text = "30"
        GuestScreen.lblTime.Text = "30"
        HostScreen.lblTime.Text = "30"
        TVControlPnl.pnlTime.Visible = False
        tmrResume.Stop()
    End Sub

    Private Sub tmrRules_Tick(sender As Object, e As EventArgs) Handles tmrRules.Tick
        Game.SetValues()
        Game.level = Game.level + 1
        If Game.level > 15 Then
            tmrRules.Stop()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        My.Computer.Audio.Play(My.Resources.game_resume, AudioPlayMode.BackgroundLoop)
        HostScreen.lblExplainRules.ForeColor = Color.Blue
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        tmrLifelineBling.Start()
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(23, False, 1000)
        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        HostScreen.picPO.Image = My.Resources.lifeline_3_bling
        GuestScreen.picPO.Image = My.Resources.lifeline_3_bling
        TVControlPnl.picPO.Image = My.Resources.lifeline_3_bling
        tmrLifelineBling.Start()
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(24, False, 1000)
        End With
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLL4_Click(sender As Object, e As EventArgs)
        intSound += 1

        With snd
            .Name = "SOUND" & intSound
            .Play(9, False, 1000)
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        tmrRules.Start()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Game.level = 0
        Game.SetValues()
    End Sub

    Private Sub btnShowTree_Click(sender As Object, e As EventArgs) Handles btnShowTree.Click
        TVControlPnl.picTree.Visible = True
        TVControlPnl.pnlQuestion.Visible = False
        TVControlPnl.pnlStrap.Visible = False
        cbWinningPanel.Checked = False
    End Sub

    Private Sub btnHideTree_Click(sender As Object, e As EventArgs) Handles btnHideTree.Click
        TVControlPnl.picTree.Visible = False
        If chkShowQuestion.Checked = True Then
            TVControlPnl.pnlQuestion.Visible = True
        Else
            TVControlPnl.pnlQuestion.Visible = False
        End If
    End Sub

    Private Sub chkShowQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowQuestion.CheckedChanged
        If chkShowQuestion.Checked = True Then
            TVControlPnl.pnlQuestion.Visible = True
        End If
        If chkShowQuestion.Checked = False Then
            TVControlPnl.pnlQuestion.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        clrBGColor.ShowDialog()
        TVControlPnl.BackColor = clrBGColor.Color
    End Sub

    Dim vote As New LifelineATA

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        vote.LifelineUse1()
    End Sub

    Private Sub chkVote_CheckedChanged(sender As Object, e As EventArgs)
        If chkVote.Checked = True Then
            btnVote.Enabled = True
        End If
        If chkVote.Checked = False Then
            btnVote.Enabled = False
        End If
    End Sub

    Private Sub ResetAllUsedQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim reset As New QDatabase
        reset.resetDB()
    End Sub

    Private Sub TVScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVScreenToolStripMenuItem.Click
        TVControlPnl.Show()
    End Sub

    Private Sub HostScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostScreenToolStripMenuItem.Click
        HostScreen.Show()
    End Sub

    Private Sub GuestScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestScreenToolStripMenuItem.Click
        GuestScreen.Show()
    End Sub

    Private Sub btnUnlockSwitch_Click(sender As Object, e As EventArgs)
        Select Case Game.gamemode
            Case 0
                Game.ChangeMode(1)
            Case 1
                Game.ChangeMode(0)
        End Select
    End Sub

    Private Sub tmrLifelineBling_Tick(sender As Object, e As EventArgs) Handles tmrLifelineBling.Tick
        HostScreen.picPO.Image = My.Resources.lifeline_3
        GuestScreen.picPO.Image = My.Resources.lifeline_3
        TVControlPnl.picPO.Image = My.Resources.lifeline_3
        tmrLifelineBling.Stop()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim q As New Question
        q.UndoAnswer(True)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub ChangeMoneyStrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeMoneyStrapToolStripMenuItem.Click
        ChangeMoneyStrap.ShowDialog()
    End Sub

    Private Sub ControlPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CoreConsole.isRunning = False
    End Sub

    Private Sub QuestionsEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestionsEditorToolStripMenuItem.Click
        Try
            Process.Start("qedit.exe")
        Catch ex As Exception
            MessageBox.Show("An error occured while opening: " + Environment.NewLine + ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CoreConsole.LogMsgDate("An error occured while opening:")
            CoreConsole.LogMsg(ex.Message())
        End Try
    End Sub

    Private Sub HostMessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostMessagesToolStripMenuItem.Click
        HostMessages.Show()
    End Sub

    Private Sub btnSendToHost_Click(sender As Object, e As EventArgs) Handles btnSendToHost.Click
        txtHostMessages.AppendText(drpNextHostMessage.Text.ToUpper() + Environment.NewLine)
        HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + drpNextHostMessage.Text.ToUpper()
    End Sub

    Private Sub btnClearHostMessages_Click(sender As Object, e As EventArgs) Handles btnClearHostMessages.Click
        txtHostMessages.Clear()
        HostScreen.lblHostMsg.Text = ""
    End Sub

    Private Sub drpNextHostMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles drpNextHostMessage.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSendToHost.PerformClick()
        End If
    End Sub

    Private Sub btnTestLifeline_Click(sender As Object, e As EventArgs)
        LifeLineDouble.LifelineUse1()
    End Sub

    Private Sub btnGetContestant_Click(sender As Object, e As EventArgs) Handles btnGetContestant.Click
        Dim address As String = "https://www.elektrotehnika.info/izbran_tekmovalec.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        tbContestant.Text = reader.ReadToEnd
        client.Dispose()
        reader.Close()
    End Sub

    Private Sub btnContestantMusic_Click(sender As Object, e As EventArgs) Handles btnContestantMusic.Click
        User.GetContestants()
    End Sub

    Private Sub btnSelectContestant_Click(sender As Object, e As EventArgs) Handles btnSelectContestant.Click
        User.SelectContestants()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        TVControlPnl.pbQRcode.BringToFront()
        TVControlPnl.pbQRcode.Visible = True
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TVControlPnl.pbQRcode.Visible = False
        TVControlPnl.pbQRcode.SendToBack()
    End Sub

    Private Sub tbContestant_KeyUp(sender As Object, e As KeyEventArgs) Handles tbContestant.KeyUp
        HostScreen.lblContestantText.Text = tbContestant.Text
    End Sub

    Public Sub AWbtnGet_Click(sender As Object, e As EventArgs) Handles AWbtnGet.Click
        Dim json_data As String = ""
        Try
            Dim address As String = "https://www.elektrotehnika.info/rezultati.php"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            json_data = reader.ReadToEnd
            client.Dispose()
            reader.Close()

            If (json_data <> "") Then
                Dim readResults = Newtonsoft.Json.Linq.JObject.Parse(json_data)
                AWlbCount.Text = readResults.Item("ABCD").ToString
                AWlbA.Text = readResults.Item("Ap").ToString + "%"
                AWlbB.Text = readResults.Item("Bp").ToString + "%"
                AWlbC.Text = readResults.Item("Cp").ToString + "%"
                AWlbD.Text = readResults.Item("Dp").ToString + "%"
                AWA = readResults.Item("Ap")
                AWB = readResults.Item("Bp")
                AWC = readResults.Item("Cp")
                AWD = readResults.Item("Dp")
                AWABCD = readResults.Item("ABCD")
                TVControlPnl.AWpbA.Value = AWA
                TVControlPnl.AWpbB.Value = AWB
                TVControlPnl.AWpbC.Value = AWC
                TVControlPnl.AWpbD.Value = AWD
                TVControlPnl.AWlabelA.Text = AWlbA.Text
                TVControlPnl.AWlabelB.Text = AWlbB.Text
                TVControlPnl.AWlabelC.Text = AWlbC.Text
                TVControlPnl.AWlabelD.Text = AWlbD.Text
                AWstatusGet.BackColor = Color.Green
            End If
        Catch ex As Exception
            AWstatusGet.BackColor = Color.Red
        End Try
    End Sub

    Public Sub AWbtnSend_Click(sender As Object, e As EventArgs) Handles AWbtnSend.Click
        Try
            Dim request As String = "Q=" + txtQuestion.Text + "&A=" + txtA.Text + "&B=" + txtB.Text + "&C=" + txtC.Text + "&D=" + txtD.Text
            Dim address As String = "https://www.elektrotehnika.info/vnesi_vprasanje.php?" + request
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Dim result As String = reader.ReadToEnd
            If result = "OK" Then
                AWstatusSend.BackColor = Color.Green
                AWbtnGet.Enabled = True
            Else
                AWstatusSend.BackColor = Color.Red
            End If
        Catch ex As Exception
            AWstatusSend.BackColor = Color.Red
        End Try
    End Sub

    Private Sub btnAW_Click(sender As Object, e As EventArgs) Handles btnAW.Click
        vote.LifelineUseAB()
    End Sub

    Private Sub chkAW_CheckedChanged(sender As Object, e As EventArgs) Handles chkAW.CheckedChanged
        If chkAW.Checked = True Then
            btnAW.Enabled = True
            HostScreen.picAW.Image = My.Resources.lifeline_4
            GuestScreen.picAW.Image = My.Resources.lifeline_4
            TVControlPnl.picAW.Image = My.Resources.lifeline_4
        End If
        If chkAW.Checked = False Then
            btnAW.Enabled = False
            HostScreen.picAW.Image = My.Resources.lifeline_4_used
            GuestScreen.picAW.Image = My.Resources.lifeline_4_used
            TVControlPnl.picAW.Image = My.Resources.lifeline_4_used
        End If
    End Sub

    Private Sub chkShowResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowResults.CheckedChanged
        If chkShowResults.Checked = True Then
            TVControlPnl.AWTVpanel.Visible = True
            HostScreen.AWHostPanel.Visible = True
            GuestScreen.AWGuestPanel.Visible = True
        Else
            TVControlPnl.AWTVpanel.Visible = False
            HostScreen.AWHostPanel.Visible = False
            GuestScreen.AWGuestPanel.Visible = False
        End If
    End Sub

    Private Sub cbChoose_CheckedChanged(sender As Object, e As EventArgs) Handles cbWinningPanel.CheckedChanged
        If cbWinningPanel.Checked = True Then
            TVControlPnl.pnlStrap.Visible = True
        Else
            TVControlPnl.pnlStrap.Visible = False
        End If
        chkPlusOne_CheckedChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub timerMusic_Tick(sender As Object, e As EventArgs) Handles timerMusic.Tick
        lbMusicLeft.Text = Convert.ToString(Convert.ToInt32(lbMusicLeft.Text) - 1)
        If lbMusicLeft.Text = "0" Then
            timerMusic.Stop()
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(45, False, 1000)
        End With
        For X = 0 To (intSound - 1)
            snd.Kill("SOUND" & X)
        Next
        timerMusic.Stop()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnStepIN1_Click(sender As Object, e As EventArgs) Handles btnStepIN1.Click
        Dim q As New Question
        q.StepIN(1)
    End Sub

    Private Sub btnStepIN2_Click(sender As Object, e As EventArgs) Handles btnStepIN2.Click
        Dim q As New Question
        q.StepIN(2)
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(3, False, 1000)
        End With
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(4, False, 1000)
        End With
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(46, False, 1000)
        End With
        For X = 0 To (intSound - 1)
            snd.Kill("SOUND" & X)
        Next
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.commercial_out, AudioPlayMode.Background)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(48, False, 1000)
        End With
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(49, False, 1000)
        End With
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(50, False, 1000)
        End With
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        intSound += 1
        With snd
            .Name = "SOUND" & intSound
            .Play(51, False, 1000)
        End With
    End Sub

    Private Sub cbContestant_CheckedChanged(sender As Object, e As EventArgs) Handles cbContestant.CheckedChanged
        If cbContestant.Checked = True Then
            TVControlPnl.pnlFFFWinner.Visible = True
        Else
            TVControlPnl.pnlFFFWinner.Visible = False
        End If
    End Sub
End Class
