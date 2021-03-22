using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IndividualProject.BusinessLogic
{
    class ConsoleMenu
    {
        
        protected internal static void Menu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Input Data.");
            Console.WriteLine("2) Print Input Lists.");
            Console.WriteLine("3) Print Students Per Course.");
            Console.WriteLine("4) Print Trainers Per Course.");
            Console.WriteLine("5) Print Assignments Per Course.");
            Console.WriteLine("6) Print Students with their Assignments.");
            Console.WriteLine("7) Print Students in more then one courses.");
            Console.WriteLine("8) Find Assignments due to given week.");
            Console.WriteLine("9) Exit.");

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Input Data.");
                    InputDataMenu();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Print Input Lists.");
                    PrintInputListsMenu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Print Students Per Course.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Print Trainers Per Course.");
                    PrintTrainersPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Print Assignments Per Course.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Print Students with their Assignments.");
                    PrintStudentsWithAssignments();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '7':
                    Console.Clear();
                    Console.WriteLine("Print Students in more then one courses.");
                    StudentsInMoreCourses.ReturnStudentsInMoreCourses();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '8':
                    Console.Clear();
                    Console.WriteLine("Print Students in more then one courses.");
                    FindAssignmentsDue find = new FindAssignmentsDue();
                    find.FindAssignments();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '9':                    
                    Environment.Exit(0);                    
                    break;
            }

        }
        protected internal static void InputDataMenu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Input list of Students.");
            Console.WriteLine("2) Input list of Course.");
            Console.WriteLine("3) Input list of Trainer.");
            Console.WriteLine("4) Input list of Assignments.");
            Console.WriteLine("5) Continue without inputs.");
            Console.WriteLine("6) Back to Main Menu.");

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Creating a list of Students.");
                    List.InputToStudentList();
                    Console.ReadKey();
                    Console.Clear();
                    InputDataMenu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Creating a list of Courses.");
                    List.InputToCourseList();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Creating a list of Trainers.");
                    List.InputToTrainersList();
                    Console.ReadKey();
                    Console.Clear();
                    InputDataMenu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Creating a list of Assignments.");
                    List.InputToAssignmentList();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                //case '5':
                //    Console.Clear();
                //    Console.WriteLine("Creating a list with sythetic data. ");
                //    SyntheticData.SendSyntheticDataToMemu();
                //    Console.ReadKey();
                //    Console.Clear();
                //    InputDataMenu();
                //    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu.");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintInputListsMenu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Print list Students.");
            Console.WriteLine("2) Print list of Courses.");
            Console.WriteLine("3) Print list of Trainers.");
            Console.WriteLine("4) Print list of Assignments.");
            Console.WriteLine("5) Back to Main Menu.");
            

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Students.");
                    CommandPromptUtils.PrintStudentsList(List.students);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Courses.");
                    CommandPromptUtils.PrintCoursesList(List.courses);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Trainers.");
                    CommandPromptUtils.PrintTrainersList(List.trainers);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Assignments.");
                    CommandPromptUtils.PrintAssignmentsList(List.assignments);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu. ");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;                
            }

        }


        protected internal static void PrintStudentsPerCourse()
        {
            StudentsPerCourse studentsPerCourse = new StudentsPerCourse();
            studentsPerCourse.ListPerStudentPerCourse();     
        }

        protected internal static void PrintTrainersPerCourse()
        {
            TrainersPerCourse trainersPerCourse = new TrainersPerCourse();
            trainersPerCourse.ListOfTrainerPerCourse();

        }

        protected internal static void PrintAssignmentsPerCourse()
        {
            AssignmentsPerCourse assignmentsPerCourse = new AssignmentsPerCourse();
            assignmentsPerCourse.ListOfAssignmentsPerCourse();
            
        }

        protected internal static void PrintStudentsWithAssignments()
        {
            StudentsWithAssignments studentsWithAssignments = new StudentsWithAssignments();
            studentsWithAssignments.ListOfStudentsWithAssignmemts();
        }

    }
    
}
