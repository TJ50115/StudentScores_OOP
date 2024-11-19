using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores_Business
{
    public class StudentList : IEnumerable<Student>
    {
        public List<Student> students;
        public List <Student> Students => students;

        //implementing interface IEnumerable.GetEnumerator
        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // listchange event notifier
        public event EventHandler? ListChanged;

        // studentlist constructor
        public StudentList()
        {
            students = new List<Student>();
        }

        // get or set our students
        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }

        // method to add a student to the list
        public void AddStudent(Student student)
        {
            students.Add(student);
            // if student added raise the listchanged event
            OnListChanged();
        }

        // method to remove a student
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            // if a student is removed raise the listchanged events
            OnListChanged();
        }

        // method to count # of students
        public int Count()
        {
            return students.Count;
        }

        // invoke listchanged event
        public void OnListChanged()
        {
            ListChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
