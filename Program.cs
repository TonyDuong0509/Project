using StudentMagenement.Models.People;

namespace StudentMagenement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Major major = new Major();
            int choise;
            do
            {
                ShowMenu();
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        university.AddMajor();
                        break;
                    case 2:
                        university.RemoveMajor();
                        break;
                    case 3:
                        university.AddCourse();
                        break;
                    case 4:
                        university.RemoveCourse();
                        break;
                    case 5:
                        university.AddPeople();
                        break;
                    case 6:
                        university.RemovePeople();
                        break;
                    case 7:
                        major.Sort();
                        break;
                    case 8:
                        university.DisplayInformations();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Error !");
                        break;
                }
            } while (choise != 9);
            Console.Read();
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Add Major");
            Console.WriteLine("2. Remove Major");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. Remove Course");
            Console.WriteLine("5. Add People");
            Console.WriteLine("6. Remove People");
            Console.WriteLine("7. Student's Scores from high to low");
            Console.WriteLine("8. Display Information");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose");
        }
    }
}