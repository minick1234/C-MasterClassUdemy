using System;

namespace UDEMYMASTERCLASSFORCSHARP.AbstractExample
{
    public class AbstractMain
    {
        private static Cube c1 = new Cube(5, "Square");
        private static Cube c2 = new Cube(10, "Cube");

        private static Sphere s1 = new Sphere(3, "Sphere");
        private static Sphere s2 = new Sphere(6, "Circle");

        public static void main(string[] args)
        {
            if (c1 is Shapes)
            {
                Console.WriteLine("This is indeed true.");
            }

            c1.GetInfo();
            c2.GetInfo();
            s1.GetInfo();
            s2.GetInfo();
        }
    }
}