using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_manipulated
{
    class Teacher : Person
    {
        public string Subject { get; set; }
        public int YearsExperience { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}");
        }
    }
}
