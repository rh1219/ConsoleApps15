namespace ConsoleAppProject.App02
{
    /// <summary>
    /// 
    /// 
    /// 
    ///
    /// 
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
}
