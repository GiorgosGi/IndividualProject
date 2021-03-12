using IndividualProject.Models;
using Microsoft.SqlServer.Server;
using Microsoft.Win32.SafeHandles;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        //-----------Trainer-------------------
        public Trainer GetTrainerDetails(List<string> subjects = null) 
        {
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" }; 
            Trainer trainer = new Trainer();
            trainer.FirstName   = AskDetail("Give me your first name");
            trainer.LastName    = AskDetail("Give me your last name");
            trainer.Subject     = AskDetail("Select the subject you teach",subjects);
            //Console.Clear();
            return (trainer);
        }
        
        private string AskDetail(string message, List<string> subjects = null)  
        {                                                                      
            string result = "";
            Console.Write(message + ": ");
            if (subjects != null)
            {
                result = SelectFromListOfStrings( subjects);
            }
            else
            {
                result = Console.ReadLine();
            }
            
            return (result);
        }

        private string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}");
            }

            int choice = 0;
            do
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out choice))
                {
                    if (choice <= elements.Count && choice > 0)
                    {
                        result = elements.ElementAt(choice - 1);
                        break;
                    }                    
                }
                else
                    Console.Write("Enter Correct selection: ");
            } while (true);

            return (result);
        }

        protected internal static void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }


        //-------------Course--------------------------

        public Course GetCourseDetails(List<string> stream = null, List<string> type = null)
        {
            if (stream == null) stream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            if (type == null) type = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };
            Course course = new Course();
            course.TitleNumber = Convert.ToInt32(AskDetail("Give Coding Bootcamp No"));  //--> needs check for wrong input
            course.Stream = AskDetail("Select Stream", stream);
            course.Type = AskDetail("Select Type", type);
            course.Start_Date = Convert.ToDateTime(AskDetail("Give Start Date")); 
            course.End_Date = Convert.ToDateTime(AskDetail("Give End Date"));
            Console.Clear();
            return (course);
        }


        protected internal static void PrintCoursesList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }
        }

        //---------------Student--------------------------

        public Student GetStudentDetails(List<string> studentsStream = null, List<string> streamType = null)
        {
            if (studentsStream == null) studentsStream = new List<string>() { "C#", "Java", "JavaScript", "PHP", "Python" };
            if (streamType == null) streamType = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };
            Student student = new Student();
            student.FirstName = AskDetail("Student first name");
            student.LastName = AskDetail("Student last name");
            student.DateOfBirth = Convert.ToDateTime(AskDetail("Student date of birth"));
            student.StudentStream = AskDetail("Select student Stream", studentsStream);
            student.StreamType = AskDetail("Select student Stream Type", streamType);            
            student.TuitionFees = Convert.ToDouble(AskDetail("Student tuituion fees"));
            Console.Clear();
            return (student);
        }

        protected internal static void PrintStudentsList(List<Student> students) 
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }


        //-------------Assignment--------------------------

        
        public Assignment GetAssignmentDetails(List<string> assignmentStream = null, List<string> assignmentType = null)
        {
            if (assignmentStream == null) assignmentStream = new List<string>() { "Java", "C#", "JavaScript", "PHP", "Python" };
            if (assignmentType == null) assignmentType = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };
            Assignment assignment = new Assignment();
            assignment.AssignmentStream = AskDetail("Select assigment Stream", assignmentStream);
            assignment.AssignmentType = AskDetail("Select assigment Stream Type", assignmentType);
            assignment.Title = AskDetail("Give me assigment title");            
            assignment.Description = AskDetail("Give me description");
            assignment.SubDateTime = Convert.ToDateTime(AskDetail("Give submission date & time"));
            assignment.OralMark = float.Parse(AskDetail("Give oral mark"));   //--> needs check for wrong input
            assignment.TotalMark = float.Parse(AskDetail("Give total mark"));
            Console.Clear();
            return (assignment);
        }

        protected internal static void PrintAssignmentsList(List<Assignment> assignments) 
        {
            foreach (var item in assignments)
            {
                Console.WriteLine(item);
            }
        }

    }
}
