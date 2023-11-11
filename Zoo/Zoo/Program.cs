namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new LIon("Lion", 10);
            animals[1] = new Giraffe("Graf", 4);
            animals[2] = new Panda("Po", 5);

            foreach(Animal animal in animals)
            {
                animal.Info();
                animal.makeNoise();
            }
        }
    }
}