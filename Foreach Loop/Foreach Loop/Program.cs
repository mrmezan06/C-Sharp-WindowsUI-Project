using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr1 = new string[5] { "Mezan", "Akash", "Mosta", "Shompa", "Red Bull" };
            foreach (string myarr in myArr1) {
                Console.WriteLine(myarr);
            }
            int[] number = new int[5] {2,3,4,5,6 };
            foreach (int n in number) {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
