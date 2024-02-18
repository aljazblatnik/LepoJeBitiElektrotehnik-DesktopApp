using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Millionaire.Windows.Question_Editor
{
    public partial class frmQuestionAdd : Form
    {

        private readonly QEditor _qe;
        int fff_answer = 0;

        public frmQuestionAdd(QEditor q)
        {
            InitializeComponent();
            this._qe = q;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string levelType;
            SqlCommand cmd;

            if (txtLevel.Text == "Nivo 1")
            {
                levelType = "Lvl1";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level0 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (txtLevel.Text == "Nivo 2")
            {
                levelType = "Lvl2";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level1 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (txtLevel.Text == "Nivo 3")
            {
                levelType = "Lvl3";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level2 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (txtLevel.Text == "Nivo 4")
            {
                levelType = "Lvl4";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level3 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else if (txtLevel.Text == "Nivo 5")
            {
                levelType = "Lvl5";
                QEditor.c.Open();
                string str = String.Format(@"INSERT INTO questions_Level4 (Question, A, B, C, D, CorrectAnswer, Type, Note) VALUES(@Question, @A, @B, @C, @D, @Correct, @Type, @Note)");
                cmd = new SqlCommand(str, QEditor.c);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@A", txtA.Text);
                cmd.Parameters.AddWithValue("@B", txtB.Text);
                cmd.Parameters.AddWithValue("@C", txtC.Text);
                cmd.Parameters.AddWithValue("@D", txtD.Text);
                cmd.Parameters.AddWithValue("@Correct", txtCorrect.Text);
                cmd.Parameters.AddWithValue("@Type", levelType);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.ExecuteNonQuery();
                QEditor.c.Close();
            }
            else
            {
                Console.WriteLine("[{0}] Error while completing operation: Level type is invalid.", DateTime.Now);
                MessageBox.Show("Napačna vrednost nivoja vprašanja!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _qe.UpdateDB();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtCorrect.Text = "";
            txtLevel.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuestionAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtLevel.Text == "Fastest Finger Round")
            {
                txtCorrect.Visible = false;
                pnlFFFAnswer.Visible = true;
            }
            else
            {
                txtCorrect.Visible = true;
                pnlFFFAnswer.Visible = false;
            }
        }

        private void btnFFFA_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "A";
            btnFFFA.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFB_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "B";
            btnFFFB.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFC_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "C";
            btnFFFC.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnFFFD_Click(object sender, EventArgs e)
        {
            if (fff_answer == 0)
            {
                lblAnswer.Text = "";
            }
            lblAnswer.Text = lblAnswer.Text + "D";
            btnFFFD.Enabled = false;
            btnReset.Enabled = true;
            fff_answer++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "*";
            btnFFFA.Enabled = true;
            btnFFFB.Enabled = true;
            btnFFFC.Enabled = true;
            btnFFFD.Enabled = true;
            fff_answer = 0;
            btnReset.Enabled = false;
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

    public class Edits
    {
        public static void Remove(int Id)
        {

        }
    }
}
