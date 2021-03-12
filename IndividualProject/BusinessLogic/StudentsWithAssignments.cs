using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsWithAssignments 
    {
        protected internal static List<string> stream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
        protected internal static List<string> type = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };

        protected internal void ListOfStudentsWithAssignmemts()
        {
            StudentsPerCourse students = new StudentsPerCourse();
            AssignmentsPerCourse assignments = new AssignmentsPerCourse();

            string streamThis = students.SelectFromListOfSrings(stream);
            string typeThis = students.SelectFromListOfSrings(type);
            
            List<Student> studentsThis = students.MakeListStudentPerCourse(streamThis, typeThis);
            List<Assignment> assignmentsThis = assignments.MakeListAssignmentPerCourse(streamThis, typeThis);

            foreach (var student in studentsThis)
            {
                foreach (var assignment in assignmentsThis)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} has to deliver " +
                                      $"{assignment.Title} {assignment.Description} at " +
                                      $"{assignment.SubDateTime}");
                }
            }

        }

        
    }
}
