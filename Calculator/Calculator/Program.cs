using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Number:\n");
            Double n1, n2;
            Console.WriteLine("Enter first number :\n");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number :\n");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What do you want?\nPress 1: Summation\nPress 2: Subtraction\nPress 3: Multiplication\nPress 4: Division\nPress 5: Mode\n");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) {
                Double res = n1+n2;
                Console.WriteLine("The Summation of "+n1+" and "+n2+" is "+ res);
            }
            else if (choice == 2)
            {
                Double res = n1 - n2;
                Console.WriteLine("The Subtraction of " + n1 + " and " + n2 + " is " + res);
            }
            else if (choice == 3)
            {
                Double res = n1 * n2;
                Console.WriteLine("The Multiplication of " + n1 + " and " + n2 + " is " + res);
            }
            else if (choice == 4)
            {
                int n11 = Convert.ToInt32(n1);
                int n22 = Convert.ToInt32(n2);
                Double res = n11 / n22;
                Double mode = n11 % n22;
                Console.WriteLine("The Division of " + n1 + " and " + n2 + " result is " + res+" Remainder is "+mode);
            }
            else if (choice == 1)
            {
                Double res = n1 % n2;
                Console.WriteLine("The Mode of " + n1 + " and " + n2 + " is " + res);
            }
            else
            {
                Console.WriteLine("Option is invalid!Try Again Later.");
            }
            Console.ReadKey();
        }
    }
}
