using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Application will prompt user to input a distance
    /// measured in miles or feet and will calculate and the output 
    /// equivalent in feet or metres
    /// </summary>
   
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const int METRES_IN_MILES = 1609.34:

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// Method will input distance in miles
        /// calculate this distance in feet and output
        /// the distance in feet
        /// </summary>  

        public void MilesToFeet()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles to Feet");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            Console.WriteLine("Converting Feet to Miles");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles to Metres");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        
        /// <summary>
        /// Prompts user to enter distance in miles
        /// Input miles as double number
        /// </summary> 
        private void InputMiles()
        {
            Console.Write("Enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        
        /// <summary>
        /// 
        /// </summary> 
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary> 
        private void CalculateMiles()
        {
            feet = miles / FEET_IN_MILES;
        }
        
        /// <summary>
        /// 
        /// </summary> 
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");
        }

        /// <summary>
        /// 
        /// </summary> 
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles");
        }

        /// <summary>
        /// 
        /// </summary> 
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres");
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine(" ===============================================");
            Console.WriteLine("              Distance Converter                ");
            Console.WriteLine("               By Rahaat Hussain                ");
            Console.WriteLine(" ===============================================");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
