using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsPerCourse
    {
        
        protected internal static List<string> stream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
        protected internal static List<string> type = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };


        protected internal void ListOfAssignmentsPerCourse()
        {
            PrintList(MakeListAssignmentPerCourse(SelectFromListOfSrings(stream), SelectFromListOfSrings(type)));
        }

        protected internal List<Assignment> MakeListAssignmentPerCourse(string stream, string type)
        {

            List<Assignment> assignmentPerCourse = List.assignments.FindAll(assignment => assignment.AssignmentStream == stream && assignment.AssignmentType == type);

            return (assignmentPerCourse);
        }

        protected internal static void PrintList(List<Assignment> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        protected internal string SelectFromListOfSrings(List<string> element)
        {
            string result = "";
            int counter = 1;
            foreach (var item in element)
            {
                Console.WriteLine($"{counter++}.{item}"); //-->presents the lists of choice
            }
            int choice = Int32.Parse(Console.ReadLine());
            while (choice > element.Count || choice <= 0) //--> checks for correct input
            {
                Console.WriteLine("Enter Correct Selection: ");
                choice = Int32.Parse(Console.ReadLine());
            }
            result = element.ElementAt(choice - 1);
            return (result);
        }

    }
}
