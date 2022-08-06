using System;
using System.Collections.Generic;


namespace UDEMYMASTERCLASSFORCSHARP.AbstractExample
{
    public abstract class Shapes
    {
        public string Name { get; set; }


        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        //This calculates the volume of the shape.
        //Since this is abstract this means we do not implement the body this is implemented by whatever derives this class.
        public abstract double Volume();
    }
}