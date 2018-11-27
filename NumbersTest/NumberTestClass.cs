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
        public void PositiveTest()
        {
            int x = 897;
           string actualResult= Program.NumWords(x);
           Assert.AreEqual("eight hundred ninty-seven", actualResult);
        }
        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("This is a failure");
        
        }
       //[Test,]
       // public void ExpectedExceptionTest()
       // {
       //     throw new NotSupportedException();

       // }
       // [Test, Ignore]
       // public void NotImplementedException()
       // {
       //     throw new NotImplementedException();
       // }
    }
}
