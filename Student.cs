using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    internal class Student
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Id cannot be less than one");
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public void SayHi() {
            Console.WriteLine($"Hi, my name is: {Name}, and my id is: {Id}.");
        }

    }
}
