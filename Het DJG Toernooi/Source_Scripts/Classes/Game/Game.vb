Public Class Game

    ' Game info variables
    Public Shared gamemode As Integer = 0
    Public Shared level As Integer = 0
    Public Shared varCurrent As String = "0"
    Public Shared varCorrect As String = "0"
    Public Shared varWrong As String = "0"
    Public Shared varDrop As String = "0"
    Public Shared varQLeft As String = "0"

    Public Shared Sub ChangeLevel(ByVal newLvl As Integer)
        If newLvl = 0 Then
            Game.level = 0
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 0
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
        End If
        If newLvl = 1 Then
            Game.level = 1
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 1
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
        End If
        If newLvl = 2 Then
            Game.level = 2
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 2
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
        End If
        If newLvl = 3 Then
            Game.level = newLvl
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 3
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
        End If
        If newLvl = 4 Then
            Game.level = 4
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 4
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtQLeft.Text = Game.varQLeft
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblQLeft.Text = Game.varQLeft
        End If
        If newLvl = 5 Then
            Game.level = 5
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 5
        End If
    End Sub

    Public Shared Sub ChangeMode(ByVal newmode As Integer)
        Select Case newmode
            Case 0      ' Change to normal mode
                gamemode = 0
                SetValues()
            Case 1      ' Change to risk mode
                gamemode = 1
                SetValues()
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(9, False, 1000)
                End With
        End Select
    End Sub

    Public Shared Sub SetValues()

        'Based on gamemode
        ' 0 = Normal Mode
        ' 1 = Risk Mode
        Select Case gamemode
            Case 0
                modeNormal.getInfo()
            Case 1
                modeRisk.getInfo()
        End Select

    End Sub

    Dim intSound As Integer = 0
    Dim snd As New SOUND

    Public Sub wrongAsnwer()
        If Game.level = 0 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 1 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 2 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(32, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 3 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(37, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 4 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(38, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
    End Sub
End Class
