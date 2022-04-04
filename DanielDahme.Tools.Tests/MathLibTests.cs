using NUnit.Framework;

namespace DanielDahme.Tools.Tests
{
    public class MathLibTests
    {

        // Test of basic factorial with special case 0, exspected result 1
        [Test]
        public void Factorial_When0_Returns1(
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = 0;
            uint output = MathLib.Factorial(input, mode);
            Assert.AreEqual(1, output);
        }

        // Test of basic factorial with value 1, exspected result 1
        [Test]
        public void Factorial_When1_Returns1(
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = 1;
            uint output = MathLib.Factorial(input, mode);
            Assert.AreEqual(1, output);
        }

        // Test of basic factorial with more values, comparing with predecessor result
        // Using proof by induction concept 
        [Test]
        public void Factorial_Test_Recursive(
            [Values(2, 3, 4, 5)] int n,
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = (uint)n;
            uint output = MathLib.Factorial(input, mode);
            uint predecessor = MathLib.Factorial(input - 1, mode);

            // Proof by induction
            Assert.AreEqual(predecessor * input, output);
        }

        // Test of double factorial with special case 0, exspected result 1
        [Test]
        public void DoubleFactorial_When0_Returns1(
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = 0;
            uint output = MathLib.DoubleFactorial(input, mode);
            Assert.AreEqual(1, output);
        }

        // Test of double factorial with value 1, exspected result 1
        [Test]
        public void DoubleFactorial_When1_Returns1(
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = 1;
            uint output = MathLib.DoubleFactorial(input, mode);
            Assert.AreEqual(1, output);
        }

        // Test of double factorial with more values, comparing with predecessor result
        // Using proof by induction concept 
        [Test]
        public void DoubleFactorial_Test_Recursive(
            [Values(2, 3, 4, 5)] int n,
            [Values(MathLib.Calculation.Iteration, MathLib.Calculation.Recursion)] MathLib.Calculation mode)
        {
            uint input = (uint)n;
            uint output = MathLib.DoubleFactorial(input, mode);
            uint predecessor = MathLib.DoubleFactorial(input - 2, mode);

            // Proof by induction
            Assert.AreEqual(predecessor * input, output);
        }

    }
}
