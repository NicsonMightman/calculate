namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class Remaine : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}