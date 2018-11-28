using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumWords;


namespace NumbersTest
{
    [TestFixture]
  public  class NumberTestClass
    {
        [Test]
        public void ThreeDigitNumberTest()
        {
            int x = 897;
           string actualResult= Program.NumWords(x);
           Assert.AreEqual("eight hundred ninty-seven", actualResult);
           
        }
        [Test]
        public void TwoDigitNumberTest()
        {
            int x = 56;
            string actualResult = Program.NumWords(x);
            Assert.AreEqual("fifty-six", actualResult);

        }
        [Test]
        public void SingleDigitNumberTest()
        {
            int x = 2;
            string actualResult = Program.NumWords(x);
            Assert.AreEqual("two", actualResult);

        }
       
    }
}
