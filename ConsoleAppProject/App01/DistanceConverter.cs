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
    /// Constructor initialises fromUnit to Miles and toUnit to Feet
    /// using enumeration
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

        fromUnit = SelectUnit(" Select the from distance unit: ");
        toUnit = SelectUnit(" Select the to distance unit: ");

        Console.WriteLine($"\n Converting {fromUnit} to {toUnit}: ");

        fromDistance = InputDistance($" Enter the number of {fromUnit}: ");

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

    /// <summary>
    /// Display menu of distance units and prompt user to select a unit
    /// and return the unit
    /// </summary>
    private DistanceUnits SelectUnit(string prompt)
    {
        string choice = DisplayChoices(prompt);
        DistanceUnits unit = ExecuteChoice(choice);

        return unit;
    }

    /// <summary>
    /// Displays choices of unit conversions
    /// Displays options from enumeration class
    /// User can make a choice and it is returned
    /// </summary>
    private static string DisplayChoices(string prompt)
    {
        Console.WriteLine();
        Console.WriteLine($"1. {DistanceUnits.Feet}");
        Console.WriteLine($"2. {DistanceUnits.Metres}");
        Console.WriteLine($"3. {DistanceUnits.Miles}");
        Console.WriteLine();

        Console.Write(prompt);
        string choice = Console.ReadLine();

        return choice; 
    }

    /// <summary>
    /// Unit from enumeration is set depending on choice 1, 2 or 3
    /// Error displayed if anything other than 1,2 or 3 is chosen
    /// /// </summary>
    private DistanceUnits ExecuteChoice(string choice)
    {
        DistanceUnits unit;

        switch (choice)
        {
            case "1": unit = DistanceUnits.Feet; break;
            case "2": unit = DistanceUnits.Metres; break;
            case "3": unit = DistanceUnits.Miles; break;

            default: unit = DistanceUnits.NoUnit; break;
        }

        if (unit == DistanceUnits.NoUnit)
        {
            Console.WriteLine("Invalid Choice");
            Console.WriteLine("Must be a number between 1-3");
        }

        Console.WriteLine($"\n You have chosen {unit}");
        return unit;
    }

    /// <summary>
    /// Prompt the user to enter the distance in chosen unit
    /// Input chosen unit as a double number
    /// </summary>
    private double InputDistance(string prompt)
    {
        Console.Write(prompt);
        string value = Console.ReadLine();
        return Convert.ToDouble(value);
    }

    /// <summary>
    /// Calculates conversions based on the distance unit selections of fromUnit and toUnit
    /// There are 6 calculations that can be made
    /// </summary>
    private void CalculateDistance()
    {
        if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
        {
            toDistance = fromDistance * FEET_IN_MILES;
        }
        else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
        {
            toDistance = fromDistance / FEET_IN_MILES;
        }
        else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
        {
            toDistance = fromDistance * METRES_IN_MILES;
        }
        else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
        {
            toDistance = fromDistance / METRES_IN_MILES;
        }
        else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
        {
            toDistance = fromDistance * FEET_IN_METRES;
        }
        else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
        {
            toDistance = fromDistance / FEET_IN_METRES;
        }
    }

    private void OutputDistance()
    {
        Console.WriteLine($"\n {fromDistance}  {fromUnit} " + 
            $" is {toDistance}  {toUnit}!\n");
    }

   }
}
