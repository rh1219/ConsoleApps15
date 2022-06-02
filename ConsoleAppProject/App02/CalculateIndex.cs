using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// 
    /// 
    /// 
    ///
    /// 

    public class BMI
    {
    //Constant for pounds in a stone and inches in a foot
    public const int POUNDS_IN_STONES = 14;
    public const int INCHES_IN_FEET = 12;

    //Constants for upper limit values 
    //in the WHO weight table
    public const double UNDERWEIGHT = 18.5;
    public const double NORMAL = 24.9;
    public const double OVERWEIGHT = 29.9;
    public const double OBESE_CLASS_I = 34.9;
    public const double OBESE_CLASS_II = 39.9;
    public const double OBESE_CLASS_III = 40.0;

    //Metric and imperial variables
    private double pound;
    private int inch;
    private double kilogram;
    private double metre;

    //BMI index
    public double indexBMI;

    private UnitSystems SelectUnits()
    {
        Console.WriteLine("1. Imperial")
        Console.WriteLine("2. Metric")

        Console.Write("\n Choose unit type: ");
        string typeChoice = Console.ReadLine();

        if (typeChoice == "1") return UnitSystems.Imperial;
        else return UnitSystems.metric
    }

    public void CalculateIndex()
    { 
        Console.WriteLine(" =================");
        Console.WriteLine("BMI Calculator");
        Console.WriteLine(" =================");

        UnitSystems unitSystem = SelectUnits();

        if (unitSystem == UnitSystems.Imperial)
        {
            InputImperialDetails();
            CalculateImperialBMI();
        }
        else
        {
            InputMetricDetails();
            CalculateMetricBMI();
        }

        OutputHealthMessage();
        OutputBameMessage();
    }


