namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample2
{
    public class Furniture
    {
        protected string color { get; set; }
        protected string material { get; set; }

        public Furniture(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        
        public Furniture()
        {
            this.material = "Leather";
            this.color = "brown";
        }
    }
}