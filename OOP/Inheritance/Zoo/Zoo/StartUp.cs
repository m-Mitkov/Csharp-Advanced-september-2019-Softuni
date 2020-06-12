using System;
using Zoo.Mammals;
using Zoo.Reptiles;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal animal = new Reptile("Lizzrd");

            Animal mammal = new Mammal("bear");
            mammal = new Bear("bear");

            Console.WriteLine(mammal);
        }
    }
}
