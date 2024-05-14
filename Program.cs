using System;

namespace Animales
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Gato : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("El gato hace: Miau");
        }
    }

    class Perro : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("El perro hace: Guau");
        }
    }

    class Oso : Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("El oso hace: Grrr");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gato myGato = new Gato();
            myGato.animalSound();

            Perro myPerro = new Perro();
            myPerro.animalSound();

            Oso myOso = new Oso(); 
            myOso.animalSound();
        }
    }
}

