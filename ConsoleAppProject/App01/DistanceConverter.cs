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

            miles = InputDistance("Enter number of miles: ")

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading();
            Console.WriteLine("Converting Feet to Miles");

            feet = InputDistance("Enter number of feet: ")
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));

        }

        public void MilesToMetres()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles to Metres");

            miles = InputDistance("Enter number of miles: ")
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
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
