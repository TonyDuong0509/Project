using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMagenement.Models.People
{
    internal class People
    {
        protected string ID { get; set; }
        public string FullName { get; set; }
        protected int Age { get; set; }

        public People() { }

        public People(string iD, string fullName, int age)
        {
            ID = iD;
            FullName = fullName;
            Age = age;
        }

        public virtual void Input()
        {
            Console.WriteLine("Input ID: ");
            ID = Console.ReadLine();

            Console.WriteLine("Input FullName: ");
            FullName = Console.ReadLine();

            Console.WriteLine("Input Age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("ID: {0}, FullName: {1}, Age: {2}", ID, FullName, Age);
        }
    }
}
