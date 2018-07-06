namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the minimum value between two points
    /// </summary>
    public class Minimum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument > secondArgument ? secondArgument : firstArgument;
        }
    }
}
