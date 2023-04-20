using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace StudentMagenement.Models.People
{
    internal class Professor : People
    {
        public Professor()
        {
        }

        public Professor(string iD, string fullName, int age) : base(iD, fullName, age)
        {

        }
        public override void Input()
        {
            base.Input();
        }

        public override void Display()
        {
            base.Display();

        }
    }
}
