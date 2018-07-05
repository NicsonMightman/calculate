namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class Average : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue)/2;
        }
    }
}