using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called
    /// when the application is started 
    /// Used to start App01 to App05
    /// This Project has been modified by:
    /// Rahaat Hussain 
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();
        private static StudentGrades marks = new StudentGrades();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine();

            Console.WriteLine("\n Options\n");
            Console.WriteLine("========================");
            Console.WriteLine("\n 1. Distance Converter\n");
            Console.WriteLine("\n 2. BMI Calculator\n");
            Console.WriteLine("\n 3. Student Grades\n");


            Console.WriteLine("Enter your choice: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                converter.ConvertDistance();
            }
            else if (option == "2")
            {
                calculator.CalculateIndex();
            }
            else if (option == "3")
            {
                marks.InputMarks();
            }
        }
    }
}
