using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "Hey I am Akash Khan";
            char []seperator = {' '};
            string[] mywords;
            mywords = words.Split(seperator);
            foreach (string word in mywords) {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
