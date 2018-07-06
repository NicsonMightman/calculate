namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the product of two values
    /// </summary>
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}