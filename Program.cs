using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    internal class Program
    {
        static void Main()
        {
            string name;
            int id;
            Console.WriteLine("Please enter your name ");
            name= Console.ReadLine();
            Console.WriteLine("Please enter your id");
            id= int.Parse(Console.ReadLine());
            Student student = new Student(id, name);
            student.SayHi();
            Console.ReadLine();
        }
    }
}
