using System.Collections.Generic;

namespace Core
{
    public class AllEvenNumbers: ISequence<int>
    {
        /// <summary>
        /// Public method for generating all even numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A list of integers</returns>
        public List<int> CreateSequence(int number)
        {
            List<int> allEvenNumbers = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                    allEvenNumbers.Add(i);
            }
            return allEvenNumbers;
        }
    }
}
