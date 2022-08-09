using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 14/12/2020
    /// Rahaat Hussain
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("BNU CO453 Application Programming 2021-2022");
            Console.WriteLine("By Rahaat Hussain");
            Console.WriteLine();
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Select an app to run:"); 
            Console.WriteLine();
            Console.WriteLine("1. App01: Distance Converter");
            Console.WriteLine("2. App02: BMI Calculator"); 
            Console.WriteLine("3. App03: Student Marks"); 
            Console.WriteLine();
            Console.Write("Enter app number: ");
            string SelectedApp = Console.ReadLine(); 

            switch (SelectedApp) 
            {
                case "1": 
                    Console.WriteLine("Distance Converter");
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    break;
                case "2": 
                    Console.WriteLine("BMI Calculator");
                    BMI calculator = new BMI();
                    calculator.CalculateIndex();
                    break;
                case "3": 
                    Console.WriteLine("Student Marks");
                    StudentGrades grades = new StudentGrades();
                    grades.Run();
                    break;
                default:
                    Console.WriteLine("Invalid Input, try again.");
                    break;
            }
        }
    }
}

