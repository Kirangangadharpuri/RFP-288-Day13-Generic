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
            int[] valuesInt = { 1, 2, 3, 4, 5 };
            double[] valuesDouble = { 10.4, 6.7, 8.2, 9.5, 7.3 };
            string[] valuesString = { "ram", "shiv", "radha", "mohan" };

            FindMax<int> obj = new FindMax<int>(valuesInt);
            obj.PrintMax();
            Console.WriteLine("**********************************************");


            FindMax<double> obj_one= new FindMax<double>(valuesDouble);
            obj_one.PrintMax();
            Console.WriteLine("**********************************************");

            FindMax<string> obj_two = new FindMax<string>(valuesString);
            string MaxString = obj_two.TestMaximum();
            obj_two.PrintMax();

        }
    }
}
