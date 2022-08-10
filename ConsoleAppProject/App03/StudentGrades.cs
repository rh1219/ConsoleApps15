using System;
using System.Linq;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This program allows a user to perform tasks such as Inputting and Outputting Marks and creating Grade Profiles and Statistics.
    /// </summary>
    /// <author>
    /// Rahaat Hussain Version 1.0
    /// </author>

    public class StudentGrades
    {

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;


        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Marks");
            Console.WriteLine("3. Output Stats");
            Console.WriteLine("4. Output Grade Profile");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Enter Option: ");
            string selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    Console.WriteLine("Input Marks selected");
                    InputMarks();
                    break;
                case "2":
                    Console.WriteLine("Output Marks selected");
                    OutputMarks();
                    break;
                case "3":
                    Console.WriteLine("Output Stats selected");
                    OutputStats();
                    break;
                case "4":
                    Console.WriteLine("Output Grade Profile selected");
                    OutputGradeProfile();
                    break;
                case "5":
                    Console.WriteLine("Quit selected");
                    Program.Menu();
                    break;
                default:
                    Console.WriteLine("Invalid Input, try again.");
                    break;
            }
        }
        public StudentGrades()
        {
            Students = new[]
            {
                "Rahaat", "Amber", "Matt", "Franklin", "Karen", "Ben", "Wilson", "Dexter", "Eevee", "Tina"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Allows input of individual marks for each Student
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            int index = 0; 

            foreach (var student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($" Enter Mark for {student}: ", 0, 100);
                Marks[index] = mark; 
                index++; 
            }
            Run(); 
        }

        /// <summary>
        /// Outputs a list of marks for all Students
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            int index = 0; 

            foreach (var student in Students)
            {
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($"{student}'s Results\n Mark: " + Marks[index] + " | Grade: " + grade);
                index++;
            }
            Run();
        }

        /// <summary>
        /// Mark to Grade conversion
        /// </summary>
        public static Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }

            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }

            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }

            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }

            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return Grades.F;
        }

        /// <summary>
        /// Calculates the Mean, Minimum, and Maximum Marks
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            foreach (int mark in Marks) 
            {
                total += mark;
            }
            Mean = total / Marks.Length;
            Minimum = Marks.Min(); 
            Maximum = Marks.Max(); 
        }

        /// <summary>
        /// Outputs the Mean, Minimum, and Maximum Mark calculated
        /// </summary>
        public void OutputStats()
        {
            CalculateStats();
            ConsoleHelper.OutputHeading("Student Grades");
            Console.WriteLine("Mean : " + Mean);
            Console.WriteLine("Minimum : " + Minimum);
            Console.WriteLine("Maximum : " + Maximum);
            Run();
        }

        /// <summary>
        /// Calculates the Grade Profile for students
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++) 
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// Outputs the Grade Profile
        /// </summary>
        public void OutputGradeProfile()
        {
            CalculateGradeProfile();
            ConsoleHelper.OutputHeading("Student Grades");

            Grades grade = Grades.F;

            foreach (int count in GradeProfile) 
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} Profile\n Percentage: {percentage}% | Student Count: {count}");
                grade++;
            }
            Run();
        }
    }
}



