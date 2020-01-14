using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_App
{
    public class Cow:Animal
    {
        public void Milk() {
            Console.WriteLine(name + " has been milked.");
        }
        public Cow(string newName) : base(newName) { }
    }
}
