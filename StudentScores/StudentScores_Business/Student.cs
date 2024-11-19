using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores_Business
{
    public class Student : Person
    {

        public string FirstName { get; }
        public string LastName { get; }
        public List<int> Scores { get; }

        // Constructor with parameters for first name, last name, and scores
        public Student(string name, List<int> scores) : base(name)
        {
            FirstName = name;
            Scores = scores;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}"; // Adjust as needed
        }
        // method to add scores
        public void AddScore(int score)
        {
            // add score to list
            Scores.Add(score);
        }

        // calculate total score
        public int ScoreTotal()
        {
            int total = 0;
            foreach (int score in Scores)
            {
                total += score;
            }
            return total;
        }

        // calculate average
        public double ScoreAverage()
        {
            if (Scores.Count == 0)
            {
                return 0; // return zero if no score
            }

            // use scoretotal method
            int total = ScoreTotal();

            // finally i'll calculate the average
            return (double)total / Scores.Count;
        }
    }
}
