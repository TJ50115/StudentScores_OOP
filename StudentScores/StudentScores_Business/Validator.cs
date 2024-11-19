using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores_Business
{
    public class Validator
    {
        // check if is integer
        public static bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }

        // check if string is present
        public static bool IsPresent(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        // method to check if int is in range
        public static bool IsWithinRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

    }
}
