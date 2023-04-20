using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMagenement.Models.People
{
    internal class University
    {
        public List<Major> majorList { get; set; }

        public University()
        {
            majorList = new List<Major>();
        }

        // Case1: AddMajor
        public void AddMajor()
        {
            Console.WriteLine("Input quantities of Major: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Major major = new Major();
                major.Input();
                majorList.Add(major);
            }
        }

        // Case2: RemoveMajor
        public void RemoveMajor()
        {
            Console.WriteLine("Input ID of Major want to remove: ");
            string idMajor = Console.ReadLine();

            for (int i = 0; i < majorList.Count; i++)
            {
                if (majorList[i].IdMajor == idMajor)
                {
                    majorList.RemoveAt(i);
                    break;
                }
            }
        }

        // Case3: AddCourse
        public void AddCourse()
        {
            Console.WriteLine("Input ID of Major want to add Course: ");
            string idMajor = Console.ReadLine();

            foreach (Major major in majorList)
            {
                if (major.IdMajor == idMajor)
                {
                    major.AddCourse();
                    break;
                }
            }
        }

        // Case4: RemoveCourse
        public void RemoveCourse()
        {
            Console.WriteLine("Input ID of Major want to remove Course: ");
            string idMajor = Console.ReadLine();

            foreach (Major minor in majorList)
            {
                if (minor.IdMajor == idMajor)
                {
                    minor.RemoveCourse();
                    break;
                }
            }
        }

        // Case5: AddPeople
        public void AddPeople()
        {
            Console.WriteLine("Input ID of Major want to add People: ");
            string idMajor = Console.ReadLine();

            foreach (Major major in majorList)
            {
                if (major.IdMajor == idMajor)
                {
                    major.AddPeople();
                    break;
                }
            }
        }

        // Case6: RemovePeople
        public void RemovePeople()
        {
            Console.WriteLine("Input ID of Major want to remove People");
            string IdMajor = Console.ReadLine();
            bool isFind = false;
            foreach (Major major in majorList)
            {
                if (major.IdMajor == IdMajor)
                {
                    Console.WriteLine("Select people type: ");
                    Console.WriteLine("1. Student");
                    Console.WriteLine("2. Professor");
                    Console.WriteLine("Choose");
                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.WriteLine("Input FullName want to remove: ");
                        string fullName = Console.ReadLine();
                        isFind = true;
                        major.RemoveStudent(fullName);
                        break;
                    }
                    else if (choose == 2)
                    {
                        Console.WriteLine("Input FullName want to remove: ");
                        string fullName = Console.ReadLine();
                        isFind = true;
                        major.RemoveProfessor(fullName);
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine("This Major isn't exist !!!");
            }
        }

        // Case8: DisplayInformations
        public void DisplayInformations()
        {
            Console.WriteLine("Informations of Major: ");

            foreach (Major major in majorList)
            {
                major.Display();
            }
        }
    }
}
