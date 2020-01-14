using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example
{
    class Program
    {
        
        enum Color : byte
        {
            Red = 1,
            Blue = 2,
            Green = 3
        }
        static void Main(string[] args)
        {
            Color myColor = Color.Red;
            Console.WriteLine("Color :"+Convert.ToString(myColor));
            Console.WriteLine("Color Number :" +Convert.ToByte( myColor));
            Console.ReadKey();
        }
    }
}
