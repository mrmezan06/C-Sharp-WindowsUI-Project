using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_two_value_in_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index;
            int maxValue = MaxValue(arr, out index);
            Console.WriteLine("Max value : " + maxValue);
            Console.WriteLine("Max index : " + (index+1));
            Console.ReadKey();
        }
        static int MaxValue(int[] arr, out int index) {
            index = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++) {
                if (max < arr[i]) {
                    max = arr[i];
                    index = i;
                }
            }

                return max;

        }
    }
}
