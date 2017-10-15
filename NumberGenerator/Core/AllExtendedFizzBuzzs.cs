using System.Collections.Generic;

namespace Core
{
    public class AllExtendedFizzBuzzs:ISequence<string>
    {
        /// <summary>
        /// Public method for generating all extended fizzbuzzs
        /// </summary>
        /// <param name="number"></param>
        /// <returns>A list of strings</returns>
        public List<string> CreateSequence(int number)
        {
            List<string> allExtendedFizzBuzzs = new List<string>();
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                    allExtendedFizzBuzzs.Add(i.ToString());
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        allExtendedFizzBuzzs.Add("Z");
                    else
                        allExtendedFizzBuzzs.Add("C");
                }
                else if(i % 5 == 0)
                    allExtendedFizzBuzzs.Add("E");
            }
            return allExtendedFizzBuzzs;
        }
    }
}
