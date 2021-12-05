using System;

namespace UDEMYMASTERCLASSFORCSHARP
{
    //Example of a getter and setter class being used with a main to display information and set it using the constructor.
    public class Box
    {
        private int _length;
        private int _width;
        private int _height;

        public Box(int length, int height, int width)
        {
            try
            {
                this.Height = height;
                this.Width = width;
                this.Length = length;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Box()
        {
            //This is left here empty on purpose because it is used if the user wants to make a empty value for each variable
        }

        //This is used to make sure that height is definitely not accesible purely as a variable to any other class and the only way to access it is using the getter and setter.
        //This means that we can now access the "variables" and edit them inside of any class that creates a instance of box.
        //The way this works is that if Box.Height is called we can either do a "=" sign after it and this will be the "set" part but if we just call box.Height thats using the get based on the value being returned.

        //Alternatively tho i dont know if its very resource friendly to call the method and do that when i can do the exact same functionality inside here without having a call to those extra methods.
        //Because this is the exact same thing as the setters and getters i made meaning the calls are pointless and i can make the code in here so its shorter and cleaner..

        //If i do this without using another variable for the current classes fgrontsurface as a member variable it makes this variable a readonly because it is using the getter only and cannot be set no matter what!!yhnhhjhjuja    QZDWGFXEV CRBTNRVYGHMJYM
        private int FrontSurface
        {
            get
            {
                return Height * Length;
            }
        }
        
        

        private int Length
        {
            get { return _length; }
            set { _length = CheckIfArguementIsValid(value); }
        }

        private int Height
        {
            get { return _height; }
            set { _height = CheckIfArguementIsValid(value); }
        }

        private int Width
        {
            get { return _width; }
            set { _width = CheckIfArguementIsValid(value); }
        }

        public int Volume
        {
            get { return Length * Width * Height; }
        }

        public int CheckIfArguementIsValid(int arguement)
        {
            if (arguement <= 0)
                throw new ArgumentException(
                    "One or more of the values is 0 or less. This is not valid.\n please make sure all values are greater than 0.");

            return arguement;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width {2} so the volume is {3}", Length, Height,
                Width, Volume);
            
            Console.WriteLine("The front surface of the shape based on the length of : {0} and the width of {1} is : {2}" , Length, Height, FrontSurface);
        }
    }

    // public class mainClassInBox
    // {
    //     public static void Main(string[] args)
    //     {
    //         var myBox = new Box(3, 5, 5);
    //         myBox.DisplayInfo();
    //     }
    // }
}