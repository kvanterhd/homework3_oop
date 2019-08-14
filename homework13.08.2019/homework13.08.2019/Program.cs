using System;

namespace homework13._08._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Human Human0_000_000_001 = new Human("Dmytro", "Timofeev", "25.01.2001");
            Abiturient Abit0_000_001 = new Abiturient("Petro", "Petrov", "15.11.1996", 200, 198, 179, 9.78);
            Student Stud0_000_001 = new Student("Mykola", "Bogatov", "17.02.1998", 4, "Tech33", "OOP", "Oxford");
            Teacher Teacher0_01 = new Teacher("Ivan", "Levchenko", "13.05.1985", "Lector", "Computer Technologies", "Oxford");
            Console.WriteLine(Abit0_000_001.GetInfo());
            Console.WriteLine(Human0_000_000_001.GetInfo());
            Console.WriteLine(Stud0_000_001.GetInfo());
            Console.WriteLine(Teacher0_01.GetInfo());

        }
        }
    }

