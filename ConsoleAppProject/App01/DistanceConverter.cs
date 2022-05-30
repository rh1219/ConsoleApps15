using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
   
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary> 
        public void Run()
        {
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
        
        /// <summary>
        /// 
        /// </summary> 
        private void CalculateFeet()
        {
            feet = miles * 5280
        }
        
        /// <summary>
        /// 
        /// </summary> 
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");
        }
    }
}
