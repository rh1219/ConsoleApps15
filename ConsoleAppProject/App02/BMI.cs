using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
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

        public void CalculateIndex()
        {
            //Heading for app
            Console.WriteLine(" =================");
            Console.WriteLine("BMI Calculator");
            Console.WriteLine(" =================");

            //SelectUnit method used to make unit choice
            UnitSystems unitSystem = SelectUnits();

            //Decision made for imperial or metric
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

            //Output the required messages for BMI calculations
            //Also outputs BAME message
            OutputHealthMessage();
            OutputBameMessage();
        }

        private UnitSystems SelectUnits()
        {
            Console.WriteLine("1. Imperial");
            Console.WriteLine("2. Metric");


        Console.Write("\n Choose unit type: ");
            string typeChoice = Console.ReadLine();

            if (typeChoice == "1") return UnitSystems.Imperial;
            else return UnitSystems.Metric;
        }

        private double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
        }

        private void InputImperialDetails()
        {
            Console.Write("Input your weight (stones & pounds) \n");
            double stones = InputNumber("Input weight in stones: ");
            pound = InputNumber("Input weight in pounds: ");
            pound += stones * POUNDS_IN_STONES;

            Console.WriteLine("Input your height (feet & inches) \n");
            double feet = InputNumber("Input height in feet: ");
            inch = (int)InputNumber("Input height in inches: ");
            inch += (int)feet * INCHES_IN_FEET;
        }

        private void InputMetricDetails()
        {
            metre = InputNumber("Input height in metres: ");
            kilogram = InputNumber("Input weight in kilograms: ");
        }

        public void CalculateMetricBMI()
        {
            indexBMI = kilogram / (metre * metre);
        }

        public void CalculateImperialBMI()
        {
            indexBMI = pound * 703 / (inch * inch);
        }

        public void OutputHealthMessage()
        {
            if (indexBMI < UNDERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as underweight.");
            }
            else if (indexBMI <= NORMAL)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as normal weight.");
            }
            else if (indexBMI <= OVERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as overweight.");
            }
            else if (indexBMI <= OBESE_CLASS_I)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class 1.");
            }
            else if (indexBMI <= OBESE_CLASS_II)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class 2.");
            }
            else if (indexBMI <= OBESE_CLASS_III)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class 3.");
            }
        }

        public void OutputBameMessage()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("There are higher risks for: ");
            Console.WriteLine("Black, Asian or other minority people");
            Console.WriteLine("==================================================");
            Console.WriteLine("The risk of excess weight for some BAME groups");
            Console.WriteLine("occur at a lower BMI than for the white population");
        }
    }
}
