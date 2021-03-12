using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class TrainersPerCourse
    {

        protected internal static List<string> subject = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
        

        protected internal void ListOfTrainerPerCourse()
        {
            PrintList(MakeListTrainerPerCourse(SelectFromListOfSrings(subject)));
        }

        protected internal static List<Trainer> MakeListTrainerPerCourse(string subject)
        {

            List<Trainer> trainerPerCourse = List.trainers.FindAll(trainer => trainer.Subject == subject);
            return (trainerPerCourse);
        }

        protected internal static void PrintList(List<Trainer> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private string SelectFromListOfSrings(List<string> element)
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
