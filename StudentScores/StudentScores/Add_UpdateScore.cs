using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Validator1 = StudentScores_Business.Validator;
namespace StudentScores
{
    public partial class Add_UpdateScore : Form
    {
        public Add_UpdateScore()
        {
            InitializeComponent();
        }

        private void asbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asbtnAdd_Click(object sender, EventArgs e)
        {
            if (!Validator1.IsInteger(astxtboxScore.Text))
            {
                MessageBox.Show("Please enter a valid integer score.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int score = int.Parse(astxtboxScore.Text);
            if (!Validator1.IsWithinRange(score, 0, 100))
            {
                MessageBox.Show("Please enter a valid score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UpdateStudentScores.listStudents.Values.ElementAt(UpdateStudentScores.selectedScore).Add(Int32.Parse(astxtboxScore.Text));
                this.Close();
            }
        }
    }
}
