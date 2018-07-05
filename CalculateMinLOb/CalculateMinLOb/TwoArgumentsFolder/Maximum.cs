namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class Maximum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument) return firstArgument;
            return secondArgument;
        }
    }
}