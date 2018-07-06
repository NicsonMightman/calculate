namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the difference between two values
    /// </summary>
    public class Minus : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}

