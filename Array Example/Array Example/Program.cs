using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int []myArr = new int[5]{2,4,8,6,10};

            for (int i = 0; i < myArr.Length; i++) {
                Console.WriteLine(myArr[i]);
            }

            string []myArr1 = new string[5] { "Mezan", "Akash", "Mosta", "Shompa", "Red Bull" };

            for (int i = 0; i < myArr1.Length; i++)
            {
                Console.WriteLine(myArr1[i]);
            }

            Console.ReadKey();
        }
    }
}
