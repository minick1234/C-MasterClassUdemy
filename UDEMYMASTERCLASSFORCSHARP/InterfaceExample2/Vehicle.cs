namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample2
{
    public class Vehicle
    {
        protected float speed { get; set; }
        protected string color { get; set; }

        public Vehicle()
        {
            this.color = "Blue";
            this.speed = 125f;
        }

        public Vehicle(string color, float speed)
        {
            this.color = color;
            this.speed = speed;
        }
    }
}