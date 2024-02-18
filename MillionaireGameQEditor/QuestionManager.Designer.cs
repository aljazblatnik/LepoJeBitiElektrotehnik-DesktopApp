namespace Millionaire
{
    partial class QEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QEditor));
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsChangeLevel = new System.Windows.Forms.ToolStripButton();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblId = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmenuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuActionsResetAllQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel1UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel2UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel3UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel4UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel5UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuControls = new System.Windows.Forms.MenuStrip();
            this.tbLevel4 = new System.Windows.Forms.TabPage();
            this.dtLevel4 = new System.Windows.Forms.DataGridView();
            this.tbLevel3 = new System.Windows.Forms.TabPage();
            this.dtLevel3 = new System.Windows.Forms.DataGridView();
            this.tbLevel2 = new System.Windows.Forms.TabPage();
            this.dtLevel2 = new System.Windows.Forms.DataGridView();
            this.tbLevel1 = new System.Windows.Forms.TabPage();
            this.dtLevel1 = new System.Windows.Forms.DataGridView();
            this.tbLevel0 = new System.Windows.Forms.TabPage();
            this.dtLevel0 = new System.Windows.Forms.DataGridView();
            this.tbLevel = new System.Windows.Forms.TabControl();
            this.tsTools.SuspendLayout();
            this.sts.SuspendLayout();
            this.menuControls.SuspendLayout();
            this.tbLevel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel4)).BeginInit();
            this.tbLevel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel3)).BeginInit();
            this.tbLevel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel2)).BeginInit();
            this.tbLevel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel1)).BeginInit();
            this.tbLevel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel0)).BeginInit();
            this.tbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsRemove,
            this.tsEdit,
            this.toolStripSeparator1,
            this.tsRefresh,
            this.toolStripSeparator2,
            this.tsChangeLevel});
            this.tsTools.Location = new System.Drawing.Point(0, 24);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(1452, 25);
            this.tsTools.TabIndex = 23;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsAdd.Image")));
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(58, 22);
            this.tsAdd.Text = "Dodaj";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsRemove
            // 
            this.tsRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsRemove.Image")));
            this.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(72, 22);
            this.tsRemove.Text = "Odstrani";
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(55, 22);
            this.tsEdit.Text = "Uredi";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsRefresh
            // 
            this.tsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsRefresh.Text = "Osveži";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsChangeLevel
            // 
            this.tsChangeLevel.Image = global::MillionaireGameQEditor.Properties.Resources.move_icon;
            this.tsChangeLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChangeLevel.Name = "tsChangeLevel";
            this.tsChangeLevel.Size = new System.Drawing.Size(103, 22);
            this.tsChangeLevel.Text = "Spremeni nivo";
            this.tsChangeLevel.Click += new System.EventHandler(this.tsChangeLevel_Click);
            // 
            // sts
            // 
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.stlblId,
            this.stLevel});
            this.sts.Location = new System.Drawing.Point(0, 742);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(1452, 22);
            this.sts.TabIndex = 25;
            this.sts.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.Text = "Pripravljen";
            // 
            // stlblId
            // 
            this.stlblId.ForeColor = System.Drawing.Color.Blue;
            this.stlblId.Name = "stlblId";
            this.stlblId.Size = new System.Drawing.Size(13, 17);
            this.stlblId.Text = "0";
            // 
            // stLevel
            // 
            this.stLevel.ForeColor = System.Drawing.Color.Fuchsia;
            this.stLevel.Name = "stLevel";
            this.stLevel.Size = new System.Drawing.Size(61, 17);
            this.stLevel.Text = "Ni izbrano";
            // 
            // tsmenuActions
            // 
            this.tsmenuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUsedQuestionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.tsmenuActions.Name = "tsmenuActions";
            this.tsmenuActions.Size = new System.Drawing.Size(51, 20);
            this.tsmenuActions.Text = "Akcije";
            // 
            // resetUsedQuestionsToolStripMenuItem
            // 
            this.resetUsedQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuActionsResetAllQuestions,
            this.resetLevel1UsedQuestionsToolStripMenuItem,
            this.resetLevel2UsedQuestionsToolStripMenuItem,
            this.resetLevel3UsedQuestionsToolStripMenuItem,
            this.resetLevel4UsedQuestionsToolStripMenuItem,
            this.resetLevel5UsedQuestionsToolStripMenuItem});
            this.resetUsedQuestionsToolStripMenuItem.Name = "resetUsedQuestionsToolStripMenuItem";
            this.resetUsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.resetUsedQuestionsToolStripMenuItem.Text = "Ponastavi uporabljena vprašanja";
            // 
            // tsmenuActionsResetAllQuestions
            // 
            this.tsmenuActionsResetAllQuestions.Name = "tsmenuActionsResetAllQuestions";
            this.tsmenuActionsResetAllQuestions.Size = new System.Drawing.Size(180, 22);
            this.tsmenuActionsResetAllQuestions.Text = "Vsa";
            this.tsmenuActionsResetAllQuestions.Click += new System.EventHandler(this.tsmenuActionsResetAllQuestions_Click_1);
            // 
            // resetLevel1UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel1UsedQuestionsToolStripMenuItem.Name = "resetLevel1UsedQuestionsToolStripMenuItem";
            this.resetLevel1UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel1UsedQuestionsToolStripMenuItem.Text = "Samo 1. nivo";
            this.resetLevel1UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetFastestFingerUsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel2UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel2UsedQuestionsToolStripMenuItem.Name = "resetLevel2UsedQuestionsToolStripMenuItem";
            this.resetLevel2UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel2UsedQuestionsToolStripMenuItem.Text = "Samo 2. nivo";
            this.resetLevel2UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel1UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel3UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel3UsedQuestionsToolStripMenuItem.Name = "resetLevel3UsedQuestionsToolStripMenuItem";
            this.resetLevel3UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel3UsedQuestionsToolStripMenuItem.Text = "Samo 3. nivo";
            this.resetLevel3UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel2UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel4UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel4UsedQuestionsToolStripMenuItem.Name = "resetLevel4UsedQuestionsToolStripMenuItem";
            this.resetLevel4UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel4UsedQuestionsToolStripMenuItem.Text = "Samo 4. nivo";
            this.resetLevel4UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel3UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel5UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel5UsedQuestionsToolStripMenuItem.Name = "resetLevel5UsedQuestionsToolStripMenuItem";
            this.resetLevel5UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel5UsedQuestionsToolStripMenuItem.Text = "Samo 5. nivo";
            this.resetLevel5UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel4UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(241, 6);
            // 
            // menuControls
            // 
            this.menuControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuActions});
            this.menuControls.Location = new System.Drawing.Point(0, 0);
            this.menuControls.Name = "menuControls";
            this.menuControls.Size = new System.Drawing.Size(1452, 24);
            this.menuControls.TabIndex = 24;
            this.menuControls.Text = "menuStrip1";
            // 
            // tbLevel4
            // 
            this.tbLevel4.Controls.Add(this.dtLevel4);
            this.tbLevel4.Location = new System.Drawing.Point(4, 22);
            this.tbLevel4.Name = "tbLevel4";
            this.tbLevel4.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel4.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel4.TabIndex = 3;
            this.tbLevel4.Text = "Nivo 5";
            this.tbLevel4.UseVisualStyleBackColor = true;
            // 
            // dtLevel4
            // 
            this.dtLevel4.AllowUserToAddRows = false;
            this.dtLevel4.AllowUserToDeleteRows = false;
            this.dtLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel4.Location = new System.Drawing.Point(6, 6);
            this.dtLevel4.Name = "dtLevel4";
            this.dtLevel4.ReadOnly = true;
            this.dtLevel4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel4.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel4.TabIndex = 15;
            this.dtLevel4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel4_CellClick);
            this.dtLevel4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel4_CellDoubleClick);
            this.dtLevel4.SelectionChanged += new System.EventHandler(this.dtLevel4_SelectionChanged);
            // 
            // tbLevel3
            // 
            this.tbLevel3.Controls.Add(this.dtLevel3);
            this.tbLevel3.Location = new System.Drawing.Point(4, 22);
            this.tbLevel3.Name = "tbLevel3";
            this.tbLevel3.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel3.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel3.TabIndex = 2;
            this.tbLevel3.Text = "Nivo 4";
            this.tbLevel3.UseVisualStyleBackColor = true;
            // 
            // dtLevel3
            // 
            this.dtLevel3.AllowUserToAddRows = false;
            this.dtLevel3.AllowUserToDeleteRows = false;
            this.dtLevel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel3.Location = new System.Drawing.Point(6, 6);
            this.dtLevel3.Name = "dtLevel3";
            this.dtLevel3.ReadOnly = true;
            this.dtLevel3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel3.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel3.TabIndex = 15;
            this.dtLevel3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel3_CellClick);
            this.dtLevel3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel3_CellDoubleClick);
            this.dtLevel3.SelectionChanged += new System.EventHandler(this.dtLevel3_SelectionChanged);
            // 
            // tbLevel2
            // 
            this.tbLevel2.Controls.Add(this.dtLevel2);
            this.tbLevel2.Location = new System.Drawing.Point(4, 22);
            this.tbLevel2.Name = "tbLevel2";
            this.tbLevel2.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel2.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel2.TabIndex = 1;
            this.tbLevel2.Text = "Nivo 3";
            this.tbLevel2.UseVisualStyleBackColor = true;
            // 
            // dtLevel2
            // 
            this.dtLevel2.AllowUserToAddRows = false;
            this.dtLevel2.AllowUserToDeleteRows = false;
            this.dtLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel2.Location = new System.Drawing.Point(6, 6);
            this.dtLevel2.Name = "dtLevel2";
            this.dtLevel2.ReadOnly = true;
            this.dtLevel2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel2.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel2.TabIndex = 15;
            this.dtLevel2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel2_CellClick);
            this.dtLevel2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel2_CellDoubleClick);
            this.dtLevel2.SelectionChanged += new System.EventHandler(this.dtLevel2_SelectionChanged);
            // 
            // tbLevel1
            // 
            this.tbLevel1.Controls.Add(this.dtLevel1);
            this.tbLevel1.Location = new System.Drawing.Point(4, 22);
            this.tbLevel1.Name = "tbLevel1";
            this.tbLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel1.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel1.TabIndex = 0;
            this.tbLevel1.Text = "Nivo 2";
            this.tbLevel1.UseVisualStyleBackColor = true;
            // 
            // dtLevel1
            // 
            this.dtLevel1.AllowUserToAddRows = false;
            this.dtLevel1.AllowUserToDeleteRows = false;
            this.dtLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel1.Location = new System.Drawing.Point(6, 6);
            this.dtLevel1.Name = "dtLevel1";
            this.dtLevel1.ReadOnly = true;
            this.dtLevel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel1.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel1.TabIndex = 14;
            this.dtLevel1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel1_CellClick);
            this.dtLevel1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel1_CellDoubleClick);
            this.dtLevel1.SelectionChanged += new System.EventHandler(this.dtLevel1_SelectionChanged);
            // 
            // tbLevel0
            // 
            this.tbLevel0.Controls.Add(this.dtLevel0);
            this.tbLevel0.Location = new System.Drawing.Point(4, 22);
            this.tbLevel0.Name = "tbLevel0";
            this.tbLevel0.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel0.TabIndex = 4;
            this.tbLevel0.Text = "Nivo 1";
            this.tbLevel0.UseVisualStyleBackColor = true;
            // 
            // dtLevel0
            // 
            this.dtLevel0.AllowUserToAddRows = false;
            this.dtLevel0.AllowUserToDeleteRows = false;
            this.dtLevel0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel0.Location = new System.Drawing.Point(6, 6);
            this.dtLevel0.Name = "dtLevel0";
            this.dtLevel0.ReadOnly = true;
            this.dtLevel0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel0.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel0.TabIndex = 16;
            this.dtLevel0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel0_CellClick);
            this.dtLevel0.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel0_CellDoubleClick);
            this.dtLevel0.SelectionChanged += new System.EventHandler(this.dtLevel0_SelectionChanged);
            // 
            // tbLevel
            // 
            this.tbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLevel.Controls.Add(this.tbLevel0);
            this.tbLevel.Controls.Add(this.tbLevel1);
            this.tbLevel.Controls.Add(this.tbLevel2);
            this.tbLevel.Controls.Add(this.tbLevel3);
            this.tbLevel.Controls.Add(this.tbLevel4);
            this.tbLevel.Location = new System.Drawing.Point(0, 50);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.SelectedIndex = 0;
            this.tbLevel.Size = new System.Drawing.Size(1452, 689);
            this.tbLevel.TabIndex = 22;
            this.tbLevel.SelectedIndexChanged += new System.EventHandler(this.tbLevel_SelectedIndexChanged);
            // 
            // QEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 764);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.menuControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuControls;
            this.Name = "QEditor";
            this.Text = "Urejevalnik vprašanj - Lepo je biti elektrotehnik";
            this.Load += new System.EventHandler(this.QEditor_Load);
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.sts.ResumeLayout(false);
            this.sts.PerformLayout();
            this.menuControls.ResumeLayout(false);
            this.menuControls.PerformLayout();
            this.tbLevel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel4)).EndInit();
            this.tbLevel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel3)).EndInit();
            this.tbLevel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel2)).EndInit();
            this.tbLevel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel1)).EndInit();
            this.tbLevel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel0)).EndInit();
            this.tbLevel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsRemove;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel stlblId;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripStatusLabel stLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmenuActions;
        private System.Windows.Forms.MenuStrip menuControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsChangeLevel;
        private System.Windows.Forms.ToolStripMenuItem resetUsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmenuActionsResetAllQuestions;
        private System.Windows.Forms.ToolStripMenuItem resetLevel1UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel2UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel3UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel4UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetLevel5UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tbLevel4;
        public System.Windows.Forms.DataGridView dtLevel4;
        private System.Windows.Forms.TabPage tbLevel3;
        public System.Windows.Forms.DataGridView dtLevel3;
        private System.Windows.Forms.TabPage tbLevel2;
        public System.Windows.Forms.DataGridView dtLevel2;
        private System.Windows.Forms.TabPage tbLevel1;
        public System.Windows.Forms.DataGridView dtLevel1;
        private System.Windows.Forms.TabPage tbLevel0;
        public System.Windows.Forms.DataGridView dtLevel0;
        private System.Windows.Forms.TabControl tbLevel;
    }
}