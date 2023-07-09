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
            string num_one = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string num_two = Console.ReadLine();

            Console.WriteLine("Please enter the third number");
            string num_three = Console.ReadLine();

            string val = FindeMaxValue.MaximumStringNumber(num_one, num_two, num_three);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}
