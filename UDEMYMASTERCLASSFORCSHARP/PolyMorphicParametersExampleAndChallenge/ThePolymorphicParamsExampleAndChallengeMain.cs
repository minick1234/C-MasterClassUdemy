using System;

namespace UDEMYMASTERCLASSFORCSHARP.PolyMorphicParametersExampleAndChallenge
{
    public class ThePolymorphicParamsExampleAndChallengeMain
    {
        public static void main(string[] args)
        {
            Car simpleCar = new Car("Blue", 250);
            Car simpleCar2 = new Car();


            AUDI a1 = new AUDI();
            AUDI a2 = new AUDI("Yellow", 999f);
            AUDI a3 = new AUDI("Red", 345.5f, "Audi Master Flow", "AUDI");
            AUDI a4 = new AUDI("AUDI DING", "AUDI");


            BMW b1 = new BMW();
            BMW b2 = new BMW("Blue", 500f, "BMW 55F", "BMW");
            BMW b3 = new BMW("Blue", 555f);
            BMW b4 = new BMW("BMW DADDIO", "BMW");


            Console.WriteLine("This is all the different CARS");
            simpleCar.Repair();
            simpleCar.ShowDetails();
            simpleCar2.Repair();
            simpleCar2.ShowDetails();

            Console.WriteLine("\n\nThis is all the different AUDI'S");
            a1.Repair();
            a1.ShowDetails();
            a2.Repair();
            a2.ShowDetails();
            a3.Repair();
            a3.ShowDetails();
            a4.Repair();
            a4.ShowDetails();


            Console.WriteLine("\n\nThis is all the different BMW'S");
            b1.Repair();
            b1.ShowDetails();
            b2.Repair();
            b2.ShowDetails();
            b3.Repair();
            b3.ShowDetails();
            b4.Repair();
            b4.ShowDetails();
        }
    }


    //The parent object where our specific vehicle models inherit from.
    public class Car
    {
        protected string _CarColour;
        protected float _CarHorsePower;

        public Car()
        {
            _CarColour = "White";
            _CarHorsePower = 500f;
        }


        public Car(string carColour, float carHorsePower)
        {
            _CarColour = carColour;
            _CarHorsePower = carHorsePower;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("The cars base colour is {0}, with a engine that has {1} horsepower!", _CarColour,
                _CarHorsePower);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car was repaired!");
        }
    }

    //a specific car that inherits from the main class of car.
    public class BMW : Car
    {
        private string _CarModel;
        private string _Brand;

        public BMW(string carColor, float horsePower) : base(carColor, horsePower)
        {
            _CarModel = "BMW M3";
            _Brand = "BMW";
        }

        public BMW(string carColour, float horsePower, string carModel, string carBrand) : base(carColour, horsePower)
        {
            _CarModel = carModel;
            _Brand = carBrand;
        }

        public BMW(string carModel, string carBrand) : base()
        {
            _CarModel = carModel;
            _Brand = carBrand;
        }


        public BMW() : base()
        {
            _CarModel = "BMW M3";
            _Brand = "BMW";
        }

        public override void ShowDetails()
        {
            Console.WriteLine(
                "The vehicle brand is {3} and The vehicle model is {2}, and the cars base colour is {0}, with a engine that has {1} horsepower!",
                _CarColour,
                _CarHorsePower, _CarModel, _Brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The brand {0}, car model {1} was repaired!", _Brand, _CarModel);
        }
    }

    //A specific car that inherits from the main class of car.
    public class AUDI : Car
    {
        private string _CarModel;
        private string _Brand;

        public AUDI(string carColor, float horsePower) : base(carColor, horsePower)
        {
            _CarModel = "AUDI A3";
            _Brand = "AUDI";
        }

        public AUDI(string carColour, float horsePower, string carModel, string carBrand) : base(carColour, horsePower)
        {
            _CarModel = carModel;
            _Brand = carBrand;
        }

        public AUDI(string carModel, string carBrand) : base()
        {
            _CarModel = carModel;
            _Brand = carBrand;
        }

        public AUDI() : base()
        {
            _CarModel = "AUDI A3";
            _Brand = "AUDI";
        }

        public override void ShowDetails()
        {
            Console.WriteLine(
                "The car Brand is {3} and The Vehicle Model is {2} and the cars base colour is {0}, with a engine that has {1} horsepower!",
                _CarColour,
                _CarHorsePower, _CarModel, _Brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The brand {0}, car model {1} was repaired!", _Brand, _CarModel);
        }
    }
}