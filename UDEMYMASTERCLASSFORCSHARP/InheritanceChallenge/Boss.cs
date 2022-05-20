using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceChallenge
{
    public class Boss : Employee
    {
        protected string _CompanyCar { get; set; }

        public Boss()
        {
            this._CompanyCar = "GenericCar";
        }

        public Boss(string nameOfJob, string FirstName, float Salary, string companyCar) : base(nameOfJob, FirstName,
            Salary)
        {
            this._CompanyCar = companyCar;
        }
        
        

        public void Lead()
        {
            Console.WriteLine("I am currently leading my team and being an amazing boss with my {0} car.",
                this._CompanyCar);
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " I am also the boss and drive a {0} car", this._CompanyCar);
        }
    }
}