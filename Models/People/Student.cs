using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMagenement.Models.People
{
    internal class Student : People
    {
        private float _score;
        public float Score
        {
            get { return _score; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Please input 0 - 10");
                }
                this._score = value;
            }
        }
        public Student() { }

        public Student(string iD, string fullName, int age, float score) : base(iD, fullName, age)
        {
            this.Score = score;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Input Scores: ");
            Score = float.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine("ID: {0}, FullName: {1}, Age: {2}, Scores: {3}", ID, FullName, Age, Score);
        }
    }
}
