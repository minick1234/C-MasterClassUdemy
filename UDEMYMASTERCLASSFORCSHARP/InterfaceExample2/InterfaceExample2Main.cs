namespace UDEMYMASTERCLASSFORCSHARP.InterfaceExample2
{
    public class InterfaceExample2Main
    {
        public static void main(string[] args)
        {
            Chair officeChair = new Chair("blue", "Leather");
            Chair GamingChair = new Chair("Red", "Leather");

            Car damagedCar = new Car(125f,"Red");
            
            
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(GamingChair);
            
            damagedCar.Destroy();



        }
    }
}