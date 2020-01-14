using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow_checking
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dv;
            short sv=281;
            dv = unchecked((byte)(sv)); //checked: App Crashed and give an error message
            Console.WriteLine("Destination :"+dv+" Source : "+sv);
            Console.ReadKey();
        }
    }
}
