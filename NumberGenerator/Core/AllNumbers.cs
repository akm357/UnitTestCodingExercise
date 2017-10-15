using System.Collections.Generic;

namespace Core
{
    public class AllNumbers:ISequence<int>
    {
        /// <summary>
        /// Public method for generating all numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A list of integers</returns>
        public List<int> CreateSequence(int number)
        {
            List<int> allNumbers = new List<int>();
            for (int i=0;i<=number;i++)
            {
                allNumbers.Add(i);
            }
            return allNumbers;
        }
    }
}
