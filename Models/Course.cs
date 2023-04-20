using StudentMagenement.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudentMagenement.Models
{
    internal class Course
    {
        private string _idCourse;
        public string IdCourse { get { return _idCourse; } set { this._idCourse = value; } }
        private string _nameCourse;
        public string NameCourse { get { return _nameCourse; } set { this._nameCourse = value; } }
        private int _credits;
        public int Credits { get { return _credits; } set { this._credits = value; } }
        private string _materials;
        public string Materials
        {
            get { return _materials; }
            set { this._materials = value; }
        }
        public List<ClassSection> classSectionList { get; set; }

        public ClassSection classSectionMain { get; set; }

        public Course()
        {
            this.classSectionList = new List<ClassSection>();
        }

        public void Input()
        {
            Console.WriteLine("Input Name Course: ");
            NameCourse = Console.ReadLine();

            Console.WriteLine("Input ID Course: ");
            IdCourse = Console.ReadLine();

            Console.WriteLine("Input Credits: ");
            Credits = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Materials: ");
            Materials = Console.ReadLine();

            classSectionMain = new ClassSection();
            classSectionMain.Input();
            classSectionList.Add(classSectionMain);
        }

        public void Display()
        {
            Console.WriteLine("IdCourse: {0}, NameCourse: {1}, Credits: {2}, Materials: {3}", IdCourse, NameCourse, Credits, Materials);
            classSectionMain = new ClassSection();
            foreach (ClassSection classSectionMain in classSectionList)
            {
                classSectionMain.Display();
            }
        }
    }
}
