using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10] { 1,2,3,4,5,6,9,8,7,0 };
            int max = find_max(list);
            Console.WriteLine("Max Value : " + max);
            Console.ReadKey();
        }
        static int find_max(int []list) {
            
            int max = list[0];
            int counter = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (max < list[i])
                {
                    counter++;
                    max = list[i];
                }
            }
            Console.WriteLine("Counter for getting max : " + counter);
            return max;
        }
    }
}
