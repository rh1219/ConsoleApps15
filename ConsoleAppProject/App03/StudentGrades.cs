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

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public Grades Grades
        {
            get => default;
            set { }
        }

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
        /// Method for inputting marks 
        /// </summary>
        public void InputMarks()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            
        }

        /// <summary>
        /// 
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
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Maximum = mark;
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// 
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
    }
}
