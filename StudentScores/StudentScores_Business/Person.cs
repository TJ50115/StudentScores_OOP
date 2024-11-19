using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores_Business
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // override tostring method  
        public override string ToString()
        {
            string[] names = Name.Split(' ');
            string firstName = names[0];
            string lastName = string.Join(" ", names.Skip(1));

            return $"{firstName} {lastName}";
        }
    }
}

