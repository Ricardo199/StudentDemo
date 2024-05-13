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
            Student student= new Student();
            Console.WriteLine("Please enter your name ");
            student.Name= Console.ReadLine();
            Console.WriteLine("Please enter your id");
            student.Id= int.Parse(Console.ReadLine());
            student.SayHi();
            Console.ReadLine();
        }
    }
}
