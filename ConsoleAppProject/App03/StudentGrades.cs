using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        //Constants for grade boundaries
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

        public int MinMark { get; set; }

        public int MaxMark { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Rahaat", "Amber", "Matt",
                "Franklin", "Karen", "Dexter",
                "Wilson", "Ray", "Ben",
                "Frank"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Convert a mark into a grade using grade boundaries
        /// </summary>
        public Grades ConvertToGrade(int mark)

        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }

            if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }

            if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }

            if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else return Grades.A;
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            OutputHeading();

            ConsoleHelper.OutputTitle(" Entering Student Marks ");

            for (int index = 0; index < Students.Length; index++)
            {
                Marks[index] = (int)ConsoleHelper.InputNumber($" Enter a percentage mark" +
                $" for {Students[index]}: ");
            }
        }

        /// <summary>
        /// Heading displayed at the start of the program
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("       Student Marks      ");
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("     By Rahaat Hussain    ");
            Console.WriteLine("\n--------------------------");
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Student Marks");

            for (int index = 0; index < Students.Length; index++)
            {
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($" Mark" +
                    $" for {Students[index]} = {Marks[index]} grade {grade}");
            }
        }

        /// <summary>
        /// Calculate mean, minimum and maximum
        /// mark for all students
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            MinMark = HighestMark;
            MaxMark = LowestMark;

            foreach (int mark in Marks)
            {
                if (mark > MaxMark) MaxMark = mark;
                if (mark < MinMark) MinMark = mark;
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// List all the students and display their
        /// names and current grade
        /// </summary>
        public void OutputGrades()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($"{Students[i]} mark = {Marks[i]} Grade = {grade}");
            }
        }

        /// <summary>
        /// Percentage of students obtaining each grade
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
        /// Outputs grades for students
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}  {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Displays menu of options
        /// </summary>
        public void OutputMenu()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Output stats (mean, maximum and minimum)
        /// </summary>
        public void OutputStats()
        {
            throw new NotImplementedException();
        }
    }
}
