namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class XDivY : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (int) firstValue / (int) secondValue;
        }
    }
}