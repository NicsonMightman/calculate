namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the Addition of two numbers
    /// </summary>
    public class Addition : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
