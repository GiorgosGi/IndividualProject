using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BusinessLogic;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class FindAssignmentsDue
    {
        protected internal DateTime AskForInput()
        {
            Console.Write("Input date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            return (date);

        }

        protected internal void ConvertDayToWeek(DateTime date, out DateTime weekStart, out DateTime weekEnd)
        {
            int dateToInteger = (int)date.DayOfWeek;
            weekStart = DateTime.Parse("01/01/1821");
            weekEnd = DateTime.Parse("02/01/1821");

            switch (dateToInteger)
            {
                case 0:
                    weekStart = date.AddDays(1);
                    weekEnd = date.AddDays(5);
                    break;
                case 1:
                    weekStart = date;
                    weekEnd = date.AddDays(4);
                    break;
                case 2:
                    weekStart = date.AddDays(-1);
                    weekEnd = date.AddDays(3);
                    break;
                case 3:
                    weekStart = date.AddDays(-2);
                    weekEnd = date.AddDays(2);
                    break;
                case 4:
                    weekStart = date.AddDays(-3);
                    weekEnd = date.AddDays(1);
                    break;

                case 5:
                    weekStart = date.AddDays(-4);
                    weekEnd = date;
                    break;
                case 6:
                    weekStart = date.AddDays(2);
                    weekEnd = date.AddDays(6);
                    break;

            }
        }

        protected internal void FindAssignments()
        {
            DateTime date = AskForInput();
            DateTime weekStart;
            DateTime weekEnd;
            ConvertDayToWeek(date, out weekStart, out weekEnd);
            List<Assignment> assignments = new List<Assignment>();
            assignments = List.assignments.FindAll(assignment => assignment.SubDateTime >= weekStart && assignment.SubDateTime <= weekEnd);
            foreach (var assignment in assignments)
            {
                List<Student> students = List.students.FindAll(student => student.StudentStream == assignment.AssignmentStream && student.StreamType == assignment.AssignmentType);
                foreach (var student in students)
                {

                    Console.WriteLine($"{student.FirstName} {student.LastName} has to submit assignment" +
                                      $"{assignment.Title} {assignment.Description} that is due {assignment.SubDateTime}");
                    //$"at week starting {weekStart:dd/MM/yy} ending {weekEnd:dd/MM/yy}\n");
                }                
            }
        }        
    }
}
