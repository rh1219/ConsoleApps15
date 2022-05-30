using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Application will prompt user to input a distance
    /// measured in one unit and it will calculate and output 
    /// the equivalent in another unit.
    /// </summary>
    /// <author>
    /// Rahaat Hussain v.0.6
    /// </author>
   
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private double fromUnit;
        private double toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// Method will input distance in miles
        /// calculate this distance in feet and output
        /// the distance in feet
        /// </summary>  

        public void MilesToFeet()
        {
            OutputHeading();
            Console.WriteLine($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Enter number of {fromUnit}: ")

            //CalculateFeet();

            OutputDistance(fromDistance, fromUnit, toDistance, toUnit);
        }

        /// <summary>
        /// Prompts user to enter distance in miles
        /// Input miles as double number
        /// </summary> 
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return = Convert.ToDouble(value);
        }
        
        /// <summary>
        /// 
        /// </summary> 
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}");
        }


        /// <summary>
        /// 
        /// </summary> 
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
