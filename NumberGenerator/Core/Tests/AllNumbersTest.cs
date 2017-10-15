using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    class AllNumbersTest
    {
        [Test]
        public void TestAllGeneral()
        {
            int input = 15;

            var result1 = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result1, input,  0, 1));

            input *= 2;
            var result2 = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result2, input, 0, 1));

            input *= 3;
            var result3 = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result3, input, 0, 1));
        }

        [Test]
        public void TestAllNegative()
        {
            int input = -15;
            var result = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 1));
        }

        [Test]
        public void TestAllMaxInt()
        {
            int input = int.MaxValue / 2;
            var result = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 1));
        }

        [Test]
        public void TestAllZero()
        {
            int input = 0;
            var result = new AllNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 1));
        }

    }
}
