using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentMagenement.Models
{
    internal class ClassSection
    {
        private string _idClassSection;
        public string IdClassSection
        { get { return _idClassSection; } set { _idClassSection = value; } }

        public Course course { get; set; }
        public ClassSection() { }

        public void Input()
        {
            Console.WriteLine("Input IdClassSection: ");
            IdClassSection = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("IdClassSection: {0}", IdClassSection);
        }
    }
}
