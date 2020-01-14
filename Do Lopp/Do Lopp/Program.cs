using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Lopp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Current i is " + i);
            } while (i < 10);
            Console.ReadKey();
        }
    }
}
