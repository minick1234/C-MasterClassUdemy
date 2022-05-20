using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceChallenge
{
    public class Trainee : Employee
    {
        protected float _WorkingHours { get; set; }
        protected float _SchoolHours { get; set; }

        public Trainee()
        {
            this._SchoolHours = 10f;
            this._WorkingHours = 20f;
        }

        public Trainee(string nameOfJob, string Firstname, float salary, float workingHours, float schoolHours) : base(
            nameOfJob, Firstname, salary)
        {
            this._SchoolHours = schoolHours;
            this._WorkingHours = workingHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am currently learning at school for {0} hours", this._SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("I am currently working for {0} hours a week", this._WorkingHours);
        }

        public override string ToString()
        {
            return string.Format(
                base.ToString() +
                " I am also a student, working only {0} a week, and studying for {1} hours for school.",
                this._WorkingHours, this._SchoolHours);
        }
    }
}