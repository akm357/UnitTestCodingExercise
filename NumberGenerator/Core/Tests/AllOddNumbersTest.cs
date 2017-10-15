using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    class AllOddNumbersTest
    {
        [Test]
        public void TestAllOddGeneral()
        {
            int input = 15;
            var result = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 1, 2));

            input *= 2;
            var result2 = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result2, input, 1, 2));

            input *= 3;
            var result3 = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result3, input, 1, 2));
        }

        [Test]
        public void TestOddNegative()
        {
            int input = -15;
            var result = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 1, 2));
        }

        [Test]
        public void TestOddMaxInt()
        {
            int input = int.MaxValue;
            var result = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 1, 2));
        }

        [Test]
        public void TestOddZero()
        {
            int input = 0;
            var result = new AllOddNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 1, 2));
        }

    }
}
