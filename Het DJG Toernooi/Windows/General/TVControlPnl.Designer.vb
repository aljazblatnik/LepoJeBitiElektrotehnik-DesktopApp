<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TVControlPnl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TVControlPnl))
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStrap = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblATA_D = New System.Windows.Forms.Label()
        Me.lblATA_B = New System.Windows.Forms.Label()
        Me.lblATA_C = New System.Windows.Forms.Label()
        Me.lblATA_A = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrRandomizer = New System.Windows.Forms.Timer(Me.components)
        Me.grpATA = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlQuestion = New System.Windows.Forms.Panel()
        Me.picD = New System.Windows.Forms.Panel()
        Me.txtD = New System.Windows.Forms.Label()
        Me.picB = New System.Windows.Forms.Panel()
        Me.txtB = New System.Windows.Forms.Label()
        Me.picC = New System.Windows.Forms.Panel()
        Me.txtC = New System.Windows.Forms.Label()
        Me.picA = New System.Windows.Forms.Panel()
        Me.txtA = New System.Windows.Forms.Label()
        Me.picQuestion = New System.Windows.Forms.Panel()
        Me.txtQuestion = New System.Windows.Forms.Label()
        Me.pnlFFFWinner = New System.Windows.Forms.Panel()
        Me.lblFFFWinnerPoints = New System.Windows.Forms.Label()
        Me.lblFFFWinnerName = New System.Windows.Forms.Label()
        Me.pnlStrap = New System.Windows.Forms.Panel()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.picTree = New System.Windows.Forms.Panel()
        Me.picAW = New System.Windows.Forms.PictureBox()
        Me.picPO = New System.Windows.Forms.PictureBox()
        Me.AWTVpanel = New System.Windows.Forms.Panel()
        Me.AWlabelD = New System.Windows.Forms.Label()
        Me.AWlabelC = New System.Windows.Forms.Label()
        Me.AWlabelB = New System.Windows.Forms.Label()
        Me.AWlabelA = New System.Windows.Forms.Label()
        Me.AWpbD = New MillionaireGame.VerticalProgressBar()
        Me.AWpbC = New MillionaireGame.VerticalProgressBar()
        Me.AWpbB = New MillionaireGame.VerticalProgressBar()
        Me.AWpbA = New MillionaireGame.VerticalProgressBar()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbQRcode = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnlTime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpATA.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuestion.SuspendLayout()
        Me.picD.SuspendLayout()
        Me.picB.SuspendLayout()
        Me.picC.SuspendLayout()
        Me.picA.SuspendLayout()
        Me.picQuestion.SuspendLayout()
        Me.pnlFFFWinner.SuspendLayout()
        Me.pnlStrap.SuspendLayout()
        Me.picTree.SuspendLayout()
        CType(Me.picAW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AWTVpanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQRcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 175
        '
        'tmrStrap
        '
        Me.tmrStrap.Interval = 1250
        '
        'pnlTime
        '
        Me.pnlTime.Controls.Add(Me.PictureBox1)
        Me.pnlTime.Controls.Add(Me.lblTime)
        Me.pnlTime.Location = New System.Drawing.Point(25, 274)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(204, 63)
        Me.pnlTime.TabIndex = 30
        Me.pnlTime.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(59, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(159, 71)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "30"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblATA_D
        '
        Me.lblATA_D.AutoSize = True
        Me.lblATA_D.BackColor = System.Drawing.Color.Transparent
        Me.lblATA_D.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATA_D.ForeColor = System.Drawing.Color.White
        Me.lblATA_D.Location = New System.Drawing.Point(81, 112)
        Me.lblATA_D.Name = "lblATA_D"
        Me.lblATA_D.Size = New System.Drawing.Size(56, 39)
        Me.lblATA_D.TabIndex = 25
        Me.lblATA_D.Text = "0%"
        Me.lblATA_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblATA_B
        '
        Me.lblATA_B.AutoSize = True
        Me.lblATA_B.BackColor = System.Drawing.Color.Transparent
        Me.lblATA_B.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATA_B.ForeColor = System.Drawing.Color.White
        Me.lblATA_B.Location = New System.Drawing.Point(81, 48)
        Me.lblATA_B.Name = "lblATA_B"
        Me.lblATA_B.Size = New System.Drawing.Size(56, 39)
        Me.lblATA_B.TabIndex = 24
        Me.lblATA_B.Text = "0%"
        Me.lblATA_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblATA_C
        '
        Me.lblATA_C.AutoSize = True
        Me.lblATA_C.BackColor = System.Drawing.Color.Transparent
        Me.lblATA_C.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATA_C.ForeColor = System.Drawing.Color.White
        Me.lblATA_C.Location = New System.Drawing.Point(81, 80)
        Me.lblATA_C.Name = "lblATA_C"
        Me.lblATA_C.Size = New System.Drawing.Size(56, 39)
        Me.lblATA_C.TabIndex = 23
        Me.lblATA_C.Text = "0%"
        Me.lblATA_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblATA_A
        '
        Me.lblATA_A.AutoSize = True
        Me.lblATA_A.BackColor = System.Drawing.Color.Transparent
        Me.lblATA_A.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATA_A.ForeColor = System.Drawing.Color.White
        Me.lblATA_A.Location = New System.Drawing.Point(81, 15)
        Me.lblATA_A.Name = "lblATA_A"
        Me.lblATA_A.Size = New System.Drawing.Size(56, 39)
        Me.lblATA_A.TabIndex = 22
        Me.lblATA_A.Text = "0%"
        Me.lblATA_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'tmrRandomizer
        '
        Me.tmrRandomizer.Interval = 150
        '
        'grpATA
        '
        Me.grpATA.BackColor = System.Drawing.Color.Transparent
        Me.grpATA.Controls.Add(Me.PictureBox2)
        Me.grpATA.Controls.Add(Me.lblATA_D)
        Me.grpATA.Controls.Add(Me.lblATA_A)
        Me.grpATA.Controls.Add(Me.lblATA_C)
        Me.grpATA.Controls.Add(Me.lblATA_B)
        Me.grpATA.Location = New System.Drawing.Point(25, 51)
        Me.grpATA.Name = "grpATA"
        Me.grpATA.Size = New System.Drawing.Size(233, 165)
        Me.grpATA.TabIndex = 32
        Me.grpATA.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(13, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'pnlQuestion
        '
        Me.pnlQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlQuestion.Controls.Add(Me.picD)
        Me.pnlQuestion.Controls.Add(Me.picB)
        Me.pnlQuestion.Controls.Add(Me.picC)
        Me.pnlQuestion.Controls.Add(Me.picA)
        Me.pnlQuestion.Controls.Add(Me.picQuestion)
        Me.pnlQuestion.Location = New System.Drawing.Point(0, 710)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(1920, 303)
        Me.pnlQuestion.TabIndex = 27
        Me.pnlQuestion.Visible = False
        '
        'picD
        '
        Me.picD.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.Normal_Answer_Fill_r
        Me.picD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picD.Controls.Add(Me.txtD)
        Me.picD.Location = New System.Drawing.Point(975, 221)
        Me.picD.Name = "picD"
        Me.picD.Size = New System.Drawing.Size(945, 69)
        Me.picD.TabIndex = 37
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.Transparent
        Me.txtD.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.txtD.ForeColor = System.Drawing.Color.White
        Me.txtD.Location = New System.Drawing.Point(49, 10)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(720, 46)
        Me.txtD.TabIndex = 19
        Me.txtD.Text = "D:"
        Me.txtD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picB
        '
        Me.picB.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.Normal_Answer_Fill_r
        Me.picB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picB.Controls.Add(Me.txtB)
        Me.picB.Location = New System.Drawing.Point(975, 143)
        Me.picB.Name = "picB"
        Me.picB.Size = New System.Drawing.Size(942, 72)
        Me.picB.TabIndex = 36
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.Transparent
        Me.txtB.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.txtB.ForeColor = System.Drawing.Color.White
        Me.txtB.Location = New System.Drawing.Point(49, 11)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(720, 46)
        Me.txtB.TabIndex = 20
        Me.txtB.Text = "B:"
        Me.txtB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC
        '
        Me.picC.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.Normal_Answer_Fill_l
        Me.picC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picC.Controls.Add(Me.txtC)
        Me.picC.Location = New System.Drawing.Point(0, 221)
        Me.picC.Name = "picC"
        Me.picC.Size = New System.Drawing.Size(969, 69)
        Me.picC.TabIndex = 35
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.Transparent
        Me.txtC.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.txtC.ForeColor = System.Drawing.Color.White
        Me.txtC.Location = New System.Drawing.Point(187, 10)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(727, 46)
        Me.txtC.TabIndex = 18
        Me.txtC.Text = "C:"
        Me.txtC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picA
        '
        Me.picA.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.Normal_Answer_Fill_l
        Me.picA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picA.Controls.Add(Me.txtA)
        Me.picA.Location = New System.Drawing.Point(0, 143)
        Me.picA.Name = "picA"
        Me.picA.Size = New System.Drawing.Size(969, 72)
        Me.picA.TabIndex = 34
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.Transparent
        Me.txtA.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.txtA.ForeColor = System.Drawing.Color.White
        Me.txtA.Location = New System.Drawing.Point(187, 11)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(727, 46)
        Me.txtA.TabIndex = 19
        Me.txtA.Text = "A:"
        Me.txtA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picQuestion
        '
        Me.picQuestion.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.Large_Strap_Fill
        Me.picQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picQuestion.Controls.Add(Me.txtQuestion)
        Me.picQuestion.Location = New System.Drawing.Point(3, 17)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(1914, 104)
        Me.picQuestion.TabIndex = 38
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.Font = New System.Drawing.Font("Calibri", 30.0!)
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(197, -2)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(1521, 105)
        Me.txtQuestion.TabIndex = 13
        Me.txtQuestion.Text = "Tu se nahaja vprašanje"
        Me.txtQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFFFWinner
        '
        Me.pnlFFFWinner.BackColor = System.Drawing.Color.Transparent
        Me.pnlFFFWinner.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.fff_fastest_new
        Me.pnlFFFWinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFFFWinner.Controls.Add(Me.lblFFFWinnerPoints)
        Me.pnlFFFWinner.Controls.Add(Me.lblFFFWinnerName)
        Me.pnlFFFWinner.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlFFFWinner.Location = New System.Drawing.Point(0, 810)
        Me.pnlFFFWinner.Name = "pnlFFFWinner"
        Me.pnlFFFWinner.Size = New System.Drawing.Size(1920, 75)
        Me.pnlFFFWinner.TabIndex = 34
        Me.pnlFFFWinner.Visible = False
        '
        'lblFFFWinnerPoints
        '
        Me.lblFFFWinnerPoints.BackColor = System.Drawing.Color.Transparent
        Me.lblFFFWinnerPoints.Font = New System.Drawing.Font("Calibri", 28.82!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFFFWinnerPoints.ForeColor = System.Drawing.Color.Black
        Me.lblFFFWinnerPoints.Location = New System.Drawing.Point(1222, 11)
        Me.lblFFFWinnerPoints.Name = "lblFFFWinnerPoints"
        Me.lblFFFWinnerPoints.Size = New System.Drawing.Size(120, 47)
        Me.lblFFFWinnerPoints.TabIndex = 9
        Me.lblFFFWinnerPoints.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFFFWinnerName
        '
        Me.lblFFFWinnerName.BackColor = System.Drawing.Color.Transparent
        Me.lblFFFWinnerName.Font = New System.Drawing.Font("Calibri", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFFFWinnerName.ForeColor = System.Drawing.Color.Black
        Me.lblFFFWinnerName.Location = New System.Drawing.Point(559, 5)
        Me.lblFFFWinnerName.Name = "lblFFFWinnerName"
        Me.lblFFFWinnerName.Size = New System.Drawing.Size(806, 71)
        Me.lblFFFWinnerName.TabIndex = 8
        Me.lblFFFWinnerName.Text = "Player Name"
        Me.lblFFFWinnerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlStrap
        '
        Me.pnlStrap.BackColor = System.Drawing.Color.Transparent
        Me.pnlStrap.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.winning_strap
        Me.pnlStrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlStrap.Controls.Add(Me.lblAmount)
        Me.pnlStrap.Location = New System.Drawing.Point(0, 810)
        Me.pnlStrap.Name = "pnlStrap"
        Me.pnlStrap.Size = New System.Drawing.Size(1920, 109)
        Me.pnlStrap.TabIndex = 28
        Me.pnlStrap.Visible = False
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Copperplate Gothic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(716, 22)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(500, 75)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "200.000"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTree
        '
        Me.picTree.BackColor = System.Drawing.Color.Transparent
        Me.picTree.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.tree_0
        Me.picTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTree.Controls.Add(Me.picAW)
        Me.picTree.Controls.Add(Me.picPO)
        Me.picTree.Location = New System.Drawing.Point(153, 0)
        Me.picTree.Name = "picTree"
        Me.picTree.Size = New System.Drawing.Size(1767, 1081)
        Me.picTree.TabIndex = 29
        Me.picTree.Visible = False
        '
        'picAW
        '
        Me.picAW.BackColor = System.Drawing.Color.Transparent
        Me.picAW.Image = Global.MillionaireGame.My.Resources.Resources.lifeline_4
        Me.picAW.Location = New System.Drawing.Point(1212, 32)
        Me.picAW.Name = "picAW"
        Me.picAW.Size = New System.Drawing.Size(118, 73)
        Me.picAW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAW.TabIndex = 3
        Me.picAW.TabStop = False
        '
        'picPO
        '
        Me.picPO.BackColor = System.Drawing.Color.Transparent
        Me.picPO.Image = Global.MillionaireGame.My.Resources.Resources.lifeline_3
        Me.picPO.Location = New System.Drawing.Point(1347, 32)
        Me.picPO.Name = "picPO"
        Me.picPO.Size = New System.Drawing.Size(118, 73)
        Me.picPO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPO.TabIndex = 2
        Me.picPO.TabStop = False
        '
        'AWTVpanel
        '
        Me.AWTVpanel.Controls.Add(Me.AWlabelD)
        Me.AWTVpanel.Controls.Add(Me.AWlabelC)
        Me.AWTVpanel.Controls.Add(Me.AWlabelB)
        Me.AWTVpanel.Controls.Add(Me.AWlabelA)
        Me.AWTVpanel.Controls.Add(Me.AWpbD)
        Me.AWTVpanel.Controls.Add(Me.AWpbC)
        Me.AWTVpanel.Controls.Add(Me.AWpbB)
        Me.AWTVpanel.Controls.Add(Me.AWpbA)
        Me.AWTVpanel.Controls.Add(Me.PictureBox5)
        Me.AWTVpanel.Location = New System.Drawing.Point(12, 332)
        Me.AWTVpanel.Name = "AWTVpanel"
        Me.AWTVpanel.Size = New System.Drawing.Size(300, 379)
        Me.AWTVpanel.TabIndex = 4
        Me.AWTVpanel.Visible = False
        '
        'AWlabelD
        '
        Me.AWlabelD.AutoSize = True
        Me.AWlabelD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AWlabelD.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWlabelD.ForeColor = System.Drawing.Color.White
        Me.AWlabelD.Location = New System.Drawing.Point(211, 41)
        Me.AWlabelD.Name = "AWlabelD"
        Me.AWlabelD.Size = New System.Drawing.Size(48, 23)
        Me.AWlabelD.TabIndex = 9
        Me.AWlabelD.Text = "25%"
        Me.AWlabelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AWlabelC
        '
        Me.AWlabelC.AutoSize = True
        Me.AWlabelC.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AWlabelC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWlabelC.ForeColor = System.Drawing.Color.White
        Me.AWlabelC.Location = New System.Drawing.Point(156, 41)
        Me.AWlabelC.Name = "AWlabelC"
        Me.AWlabelC.Size = New System.Drawing.Size(48, 23)
        Me.AWlabelC.TabIndex = 8
        Me.AWlabelC.Text = "25%"
        Me.AWlabelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AWlabelB
        '
        Me.AWlabelB.AutoSize = True
        Me.AWlabelB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AWlabelB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWlabelB.ForeColor = System.Drawing.Color.White
        Me.AWlabelB.Location = New System.Drawing.Point(101, 41)
        Me.AWlabelB.Name = "AWlabelB"
        Me.AWlabelB.Size = New System.Drawing.Size(48, 23)
        Me.AWlabelB.TabIndex = 7
        Me.AWlabelB.Text = "25%"
        Me.AWlabelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AWlabelA
        '
        Me.AWlabelA.AutoSize = True
        Me.AWlabelA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AWlabelA.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWlabelA.ForeColor = System.Drawing.Color.White
        Me.AWlabelA.Location = New System.Drawing.Point(46, 41)
        Me.AWlabelA.Name = "AWlabelA"
        Me.AWlabelA.Size = New System.Drawing.Size(48, 23)
        Me.AWlabelA.TabIndex = 6
        Me.AWlabelA.Text = "25%"
        Me.AWlabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AWpbD
        '
        Me.AWpbD.Location = New System.Drawing.Point(215, 71)
        Me.AWpbD.Name = "AWpbD"
        Me.AWpbD.Size = New System.Drawing.Size(37, 235)
        Me.AWpbD.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.AWpbD.TabIndex = 5
        Me.AWpbD.Value = 25
        '
        'AWpbC
        '
        Me.AWpbC.Location = New System.Drawing.Point(160, 71)
        Me.AWpbC.Name = "AWpbC"
        Me.AWpbC.Size = New System.Drawing.Size(37, 235)
        Me.AWpbC.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.AWpbC.TabIndex = 4
        Me.AWpbC.Value = 25
        '
        'AWpbB
        '
        Me.AWpbB.Location = New System.Drawing.Point(105, 71)
        Me.AWpbB.Name = "AWpbB"
        Me.AWpbB.Size = New System.Drawing.Size(37, 235)
        Me.AWpbB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.AWpbB.TabIndex = 3
        Me.AWpbB.Value = 25
        '
        'AWpbA
        '
        Me.AWpbA.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.AWpbA.Location = New System.Drawing.Point(50, 71)
        Me.AWpbA.Name = "AWpbA"
        Me.AWpbA.Size = New System.Drawing.Size(37, 235)
        Me.AWpbA.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.AWpbA.TabIndex = 2
        Me.AWpbA.Value = 25
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MillionaireGame.My.Resources.Resources.AWback
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(296, 376)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'pbQRcode
        '
        Me.pbQRcode.Image = Global.MillionaireGame.My.Resources.Resources.QR_code
        Me.pbQRcode.Location = New System.Drawing.Point(0, 0)
        Me.pbQRcode.Name = "pbQRcode"
        Me.pbQRcode.Size = New System.Drawing.Size(1920, 1080)
        Me.pbQRcode.TabIndex = 35
        Me.pbQRcode.TabStop = False
        Me.pbQRcode.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1920, 1080)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'TVControlPnl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.AWTVpanel)
        Me.Controls.Add(Me.pnlFFFWinner)
        Me.Controls.Add(Me.pnlQuestion)
        Me.Controls.Add(Me.pnlStrap)
        Me.Controls.Add(Me.picTree)
        Me.Controls.Add(Me.pnlTime)
        Me.Controls.Add(Me.grpATA)
        Me.Controls.Add(Me.pbQRcode)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TVControlPnl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.pnlTime.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpATA.ResumeLayout(False)
        Me.grpATA.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuestion.ResumeLayout(False)
        Me.picD.ResumeLayout(False)
        Me.picB.ResumeLayout(False)
        Me.picC.ResumeLayout(False)
        Me.picA.ResumeLayout(False)
        Me.picQuestion.ResumeLayout(False)
        Me.pnlFFFWinner.ResumeLayout(False)
        Me.pnlStrap.ResumeLayout(False)
        Me.picTree.ResumeLayout(False)
        CType(Me.picAW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AWTVpanel.ResumeLayout(False)
        Me.AWTVpanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQRcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlQuestion As Panel
    Friend WithEvents tmrFlash As Timer
    Friend WithEvents tmrStrap As Timer
    Friend WithEvents pnlStrap As Panel
    Friend WithEvents lblAmount As Label
    Friend WithEvents picTree As Panel
    Friend WithEvents pnlTime As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents picPO As PictureBox
    Friend WithEvents txtQuestion As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tmrRandomizer As Timer
    Friend WithEvents lblATA_D As Label
    Friend WithEvents lblATA_B As Label
    Friend WithEvents lblATA_C As Label
    Friend WithEvents lblATA_A As Label
    Friend WithEvents grpATA As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picA As Panel
    Friend WithEvents picQuestion As Panel
    Friend WithEvents picB As Panel
    Friend WithEvents picC As Panel
    Friend WithEvents picD As Panel
    Friend WithEvents txtD As Label
    Friend WithEvents txtC As Label
    Friend WithEvents txtB As Label
    Friend WithEvents txtA As Label
    Friend WithEvents pnlFFFWinner As Panel
    Friend WithEvents lblFFFWinnerPoints As Label
    Friend WithEvents lblFFFWinnerName As Label
    Friend WithEvents picAW As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbQRcode As PictureBox
    Friend WithEvents AWTVpanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents AWpbD As VerticalProgressBar
    Friend WithEvents AWpbC As VerticalProgressBar
    Friend WithEvents AWpbB As VerticalProgressBar
    Friend WithEvents AWpbA As VerticalProgressBar
    Friend WithEvents AWlabelD As Label
    Friend WithEvents AWlabelC As Label
    Friend WithEvents AWlabelB As Label
    Friend WithEvents AWlabelA As Label
End Class
