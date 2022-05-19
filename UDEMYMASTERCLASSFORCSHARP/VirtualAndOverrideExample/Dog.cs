using System;
namespace UDEMYMASTERCLASSFORCSHARP.VirtualAndOverrideExample
{
    public class Dog : Animal
    {
        public bool isHappy { get; set; }

        public Dog(string animalName, int animalAge, bool isAnimalHungry) : base(animalName, animalAge, isAnimalHungry)
        {
            isHappy = true;
        }

        public override void MakeSound() 
        {
            Console.WriteLine("I AM A LOUD ASS DOG GOING RAWRRRRRRRRRRRRRRRRRR");
        }

        public override void Eat()
        {
           base.Eat();
        }
        
        
        
    }
}