using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public Trainer GetTrainerDetails(List<string> subjects = null)
        {
            if(subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me your first name");
            trainer.LastName  = AskDetail("Give me your last name");
            trainer.Subject   = AskDetail("Give me the subject you teach", subjects);
            return (trainer);
        }

        public Course GetCourseDetails(List<string> streams = null, List<string> types = null, List<string> titles = null)
        {
            if (titles == null) titles = new List<string>() { "CB10", "CB11", "CB12" };
            if (streams == null) streams = new List<string>() { "C#", "Java" };
            if (types == null) types = new List<string>() { "Full time", "Part time" };
            Course course = new Course();
            course.Title = AskDetail("Name of course", titles);
            course.Stream = AskDetail("Stream of course", streams);
            course.Type = AskDetail("Type of course", types);
            course.Start_Date = AskDetail("Start date of the course");
            course.End_Date = AskDetail("End date of the course");
            return (course);
        }

        public Student GetStudentDetails(List<string> subjects = null)
        {
            Student student = new Student();
            student.FirstName = AskDetail("Give me your first name");
            student.LastName = AskDetail("Give me your last name");
            student.DateOfBirth = AskDetail("Give me your date of birth");
            student.TuitionFees = AskDetail("What are your tuition fees?");
            return (student);
        }

        public Assignment GetAssignmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Assignment title");
            assignment.Description = AskDetail("Assignment description");
            assignment.SubdateTime = AskDetail("Submission date");
            assignment.OralMark = AskDetail("Oral mark");
            assignment.TotalMark = AskDetail("Total mark");
            return (assignment);
        }

        private string AskDetail(string message, List<string> subjects = null)
        {
            string result = "";
            Console.Write(message + ": ");
            if(subjects != null)
            {
                // ask for the subject the trainer teaches
                result = SelectFromListOfStrings(subjects);
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
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != elements.Count)
            {
                Console.WriteLine("Please select from the given list!!!");
                
            }
            else
            {
                result = elements.ElementAt(choice - 1); //elements[choice - 1];
            }
            return (result);
        }

        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintCoursesList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item + "\n");
            }
        }

        public void PrintStudentsList(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item + "\n");
            }
        }

        public void PrintAssignmentsList(List<Assignment> assignments)
        {
            foreach (var item in assignments)
            {
                Console.WriteLine(item + "\n");
            }
        }
    }
}
