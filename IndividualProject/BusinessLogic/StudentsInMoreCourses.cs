using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class StudentsInMoreCourses
    {
        public static List<Student> studentsInMoreCourses = new List<Student>();

        protected internal static void ReturnStudentsInMoreCourses()
        {
            
            for (int i = 0; i < List.students.Count; i++)
            {
                for (int j = i +1 ; j < List.students.Count; j++)
                {
                    if (List.students[i].FirstName == List.students[j].FirstName && List.students[i].LastName == List.students[j].LastName)
                    {
                        studentsInMoreCourses.Add(List.students[i]);
                        studentsInMoreCourses.Add(List.students[j]);
                    }
                }
            }

            foreach (var students in studentsInMoreCourses)
            {
                Console.WriteLine(students);
            }            
        }        
    }
}
