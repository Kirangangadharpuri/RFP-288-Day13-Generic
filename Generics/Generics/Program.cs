using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string num1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string num2 = Console.ReadLine();

            Console.WriteLine("Please enter the third number");
            string num3 = Console.ReadLine();

            string val = FindeMaxValue.MaximumIntegerNumber(num1, num2, num3);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}
