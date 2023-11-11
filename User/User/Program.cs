using System;
using System.Net.Cache;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keypressed;
            User[] users = new User[8];
            users[0] = new User("Константин", "Григоренко", 2001, 12, 1);   // Кореектные данные
            users[1] = new User("Петр", "", 1995, 11, 2);                   // отсутсвеие фамилии
            users[2] = new User("", "Куклов", 1999, 9, 5);                  // нет имени
            users[3] = new User(" ", "  ", 1999, 9, 5);                     // нет ни имени ни фамилии
            users[4] = new User("Сергей", "Петрович", 1889, 6, 14);         // не корректный год
            users[5] = new User("Алексей", "Дикий", 2030, 4, 23);           // не корректный год
            users[6] = new User("Игорь", "Журавлев", 2004, 43, 2);          // не корректный месяц
            users[7] = new User("Антон", "Сухов", 1990, 9, 54);             // не корректный день

            foreach ( User user in users)
            {
                user.Print();
            }
        }
    }
}