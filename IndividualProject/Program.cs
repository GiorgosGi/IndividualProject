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
            for (int i = 1; i <= tr; i++)
            {
                List<Trainer> trainers = new List<Trainer>();
                trainers.Add(cpUtils.GetTrainerDetails());
                cpUtils.PrintTrainersList(trainers);
                Console.WriteLine();
            }


            Console.WriteLine("How many courses the school offers?");
            int crs = int.Parse(Console.ReadLine());
            for (int i = 1; i <= crs; i++)
            {
                List<Course> courses = new List<Course>();
                courses.Add(cpUtils.GetCourseDetails());
                cpUtils.PrintCoursesList(courses);
            }

            Console.WriteLine("How many students are in the school?");
            int std = int.Parse(Console.ReadLine());
            for (int i = 1; i <= std; i++)
            {
                List<Student> students = new List<Student>();
                students.Add(cpUtils.GetStudentDetails());
                cpUtils.PrintStudentsList(students);
            }


            Console.WriteLine("How many are the current assignments?");
            int assgn = int.Parse(Console.ReadLine());
            for (int i = 1; i <= assgn; i++)
            {
                List<Assignment> assignments = new List<Assignment>();
                assignments.Add(cpUtils.GetAssignmentDetails());
                cpUtils.PrintAssignmentsList(assignments);
            }

        }

       
        // Create appropriate methods in order to ask 
        // from the user data for the four main classes
    }
}
