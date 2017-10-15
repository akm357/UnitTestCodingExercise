using System.Collections.Generic;

namespace Core
{
    public class AllFibonacciNumbers:ISequence<long>
    {
        List<long> _allFibonacciNumbers = new List<long>();
        /// <summary>
        /// Public method for generating Fibonacci Series
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A list of long</returns>
        public List<long> CreateSequence(int number)
        {
            Fibonacci(0, 1, number);
            return _allFibonacciNumbers;
        }

        /// <summary>
        /// Recursively finds fibonacci series including the number
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="number"></param>
        private void Fibonacci(int first, int second, int number)
        {
            if (first <= number)
            {
                _allFibonacciNumbers.Add((long)first);
                Fibonacci(second, first + second, number);
            }
                
        }

    }
}
