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
            int num_one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num_two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num_three = Convert.ToInt32(Console.ReadLine());

            int val = FindeMaxValue.MaximumIntegerNumber(num_one, num_two, num_three);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}
