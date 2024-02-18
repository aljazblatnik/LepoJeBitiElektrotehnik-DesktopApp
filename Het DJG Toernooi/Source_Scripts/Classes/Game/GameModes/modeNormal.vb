Public Class modeNormal

    Public Shared Sub getInfo()
        If Game.level = 0 Then
            Game.varCurrent = ""
            Game.varQLeft = "5"
            HostScreen.picTree.Image = My.Resources._0_tree_0
            GuestScreen.picTree.Image = My.Resources._0_tree_0
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_0
        End If
        If Game.level = 1 Then
            Game.varCurrent = "Balon FE"
            Game.varQLeft = "4"
            HostScreen.picTree.Image = My.Resources._0_tree_1
            GuestScreen.picTree.Image = My.Resources._0_tree_1
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_1
        End If
        If Game.level = 2 Then
            Game.varCurrent = "Majica FE"
            Game.varQLeft = "3"
            HostScreen.picTree.Image = My.Resources._0_tree_2
            GuestScreen.picTree.Image = My.Resources._0_tree_2
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_2
        End If
        If Game.level = 3 Then
            Game.varCurrent = "Pulover FE"
            Game.varQLeft = "2"
            HostScreen.picTree.Image = My.Resources._0_tree_3
            GuestScreen.picTree.Image = My.Resources._0_tree_3
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_3
        End If
        If Game.level = 4 Then
            Game.varCurrent = "Earbuds Mi"
            Game.varQLeft = "1"
            HostScreen.picTree.Image = My.Resources._0_tree_4
            GuestScreen.picTree.Image = My.Resources._0_tree_4
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_4
        End If
        If Game.level = 5 Then
            Game.varCurrent = "iPhone 15"
            Game.varQLeft = "0"
            HostScreen.picTree.Image = My.Resources._0_tree_5
            GuestScreen.picTree.Image = My.Resources._0_tree_5
            TVControlPnl.picTree.BackgroundImage = My.Resources._0_tree_5
        End If
    End Sub

End Class
