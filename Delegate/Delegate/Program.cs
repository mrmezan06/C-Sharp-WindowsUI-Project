using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate double processDelegate(double param1, double param2);
        static double multiply(double param1, double param2) {
            return param1 * param2;
        }
        static double divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            processDelegate process;
            Console.WriteLine("Enter two number seperated by comma(,):");
            string input = Console.ReadLine();
            int comapos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, comapos - 1));
            double param2 = Convert.ToDouble(input.Substring(comapos + 1,input.Length-comapos-1));
            Console.WriteLine("Enter M for Multiply and D for Divide");
            string cmd = Console.ReadLine();
            if (cmd == "M") {
                process = new processDelegate(multiply);
                Console.WriteLine("Multiplication result : " + process(param1, param2));
            }
            else if (cmd == "D")
            {
                process = new processDelegate(divide);
                Console.WriteLine("Dovision result : " + process(param1, param2));
            }
            else {
                Console.WriteLine("Wrong Command entered!");
            }
            Console.ReadKey();
            
        }
    }
}
