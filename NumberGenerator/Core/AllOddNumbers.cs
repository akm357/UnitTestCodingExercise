using System.Collections.Generic;

namespace Core
{
    public class AllOddNumbers : ISequence<int>
    {
        /// <summary>
        /// Public method for generating all odd numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A list of integers</returns>
        public List<int> CreateSequence(int number)
        {
            List<int> allOddNumbers = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                if(i%2 != 0)
                    allOddNumbers.Add(i);
            }
            return allOddNumbers;
        }
    }
}
