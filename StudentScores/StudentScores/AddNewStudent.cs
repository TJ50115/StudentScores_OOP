using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using StudentScores;
using StudentScores_Business;
using static System.Windows.Forms.DataFormats;
using Validator1 = StudentScores_Business.Validator;
// there are two validators I guess?? it made me declare between the two, validator1 is my validator
using Validator2 = System.ComponentModel.DataAnnotations.Validator;


namespace StudentScores
{
    public partial class AddNewStudent : Form
    {
        Dictionary<string, List<int>> newStudent = new Dictionary<string, List<int>>();
        List<int> scores = new List<int>();
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void ansbtnAddScore_Click(object sender, EventArgs e)
        {
            if (!Validator1.IsInteger(ansTxtBoxScore.Text))
            {
                MessageBox.Show("Please enter a valid integer score.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int score = int.Parse(ansTxtBoxScore.Text);
            if (!Validator1.IsWithinRange(score, 0, 100))
            {
                MessageBox.Show("Please enter a valid score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                scores.Add(Int32.Parse(ansTxtBoxScore.Text));
                lblScores.Text = string.Join(", ", scores);
                ansTxtBoxScore.Focus();
            }
        }
        private void UpdateScoresLabel()
        {
            // update score label
            lblScores.Text = string.Join(", ", scores);
        }

        private void ansbtnOK_Click(object sender, EventArgs e)
        {

            string studentName = ansTxtBoxName.Text;
            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a student name.", "Blank Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate scores
            foreach (string scoreText in lblScores.Text.Split(','))
            {
                if (!Validator1.IsInteger(scoreText))
                {
                    MessageBox.Show("Please enter valid integer scores between 0 and 100.", "Invalid Scores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Parse scores
            List<int> scores = new List<int>();
            foreach (string scoreText in lblScores.Text.Split(','))
            {
                if (int.TryParse(scoreText, out int score))
                {
                    scores.Add(score);
                }
            }

            // create new student
            if (ansTxtBoxName.Text != "")
            {
                StudentScores.students.Add(ansTxtBoxName.Text, scores); //call the add functio to add the score to the dictionary
                this.Close();
            }
            else
            {
                //error
                MessageBox.Show("Please enter a name", "Empty Name field");
                ansTxtBoxName.Focus();
            }
        }

        private void ansbtnClearScores_Click(object sender, EventArgs e)
        {
            scores.Clear();
            ansTxtBoxName.Text = "";
            ansTxtBoxScore.Text = "";
            ansTxtBoxName.Focus();
        }

        private void ansbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
