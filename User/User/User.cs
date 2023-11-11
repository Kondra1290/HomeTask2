using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class User
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private int yearOfBirth;
        private int monthOfBirth;
        private int dayOfBirth;
        private string age;
        public User(string fname, string lname, int y, int m, int d)
        {
            Name = fname;
            LastName = lname;
            FullName = "Неизвестно";
            Year = y;
            Month = m;
            Day = d;
            Age = "Неизвестно";
        }
        public string Name
        {
            set {
                if (!value.Trim().Equals("")) firstName = value;
                else firstName = "Неизвестно";
            }
        }
        public string LastName
        {
            set { 
                if (!value.Trim().Equals("")) lastName = value;
                else lastName = "Неизвестно";
            }
        }
        private string FullName
        {
            set
            {
                if (firstName.Equals("Неизвестно") && lastName.Equals("Неизвестно")) fullName = value;
                else fullName = $"{firstName} {lastName}";
            }
        }
        public int Year
        {
            set { 
                if (value >= 1900 && value <= 2018) yearOfBirth = value;
                else yearOfBirth = 0;
            }
        }
        public int Month
        {
            set { 
                if (value >= 1 && value <= 12) monthOfBirth = value;
                else monthOfBirth = 0;
            }
        }
        public int Day
        {
            set { 
                if (value >= 1 && value <= 31) dayOfBirth = value; 
                else yearOfBirth = 0;
            }
        }
        private string Age
        {
            set {
                if (yearOfBirth != 0 && monthOfBirth != 0 && dayOfBirth != 0)
                {
                    DateTime date1 = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
                    DateTime date2 = DateTime.Now;
                    TimeSpan date = date2 - date1;

                    int y = (int)(date.TotalDays / 365);
                    int m = (int)(date.TotalDays - y * 365) / 31;
                    int d = (int)(date.TotalDays - y * 365 - m * 31);
                    age = $"{y.ToString()} {m.ToString()} {d.ToString()}";
                }
                else age = value; 
            }
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Полное имя:     {fullName}");
            Console.WriteLine($"Возраст:        {age}\n");
        }
    }
}
