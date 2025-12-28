using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_manipulated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your badge number: ");
            Console.ReadLine();
            Student student1 = new Student();
            student1.Name = "Ali Mustafa";
            student1.Age = 19;
            student1.Pretend = "Student";
            student1.Rank = "Junior Intelligence Officer";
            student1.Location = "31.4396399, 73.053934 C3Q3+VH3 Faisalabad";

            //Teacher teacher1 = new Teacher();
            //teacher1.Name = "Sir Zeeshan";
            //teacher1.Age = 45;
            //teacher1.Subject = "OOP";
            //teacher1.YearsExperience = 15;

            student1.Greet();  // "Hello, my name is Ali"
            //teacher1.Greet();  // "Hello, my name is Zeeshan"

            student1.Secracy();  // "This is a national secret!"
            //teacher1.Teach();  // "Zeeshan is teaching OOP"

            Console.Write("\nEnter security code: ");
            Console.ReadLine();
            
            Console.Write("Enter second security code: ");
            Console.ReadLine();

            Console.WriteLine("\nVerifying credentials...");
            Console.ReadLine();
            Console.WriteLine("Access Granted!");
            Console.ReadLine();

            Console.WriteLine("\nAgent Information:");
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"Pretending to be: {student1.Pretend}");
            Console.WriteLine($"Age: {student1.Age}");
            Console.WriteLine($"Rank: {student1.Rank}");
            Console.WriteLine($"Location: {student1.Location}");

            //Console.WriteLine("\nTeacher Information:");
            //Console.WriteLine($"Name: {teacher1.Name}");
            //Console.WriteLine($"Age: {teacher1.Age}");
            //Console.WriteLine($"Subject: {teacher1.Subject}");
            //Console.WriteLine($"Experience: {teacher1.YearsExperience} years");
        }
    }
}
