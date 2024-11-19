using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.DataFormats;

namespace StudentScores
{
    public partial class UpdateStudentScores : Form
    {
        public static Dictionary<string, List<int>> listStudents;
        //using binding source for inheritance
        BindingSource bs = new BindingSource();
        public static int selectedScore;
        public UpdateStudentScores()
        {
            InitializeComponent();
        }
        private void UpdateStudentScores_Load(object sender, EventArgs e)
        {
            //loading scores into the list
            listStudents = StudentScores.students.ToDictionary(p => p.Key, p => p.Value.ToList());
        }
        private void UpdateStudentScores_Activated(object sender, EventArgs e)
        {
            if (StudentScores.selected >= 0 && StudentScores.selected < listStudents.Count)
            {
                // textbox text to selected student name
                ussTxtName.Text = listStudents.Keys.ElementAt(StudentScores.selected);

                // add list of scores to usslistBox
                bs.DataSource = listStudents.Values.ElementAt(StudentScores.selected);
                usslistBox.DataSource = bs;
            }
            else
            {
                // if no student is selected
                ussTxtName.Text = "No student selected";
                usslistBox.DataSource = null; 
            }
        }

        private void ussbtnAdd_Click(object sender, EventArgs e)
        {
            Form addForm = new Add_UpdateScore();
            DialogResult result = addForm.ShowDialog(); //show dialog
            bs.ResetBindings(false);
        }

        private void ussbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ussbtnOk_Click(object sender, EventArgs e)
        {
            //simply seting the students and their scores to the list
            StudentScores.students = listStudents;
            this.Close();
        }

        private void ussbtnUpdate_Click(object sender, EventArgs e)
        {
            selectedScore = usslistBox.SelectedIndex;
            Form updateScore = new Add_UpdateScore();
            updateScore.ShowDialog();
            bs.ResetBindings(false);
        }

        private void ussbtnRemove_Click(object sender, EventArgs e)
        {
            //if listbox1 is empty throw an error
            if (usslistBox.Items.Count == 0)
            {
                MessageBox.Show("No scores to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                listStudents.Values.ElementAt(StudentScores.selected).RemoveAt(usslistBox.SelectedIndex);
                bs.ResetBindings(false);
            }

        }

        private void ussbtnClearScores_Click(object sender, EventArgs e)
        {
            listStudents.Values.ElementAt(StudentScores.selected).RemoveRange(
         0, listStudents.Values.ElementAt(StudentScores.selected).Count);
            bs.ResetBindings(false);
        }

        private void ussTxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
