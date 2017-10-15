using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    class AllEvenNumbersTest
    {
        [Test]
        public void TestEvenGeneral()
        {
            int input = 15;
            var result = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 2));

            input *= 2;
            var result2 = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result2, input, 0, 2));

            input *= 3;
            var result3 = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result3, input, 0, 2));
        }

        [Test]
        public void TestEvenNegative()
        {
            int input = -15;
            var result = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 2));
        }

        [Test]
        public void TestEvenMaxInt()
        {
            int input = int.MaxValue;
            var result = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 2));
        }

        [Test]
        public void TestEvenZero()
        {
            int input = 0;
            var result = new AllEvenNumbers().CreateSequence(input);
            Assert.IsTrue(SequenceTestHelper.TestLinearSquence(result, input, 0, 2));
        }

    }
}
