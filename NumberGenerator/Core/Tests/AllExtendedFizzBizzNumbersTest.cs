using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    class AllExtendedFizzBizzNumbersTest
    {
        [Test]
        public void TestExtendedFizzBizzGeneral ()
        {
            int input = 15;

            var result1 = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result1, input));

            input *= 2;
            var result2 = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result2, input));

            input *= 3;
            var result3 = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result3, input));
        }

        [Test]
        public void TestExtendedFizzBizzNegative()
        {
            int input = -15;
            var result = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result, input));
        }

        [Test]
        public void TestExtendedFizzBizzMaxInt()
        {
            int input = int.MaxValue;
            var result = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result, input));

        }

        [Test]
        public void TestExtendedFizzBizzZero()
        {
            int input = 0;
            var result = new AllExtendedFizzBuzzs().CreateSequence(input);
            Assert.IsTrue(TestExtendedFizzBizz(result, input));
        }

        public static bool TestExtendedFizzBizz(List<string> sequence, int input)
        {
            //edge cases
            if (input == 0)
                return (sequence.Count == 1 && sequence[0].Equals("Z"));
            else if (input < 0)
                return (sequence.Count == 0);

            for (int i = 0; i < sequence.Count; i++)
            {
                if (int.TryParse(sequence[i], out int value) && i != value)
                    return false;
                else if (sequence[i].Equals("Z") && i % 3 != 0 && i % 5 != 0)
                    return false;
                else if (sequence[i].Equals("E") && i % 5 != 0)
                    return false;
                else if (sequence[i].Equals("C") && i % 3 != 0)
                    return false;
            }

            return true;
        }



    }
}
