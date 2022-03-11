using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Constructor to initialise fromUnit to Miles and 
    /// toUnit to Feet using enumeration
    /// </summary>
    /// Rahaat Hussain

    public class DistanceConverter
    {
        
        // Distance conversion constants
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        // From and to distance variables
        private double fromDistance;
        private double toDistance;

        // fromUnit and toUnit set as enumeration types
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;


        /// <summary>
        /// COnstructor
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
        }



    /// <summary>
    /// This method will input distance chosen by user, 
    /// calculates the distance in another unit then outputs 
    /// the conversion
    /// </summary>
    public void ConvertDistance()
    {
        OutputHeading();

        fromUnit = SelectUnit(" Select the from distance unit > ");
        toUnit = SelectUnit(" Select the to distance unit > ");

        Console.WriteLine($"\n Converting (fromUnit) to (toUnit) > ");

        CalculateDistance();

        OutputDistance();
    }

    /// <summary>
    /// Heading displayed at the start of the program
    /// </summary>
    private void OutputHeading()
    {
        Console.WriteLine();
        Console.WriteLine("\n------------------------");
        Console.WriteLine("    Distance Converter    ");
        Console.WriteLine("\n------------------------");
        Console.WriteLine("    By Rahaat Hussain    ");
        Console.WriteLine("\n------------------------");
    }






}
