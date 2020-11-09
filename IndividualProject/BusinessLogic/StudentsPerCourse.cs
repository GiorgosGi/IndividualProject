using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCourse : Student
    {
        public StudentsPerCourse()
        {
            Console.WriteLine($"The students in {StudentsPerClass()}");
        }

        public Course StudentsPerClass(List<Student> students = null)
        {
            Course course1 = new Course();
            course1.Stream = "C#";
            return (course1);
        }
    }
}
