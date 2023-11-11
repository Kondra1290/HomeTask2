using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        protected string name;
        protected int age;
        public Animal()
        {
            this.name = "Неизвестно";
            this.age = 0;
        }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Info()
        {
            Console.WriteLine("Информация о звере:");
            Console.WriteLine($"Имя: {name}\nВозрвст: {age}");
        }
        public virtual void makeNoise()
        {
            Console.Write("Зверь издает следующий звук: "); 
        }
    }
}
