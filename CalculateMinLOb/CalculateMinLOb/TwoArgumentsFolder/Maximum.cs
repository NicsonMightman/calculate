namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    ///  Function computes the maximum value between two points
    /// </summary>
    public class Maximum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument > secondArgument ? firstArgument : secondArgument;
        }
    }
}