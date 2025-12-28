using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_manipulated
{
    class Student : Person
    {
        public string Rank { get; set; }
        public string Location { get; set; }

        public void Secracy()
        {
            Console.WriteLine($"We must verify this before opening the secret!.. ");
        }
    }
}