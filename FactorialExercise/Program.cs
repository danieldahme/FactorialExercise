using System;
using DanielDahme.Tools;

namespace DanielDahme.FactorialExample
{

    // Example console program for using the factorial methods
    class Program
    {
        static void Main()
        {

            // Example value for showing the usage of the factorial methods and output variables
            uint n = 12, factorial, factorialDouble;

            // Factorial methods may throw an overflow exception
            try
            {

                // Example calculation of a basic and a double factorial
                factorial = MathLib.Factorial(n, MathLib.Calculation.Iteration);
                factorialDouble = MathLib.DoubleFactorial(n, MathLib.Calculation.Recursion);

            }
            catch (System.OverflowException e)
            {

                // Handle exception in this example by just showing the error message
                Console.WriteLine("An error occured: {0}", e.Message);
                return;

            }

            // Output
            Console.WriteLine("- Factorial example -");
            Console.WriteLine("The factorial of {0} is {1}.", n, factorial);
            Console.WriteLine("The double factorial of {0} is {1}.", n, factorialDouble);

            Console.ReadLine();

        }
    }
}
