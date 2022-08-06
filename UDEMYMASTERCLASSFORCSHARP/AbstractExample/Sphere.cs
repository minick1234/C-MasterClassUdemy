using System;

namespace UDEMYMASTERCLASSFORCSHARP.AbstractExample
{
    public class Sphere : Shapes
    {
        public double Radius;
        public string Name;

        public Sphere(double radius, string name)
        {
            Radius = radius;
            Name = name;
        }

        //This is incase the person forgets to set the name of the cube.
        public Sphere(double radius)
        {
            Radius = radius;
            Name = "Default cube";
        }

        //This is for the idiots who forget to set the lengths and the name of the cube lool.
        public Sphere()
        {
            Radius = 5;
            Name = "Default cube";
        }

        public override void GetInfo()
        {
            //If i did this it would call the getinfo from the main class this derives from and also the stuff inside here.
            //base.GetInfo();
            Console.WriteLine($"This is a {Name}, and its volume is {Volume()}");
        }

        public override double Volume()
        {
            double PowerValue = Math.Pow(Radius, 3);
            double dividend = (double)4 / 3;

            return Math.PI * dividend * PowerValue;
        }
    }
}