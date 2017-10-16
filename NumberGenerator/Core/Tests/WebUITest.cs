using System;
using NUnit.Framework;
using WatiN.Core;

namespace Core.Tests
{
    [TestFixture, Apartment(System.Threading.ApartmentState.STA)]
    class WebUITest
    {
        const string testUrl = "localhost";

        [Test]
        [STAThread]
        public void TestWebUIButton1()
        {
            var input = 123;
            string[] Headers = {"All Numbers:",
                "All Odd Numbers:",
                "All Even Numbers:",
                "All Extended FizzBuzzs:",
                "All Fibonacci Numbers:" };

            using (var browser = new WatiN.Core.IE(testUrl))
            {
                browser.TextField(Find.ByName("txtNumber")).TypeText(input.ToString());
                browser.Button(Find.ByName("btnGenerate")).Click();
                browser.WaitForComplete();
                //check each div has content
                var hIdx = 0;

                //sequence objects
                var allNumbers = new AllNumbers();
                var allEven = new AllEvenNumbers();
                var allOdd = new AllOddNumbers();
                var allFizz = new AllExtendedFizzBuzzs();
                var allFib = new AllFibonacciNumbers();

                foreach (var div in browser.Divs)
                {
                    var h = Headers[hIdx];
                    //check bold txt
                    if (div.Children().Count != 1)
                        Assert.Fail("Missing or extra bold header of " + h);
                    else
                    {
                        var boldHeader = div.Children()[0];
                        Assert.IsTrue(boldHeader.OuterHtml.Equals(string.Format("<b>{0}</b>", h)));
                    }
                    
                    switch (hIdx)
                    {
                        case 0:
                            var allNumberSequence = string.Join(", ", allNumbers.CreateSequence(input));
                            Assert.IsTrue(div.Text.Equals(string.Format("{0} {1} ", h, allNumberSequence)));
                            break;
                        case 1:
                            var allOddSequence = string.Join(", ", allOdd.CreateSequence(input));
                            Assert.IsTrue(div.Text.Equals(string.Format("{0} {1} ", h, allOddSequence)));
                            break;
                        case 2:
                            var allEvenSequence = string.Join(", ", allEven.CreateSequence(input));
                            Assert.IsTrue(div.Text.Equals(string.Format("{0} {1} ", h, allEvenSequence)));
                            break;
                        case 3:
                            var allFizzSequence = string.Join(", ", allFizz.CreateSequence(input));
                            Assert.IsTrue(div.Text.Equals(string.Format("{0} {1} ", h, allFizzSequence)));
                            break;
                        case 4:
                            var allFibSequence = string.Join(", ", allFib.CreateSequence(input));
                            Assert.IsTrue(div.Text.Equals(string.Format("{0} {1} ", h, allFibSequence)));
                            break;
                    }
                    hIdx++;
                }
            }
        }

        [Test]
        [STAThread]
        public void TestWebUIButtonValidation()
        {
            var input = 0;
            string[] Headers = {"All Numbers:",
                "All Odd Numbers:",
                "All Even Numbers:",
                "All Extended FizzBuzzs:",
                "All Fibonacci Numbers:" };

            using (var browser = new WatiN.Core.IE(testUrl))
            {
                browser.TextField(Find.ByName("txtNumber")).TypeText(input.ToString());
                browser.Button(Find.ByName("btnGenerate")).Click();
                browser.WaitForComplete();

                Assert.IsTrue(string.IsNullOrWhiteSpace(browser.Divs[0].Text));

            }
        }
    }
}
