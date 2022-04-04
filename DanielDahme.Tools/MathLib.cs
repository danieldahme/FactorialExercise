namespace DanielDahme.Tools
{
    /// <summary>
    /// Class library for the calculation of basic and double factorials.
    /// </summary>
    public static class MathLib
    {

        /// <summary>
        /// Enum for selecting the type of calculation, either bei iteration or by recursion.
        /// </summary>
        public enum Calculation
        {
            ///<summary>Calculation by using iteration</summary>
            Iteration,
            ///<summary>Calculation by using recursion</summary>
            Recursion
        }

        /// <summary>
        /// Enum for selecting the calculation function, the basic or the double factorial.
        /// Private for internal use.
        /// </summary>
        private enum Operation
        {
            ///<summary>Basic factorial function</summary>
            Single = 1,
            ///<summary>Double factorial function</summary>
            Double = 2
        }

        /// <summary>
        /// Calculation of a basic factorial given a operand, done either by iteration or by recursion.
        /// </summary>
        /// <param name="operand">The non-negative value to be used for the calculation.</param>
        /// <param name="mode">Enum for selecting the calculation function, the basic or the double factorial.</param>
        /// <returns>The basic (single) factorial of given operand.</returns>
        public static uint Factorial(uint operand, Calculation mode = Calculation.Iteration)
        {

            // 
            return mode == Calculation.Iteration
                ? FactorialIteration(operand, Operation.Single)
                : FactorialRecursion(operand, Operation.Single);

        }

        /// <summary>
        /// Calculation of a double factorial, done either by iteration or by recursion.
        /// </summary>
        /// <param name="operand">The non-negative value to be used for the calculation.</param>
        /// <param name="mode">Enum for selecting the calculation function, the basic or the double factorial.</param>
        /// <returns>The double factorial of given operand.</returns>
        public static uint DoubleFactorial(uint operand, Calculation mode = Calculation.Iteration)
        {

            return mode == Calculation.Iteration
                ? FactorialIteration(operand, Operation.Double)
                : FactorialRecursion(operand, Operation.Double);

        }

        /// <summary>
        /// Factorial calculation by iteration, used for both basic and double factorials.
        /// </summary>
        /// <param name="operand">The non-negative value to be used for the calculation.</param>
        /// <param name="operation">Enum for selecting between basic (single) and double factorial</param>
        /// <returns>The basic or double factorial of given operand, as calculated by iteration.</returns>
        /// <exception cref="OverflowException">
        /// When the result becomes too large to be represented by an unsigned integer.
        /// </exception>
        private static uint FactorialIteration(uint operand, Operation operation)
        {

            var step = (uint)operation;
            uint result = 1;
            for (uint i = operand; i >= step; i -= step) result = checked(result * i);
            return result;

        }

        /// <summary>
        /// Factorial calculation by recursion, used for both basic and double factorials.
        /// </summary>
        /// <param name="operand">The non-negative value to be used for the calculation.</param>
        /// <param name="operation">Enum for selecting between basic (single) and double factorial</param>
        /// <returns>The basic or double factorial of given operand, as calculated by recursion.</returns>
        /// <exception cref="OverflowException">
        /// When the result becomes too large to be represented by an unsigned integer.
        /// </exception>
        private static uint FactorialRecursion(uint operand, Operation operation)
        {

            var step = (uint)operation;
            if (operand == 0 || operand == 1) return 1;
            return checked(FactorialRecursion(operand - step, operation) * operand);

        }
    }
}
