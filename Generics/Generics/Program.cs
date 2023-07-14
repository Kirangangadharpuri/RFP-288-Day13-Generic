using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.FindeMaxValue;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the FirstValue:");
            var firstVal = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            var secondVal = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            var ThirdVal = Console.ReadLine();

            var Value = FindMaxUsingGenerics<IComparable>.MaximumNum(firstVal, secondVal, ThirdVal);
            Console.WriteLine("{0} is greater", Value);
            Console.WriteLine("**************************************");

        }
    }
}
