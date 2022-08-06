using System;

namespace UDEMYMASTERCLASSFORCSHARP.AbstractExample
{
    public class Cube : Shapes
    {
        public double Length { get; set; }
        public string Name { get; set; }

        public Cube(double length, string name)
        {
            Length = length;
            Name = name;
        }

        //This is incase the person forgets to set the name of the cube.
        public Cube(double length)
        {
            Length = length;
            Name = "Default cube";
        }

        //This is for the idiots who forget to set the lengths and the name of the cube lool.
        public Cube()
        {
            Length = 5;
            Name = "Default cube";
        }


        //This is being implemented from the shapes
        //abstract class which now it needs me to define the body inmsde of here.
        public override double Volume()
        {
            return MathF.Pow((float)Length, 3);
        }

        public override void GetInfo()
        {
            //If i did this it would call the getinfo from the main class this derives from and also the stuff inside here.
            //base.GetInfo();
            Console.WriteLine($"This is a {Name} shape which has a volume of: {Volume()}");
        }
    }
}