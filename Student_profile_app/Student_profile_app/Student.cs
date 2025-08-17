using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_profile_app
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int Grade;

        public Student(string aName, int aAge, int aGrade)
        {
            Name = aName;
            Age = aAge;
            Grade = aGrade;
        }

        public void DisplayProfile()
        {
            Console.WriteLine($"Student Name: {Name} \nStudent Age: {Age} \nStudent Grade: {Grade}");
        }
    }
}
