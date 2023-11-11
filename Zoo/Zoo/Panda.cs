using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Panda : Animal
    {
        public Panda() : base() { }
        public Panda(string name, int age) : base(name, age) { }
        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine("Зввуки поедания бамбука\n");
        }
        public override void Info()
        {
            Console.WriteLine("Зверь: панда");
            base.Info();
        }
    }
}

