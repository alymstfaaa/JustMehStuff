using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_manipulated
{
    class Person
    {
        public string Name { get; set; }
        public string Pretend { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hey, {Name}");
        }
    }

}

