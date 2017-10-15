using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    class AllFibonacciNumbersTest
    {
        [Test]
        public void TestFibonacciGeneral()
        {
            int input = 15;

            var result1 = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result1, input));

            input *= 2;
            var result2 = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result2, input));

            input *= 3;
            var result3 = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result3, input));
        }

        [Test]
        public void TestFibonacciNegative()
        {
            int input = -15;
            var result = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result, input));
        }

        [Test]
        public void TestFibonacciMaxInt()
        {
            int input = int.MaxValue / 2;
            var result = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result, input));
        }

        [Test]
        public void TestFibonacciZero()
        {
            int input = 0;
            var result = new AllFibonacciNumbers().CreateSequence(input);
            Assert.IsTrue(TestFibonacci(result, input));
        }

        static bool TestFibonacci(List<long> sequence, int input)
        {
            //edge cases
            if (input < 0)
                return (sequence.Count == 0);
            else if (input == 0)
                return (sequence.Count == 1 && sequence[0] == 0);
            else if (sequence.Count < 3)
                return false;

            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i - 2] + sequence[i - 1] != sequence[i] || !isFibonacci(sequence[i]))
                    return false;
            }

            return true;
        }

        // A utility function that returns true if x is perfect square
        static bool isPerfectSquare(long x)
        {
            long s = Convert.ToInt64(Math.Sqrt(x));
            return (s * s == x);
        }

        // Returns true if n is a Fibinacci Number, else false
        static bool isFibonacci(long n)
        {
            // n is Fibinacci if one of 5*n*n + 4 or 5*n*n - 4 or both
            // is a perferct square
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }



    }
}
