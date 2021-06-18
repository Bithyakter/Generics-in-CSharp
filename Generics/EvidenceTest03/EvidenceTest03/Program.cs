using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceTest03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behaviour of Animal\n=====================================");
            Animal human = new Animal { 
                Name = "Humans", 
                Age = 18, 
                Type = AnimalType.Mammals };

            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(human));

            Console.WriteLine("\n\nType Specific Behaviour of Animal\n=====================================");
            Animal parrot = new Animal { 
                Name = "Parrots", 
                Age = 9, 
                Type = AnimalType.Birds, 
                gender = Gender.Male };

            SpecificAnimal<Animal> obj2 = new SpecificAnimal<Animal>();
            Console.WriteLine(obj2.GetSpecificBehavior(parrot));

            Console.ReadKey();
        }

    }
}
