using System;
using System.Collections.Generic;
using System.Drawing;

namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample2
{
    public class Car : Vehicle, IDestroyable
    {
        public string audioFile { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.speed = speed;
            this.color = color;
            audioFile = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }


        public void Destroy()
        {
            Console.WriteLine("Playing the destruction sound : {0}", audioFile);
            Console.WriteLine("I am destroying the car now.");

            foreach (var destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}