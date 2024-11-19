using StudentScores_Business;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace StudentScores
{

    public partial class StudentScores : Form
    {
        public static Dictionary<string, List<int>> students = new Dictionary<string, List<int>>(); //creating a dictionary to try to get this to work
        public static int selected;
        public StudentScores()
        {
            InitializeComponent();
            students.Add("Alan Turing", new List<int> { 97, 91, 83 });
            students.Add("Grace Hopper", new List<int> { 99, 93, 97 });
            students.Add("Ada Lovelace", new List<int> { 100, 100, 100 });
        }

        //method for UpdateStudentListBox();
        private void UpdateStudentListBox()
        {

            foreach (var student in students)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.Key.ToString());
                sb.Append("|"); //add the pipe 
                for (int i = 0; i < student.Value.Count; i++)
                {
                    sb.Append(student.Value[i]);
                    if (i != student.Value.Count - 1)
                    {
                        sb.Append("|"); //add the pipe 
                    }
                }
                ListBox.Items.Add(sb); //add the student and the score to the listbox
                ListBox.SetSelected(0, true);
                UpdateText(); // display student avg
            }
        }
        private void UpdateText() //update calculated text
        {
            try
            {
                lblScoretotal.Text = students.Values.ElementAt(ListBox.SelectedIndex).Sum().ToString();
                lblScoreCount.Text = students.Values.ElementAt(ListBox.SelectedIndex).Count.ToString();
                lblAverage.Text = Math.Round(students.Values.ElementAt(ListBox.SelectedIndex).Average()).ToString();
            }
            catch (Exception)
            {
                lblScoretotal.Text = "";
                lblScoreCount.Text = "";
                lblAverage.Text = "";
            }
        }
        private void ssbtnUpdate_Click(object sender, EventArgs e)
        {
            Form updateScores = new UpdateStudentScores();
            selected = ListBox.SelectedIndex;
            if (ListBox.Items.Count > 0)
            {
                updateScores.ShowDialog(); //open the form to update student details
            }
            string selectedStudent = students.Keys.ElementAt(ListBox.SelectedIndex);
        }

        private void ssbtnDelete_Click(object sender, EventArgs e)
        {
            students.Remove(students.Keys.ElementAt(ListBox.SelectedIndex));
            ListBox.Items.Clear();
            UpdateStudentListBox();
            if (students.Count == 0)
            {
                lblScoretotal.Text = "";
                lblScoreCount.Text = "";
                lblAverage.Text = "";
            }
        }

        private void ssbtnAddNew_Click_1(object sender, EventArgs e)
        {
            Form addNewStudent = new AddNewStudent(); //create an object of the student form
            addNewStudent.ShowDialog();
            ListBox.Items.Clear();
            UpdateStudentListBox(); //add the student to the list
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
