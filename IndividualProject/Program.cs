using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();

            Console.WriteLine("How many traines has the school?");
            int tr = int.Parse(Console.ReadLine());
            List<Trainer> trainers = new List<Trainer>();
            for (int i = 1; i <= tr; i++)
            {
                trainers.Add(cpUtils.GetTrainerDetails());
            }
            cpUtils.PrintTrainersList(trainers);
            Console.WriteLine();


            Console.WriteLine("How many courses the school offers?");
            int crs = int.Parse(Console.ReadLine());
            List<Course> courses = new List<Course>();
            for (int i = 1; i <= crs; i++)
            {
                courses.Add(cpUtils.GetCourseDetails());
            }
            cpUtils.PrintCoursesList(courses);
            Console.WriteLine();

            Console.WriteLine("How many students are in the school?");
            int std = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 1; i <= std; i++)
            {
                students.Add(cpUtils.GetStudentDetails());
            }
            cpUtils.PrintStudentsList(students);
            Console.WriteLine();

            Console.WriteLine("How many are the current assignments?");
            int assgn = int.Parse(Console.ReadLine());
            List<Assignment> assignments = new List<Assignment>();
            for (int i = 1; i <= assgn; i++)
            {
                assignments.Add(cpUtils.GetAssignmentDetails());
            }
            cpUtils.PrintAssignmentsList(assignments);
            Console.WriteLine();
        }

       
        // Create appropriate methods in order to ask 
        // from the user data for the four main classes
    }
}
