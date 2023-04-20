using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentMagenement.Models.People
{
    internal class Major
    {
        private string _idMajor;
        public string IdMajor
        {
            get { return _idMajor; }
            set { this._idMajor = value; }
        }
        private string _nameMajor;
        public string NameMajor
        {
            get { return this._nameMajor; }
            set { this._nameMajor = value; }
        }
        public List<Course> courseList { get; set; }
        public List<Student> studenList { get; set; }
        public List<Professor> professorList { get; set; }

        public Major()
        {
            this.courseList = new List<Course>();
            this.studenList = new List<Student>();
            this.professorList = new List<Professor>();
        }

        public void Input()
        {
            Console.WriteLine("Input Name Major: ");
            NameMajor = Console.ReadLine();

            Console.WriteLine("Input ID Major: ");
            IdMajor = Console.ReadLine();
        }

        // AddCourse
        public void AddCourse()
        {
            Console.WriteLine("Input quantities of courses want to add: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Course course = new Course();
                course.Input();
                courseList.Add(course);
            }
        }

        // RemoveCourse
        public void RemoveCourse()
        {
            Console.WriteLine("Input ID of Course: ");
            string idCourse = Console.ReadLine();

            for (int i = 0; i < courseList.Count; i++)
            {
                if (courseList[i].IdCourse == idCourse)
                {
                    courseList.RemoveAt(i);
                    break;
                }
            }
        }

        // AddPeople
        public void AddPeople()
        {
            Console.WriteLine("Select people type: ");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Professor");
            Console.WriteLine("Choose");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Student student = new Student();
                student.Input();
                studenList.Add(student);
            }
            else if (choose == 2)
            {
                Professor professor = new Professor();
                professor.Input();
                professorList.Add(professor);
            }
        }

        // RemoveProfessor
        public void RemoveProfessor(string fullName)
        {

            for (int i = 0; i < professorList.Count; i++)
            {
                if (professorList[i].FullName == fullName)
                {
                    professorList.RemoveAt(i);
                    i--;
                }
            }

        }

        //RemoveStudent
        public void RemoveStudent(string fullName)
        {
            for (int i = 0; i < studenList.Count; i++)
            {
                if (studenList[i].FullName == fullName)
                {
                    studenList.RemoveAt(i);
                    i--;
                }
            }
        }

        // Case7: CompareScoreStudent
        public int CompareScoreStudent(Student student1, Student student2)
        {
            int resaultCompare = string.Compare(student1.Score.ToString(), student2.Score.ToString(), true);
            if (resaultCompare == 0)
            {
                if (student1.Score < student2.Score)
                    return -1;
                else if (student1.Score > student2.Score)
                    return 1;
                else return 0;
            }
            return resaultCompare;
        }

        public void Sort()
        {
            studenList.Sort(CompareScoreStudent);
        }

        // Display 
        public void Display()
        {
            Console.WriteLine("Information Courses and People of ID Major: {0} -  Name Major: {1}", IdMajor, NameMajor);

            foreach (Course course in courseList)
            {
                course.Display();
            }
            foreach (Student student in studenList)
            {
                student.Display();
            }
            foreach (Professor professor in professorList)
            {
                professor.Display();
            }
        }
    }
}
