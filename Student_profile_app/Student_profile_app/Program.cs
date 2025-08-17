using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_profile_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Cameron", 20, 0);
            Student student2 = new Student("Hailey", 16, 11);
            Student student3 = new Student("Xander", 15, 9);

            student1.DisplayProfile();
            student2.DisplayProfile();
            student3.DisplayProfile();
        }
    }
}
