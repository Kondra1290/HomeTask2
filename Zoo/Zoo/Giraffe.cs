using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Giraffe: Animal
    {
        public Giraffe() : base() { }
        public Giraffe(string name, int age) : base(name, age) { }
        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine("Звуки поедания листвы\n");
        }
        public override void Info()
        {
            Console.WriteLine("Зверь: жираф");
            base.Info();
        }
    }
}
