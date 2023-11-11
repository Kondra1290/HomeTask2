using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class LIon: Animal
    {
        public LIon(): base() { }
        public LIon(string name, int age): base(name, age) { }
        public override void makeNoise()
        {
            base.makeNoise();
            Console.WriteLine("РАААР\n");
        }
        public override void Info()
        {
            Console.WriteLine("Зверь: Лев");
            base.Info();
        }
    }
}
