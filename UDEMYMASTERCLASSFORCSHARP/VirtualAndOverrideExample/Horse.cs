using System;

namespace UDEMYMASTERCLASSFORCSHARP.VirtualAndOverrideExample
{
    public class Horse : Animal
    {
        public Horse(string animalName, int animalAge, bool isAnimalHungry) : base(animalName, animalAge,
            isAnimalHungry)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("I am a fucking horse and i go NEHHEWQHEQODWQIOHQEOQHEEEEE");
        }

        public override void Eat()
        {
            base.Eat();
        }
    }
}