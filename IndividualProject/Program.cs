using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;
using System.Linq.Expressions;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();

            List<Trainer> trainers         = new List<Trainer>();
            List<Course> courses           = new List<Course>();
            List<Student> students         = new List<Student>();
            List<Assignment> assignments   = new List<Assignment>();



            try
            {
                Console.WriteLine("How many trainers the school has?");
                int tr = int.Parse(Console.ReadLine());
                for (int i = 1; i <= tr; i++)
                {
                    trainers.Add(cpUtils.GetTrainerDetails());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            cpUtils.PrintTrainersList(trainers);
            Console.WriteLine();



            try
            {
                Console.WriteLine("How many courses the school offers?");
                int crs = int.Parse(Console.ReadLine());
                for (int i = 1; i <= crs; i++)
                {
                    courses.Add(cpUtils.GetCourseDetails());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            cpUtils.PrintCoursesList(courses);
            Console.WriteLine();

            try
            {
                Console.WriteLine("How many students are in the school?");
                int std = int.Parse(Console.ReadLine());
                for (int i = 1; i <= std; i++)
                {
                    students.Add(cpUtils.GetStudentDetails());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            cpUtils.PrintStudentsList(students);
            Console.WriteLine();

            try
            {
                Console.WriteLine("How many are the current assignments?");
                int assgn = int.Parse(Console.ReadLine());
                for (int i = 1; i <= assgn; i++)
                {
                    assignments.Add(cpUtils.GetAssignmentDetails());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            cpUtils.PrintAssignmentsList(assignments);
            Console.WriteLine();
        }

       
        
    }
}
