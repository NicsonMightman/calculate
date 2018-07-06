namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the Average of two numbers
    /// </summary>
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue)/2;
        }
    }
}