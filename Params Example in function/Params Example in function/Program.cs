using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Example_in_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Summation(2, 4, 6, 8, 10);
            Console.WriteLine("The summation is " + sum);
            Console.ReadKey();
        }
        static int Summation(params int[] vals) {
            int sum = 0;
            foreach (int val in vals) {
                sum += val;
            }
            return sum;
        }
    }
}
