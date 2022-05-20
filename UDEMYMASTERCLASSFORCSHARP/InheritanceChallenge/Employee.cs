using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceChallenge
{
    public class Employee
    {
        protected string _nameOfJob { get; set; }
        protected string _FirstName { get; set; }
        protected float _Salary { get; set; }


        public Employee()
        {
            this._nameOfJob = "DefaultGuy";
            this._FirstName = "A generic First Name";
            this._Salary = 1.00f;
        }

        public Employee(string nameOfJob, string FirstName, float salary)
        {
            this._nameOfJob = nameOfJob;
            this._FirstName = FirstName;
            this._Salary = salary;
        }


        public virtual void Work()
        {
            Console.WriteLine("I am working my job for a {0} an hour salary", this._Salary);
        }

        public void PauseWork()
        {
            Console.WriteLine("I have decided i am going to pause my work and be a lazy ass");
        }

        public override string ToString()
        {
            return string.Format(
                "I am a {0}, and my first name is {1}, and currently i work for a salary of {2} an hour",
                this._nameOfJob, this._FirstName, this._Salary);
        }
    }
}