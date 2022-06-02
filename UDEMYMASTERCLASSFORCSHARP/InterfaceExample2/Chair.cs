using System;
using System.Collections.Generic;


namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample2
{
    public class Chair : Furniture, IDestroyable
    {
        public string audioFile { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        public Chair(string color, string material)
        {
            this.color = color;
            this.material = material;
            audioFile = "BLAHExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }


        public void Destroy()
        {
            Console.WriteLine("Playing the destruction sound : {0}", audioFile);
            Console.WriteLine($"The {this.color} chair was destroyed.");
            Console.WriteLine("I am destroying the chair now.");
        }
    }
}