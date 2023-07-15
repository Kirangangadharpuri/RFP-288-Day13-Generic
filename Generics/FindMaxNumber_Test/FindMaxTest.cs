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
        [Test]
        public void ReturnFirstValue()
        {
            FindeMaxValue findMaxValue = new FindeMaxValue();

            int Result = findMaxValue.MaximumIntegerNumber(56, 37, 12);
            Assert.AreEqual(Result, 56);
        }
    }
}
