using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Balance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double balance;
            Double irate;
            Double target;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current interest rate in percentage?");
            irate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your target balance?");
            target = Convert.ToDouble(Console.ReadLine());
            irate = irate / 100;
            Console.WriteLine("Interest rate: "+irate);
            int totalyrs = 0;
            do
            {
                balance +=balance * irate;
                ++totalyrs;
            } while (balance < target);
            string res = totalyrs == 1 ? "" : "s";
            Console.WriteLine("In "+totalyrs+" year"+res+" your balance is "+balance);
            Console.ReadKey();
        }
    }
}
