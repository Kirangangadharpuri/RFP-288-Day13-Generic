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
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int val = FindeMaxValue.MaximumIntegerNumber(num1, num2, num3);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}
