using System;
using System.Security.Cryptography.X509Certificates;

namespace UDEMYMASTERCLASSFORCSHARP.VirtualAndOverrideExample
{
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool isHungry { get; set; }

        public Animal(string animalName, int animalAge, bool isAnimalHungry)
        {
            name = animalName;
            age = animalAge;
            isHungry = isAnimalHungry;
        }

        //The reason for the word virtual is to make sure we can override this method in classes that inherit from animal.
        public virtual void MakeSound()
        {
            Console.WriteLine("I am a general animal sound!");
        }

        //again another virtual method which can be overrided by other classes that derive from animal.
        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine($"{name} is eating his food.");
            }
            else if (!isHungry)
            {
                Console.WriteLine($"{name} is not really hungry right now!");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{name} is now playing, having a great ass time!");
        }
    }
}