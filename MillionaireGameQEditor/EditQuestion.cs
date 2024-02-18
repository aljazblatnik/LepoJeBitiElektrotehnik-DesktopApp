﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmEditQuestion : Form
    {

        int fff_answer = 0;

        private readonly QEditor _qe;

        public frmEditQuestion(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            QEditor.c.Open();
            if (txtLevel.Text == "Lvl1")
            {
                cmd = new SqlCommand("UPDATE questions_Level0 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type,Note = @Note, Used = @Used WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Used", cbUsed.Checked);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl2")
            {
                cmd = new SqlCommand("UPDATE questions_Level1 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type,Note = @Note, Used = @Used WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Used", cbUsed.Checked);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl3")
            {
                cmd = new SqlCommand("UPDATE questions_Level2 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type,Note = @Note, Used = @Used WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Used", cbUsed.Checked);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl4")
            {
                cmd = new SqlCommand("UPDATE questions_Level3 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type,Note = @Note, Used = @Used WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Used", cbUsed.Checked);
                cmd.ExecuteNonQuery();
            }
            else if (txtLevel.Text == "Lvl5")
            {
                cmd = new SqlCommand("UPDATE questions_Level4 SET Question=@Question,A = @A,B = @B,C = @C,D = @D,CorrectAnswer = @Correct,Type = @Type,Note = @Note, Used = @Used WHERE Id = @Id", QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", txtLevel.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Used", cbUsed.Checked);
                cmd.ExecuteNonQuery();
            }
            QEditor.c.Close();
            this._qe.UpdateDB();
            this.Close();
            Console.WriteLine("[{0}] Database EDIT operation completed succesfully!", DateTime.Now);
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {
            txtCorrect.Visible = true;
            pnlFFFAnswer.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "*";
            fff_answer = 0;
            btnFFFA.Enabled = true;
            btnFFFB.Enabled = true;
            btnFFFC.Enabled = true;
            btnFFFD.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFFFA_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            
            lblAnswer.Text = lblAnswer.Text + "A";
            btnFFFA.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFB_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "B";
            btnFFFB.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFC_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "C";
            btnFFFC.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnFFFD_Click_1(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }

            lblAnswer.Text = lblAnswer.Text + "D";
            btnFFFD.Enabled = false;
            btnReset.Enabled = true;

            fff_answer++;
            if (fff_answer == 4)
            {
                btnSave.Enabled = true;
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            labelCharLeftQuestion.Text = (200 - txtQuestion.Text.Length).ToString();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            labelCharLeftA.Text = (50 - txtA.Text.Length).ToString();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            labelCharLeftB.Text = (50 - txtB.Text.Length).ToString();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            labelCharLeftC.Text = (50 - txtC.Text.Length).ToString();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            labelCharLeftD.Text = (50 - txtD.Text.Length).ToString();
        }
    }
}
