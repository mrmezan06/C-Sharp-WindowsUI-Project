using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_App
{
    public class Chicken:Animal
    {
        public void LayEgg() {
            Console.WriteLine(name + " has laid en egg.");
        }
        public Chicken(string newName) : base(newName) { }
    }
}
