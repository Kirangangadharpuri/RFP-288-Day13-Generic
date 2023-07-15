using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace FindMaxNumber_Test
{
    public class FindMaxTest
    {
        FindeMaxValue findMaxValue = new FindeMaxValue();

        [Test]
        public void ReturnFirstValue()
        {
           // FindeMaxValue findMaxValue = new FindeMaxValue();

            int Result = findMaxValue.MaximumIntegerNumber(56, 37, 12);
            Assert.AreEqual(Result, 56);
        }
        [Test]
        public void ReturnSecondValue()
        {
            // FindeMaxValue findMaxValue = new FindeMaxValue();

            int Result = findMaxValue.MaximumIntegerNumber(56, 87, 12);
            Assert.AreEqual(Result, 87);
        }
        [Test]
        public void ReturnThirdtValue()
        {
            // FindeMaxValue findMaxValue = new FindeMaxValue();

            int Result = findMaxValue.MaximumIntegerNumber(56, 87, 99);
            Assert.AreEqual(Result, 99);
        }
    }
}
